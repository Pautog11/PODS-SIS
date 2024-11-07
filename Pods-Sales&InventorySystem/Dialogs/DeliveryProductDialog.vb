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
    End Sub

    Private Sub AddDeliveryButton_Click(sender As Object, e As EventArgs) Handles AddDeliveryButton.Click
        Dim result As New List(Of Object)()
        result.Add(InputValidation.ValidateInputString(QuantityTextBox, DataInput.STRING_INTEGER))

        Dim is_existing As Boolean = False

        If Not result.Any(Function(item As Object()) Not item(0)) Then
            For Each item As DataGridViewRow In _parent.DeliveryDataGridView.Rows
                If item.Cells("PRODUCT").Value.ToString() = ProductComboBox.Text Then
                    item.Cells("PRICE").Value = Decimal.Parse(CostTextBox.Text)
                    item.Cells("QUANTITY").Value = CInt(QuantityTextBox.Text)
                    item.Cells("TOTAL").Value = Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)
                    is_existing = True
                    Exit For
                End If
            Next

            If Not is_existing Then
                _parent.DeliveryDataGridView.Rows.Add({ProductComboBox.SelectedItem("ID"),
                                                      ProductComboBox.Text,
                                                      MfdTextBox.Text,
                                                      ExdTextBox.Text,
                                                      CostTextBox.Text,
                                                      QuantityTextBox.Text,
                                                      CDec(CostTextBox.Text) * CDec(QuantityTextBox.Text)
                                                      })

            End If
            _parent.UpdateVisualData()
            Me.Close()
        Else
            MessageBox.Show("Invalid quantity!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        'MsgBox(MfgDate.Value.ToString("dd-MM-yyyy"))
        '{"date", DateTimePicker1.Value.ToString("MMM dd yyyy")}
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

    Private Sub MfgDate_ValueChanged(sender As Object, e As EventArgs)
        'MsgBox(MfgDate.Value)
        'MsgBox(MfgDate.Value.ToString("dd-MM-yyyy"))
    End Sub
End Class

