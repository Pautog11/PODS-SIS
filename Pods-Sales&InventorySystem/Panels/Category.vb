Public Class Category
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblcategoriesTableAdapter
    Private _dataTable As New pods.viewtblcategoriesDataTable
    'Private WithEvents Timer1 As New Timer()

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        CategoryDataGridView.DataSource = _dataTable
        CategoryDataGridView.Columns.Item("ID").Visible = False
    End Sub

    Private Sub CategorySearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles CategorySearchTextBox.TextChanged
        _dataTable = BaseCategory.Search(CategorySearchTextBox.Text)
        CategoryDataGridView.DataSource = _dataTable
    End Sub

    Private Sub AddCategoryButton_Click(sender As Object, e As EventArgs) Handles AddCategoryButton.Click
        Dim Dialog As New CategoryDialog(subject:=_subject)
        Dialog.ShowDialog()
    End Sub

    Private Sub CategoryDataGridView_Click(sender As Object, e As EventArgs) Handles CategoryDataGridView.CellClick
        Try
            If CategoryDataGridView.SelectedRows.Count > 0 Then
                Dim selectedRows As DataGridViewSelectedRowCollection = CategoryDataGridView.SelectedRows
                Dim row As DataGridViewRow = selectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                    {"id", row.Cells(0).Value.ToString()},
                    {"category", row.Cells(1).Value.ToString()},'row.Cells(1).Value.ToString()},
                    {"description", row.Cells(2).Value.ToString()}
                }
                Dim Dialog As New CategoryDialog(data:=data, subject:=_subject)
                Dialog.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Fill()
        _tableAapter.Fill(_dataTable)
        CategoryDataGridView.DataSource = _dataTable
        CategoryDataGridView.Columns.Item("ID").Visible = False
    End Sub
End Class
