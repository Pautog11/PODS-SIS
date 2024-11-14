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
        Dim dt As DataTable = BaseTransaction.FetchDiscounts
        DiscountComboBox.DataSource = dt.DefaultView
        DiscountComboBox.DisplayMember = "discount"

        If _data IsNot Nothing Then
            Reference_number.Text = _data.Item("transaction_number")
            SubtotalTextBox.Text = _data.Item("subtotal")
            VatTextBox.Text = _data.Item("vat")
            DiscountComboBox.Text = _data.Item("discount")
            TotalTextBox.Text = _data.Item("total")
            DateLabel.Text = _data.Item("date")
            CashTextBox.Text = _data.Item("cash")

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
        Else
            Reference_number.Text = Helpers.GenInvoiceNumber(InvoiceType.Transaction)
            'Label2.Text = DateAndTime.Now
            DateLabel.Text = DateAndTime.Now.ToString("F")
        End If
        'TransactionDataGridView.Columns.Item("ID").Visible = False
        SubtotalTextBox.Enabled = False
        VatTextBox.Enabled = False
        TotalTextBox.Enabled = False
        VatableTextBox.Enabled = False
        ChangeTextBox.Enabled = False
    End Sub

    Public Sub UpdateVisualData()
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
        'TransactionDataGridView.DataSource = _itemSource?.DefaultView
        'Dim total As Decimal = 0D
        'For i As Integer = 0 To TransactionDataGridView?.Rows.Count - 1
        '    Dim value As Object = TransactionDataGridView.Rows(i).Cells("TOTAL").Value
        '    If value IsNot Nothing AndAlso Decimal.TryParse(value.ToString(), total) Then
        '        total += CDec(value)
        '    End If
        'Next
        'SubtotalTextBox.Text = total.ToString("F2")


        'TotalTextBox.Text = total.ToString("F2")

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
    End Sub

    Private Sub AddItemTransactionButton_Click(sender As Object, e As EventArgs) Handles AddItemTransactionButton.Click
        Dim dialog As New TransactionCartDailog(parent:=Me)
        dialog.ShowDialog()
    End Sub

    'Private Sub AddTransactionButton_Click(sender As Object, e As EventArgs) Handles AddTransactionButton.Click
    '    If TransactionDataGridView.Rows.Count > 0 Then 'AndAlso Not result.Any(Function(item As Object()) Not item(0)) Then
    '        Dim result As New List(Of Object)() From {InputValidation.ValidateInputString(CashTextBox, DataInput.STRING_INTEGER)}
    '        If Not result.Any(Function(item As Object()) Not item(0)) Then
    '            Dim items As New List(Of Dictionary(Of String, String))()
    '            Dim baseCommand As ICommandPanel ' = Nothing
    '            Dim invoker As ICommandInvoker
    '            Dim data As New Dictionary(Of String, String) From {
    '                {"id", If(_data?.Item("id"), String.Empty)},
    '                {"transaction_number", Reference_number.Text},
    '                {"subtotal", SubtotalTextBox.Text},
    '                {"vat", VatTextBox.Text},
    '                {"discount", DiscountComboBox.Text},
    '                {"total", TotalTextBox.Text},
    '                {"date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'DateTimePicker1.Value.ToString("yyyy/MM/dd")}
    '            }
    '            For Each row As DataGridViewRow In TransactionDataGridView.Rows
    '                ' Check if the row is not the new row added automatically at the end of DataGridView
    '                If Not row.IsNewRow Then
    '                    Dim item As New Dictionary(Of String, String) From {
    '                        {"product_id", row.Cells(0).Value},
    '                        {"price", If(row.Cells(2).Value?.ToString(), "0")},
    '                        {"quantity", If(row.Cells(3).Value?.ToString(), "0")},
    '                        {"total", If(row.Cells(4).Value?.ToString(), "0")}
    '                    }
    '                    items.Add(item)
    '                End If
    '            Next

    '            baseCommand = New BaseTransaction(data) With {
    '                .Items = items
    '            }

    '            invoker = New AddCommand(baseCommand)
    '            invoker?.Execute()
    '            Using dialog As New ReportViewerDialog(Reference_number.Text) ' Pass transaction_number to dialog
    '                dialog.ShowDialog()
    '            End Using
    '            Me.Close()
    '        Else
    '            MessageBox.Show("Enter a valid amount.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            CashTextBox.Text = ""
    '        End If
    '    Else
    '        MessageBox.Show("No product selected.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End If
    '    _subject.NotifyObserver()
    'End Sub
    Private Sub AddTransactionButton_Click(sender As Object, e As EventArgs) Handles AddTransactionButton.Click
        If TransactionDataGridView.Rows.Count > 0 Then
            Dim result As New List(Of Object)() From {InputValidation.ValidateInputString(CashTextBox, DataInput.STRING_INTEGER)}

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim items As New List(Of Dictionary(Of String, String))()
                Dim baseCommand As ICommandPanel
                Dim invoker As ICommandInvoker

                Dim data As New Dictionary(Of String, String) From {
                {"id", If(_data?.Item("id"), String.Empty)},
                {"transaction_number", Reference_number.Text},
                {"subtotal", SubtotalTextBox.Text},
                {"vat", VatTextBox.Text},
                {"discount", DiscountComboBox.Text},
                {"total", TotalTextBox.Text},
                {"date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")},
                {"cash", CashTextBox.Text}
            }

                For Each row As DataGridViewRow In TransactionDataGridView.Rows
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

                Using dialog As New ReportViewerDialog(Reference_number.Text) 
                    dialog.ShowDialog()
                End Using

                Me.Close()
            Else
                MessageBox.Show("Enter a valid amount.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                CashTextBox.Text = ""
            End If
        Else
            MessageBox.Show("No product selected.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        _subject.NotifyObserver()
    End Sub


    'Private Sub DiscountTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles DiscountTextBox.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        Dim discount As Decimal
    '        If Not Decimal.TryParse(DiscountTextBox.Text, discount) OrElse DiscountTextBox.Text = "" Then
    '            MessageBox.Show("Invalid discount format. Please enter a valid number.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            DiscountTextBox.Text = 0
    '            TotalTextBox.Text = SubtotalTextBox.Text
    '        Else
    '            discount = SubtotalTextBox.Text * (DiscountTextBox.Text / 100)
    '            TotalTextBox.Text = SubtotalTextBox.Text - discount
    '        End If
    '    End If
    'End Sub

    Private Sub TransactionDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionDataGridView.CellClick
        MsgBox("How")
    End Sub

    Private Sub BarcodeTextBox_KeyDown(sender As Object, e As KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    'Dim res As New List(Of Object()) From {InputValidation.ValidateInputString(BarcodeTextBox, DataInput.STRING_INTEGER)}
        '    'If Not res.Any(Function(item As Object()) Not item(0)) Then
        '    If Guna2ImageButton2.Text IsNot Nothing Then
        '        Dim dt As DataTable = BaseTransaction.SelectProductsByBarcode(BarcodeTextBox.Text)
        '        If BarcodeTextBox.Text.Length <= 13 AndAlso dt.Rows.Count > 0 Then
        '            Dim data As New Dictionary(Of String, String)()
        '            For Each row As DataRow In dt.Rows

        '                For Each column As DataColumn In dt.Columns
        '                    ' Access the data in each column for the current row
        '                    Dim columnName As String = column.ColumnName  ' Get the column name
        '                    Dim columnValue As String = row(columnName).ToString()  ' Get the value from the current row

        '                    ' Do something with the data (for example, display it)
        '                    'MessageBox.Show($"Column: {columnName}, Value: {columnValue}")
        '                    data.Add(columnName, columnValue)
        '                Next
        '            Next
        '            Dim dialog As New TransactionCartDailog(data:=data, )
        '            dialog.ShowDialog()
        'Dim productName As String = dt.Rows(0).Item("product_name").ToString()
        'Dim productSubCategory As String = BaseSubCategory.Fillsubcategorybyid(dt.Rows(0).Item("subcategory_id").ToString())

        '' Check if the product name already exists in the ComboBox
        'If Not ProductComboBox.Items.Contains(productName) Then
        '    ' If not, add the product name to the ComboBox
        '    ProductComboBox.Items.Add(productName)
        'End If
        'End If

        'If Not SubcategoryComboBox.Items.Contains(productSubCategory) Then
        '    ' If not, add the product name to the ComboBox
        '    SubcategoryComboBox.Items.Add(productSubCategory)
        'End If
        'ProductComboBox.SelectedItem = dt.Rows(0).Item("product_name").ToString()
        'ProductComboBox.Text = dt.Rows(0).Item("product_name").ToString()

        ''ProductComboBox.Items.Add(dt.Rows(0).Item("product_name").ToString())
        'StocksTextBox.Text = dt.Rows(0).Item("quantity").ToString()
        'PriceTextBox.Text = dt.Rows(0).Item("product_price").ToString()
        'e.Handled = True
        'Else
        '            MessageBox.Show("No, product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            BarcodeTextBox.Text = ""
        '        End If
        '    Else
        '        MessageBox.Show("Barcode not valid!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        'BarcodeTextBox.Text = ""
        '        'Return
        '    End If
        'End If
        'BarcodeTextBox.Text = ""
    End Sub

    Private Sub DiscountComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles DiscountComboBox.SelectionChangeCommitted
        Dim discount As Decimal
        'If Not Decimal.TryParse(DiscountComboBox.Text, discount) OrElse DiscountComboBox.Text = "" Then
        '    '    MessageBox.Show("Invalid discount format. Please enter a valid number.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    '    DiscountTextBox.Text = 0
        '    '    TotalTextBox.Text = SubtotalTextBox.Text
        '    'Else
        discount = SubtotalTextBox.Text * (DiscountComboBox.Text / 100)
            TotalTextBox.Text = SubtotalTextBox.Text - discount
        'End If
    End Sub

    Private Sub CashTextBox_TextChanged(sender As Object, e As EventArgs) Handles CashTextBox.TextChanged
        Dim total As Decimal = 0D
        Dim cash As Decimal = 0D

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
    End Sub
    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Using dialog As New ReportViewerDialog(Reference_number.Text)
            dialog.ShowDialog()
        End Using
    End Sub

    'Private Sub DiscountTextBox_Leave(sender As Object, e As EventArgs) Handles DiscountTextBox.Leave
    '    Dim discount As Decimal
    '    If Not Decimal.TryParse(DiscountTextBox.Text, discount) OrElse DiscountTextBox.Text = 0 Then
    '        MessageBox.Show("Invalid discount format. Please enter a valid number.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        DiscountTextBox.Text = 0
    '        TotalTextBox.Text = SubtotalTextBox.Text
    '    Else
    '        discount = SubtotalTextBox.Text * (DiscountTextBox.Text / 100)
    '        TotalTextBox.Text = SubtotalTextBox.Text - discount
    '    End If
    'End Sub


    'Private Sub DiscountTextBox(sender As Object, e As KeyEventArgs) Handles DiscountTextBox
    '    If e.KeyCode = Keys.Enter Then

    '    End If
    'End Sub
End Class
