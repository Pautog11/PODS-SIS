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
        PasswordTextBox.UseSystemPasswordChar = True
        Guna2TextBox1.UseSystemPasswordChar = True
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            Dim result As New List(Of Object)() From {InputValidation.ValidateInputString(PasswordTextBox, DataInput.STRING_STRING), InputValidation.ValidateInputString(Guna2TextBox1, DataInput.STRING_STRING)}
            If Not result.Any(Function(item As Object()) Not item(0)) Then
                If PasswordTextBox.Text = Guna2TextBox1.Text Then
                    BaseAccount.ChangePass(PasswordTextBox.Text, _id)
                    Me.Close()
                    _parent.Close()
                Else
                    MessageBox.Show("Password doesn't match.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PasswordTextBox.Text = ""
                    Guna2TextBox1.Text = ""
                End If
            Else
                MessageBox.Show("Enter your new password.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.Checked Then
            PasswordTextBox.UseSystemPasswordChar = False ' Show password
            Guna2TextBox1.UseSystemPasswordChar = False ' Show password
        Else
            PasswordTextBox.UseSystemPasswordChar = True
            Guna2TextBox1.UseSystemPasswordChar = True
        End If
    End Sub
End Class
