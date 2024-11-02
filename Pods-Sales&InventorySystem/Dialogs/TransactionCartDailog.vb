Imports System.Windows.Forms

Public Class TransactionCartDailog
    Private ReadOnly _tableAdapter As New podsTableAdapters.viewtblcategoriesTableAdapter
    Private ReadOnly _dataTable As New pods.viewtblcategoriesDataTable
    Private ReadOnly _subject As IObservablePanel
    Private ReadOnly _parent As TransactionDialog = Nothing
    Public Sub New(Optional subject As IObservablePanel = Nothing,
                   Optional parent As TransactionDialog = Nothing)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
        _subject = subject
    End Sub
    Private Sub TransactionCartDailog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoryComboBox.DataSource = _tableAdapter.GetData
        CategoryComboBox.DisplayMember = "CATEGORY"
    End Sub

    Private Sub CategoryComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CategoryComboBox.SelectionChangeCommitted
        If CategoryComboBox.SelectedIndex >= 0 Then
            Dim dt As DataTable = BaseSubCategory.FetchSubCategory(CategoryComboBox.SelectedItem("ID"))
            SubcategoryComboBox.DataSource = dt.DefaultView
            SubcategoryComboBox.DisplayMember = "subcategory"
        End If
        ProductComboBox.Text = Nothing
    End Sub
    Private Sub SubcategoryComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles SubcategoryComboBox.DropDownClosed
        If SubcategoryComboBox.SelectedIndex >= 0 Then
            Dim dt As DataTable = BaseProduct.FetchProductBySubcategory(SubcategoryComboBox.SelectedItem("ID"))
            ProductComboBox.DataSource = dt.DefaultView
            ProductComboBox.DisplayMember = "product_name"
        End If
    End Sub
    Private Sub ProductComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ProductComboBox.SelectionChangeCommitted
        If ProductComboBox.SelectedIndex <> -1 Then
            Dim info As DataTable = BaseProduct.ProductInfo(ProductComboBox.SelectedItem("ID"))
            'BarcodeTextBox.Text = info.Rows(0).Item("BARCODE").ToString()
            CostTextBox.Text = info.Rows(0).Item("PRICE").ToString()
        End If
    End Sub

    Private Sub AddTransactionButton_Click(sender As Object, e As EventArgs) Handles AddTransactionButton.Click
        Dim result As New List(Of Object()) '= New List(Of Object())()
        result.Add(InputValidation.ValidateInputString(QuantityTextBox, DataInput.STRING_INTEGER))

        Dim is_existing As Boolean = False

        If Not result.Any(Function(item As Object()) Not item(0)) Then
            For Each item As DataGridViewRow In _parent.TransactionDataGridView.Rows
                If item.Cells("PRODUCT").Value.ToString() = ProductComboBox.Text Then
                    item.Cells("PRICE").Value = Decimal.Parse(CostTextBox.Text)
                    item.Cells("QUANTITY").Value = CInt(QuantityTextBox.Text)
                    item.Cells("TOTAL").Value = Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)
                    is_existing = True
                    Exit For
                End If
            Next

            If Not is_existing Then
                _parent.TransactionDataGridView.Rows.Add({ProductComboBox.SelectedItem("ID"),
                                                      ProductComboBox.Text,
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
    End Sub
End Class
