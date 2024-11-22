Imports System.Windows.Forms

Public Class DeliveryProductDialog
    Private ReadOnly _tableAdapter As New podsTableAdapters.viewtblcategoriesTableAdapter
    Private ReadOnly _dataTable As New pods.viewtblcategoriesDataTable
    Private ReadOnly _parent As DeliveryCartDialog = Nothing
    Dim id As Integer = Nothing
    Public Sub New(Optional parent As DeliveryCartDialog = Nothing)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
    End Sub

    Private Sub DeliveryProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CategoryComboBox.DataSource = _tableAdapter.GetData
        'CategoryComboBox.DisplayMember = "CATEGORY"
        'PriceTextBox.ReadOnly = True
        DateTimePicker.MinDate = DateTime.Today.AddMonths(6)
        'MfgDate.MaxDate = DateTime.Now
        'ExpiryDate.MinDate = Date.Today

        ' DateTimePicker1.Value = DateTime.MinValue

        SkuComboBox1.Enabled = False
        ProductTextBox.Enabled = False
        CostTextBox.Enabled = False
        txtPrays.Enabled = False
    End Sub

    Private Sub ProductComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs)
        'If ProductComboBox.SelectedIndex <> -1 Then
        '    Dim info As DataTable = BaseProduct.ProductInfo(ProductComboBox.SelectedItem("ID"))
        '    'BarcodeTextBox.Text = info.Rows(0).Item("BARCODE").ToString()
        '    CostTextBox.Text = info.Rows(0).Item("COST").ToString()
        'End If

        'Dim dt As DataTable = BaseDelivery.FillSkuByProduct(ProductComboBox.Text)
        'SkuComboBox1.DataSource = dt
        'SkuComboBox1.DisplayMember = "sku"

        'If BaseDelivery.Daterequired(ProductComboBox.SelectedItem("ID")) = 0 Then
        '    ' MfdTextBox.Enabled = False
        '    DateTimePicker.Enabled = False
        'Else
        '    'MfdTextBox.Enabled = True
        '    DateTimePicker.Enabled = True
        'End If
    End Sub

    Private Sub AddDeliveryButton_Click(sender As Object, e As EventArgs) Handles AddDeliveryButton.Click
        Dim controls As Object() = {
            BarcodeTextBox, QuantityTextBox
        }
        Dim types As DataInput() = {
            DataInput.STRING_INTEGER, DataInput.STRING_INTEGER
        }
        Dim result As New List(Of Object())
        For i = 0 To controls.Count - 1
            result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
        Next

        If Not result.Any(Function(item As Object()) Not item(0)) Then
            Dim is_existing As Boolean = False
            Dim exd As Date = DateTimePicker.Value.Date
            'If Not result.Any(Function(item As Object()) Not item(0)) Then
            For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                If item.Cells("PRODUCT").Value.ToString() = ProductTextBox.Text AndAlso item.Cells("EXPIRY_DATE").Value = exd.ToString("yyyy-MM-dd") Then
                    'item.Cells("MANUFACTURED_DATE").Value = MfdTextBox.Text
                    item.Cells("EXPIRY_DATE").Value = exd
                    item.Cells("PRICE").Value = Decimal.Parse(txtPrays.Text)
                    item.Cells("QUANTITY").Value = CInt(QuantityTextBox.Text)
                    item.Cells("TOTAL").Value = Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)
                    item.Cells("COST PRICE").Value = Decimal.Parse(CostTextBox.Text)
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
        Else
            MessageBox.Show("Invalid quantity or No product selected!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
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
        If e.KeyCode = Keys.Enter Then
            Dim res As New List(Of Object()) From {InputValidation.ValidateInputString(BarcodeTextBox, DataInput.STRING_INTEGER)}
            If Not res.Any(Function(item As Object()) Not item(0)) Then
                Dim dt As DataTable = BaseTransaction.SelectProductsByBarcode(BarcodeTextBox.Text)
                If BarcodeTextBox.Text.Length <= 13 AndAlso dt.Rows.Count > 0 Then
                    'Dim productName As String = dt.Rows(0).Item("product_name").ToString()
                    'Dim sku As String = dt.Rows(0).Item("sku").ToString()
                    'Dim productSubCategory As String = BaseSubCategory.Fillsubcategorybyid(dt.Rows(0).Item("subcategory_id").ToString())

                    'If Not ProductComboBox.Items.Contains(ProductName) Then
                    '    ProductComboBox.DataSource = Nothing
                    '    ProductComboBox.Items.Add(ProductName)
                    'End If

                    'If Not SkuComboBox1.Items.Contains(sku) Then
                    '    SkuComboBox1.DataSource = Nothing
                    '    SkuComboBox1.Items.Add(sku)
                    'End If

                    'If Not SubcategoryComboBox.Items.Contains(productSubCategory) Then
                    '    SubcategoryComboBox.DataSource = Nothing
                    '    SubcategoryComboBox.Items.Clear()
                    '    SubcategoryComboBox.Items.Add(productSubCategory)
                    'End If
                    id = dt.Rows(0).Item("id").ToString()
                    CostTextBox.Text = dt.Rows(0).Item("cost").ToString()
                    txtPrays.Text = dt.Rows(0).Item("price").ToString()
                    SkuComboBox1.SelectedItem = dt.Rows(0).Item("sku").ToString()
                    ProductTextBox.Text = dt.Rows(0).Item("product_name").ToString()
                    'CostTextBox.Text = dt.Rows(0).Item("product_cost").ToString()
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
    End Sub

    Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click
        Dim potangina As New Dictionary(Of String, String) From {
            {"id", id},
            {"price", If(String.IsNullOrEmpty(txtPrays.Text), 0, txtPrays.Text)},
            {"cost", If(String.IsNullOrEmpty(CostTextBox.Text), 0, CostTextBox.Text)}
        }
        Dim dialog As New PricingDialog(data:=potangina)
        dialog.ShowDialog()
    End Sub
End Class