Public Class SubCategory
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private _tableAapter As New podsTableAdapters.viewtblsubcategoriesTableAdapter
    Private _dataTable As New pods.viewtblsubcategoriesDataTable
    Private Sub SubCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        SubCategoryDataGridView.DataSource = _dataTable
    End Sub

    Private Sub AddSubCategoryButton_Click(sender As Object, e As EventArgs) Handles AddSubCategoryButton.Click
        Dim Dialog As New SubCategoryDialog(subject:=_subject)
        Dialog.ShowDialog()
    End Sub

    Private Sub SubCategoryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SubCategoryDataGridView.CellClick
        If SubCategoryDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRows As DataGridViewSelectedRowCollection = SubCategoryDataGridView.SelectedRows
            Dim row As DataGridViewRow = selectedRows(0)
            Dim data As New Dictionary(Of String, String) From {
                {"id", row.Cells(0).Value.ToString()},
                {"category_id", BaseSubCategory.ScalarsCategoryName(row.Cells(1).Value.ToString())},
                {"subcategory", row.Cells(2).Value.ToString()},
                {"description", row.Cells(3).Value.ToString()}
            }
            Dim Dialog As New SubCategoryDialog(data:=data, subject:=_subject)
            Dialog.ShowDialog()
        End If
    End Sub
End Class
