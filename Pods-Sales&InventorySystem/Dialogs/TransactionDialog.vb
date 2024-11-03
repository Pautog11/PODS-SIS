Imports System.Windows.Forms

Public Class TransactionDialog
    Public _itemSource As DataTable
    Private ReadOnly _subject As IObservablePanel
    Private ReadOnly _data As Dictionary(Of String, String)

    Public Sub New(Optional subject As IObservablePanel = Nothing,
                   Optional data As Dictionary(Of String, String) = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub

    Private Sub TransactionDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _data IsNot Nothing Then
            Reference_number.Text = _data.Item("transaction_number")
        Else
            Reference_number.Text = Helpers.GenInvoiceNumber(InvoiceType.Transaction)
            'Label2.Text = DateAndTime.Now
            DateLabel.Text = DateAndTime.Now.ToString("F")
        End If
    End Sub

    Public Sub UpdateVisualData()
        TransactionDataGridView.DataSource = _itemSource?.DefaultView
        Dim total As Integer = 0
        For i = 0 To TransactionDataGridView?.Rows.Count - 1
            total += TransactionDataGridView.Rows(i).Cells("TOTAL").Value
        Next
        SubtotalLabel.Text = total
        TotalLabel.Text = total
    End Sub

    Private Sub AddItemTransactionButton_Click(sender As Object, e As EventArgs) Handles AddItemTransactionButton.Click
        Dim dialog As New TransactionCartDailog(parent:=Me)
        dialog.ShowDialog()
    End Sub

    Private Sub AddTransactionButton_Click(sender As Object, e As EventArgs) Handles AddTransactionButton.Click
        'Dim result As New List(Of Object)()
        'result.Add(InputValidation.ValidateInputString(TransactionDeliveryTextBox, DataInput.STRING_STRING))

        If TransactionDataGridView.Rows.Count > 0 Then 'AndAlso Not result.Any(Function(item As Object()) Not item(0)) Then
            Dim items As New List(Of Dictionary(Of String, String))()
            Dim baseCommand As ICommandPanel ' = Nothing
            Dim invoker As ICommandInvoker
            Dim data As New Dictionary(Of String, String) From {
            {"id", If(_data?.Item("id"), String.Empty)},
            {"transaction_number", Reference_number.Text},
            {"subtotal", SubtotalLabel.Text},
            {"vat", VatLabel.Text},
            {"discount", DiscountTextBox.Text},
            {"total", TotalLabel.Text},
            {"date", "2021-12-31"} 'DateTimePicker1.Value.ToString("yyyy/MM/dd")}
            }

            For Each row As DataGridViewRow In TransactionDataGridView.Rows
                ' Check if the row is not the new row added automatically at the end of DataGridView
                If Not row.IsNewRow Then
                    Dim item As New Dictionary(Of String, String) From {
                        {"product_id", row.Cells(0).Value},
                        {"price", If(row.Cells(2).Value?.ToString(), "0")},
                        {"quantity", If(row.Cells(3).Value?.ToString(), "0")},
                        {"total", If(row.Cells(4).Value?.ToString(), "0")}
                    }
                    items.Add(item)
                End If
            Next

            baseCommand = New BaseTransaction(data) With {
                .Items = items
            }

            invoker = New AddCommand(baseCommand)
            invoker?.Execute()
            _subject.NotifyObserver()
            Me.Close()
            'Else
            '    MessageBox.Show("No product selected!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    'Private Sub Guna2TextBox1_Click(sender As Object, e As EventArgs) Handles Guna2TextBox1.Click
    '    Dim discountValue As Decimal
    '    Dim dis As Decimal = subtotalValue - (subtotalValue * (discountValue / 100))
    '    Label7.Text = dis.ToString("F2")

    '    Label7.Text = Label11.Text * Guna2TextBox1.Text / 100
    'End Sub
End Class
