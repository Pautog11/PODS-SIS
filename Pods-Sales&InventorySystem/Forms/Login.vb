Imports System.Windows.Forms.TabControl

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
            Dim validationResult = TryCast(vres(i), Object())
            If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                If Not validationResult(0) = True Then
                    Exit Sub
                End If
            End If
        Next

        If Not vres.Any(Function(item As Object()) Not item(0)) Then
            If BaseAccount.ScalarAccount() = 0 Then
                Dim dick As New List(Of String) From {"Superadmin", "superadmin", "SUPERADMIN", "SuperAdmin", "super_admin", "Super_Admin"}
                If dick.Contains(UsernameTextBox.Text) AndAlso dick.Contains(PasswordTextBox.Text) Then
                    Dim fuck As New SignUp
                    Dim res1 = MessageBox.Show("You will be directed to signup Panel", "PODS", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If res1 = DialogResult.Yes Then
                        fuck.ShowDialog()
                    End If
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                    Exit Sub
                Else
                    MessageBox.Show("Login Failed!", "PODS-SIS")
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                    Exit Sub
                End If
            End If
            res = _loginModule.LoginAccount(UsernameTextBox.Text, PasswordTextBox.Text)
            If res?(0) Then
                Dim dash As New Dashboard
                Select Case My.Settings.roleId
                        Case 1

                        Case 2
                            'main.MaintenaceTabControl.TabPages.Remove(main.Accounts)
                            ''Dim tabss As TabControl = dash.Maintenance.TabIndex. .TabControlContainer.Items()
                            ''Dim tabs As TabControl = dash.Maintenance.TabPageControlCollection 'MaintainanceContainer.TabControlContainer.Items(
                            'dash.DashboardTabControl.TabPages.Remove(dash.Account)
                            Dim tabs As TabPageCollection = dash.Maintenance1.MaintenaceTabControl.TabPages
                            tabs.Remove(dash.Maintenance1.Accounts)
                        Case 3
                            dash.DashboardTabControl.TabPages.Remove(dash.Products)
                            dash.DashboardTabControl.TabPages.Remove(dash.Maintenance)
                            dash.DashboardTabControl.TabPages.Remove(dash.Reports)
                            'dash.DashboardTabControl.TabPages.Remove(dash.Witdrawal)
                            dash.DashboardTabControl.TabPages.Remove(dash.Activity)
                            dash.DashboardTabControl.TabPages.Remove(dash.Inventory)
                            dash.DashboardTabControl.TabPages.Remove(dash.Deliveries)
                            'dash.DashboardTabControl.TabPages.Remove(dash.Account)
                    End Select

                    If BaseLoginStatus.Status() = 1 Then
                        MessageBox.Show("Unable to log in at the moment because you are currently logged in on another device. Please log out from the other device or try again later.", "PODS-SIS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    BaseLoginStatus.Login()

                Using Me
                    dash.Show()
                End Using
            End If
        Else
            MessageBox.Show("Login Failed!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
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