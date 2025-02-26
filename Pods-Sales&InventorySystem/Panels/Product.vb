Public Class Product
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
        ProductsDataGridView.Columns.Item("ID SUBCAT").Visible = False
        ProductsDataGridView.Columns.Item("BARCODE").Visible = False
        ProductsDataGridView.Columns.Item("CRITICAL LEVEL").Visible = False
    End Sub
    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Dim Dialog As New ProductDialog(subject:=_subject)
        Dialog.ShowDialog()
    End Sub

    Private Sub ProductsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductsDataGridView.CellClick
        Try
            If ProductsDataGridView.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = ProductsDataGridView.SelectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                    {"id", If(String.IsNullOrEmpty(row.Cells(0).Value.ToString()), 0, row.Cells(0).Value.ToString())},
                    {"category_id", If(String.IsNullOrEmpty(row.Cells(2).Value.ToString()), 0, row.Cells(2).Value.ToString())}, 'BaseProduct.ScalarCategoryId(row.Cells(2).Value.ToString())},
                    {"subcategory_id", If(String.IsNullOrEmpty(row.Cells(1).Value.ToString()), "", row.Cells(1).Value.ToString())},
                    {"barcode", If(String.IsNullOrEmpty(row.Cells(4).Value.ToString()), "", row.Cells(4).Value.ToString())},
                    {"product_name", If(String.IsNullOrEmpty(row.Cells(5).Value.ToString()), "", row.Cells(5).Value.ToString())},
                    {"description", If(String.IsNullOrEmpty(row.Cells(6).Value.ToString()), "", row.Cells(6).Value.ToString())},
                    {"stock_level", If(String.IsNullOrEmpty(row.Cells(7).Value.ToString()), 0, row.Cells(7).Value.ToString())}
                }
                Dim Dialog As New ProductDialog(data:=data, subject:=_subject)
                Dialog.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProductSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductSearchTextBox.TextChanged
        _dataTable = BaseProduct.Search(ProductSearchTextBox.Text)
        ProductsDataGridView.DataSource = _dataTable
    End Sub
    'Private Sub ModalImageButton_Click(sender As Object, e As EventArgs) Handles ModalImageButton.Click
    '    Dim modal As New Dialog1()
    '    modal.StartPosition = FormStartPosition.Manual
    '    modal.Location = New Point(Dashboard.Location.X + 190, Dashboard.Location.Y + 50) ' Align with the parent form's upper left corner
    '    modal.ShowDialog(Dashboard) ' Pass the parent form as argument
    'End Sub

    'Private Sub PrintProductButton_Click(sender As Object, e As EventArgs) 
    '    'Using dialog = ProductVIewer
    '    '    dialog.ShowDialog()
    '    'End Using
    'End Sub

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
