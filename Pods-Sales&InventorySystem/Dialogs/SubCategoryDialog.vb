Imports System.Windows.Forms

Public Class SubCategoryDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub

    Private Sub SubCategoryDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' To fill the data to CategoryComboBox
            CategoryComboBox.DataSource = BaseSubCategory.FillByCategory
            CategoryComboBox.DisplayMember = "category"
            CategoryComboBox.SelectedItem = "id"


            If _data IsNot Nothing Then
                'To addbutton changed Update
                AddSubCategoryButton.Text = "Update"

                'To populate the data
                CategoryComboBox.Text = BaseSubCategory.FetchCategory(_data.Item("category_id"))
                SubcategoryNameTextBox.Text = _data.Item("subcategory")
                SubCategoryDescriptionTextBox.Text = _data.Item("description")
                DeleteSubCategoryButton.Visible = False
            Else
                DeleteSubCategoryButton.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddSubCategoryButton_Click(sender As Object, e As EventArgs) Handles AddSubCategoryButton.Click
        Try
            Dim controls As Object() = {SubcategoryNameTextBox}
            Dim types As DataInput() = {DataInput.STRING_STRING}

            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                If Not CType(result(i), Object())(0) AndAlso Not String.IsNullOrEmpty(controls(i).Text) Then
                    Exit Sub
                End If
            Next
            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim data As New Dictionary(Of String, String) From {
                    {"id", _data?.Item("id")},
                    {"category_id", CategoryComboBox.SelectedItem("id")},
                    {"subcategory", result(0)(1)},
                    {"description", SubCategoryDescriptionTextBox.Text}
                }
                Dim baseCommand As New BaseSubCategory(data)
                Dim invoker As ICommandInvoker = Nothing
                If BaseSubCategory.CategoryAndSubcategoryExists(CategoryComboBox.SelectedItem("id"), result(0)(1)) = 0 AndAlso _data Is Nothing Then 'BaseSubCategory.Exists(result(0)(1)) = 0 AndAlso
                    invoker = New AddCommand(baseCommand)
                ElseIf _data IsNot Nothing AndAlso BaseSubCategory.CategoryAndSubcategoryExists(CategoryComboBox.SelectedItem("id"), result(0)(1)) = 0 Then
                    invoker = New UpdateCommand(baseCommand)
                Else
                    MessageBox.Show("Subcategory exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                invoker?.Execute()
                _subject.NotifyObserver()
                Me.Close()
            Else
                MessageBox.Show("Please fill out all textboxes or provide all valid inputs.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteSubCategoryButton_Click(sender As Object, e As EventArgs) Handles DeleteSubCategoryButton.Click
        Dim baseCommand As New BaseSubCategory(_data)
        Dim invoker As New DeleteCommand(baseCommand)
        invoker?.Execute()
        _subject.NotifyObserver()
        Me.Close()
    End Sub
End Class
