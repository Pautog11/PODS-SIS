Imports System.Windows.Forms

Public Class DeliveryProductDialog
    ' Private _tableAdapter As New podsTableAdapters.viewtblproductsTableAdapter
    Private _dataTable As New pods.viewtblproductsDataTable
    Private _parent As DeliveryCartDialog = Nothing
    Public Sub New(Optional parent As DeliveryCartDialog = Nothing)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
    End Sub

    Private Sub DeliveryProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ProductComboBox.DataSource = _tableAdapter.GetData
        'ProductComboBox.DisplayMember = "PRODUCT"



        'Dim data As DataTable = BaseProduct.Product
        'ProductComboBox.DataSource = data
        'ProductComboBox.DisplayMember = "PRODUCT"
        'ProductComboBox.ValueMember = "ID"
        'data.Rows.Add(-1, "None")
        'ProductComboBox.SelectedValue = -1




        Dim data As DataTable = BaseProduct.Product

        ' Add a new row for "None" at the beginning of the DataTable
        Dim noneRow As DataRow = data.NewRow()
        noneRow("ID") = -1
        noneRow("PRODUCT") = "None"
        data.Rows.InsertAt(noneRow, 0) ' Insert at the beginning

        ' Set the DataSource for the ComboBox
        ProductComboBox.DataSource = data
        ProductComboBox.DisplayMember = "PRODUCT"
        ProductComboBox.ValueMember = "ID"

        ' Set the selected value to "None"
        ProductComboBox.SelectedValue = -1

    End Sub

    Private Sub ProductComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ProductComboBox.SelectionChangeCommitted
        If ProductComboBox.SelectedIndex <> -1 Then
            'MsgBox(ProductComboBox.SelectedItem("ID"))
            Dim info As DataTable = BaseProduct.ProductInfo(ProductComboBox.SelectedItem("ID"))
            BarcodeTextBox.Text = info.Rows(0).Item("BARCODE").ToString()
            PriceTextBox.Text = info.Rows(0).Item("PRICE").ToString()
            CostTextBox.Text = info.Rows(0).Item("COST").ToString()
        End If
    End Sub

    Private Sub BarcodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles BarcodeTextBox.TextChanged
        _dataTable = BaseProduct.Search(BarcodeTextBox.Text)
        If _dataTable IsNot Nothing AndAlso _dataTable.Rows.Count > 0 Then
            PriceTextBox.Text = _dataTable.Rows(0).Item("PRICE").ToString()
            CostTextBox.Text = _dataTable.Rows(0).Item("COST").ToString()
            'QuantityTextBox.Text = _dataTable.Rows(0).Item("ID").ToString()
        Else
            PriceTextBox.Text = ""
            CostTextBox.Text = ""
        End If

    End Sub

    Private Sub AddDeliveryButton_Click(sender As Object, e As EventArgs) Handles AddDeliveryButton.Click
        For Each item As DataRow In _parent._itemSource.Rows
            item.Item("ID") = "add"
            item.Item("PR") = "add"
            Exit For
        Next
        _parent.UpdateVisualData()
    End Sub
End Class
