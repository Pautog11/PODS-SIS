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
                Me.Close()
            ElseIf _data IsNot Nothing AndAlso BaseCategory.Exists(result(0)(1)) = 0 Then
                baseCommand = New BaseCategory(data)
                invoker = New UpdateCommand(baseCommand)
                Me.Close()
            Else
                MessageBox.Show("Category exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            invoker?.Execute()
            _subject.NotifyObserver()
            'Me.Close()
        Else
            MessageBox.Show("Please fill out all textboxes or provide all valid inputs.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DeleteCategoryButton_Click(sender As Object, e As EventArgs) Handles DeleteCategoryButton.Click
        Dim baseCommand As New BaseCategory(_data)
        Dim invoker As New DeleteCommand(baseCommand)
        invoker?.Execute()
        _subject.NotifyObserver()
        Me.Close()
    End Sub
End Class
