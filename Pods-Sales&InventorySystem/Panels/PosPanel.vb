Public Class PosPanel
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Public _itemSource As DataTable
    Dim WithEvents _timer As New Timer()
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblproductsTableAdapter
    Dim Totalcost As Decimal = Nothing
    Private Sub PosPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        DiscountComboBox.Enabled = False
        _timer.Interval = 1000
        _timer.Start()
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        Reference_number.Text = Helpers.GenInvoiceNumber(InvoiceType.Transaction)
        Datepurchased.Text = DateAndTime.Now.ToString("F")

        TransactionDataGridView.Columns.Item("ID").Visible = False

        Dim dt As DataTable = BaseTransaction.FetchDiscounts
        DiscountComboBox.DataSource = dt.DefaultView
        DiscountComboBox.DisplayMember = "des"
        DiscountComboBox.ValueMember = "discount"

        SearchTextbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        SearchTextbox.AutoCompleteSource = AutoCompleteSource.CustomSource
        SearchTextbox.AutoCompleteCustomSource = BaseProduct.PopulateAutoCompleteList
    End Sub
    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
        Using dialog As New TransactionProductDailog(parent:=Me)
            dialog.ShowDialog()
        End Using
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles _timer.Tick
        Datepurchased.Text = DateAndTime.Now.ToString("F")
    End Sub

    Public Sub UpdateVisualData()
        Try
            TransactionDataGridView.DataSource = _itemSource?.DefaultView
            DiscountComboBox.Enabled = True
            'For subtotal
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

            'For cost
            Dim cost As Decimal = 0D
            For Each row As DataGridViewRow In TransactionDataGridView.Rows
                Dim total As Object = row.Cells("COST").Value
                If total IsNot Nothing Then
                    Dim add As Decimal
                    If Decimal.TryParse(total.ToString(), add) Then
                        cost += add  ' Add the parsed value to cost
                    End If
                End If
            Next
            'Guna2HtmlLabel3.Text = cost.ToString("F2")
            Totalcost = cost.ToString("F2")

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

    Private Sub SearchTextbox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTextbox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim res As New List(Of Object()) From {InputValidation.ValidateInputString(SearchTextbox, DataInput.STRING_STRING)}
                If Not res.Any(Function(item As Object()) Not item(0)) Then
                    Dim dt As DataTable = BaseTransaction.FetchByName(SearchTextbox.Text)
                    If dt.Rows.Count > 0 Then
                        Dim data As New Dictionary(Of String, String) From {
                            {"id", If(String.IsNullOrEmpty(dt.Rows(0).Item("idngprod").ToString()), 0, dt.Rows(0).Item("idngprod").ToString())},
                            {"product_name", If(String.IsNullOrEmpty(dt.Rows(0).Item("product_name").ToString()), 0, dt.Rows(0).Item("product_name").ToString())},
                            {"price", If(String.IsNullOrEmpty(dt.Rows(0).Item("price").ToString()), 0, dt.Rows(0).Item("price").ToString())},
                            {"stocks", If(String.IsNullOrEmpty(dt.Rows(0).Item("quantity").ToString()), 0, dt.Rows(0).Item("quantity").ToString())},
                            {"cost", If(String.IsNullOrEmpty(dt.Rows(0).Item("cost").ToString()), 0, dt.Rows(0).Item("cost").ToString())}
                        }
                        SearchTextbox.Text = ""
                        Dim dialog As New TransactionProductDailog(dat2:=data, parent:=Me)
                        dialog.ShowDialog()
                    Else
                        SearchTextbox.Text = ""
                        MessageBox.Show("No product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    SearchTextbox.Text = ""
                    MessageBox.Show("No product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
                'MessageBox.Show("Enter a valid amount.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                CashTextBox.Text = ""
                Exit Sub
            End If

            If Val(CashTextBox.Text) < Val(TotalTextBox.Text) Then
                MessageBox.Show("Insufficient funds", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If Val(Totalcost) >= Val(TotalTextBox.Text) Then
                MessageBox.Show("Invalid discount", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim items As New List(Of Dictionary(Of String, String))()
            Dim baseCommand As ICommandPanel
            Dim invoker As ICommandInvoker

            Dim data As New Dictionary(Of String, String) From {
                {"id", If(_data?.Item("id"), String.Empty)},
                {"transaction_number", Reference_number.Text},
                {"subtotal", If(String.IsNullOrEmpty(SubtotalTextBox.Text), "0", SubtotalTextBox.Text)}, '{"vatable", If(String.IsNullOrEmpty(VatableTextBox.Text), "0", VatableTextBox.Text)},
                {"vat", If(String.IsNullOrEmpty(VatTextBox.Text), "0", VatTextBox.Text)},
                {"discount", If(String.IsNullOrEmpty(DiscountComboBox.SelectedValue), "0", DiscountComboBox.SelectedValue)},
                {"total", If(String.IsNullOrEmpty(TotalTextBox.Text), "0", TotalTextBox.Text)},
                {"date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")},
                {"cash", If(String.IsNullOrEmpty(CashTextBox.Text), "0", CashTextBox.Text)}
            }

            For Each row As DataGridViewRow In TransactionDataGridView.Rows
                If Not row.IsNewRow Then
                    Dim item As New Dictionary(Of String, String) From {
                        {"product_id", If(row.Cells(0).Value?.ToString(), "0")},
                        {"price", If(row.Cells(2).Value?.ToString(), "0")},
                        {"quantity", If(row.Cells(3).Value?.ToString(), "0")}
                    }
                    items.Add(item)
                End If
            Next

            baseCommand = New BaseTransaction(data) With {.Items = items}
            invoker = New AddCommand(baseCommand)
            invoker?.Execute()
            Clear()
            _subject.NotifyObserver()
            DiscountComboBox.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Totalcost = 0
        'Guna2HtmlLabel3.Text = ""
    End Sub

    Private Sub DiscountComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles DiscountComboBox.SelectionChangeCommitted
        Try
            Dim Subtotal As Decimal
            If Not String.IsNullOrEmpty(SubtotalTextBox.Text) AndAlso Decimal.TryParse(SubtotalTextBox.Text, Subtotal) Then
                Dim discountPercentage As Decimal
                If Decimal.TryParse(DiscountComboBox.SelectedItem("discount"), discountPercentage) Then
                    Dim discount As Decimal = Subtotal * (discountPercentage / 100)
                    Dim total As Decimal = Subtotal - discount
                    TotalTextBox.Text = total.ToString("F2")
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
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TransactionDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionDataGridView.CellClick
        Try
            If TransactionDataGridView.Rows.Count > 0 Then
                Dim row As DataGridViewRow = TransactionDataGridView.SelectedRows(0)
                Dim dt As DataTable = BaseTransaction.FetchByID(If(row.Cells(0).Value?.ToString(), ""))
                If dt.Rows.Count > 0 Then
                    Dim data As New Dictionary(Of String, String) From {
                        {"id", If(String.IsNullOrEmpty(dt.Rows(0).Item("idngprod").ToString()), 0, dt.Rows(0).Item("idngprod").ToString())},
                        {"product_name", If(String.IsNullOrEmpty(dt.Rows(0).Item("product_name").ToString()), 0, dt.Rows(0).Item("product_name").ToString())},
                        {"price", If(String.IsNullOrEmpty(dt.Rows(0).Item("price").ToString()), 0, dt.Rows(0).Item("price").ToString())},
                        {"stocks", If(String.IsNullOrEmpty(dt.Rows(0).Item("quantity").ToString()), 0, dt.Rows(0).Item("quantity").ToString())}
                    }
                    Dim dialog As New TransactionProductDailog(data:=data, parent:=Me)
                    dialog.ShowDialog()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
