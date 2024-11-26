Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class SalesReportViewer
    Private _startDate As DateTime
    Private _endDate As DateTime

    '' Constructor to accept the date range for filtering
    Public Sub New(startDate As DateTime, endDate As DateTime)
        InitializeComponent()
        _startDate = startDate
        _endDate = endDate
    End Sub

    Private Sub SalesReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Load datasets with date filters
            Dim salesViewData As DataSet = SalesView(_startDate, _endDate)
            Dim transactionData As DataSet = SalesReport(_startDate, _endDate)
            Dim returnData As DataSet = SalesReturn(_startDate, _endDate)
            'Dim salesViewData As DataSet = SalesView()
            'Dim transactionData As DataSet = SalesReport()
            'Dim returnData As DataSet = SalesReturn()

            If salesViewData Is Nothing OrElse transactionData Is Nothing OrElse returnData Is Nothing Then
                MessageBox.Show("Failed to load one or more datasets.")
                Exit Sub
            End If

            ' Check if datasets have the expected tables
            If salesViewData.Tables.Contains("DT_SalesView") AndAlso
                transactionData.Tables.Contains("DT_SalesReport") AndAlso
                returnData.Tables.Contains("DT_ReturnsReport") Then

                Dim reportDocument As New SalesRpt()
                reportDocument.SetDataSource(salesViewData.Tables("DT_SalesView"))

                Dim subreportSales = reportDocument.Subreports("Sales")
                subreportSales.SetDataSource(transactionData.Tables("DT_SalesReport"))

                Dim subreportReturn = reportDocument.Subreports("Returns")
                subreportReturn.SetDataSource(returnData.Tables("DT_ReturnsReport"))

                CrystalReportViewer1.ReportSource = reportDocument
                CrystalReportViewer1.RefreshReport()
            Else
                MessageBox.Show("One or more required tables are missing from the datasets.")
            End If
        Catch ex As Exception
        MessageBox.Show($"Error loading report: {ex.Message}")
        End Try
    End Sub

    ' Fetch sales view data based on date range
    Private Function SalesView(startDate As DateTime, endDate As DateTime) As DataSet
        Dim dset As New DataSet

        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString)
                con.Open()
                Dim cmd As New SqlCommand("SELECT @startDate as start_date, @endDate as end_date,
                                                COALESCE(SUM(t.total), 0) AS total_sales,
                                                COALESCE(SUM(r.total), 0) AS total_returns
                                            FROM tbltransactions t
                                            FULL JOIN tblreturns r ON t.id = r.transaction_id
                                            WHERE t.date BETWEEN @startDate AND @endDate", con)
                'WHERE t.date BETWEEN @startDate AND @endDate", con)
                cmd.Parameters.AddWithValue("@startDate", startDate)
                cmd.Parameters.AddWithValue("@endDate", endDate)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset, "DT_SalesView")
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading sales view data: {ex.Message}")
        End Try
        Return dset
    End Function

    ' Fetch sales report data based on date range
    Private Function SalesReport(startDate As DateTime, endDate As DateTime) As DataSet
        Dim dset As New DataSet
        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString)
                con.Open()
                Dim cmd As New SqlCommand("SELECT 
                                            CONCAT(a.first_name, ' ', a.last_name) AS cashier,
                                            t.transaction_number,
                                            t.total,
                                            t.date,
                                            SUM(t.total) OVER () AS total_revenue
                                        FROM tbltransactions t
                                        JOIN tblaccounts a ON t.account_id = a.id
                                        WHERE t.date BETWEEN @startDate AND @endDate", con)
                '                        WHERE t.date BETWEEN @startDate AND @endDate", con)
                cmd.Parameters.AddWithValue("@startDate", startDate)
                cmd.Parameters.AddWithValue("@endDate", endDate)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset, "DT_SalesReport")
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading sales report data: {ex.Message}")
        End Try
        Return dset
    End Function

    ' Fetch sales return data based on date range
    Private Function SalesReturn(startDate As DateTime, endDate As DateTime) As DataSet
        Dim dset As New DataSet
        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString)
                con.Open()
                Dim cmd As New SqlCommand("SELECT 
                                            CONCAT(a.first_name, ' ', a.last_name) AS cashier,
                                            t.transaction_number,
                                            r.total,
                                            r.date,
                                            SUM(r.total) OVER () AS total_return
                                        FROM tblreturns r
                                        JOIN tblaccounts a ON r.account_id = a.id
                                        JOIN tbltransactions t ON r.transaction_id = t.id
                                        WHERE r.date BETWEEN @startDate AND @endDate", con)
                '                        WHERE r.date BETWEEN @startDate AND @endDate", con)
                cmd.Parameters.AddWithValue("@startDate", startDate)
                cmd.Parameters.AddWithValue("@endDate", endDate)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset, "DT_ReturnsReport")
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading returns data: {ex.Message}")
        End Try
        Return dset
    End Function
End Class


'Private Function SalesView(startDate As DateTime, endDate As DateTime) As DataSet
'    Dim dset As New DataSet
'    Try
'        Using con As New SqlConnection(My.Settings.podsdbConnectionString)
'            con.Open()
'            Dim cmd As New SqlCommand("SELECT 
'                                            COALESCE(SUM(t.total), 0) AS total_sales,
'                                            COALESCE(SUM(r.total), 0) AS total_return
'                                        FROM tbltransactions t
'                                        FULL JOIN tblreturns r ON t.id = r.transaction_id
'                                        WHERE 
'                                            (t.date BETWEEN @start_date AND @end_date OR t.date IS NULL)
'                                            AND (r.date BETWEEN @start_date AND @end_date OR r.date IS NULL)", con)

'            cmd.Parameters.AddWithValue("@start_date", startDate)
'            cmd.Parameters.AddWithValue("@end_date", endDate)

'            Dim adapter As New SqlDataAdapter(cmd)
'            adapter.Fill(dset, "DT_SalesView")
'        End Using
'    Catch ex As Exception
'        MessageBox.Show($"Error loading sales view data: {ex.Message}")
'    End Try
'    Return dset
'End Function