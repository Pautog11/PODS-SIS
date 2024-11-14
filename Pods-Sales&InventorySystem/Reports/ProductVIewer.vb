Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms

Public Class ProductVIewer
    Private Sub ProductVIewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim src As New ReportDataSource("DS_Products", Products.Tables("DT_Products"))
        ReportViewer1.LocalReport.ReportPath = "C:\Users\Christian\Desktop\PODS-SIS\Pods-Sales&InventorySystem\Reports\Products.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(src)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Function Products() As DSReport
        Dim dset As New DSReport
        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString1)
                con.Open()
                Dim cmd As New SqlCommand("SELECT sc.subcategory, p.product_name product, p.barcode, p.product_price price, p.stock_level 
                                            FROM tblProducts p
                                            JOIN tblsubcategories sc ON sc.id = p.subcategory_id", con)
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset.Tables("DT_Products"))
                Return dset
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
