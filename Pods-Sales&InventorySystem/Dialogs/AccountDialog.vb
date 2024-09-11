
Public Class AccountDialog
    Private _data As Dictionary(Of String, String)
    Private _subject As IObservablePanel
    Private _id As String
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing,
                   Optional id As String = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
        'MessageBox.Show(data.ToString)
        _id = id
    End Sub

    Private Sub AccountDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _id IsNot Nothing Then
            AddAccountButton.Text = "Update"
            IdTextBox.Text = _id
        Else
            DeleteAccountButton.Visible = False
        End If
        '''MessageBox.Show("load")
        RoleComboBox.DataSource = BaseAccount.FillByRoles() '.DefaultView
        RoleComboBox.DisplayMember = "role"
        RoleComboBox.SelectedItem = "id"
    End Sub

    Private Sub AddAccountButton_Click(sender As Object, e As EventArgs) Handles AddAccountButton.Click
        'Try
        '    'Guna2TextBox1.BorderColor = Color.Red
        '    'Dim controls As Object() = {
        '    '    'FirstnameTextBox, MiddlenameTextBox.Text, LastnameTextBox.Text,
        '    'AddressTextBox.Text, UsernameTextBox.Text, PasswordTextBox.Text
        '    '}
        '    'MessageBox.Show(controls)
        '    'Dim types As DataInput() = {
        '    '    DataInput.STRING_NAME} ', DataInput.STRING_NAME, DataInput.STRING_NAME,
        '    ''DataInput.STRING_PHONE, DataInput.STRING_STRING,
        '    ''    DataInput.STRING_USERNAME, DataInput.STRING_PASSWORD
        '    ''}  s

        '    Dim result As New List(Of Object())
        '    For i = 0 To controls.Count - 1
        '        result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
        '    Next

        '    If Not result.Any(Function(item As Object()) Not item(0)) Then
        '        'Dim data As New Dictionary(Of String, String) From {
        '        '   {"role_id", "1"},
        '        '   {"first_name", result(1)(1)},
        '        '   {"middle_name", result(2)(1)},  
        '        '   {"last_name", result(3)(1)},
        '        '   {"address", result(4)(1)},
        '        '   {"username", result(5)(1)},
        '        '   {"password", result(6)(1)},
        '        '   {"phone_number", result(7)(1)},
        '        '}

        '        Dim data As New Dictionary(Of String, String) From {
        '           {"first_name", result(0)(1)}}


        '        MessageBox.Show("pass")
        '        'Dim baseCommand As New BaseAccount(data)
        '        'Dim invoker As ICommandInvoker = Nothing
        '        'invoker = New AddCommand(baseCommand)
        '        'invoker?.Execute()
        '        '_subject.NotifyObserver()
        '        'Me.Close()
        '    Else
        '        MessageBox.Show("Please fill out all textboxes or provide all valid input.")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try



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
End Class
