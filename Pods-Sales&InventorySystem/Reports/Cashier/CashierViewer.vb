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
                Dim cmd As New SqlCommand("SELECT sc.subcategory, p.product_name product, p.barcode, p.product_price price, p.stock_level, p.quantity stocks 
                                            FROM tblProducts p
                                            JOIN tblsubcategories sc ON sc.id = p.subcategory_id", con)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset, "DT_Products")
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading inventory data: {ex.Message}")
        End Try
        Return dset
    End Function
End Class
