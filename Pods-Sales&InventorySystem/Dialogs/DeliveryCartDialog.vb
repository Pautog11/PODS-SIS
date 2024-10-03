Imports System.Windows.Forms
Imports Pods_Sales_InventorySystem.pods

Public Class DeliveryCartDialog
    Private _tableAdapter As New podsTableAdapters.viewtblsuppliersTableAdapter
    Private _subject As IObservablePanel
    Public Sub New(Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
    End Sub
    Private Sub DeliveryCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim supplier_data As viewtblsuppliersDataTable = _tableAdapter.GetData()
        SupplierNameComboBox.DataSource = supplier_data
        SupplierNameComboBox.DisplayMember = "NAME"
        SupplierNameComboBox.ValueMember = "id"
    End Sub

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Dim dialog As New DeliveryProductDialog(parent:=Me)
        dialog.ShowDialog()
    End Sub
End Class
