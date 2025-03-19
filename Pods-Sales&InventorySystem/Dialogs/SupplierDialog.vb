Imports System.Windows.Forms

Public Class SupplierDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel
    Private Allow As Integer = 0
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub

    Private Sub SupplierDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                AddSupplierButton.Text = "Update"
                CompanyNameTextBox.Text = _data("company_name")
                CPTextBox.Text = _data("company_contact_number")
                CompanyAddressTextBox.Text = _data("company_address")
                'FirstnameTextBox.Text = _data("first_name")
                'LastnameTextBox.Text = _data("last_name")
                'PhoneNumberTextBox.Text = _data("phone_number")

                If BaseSupplier.AllowsRefund(_data.Item("id")) = 1 Then
                    CheckBox.Checked = True
                Else
                    CheckBox.Checked = False
                End If

                DeleteSupplierButton.Visible = False
            Else
                DeleteSupplierButton.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddSupplierButton_Click(sender As Object, e As EventArgs) Handles AddSupplierButton.Click
        Try
            Dim controls As Object() = {
                CompanyNameTextBox, CPTextBox, CompanyAddressTextBox
            }
            Dim types As DataInput() = {
                DataInput.STRING_NAME, DataInput.STRING_TEL, DataInput.STRING_STRING
            }
            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                Dim validationResult = TryCast(result(i), Object())
                If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                    If Not validationResult(0) = True Then
                        Exit Sub
                    End If
                Else
                    Throw New Exception
                End If
            Next

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim data As New Dictionary(Of String, String) From {
                    {"id", _data?.Item("id")},
                    {"company_name", result(0)(1)},
                    {"company_contact_number", result(1)(1)},
                    {"company_address", result(2)(1)},
                    {"allow_refund", Allow}
                }
                Dim baseCommand As New BaseSupplier(data)
                Dim invoker As ICommandInvoker = Nothing
                If BaseSupplier.Exists(result(0)(1)) = 0 AndAlso _data Is Nothing Then          'BaseAccount.Exists(result(4)(1)) = 0 AndAlso
                    invoker = New AddCommand(baseCommand)
                ElseIf _data IsNot Nothing Then
                    invoker = New UpdateCommand(baseCommand)
                Else
                    MessageBox.Show("Supplier name exists!")
                End If
                invoker?.Execute()
                _subject.NotifyObserver()
                Me.Close()
                'Exit Sub
            Else
                MessageBox.Show("Please fill out all textboxes or provide all valid inputs.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteSupplierButton_Click(sender As Object, e As EventArgs) Handles DeleteSupplierButton.Click
        Dim baseCommand As New BaseSupplier(_data)
        Dim invoker As New DeleteCommand(baseCommand)
        invoker?.Execute()
        _subject.NotifyObserver()
        Me.Close()
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox.CheckedChanged
        If CheckBox.Checked Then
            Allow = 1
        Else
            Allow = 0
        End If
    End Sub
End Class
