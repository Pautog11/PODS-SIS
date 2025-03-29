Imports System.Windows.Forms

Public Class VendorDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub
    Private Sub VendorDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = BaseSupplier.FetchCompany
        CompanyComboBox.DataSource = dt
        CompanyComboBox.DisplayMember = "name"
        CompanyComboBox.ValueMember = "id"

        If _data IsNot Nothing Then
            CompanyComboBox.Text = _data.Item("company")
            FirstNameTextBox.Text = _data.Item("first_name")
            LastnameTextBox.Text = _data.Item("last_name")
            ContactTextBox.Text = _data.Item("contact_number")

            AddVendorButton.Text = "Update"
        Else
            If dt.Rows.Count > 0 Then
                CompanyComboBox.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub AddVendorButton_Click(sender As Object, e As EventArgs) Handles AddVendorButton.Click
        Try
            Dim controls As Object() = {
              CompanyComboBox, FirstNameTextBox, LastnameTextBox, ContactTextBox
            }
            Dim types As DataInput() = {
                 DataInput.STRING_STRING, DataInput.STRING_NAME, DataInput.STRING_NAME, DataInput.STRING_PHONE
            }
            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                Dim validationResult = TryCast(result(i), Object())
                If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                    If Not validationResult(0) = True Then
                        Exit Sub
                    End If
                End If
            Next

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim data As New Dictionary(Of String, String) From {
                    {"id", _data?.Item("id")},
                    {"supplier_id", CompanyComboBox.SelectedItem("id")},
                    {"first_name", result(1)(1)},
                    {"last_name", result(2)(1)},
                    {"contact_number", result(3)(1)}
                }
                Dim baseCommand As New BaseVendor(data)
                Dim invoker As ICommandInvoker = Nothing

                If BaseVendor.ContactNumberExists(result(3)(1)) = 1 Then
                    If BaseVendor.ContactNumberExistsWithId(_data.Item("id"), result(3)(1)) = 1 Then
                        'Return
                    Else
                        MessageBox.Show("Phone number exist!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End If

                If BaseVendor.Exists(result(1)(1), result(2)(1)) = 0 AndAlso _data Is Nothing Then
                    invoker = New AddCommand(baseCommand)
                ElseIf _data IsNot Nothing Then
                    invoker = New UpdateCommand(baseCommand)
                Else
                    MessageBox.Show("Vendor exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                invoker?.Execute()
                _subject.NotifyObserver()
                Me.Close()
            Else
                MessageBox.Show("Please provide valid inputs.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
