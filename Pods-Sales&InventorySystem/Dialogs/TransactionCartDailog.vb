Imports System.Windows.Forms

Public Class TransactionCartDailog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _dat2 As Dictionary(Of String, String)
    Private ReadOnly _tableAdapter As New podsTableAdapters.viewtblcategoriesTableAdapter
    Private ReadOnly _dataTable As New pods.viewtblcategoriesDataTable
    Private ReadOnly _subject As IObservablePanel
    Private ReadOnly _parent As TransactionDialog = Nothing
    Dim id As Integer = Nothing
    Public Sub New(Optional subject As IObservablePanel = Nothing,
                   Optional parent As TransactionDialog = Nothing,
                   Optional data As Dictionary(Of String, String) = Nothing,
                   Optional dat2 As Dictionary(Of String, String) = Nothing)
        InitializeComponent()
        _parent = parent
        _subject = subject
        _data = data
        _dat2 = dat2
    End Sub
    Private Sub TransactionCartDailog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _data IsNot Nothing Then
            ProductNameTextBox.Text = _data.Item("productname")
            PriceTextBox.Text = _data.Item("price")
            ' QuantityTextBox.Text = _data.Item("quantity")

            Dim dipota As Integer = BaseTransaction.ScalarStocks(_data.Item("id"))
            StocksTextBox.Text = dipota
            AddTransactionButton.Text = "Update"

            'If _data.Item("id") IsNot Nothing Then
            '    id = _data.Item("id")
            '    AddTransactionButton.Text = "Add"
            '    'VoidButton.Visible = False
            '    BarcodeTextBox.Enabled = False
            'End If
            VoidButton.Visible = False
        ElseIf _dat2 IsNot Nothing Then
            If _dat2.Item("id") IsNot Nothing Then
                id = _dat2.Item("id")

                ProductNameTextBox.Text = _dat2.Item("productname")
                PriceTextBox.Text = _dat2.Item("price")
                StocksTextBox.Text = _dat2.Item("quantity")
                AddTransactionButton.Text = "Add"
                'VoidButton.Visible = False
                BarcodeTextBox.Enabled = False
            End If
            VoidButton.Visible = False
        Else
            VoidButton.Visible = False
        End If


        'CategoryComboBox.DataSource = _tableAdapter.GetData
        'CategoryComboBox.DisplayMember = "CATEGORY"
        ProductNameTextBox.Enabled = False
        PriceTextBox.Enabled = False
        StocksTextBox.Enabled = False

        'If _data IsNot Nothing Then
        '    PriceTextBox.Text = _data.Item("product_price")


        'End If
    End Sub

    Private Sub AddTransactionButton_Click(sender As Object, e As EventArgs) Handles AddTransactionButton.Click
        Dim result As New List(Of Object()) From {InputValidation.ValidateInputString(QuantityTextBox, DataInput.STRING_INTEGER)}
        Dim is_existing As Boolean = False
        If Not result.Any(Function(item As Object()) Not item(0)) Then
            For Each item As DataGridViewRow In _parent.TransactionDataGridView.Rows
                If CInt(StocksTextBox.Text) >= QuantityTextBox.Text Then
                    If _data IsNot Nothing Then
                        If item.Cells("ID").Value.ToString() = _data.Item("ID") Then
                            item.Cells("PRODUCT").Value = ProductNameTextBox.Text
                            item.Cells("PRICE").Value = Decimal.Parse(PriceTextBox.Text)
                            item.Cells("QUANTITY").Value = CInt(QuantityTextBox.Text)
                            item.Cells("TOTAL").Value = Decimal.Parse(PriceTextBox.Text) * CInt(QuantityTextBox.Text)
                            is_existing = True
                            Exit For
                        Else
                            item.Cells("PRODUCT").Value = ProductNameTextBox.Text
                            item.Cells("PRICE").Value = Decimal.Parse(PriceTextBox.Text)
                            item.Cells("QUANTITY").Value = CInt(QuantityTextBox.Text)
                            item.Cells("TOTAL").Value = Decimal.Parse(PriceTextBox.Text) * CInt(QuantityTextBox.Text)
                            is_existing = True
                            Exit For
                        End If
                    End If
                End If
            Next

            If Not is_existing Then
                If CInt(If(String.IsNullOrEmpty(StocksTextBox.Text), 0, StocksTextBox.Text)) >= QuantityTextBox.Text Then
                    _parent.TransactionDataGridView.Rows.Add({If(IsDBNull(id), 0, id),
                                                    If(String.IsNullOrEmpty(ProductNameTextBox.Text), 0, ProductNameTextBox.Text),
                                                    If(String.IsNullOrEmpty(PriceTextBox.Text), 0, PriceTextBox.Text),
                                                    If(String.IsNullOrEmpty(QuantityTextBox.Text), 0, QuantityTextBox.Text),
                                                    CDec(PriceTextBox.Text) * CDec(QuantityTextBox.Text)
                                                    })
                Else
                    MessageBox.Show("Insufficient stocks!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            _parent.UpdateVisualData()
            Me.Close()
        Else
            MessageBox.Show("Invalid quantity!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BarcodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BarcodeTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim res As New List(Of Object()) From {InputValidation.ValidateInputString(BarcodeTextBox, DataInput.STRING_INTEGER)}
            If Not res.Any(Function(item As Object()) Not item(0)) Then
                Dim dt As DataTable = BaseTransaction.SelectProductsByBarcode(BarcodeTextBox.Text)
                If BarcodeTextBox.Text.Length <= 13 AndAlso dt.Rows.Count > 0 Then

                    id = dt.Rows(0).Item("id").ToString()
                    ProductNameTextBox.Text = dt.Rows(0).Item("product_name").ToString()

                    StocksTextBox.Text = dt.Rows(0).Item("quantity").ToString()
                    PriceTextBox.Text = dt.Rows(0).Item("price").ToString()
                    e.Handled = True
                Else
                    MessageBox.Show("No, product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Barcode not valid!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub VoidButton_Click(sender As Object, e As EventArgs) Handles VoidButton.Click
        For Each row As DataGridViewRow In _parent.TransactionDataGridView.Rows
            If row.Cells("ID").Value.ToString() = _data.Item("id").ToString() Then
                _parent.TransactionDataGridView.Rows.Remove(row)
                Exit For
            End If
        Next
        _parent.UpdateVisualData()
        Me.Close()
    End Sub
End Class
