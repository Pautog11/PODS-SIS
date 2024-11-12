Imports System.Windows.Forms

Public Class DeliveryProductDialog
    Private ReadOnly _tableAdapter As New podsTableAdapters.viewtblcategoriesTableAdapter
    Private ReadOnly _dataTable As New pods.viewtblcategoriesDataTable
    Private ReadOnly _parent As DeliveryCartDialog = Nothing
    Public Sub New(Optional parent As DeliveryCartDialog = Nothing)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
    End Sub

    Private Sub DeliveryProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoryComboBox.DataSource = _tableAdapter.GetData
        CategoryComboBox.DisplayMember = "CATEGORY"
        'PriceTextBox.ReadOnly = True
        CostTextBox.Enabled = False

        'MfgDate.MaxDate = DateTime.Now
        'ExpiryDate.MinDate = Date.Today

        ' DateTimePicker1.Value = DateTime.MinValue
    End Sub

    Private Sub ProductComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ProductComboBox.SelectionChangeCommitted
        If ProductComboBox.SelectedIndex <> -1 Then
            Dim info As DataTable = BaseProduct.ProductInfo(ProductComboBox.SelectedItem("ID"))
            'BarcodeTextBox.Text = info.Rows(0).Item("BARCODE").ToString()
            CostTextBox.Text = info.Rows(0).Item("COST").ToString()
        End If

        Dim dt As DataTable = BaseDelivery.FillSkuByProduct(ProductComboBox.Text)
        Guna2ComboBox1.DataSource = dt
        Guna2ComboBox1.DisplayMember = "sku"

        If BaseDelivery.Daterequired(ProductComboBox.SelectedItem("ID")) = 0 Then
            ' MfdTextBox.Enabled = False
            ExdTextBox.Enabled = False
        Else
            'MfdTextBox.Enabled = True
            ExdTextBox.Enabled = True
        End If
    End Sub

    Private Sub AddDeliveryButton_Click(sender As Object, e As EventArgs) Handles AddDeliveryButton.Click
        Dim result As New List(Of Object)() From {InputValidation.ValidateInputString(QuantityTextBox, DataInput.STRING_INTEGER)}
        'result.Add(InputValidation.ValidateInputString(QuantityTextBox, DataInput.STRING_INTEGER))

        Dim is_existing As Boolean = False

        If Not result.Any(Function(item As Object()) Not item(0)) Then
            For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                If item.Cells("PRODUCT").Value.ToString() = ProductComboBox.Text AndAlso item.Cells("EXPIRY_DATE").Value = ExdTextBox.Text Then
                    'item.Cells("MANUFACTURED_DATE").Value = MfdTextBox.Text
                    'item.Cells("EXPIRY_DATE").Value = ExdTextBox.Text
                    'item.Cells("PRICE").Value = Decimal.Parse(CostTextBox.Text)
                    'item.Cells("QUANTITY").Value = CInt(QuantityTextBox.Text)
                    'item.Cells("TOTAL").Value = Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)
                    is_existing = True
                    MessageBox.Show("Product exists.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'Me.Close()
                    Exit For
                End If
            Next

            If Not is_existing Then
                If BaseDelivery.Daterequired(ProductComboBox.SelectedItem("ID")) = 1 Then
                    Dim controls As Object() = {
                         ExdTextBox
                    }
                    Dim types As DataInput() = {
                       DataInput.STRING_DATE
                    }
                    Dim dateresult As New List(Of Object())
                    For i = 0 To controls.Count - 1
                        dateresult.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                    Next

                    If Not dateresult.Any(Function(item As Object()) Not item(0)) Then
                        If ExdTextBox.Text >= Date.Today Then
                            _parent.DeliveryDataGridView.Rows.Add({ProductComboBox.SelectedItem("ID"),
                                                    ProductComboBox.Text,
                                                    ExdTextBox.Text,
                                                    CostTextBox.Text,
                                                    QuantityTextBox.Text,
                                                    CDec(CostTextBox.Text) * CDec(QuantityTextBox.Text)
                                                    })
                        Else
                            MessageBox.Show("The Expiration date must not be before today.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("Date is required.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    _parent.DeliveryDataGridView.Rows.Add({ProductComboBox.SelectedItem("ID"),
                                                    ProductComboBox.Text,
                                                    ExdTextBox.Text,
                                                    CostTextBox.Text,
                                                    QuantityTextBox.Text,
                                                    CDec(CostTextBox.Text) * CDec(QuantityTextBox.Text)
                                                    })
                End If
            End If
            _parent.UpdateVisualData()
            Me.Close()
        Else
            MessageBox.Show("Invalid quantity!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        'MsgBox(ProductComboBox.SelectedItem("ID"))
        '{"date", DateTimePicker1.Value.ToString("MMM dd yyyy")}

        'If MfdTextBox.Text <= Date.Today AndAlso ExdTextBox.Text >= Date.Today Then
        '    MsgBox("wong")
        'Else
        '    MsgBox("The Manufacture Date must not be after today and the Expiration Date must not be before today.")
        'End If
    End Sub

    Private Sub CategoryComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles CategoryComboBox.DropDownClosed
        If CategoryComboBox.SelectedIndex >= 0 Then
            Dim dt As DataTable = BaseSubCategory.FetchSubCategory(CategoryComboBox.SelectedItem("ID"))
            SubcategoryComboBox.DataSource = dt.DefaultView
            SubcategoryComboBox.DisplayMember = "subcategory"
        End If
        Clear()
    End Sub
    Private Sub SubcategoryComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles SubcategoryComboBox.DropDownClosed
        If SubcategoryComboBox.SelectedIndex >= 0 Then
            Dim dt As DataTable = BaseProduct.FetchProductBySubcategory(SubcategoryComboBox.SelectedItem("ID"))
            ProductComboBox.DataSource = dt.DefaultView
            ProductComboBox.DisplayMember = "product_name"
        End If
        Clear()
    End Sub

    Public Sub Clear()
        ProductComboBox.Text = Nothing
        BarcodeTextBox.Text = Nothing
        CostTextBox.Text = Nothing
        QuantityTextBox.Text = Nothing
    End Sub

    Private Sub BarcodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BarcodeTextBox.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    Dim res As New List(Of Object()) From {InputValidation.ValidateInputString(BarcodeTextBox, DataInput.STRING_INTEGER)}
        '    If Not res.Any(Function(item As Object()) Not item(0)) Then
        '        Dim dt As DataTable = BaseTransaction.SelectProductsByBarcode(BarcodeTextBox.Text)
        '        If BarcodeTextBox.Text.Length = 13 AndAlso dt.Rows.Count > 0 Then
        '            If Not ProductComboBox.Items.Contains(dt.Rows(0).Item("product_name").ToString()) Then
        '                'ProductComboBox.Items.Add(dt.Rows(0).Item("product_name").ToString())
        '            End If
        '            ProductComboBox.SelectedItem = dt.Rows(0).Item("product_name").ToString()
        '            ProductComboBox.Text = dt.Rows(0).Item("product_name").ToString()

        '            'ProductComboBox.Items.Add(dt.Rows(0).Item("product_name").ToString())
        '            CostTextBox.Text = dt.Rows(0).Item("product_cost").ToString()
        '            'PriceTextBox.Text = dt.Rows(0).Item("product_price").ToString()
        '            e.Handled = True
        '        Else
        '            MessageBox.Show("No, product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            BarcodeTextBox.Text = ""
        '        End If
        '    Else
        '        MessageBox.Show("Barcode not valid!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        BarcodeTextBox.Text = ""
        '        Return
        '    End If
        'End If
        If e.KeyCode = Keys.Enter Then
            ' Validate the input string (barcode)
            Dim validationResult As New List(Of Object()) From {InputValidation.ValidateInputString(BarcodeTextBox, DataInput.STRING_INTEGER)}

            ' If validation fails, show a warning and exit
            If validationResult.Any(Function(item As Object()) Not item(0)) Then
                MessageBox.Show("Barcode not valid!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                BarcodeTextBox.Clear()  ' Clear the barcode input
                Return
            End If

            ' Query the product details based on the barcode
            Dim dt As DataTable = BaseTransaction.SelectProductsByBarcode(BarcodeTextBox.Text)

            ' If barcode is valid and product is found
            If BarcodeTextBox.Text.Length = 13 AndAlso dt.Rows.Count > 0 Then
                Dim productName As String = dt.Rows(0).Item("product_name").ToString()

                ' Check if the product name is not already in the combo box and add it if necessary
                If Not ProductComboBox.Items.Contains(productName) Then
                    ' ProductComboBox.Items.Add(productName)  ' Uncomment if you need to add the product name to the combo box
                End If

                ' Set the selected item and text of the combo box
                ProductComboBox.SelectedItem = productName
                ProductComboBox.Text = productName

                ' Set the cost text box
                CostTextBox.Text = dt.Rows(0).Item("product_cost").ToString()

                ' Optionally, set the price text box if required
                ' PriceTextBox.Text = dt.Rows(0).Item("product_price").ToString()

                ' Mark the event as handled
                e.Handled = True
            Else
                ' If no product found, show an error message
                MessageBox.Show("No product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BarcodeTextBox.Clear()  ' Clear the barcode input
            End If
        End If

    End Sub

    'Private Sub MfgDate_ValueChanged(sender As Object, e As EventArgs)
    '    'MsgBox(MfgDate.Value)
    '    'MsgBox(MfgDate.Value.ToString("dd-MM-yyyy"))
    'End Sub
End Class

