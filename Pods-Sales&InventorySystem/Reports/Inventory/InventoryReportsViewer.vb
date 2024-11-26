Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class InventoryReportsViewer
    Private Sub InventoryReportsViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim InventoryData As DataSet = InventoryReports()
        Dim reportDocument As New InventoryReports()
        reportDocument.SetDataSource(InventoryData.Tables("DT_Products"))

        CrystalReportViewer1.ReportSource = reportDocument
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Function InventoryReports()
        Dim dset As New DataSet

        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString)
                con.Open()
                Dim cmd As New SqlCommand("SELECT sc.subcategory, p.product_name product, p.barcode, p.price, p.stock_level, p.quantity stocks 
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
