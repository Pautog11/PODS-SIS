Imports System.Windows.Forms

Public Class DeliveryProductDialog
    Private ReadOnly _tableAdapter As New podsTableAdapters.viewtblcategoriesTableAdapter
    Private ReadOnly _dataTable As New pods.viewtblcategoriesDataTable
    Private ReadOnly _parent As DeliveryCartDialog = Nothing
    Private ReadOnly _data As Dictionary(Of String, String) = Nothing
    Dim id As Integer = Nothing
    Public Sub New(Optional parent As DeliveryCartDialog = Nothing,
                   Optional data As Dictionary(Of String, String) = Nothing)
        InitializeComponent()
        _parent = parent
        _data = data
    End Sub

    Private Sub DeliveryProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                ProductTextBox.Text = _data.Item("name")
                txtPrays.Text = _data.Item("sellingprice")
                CostTextBox.Text = _data.Item("costprice")
                'DateTimePicker.Value = _data.Item("date")

                AddDeliveryButton.Text = "Update"
                ChangeButton.Enabled = False
                BarcodeTextBox.Enabled = False
                SearchButton.Enabled = False
                If BaseProduct.Disableexd(_data.Item("id").ToString()) = 1 Then
                    DateTimePicker.Enabled = True
                    id = _data.Item("id")
                Else
                    DateTimePicker.Enabled = False
                    id = _data.Item("id")
                End If

                For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                    If item.Cells("PRODUCT").Value.ToString() = ProductTextBox.Text Then
                        ChangeButton.Enabled = False
                        Exit For
                    End If
                Next
            Else
                VoidButton.Visible = False
            End If
            DateTimePicker.MinDate = DateTime.Today.AddMonths(6)
            SkuComboBox1.Enabled = False
            ProductTextBox.Enabled = False
            CostTextBox.Enabled = False
            txtPrays.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddDeliveryButton_Click(sender As Object, e As EventArgs) Handles AddDeliveryButton.Click
        Try
            If ProductTextBox.Text = "" Then
                MessageBox.Show("No product selected!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim controls As Object() = {
                    QuantityTextBox
                }
                Dim types As DataInput() = {
                    DataInput.STRING_PRICE
                }
                Dim result As New List(Of Object())
                For i = 0 To controls.Count - 1
                    result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                Next

                If Not result.Any(Function(item As Object()) Not item(0)) Then
                    If Val(txtPrays.Text) = 0 AndAlso Val(CostTextBox.Text) = 0 OrElse ProductTextBox.Text = "" Then
                        MessageBox.Show("Please set the selling price and cost price first!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Dim is_existing As Boolean = False
                        Dim exd As Date = DateTimePicker.Value.Date
                        For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                            If item.Cells("PRODUCT").Value.ToString() = ProductTextBox.Text AndAlso item.Cells("EXPIRY_DATE").Value = exd.ToString("yyyy-MM-dd") Then
                                'item.Cells("MANUFACTURED_DATE").Value = MfdTextBox.Text
                                If BaseDelivery.Daterequired(id) = 1 Then
                                    item.Cells("EXPIRY_DATE").Value = exd.ToString("yyyy-MM-dd")
                                Else
                                    item.Cells("EXPIRY_DATE").Value = "N/A"
                                End If
                                'item.Cells("PRICE").Value = Decimal.Parse(txtPrays.Text)
                                item.Cells("QUANTITY").Value = CInt(QuantityTextBox.Text)
                                item.Cells("TOTAL").Value = Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)
                                'item.Cells("COST PRICE").Value = Decimal.Parse(CostTextBox.Text)
                                is_existing = True
                                ' MessageBox.Show("Product exists.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                'Me.Close()
                                Exit For
                            End If
                        Next

                        If Not is_existing Then
                            If BaseDelivery.Daterequired(id) = 1 Then
                                If DateTimePicker.Value >= Date.Today Then
                                    _parent.DeliveryDataGridView.Rows.Add({BaseTransaction.NamebyID(ProductTextBox.Text),
                                                                              ProductTextBox.Text,
                                                                              exd.ToString("yyyy-MM-dd"),
                                                                              If(String.IsNullOrEmpty(txtPrays.Text), 0, txtPrays.Text),
                                                                              If(String.IsNullOrEmpty(CostTextBox.Text), 0, CostTextBox.Text),
                                                                              If(String.IsNullOrEmpty(QuantityTextBox.Text), 0, QuantityTextBox.Text),
                                                                              CDec(CostTextBox.Text) * CDec(QuantityTextBox.Text)
                                                                              })
                                Else
                                    MessageBox.Show("The Expiration date must not be before today.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            Else
                                _parent.DeliveryDataGridView.Rows.Add({BaseTransaction.NamebyID(ProductTextBox.Text),
                                                                    ProductTextBox.Text,
                                                                    "N/A",
                                                                    txtPrays.Text,
                                                                    If(String.IsNullOrEmpty(CostTextBox.Text) OrElse CostTextBox.Text = "", 0, CostTextBox.Text),
                                                                    QuantityTextBox.Text,
                                                                    CDec(If(String.IsNullOrEmpty(CostTextBox.Text) OrElse CostTextBox.Text = "", 0, CostTextBox.Text)) * CDec(QuantityTextBox.Text)
                                                                    })
                            End If
                        End If
                        _parent.UpdateVisualData()
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("Invalid quantity!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    QuantityTextBox.Text = ""
                End If
            End If
        Catch ex As Exception

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

    Public Sub Clear()
        ProductTextBox.Text = Nothing
        BarcodeTextBox.Text = Nothing
        CostTextBox.Text = Nothing
        QuantityTextBox.Text = Nothing
    End Sub

    Private Sub BarcodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BarcodeTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim res As New List(Of Object()) From {InputValidation.ValidateInputString(BarcodeTextBox, DataInput.STRING_INTEGER)}
                If Not res.Any(Function(item As Object()) Not item(0)) Then
                    Dim dt As DataTable = BaseTransaction.SelectProductsByBarcode(BarcodeTextBox.Text)
                    If BarcodeTextBox.Text.Length <= 13 AndAlso dt.Rows.Count > 0 Then
                        id = dt.Rows(0).Item("id").ToString()
                        CostTextBox.Text = dt.Rows(0).Item("cost").ToString()
                        txtPrays.Text = dt.Rows(0).Item("price").ToString()
                        SkuComboBox1.SelectedItem = dt.Rows(0).Item("sku").ToString()
                        ProductTextBox.Text = dt.Rows(0).Item("product_name").ToString()

                        For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                            If item.Cells("PRODUCT").Value.ToString() = ProductTextBox.Text Then
                                ChangeButton.Enabled = False
                                Exit For
                            End If
                        Next
                        e.Handled = True

                        If BaseProduct.Disableexd(dt.Rows(0).Item("id").ToString()) = 1 Then
                            DateTimePicker.Enabled = True
                        Else
                            DateTimePicker.Enabled = False
                        End If
                    Else
                        MessageBox.Show("No, product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Barcode not valid!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click
        Try
            If ProductTextBox.Text = "" Then
                MessageBox.Show("No, product selected!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf ProductTextBox.Text IsNot Nothing Then
                Dim potangina As New Dictionary(Of String, String) From {
                    {"id", id},
                    {"price", If(String.IsNullOrEmpty(txtPrays.Text), 0, txtPrays.Text)},
                    {"cost", If(String.IsNullOrEmpty(CostTextBox.Text), 0, CostTextBox.Text)}
                }
                Dim dialog As New PricingDialog(data:=potangina, parent:=Me)
                dialog.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

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
End Class