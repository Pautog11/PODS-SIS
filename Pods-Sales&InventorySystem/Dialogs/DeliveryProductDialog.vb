Imports System.Windows.Forms

Public Class DeliveryProductDialog
    Private ReadOnly _tableAdapter As New podsTableAdapters.viewtblcategoriesTableAdapter
    Private ReadOnly _dataTable As New pods.viewtblcategoriesDataTable
    Private ReadOnly _parent As DeliveryCartDialog = Nothing
    Private ReadOnly _data As Dictionary(Of String, String) = Nothing
    Dim dt As DataTable = Nothing
    Dim id As Integer = Nothing
    Dim tite As Integer = Nothing
    Dim num As Integer = 1

    Public Sub New(Optional parent As DeliveryCartDialog = Nothing,
                   Optional data As Dictionary(Of String, String) = Nothing)
        InitializeComponent()
        _parent = parent
        _data = data
    End Sub

    Private Sub DeliveryProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                id = _data.Item("id")
                ProductTextBox.Text = _data.Item("name")
                SellingTextBox.Text = _data.Item("selling_price")
                CostTextBox.Text = _data.Item("cost_price")
                BatchTextBox.Text = _data.Item("batch_number")
                QuantityTextBox.Text = _data.Item("quantity")
                AddDeliveryButton.Text = "Update"
                BarcodeTextBox.Enabled = False

                If _data.Item("date") <> "" Then
                    DateTimePicker.Value = _data.Item("date")
                Else
                    DateTimePicker.Enabled = False
                    BatchTextBox.Enabled = False
                End If
            Else
                VoidButton.Visible = False

                If _parent.DeliveryDataGridView.Rows.Count > 0 Then
                    num = _parent.DeliveryDataGridView.Rows.Cast(Of DataGridViewRow)().Max(Function(row) Convert.ToInt32(row.Cells("target").Value)) + 1
                Else
                    num = 1
                End If
            End If
            DateTimePicker.MinDate = DateTime.Today.AddMonths(6)

            ProductTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ProductTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
            ProductTextBox.AutoCompleteCustomSource = BaseProduct.PopulateAutoCompleteList()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddDeliveryButton_Click(sender As Object, e As EventArgs) Handles AddDeliveryButton.Click
        Try
            If _data Is Nothing Then
                If dt Is Nothing OrElse dt.Rows.Count < 1 Then
                    MessageBox.Show("No product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Clear()
                    Exit Sub
                End If
            End If

            If BaseProduct.CheckProductname(ProductTextBox.Text) = 0 Then
                MessageBox.Show("Invalid product name!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Clear()
                Exit Sub
            End If

            Dim controls As Object() = {ProductTextBox, SellingTextBox, CostTextBox, QuantityTextBox, BatchTextBox}
            Dim types As DataInput() = {DataInput.STRING_STRING, DataInput.STRING_DECIMAL, DataInput.STRING_DECIMAL, DataInput.STRING_INTEGER, DataInput.STRING_STRING}
            Dim result As New List(Of Object())

            For i = 0 To controls.Count - 1
                If controls(i) Is BatchTextBox AndAlso tite = 0 Then
                    Continue For
                End If
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                Dim validationResult = TryCast(result(i), Object())
                If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                    If Not validationResult(0) = True Then
                        Exit Sub
                    End If
                End If
            Next

            If Not (BaseDelivery.Pricing(result(1)(1), id) = 0) Then
                MessageBox.Show("You cannot set a price lower than the price in your previous inventory.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If Val(CostTextBox.Text) >= Val(SellingTextBox.Text) Then
                MessageBox.Show("The price cannot be less than or equal to the cost price.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim is_existing As Boolean = False
                Dim exd As Date = DateTimePicker.Value.Date
                Dim swicth As Integer = 0
                'Dim sellingprice As Decimal
                'Dim costprice As Decimal

                'If Decimal.TryParse(SellingTextBox.Text, sellingprice) AndAlso Decimal.TryParse(CostTextBox.Text, costprice) Then
                'End If

                For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                    If CInt(item.Cells("id").Value) = id Then
                        If item.Cells("price").Value.ToString() <> Decimal.Parse(SellingTextBox.Text).ToString("F2") OrElse item.Cells("cost_price").Value.ToString() <> Decimal.Parse(CostTextBox.Text).ToString("F2") Then
                            If AddDeliveryButton.Text = "Update" Then
                                'MsgBox("update")
                                Exit For
                            Else
                                MessageBox.Show("You cannot set a different price for the same product!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                        End If
                    End If
                Next

                For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                    If DateTimePicker.Enabled = True Then
                        If item.Cells("product").Value.ToString() = ProductTextBox.Text AndAlso item.Cells("expiry_date").Value = exd.ToString("yyyy-MM-dd") AndAlso item.Cells("batch_number").Value = BatchTextBox.Text Then
                            If DateTimePicker.Enabled = True Then
                                item.Cells("expiry_date").Value = exd.ToString("yyyy-MM-dd")
                                item.Cells("batch_number").Value = BatchTextBox.Text
                            End If

                            If _data IsNot Nothing Then
                                'update
                                If item.Cells("target").Value = _data.Item("target") Then
                                    'update selected row, no adding quantity
                                    item.Cells("price").Value = Decimal.Parse(SellingTextBox.Text).ToString("F2")
                                    item.Cells("cost_price").Value = Decimal.Parse(CostTextBox.Text).ToString("F2")
                                    item.Cells("quantity").Value = CInt(QuantityTextBox.Text)
                                    item.Cells("total").Value = Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)
                                Else
                                    'When changes occur, it will check first if there is the same item in the delivery cart, and if it is true, it will add the quantity.
                                    Dim quantity As Integer = CInt(QuantityTextBox.Text) + item.Cells("quantity").Value
                                    item.Cells("price").Value = Decimal.Parse(SellingTextBox.Text).ToString("F2")
                                    item.Cells("cost_price").Value = Decimal.Parse(CostTextBox.Text).ToString("F2")
                                    item.Cells("quantity").Value = quantity
                                    item.Cells("total").Value = Decimal.Parse(CostTextBox.Text) * CInt(quantity)

                                    swicth = 1
                                End If
                            Else
                                'if exist
                                Dim quantity As Integer = CInt(QuantityTextBox.Text) + item.Cells("quantity").Value
                                item.Cells("price").Value = Decimal.Parse(SellingTextBox.Text).ToString("F2") 'sellingprice.ToString("F2")
                                item.Cells("cost_price").Value = Decimal.Parse(CostTextBox.Text).ToString("F2") 'costprice.ToString("F2")
                                item.Cells("quantity").Value = quantity
                                item.Cells("total").Value = Decimal.Parse(CostTextBox.Text) * CInt(quantity)
                            End If
                            is_existing = True
                            Exit For
                        End If
                    Else
                        If item.Cells("product").Value.ToString() = ProductTextBox.Text Then
                            item.Cells("batch_number").Value = ""
                            item.Cells("expiry_date").Value = ""

                            If _data Is Nothing Then
                                Dim quantity As Integer = CInt(QuantityTextBox.Text) + item.Cells("quantity").Value
                                item.Cells("price").Value = Decimal.Parse(SellingTextBox.Text).ToString("F2")
                                item.Cells("cost_price").Value = Decimal.Parse(CostTextBox.Text).ToString("F2")
                                item.Cells("quantity").Value = quantity
                                item.Cells("total").Value = Decimal.Parse(CostTextBox.Text) * CInt(quantity)
                            Else
                                item.Cells("price").Value = Decimal.Parse(SellingTextBox.Text).ToString("F2")
                                item.Cells("cost_price").Value = Decimal.Parse(CostTextBox.Text).ToString("F2")
                                item.Cells("quantity").Value = CInt(QuantityTextBox.Text)
                                item.Cells("total").Value = Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)
                            End If
                            is_existing = True
                            Exit For
                        End If
                    End If
                Next

                If is_existing = True Then
                    If _data IsNot Nothing Then
                        If swicth = 1 Then
                            For Each row As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                                If row.Cells("target").Value = _data.Item("target") Then
                                    _parent.DeliveryDataGridView.Rows.Remove(row)
                                    Exit For
                                End If
                            Next
                        End If
                    End If
                End If

                If Not is_existing Then
                    _parent.DeliveryDataGridView.Rows.Add({If(String.IsNullOrEmpty(id), 0, id),
                                                          If(String.IsNullOrEmpty(ProductTextBox.Text), 0, ProductTextBox.Text),
                                                          If(DateTimePicker.Enabled AndAlso Not String.IsNullOrEmpty(exd.ToString()) AndAlso exd.ToString() <> "", exd.ToString("yyyy-MM-dd"), ""),
                                                          If(DateTimePicker.Enabled AndAlso Not String.IsNullOrEmpty(BatchTextBox.Text) AndAlso exd.ToString() <> "", BatchTextBox.Text, ""),
                                                          If(String.IsNullOrEmpty(Decimal.Parse(SellingTextBox.Text).ToString("F2")), 0, Decimal.Parse(SellingTextBox.Text).ToString("F2")),
                                                          If(String.IsNullOrEmpty(Decimal.Parse(CostTextBox.Text).ToString("F2")), 0, Decimal.Parse(CostTextBox.Text).ToString("F2")),
                                                          If(String.IsNullOrEmpty(QuantityTextBox.Text), 0, QuantityTextBox.Text),
                                                          CDec(CostTextBox.Text) * CDec(QuantityTextBox.Text),
                                                          num
                                                          })
                    num += 1
                End If

                _parent.UpdateVisualData()
                Me.Close()
            Else
                MessageBox.Show("Invalid quantity!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                QuantityTextBox.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarcodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BarcodeTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim res As New List(Of Object()) From {InputValidation.ValidateInputString(BarcodeTextBox, DataInput.STRING_INTEGER)}
                If Not res.Any(Function(item As Object()) Not item(0)) Then
                    dt = BaseDelivery.BarcodeFetching(BarcodeTextBox.Text)
                    If BarcodeTextBox.Text.Length <= 13 AndAlso dt.Rows.Count > 0 Then
                        id = If(String.IsNullOrEmpty(dt.Rows(0).Item("id").ToString()), 0, dt.Rows(0).Item("id").ToString())
                        ProductTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("product_name").ToString()), 0, dt.Rows(0).Item("product_name"))
                        SellingTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("price").ToString()), 0, dt.Rows(0).Item("price").ToString())
                        CostTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("cost_price").ToString()), 0, dt.Rows(0).Item("cost_price").ToString())
                        ProductTextBox.ReadOnly = True
                        e.Handled = True
                    Else
                        MessageBox.Show("No product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ProductTextBox.ReadOnly = False
                        Clear()
                    End If
                Else
                    Clear()
                End If
                Txite()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VoidButton_Click(sender As Object, e As EventArgs) Handles VoidButton.Click
        Try
            For Each row As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                If row.Cells("target").Value.ToString() = _data.Item("target").ToString() Then
                    _parent.DeliveryDataGridView.Rows.Remove(row)
                    Exit For
                End If
            Next
            _parent.UpdateVisualData()
            Me.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Clear()
        ProductTextBox.Text = ""
        BarcodeTextBox.Text = ""
        CostTextBox.Text = ""
        SellingTextBox.Text = ""
        QuantityTextBox.Text = ""
    End Sub

    Public Sub Txite()
        tite = BaseDelivery.EnableExp(id)
        If tite = 1 Then
            DateTimePicker.Enabled = True
            BatchTextBox.Enabled = True
        Else
            BatchTextBox.Enabled = False
            DateTimePicker.Enabled = False
        End If
    End Sub

    Private Sub ProductTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ProductTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                dt = BaseDelivery.NameFetching(ProductTextBox.Text)
                If BarcodeTextBox.Text.Length <= 13 AndAlso dt.Rows.Count > 0 Then
                    id = If(String.IsNullOrEmpty(dt.Rows(0).Item("id").ToString()), 0, dt.Rows(0).Item("id").ToString())
                    ProductTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("product_name").ToString()), 0, dt.Rows(0).Item("product_name"))
                    SellingTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("price").ToString()), 0, dt.Rows(0).Item("price").ToString())
                    CostTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("cost_price").ToString()), 0, dt.Rows(0).Item("cost_price").ToString())
                    BarcodeTextBox.Text = ""
                    e.Handled = True
                Else
                    MessageBox.Show("No product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Clear()
                End If
                Txite()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class