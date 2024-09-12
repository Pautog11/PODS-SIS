
Public Class AccountDialog
    Private _data As Dictionary(Of String, String)
    Private _subject As IObservablePanel
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
        'MessageBox.Show(data.ToString)
    End Sub

    Private Sub AccountDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _data IsNot Nothing Then
            AddAccountButton.Text = "Update"

            RoleComboBox.DataSource = BaseAccount.FillByRoles().DefaultView
            RoleComboBox.DisplayMember = "role"
            RoleComboBox.SelectedItem = "id"

            IdTextBox.Text = _data.Item("id")
            RoleComboBox.SelectedItem = _data.Item("role")
            StatusTextBox.Text = _data.Item("status")
            FirstnameTextBox.Text = _data.Item("first_name")
            MiddlenameTextBox.Text = _data.Item("middle_name")
            LastnameTextBox.Text = _data.Item("last_name")
            Phone_numberTextBox.Text = _data.Item("phone_number")
            AddressTextBox.Text = _data.Item("address")
            UsernameTextBox.Text = _data.Item("username")
            PasswordTextBox.Text = _data.Item("password")
            MsgBox(_data.Item("role"))
        Else
            RoleComboBox.DataSource = BaseAccount.FillByRoles().DefaultView
            RoleComboBox.DisplayMember = "role"
            RoleComboBox.SelectedItem = "id"

            DeleteAccountButton.Visible = False
        End If
    End Sub

    Private Sub AddAccountButton_Click(sender As Object, e As EventArgs) Handles AddAccountButton.Click
        Try
            'Guna2TextBox1.BorderColor = Color.Red
            Dim controls As Object() = {
                FirstnameTextBox, MiddlenameTextBox, LastnameTextBox,
                Phone_numberTextBox, AddressTextBox, UsernameTextBox, PasswordTextBox
            }
            'MessageBox.Show(controls)
            Dim types As DataInput() = {
                DataInput.STRING_NAME, DataInput.STRING_NAME, DataInput.STRING_NAME,
                DataInput.STRING_PHONE, DataInput.STRING_STRING, DataInput.STRING_USERNAME, DataInput.STRING_PASSWORD
            }

            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                'result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
            Next

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                'Dim data As New Dictionary(Of String, String) From {
                '   {"role_id", StatusTextBox.Text},
                '   {"first_name", result(0)(1)},
                '   {"middle_name", result(1)(1)},
                '   {"last_name", result(2)(1)},
                '   {"phone_number", result(3)(1)},
                '   {"address", result(4)(1)},
                '   {"username", result(5)(1)},
                '   {"password", result(6)(1)}
                '}

                Dim data As New Dictionary(Of String, String) From {
                   {"role_id", "1"},
                   {"first_name", "dipota"},
                   {"middle_name", "dipota"},
                   {"last_name", "dipota"},
                   {"phone_number", "456465465465"},
                   {"address", "dipota"},
                   {"username", "dipota"},
                   {"password", "dipota"}
                }

                Dim baseCommand As New BaseAccount(data)
                Dim invoker As ICommandInvoker = Nothing
                invoker = New AddCommand(baseCommand)
                invoker?.Execute()
                _subject.NotifyObserver()
                Me.Close()
            Else
                MessageBox.Show("Please fill out all textboxes or provide all valid input.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



        '===============================================================
        'FirstnameTextBox.BorderColor = Color.Red

        'If String.IsNullOrEmpty(FirstnameTextBox.Text) Then
        '    ShakeControl(FirstnameTextBox)
        'End If
    End Sub

    Private Sub DeleteAccountButton_Click(sender As Object, e As EventArgs) Handles DeleteAccountButton.Click

        'Dim baseCommand As New BaseAccount()
        'Dim invoker As New DeleteCommand(baseCommand)

        'invoker.Execute()
        '_subject.NotifyObserver()
        'Me.Close()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

    End Sub
End Class
