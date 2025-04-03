Imports System.Windows.Forms

Public Class SubCategoryDialog
    Private ReadOnly _tableAdapter As New podsTableAdapters.viewtblcategoriesTableAdapter
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
            Dim subcategory_data As pods.viewtblcategoriesDataTable = _tableAdapter.GetData()
            CategoryComboBox.DataSource = subcategory_data
            CategoryComboBox.DisplayMember = "CATEGORY"
            CategoryComboBox.ValueMember = "ID"
            If subcategory_data.Rows.Count > 0 Then
                CategoryComboBox.SelectedIndex = -1
            End If

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
            Dim controls As Object() = {CategoryComboBox, SubcategoryNameTextBox}
            Dim types As DataInput() = {DataInput.STRING_STRING, DataInput.STRING_STRING}

            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                Dim validationResult = TryCast(result(i), Object())
                If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                    If Not validationResult(0) = True Then
                        Exit Sub
                    End If
                Else
                    Throw New Exception
                End If
            Next
            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim data As New Dictionary(Of String, String) From {
                    {"id", _data?.Item("id")},
                    {"category_id", CategoryComboBox.SelectedItem("id")},
                    {"subcategory", result(1)(1)},
                    {"description", SubCategoryDescriptionTextBox.Text}
                }
                Dim baseCommand As New BaseSubCategory(data)
                Dim invoker As ICommandInvoker = Nothing
                If BaseSubCategory.CategoryAndSubcategoryExists(CategoryComboBox.SelectedItem("id"), result(1)(1)) = 0 AndAlso _data Is Nothing Then 'BaseSubCategory.Exists(result(0)(1)) = 0 AndAlso
                    invoker = New AddCommand(baseCommand)
                    invoker?.Execute()
                    _subject.NotifyObserver()
                    Me.Close()
                ElseIf _data IsNot Nothing Then
                    If BaseSubCategory.CategoryAndSubcategoryExists(CategoryComboBox.SelectedItem("id"), result(1)(1)) = 1 Then
                        If BaseSubCategory.CategoryAndSubcategoryWithIdExists(_data.Item("id"), CategoryComboBox.SelectedItem("id"), result(1)(1)) = 1 Then
                            invoker = New UpdateCommand(baseCommand)
                            invoker?.Execute()
                            _subject.NotifyObserver()
                            Me.Close()
                        Else
                            'invoker = New UpdateCommand(baseCommand)
                            'invoker?.Execute()
                            '_subject.NotifyObserver()
                            'Me.Close()
                            MessageBox.Show("Subcategory exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If

                    Else
                        invoker = New UpdateCommand(baseCommand)
                        invoker?.Execute()
                        _subject.NotifyObserver()
                        Me.Close()
                    End If

                Else
                    MessageBox.Show("Subcategory exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            Else
                MessageBox.Show("Please fill out all textboxes or provide all valid inputs.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
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
