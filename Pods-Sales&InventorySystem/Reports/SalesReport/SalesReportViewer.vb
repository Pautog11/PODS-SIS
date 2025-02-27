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
            Dim salesViewData As DataSet = SalesView(_startDate, _endDate)
            Dim transactionData As DataSet = SalesReport(_startDate, _endDate)

            If salesViewData Is Nothing OrElse transactionData Is Nothing Then
                MessageBox.Show("Failed to load one or more datasets.")
                Exit Sub
            End If

            If salesViewData.Tables.Contains("DT_SalesView") AndAlso transactionData.Tables.Contains("DT_SalesReport") Then

                Dim reportDocument As New SalesRpt()
                reportDocument.SetDataSource(salesViewData.Tables("DT_SalesView"))

                Dim subreportSales = reportDocument.Subreports("Sales")
                subreportSales.SetDataSource(transactionData.Tables("DT_SalesReport"))

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
End Class