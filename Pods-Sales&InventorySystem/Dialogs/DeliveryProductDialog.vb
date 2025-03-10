﻿Imports System.Windows.Forms

Public Class DeliveryProductDialog
    Private ReadOnly _tableAdapter As New podsTableAdapters.viewtblcategoriesTableAdapter
    Private ReadOnly _dataTable As New pods.viewtblcategoriesDataTable
    Private ReadOnly _parent As DeliveryCartDialog = Nothing
    Private ReadOnly _data As Dictionary(Of String, String) = Nothing
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
                AddDeliveryButton.Text = "Update"
                BarcodeTextBox.Enabled = False

                'MsgBox(_data.Item("target"))

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
            If BaseProduct.CheckProductname(ProductTextBox.Text) = 0 Then
                MessageBox.Show("No product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

                Dim sellingprice As Decimal
                Dim costprice As Decimal
                If Decimal.TryParse(SellingTextBox.Text, sellingprice) AndAlso Decimal.TryParse(CostTextBox.Text, costprice) Then

                End If

                For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                    If CInt(item.Cells("id").Value) = id Then
                        If item.Cells("price").Value.ToString() <> sellingprice.ToString("F2") OrElse item.Cells("cost_price").Value.ToString() <> costprice.ToString("F2") Then
                            MessageBox.Show("You cannot set a different price for the same product!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End If

                    If item.Cells("product").Value.ToString() = ProductTextBox.Text AndAlso item.Cells("expiry_date").Value = exd.ToString("yyyy-MM-dd") AndAlso item.Cells("batch_number").Value = BatchTextBox.Text Then
                        If DateTimePicker.Enabled = True Then
                            item.Cells("expiry_date").Value = exd.ToString("yyyy-MM-dd")
                            item.Cells("batch_number").Value = BatchTextBox.Text
                        Else
                            item.Cells("batch_number").Value = ""
                            item.Cells("expiry_date").Value = ""
                        End If

                        Dim a As Integer = CInt(QuantityTextBox.Text) + item.Cells("quantity").Value
                        item.Cells("quantity").Value = a

                        item.Cells("total").Value = Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)



                        AddHandler AddDeliveryButton.Click, AddressOf VoidButton_Click
                        '_parent.DeliveryDataGridView.Rows.Remove(item = _data.Item("target").ToString())


                        'Dim targetValue As String = _data.Item("target").ToString()

                        'If item.Cells("target").Value.ToString() = targetValue Then

                        '    _parent.DeliveryDataGridView.Rows.Remove(item)
                        '    'Exit For

                        'End If


                        is_existing = True
                        Exit For
                    End If
                Next

                If Not is_existing Then
                    _parent.DeliveryDataGridView.Rows.Add({If(String.IsNullOrEmpty(id), 0, id),
                                                          If(String.IsNullOrEmpty(ProductTextBox.Text), 0, ProductTextBox.Text),
                                                          If(DateTimePicker.Enabled AndAlso Not String.IsNullOrEmpty(exd.ToString()) AndAlso exd.ToString() <> "", exd.ToString("yyyy-MM-dd"), ""),
                                                          If(DateTimePicker.Enabled AndAlso Not String.IsNullOrEmpty(BatchTextBox.Text) AndAlso exd.ToString() <> "", BatchTextBox.Text, ""),
                                                          If(String.IsNullOrEmpty(sellingprice.ToString("F2")), 0, sellingprice.ToString("F2")),
                                                          If(String.IsNullOrEmpty(costprice.ToString("F2")), 0, costprice.ToString("F2")),
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
        'Dim event fuck As EventHandler
        'Dim isHandlerAdded As Boolean = False
        'If Not isHandlerAdded = True Then
        '    AddHandler AddDeliveryButton.Click, AddressOf VoidButton_Click
        '    isHandlerAdded = True ' Set flag to true so handler is not added again
        'End If
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

    Private Sub VoidButton_Click(sender As Object, e As EventArgs) Handles VoidButton.Click
        'Try
        '    For Each row As DataGridViewRow In _parent.DeliveryDataGridView.Rows
        '        If row.Cells("target").Value.ToString() = _data.Item("target").ToString() Then
        '            _parent.DeliveryDataGridView.Rows.Remove(row)
        '            Exit For
        '        End If
        '    Next
        '    _parent.UpdateVisualData()
        '    Me.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        MsgBox("dd")
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
End Class