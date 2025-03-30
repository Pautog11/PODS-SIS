Imports System.Windows.Forms

Public Class ReturnInventoryDialog
    'Private _id As Integer?
    'Public Sub New(Optional id As Integer = Nothing)
    '    InitializeComponent()
    '    _id = id
    'End Sub

    'Private Sub ReturnInventoryDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Try
    '        If _id IsNot Nothing Then
    '            Dim dt As DataTable = BaseReturn.SelectAllReturnedByID(_id)
    '            If dt.Rows.Count > 0 Then
    '                ProductComboBox.DataSource = dt.DefaultView
    '                ProductComboBox.DisplayMember = ("product_name")
    '                If dt.Rows.Count > 0 Then
    '                    ProductComboBox.SelectedIndex = -1
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub ProductComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ProductComboBox.SelectionChangeCommitted
    '    Try
    '        If ProductComboBox.SelectedIndex >= 0 Then
    '            Dim selectedRow As DataRowView = DirectCast(ProductComboBox.SelectedItem, DataRowView)
    '            StocksTextBox.Text = If(selectedRow("quantity_remaining") Is DBNull.Value, "", selectedRow("quantity_remaining").ToString())

    '            If BaseDelivery.EnableExp(If(selectedRow("product_id") Is DBNull.Value, "", selectedRow("product_id").ToString())) = 0 Then
    '                Guna2DateTimePicker1.Enabled = False
    '            Else
    '                Guna2DateTimePicker1.Enabled = True
    '            End If

    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub PullOutProductSaveButton_Click(sender As Object, e As EventArgs) Handles PullOutProductSaveButton.Click

    'End Sub
End Class
