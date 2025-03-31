Imports System.Windows.Forms

Public Class DiscountDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub
    Private Sub DiscountDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                'MsgBox(_data.Item("id"))
                Dim fuck As Integer = BaseDiscount.FetchDiscount(_data.Item("id"))
                DiscountTextBox.Text = fuck.ToString '_data.Item("discount")
                DescriptionTextBox.Text = _data.Item("description")
                AddDiscountButton.Text = "Update"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddDiscountButton_Click(sender As Object, e As EventArgs) Handles AddDiscountButton.Click
        Try
            'Dim result As New List(Of Object()) From {InputValidation.ValidateInputString(DiscountTextBox, DataInput.STRING_INTEGER)}
            Dim controls As Object() = {DiscountTextBox}
            Dim types As DataInput() = {DataInput.STRING_INTEGER}

            Dim result As New List(Of Object())
            For i = 0 To Controls.Count - 1
                result.Add(InputValidation.ValidateInputString(Controls(i), types(i)))
                If Not CType(result(i), Object())(0) AndAlso Not String.IsNullOrEmpty(Controls(i).Text) Then
                    Exit Sub
                End If
            Next

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim data As New Dictionary(Of String, String) From {
                    {"id", _data?.Item("id")},
                    {"discount", result(0)(1)},
                    {"description", DescriptionTextBox.Text}
                }

                Dim validVat As Boolean = False
                If result(0)(1) >= 1 And result(0)(1) <= 25 Then
                    validVat = True
                End If

                If Not validVat Then
                    MessageBox.Show("Please enter a discount value between 1 and 25.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DiscountTextBox.Text = ""
                    Exit Sub
                End If

                Dim baseCommand As New BaseDiscount(data)
                Dim invoker As ICommandInvoker = Nothing
                If BaseDiscount.Exists(result(0)(1)) = 0 AndAlso _data Is Nothing Then
                    invoker = New AddCommand(baseCommand)
                ElseIf _data IsNot Nothing AndAlso BaseDiscount.IdExists(_data?.Item("id"), result(0)(1)) = 0 Then
                    If _data.Item("id") = "12" Then
                        MessageBox.Show("You can't edit this discount!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    invoker = New UpdateCommand(baseCommand)
                Else
                    MessageBox.Show("Discount exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                invoker?.Execute()
                _subject.NotifyObserver()
                Me.Close()
            Else
                MessageBox.Show("Please provide valid discount.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
