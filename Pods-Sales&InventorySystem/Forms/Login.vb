Public Class Login
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Try
            Dim res As Object() = Nothing
            Dim controls As Object() = {UsernameTextBox, PasswordTextBox}
            Dim types As DataInput() = {DataInput.STRING_USERNAME, DataInput.STRING_USERNAME}

            Dim vres As New List(Of Object())
            For i = 0 To controls.Count - 1
                vres.Add(InputValidation.ValidateInputString(controls(i), types(i)))
            Next

            If Not vres.Any(Function(item As Object()) Not item(0)) Then
                MsgBox("good")
            Else
                Throw New Exception("Fcuk")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ''MsgBox("fuck")

    End Sub
End Class