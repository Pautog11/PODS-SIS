Imports System.Windows.Forms

Public Class PasswordDialog
    Private ReadOnly _subject As IObservablePanel
    Private ReadOnly _parent As AccountDialog = Nothing
    Private ReadOnly _id As Integer
    Public Sub New(Optional subject As IObservablePanel = Nothing,
                   Optional parent As AccountDialog = Nothing,
                   Optional id As Integer = Nothing)
        InitializeComponent()
        _parent = parent
        _subject = subject
        _id = id

    End Sub
    Private Sub PasswordDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim result As New List(Of Object)() From {InputValidation.ValidateInputString(PasswordTextBox, DataInput.STRING_STRING)}

        If Not result.Any(Function(item As Object()) Not item(0)) Then
            BaseAccount.ChangePass(PasswordTextBox.Text, _id)
            Me.Close()
            _parent.Close()
        Else
            MessageBox.Show("Enter your new password.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
