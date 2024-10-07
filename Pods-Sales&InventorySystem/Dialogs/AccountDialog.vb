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
            'To update the button from add to update
            AddAccountButton.Text = "Update"

            'IdTextBox.Visible = False
            'IdTextBox.Text = _data.Item("id")

            'For fetching data to combobox
            RoleComboBox.Text = BaseAccount.Fetchroles(_data.Item("role"))
            StatusComboBox.Text = BaseAccount.Fetchstatus(_data.Item("status"))

            'To populate data to texboxes
            FirstnameTextBox.Text = _data.Item("first_name")
            LastnameTextBox.Text = _data.Item("last_name")
            Phone_numberTextBox.Text = _data.Item("phone_number")
            AddressTextBox.Text = _data.Item("address")
            UsernameTextBox.Text = _data.Item("username")

            'PasswordTextBox.Text = BaseAccount.Fetchroles(_data.Item("role"))
            'UsernameTextBox.ReadOnly = True
            'MsgBox(_data.Item("status"))

        Else
            'Auto select "None" for roles
            roles.Rows.Add(-1, "None")
            RoleComboBox.SelectedValue = -1

            'To disable the delete button
            DeleteAccountButton.Visible = False

            'IdTextBox.Visible = False
            StatusComboBox.Visible = False
        End If
    End Sub

    Private Sub AddAccountButton_Click(sender As Object, e As EventArgs) Handles AddAccountButton.Click
        Dim controls As Object() = {
            FirstnameTextBox, LastnameTextBox, Phone_numberTextBox, AddressTextBox, UsernameTextBox, PasswordTextBox
        }
        Dim types As DataInput() = {
            DataInput.STRING_NAME, DataInput.STRING_NAME, DataInput.STRING_PHONE, DataInput.STRING_STRING, DataInput.STRING_USERNAME, DataInput.STRING_PASSWORD
        }
        Dim result As New List(Of Object())
        For i = 0 To controls.Count - 1
            result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
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
            ElseIf _data IsNot Nothing Then
                invoker = New UpdateCommand(baseCommand)
            Else
                MessageBox.Show("Username exists!")
                Return
            End If
            invoker?.Execute()
            _subject.NotifyObserver()
            Me.Close()
        Else
            MessageBox.Show("Please fill out all textboxes or provide all valid inputs.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DeleteAccountButton_Click(sender As Object, e As EventArgs) Handles DeleteAccountButton.Click
        'Const SUPER_ADMIN As Integer = 1
        'Const ADMIN As Integer = 2

        If BaseAccount.ScalarRoleName(_data.Item("role")) = 1 Then 'Or BaseAccount.ScalarRoleName(_data.Item("role")) = 2 Then
            If _data.Item("id") <> My.Settings.roleId Then
                Dim baseCommand As New BaseAccount(_data)
                Dim invoker As New DeleteCommand(baseCommand)
                invoker?.Execute()
                _subject.NotifyObserver()
                Me.Close()
            Else
                MessageBox.Show("You can't delete your account.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Action can't be performed.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
