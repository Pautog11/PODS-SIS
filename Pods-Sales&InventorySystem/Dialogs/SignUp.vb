Imports System.Windows.Forms

Public Class SignUp
    Private ReadOnly _data As Dictionary(Of String, String)

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddAccountButton_Click(sender As Object, e As EventArgs) Handles AddAccountButton.Click
        Try
            Dim controls As Object() = {
                FirstnameTextBox, LastnameTextBox, Phone_numberTextBox, AddressTextBox, UsernameTextBox, PasswordTextBox
            }
            Dim types As DataInput() = {
                DataInput.STRING_NAME, DataInput.STRING_NAME, DataInput.STRING_PHONE, DataInput.STRING_STRING, DataInput.STRING_USERNAME, DataInput.STRING_PASSWORD
            }

            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                If Not CType(result(i), Object())(0) AndAlso Not String.IsNullOrEmpty(controls(i).Text) Then
                    Exit Sub
                End If
            Next

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim data As New Dictionary(Of String, String) From {
                    {"id", _data?.Item("id")},
                    {"role_id", 1},
                    {"status_id", 1},
                    {"first_name", result(0)(1)},
                    {"last_name", result(1)(1)},
                    {"phone_number", result(2)(1)},
                    {"address", result(3)(1)},
                    {"username", result(4)(1)},
                    {"password", result(5)(1)}
                }
                Dim baseCommand As New BaseAccount(data)
                Dim invoker As ICommandInvoker = Nothing
                If BaseAccount.Exists(result(4)(1)) = 0 AndAlso _data Is Nothing Then
                    invoker = New AddCommand(baseCommand)
                    invoker?.Execute()
                    Me.Close()
                Else
                    MessageBox.Show("Username exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Please fill out all textboxes or provide all valid inputs.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
