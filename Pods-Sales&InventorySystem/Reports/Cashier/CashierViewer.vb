Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class CashierViewer
    Private Sub CashierViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CashierData As DataSet = Cashier()
        Dim reportDocument As New SalesRpt()
        reportDocument.SetDataSource(CashierData.Tables("DT_Products"))

        CrystalReportViewer1.ReportSource = reportDocument
        CrystalReportViewer1.RefreshReport()
    End Sub
    Private Function Cashier()
        Dim dset As New DataSet

        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString)
                con.Open()
                Dim cmd As New SqlCommand("SELECT
                                                CONCAT(a.first_name, ' ', a.last_name) AS cashier,
                                                t.transaction_number,
                                                t.total,
                                                t.date
                                                FROM tbltransactions t
                                                JOIN tblaccounts a ON t.account_id = a.id
                                                FULL JOIN tblreturns r ON t.id = r.transaction_id
                                                WHERE a.ID = '1'
                                                ORDER BY t.date ASC", con)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset, "DT_Products")
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading inventory data: {ex.Message}")
        End Try
        Return dset
    End Function
End Class
