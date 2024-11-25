Public Class Login
    Private _loginModule As New LoginModule
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTextBox.UseSystemPasswordChar = True
    End Sub
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim res As Object() = Nothing
        Dim controls As Object() = {UsernameTextBox, PasswordTextBox}
        Dim types As DataInput() = {DataInput.STRING_USERNAME, DataInput.STRING_PASSWORD}

        Dim vres As New List(Of Object())
        For i = 0 To controls.Count - 1
            vres.Add(InputValidation.ValidateInputString(controls(i), types(i)))
        Next

        If Not vres.Any(Function(item As Object()) Not item(0)) Then
            If BaseAccount.ScalarAccount() = 0 Then
                Dim fuck As New SignUp
                Dim res1 = MessageBox.Show("You will be directed to signup Panel", "PODS", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If res1 = DialogResult.Yes Then
                    fuck.ShowDialog()
                End If
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
                Exit Sub
            End If
            res = _loginModule.LoginAccount(UsernameTextBox.Text, PasswordTextBox.Text)
            If res?(0) Then
                Dim dash As New Dashboard
                Dim main As New Maintenance
                Select Case My.Settings.roleId
                    Case 1
                        'dash.DashboardTabControl.TabPages.Remove(dash.AuditTrail)
                    Case 2
                        'main.MaintenaceTabControl.TabPages.Remove(main.Accounts)
                        ''Dim tabss As TabControl = dash.Maintenance.TabIndex. .TabControlContainer.Items()
                        ''Dim tabs As TabControl = dash.Maintenance.TabPageControlCollection 'MaintainanceContainer.TabControlContainer.Items(
                    Case 3
                        dash.DashboardTabControl.TabPages.Remove(dash.Maintenance)
                End Select
                Me.Hide()
                dash.Show()
            End If
        Else
            MessageBox.Show("Login Failed!", "PODS-SIS")
        End If
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.Checked Then
            PasswordTextBox.UseSystemPasswordChar = False ' Show password
        Else
            PasswordTextBox.UseSystemPasswordChar = True ' Hide password
        End If
    End Sub
End Class