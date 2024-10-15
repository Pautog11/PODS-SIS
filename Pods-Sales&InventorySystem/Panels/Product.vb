Public Class Product
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private _tableAapter As New podsTableAdapters.viewtblproductsTableAdapter
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
    End Sub
    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Dim Dialog As New ProductDialog(subject:=_subject)
        Dialog.ShowDialog()
    End Sub

    Private Sub ProductsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductsDataGridView.CellClick
        If ProductsDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRows As DataGridViewSelectedRowCollection = ProductsDataGridView.SelectedRows
            Dim row As DataGridViewRow = selectedRows(0)
            Dim data As New Dictionary(Of String, String) From {
                {"id", row.Cells(0).Value.ToString()},
                {"subcategory_id", BaseProduct.ScalarSubcategoryId(row.Cells(1).Value.ToString())},
                {"barcode", row.Cells(2).Value.ToString()},
                {"product_name", row.Cells(3).Value.ToString()},
                {"description", row.Cells(4).Value.ToString()},
                {"price", row.Cells(5).Value.ToString()},
                {"cost", row.Cells(6).Value.ToString()},
                {"stock_level", row.Cells(7).Value.ToString()}
            }
            Dim Dialog As New ProductDialog(data:=data, subject:=_subject)
            Dialog.ShowDialog()
        End If
    End Sub

    Private Sub ProductSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductSearchTextBox.TextChanged
        _dataTable = BaseProduct.Search(ProductSearchTextBox.Text)
        ProductsDataGridView.DataSource = _dataTable
    End Sub
End Class
