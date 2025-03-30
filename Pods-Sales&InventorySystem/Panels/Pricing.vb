Imports System.Data.SqlClient

Public Class Pricing
    Private Sub Pricing_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT 
                                        b.id, 
                                        a.product_name, 
                                        b.price, 
                                        b.cost_price
                                    FROM tblproducts a
                                    JOIN tbldeliveries_items b ON a.id = b.product_id
                                    WHERE b.inventory_quantity != 0
                                    AND b.id = (SELECT MAX(b2.id) FROM tbldeliveries_items b2 WHERE b2.product_id = b.product_id)
                                    ORDER BY b.id DESC;", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            PricingDataGridView.DataSource = dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class
