﻿Public Class Product
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblproductsTableAdapter
    Private _dataTable As New pods.viewtblproductsDataTable
    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        _tableAapter.Fill(_dataTable)
        ProductsDataGridView.DataSource = _dataTable
        ProductsDataGridView.Columns.Item("ID").Visible = False
        ProductsDataGridView.Columns.Item("QUANTITY").Visible = False
        ProductsDataGridView.Columns.Item("SKU").Visible = False
        ProductsDataGridView.Columns.Item("DESCRIPTION").Visible = False
    End Sub
    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        'Dim result As DialogResult
        'result = MessageBox.Show("Is this product a medicine?", "Product Type Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'If result = DialogResult.Yes Then
        '    Dim Dialog As New ProductDialog(subject:=_subject)
        '    Dialog.ShowDialog()
        'Else
        '    MessageBox.Show("You selected Non-Medicine.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If

        Dim result As DialogResult
        result = MessageBox.Show("Please confirm if this is a medicine?.",
                                 "Product type",
                                 MessageBoxButtons.YesNoCancel,
                                 MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim Dialog As New ProductDialog(subject:=_subject)
            Dialog.ShowDialog()
        ElseIf result = DialogResult.No Then
            Dim Dialog As New NonMedicalDialog(subject:=_subject)
            Dialog.ShowDialog()
        Else
            Return
        End If

    End Sub

    Private Sub ProductsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductsDataGridView.CellClick
        If ProductsDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRows As DataGridViewSelectedRowCollection = ProductsDataGridView.SelectedRows
            Dim row As DataGridViewRow = selectedRows(0)
            Dim data As New Dictionary(Of String, String) From {
                {"id", If(String.IsNullOrEmpty(row.Cells(0).Value.ToString()), 0, row.Cells(0).Value.ToString())},
                {"subcategory_id", BaseProduct.ScalarSubcategoryId(row.Cells(1).Value.ToString())},
                {"sku", If(String.IsNullOrEmpty(row.Cells(2).Value.ToString()), 0, row.Cells(2).Value.ToString())},
                {"barcode", If(String.IsNullOrEmpty(row.Cells(3).Value.ToString()), 0, row.Cells(3).Value.ToString())},
                {"product_name", If(String.IsNullOrEmpty(row.Cells(4).Value.ToString()), 0, row.Cells(4).Value.ToString())},
                {"description", row.Cells(5).Value.ToString()},'               {"price", row.Cells(7).Value.ToString()},               {"cost", row.Cells(8).Value.ToString()},
                {"stock_level", If(String.IsNullOrEmpty(row.Cells(7).Value.ToString()), 0, row.Cells(7).Value.ToString())}
            }
            If BaseProduct.ChangeDialog(data.Item("id")) = 1 Then
                Dim Dialog As New ProductDialog(data:=data, subject:=_subject)
                Dialog.ShowDialog()
            Else
                Dim Dialog As New NonMedicalDialog(data:=data, subject:=_subject)
                Dialog.ShowDialog()
            End If
        End If
    End Sub

    Private Sub ProductSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductSearchTextBox.TextChanged
        _dataTable = BaseProduct.Search(ProductSearchTextBox.Text)
        ProductsDataGridView.DataSource = _dataTable
    End Sub

    Private Sub ModalImageButton_Click(sender As Object, e As EventArgs) Handles ModalImageButton.Click
        Dim modal As New Dialog1()
        modal.StartPosition = FormStartPosition.Manual
        modal.Location = New Point(Dashboard.Location.X + 190, Dashboard.Location.Y + 50) ' Align with the parent form's upper left corner
        modal.ShowDialog(Dashboard) ' Pass the parent form as argument
    End Sub

    Private Sub PrintProductButton_Click(sender As Object, e As EventArgs) 
        'Using dialog = ProductVIewer
        '    dialog.ShowDialog()
        'End Using
    End Sub

    'Private Sub ProductsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyBasesDataGridView.CellContentClick

    'End Sub


    'Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs)
    '    If Guna2ToggleSwitch1.Checked Then
    '        ' Action when the toggle switch is checked
    '        'MsgBox("The switch is ON")
    '        ProductSearchTextBox.Enabled = False
    '        Guna2ComboBox1.Enabled = True
    '        Guna2ComboBox2.Enabled = True
    '    Else
    '        ' Action when the toggle switch is unchecked
    '        'MsgBox("The switch is Off")
    '        ProductSearchTextBox.Enabled = True
    '        Guna2ComboBox1.Enabled = False
    '        Guna2ComboBox2.Enabled = False
    '    End If
    'End Sub
End Class
