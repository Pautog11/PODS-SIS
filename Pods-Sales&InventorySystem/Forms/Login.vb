﻿Public Class Login
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
                If My.Settings.myid = 1 Then
                    dash.Maintenance.Visible = False
                End If
                dash.Show()
            Else
                MessageBox.Show("Incorrect username or password!", "PODS-SIS")
            End If
            'MsgBox("good")
            'Else
            '    MessageBox.Show("Login Failed!")
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        MsgBox(My.Settings.myid)
    End Sub
End Class