Imports System.Windows.Forms
Imports Pods_Sales_InventorySystem.pods

Public Class DeliveryCartDialog
    Private _tableAdapter As New podsTableAdapters.viewtblsuppliersTableAdapter
    Private _subject As IObservablePanel
    Public _itemSource As DataTable
    Private _data As DataRowView

    Public Sub New(Optional subject As IObservablePanel = Nothing,
                   Optional data As DataRowView = Nothing)
        InitializeComponent()
        _data = data
        _subject = subject
    End Sub
    Private Sub DeliveryCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim supplier_data As viewtblsuppliersDataTable = _tableAdapter.GetData()
        SupplierNameComboBox.DataSource = supplier_data
        SupplierNameComboBox.DisplayMember = "NAME"
        SupplierNameComboBox.ValueMember = "id"

        If _data Is Nothing Then
            'Create a data table to populate the item source
            _itemSource = New DataTable
            _itemSource.Columns.Add("ID")
            _itemSource.Columns.Add("PR")
        End If
    End Sub
    'Private Sub DeliveryDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles DeliveryDataGridView.SelectionChanged
    '    If _data Is Nothing AndAlso Not _is_from_notif Then
    '        If DeliveryDataGridView.SelectedItems.Count > 0 Then
    '            Dim data As DataRowView = ItemsDataGridView.SelectedItems(0)
    '            Dialog.Show(New TransactionProductDialog(Me, data))
    '            ItemsDataGridView.SelectedIndex = -1
    '        End If
    '    End If
    'End Sub
    Public Sub UpdateVisualData()
        DeliveryDataGridView.DataSource = _itemSource?.DefaultView
    End Sub
    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Dim dialog As New DeliveryProductDialog(parent:=Me)
        dialog.ShowDialog()
    End Sub
End Class
