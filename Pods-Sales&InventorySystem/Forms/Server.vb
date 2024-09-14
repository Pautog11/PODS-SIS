Imports System.Data.SqlClient

Public Class Server
    Private Sub Server_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Private Sub TestButton_Click(sender As Object, e As EventArgs) Handles TestButton.Click
        Try
            Dim controls As Object() = {
                ServerTextBox, UsernameTextBox, PasswordTextBox
            }
            Dim types As DataInput() = {
                DataInput.STRING_STRING, DataInput.STRING_NAME, DataInput.STRING_NAME
            }
            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
            Next

            'Dim default_connection As String = "Server=" + ServerTextBox.Text + ";Initial Catalog=podsdb;Persist Security Info=True;User ID=" + UsernameTextBox.Text + ";Password=" + PasswordTextBox.Text + ""
            Dim default_connection As String = $"Server={ServerTextBox.Text};Initial Catalog=;Persist Security Info=True;User ID={"admin"};Password={"admin"}"

            Dim con As New SqlConnection(default_connection)
            Dim cmd As New SqlCommand
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd = New SqlCommand("SELECT name FROM master.sys.databases", con)
            Dim c As New SqlDataAdapter(cmd)
            Dim d As New DataTable
            c.Fill(d)
            DatabaseComboBox.DataSource = d.DefaultView
            DatabaseComboBox.DisplayMember = "name"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class