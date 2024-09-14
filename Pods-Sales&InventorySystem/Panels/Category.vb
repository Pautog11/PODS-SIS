Public Class Category
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private _tableAapter As New podsTableAdapters.tblcategoryTableAdapter
    Private _dataTable As New pods.tblcategoryDataTable

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error")
        End Try
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        _tableAapter.Fill(_dataTable)
        CategoryDataGridView.DataSource = _dataTable
    End Sub

    Private Sub CategorySearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles CategorySearchTextBox.TextChanged
        _dataTable = BaseCategory.Search(CategorySearchTextBox.Text)
        CategoryDataGridView.DataSource = _dataTable
    End Sub

    Private Sub AddAccountButton_Click(sender As Object, e As EventArgs) Handles AddAccountButton.Click
        Dim Dialog As New CategoryDialog(subject:=_subject)
        Dialog.ShowDialog()
    End Sub
End Class
