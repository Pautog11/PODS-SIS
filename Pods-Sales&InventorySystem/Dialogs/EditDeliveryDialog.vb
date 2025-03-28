Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class EditDeliveryDialog
    Private ReadOnly _parent As DeliveryCartDialog = Nothing
    Private ReadOnly _data As Dictionary(Of String, String) = Nothing
    Private ReadOnly _data2 As Dictionary(Of String, String) = Nothing
    Dim id As Integer = Nothing
    Dim tite As Integer = Nothing
    Dim num As Integer = 1
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
                Dim pid As String = BaseDelivery.Product_id(_data.Item("name"))
                id = pid
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
                BarcodeTextBox.Enabled = False
                ProductTextBox.ReadOnly = True
            Else

                If _parent.DeliveryDataGridView.Rows.Cast(Of DataGridViewRow)().Any(Function(row) Convert.ToString(row.Cells("target2").Value) = "NEW") Then
                    If _parent.DeliveryDataGridView.Rows.Count > 0 Then
                        num = _parent.DeliveryDataGridView.Rows.Cast(Of DataGridViewRow)() _
                            .Where(Function(row) Convert.ToString(row.Cells("target2").Value) <> "OLD") _
                            .Max(Function(row) Convert.ToInt32(row.Cells("target").Value)) + 1
                    Else
                        num = 1
                    End If
                End If

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


            For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                If CInt(item.Cells("target").Value) = id Then
                    If item.Cells("price").Value.ToString() <> Decimal.Parse(SellingTextBox.Text).ToString("F2") OrElse item.Cells("cost_price").Value.ToString() <> Decimal.Parse(CostTextBox.Text).ToString("F2") Then
                        If UpdateDeliveryButton.Text = "Update" Then
                            If item.Cells("price").Value.ToString() <> Decimal.Parse(SellingTextBox.Text).ToString("F2") OrElse item.Cells("cost_price").Value.ToString() <> Decimal.Parse(CostTextBox.Text).ToString("F2") Then
                                MessageBox.Show("You cannot set a different price for the same product!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            Else
                                Exit For
                            End If
                        Else
                            MessageBox.Show("You cannot set a different price for the same product!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End If
                End If
            Next


            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim is_existing As Boolean = False
                Dim exd As Date = DateTimePicker.Value.Date

                For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows

                    If item.Cells("id").Value.ToString() = _data.Item("id") Then
                        item.Cells("price").Value = Decimal.Parse(SellingTextBox.Text).ToString("F2")
                        item.Cells("cost_price").Value = Decimal.Parse(CostTextBox.Text).ToString("F2")
                        item.Cells("quantity").Value = CInt(QuantityTextBox.Text)
                        item.Cells("total").Value = Decimal.Parse(Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)).ToString("F2")
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
            Dim controls As Object() = {
                ProductTextBox, SellingTextBox, CostTextBox, QuantityTextBox, BatchTextBox
            }
            Dim types As DataInput() = {
                DataInput.STRING_NAME, DataInput.STRING_DECIMAL, DataInput.STRING_DECIMAL, DataInput.STRING_INTEGER, DataInput.STRING_STRING
            }

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
                End If
            Next

            Dim is_existing As Boolean = False
            Dim exd As Date = DateTimePicker.Value.Date

            If Val(CostTextBox.Text) >= Val(SellingTextBox.Text) Then
                MessageBox.Show("The price cannot be less than or equal to the cost price.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                If CInt(item.Cells("target").Value) = id Then
                    If item.Cells("price").Value.ToString() <> Decimal.Parse(SellingTextBox.Text).ToString("F2") OrElse item.Cells("cost_price").Value.ToString() <> Decimal.Parse(CostTextBox.Text).ToString("F2") Then
                        MessageBox.Show("You cannot set a different price for the same product!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If
            Next

            For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                If DateTimePicker.Enabled = False Then
                    If item.Cells("product").Value = ProductTextBox.Text Then
                        MessageBox.Show("This product is already exist!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If

                If item.Cells("product").Value.ToString() = ProductTextBox.Text AndAlso item.Cells("expiry_date").Value = exd.ToString("yyyy-MM-dd") AndAlso item.Cells("batch_number").Value = BatchTextBox.Text Then
                    MessageBox.Show("This product is already exist!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    is_existing = True
                    Exit Sub
                End If
            Next

            If Not is_existing Then
                _parent.DeliveryDataGridView.Rows.Add({If(String.IsNullOrEmpty(id), 0, id),
                                                      If(String.IsNullOrEmpty(ProductTextBox.Text), 0, ProductTextBox.Text),
                                                      If(DateTimePicker.Enabled AndAlso Not String.IsNullOrEmpty(exd.ToString()) AndAlso exd.ToString() <> "", exd.ToString("yyyy-MM-dd"), ""),
                                                      If(DateTimePicker.Enabled AndAlso Not String.IsNullOrEmpty(BatchTextBox.Text) AndAlso exd.ToString() <> "", BatchTextBox.Text, ""),
                                                      If(String.IsNullOrEmpty(Decimal.Parse(SellingTextBox.Text).ToString("F2")), 0, Decimal.Parse(SellingTextBox.Text).ToString("F2")),
                                                      If(String.IsNullOrEmpty(Decimal.Parse(CostTextBox.Text).ToString("F2")), 0, Decimal.Parse(CostTextBox.Text).ToString("F2")),
                                                      If(String.IsNullOrEmpty(QuantityTextBox.Text), 0, QuantityTextBox.Text),
                                                      CDec(CostTextBox.Text) * CDec(QuantityTextBox.Text),
                                                      num,
                                                      "NEW"
                                                      })

                num += 1
                _parent.UpdateVisualData()
                Me.Close()
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
                        ProductTextBox.ReadOnly = True
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
