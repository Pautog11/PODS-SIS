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
        Try
            Dim dt As DataTable = BaseTransaction.FetchDiscounts
            DiscountComboBox.DataSource = dt.DefaultView
            DiscountComboBox.DisplayMember = "des"
            DiscountComboBox.ValueMember = "discount"

            If _data IsNot Nothing Then
                Reference_number.Text = _data.Item("transaction_number")
                SubtotalTextBox.Text = _data.Item("subtotal")
                VatTextBox.Text = _data.Item("vat")
                DiscountComboBox.Text = _data.Item("discount")
                TotalTextBox.Text = _data.Item("total")
                DateLabel.Text = _data.Item("date")
                CashTextBox.Text = _data.Item("cash")
                VatableTextBox.Text = _data.Item("vatable")

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
                AddTransactionButton.Visible = False
                AddItemTransactionButton.Visible = False
                SearchItemButton.Visible = False
                CashTextBox.Enabled = False
                DiscountComboBox.Enabled = False
                'MsgBox(_data.Item("id"))
                Dim productDate As Date

                ' Parse the date from the label
                If Date.TryParse(DateLabel.Text, productDate) Then
                    Dim daysDifference As Integer = (Date.Today - productDate).Days
                    If daysDifference > 7 Then
                        ReturnButton.Enabled = False
                        'Else
                        '    ReturnButton.Enabled = True
                    End If
                End If


                If BaseTransaction.Returnbutton(_data.Item("id")) = 1 Then
                    ReturnButton.Enabled = False
                End If
            Else
                Reference_number.Text = Helpers.GenInvoiceNumber(InvoiceType.Transaction)
                DateLabel.Text = DateAndTime.Now.ToString("F")
                ReturnButton.Visible = False
            End If
            'TransactionDataGridView.Columns.Item("ID").Visible = False
            SubtotalTextBox.Enabled = False
            VatTextBox.Enabled = False
            TotalTextBox.Enabled = False
            VatableTextBox.Enabled = False
            ChangeTextBox.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdateVisualData()
        Try
            TransactionDataGridView.DataSource = _itemSource?.DefaultView
            Dim subtotal As Decimal = 0D
            For i As Integer = 0 To TransactionDataGridView.Rows.Count - 1
                Dim total As Object = TransactionDataGridView.Rows(i).Cells("TOTAL").Value
                If total IsNot Nothing Then
                    Dim add As Decimal
                    If Decimal.TryParse(total.ToString(), add) Then
                        subtotal += add
                    End If
                End If
            Next
            SubtotalTextBox.Text = subtotal.ToString("F2")
            TotalTextBox.Text = subtotal.ToString("F2")

            'For Vat
            Dim vat As Decimal = BaseTransaction.ScalarVat / 100
            'Dim subtotal As Decimal
            If Decimal.TryParse(SubtotalTextBox.Text, subtotal) Then
                Dim vatAmount As Decimal = subtotal * vat / (1 + vat)
                VatTextBox.Text = vatAmount.ToString("F2")
            End If
            Dim vatable As Decimal
            vatable = SubtotalTextBox.Text - VatTextBox.Text
            VatableTextBox.Text = vatable
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddItemTransactionButton_Click(sender As Object, e As EventArgs) Handles AddItemTransactionButton.Click
        Dim dialog As New TransactionCartDailog(parent:=Me)
        dialog.ShowDialog()
    End Sub
    Private Sub AddTransactionButton_Click(sender As Object, e As EventArgs) Handles AddTransactionButton.Click
        Try
            If TransactionDataGridView.Rows.Count > 0 Then
                Dim result As New List(Of Object)() From {InputValidation.ValidateInputString(CashTextBox, DataInput.STRING_DECIMAL)}
                If Not result.Any(Function(item As Object()) Not item(0)) Then
                    If Val(CashTextBox.Text) < Val(TotalTextBox.Text) Then
                        MessageBox.Show("Insufficient funds", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Dim items As New List(Of Dictionary(Of String, String))()
                        Dim baseCommand As ICommandPanel
                        Dim invoker As ICommandInvoker
                        Dim isSuccess As Boolean = False ' Flag to track success

                        Dim data As New Dictionary(Of String, String) From {
                        {"id", If(_data?.Item("id"), String.Empty)},
                        {"transaction_number", Reference_number.Text},
                        {"subtotal", If(String.IsNullOrEmpty(SubtotalTextBox.Text), "0", SubtotalTextBox.Text)},
                        {"vatable", If(String.IsNullOrEmpty(VatableTextBox.Text), "0", VatableTextBox.Text)},
                        {"vat", If(String.IsNullOrEmpty(VatTextBox.Text), "0", VatTextBox.Text)},
                        {"discount", If(String.IsNullOrEmpty(DiscountComboBox.Text), "0", DiscountComboBox.Text)},
                        {"total", If(String.IsNullOrEmpty(TotalTextBox.Text), "0", TotalTextBox.Text)},
                        {"date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")},
                        {"cash", If(String.IsNullOrEmpty(CashTextBox.Text), "0", CashTextBox.Text)}
                    }

                        For Each row As DataGridViewRow In TransactionDataGridView.Rows
                            If Not row.IsNewRow Then
                                Dim item As New Dictionary(Of String, String) From {
                                {"product_id", row.Cells(0).Value?.ToString()},
                                {"price", If(row.Cells(2).Value?.ToString(), "0")},
                                {"quantity", If(row.Cells(3).Value?.ToString(), "0")},
                                {"total", If(row.Cells(4).Value?.ToString(), "0")},
                                {"devid", If(row.Cells(4).Value?.ToString(), "0")}
                            }
                                items.Add(item)
                            End If
                        Next

                        baseCommand = New BaseTransaction(data) With {
                        .Items = items
                    }

                        invoker = New AddCommand(baseCommand)

                        ' Execute the transaction and check success
                        Try
                            invoker?.Execute()
                            isSuccess = True ' Mark success if no exceptions occur
                        Catch ex As Exception
                            MessageBox.Show($"Transaction failed: {ex.Message}", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End Try

                        ' Handle success case
                        If isSuccess Then
                            Dim reslt As DialogResult = MsgBox("Do you want to print a receipt?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If reslt = DialogResult.Yes Then
                                Using dialog As New ReceiptViewer(Reference_number.Text)
                                    dialog.ShowDialog()
                                End Using
                            End If
                            MessageBox.Show("Transaction completed successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        End If
                    End If
                Else
                    MessageBox.Show("Enter a valid amount.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    CashTextBox.Text = ""
                End If
            Else
                MessageBox.Show("No product selected.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            _subject.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DiscountComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles DiscountComboBox.SelectionChangeCommitted
        Try
            Dim Subtotal As Decimal
            ' Validate if SubtotalTextBox contains a valid decimal value
            If Not String.IsNullOrEmpty(SubtotalTextBox.Text) AndAlso Decimal.TryParse(SubtotalTextBox.Text, Subtotal) Then
                ' Ensure DiscountComboBox and CashTextBox have valid values
                Dim discountPercentage As Decimal
                If Decimal.TryParse(DiscountComboBox.SelectedItem("discount"), discountPercentage) Then
                    ' Calculate the discount and update the total
                    Dim discount As Decimal = Subtotal * (discountPercentage / 100)
                    Dim total As Decimal = Subtotal - discount
                    TotalTextBox.Text = total.ToString("F2") ' Format as 2 decimal points
                    ' Calculate and display change if cash is provided
                    Dim cash As Decimal
                    If Decimal.TryParse(CashTextBox.Text, cash) AndAlso cash >= total Then
                        ChangeTextBox.Text = (cash - total).ToString("C2") ' Format as currency
                    Else
                        ChangeTextBox.Text = "Insufficient funds"
                    End If
                Else
                    MessageBox.Show("Please select a valid discount percentage.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Please enter a valid subtotal.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub CashTextBox_TextChanged(sender As Object, e As EventArgs) Handles CashTextBox.TextChanged
        Try
            Dim total As Decimal
            Dim cash As Decimal
            If Not String.IsNullOrWhiteSpace(TotalTextBox.Text) AndAlso Decimal.TryParse(TotalTextBox.Text, total) AndAlso
           Not String.IsNullOrWhiteSpace(CashTextBox.Text) AndAlso Decimal.TryParse(CashTextBox.Text, cash) Then
                If cash >= total Then
                    ChangeTextBox.Text = (cash - total).ToString("C2") ' Format as currency
                Else
                    ChangeTextBox.Text = "Insufficient funds"
                End If
            Else
                ChangeTextBox.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        Try
            Dim currentDate As DateTime = DateTime.Now
            Dim selectedDate As DateTime = DateLabel.Text
            Dim sevenDaysAgo As DateTime = currentDate.AddDays(-7) ' 7 days ago
            Dim sevenDaysFromNow As DateTime = currentDate.AddDays(7) ' 7 days from today

            If selectedDate.Date >= sevenDaysAgo.Date AndAlso selectedDate.Date <= sevenDaysFromNow.Date Then
                'MsgBox("Pwedi pang i balik")
                Dim data As New Dictionary(Of String, String) From {
                    {"ref", Reference_number.Text},
                    {"date", DateLabel.Text},
                    {"delivery_id", _data.Item("id")}
                }
                Dim dialog As New ReturnCartDialog(subject:=_subject, data:=data, parent:=Me)
                dialog.ShowDialog()
            Else
                MsgBox("Sorry!, the period of time has expired!")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TransactionDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionDataGridView.CellClick
        Try
            If _data Is Nothing Then
                If TransactionDataGridView.Rows.Count > 0 Then
                    Dim selectedRows As DataGridViewSelectedRowCollection = TransactionDataGridView.SelectedRows
                    Dim row As DataGridViewRow = selectedRows(0)
                    Dim data As New Dictionary(Of String, String) From {
                        {"id", row.Cells(0).Value.ToString()},
                        {"productname", row.Cells(1).Value.ToString()},
                        {"price", row.Cells(2).Value.ToString()},
                        {"quantity", row.Cells(3).Value.ToString()}
                    }
                    Dim dialog As New TransactionCartDailog(data:=data, parent:=Me)
                    dialog.ShowDialog()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SearchItemButton_Click(sender As Object, e As EventArgs) Handles SearchItemButton.Click
        Dim dialog As New SearchDialog(parent:=Me)
        dialog.ShowDialog()
    End Sub
End Class
