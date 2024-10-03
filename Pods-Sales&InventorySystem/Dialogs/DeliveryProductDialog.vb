Imports System.Windows.Forms

Public Class DeliveryProductDialog
    Private _tableAdapter As New podsTableAdapters.viewtblproductsTableAdapter
    Private _parent As DeliveryCartDialog = Nothing
    Public Sub New(Optional parent As DeliveryCartDialog = Nothing)

        ' This call is required by the designer.
        InitializeComponent()
        _parent = parent
    End Sub

    Private Sub DeliveryProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductComboBox.DataSource = _tableAdapter.GetData
        ProductComboBox.DisplayMember = "PRODUCT"
        'ProductComboBox.SelectedItem = "ID"
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
End Class
