Public Class PosPanel
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Public _itemSource As DataTable
    Dim WithEvents _timer As New Timer()
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblproductsTableAdapter
    'Dim autocompleteList As New AutoCompleteStringCollection()
    Private Sub PosPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim dt As DataTable = BaseTransaction.FetchDiscounts
        DiscountComboBox.DataSource = dt.DefaultView
        DiscountComboBox.DisplayMember = "des"
        DiscountComboBox.ValueMember = "discount"

        _timer.Interval = 1000
        _timer.Start()
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        Reference_number.Text = Helpers.GenInvoiceNumber(InvoiceType.Transaction)
        Datepurchased.Text = DateAndTime.Now.ToString("F")

        SearchTextbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        SearchTextbox.AutoCompleteSource = AutoCompleteSource.CustomSource
        SearchTextbox.AutoCompleteCustomSource = BaseProduct.PopulateAutoCompleteList
    End Sub
    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
        Using dialog As New TransactionProductDailog(parent:=Me)
            dialog.ShowDialog()
        End Using
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles _timer.Tick
        Datepurchased.Text = DateAndTime.Now.ToString("F")
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

    'Private Sub PopulateAutoCompleteList()
    '    Dim accountsTable As pods.viewtblproductsDataTable = _tableAapter.GetData()
    '    autocompleteList.Clear()
    '    For Each row As pods.viewtblproductsRow In accountsTable
    '        autocompleteList.Add(row.PRODUCT)
    '    Next
    'End Sub

    Private Sub SearchTextbox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTextbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            MsgBox(SearchTextbox.Text)
        End If
    End Sub

    Private Sub AddTransactionButton_Click(sender As Object, e As EventArgs) Handles AddTransactionButton.Click
        Try
            If TransactionDataGridView.Rows.Count = 0 Then
                MessageBox.Show("Please select product first.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim result As New List(Of Object)() From {InputValidation.ValidateInputString(CashTextBox, DataInput.STRING_DECIMAL)}
            'If Not result.Any(Function(item As Object()) Not item(1)) Then
            If Not result.Any(Function(item) DirectCast(item, Object())(0) = True) Then
                MessageBox.Show("Enter a valid amount.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                CashTextBox.Text = ""
                Exit Sub
            End If

            If Val(CashTextBox.Text) < Val(TotalTextBox.Text) Then
                MessageBox.Show("Insufficient funds", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim items As New List(Of Dictionary(Of String, String))()
            Dim baseCommand As ICommandPanel
            Dim invoker As ICommandInvoker

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
                        {"product_id", If(row.Cells(0).Value?.ToString(), "0")},
                        {"price", If(row.Cells(2).Value?.ToString(), "0")},
                        {"quantity", If(row.Cells(3).Value?.ToString(), "0")},
                        {"total", If(row.Cells(4).Value?.ToString(), "0")}
                    }
                    items.Add(item)
                End If
            Next

            baseCommand = New BaseTransaction(data) With {.Items = items}
            invoker = New AddCommand(baseCommand)
            invoker?.Execute()
            Clear()
            _subject.NotifyObserver()

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Clear()
        TransactionDataGridView.Rows.Clear()
        VatTextBox.Text = ""
        VatableTextBox.Text = ""
        SubtotalTextBox.Text = ""
        DiscountComboBox.Text = ""
        TotalTextBox.Text = ""
        CashTextBox.Text = ""
        ChangeTextBox.Text = ""
    End Sub
End Class
