Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class InventoryReportsViewer
    Private Sub InventoryReportsViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim InventoryData As DataSet = InventoryReports()
        Dim reportDocument As New InventoryReports()
        reportDocument.SetDataSource(InventoryData.Tables("DT_Inventory"))

        CrystalReportViewer1.ReportSource = reportDocument
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Function InventoryReports()
        Try
            Dim dset As New DataSet
            Using con As SqlConnection = SqlConnectionPods.GetInstance
                Dim cmd As New SqlCommand("SELECT a.sku AS SKU, 
                                                  a.barcode AS BARCODE, 
                                                  a.product_name AS PRODUCT, 
                                                  b.price AS PRICE, 
                                                  b.cost_price AS 'COST PRICE', 
                                                  SUM(b.inventory_quantity) AS QUANTITY
                                            FROM tblproducts a
                                            JOIN tbldeliveries_items b on a.id = b.product_id
											GROUP BY  a.sku,
											      a.barcode, 
                                                  a.product_name, 
                                                  b.price, 
                                                  b.cost_price", con)
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset, "DT_Inventory")
                Return dset
            End Using
        Catch ex As Exception
            Return New DataSet
        End Try
    End Function
End Class
