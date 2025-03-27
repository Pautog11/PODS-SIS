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
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Function FinancialReportView(startDate As DateTime, endDate As DateTime) As DataSet
        Dim dset As New DataSet

        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString)
                con.Open()
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
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return dset
    End Function
End Class
