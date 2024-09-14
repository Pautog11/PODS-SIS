Public Class Login
    Private _loginModule As New LoginModule
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        Dim res As Object() = Nothing
        Dim controls As Object() = {UsernameTextBox, PasswordTextBox}
        Dim types As DataInput() = {DataInput.STRING_USERNAME, DataInput.STRING_PASSWORD}

        Dim vres As New List(Of Object())
        For i = 0 To controls.Count - 1
            vres.Add(InputValidation.ValidateInputString(controls(i), types(i)))
        Next

        If Not vres.Any(Function(item As Object()) Not item(0)) Then
            res = _loginModule.LoginAccount(UsernameTextBox.Text, PasswordTextBox.Text)
            If res?(0) Then
                Dim dash As New Dashboard
                Select Case My.Settings.roleId
                    Case 1
                        'dash.DashboardTabControl.TabPageCollection.Maintenance = False
                        AddHandler dash.DashboardTabControl.Selecting, AddressOf TabControl_Selecting
                End Select

                dash.Show()
                'Else
                '    'Console.WriteLine("The result is: ")
                '    MessageBox.Show("Incorrect username or password!", "PODS-SIS")
            ElseIf res IsNot Nothing Then

            End If
        Else
            MessageBox.Show("Login Failed!")
        End If
    End Sub

    Private Sub TabControl_Selecting(sender As Object, e As TabControlCancelEventArgs)
        ' Index of the tab page you want to disable
        Dim tabIndexToDisable As Integer = 2 ' Replace with the index of the tab you want to disable
        If e.TabPageIndex = tabIndexToDisable Then
            ' Prevent selection of the tab
            e.Cancel = True
        End If
    End Sub
End Class