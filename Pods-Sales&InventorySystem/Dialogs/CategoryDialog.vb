Imports System.Windows.Forms

Public Class CategoryDialog
    Private _data As Dictionary(Of String, String)
    Private _subject As IObservablePanel
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub

    Private Sub CategoryDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddCategoryButton_Click(sender As Object, e As EventArgs) Handles AddCategoryButton.Click
        Dim controls As Object() = {CategoryNameTextBox}
        Dim types As DataInput() = {DataInput.STRING_STRING}

        Dim result As New List(Of Object())
        For i = 0 To controls.Count - 1
            result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
        Next

        Dim baseCommand As BaseCategory = Nothing
        Dim invoker As ICommandInvoker = Nothing
        If Not result.Any(Function(item As Object()) Not item(0)) Then
            Dim data As New Dictionary(Of String, String) From {
                {"id", _data?.Item("id")},
                {"category", result(0)(1)},
                {"description", If(String.IsNullOrEmpty(DescriptionTextBox.Text), "", DescriptionTextBox.Text)}
            }
            If BaseCategory.Exists(result(0)(1)) = 0 AndAlso _data Is Nothing Then
                baseCommand = New BaseCategory(data)
                invoker = New AddCommand(baseCommand)
            End If

        End If

            invoker?.Execute()
        _subject.NotifyObserver()
        Me.Close()
    End Sub

    Private Sub DeleteCategoryButton_Click(sender As Object, e As EventArgs) Handles DeleteCategoryButton.Click

    End Sub
End Class
