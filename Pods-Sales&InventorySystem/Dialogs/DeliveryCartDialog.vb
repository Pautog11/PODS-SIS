Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Pods_Sales_InventorySystem.pods

Public Class DeliveryCartDialog
    Private _tableAdapter As New podsTableAdapters.viewtblsuppliersTableAdapter
    Private _subject As IObservablePanel
    Public _itemSource As DataTable
    Private ReadOnly _data As Dictionary(Of String, String)
    'Private _data As DataRowView

    Public Sub New(Optional subject As IObservablePanel = Nothing,
                   Optional data As Dictionary(Of String, String) = Nothing)
        InitializeComponent()
        _data = data
        _subject = subject

    End Sub
    Private Sub DeliveryCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim supplier_data As viewtblsuppliersDataTable = _tableAdapter.GetData()
        SupplierNameComboBox.DataSource = supplier_data
        SupplierNameComboBox.DisplayMember = "NAME"
        SupplierNameComboBox.ValueMember = "id"

        'If _data Is Nothing Then
        '    _itemSource = New DataTable()
        '    ''_itemSource.Rows()
        '    _itemSource.Columns.Add("aa", GetType(String)) ' Adjust type as needed
        '    _itemSource.Columns.Add("bb", GetType(String)) ' Adjust type as needed
        'End If
        'Dim newRow As DataRow = _itemSource.NewRow()
        'newRow("aa") = "Value for aa"
        'newRow("bb") = "Value for bb"

        If _data IsNot Nothing Then
            AddProductButton.Visible = False
            SaveButton.Visible = False

            TotalPrice.Text = _data("total")
            DateTimePicker1.Value = _data("date")
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
        Dim total As Integer = 0
        For i = 0 To DeliveryDataGridView?.Rows.Count - 1
            total += DeliveryDataGridView.Rows(i).Cells("TOTAL").Value
        Next
        TotalPrice.Text = total
    End Sub

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Dim dialog As New DeliveryProductDialog(parent:=Me)
        dialog.ShowDialog()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'MsgBox(DateTimePicker1.Value.ToString("dd/MM/yyyy"))

        'Dim con As SqlConnection = SqlConnectionPods.GetInstance
        'Dim cmd As New SqlCommand

        'Dim transaction As SqlTransaction = con.BeginTransaction()

        'Try
        '    cmd = New SqlCommand("insert into tbldeliveries (supplier_id, total, date) values (@supplier_id, @total, @date); SELECT SCOPE_IDENTITY()", con, transaction)
        '    cmd.Parameters.AddWithValue("@supplier_id", SupplierNameComboBox.SelectedItem("id"))
        '    cmd.Parameters.AddWithValue("@total", TotalPrice.Text)
        '    cmd.Parameters.AddWithValue("@date", DateTimePicker1.Value.ToString("yyyy/MM/dd"))

        '    Dim lastInsertedId As Object = cmd.ExecuteScalar()
        '    If lastInsertedId IsNot Nothing Then
        '        Dim deliveryId As Integer = Convert.ToInt32(lastInsertedId)
        '        cmd = New SqlCommand("insert into tbldeliveries_items (delivery_id, product_id, price, quantity, total) values (@delivery_id, @product_id, @price, @quantity, @total)", con, transaction)
        '        For Each row As DataGridViewRow In DeliveryDataGridView.Rows
        '            If Not row.IsNewRow Then
        '                cmd.Parameters.Clear()
        '                cmd.Parameters.AddWithValue("@delivery_id", deliveryId)
        '                cmd.Parameters.AddWithValue("@product_id", row.Cells(0).Value)
        '                cmd.Parameters.AddWithValue("@price", row.Cells(2).Value)
        '                cmd.Parameters.AddWithValue("@quantity", row.Cells(3).Value)
        '                cmd.Parameters.AddWithValue("@total", row.Cells(4).Value)
        '                cmd.ExecuteNonQuery()
        '            End If
        '        Next
        '    End If
        '    transaction.Commit()
        '    Me.Close()
        'Catch ex As Exception
        '    transaction.Rollback()
        '    MsgBox(ex.Message)
        'End Try

        Dim items As New List(Of Dictionary(Of String, String))()
        Dim baseCommand As ICommandPanel ' = Nothing
        Dim invoker As ICommandInvoker
        Dim data As New Dictionary(Of String, String) From {
            {"id", If(_data?.Item("id"), String.Empty)},
            {"supplier_id", If(DirectCast(SupplierNameComboBox.SelectedItem, DataRowView)("id"), String.Empty)},
            {"total", TotalPrice.Text},
            {"date", DateTimePicker1.Value.ToString("MMM dd yyyy")} 'DateTimePicker1.Value.ToString("yyyy/MM/dd")}
        }

        For Each row As DataGridViewRow In DeliveryDataGridView.Rows
            ' Check if the row is not the new row added automatically at the end of DataGridView
            If Not row.IsNewRow Then
                Dim item As New Dictionary(Of String, String) From {
                {"product_id", row.Cells(0).Value},
                {"price", If(row.Cells(2).Value?.ToString(), "0")},
                {"quantity", If(row.Cells(3).Value?.ToString(), "0")},
                {"total", If(row.Cells(4).Value?.ToString(), "0")}
            }
                items.Add(item)
            End If
        Next

        baseCommand = New BaseDelivery(data) With {
            .Items = items
        }

        invoker = New AddCommand(baseCommand)
        invoker?.Execute()
        _subject.NotifyObserver()
        Me.Close()
    End Sub
End Class
