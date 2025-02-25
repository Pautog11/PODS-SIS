Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FinancialReportViewer
    Private _startDate As DateTime
    Private _endDate As DateTime

    '' Constructor to accept the date range for filtering
    Public Sub New(startDate As DateTime, endDate As DateTime)
        InitializeComponent()
        _startDate = startDate
        _endDate = endDate
    End Sub
    Private Sub FinancialReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim financialViewData As DataSet = FinancialReportView(_startDate, _endDate)

            If financialViewData Is Nothing Then
                MessageBox.Show("Failed to load one or more datasets.")
                Exit Sub
            End If

            ' Check if datasets have the expected tables
            If financialViewData.Tables.Contains("DT_FinancialReport") Then

                Dim reportDocument As New FinancialRpt()
                reportDocument.SetDataSource(financialViewData.Tables("DT_FinancialReport"))

                CrystalReportViewer1.ReportSource = reportDocument
                CrystalReportViewer1.RefreshReport()
            Else
                MessageBox.Show("One or more required tables are missing from the datasets.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading report: {ex.Message}")
        End Try
    End Sub
    Private Function FinancialReportView(startDate As DateTime, endDate As DateTime) As DataSet
        Dim dset As New DataSet

        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString)
                con.Open()
                'Dim cmd As New SqlCommand("SELECT @startDate as start_date, @endDate as end_date, 
                '                                  th.transaction_number,
                '                                  CONCAT(ac.first_name, ' ', ac.last_name) AS cashier,
                '                                  SUM((ti.price - di.cost_price) * ti.quantity) AS revenue,
                '                                  SUM(ti.total) AS total,
                '                                  th.date,
                '                                  SUM(SUM((ti.price - di.cost_price) * ti.quantity)) OVER () AS total_revenue
                '                                FROM tbldeliveries_items di
                '                                JOIN tbltransaction_items ti ON di.id = ti.delivery_id
                '                                JOIN tbltransactions th ON ti.transaction_id = th.id
                '                                JOIN tblaccounts ac ON th.account_id = ac.id
                '                                WHERE th.date BETWEEN @startDate AND @endDate 
                '                                GROUP BY s
                '                                  th.transaction_number, 
                '                                  CONCAT(ac.first_name, ' ', ac.last_name), 
                '                                  th.date", con)
                'Dim cmd As New SqlCommand("WITH
                '                            Panuway AS (
                '                                SELECT transaction_id AS id, price,
                '                          product_id
                '                                FROM tbltransaction_items 
                '                                --WHERE transaction_id = @id
                '                            ),
                '                            Dipota AS (
                '                                SELECT transaction_id AS id, cost , quantity
                '                                FROM getrev 
                '                                --WHERE transaction_id = @id and quantity !=0
                '                            ),
                '                         Magic as (
                '                          SELECT a.id, product_id, price, a.cost, a.quantity, sum(price * a.quantity) as total, sum(a.cost * a.quantity) as kapital
                '                          FROM Dipota a
                '                          JOIN Panuway b ON a.id = b.id
                '                          group by a.id, product_id, price, a.cost, a.quantity
                '                         ),
                '                         Tite as (
                '                         Select id, product_id, price, cost, quantity, total, kapital, sum(total - kapital) as tubo from Magic
                '                         group by id, product_id, price, cost, quantity, total, kapital
                '                         )
                '                        select b.id, b.transaction_number, sum(a.total) as total, b.date, b.account_id, sum(a.tubo) as Revenue from Tite a left join tbltransactions b on a.id = b.id
                '                        group by b.id, b.transaction_number, b.date, b.account_id", con)


                Dim cmd As New SqlCommand("select id, NAME as cashier, [TRANSACTION NUMBER] as transaction_number, CAPITAL, REVENUE, TOTAL, date
                                            from viewtblrevenue

                                            union all

                                            select a.id, 
                                                   b.first_name as cashier, -- Assuming you want one value per id (adjust as needed)
                                                   c.transaction_number, 
	                                               NULL as CAPITAL,
	                                               NULL as REVENUE,
                                                   -1 * a.total, 
                                                   a.date
                                            from tblreturns a
                                            join tblaccounts b on a.account_id = b.id
                                            join tbltransactions c on a.transaction_id = c.id
                                            order by transaction_number, total desc, date", con)
                'cmd.Parameters.AddWithValue("@startDate", startDate)
                'cmd.Parameters.AddWithValue("@endDate", endDate)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset, "DT_FinancialReport")
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading financial report data: {ex.Message}")
        End Try
        Return dset
    End Function
End Class
