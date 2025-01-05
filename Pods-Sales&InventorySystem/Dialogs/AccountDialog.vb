Imports System.Windows.Forms

Public Class AccountDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub
    Private Sub Account_Dialog(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordTextBox.UseSystemPasswordChar = True ' Show password
        Guna2TextBox1.UseSystemPasswordChar = True ' Show password
        Try
            'For Roles
            Dim roles As DataTable = BaseAccount.FillByRoles()
            RoleComboBox.DataSource = roles
            RoleComboBox.DisplayMember = "role"
            RoleComboBox.ValueMember = "id"

            'For Status
            StatusComboBox.DataSource = BaseAccount.FillByStatus()
            StatusComboBox.DisplayMember = "status"
            StatusComboBox.SelectedItem = "id"

            If _data IsNot Nothing Then
                AddAccountButton.Text = "Update"

                'For fetching data to combobox
                RoleComboBox.Text = BaseAccount.Fetchroles(_data.Item("role"))
                StatusComboBox.Text = BaseAccount.Fetchstatus(_data.Item("status"))

                'To populate data to texboxes
                FirstnameTextBox.Text = _data.Item("first_name")
                LastnameTextBox.Text = _data.Item("last_name")
                Phone_numberTextBox.Text = _data.Item("phone_number")
                AddressTextBox.Text = _data.Item("address")
                UsernameTextBox.Text = _data.Item("username")

                'For Visibility
                'UsernameTextBox.Enabled = False
                DeleteAccountButton.Visible = False
                PasswordTextBox.Visible = False
                'RoleComboBox.Enabled = False
                'End If

                If RoleComboBox.Text = "Super Admin" Then
                    RoleComboBox.Enabled = False
                    StatusComboBox.Enabled = False
                Else
                    Dim rowsToRemove As New List(Of DataRow)()
                    For Each row As DataRow In roles.Rows
                        If My.Settings.roleId = 1 Then
                            If row("id") = 1 Then
                                rowsToRemove.Add(row) ' Add the row to be removed later
                                Exit For ' Exit the loop once the row is removed
                            End If
                        Else
                            If RoleComboBox.Text = "Admin" Then
                                RoleComboBox.Enabled = False
                                StatusComboBox.Enabled = False
                            Else
                                If row("id") = 1 Or row("id") = 2 Then
                                    rowsToRemove.Add(row)
                                End If
                            End If
                        End If
                    Next
                    For Each row As DataRow In rowsToRemove
                        roles.Rows.Remove(row)
                    Next
                End If


            Else
                Dim rowsToRemove As New List(Of DataRow)()
                For Each row As DataRow In roles.Rows
                    If My.Settings.roleId = 1 Then
                        If row("id") = 1 Then
                            rowsToRemove.Add(row) ' Add the row to be removed later
                            Exit For ' Exit the loop once the row is removed
                        End If
                    Else
                        If row("id") = 1 Or row("id") = 2 Then
                            rowsToRemove.Add(row)
                        End If
                    End If
                Next
                For Each row As DataRow In rowsToRemove
                    roles.Rows.Remove(row)
                Next

                'For Visibility
                DeleteAccountButton.Visible = False
                StatusComboBox.Visible = False
                ChangePassButton.Visible = False
            End If
        Catch ex As Exception

        End Try
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
                'result.Add(InputValidation.ValidateInputString(controls(i), types(i)))

                If _data IsNot Nothing Then
                    If controls(i) IsNot PasswordTextBox Then
                        result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                    Else
                        ' Skip password validation and add it directly
                        result.Add(New Object() {True, PasswordTextBox.Text}) ' Assuming password is valid for now
                    End If
                Else
                    result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                End If

                If Not CType(result(i), Object())(0) AndAlso Not String.IsNullOrEmpty(controls(i).Text) Then
                    Exit Sub
                End If
            Next
            If RoleComboBox.SelectedValue = -1 OrElse RoleComboBox.SelectedIndex = -1 Then
                'MessageBox.Show("Please select a role", "POS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim data As New Dictionary(Of String, String) From {
                    {"id", _data?.Item("id")},
                    {"role_id", RoleComboBox.SelectedItem("id")},
                    {"status_id", StatusComboBox.SelectedItem("id")},
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
                ElseIf _data IsNot Nothing Then ' AndAlso my.Settings.myId = _data.Item("id") Then 'BaseAccount.Exists(result(4)(1)) = 0 Then
                    'My.Settings.roleId = BaseAccount.Exists(result(4)(1)) = 0
                    invoker = New UpdateCommand(baseCommand)
                Else
                    MessageBox.Show("Username exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                invoker?.Execute()
                _subject.NotifyObserver()
                Me.Close()
            Else
                MessageBox.Show("Please fill out all textboxes or provide all valid inputs.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeleteAccountButton_Click(sender As Object, e As EventArgs) Handles DeleteAccountButton.Click
        If My.Settings.roleId = _data.Item("role") Then
            MessageBox.Show("You can't delete your account.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If My.Settings.roleId >= _data.Item("role") Then
                MessageBox.Show("You can't delete super admin account.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim baseCommand As New BaseAccount(_data)
                Dim invoker As New DeleteCommand(baseCommand)
                invoker?.Execute()
                _subject.NotifyObserver()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ChangePassButton_Click(sender As Object, e As EventArgs) Handles ChangePassButton.Click
        Dim dialog As New PasswordDialog(parent:=Me, id:=_data.Item("id"))
        dialog.ShowDialog()
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
