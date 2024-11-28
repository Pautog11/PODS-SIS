Imports System.Data.SqlClient

Public Class Server
    Private Sub Server_Load(sender As Object, e As EventArgs) Handles Me.Load
        PasswordTextBox.UseSystemPasswordChar = True
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
            Dim default_connection As String = $"Server={ServerTextBox.Text};Initial Catalog=;Persist Security Info=True;User ID={UsernameTextBox.Text};Password={PasswordTextBox.Text}"

            Dim con As New SqlConnection(default_connection)
            Dim cmd As New SqlCommand
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            'cmd = New SqlCommand("SELECT name FROM master.sys.databases", con)
            'Dim c As New SqlDataAdapter(cmd)
            'Dim d As New DataTable
            'c.Fill(d)
            'DatabaseComboBox.DataSource = d.DefaultView
            'DatabaseComboBox.DisplayMember = "name"
            MessageBox.Show("Test connection success!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            Dim podsconnection As String = $"Server={ServerTextBox.Text};Initial Catalog=podsdb;Persist Security Info=True;User ID={UsernameTextBox.Text};Password={PasswordTextBox.Text}"
            My.Settings.con = podsconnection
            'My.Settings.podsdbConnectionString = "Server=.;Initial Catalog=podsdb;Persist Security Info=True;User ID=admin;Password=password;"
            'My.Settings.podsdbConnectionString1 = "Data Source=.;Initial Catalog=podsdb;User ID=admin;Password=password;"
            'My.Settings.podsdbConnectionString = podsconnection
            My.Settings.Save()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        Try
            If Guna2CheckBox1.Checked Then
                PasswordTextBox.UseSystemPasswordChar = False
            Else
                PasswordTextBox.UseSystemPasswordChar = True
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class