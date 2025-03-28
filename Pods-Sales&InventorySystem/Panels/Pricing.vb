Imports System.Data.SqlClient

Public Class Pricing
    Private Sub Pricing_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("select product_name, price, cost_price from tblproducts a
                                    join tbldeliveries_items b on a.id = b.product_id where inventory_quantity != 0
                                    group by product_name, price, cost_price", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            PricingDataGridView.DataSource = dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class
