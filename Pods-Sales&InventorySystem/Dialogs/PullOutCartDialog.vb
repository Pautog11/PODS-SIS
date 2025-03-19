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

            Dim dialog As New PullOutProductDialog
            dialog.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SupplierNameComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SupplierNameComboBox.SelectionChangeCommitted
        SupplierNameComboBox.BorderColor = Color.Gray
        'MsgBox("hellp")
        'SupplierNameComboBox.SelectedItem("ID")
        MsgBox(SupplierNameComboBox.SelectedItem("ID"))
    End Sub
End Class
