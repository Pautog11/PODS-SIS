Imports System.Windows.Forms
Imports Pods_Sales_InventorySystem.pods

Public Class CategoryDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub

    Private Sub CategoryDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                'To update the button
                AddCategoryButton.Text = "Update"

                'To populate the data
                CategoryNameTextBox.Text = _data("category")
                DescriptionTextBox.Text = _data("description")
                DeleteCategoryButton.Visible = False
            Else
                'To disable the delete button
                DeleteCategoryButton.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddCategoryButton_Click(sender As Object, e As EventArgs) Handles AddCategoryButton.Click
        Try
            Dim controls As Object() = {CategoryNameTextBox}
            Dim types As DataInput() = {DataInput.STRING_STRING}

            Dim result As New List(Of Object())
            'For i = 0 To controls.Count - 1
            '    result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
            '    If Not CType(result(i), Object())(0) AndAlso Not String.IsNullOrEmpty(controls(i).Text) Then
            '        Exit Sub
            '    End If
            'Next


            For i = 0 To controls.Count - 1
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                Dim validationResult = TryCast(result(i), Object())
                If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                    If Not validationResult(0) = True Then
                        Exit Sub
                    End If
                End If
            Next

            Dim baseCommand As BaseCategory = Nothing
            Dim invoker As ICommandInvoker = Nothing
            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim data As New Dictionary(Of String, String) From {
                    {"id", _data?.Item("id")},
                    {"category", result(0)(1)},
                    {"description", If(String.IsNullOrEmpty(DescriptionTextBox.Text), "", DescriptionTextBox.Text)}
                }

                baseCommand = New BaseCategory(data)
                If BaseCategory.Exists(result(0)(1)) = 0 AndAlso _data Is Nothing Then
                    'baseCommand = New BaseCategory(data)
                    invoker = New AddCommand(baseCommand)
                    'Me.Close()
                ElseIf _data IsNot Nothing AndAlso BaseCategory.Exists(result(0)(1)) = 0 Then
                    'baseCommand = New BaseCategory(data)
                    invoker = New UpdateCommand(baseCommand)
                    'Me.Close()
                Else
                    MessageBox.Show("Category exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                'baseCommand = New BaseCategory(data)
                invoker?.Execute()
                _subject.NotifyObserver()
                Me.Close()
            Else
                MessageBox.Show("Please fill out all textboxes or provide all valid inputs.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteCategoryButton_Click(sender As Object, e As EventArgs) Handles DeleteCategoryButton.Click
        Dim baseCommand As New BaseCategory(_data)
        Dim invoker As New DeleteCommand(baseCommand)
        invoker?.Execute()
        _subject.NotifyObserver()
        Me.Close()
    End Sub
End Class
