Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class SalesReportViewer
    'Private _startDate As DateTime
    'Private _endDate As DateTime

    'Public Sub New(startDate As DateTime, endDate As DateTime)
    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Assign the date values
    '    _startDate = startDate
    '    _endDate = endDate
    'End Sub
    Private Sub SalesReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Load datasets
            Dim salesViewData As DataSet = SalesView()
            Dim transactionData As DataSet = SalesReport()
            Dim returnData As DataSet = SalesReturn()

            ' Null check for datasets
            If transactionData Is Nothing OrElse returnData Is Nothing Then
                MessageBox.Show("Failed to load one or more datasets.")
                Exit Sub
            End If

            ' Check if datasets have the expected tables
            If salesViewData.Tables.Contains("DT_SalesView") AndAlso transactionData.Tables.Contains("DT_SalesReport") AndAlso
           returnData.Tables.Contains("DT_ReturnsReport") Then

                ' Load the main report
                Dim reportDocument As New SalesRpt()
                reportDocument.SetDataSource(salesViewData.Tables("DT_SalesView"))

                Dim subreportSales = reportDocument.Subreports("Sales")
                subreportSales.SetDataSource(transactionData.Tables("DT_SalesReport"))

                ' Load subreport for returns
                Dim subreportReturn = reportDocument.Subreports("Returns") ' Ensure this matches the subreport name
                subreportReturn.SetDataSource(returnData.Tables("DT_ReturnsReport"))

                ' Pass parameters to the report
                'reportDocument.SetParameterValue("start_date", _startDate)
                'reportDocument.SetParameterValue("end_date", _endDate)

                ' Display the report
                CrystalReportViewer1.ReportSource = reportDocument
                CrystalReportViewer1.RefreshReport()
            Else
                MessageBox.Show("One or more required tables are missing from the datasets.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading report: {ex.Message}")
        End Try
    End Sub

    Private Function SalesView() As DataSet
        Dim dset As New DataSet
        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString)
                con.Open()
                Dim cmd As New SqlCommand("SELECT 
                                                COALESCE(SUM(t.total), 0) AS total_sales,
                                                COALESCE(SUM(r.total), 0) AS total_returns
                                            FROM tbltransactions t
                                            FULL JOIN tblreturns r ON t.id = r.transaction_id
                                            ", con)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset, "DT_SalesView")
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading sales view data: {ex.Message}")
        End Try
        Return dset
    End Function

    Private Function SalesReport() As DataSet
        Dim dset As New DataSet
        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString)
                con.Open()
                Dim cmd As New SqlCommand("SELECT 
                                                CONCAT(a.first_name, ' ', a.last_name) AS cashier,
                                                t.transaction_number,
                                                t.total,
                                                t.date,
                                                SUM(t.total) OVER () AS total_revenue,
                                                SUM(r.total) OVER () AS total_returns
                                            FROM tbltransactions t
                                            JOIN tblaccounts a ON t.account_id = a.id
                                            FULL JOIN tblreturns r ON t.id = r.transaction_id", con)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset, "DT_SalesReport")
                Return dset
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading sales report data: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Private Function SalesReturn() As DataSet
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
                                            JOIN tbltransactions t ON r.transaction_id = t.id", con)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset, "DT_ReturnsReport") ' Use a distinct table name
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading returns data: {ex.Message}")
        End Try
        Return dset
    End Function
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
End Class
