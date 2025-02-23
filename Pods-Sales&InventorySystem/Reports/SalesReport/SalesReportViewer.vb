Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class SalesReportViewer
    Private _startDate As DateTime
    Private _endDate As DateTime

    Public Sub New(Optional startDate As DateTime = Nothing,
                   Optional endDate As DateTime = Nothing)
        InitializeComponent()
        _startDate = startDate
        _endDate = endDate
    End Sub

    Private Sub SalesReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Load datasets with date filters
            Dim salesViewData As DataSet = SalesView(_startDate, _endDate)
            Dim transactionData As DataSet = SalesReport(_startDate, _endDate)
            'Dim returnData As DataSet = SalesReturn(_startDate, _endDate)
            'Dim salesViewData As DataSet = SalesView()
            'Dim transactionData As DataSet = SalesReport()
            'Dim returnData As DataSet = SalesReturn()

            If salesViewData Is Nothing OrElse transactionData Is Nothing Then 'OrElse returnData Is Nothing Then
                MessageBox.Show("Failed to load one or more datasets.")
                Exit Sub
            End If

            ' Check if datasets have the expected tables
            If salesViewData.Tables.Contains("DT_SalesView") AndAlso transactionData.Tables.Contains("DT_SalesReport") Then 'AndAlso returnData.Tables.Contains("DT_ReturnsReport") Then

                Dim reportDocument As New SalesRpt()
                reportDocument.SetDataSource(salesViewData.Tables("DT_SalesView"))

                Dim subreportSales = reportDocument.Subreports("Sales")
                subreportSales.SetDataSource(transactionData.Tables("DT_SalesReport"))

                'Dim subreportReturn = reportDocument.Subreports("Returns")
                'subreportReturn.SetDataSource(returnData.Tables("DT_ReturnsReport"))

                CrystalReportViewer1.ReportSource = reportDocument
                CrystalReportViewer1.RefreshReport()
            Else
                MessageBox.Show("One or more required tables are missing from the datasets.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Function SalesView(startDate As DateTime, endDate As DateTime) As DataSet
        Dim dset As New DataSet

        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString)
                con.Open()
                'Dim cmd As New SqlCommand("SELECT @startDate as start_date, @endDate as end_date,
                '                                COALESCE(SUM(t.total), 0) AS total_sales,
                '                                COALESCE(SUM(r.total), 0) AS total_returns,
                '                                COALESCE(SUM(t.total), 0) - COALESCE(SUM(r.total), 0) AS overall_total
                '                            FROM tbltransactions t
                '                            FULL JOIN tblreturns r ON t.id = r.transaction_id
                '                            WHERE t.date BETWEEN @startDate AND @endDate", con)
                Dim cmd As New SqlCommand("WITH 
                                            Sales AS (
                                                SELECT 
                                                    id, 
                                                    SUM(total) AS benta 
                                                FROM tbltransactions t 
                                                WHERE CAST(t.date AS DATE) >= @startDate 
                                                  AND CAST(t.date AS DATE) <= @endDate
                                                GROUP BY id
                                            ),
                                            Balik AS (
                                                SELECT 
                                                    transaction_id, 
                                                    SUM(a.total) AS balick 
                                                FROM tblreturns a 
                                                WHERE CAST(a.date AS DATE) >= @startDate
                                                  AND CAST(a.date AS DATE) <= @endDate
                                                GROUP BY transaction_id
                                            )
                                        SELECT @startDate AS start_date, 
                                               @endDate AS end_date,
                                               SUM(a.benta) AS total_sales, 
                                               SUM(b.balick) AS total_returns, 
                                               SUM(benta - COALESCE(balick, 0)) AS overall_total 
                                        FROM Sales a 
                                        FULL JOIN Balik b ON a.id = b.transaction_id;", con)
                'WHERE t.date BETWEEN @startDate AND @endDate", con)
                cmd.Parameters.AddWithValue("@startDate", startDate)
                cmd.Parameters.AddWithValue("@endDate", endDate)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset, "DT_SalesView")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return dset
    End Function

    Private Function SalesReport(startDate As DateTime, endDate As DateTime) As DataSet
        Dim dset As New DataSet
        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString)
                con.Open()
                'Dim cmd As New SqlCommand("SELECT 
                '                            CONCAT(a.first_name, ' ', a.last_name) AS cashier,
                '                            t.transaction_number,
                '                            t.total,
                '                            t.date,
                '                            SUM(t.total) OVER () AS total_revenue
                '                        FROM tbltransactions t
                '                        JOIN tblaccounts a ON t.account_id = a.id
                '                        WHERE t.date BETWEEN @startDate AND @endDate", con)


                Dim cmd As New SqlCommand("SELECT a.id, 
                                                  CONCAT(first_name, ' ', last_name) AS cashier, 
                                                  transaction_number, 
                                                  total, 
                                                  a.date
                                           FROM tbltransactions a 
                                           JOIN tblaccounts b ON a.account_id = b.id 
                                           WHERE CAST(a.date AS DATE) >= @startDate
                                           AND CAST(a.date AS DATE) <= @endDate
   
                                           UNION ALL
 
                                          SELECT a.transaction_id, 
                                                 CONCAT(first_name, ' ', last_name) AS cashier, 
                                                 transaction_number, 
                                                 -1 * a.total, a.date
                                          FROM tblreturns a
                                          JOIN tbltransactions b ON a.transaction_id = b.id
                                          JOIN tblaccounts c ON a.account_id = c.id
                                          WHERE a.transaction_id IN (SELECT id FROM tbltransactions) 
                                                AND CAST(a.date AS DATE) >= @startDate
                                                AND CAST(a.date AS DATE) <= @endDate
                                          ORDER BY transaction_number, 
                                                   total DESC;", con)
                cmd.Parameters.AddWithValue("@startDate", startDate)
                cmd.Parameters.AddWithValue("@endDate", endDate)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset, "DT_SalesReport")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return dset
    End Function

    ' Fetch sales return data based on date range
    'Private Function SalesReturn(startDate As DateTime, endDate As DateTime) As DataSet
    '    Dim dset As New DataSet
    '    Try
    '        Using con As New SqlConnection(My.Settings.podsdbConnectionString)
    '            con.Open()
    '            Dim cmd As New SqlCommand("SELECT 
    '                                        CONCAT(a.first_name, ' ', a.last_name) AS cashier,
    '                                        t.transaction_number,
    '                                        r.total,
    '                                        r.date,
    '                                        SUM(r.total) OVER () AS total_return
    '                                    FROM tblreturns r
    '                                    JOIN tblaccounts a ON r.account_id = a.id
    '                                    JOIN tbltransactions t ON r.transaction_id = t.id
    '                                    WHERE r.date BETWEEN @startDate AND @endDate", con)
    '            '                        WHERE r.date BETWEEN @startDate AND @endDate", con)
    '            cmd.Parameters.AddWithValue("@startDate", startDate)
    '            cmd.Parameters.AddWithValue("@endDate", endDate)

    '            Dim adapter As New SqlDataAdapter(cmd)
    '            adapter.Fill(dset, "DT_ReturnsReport")
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show($"Error loading returns data: {ex.Message}")
    '    End Try
    '    Return dset
    'End Function
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