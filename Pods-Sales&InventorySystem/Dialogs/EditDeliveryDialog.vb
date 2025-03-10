Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class EditDeliveryDialog
    Private ReadOnly _parent As DeliveryCartDialog = Nothing
    Private ReadOnly _data As Dictionary(Of String, String) = Nothing
    Private ReadOnly _data2 As Dictionary(Of String, String) = Nothing
    Dim id As Integer = Nothing
    Dim tite As Integer = Nothing
    'Dim enable_exp As Integer = Nothing
    Public Sub New(Optional parent As DeliveryCartDialog = Nothing,
                   Optional data As Dictionary(Of String, String) = Nothing,
                   Optional data2 As Dictionary(Of String, String) = Nothing)
        InitializeComponent()
        _parent = parent
        _data = data
        _data2 = data2
    End Sub
    Private Sub EditDeliveryDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                Dim pid As String = BaseDelivery.Product_id(_data.Item("id"))
                id = pid
                'enable_exp = BaseDelivery.EnableExp(pid)
                ProductTextBox.Text = BaseProduct.Getname(pid)
                SellingTextBox.Text = _data.Item("selling_price")
                CostTextBox.Text = _data.Item("cost_price")
                BatchTextBox.Text = _data.Item("batch_number")
                QuantityTextBox.Text = _data.Item("quantity")
                If _data.Item("date") <> "" Then
                    DateTimePicker.Value = _data.Item("date")
                Else
                    DateTimePicker.Enabled = False
                    BatchTextBox.Enabled = False
                End If
                AddProductButton.Visible = False
            Else
                UpdateDeliveryButton.Visible = False
            End If

            ProductTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            ProductTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
            ProductTextBox.AutoCompleteCustomSource = BaseProduct.PopulateAutoCompleteList()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UpdateDeliveryButton_Click(sender As Object, e As EventArgs) Handles UpdateDeliveryButton.Click
        Try
            If BaseProduct.CheckProductname(ProductTextBox.Text) = 0 Then
                MessageBox.Show("No product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim controls As Object() = {ProductTextBox, SellingTextBox, CostTextBox, QuantityTextBox, BatchTextBox}
            Dim types As DataInput() = {DataInput.STRING_STRING, DataInput.STRING_DECIMAL, DataInput.STRING_DECIMAL, DataInput.STRING_INTEGER, DataInput.STRING_STRING}
            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                If controls(i) Is BatchTextBox AndAlso DateTimePicker.Enabled = False Then
                    Continue For
                End If
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                Dim validationResult = TryCast(result(i), Object())
                If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                    If Not validationResult(0) = True Then
                        Exit Sub
                    End If
                Else
                    Throw New Exception
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

            If QuantityTextBox.Text < BaseDelivery.Count_bought_quantity(_data.Item("transaction_id"), id) Then
                MessageBox.Show("You cannot set a quantity lower than the purchased amount!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                QuantityTextBox.Text = ""
                Exit Sub
            End If

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim is_existing As Boolean = False
                Dim exd As Date = DateTimePicker.Value.Date

                Dim sellingprice As Decimal
                Dim costprice As Decimal

                If Decimal.TryParse(SellingTextBox.Text, sellingprice) AndAlso Decimal.TryParse(CostTextBox.Text, costprice) Then
                End If

                For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows

                    If item.Cells("id").Value.ToString() = _data.Item("id") Then
                        item.Cells("price").Value = SellingTextBox.Text
                        item.Cells("cost_price").Value = CostTextBox.Text
                        item.Cells("quantity").Value = CInt(QuantityTextBox.Text)
                        item.Cells("total").Value = Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)
                        item.Cells("target").Value = id
                        is_existing = True
                        Exit For
                    End If
                Next
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

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Try
            Dim check As Integer = 0
            If id = 0 Then
                MessageBox.Show("No product selected!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            For Each row As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                If row.Cells("target").Value.ToString() = id Then
                    check = 1
                    Exit For
                Else
                    Continue For
                End If
            Next

            If check = 1 Then
                MessageBox.Show("This product is already exist!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim controls As Object() = {
                    ProductTextBox, SellingTextBox, CostTextBox, QuantityTextBox, BatchTextBox
                }
                Dim types As DataInput() = {
                    DataInput.STRING_NAME, DataInput.STRING_DECIMAL, DataInput.STRING_DECIMAL, DataInput.STRING_INTEGER, DataInput.STRING_STRING
                }

                Dim result As New List(Of Object())
                For i = 0 To controls.Count - 1
                    If controls(i) Is BatchTextBox AndAlso DateTimePicker.Enabled = False Then
                        'BatchTextBox.Text = ""
                        Continue For
                    End If
                    result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                    Dim validationResult = TryCast(result(i), Object())
                    If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                        If Not validationResult(0) = True Then
                            Exit Sub
                        End If
                    Else
                        Throw New Exception
                    End If
                Next

                Dim datevalue As String = Nothing
                datevalue = DateTimePicker.Value.ToString("yyyy-MM-dd")

                If DateTimePicker.Enabled = False Then
                    datevalue = Nothing
                    BatchTextBox.Text = ""
                End If

                Dim data As New Dictionary(Of String, String) From {
                    {"delivery_id", _data2.Item("id")},
                    {"product_id", id},
                    {"price", result(1)(1)},
                    {"cost_price", result(2)(1)},
                    {"quantity", result(3)(1)},
                    {"batch_number", If(String.IsNullOrEmpty(BatchTextBox.Text), "", BatchTextBox.Text)},
                    {"expiration_date", If(String.IsNullOrEmpty(datevalue), "", datevalue)}
                }
                BaseDelivery.Insert_Items(data)
                MessageBox.Show("Successfully added an item to this delivery!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                _parent.UpdateDataGridview()
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
                    Dim dt As DataTable = BaseDelivery.BarcodeFetching(BarcodeTextBox.Text)
                    If BarcodeTextBox.Text.Length <= 13 AndAlso dt.Rows.Count > 0 Then
                        id = If(String.IsNullOrEmpty(dt.Rows(0).Item("id").ToString()), 0, dt.Rows(0).Item("id").ToString())
                        ProductTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("product_name").ToString()), 0, dt.Rows(0).Item("product_name"))
                        SellingTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("price").ToString()), 0, dt.Rows(0).Item("price").ToString())
                        CostTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("cost_price").ToString()), 0, dt.Rows(0).Item("cost_price").ToString())
                        e.Handled = True
                    Else
                        MessageBox.Show("No product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Clear()
                    End If
                Else
                    Clear()
                End If
            End If
            Txite()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProductTextBox_TextChanged(sender As Object, e As KeyEventArgs) Handles ProductTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim dt As DataTable = BaseDelivery.NameFetching(ProductTextBox.Text)
                If BarcodeTextBox.Text.Length <= 13 AndAlso dt.Rows.Count > 0 Then
                    id = If(String.IsNullOrEmpty(dt.Rows(0).Item("id").ToString()), 0, dt.Rows(0).Item("id").ToString())
                    ProductTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("product_name").ToString()), 0, dt.Rows(0).Item("product_name"))
                    SellingTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("price").ToString()), 0, dt.Rows(0).Item("price").ToString())
                    CostTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("cost_price").ToString()), 0, dt.Rows(0).Item("cost_price").ToString())
                    e.Handled = True
                Else
                    MessageBox.Show("No product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Clear()
                End If
            End If
            Txite()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Public Sub Clear()
        ProductTextBox.Text = ""
        BarcodeTextBox.Text = ""
        CostTextBox.Text = ""
        SellingTextBox.Text = ""
        QuantityTextBox.Text = ""
    End Sub
End Class
