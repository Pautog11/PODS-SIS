Imports System.Windows.Forms

Public Class TransactionProductDailog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _dat2 As Dictionary(Of String, String)
    Private ReadOnly _tableAdapter As New podsTableAdapters.viewtblcategoriesTableAdapter
    Private ReadOnly _dataTable As New pods.viewtblcategoriesDataTable
    Private ReadOnly _subject As IObservablePanel
    Private ReadOnly _parent As PosPanel = Nothing
    Dim id As Integer = Nothing
    Dim cost As Decimal = Nothing
    Public Sub New(Optional subject As IObservablePanel = Nothing,
                   Optional parent As PosPanel = Nothing,
                   Optional data As Dictionary(Of String, String) = Nothing,',
                   Optional dat2 As Dictionary(Of String, String) = Nothing) ',
        'Optional dat2 As Dictionary(Of String, String) = Nothing)
        InitializeComponent()
        _parent = parent
        _subject = subject
        _data = data
        _dat2 = dat2
    End Sub
    Private Sub TransactionCartDailog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                id = _data.Item("id")
                ProductNameTextBox.Text = _data.Item("product_name")
                PriceTextBox.Text = _data.Item("price")
                StocksTextBox.Text = _data.Item("stocks")
                'Else
                '    VoidButton.Visible = False
                AddTransactionButton.Text = "Update"
                Exit Sub
            End If

            If _dat2 IsNot Nothing Then
                id = _dat2.Item("id")
                ProductNameTextBox.Text = _dat2.Item("product_name")
                PriceTextBox.Text = _dat2.Item("price")
                StocksTextBox.Text = _dat2.Item("stocks")
                cost = _dat2.Item("cost")

                VoidButton.Visible = False
                Exit Sub
            End If

            VoidButton.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddTransactionButton_Click(sender As Object, e As EventArgs) Handles AddTransactionButton.Click
        Try
            If ProductNameTextBox.Text = "" AndAlso StocksTextBox.Text = "" Then
                MessageBox.Show("No product selected!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim result As New List(Of Object()) From {InputValidation.ValidateInputString(QuantityTextBox, DataInput.STRING_INTEGER)}
            Dim validationResult = TryCast(result(0), Object())
            If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                If Not validationResult(0) = True Then
                    Exit Sub
                End If
            Else
                Throw New Exception
            End If

            Dim is_existing As Boolean = False

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                For Each item As DataGridViewRow In _parent.TransactionDataGridView.Rows
                    If CInt(StocksTextBox.Text) >= QuantityTextBox.Text Then
                        'If _data IsNot Nothing Then
                        If item.Cells("ID").Value.ToString() = id Then
                                item.Cells("PRODUCT").Value = ProductNameTextBox.Text
                                item.Cells("PRICE").Value = Decimal.Parse(PriceTextBox.Text)
                                item.Cells("QUANTITY").Value = CInt(QuantityTextBox.Text)
                                item.Cells("TOTAL").Value = Decimal.Parse(PriceTextBox.Text) * CInt(QuantityTextBox.Text)
                                is_existing = True
                            Exit For
                        End If
                        'End If
                    End If
                Next

                If Not is_existing Then
                    If CInt(If(String.IsNullOrEmpty(StocksTextBox.Text), 0, StocksTextBox.Text)) >= QuantityTextBox.Text Then
                        _parent.TransactionDataGridView.Rows.Add({If(IsDBNull(id), 0, id),
                                                        If(String.IsNullOrEmpty(ProductNameTextBox.Text), 0, ProductNameTextBox.Text),
                                                        If(String.IsNullOrEmpty(PriceTextBox.Text), 0, PriceTextBox.Text),
                                                        If(String.IsNullOrEmpty(QuantityTextBox.Text), 0, QuantityTextBox.Text),
                                                        CDec(PriceTextBox.Text) * CDec(QuantityTextBox.Text),
                                                        If(String.IsNullOrEmpty(CDec(QuantityTextBox.Text) * CDec(cost)), 0, CDec(QuantityTextBox.Text) * CDec(cost))
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
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BarcodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BarcodeTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim res As New List(Of Object()) From {InputValidation.ValidateInputString(BarcodeTextBox, DataInput.STRING_INTEGER)}
                If Not res.Any(Function(item As Object()) Not item(0)) Then
                    Dim dt As DataTable = BaseTransaction.FetchByBarcode(BarcodeTextBox.Text)
                    If BarcodeTextBox.Text.Length <= 13 AndAlso dt.Rows.Count > 0 Then
                        id = If(String.IsNullOrEmpty(dt.Rows(0).Item("idngprod").ToString()), 0, dt.Rows(0).Item("idngprod").ToString())
                        ProductNameTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("product_name").ToString()), 0, dt.Rows(0).Item("product_name").ToString())
                        StocksTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("quantity").ToString()), 0, dt.Rows(0).Item("quantity").ToString())
                        PriceTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("price").ToString()), 0, dt.Rows(0).Item("price").ToString())
                        cost = If(String.IsNullOrEmpty(dt.Rows(0).Item("cost").ToString()), 0, dt.Rows(0).Item("cost").ToString())
                        e.Handled = True
                    Else
                        Clear()
                        MessageBox.Show("No, product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    Clear()
                    MessageBox.Show("Barcode not valid!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VoidButton_Click(sender As Object, e As EventArgs) Handles VoidButton.Click
        Try
            For Each row As DataGridViewRow In _parent.TransactionDataGridView.Rows
                If row.Cells("ID").Value.ToString() = _data.Item("id").ToString() Then
                    _parent.TransactionDataGridView.Rows.Remove(row)
                    Exit For
                End If
            Next
            _parent.UpdateVisualData()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Clear()
        BarcodeTextBox.Text = ""
        ProductNameTextBox.Text = ""
        PriceTextBox.Text = ""
        QuantityTextBox.Text = ""
        StocksTextBox.Text = ""
    End Sub
End Class
