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
                Dim cmd As New SqlCommand("SELECT  @startDate as start_date, @endDate as end_date, 
	                                               th.transaction_number,
	                                               CONCAT(ac.first_name, ' ', ac.last_name) cashier,
	                                               SUM(ti.price - di.cost_price) * SUM(ti.quantity) revenue,
	                                               SUM(ti.total) total,
	                                               th.date,
												   SUM(SUM(ti.price - di.cost_price) * SUM(ti.quantity)) OVER () AS total_revenue
                                            FROM tbldeliveries_items di
                                            JOIN tbltransaction_items ti ON di.id = ti.delivery_id
                                            JOIN tbltransactions th ON ti.transaction_id = th.id
                                            JOIN tblaccounts ac ON th.account_id = ac.id
                                            WHERE th.date BETWEEN @startDate AND @endDate 
                                            GROUP BY th.transaction_number, ac.first_name, ac.last_name, th.date", con)
                cmd.Parameters.AddWithValue("@startDate", startDate)
                cmd.Parameters.AddWithValue("@endDate", endDate)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset, "DT_FinancialReport")
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading financial report data: {ex.Message}")
        End Try
        Return dset
    End Function
End Class
