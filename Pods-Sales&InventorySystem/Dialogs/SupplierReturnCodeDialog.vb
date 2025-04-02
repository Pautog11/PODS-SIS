Imports System.Windows.Forms
Public Class SupplierReturnCodeDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub

    Private Sub SupplierReturnCodeDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim types As DataInput() = {DataInput.STRING_CODE}

            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                Dim validationResult = TryCast(result(i), Object())
                If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                    If Not validationResult(0) = True Then
                        Exit Sub
                    End If
                End If
            Next

            Dim baseCommand As BaseSupplierReturnCode = Nothing
            Dim invoker As ICommandInvoker = Nothing
            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim data As New Dictionary(Of String, String) From {
                    {"id", _data?.Item("id")},
                    {"code", result(0)(1)},
                    {"description", If(String.IsNullOrEmpty(DescriptionTextBox.Text), "", DescriptionTextBox.Text)}
                }

                baseCommand = New BaseSupplierReturnCode(data)
                If BaseSupplierReturnCode.Exists(result(0)(1)) = 0 AndAlso _data Is Nothing Then
                    invoker = New AddCommand(baseCommand)
                    invoker?.Execute()
                    _subject.NotifyObserver()
                    Me.Close()
                ElseIf _data IsNot Nothing Then
                    If BaseSupplierReturnCode.Exists(result(0)(1)) = 1 Then
                        If BaseSupplierReturnCode.ExistsWithId(_data.Item("id"), result(0)(1)) = 1 Then
                            invoker = New UpdateCommand(baseCommand)
                            invoker?.Execute()
                            _subject.NotifyObserver()
                            Me.Close()
                        Else
                            MessageBox.Show("Code exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Return
                        End If
                    Else
                        invoker = New UpdateCommand(baseCommand)
                        invoker?.Execute()
                        _subject.NotifyObserver()
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("Code exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            Else
                MessageBox.Show("Please fill out all textboxes or provide all valid inputs.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
