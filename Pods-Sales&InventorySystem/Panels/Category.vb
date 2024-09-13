Public Class Category
    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoryDataGridView.DataSource = BaseCategory.Category.DefaultView
    End Sub
End Class
