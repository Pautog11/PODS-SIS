Imports System.Windows.Forms

Public Class DeliveryProductDialog
    Private ReadOnly _tableAdapter As New podsTableAdapters.viewtblcategoriesTableAdapter
    Private ReadOnly _dataTable As New pods.viewtblcategoriesDataTable
    Private ReadOnly _parent As DeliveryCartDialog = Nothing
    Private ReadOnly _data As Dictionary(Of String, String) = Nothing
    Dim id As Integer = Nothing
    Dim tite As Integer = Nothing

    Public Sub New(Optional parent As DeliveryCartDialog = Nothing,
                   Optional data As Dictionary(Of String, String) = Nothing)
        InitializeComponent()
        _parent = parent
        _data = data
    End Sub

    Private Sub DeliveryProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'DateTimePicker.Enabled = False
            If _data IsNot Nothing Then
                id = _data.Item("id")
                ProductTextBox.Text = _data.Item("name")
                SellingTextBox.Text = _data.Item("selling_price")
                CostTextBox.Text = _data.Item("cost_price")
                BatchTextBox.Text = _data.Item("batch_number")
                AddDeliveryButton.Text = "Update"
                BarcodeTextBox.Enabled = False
                If _data.Item("date") <> "" Then
                    DateTimePicker.Value = _data.Item("date")
                Else
                    DateTimePicker.Enabled = False
                End If
            Else
                VoidButton.Visible = False
            End If
            DateTimePicker.MinDate = DateTime.Today.AddMonths(6)
            'SkuComboBox1.Enabled = False
            'ProductTextBox.Enabled = False
            'CostTextBox.Enabled = False
            'txtPrays.Enabled = False

            'ProductTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            'ProductTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
            'PopulateAutoCompleteList()
            'ProductTextBox.AutoCompleteCustomSource = autocompleteList

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
            Dim controls As Object() = {
                ProductTextBox, SellingTextBox, CostTextBox, QuantityTextBox, BatchTextBox
            }
            Dim types As DataInput() = {
                 DataInput.STRING_STRING, DataInput.STRING_DECIMAL, DataInput.STRING_DECIMAL, DataInput.STRING_INTEGER, DataInput.STRING_INTEGER
            }
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
                Else
                    Throw New Exception
                End If
            Next
            If Not (BaseDelivery.Pricing(result(1)(1), id) = 0) Then
                MessageBox.Show("Lugi ka angkol", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If Val(CostTextBox.Text) >= Val(SellingTextBox.Text) Then
                MessageBox.Show("It should not be less than the cost price.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim is_existing As Boolean = False
                Dim exd As Date = DateTimePicker.Value.Date

                For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                    If item.Cells("product").Value.ToString() = ProductTextBox.Text AndAlso item.Cells("expiry_date").Value = exd.ToString("yyyy-MM-dd") AndAlso item.Cells("batch_number").Value = BatchTextBox.Text Then
                        If DateTimePicker.Enabled = True Then
                            item.Cells("expiry_date").Value = exd.ToString("yyyy-MM-dd")
                        Else
                            item.Cells("expiry_date").Value = ""
                        End If
                        'item.Cells("price").Value = SellingTextBox.Text
                        'item.Cells("cost_price").Value = CostTextBox.Text
                        item.Cells("batch_number").Value = BatchTextBox.Text
                        item.Cells("quantity").Value = CInt(QuantityTextBox.Text)
                        item.Cells("total").Value = Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)
                        is_existing = True
                        Exit For
                    End If
                Next

                If Not is_existing Then
                    _parent.DeliveryDataGridView.Rows.Add({If(String.IsNullOrEmpty(id), 0, id),
                                                          If(String.IsNullOrEmpty(ProductTextBox.Text), 0, ProductTextBox.Text),
                                                          If(DateTimePicker.Enabled AndAlso Not String.IsNullOrEmpty(exd.ToString()) AndAlso exd.ToString() <> "", exd.ToString("yyyy-MM-dd"), ""),
                                                          If(String.IsNullOrEmpty(BatchTextBox.Text), "", BatchTextBox.Text),
                                                          If(String.IsNullOrEmpty(SellingTextBox.Text), 0, SellingTextBox.Text),
                                                          If(String.IsNullOrEmpty(CostTextBox.Text), 0, CostTextBox.Text),
                                                          If(String.IsNullOrEmpty(QuantityTextBox.Text), 0, QuantityTextBox.Text),
                                                          CDec(CostTextBox.Text) * CDec(QuantityTextBox.Text)
                                                          })
                End If


                For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                    If Not item.IsNewRow Then
                        If CInt(item.Cells("id").Value) = id Then
                            item.Cells("price").Value = SellingTextBox.Text
                            item.Cells("cost_price").Value = CostTextBox.Text
                        End If
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

    'Private Sub CategoryComboBox_DropDownClosed(sender As Object, e As EventArgs)
    '    If CategoryComboBox.SelectedIndex >= 0 Then
    '        Dim dt As DataTable = BaseSubCategory.FetchSubCategory(CategoryComboBox.SelectedItem("ID"))
    '        SubcategoryComboBox.DataSource = dt.DefaultView
    '        SubcategoryComboBox.DisplayMember = "subcategory"
    '        SubcategoryComboBox.ValueMember = "id"
    '    End If
    '    SubcategoryComboBox.Enabled = True
    '    Clear()
    'End Sub
    'Private Sub SubcategoryComboBox_DropDownClosed(sender As Object, e As EventArgs)
    '    If SubcategoryComboBox.SelectedIndex >= 0 Then
    '        Dim dt As DataTable = BaseProduct.FetchProductBySubcategory(SubcategoryComboBox.SelectedItem("ID"))
    '        ProductComboBox.DataSource = dt.DefaultView
    '        ProductComboBox.DisplayMember = "product_name"
    '        ProductComboBox.ValueMember = "id"
    '    End If
    '    Clear()
    '    ProductComboBox.Enabled = True
    'End Sub

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
            txite()
            'tite = BaseDelivery.EnableExp(id)
            'If tite = 1 Then
            '    DateTimePicker.Enabled = True
            'Else
            '    DateTimePicker.Enabled = False
            'End If
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub ChangeButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        If ProductTextBox.Text = "" Then
    '            MessageBox.Show("No, product selected!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        ElseIf ProductTextBox.Text IsNot Nothing Then
    '            Dim potangina As New Dictionary(Of String, String) From {
    '                {"id", id},
    '                {"price", If(String.IsNullOrEmpty(SellingTextBox.Text), 0, SellingTextBox.Text)},
    '                {"cost", If(String.IsNullOrEmpty(CostTextBox.Text), 0, CostTextBox.Text)}
    '            }
    '            Dim dialog As New PricingDialog(data:=potangina, parent:=Me)
    '            dialog.ShowDialog()
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub VoidButton_Click(sender As Object, e As EventArgs) Handles VoidButton.Click
        Try
            For Each row As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                If row.Cells("ID").Value.ToString() = _data.Item("id").ToString() Then
                    _parent.DeliveryDataGridView.Rows.Remove(row)
                    Exit For
                End If
            Next
            _parent.UpdateVisualData()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Clear()
        ProductTextBox.Text = ""
        BarcodeTextBox.Text = ""
        CostTextBox.Text = ""
        SellingTextBox.Text = ""
        QuantityTextBox.Text = ""
    End Sub
    Public Sub txite()
        tite = BaseDelivery.EnableExp(id)
        If tite = 1 Then
            DateTimePicker.Enabled = True
        Else
            DateTimePicker.Enabled = False
        End If
    End Sub
    Private Sub ProductTextBox_TextChanged(sender As Object, e As KeyEventArgs) Handles ProductTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                'MsgBox(ProductTextBox.Text)
                Dim dt As DataTable = BaseDelivery.NameFetching(ProductTextBox.Text)
                If BarcodeTextBox.Text.Length <= 13 AndAlso dt.Rows.Count > 0 Then
                    id = If(String.IsNullOrEmpty(dt.Rows(0).Item("id").ToString()), 0, dt.Rows(0).Item("id").ToString())
                    ProductTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("product_name").ToString()), 0, dt.Rows(0).Item("product_name"))
                    SellingTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("price").ToString()), 0, dt.Rows(0).Item("price").ToString())
                    CostTextBox.Text = If(String.IsNullOrEmpty(dt.Rows(0).Item("cost_price").ToString()), 0, dt.Rows(0).Item("cost_price").ToString())
                    ' e.Handled = True
                Else
                    MessageBox.Show("No product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Clear()
                End If
            End If
            txite()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class