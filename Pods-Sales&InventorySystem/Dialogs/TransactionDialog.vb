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
            SubtotalTextBox.Text = _data.Item("subtotal")
            VatTextBox.Text = _data.Item("vat")
            DiscountTextBox.Text = _data.Item("discount")
            TotalTextBox.Text = _data.Item("total")
            DateLabel.Text = _data.Item("date")

            'Populate items 
            TransactionDataGridView.Rows.Clear()
            Dim DeliveryItems As DataTable = BaseTransaction.SelectAllTransactedItems(_data("id"))
            For Each row As DataRow In DeliveryItems.Rows
                Dim rowData As New List(Of Object)()
                For Each column As DataColumn In DeliveryItems.Columns
                    rowData.Add(row(column))
                Next
                TransactionDataGridView.Rows.Add(rowData.ToArray())
            Next
        Else
            Reference_number.Text = Helpers.GenInvoiceNumber(InvoiceType.Transaction)
            'Label2.Text = DateAndTime.Now
            DateLabel.Text = DateAndTime.Now.ToString("F")
        End If
        TransactionDataGridView.Columns.Item("ID").Visible = False
        SubtotalTextBox.Enabled = False
        VatTextBox.Enabled = False
        TotalTextBox.Enabled = False
    End Sub

    Public Sub UpdateVisualData()
        TransactionDataGridView.DataSource = _itemSource?.DefaultView
        Dim total As Decimal = 0D
        For i As Integer = 0 To TransactionDataGridView?.Rows.Count - 1
            Dim value As Object = TransactionDataGridView.Rows(i).Cells("TOTAL").Value
            If value IsNot Nothing AndAlso Decimal.TryParse(value.ToString(), total) Then
                total += CDec(value)
            End If
        Next
        SubtotalTextBox.Text = total.ToString("F2")
        TotalTextBox.Text = total.ToString("F2")

        'For Vat
        Dim vat As Decimal = BaseTransaction.ScalarVat / 100
        Dim subtotal As Decimal
        If Decimal.TryParse(SubtotalTextBox.Text, subtotal) Then
            Dim vatAmount As Decimal = subtotal * vat / (1 + vat)
            VatTextBox.Text = vatAmount.ToString("F2")
        End If
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
            {"subtotal", SubtotalTextBox.Text},
            {"vat", VatTextBox.Text},
            {"discount", DiscountTextBox.Text},
            {"total", TotalTextBox.Text},
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

    Private Sub DiscountTextBox_Leave(sender As Object, e As EventArgs) Handles DiscountTextBox.Leave
        Dim total As Decimal = Nothing
        If Not Decimal.TryParse(DiscountTextBox.Text, total) OrElse DiscountTextBox.Text = 0 Then
            MessageBox.Show("Invalid discount format. Please enter a valid number.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DiscountTextBox.Text = 0
            TotalTextBox.Text = SubtotalTextBox.Text
        Else
            total = SubtotalTextBox.Text * (DiscountTextBox.Text / 100)
            TotalTextBox.Text = total
        End If
    End Sub
End Class
