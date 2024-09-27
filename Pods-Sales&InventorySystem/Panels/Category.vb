Public Class Category
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private _tableAapter As New podsTableAdapters.viewtblcategoriesTableAdapter
    Private _dataTable As New pods.viewtblcategoriesDataTable

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error")
        End Try

        'Guna2ComboBox1.DataSource = BaseCategory.FillByCategories().DefaultView
        'Guna2ComboBox1.DisplayMember = "category"
        'Guna2ComboBox1.SelectedItem = "id"
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        _tableAapter.Fill(_dataTable)
        CategoryDataGridView.DataSource = _dataTable
    End Sub

    Private Sub CategorySearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles CategorySearchTextBox.TextChanged
        _dataTable = BaseCategory.Search(CategorySearchTextBox.Text)
        CategoryDataGridView.DataSource = _dataTable
    End Sub

    Private Sub AddCategoryButton_Click(sender As Object, e As EventArgs) Handles AddCategoryButton.Click
        Dim Dialog As New CategoryDialog(subject:=_subject)
        Dialog.ShowDialog()
    End Sub

    Private Sub AddAccountButton_Click_1(sender As Object, e As EventArgs) Handles AddCategoryButton.Click

    End Sub
    Private Sub CategoryDataGridView_Click(sender As Object, e As EventArgs) Handles CategoryDataGridView.Click
        MsgBox("jhkjhkjh")
    End Sub
End Class
