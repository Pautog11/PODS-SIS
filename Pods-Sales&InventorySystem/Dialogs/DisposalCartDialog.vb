Imports System.Windows.Forms

Public Class DisposalCartDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel
    Public _itemSource As DataTable
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub

    Private Sub DisposalCartDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DiposalRefTextBox.Text = Helpers.GenInvoiceNumber(InvoiceType.Disposal)
            DatePicker.Value = DateTime.Now
            DatePicker.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Try
            Dim dialog As New DiposalProductDialog(parent:=Me)
            dialog.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdateVisualData()
        Try
            DisposalDataGridView.DataSource = _itemSource?.DefaultView
            Dim total As Decimal = 0
            For i = 0 To DisposalDataGridView?.Rows.Count - 1
                total += DisposalDataGridView.Rows(i).Cells("TOTAL").Value
            Next
            totallabel.Text = total
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            'Dim controls As Object() = {SupplierNameComboBox, VendorComboBox, TransactionDeliveryTextBox}

            'Dim types As DataInput() = {DataInput.STRING_STRING, DataInput.STRING_STRING, DataInput.STRING_STRING}

            'Dim result As New List(Of Object())
            'For i = 0 To controls.Count - 1
            '    result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
            '    Dim validationResult = TryCast(result(i), Object())
            '    If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
            '        If Not validationResult(0) = True Then
            '            Exit Sub
            '        End If
            '    End If
            'Next

            If DisposalDataGridView.Rows.Count > 0 Then 'AndAlso Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim items As New List(Of Dictionary(Of String, String))()
                Dim baseCommand As ICommandPanel
                Dim invoker As ICommandInvoker
                Dim data As New Dictionary(Of String, String) From {
                    {"id", If(_data?.Item("id"), String.Empty)},
                    {"reference_number", If(String.IsNullOrEmpty(DiposalRefTextBox.Text) OrElse DiposalRefTextBox.Text = "", 0, DiposalRefTextBox.Text)},
                    {"total", If(String.IsNullOrEmpty(totallabel.Text) OrElse totallabel.Text = "", 0, totallabel.Text)}
                }

                For Each row As DataGridViewRow In DisposalDataGridView.Rows
                    Dim item As New Dictionary(Of String, String) From {
                        {"delivery_items_id", row.Cells(0).Value},
                        {"product_id", row.Cells(1).Value},
                        {"from", row.Cells(2).Value},
                        {"drc", 1},
                        {"batch_number", If(row.Cells(5).Value?.ToString(), "")},
                        {"expiration_date", If(row.Cells(6).Value?.ToString(), "")},
                        {"price", If(row.Cells(7).Value?.ToString(), "0")},
                        {"quantity", If(row.Cells(8).Value?.ToString(), "0")}
                    }
                    items.Add(item)
                Next

                baseCommand = New BaseDisposal(data) With {.Items = items}

                'If BaseDelivery.Exists(result(2)(1)) = 0 Then
                invoker = New AddCommand(baseCommand)
                invoker?.Execute()
                _subject.NotifyObserver()
                Me.Close()
                'Else
                '    MessageBox.Show("Transaction reference is already exist!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'End If
            Else
                MessageBox.Show("Please select a product first.!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
