Imports System.Windows.Forms

Public Class CustomerReturnCodeDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub

    Private Sub CustomerReturnCodeDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _data IsNot Nothing Then
            CodeTextBox.Text = _data.Item("code")
            DescriptionTextBox.Text = _data.Item("description")

            AddButton.Text = "Update"
        End If
        DeleteButton.Visible = False
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try
            Dim controls As Object() = {CodeTextBox}
            Dim types As DataInput() = {DataInput.STRING_STRING}

            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                If Not CType(result(i), Object())(0) AndAlso Not String.IsNullOrEmpty(controls(i).Text) Then
                    Exit Sub
                End If
            Next

            Dim baseCommand As BaseCustomerReturnCode = Nothing
            Dim invoker As ICommandInvoker = Nothing
            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim data As New Dictionary(Of String, String) From {
                    {"id", _data?.Item("id")},
                    {"code", result(0)(1)},
                    {"description", If(String.IsNullOrEmpty(DescriptionTextBox.Text), "", DescriptionTextBox.Text)}
                }

                If BaseCustomerReturnCode.Exists(result(0)(1)) = 0 AndAlso _data Is Nothing Then
                    baseCommand = New BaseCustomerReturnCode(data)
                    invoker = New AddCommand(baseCommand)
                    Me.Close()
                ElseIf _data IsNot Nothing AndAlso BaseCategory.Exists(result(0)(1)) = 0 Then
                    baseCommand = New BaseCustomerReturnCode(data)
                    invoker = New UpdateCommand(baseCommand)
                    Me.Close()
                Else
                    MessageBox.Show("Code exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

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
End Class
