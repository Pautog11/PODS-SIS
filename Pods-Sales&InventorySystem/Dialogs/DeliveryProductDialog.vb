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
            BarcodeTextBox.Text = info.Rows(0).Item("BARCODE").ToString()
            CostTextBox.Text = info.Rows(0).Item("COST").ToString()
        End If

        Dim dt As DataTable = BaseDelivery.FillSkuByProduct(ProductComboBox.Text)
        Guna2ComboBox1.DataSource = dt
        Guna2ComboBox1.DisplayMember = "sku"

        If BaseDelivery.Daterequired(ProductComboBox.SelectedItem("ID")) = 0 Then
            MfdTextBox.Enabled = False
            ExdTextBox.Enabled = False
        Else
            MfdTextBox.Enabled = True
            ExdTextBox.Enabled = True
        End If
    End Sub

    Private Sub AddDeliveryButton_Click(sender As Object, e As EventArgs) Handles AddDeliveryButton.Click
        Dim result As New List(Of Object)() From {InputValidation.ValidateInputString(QuantityTextBox, DataInput.STRING_INTEGER)}
        'result.Add(InputValidation.ValidateInputString(QuantityTextBox, DataInput.STRING_INTEGER))

        Dim is_existing As Boolean = False

        If Not result.Any(Function(item As Object()) Not item(0)) Then
            For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                If item.Cells("PRODUCT").Value.ToString() = ProductComboBox.Text AndAlso item.Cells("MANUFACTURED_DATE").Value = MfdTextBox.Text AndAlso item.Cells("EXPIRY_DATE").Value = MfdTextBox.Text Then
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
                        MfdTextBox, ExdTextBox
                    }
                    Dim types As DataInput() = {
                        DataInput.STRING_DATE, DataInput.STRING_DATE
                    }
                    Dim dateresult As New List(Of Object())
                    For i = 0 To controls.Count - 1
                        dateresult.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                    Next

                    If Not dateresult.Any(Function(item As Object()) Not item(0)) Then
                        If MfdTextBox.Text <= Date.Today AndAlso ExdTextBox.Text >= Date.Today Then
                            _parent.DeliveryDataGridView.Rows.Add({ProductComboBox.SelectedItem("ID"),
                                                    ProductComboBox.Text,
                                                    MfdTextBox.Text,
                                                    ExdTextBox.Text,
                                                    CostTextBox.Text,
                                                    QuantityTextBox.Text,
                                                    CDec(CostTextBox.Text) * CDec(QuantityTextBox.Text)
                                                    })
                        Else
                            MessageBox.Show("The Manufactured date must not be after today or the Expiration date must not be before today.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("Date is required.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    _parent.DeliveryDataGridView.Rows.Add({ProductComboBox.SelectedItem("ID"),
                                                    ProductComboBox.Text,
                                                    MfdTextBox.Text,
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

    'Private Sub MfgDate_ValueChanged(sender As Object, e As EventArgs)
    '    'MsgBox(MfgDate.Value)
    '    'MsgBox(MfgDate.Value.ToString("dd-MM-yyyy"))
    'End Sub
End Class

