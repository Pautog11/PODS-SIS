Imports System.Windows.Forms

Public Class PullOutCartDialog
    Private Sub PullOutCartDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = BaseSupplier.Fetchsupplier_allow_refund()
        SupplierNameComboBox.DataSource = dt
        SupplierNameComboBox.DisplayMember = "name"
        SupplierNameComboBox.ValueMember = "id"

        If dt.Rows.Count > 0 Then
            SupplierNameComboBox.SelectedIndex = -1
        End If
    End Sub

    Private Sub AddProduct_Click(sender As Object, e As EventArgs) Handles AddProduct.Click
        Try
            If SupplierNameComboBox.Text = "" Then
                MessageBox.Show("Please select a supplier first!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SupplierNameComboBox.BorderColor = Color.Red
                Exit Sub
            End If

            If VendorComboBox.Text = "" Then
                MessageBox.Show("Please select a vendor first!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                VendorComboBox.BorderColor = Color.Red
                Exit Sub
            End If

            Dim data As New Dictionary(Of String, String) From {
                {"id", SupplierNameComboBox.SelectedItem("ID")}
            }
            Dim dialog As New PullOutProductDialog(data:=data, parent:=Me)
            dialog.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SupplierNameComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SupplierNameComboBox.SelectionChangeCommitted
        Try
            SupplierNameComboBox.BorderColor = Color.Gray

            Dim dt As DataTable = BaseVendor.GetVendorBySupplierId(SupplierNameComboBox.SelectedItem("ID"))
            VendorComboBox.DataSource = dt.DefaultView
            VendorComboBox.DisplayMember = "name"
            VendorComboBox.SelectedItem = "id"
            If dt.Rows.Count > 0 Then
                VendorComboBox.SelectedIndex = -1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeliveryPulloutDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DeliveryPulloutDataGridView.CellClick
        Try
            If DeliveryPulloutDataGridView.Rows.Count > 0 Then
                Dim row As DataGridViewRow = DeliveryPulloutDataGridView.SelectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                    {"id", If(row.Cells(0).Value?.ToString(), "0")},
                    {"name", If(row.Cells(1).Value?.ToString(), "")},
                    {"date", If(row.Cells(2).Value?.ToString(), "")},
                    {"batch_number", If(row.Cells(3).Value?.ToString(), "")},
                    {"selling_price", If(row.Cells(4).Value?.ToString(), "0")},
                    {"cost_price", If(row.Cells(5).Value?.ToString(), "0")},
                    {"quantity", If(row.Cells(6).Value?.ToString(), "0")},
                    {"target", If(row.Cells(8).Value?.ToString(), "0")}
                }
                Dim dialog As New PullOutProductDialog(data:=data, parent:=Me)
                dialog.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
