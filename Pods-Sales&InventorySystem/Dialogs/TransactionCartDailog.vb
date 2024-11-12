Imports System.Windows.Forms

Public Class TransactionCartDailog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _tableAdapter As New podsTableAdapters.viewtblcategoriesTableAdapter
    Private ReadOnly _dataTable As New pods.viewtblcategoriesDataTable
    Private ReadOnly _subject As IObservablePanel
    Private ReadOnly _parent As TransactionDialog = Nothing
    Public Sub New(Optional subject As IObservablePanel = Nothing,
                   Optional parent As TransactionDialog = Nothing,
                   Optional data As Dictionary(Of String, String) = Nothing)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _subject = subject
        _data = data
    End Sub
    Private Sub TransactionCartDailog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoryComboBox.DataSource = _tableAdapter.GetData
        CategoryComboBox.DisplayMember = "CATEGORY"
        PriceTextBox.Enabled = False
        StocksTextBox.Enabled = False

        If _data IsNot Nothing Then
            PriceTextBox.Text = _data.Item("product_price")
        End If
    End Sub

    Private Sub CategoryComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CategoryComboBox.SelectionChangeCommitted
        If CategoryComboBox.SelectedIndex >= 0 Then
            Dim dt As DataTable = BaseSubCategory.FetchSubCategory(CategoryComboBox.SelectedItem("ID"))
            SubcategoryComboBox.DataSource = dt.DefaultView
            SubcategoryComboBox.DisplayMember = "subcategory"
        End If
        SubcategoryComboBox.Enabled = True
        ProductComboBox.Text = ""
        'ProductComboBox.Items.Clear()
        'SubcategoryComboBox.Items.Clear()

    End Sub
    Private Sub SubcategoryComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles SubcategoryComboBox.DropDownClosed
        If SubcategoryComboBox.SelectedIndex >= 0 Then
            Dim dt As DataTable = BaseProduct.FetchProductBySubcategory(SubcategoryComboBox.SelectedItem("ID"))
            ProductComboBox.DataSource = dt.DefaultView
            ProductComboBox.DisplayMember = "product_name"
        End If
        ProductComboBox.Enabled = True
    End Sub
    Private Sub ProductComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ProductComboBox.SelectionChangeCommitted
        If ProductComboBox.SelectedIndex <> -1 Then
            Dim info As DataTable = BaseProduct.ProductInfo(ProductComboBox.SelectedItem("ID"))
            'BarcodeTextBox.Text = info.Rows(0).Item("BARCODE").ToString()
            PriceTextBox.Text = info.Rows(0).Item("PRICE").ToString()
            StocksTextBox.Text = info.Rows(0).Item("QUANTITY").ToString()
        End If
    End Sub

    Private Sub AddTransactionButton_Click(sender As Object, e As EventArgs) Handles AddTransactionButton.Click
        Dim result As New List(Of Object()) From {InputValidation.ValidateInputString(QuantityTextBox, DataInput.STRING_INTEGER)}
        Dim is_existing As Boolean = False
        If Not result.Any(Function(item As Object()) Not item(0)) Then
            For Each item As DataGridViewRow In _parent.TransactionDataGridView.Rows
                If item.Cells("PRODUCT").Value.ToString() = ProductComboBox.Text Then
                    item.Cells("PRICE").Value = Decimal.Parse(PriceTextBox.Text)
                    item.Cells("QUANTITY").Value = CInt(QuantityTextBox.Text)
                    item.Cells("TOTAL").Value = Decimal.Parse(PriceTextBox.Text) * CInt(QuantityTextBox.Text)
                    is_existing = True
                    Exit For
                End If
            Next

            If Not is_existing Then
                If CInt(StocksTextBox.Text) >= QuantityTextBox.Text Then
                    _parent.TransactionDataGridView.Rows.Add({BaseProduct.ScalarProductId(ProductComboBox.Text),
                                                     ProductComboBox.Text,
                                                     PriceTextBox.Text,
                                                     QuantityTextBox.Text,
                                                     CDec(PriceTextBox.Text) * CDec(QuantityTextBox.Text)
                                                     })
                Else
                    MessageBox.Show("Insufficient stocks!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            _parent.UpdateVisualData()
            Me.Close()
        Else
            MessageBox.Show("Invalid quantity!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BarcodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BarcodeTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim res As New List(Of Object()) From {InputValidation.ValidateInputString(BarcodeTextBox, DataInput.STRING_INTEGER)}
            If Not res.Any(Function(item As Object()) Not item(0)) Then
                Dim dt As DataTable = BaseTransaction.SelectProductsByBarcode(BarcodeTextBox.Text)
                If BarcodeTextBox.Text.Length <= 13 AndAlso dt.Rows.Count > 0 Then
                    Dim productName As String = dt.Rows(0).Item("product_name").ToString()
                    Dim productSubCategory As String = BaseSubCategory.Fillsubcategorybyid(dt.Rows(0).Item("subcategory_id").ToString())

                    ' Check if the product name already exists in the ComboBox
                    If Not ProductComboBox.Items.Contains(productName) Then
                        ' If not, add the product name to the ComboBox
                        ProductComboBox.DataSource = Nothing
                        ProductComboBox.Items.Add(productName)
                        ComboBox1.Text = productName
                    End If

                    If Not SubcategoryComboBox.Items.Contains(productSubCategory) Then
                        ' If not, add the product name to the ComboBox
                        SubcategoryComboBox.DataSource = Nothing
                        SubcategoryComboBox.Items.Clear()
                        SubcategoryComboBox.Items.Add(productSubCategory)
                    End If
                    ProductComboBox.SelectedItem = dt.Rows(0).Item("product_name").ToString()
                    ProductComboBox.Text = dt.Rows(0).Item("product_name").ToString()

                    'ProductComboBox.Items.Add(dt.Rows(0).Item("product_name").ToString())
                    StocksTextBox.Text = dt.Rows(0).Item("quantity").ToString()
                    PriceTextBox.Text = dt.Rows(0).Item("product_price").ToString()
                    e.Handled = True
                Else
                    MessageBox.Show("No, product found!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Barcode not valid!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'BarcodeTextBox.Text = ""
                'Return
            End If
        End If
        SubcategoryComboBox.Enabled = False
        ProductComboBox.Enabled = False
    End Sub

End Class
