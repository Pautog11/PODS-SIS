Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Pods_Sales_InventorySystem.pods

Public Class DeliveryCartDialog
    Private ReadOnly _tableAdapter As New podsTableAdapters.viewtblsuppliersTableAdapter
    Private ReadOnly _subject As IObservablePanel
    Public _itemSource As DataTable
    Private ReadOnly _data As Dictionary(Of String, String)

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

        DeliveryDataGridView.Columns.Item("ID").Visible = False

        If _data IsNot Nothing Then
            AddProductButton.Visible = False
            SaveButton.Visible = False
            SupplierNameComboBox.Enabled = False
            DateTimePicker1.Enabled = False
            TotalPrice.Text = _data("total")
            DateTimePicker1.Value = _data("date")
            TransactionDeliveryTextBox.Enabled = False
            TransactionDeliveryTextBox.Text = _data("delivery_number")

            'Populate items 
            DeliveryDataGridView.Rows.Clear()
            Dim DeliveryItems As DataTable = BaseDelivery.SelectAllDeliveryItems(_data("id"))
            For Each row As DataRow In DeliveryItems.Rows
                Dim rowData As New List(Of Object)()
                For Each column As DataColumn In DeliveryItems.Columns
                    If column.ColumnName = "mfd" OrElse column.ColumnName = "exd" Then
                        Dim dateValue As Date = Convert.ToDateTime(row(column))
                        rowData.Add(dateValue.ToString("yyyy-MM-dd"))
                    Else
                        rowData.Add(row(column))
                    End If
                Next
                DeliveryDataGridView.Rows.Add(rowData.ToArray())
            Next
        Else
            'PulloutButton.Visible = False
            DateTimePicker1.MaxDate = DateTime.Now
        End If
    End Sub

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
        'Dim result As New Object
        Dim result As New List(Of Object)()
        result.add(InputValidation.ValidateInputString(TransactionDeliveryTextBox, DataInput.STRING_STRING))

        If DeliveryDataGridView.Rows.Count > 0 AndAlso Not result.Any(Function(item As Object()) Not item(0)) Then
            Dim items As New List(Of Dictionary(Of String, String))()
            Dim baseCommand As ICommandPanel ' = Nothing
            Dim invoker As ICommandInvoker
            Dim data As New Dictionary(Of String, String) From {
            {"id", If(_data?.Item("id"), String.Empty)},
            {"delivery_number", TransactionDeliveryTextBox.Text},
            {"supplier_id", If(DirectCast(SupplierNameComboBox.SelectedItem, DataRowView)("id"), String.Empty)},
            {"total", TotalPrice.Text},
            {"date", DateTimePicker1.Value.ToString("MMM dd yyyy")} 'DateTimePicker1.Value.ToString("yyyy/MM/dd")}
            }

            For Each row As DataGridViewRow In DeliveryDataGridView.Rows
                ' Check if the row is not the new row added automatically at the end of DataGridView
                If Not row.IsNewRow Then
                    Dim item As New Dictionary(Of String, String) From {
                        {"product_id", row.Cells(0).Value},
                        {"mfd", row.Cells(2).Value?.ToString()},
                        {"exd", row.Cells(3).Value?.ToString()},
                        {"price", If(row.Cells(4).Value?.ToString(), "0")},
                        {"quantity", If(row.Cells(5).Value?.ToString(), "0")},
                        {"total", If(row.Cells(6).Value?.ToString(), "0")}
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
        Else
            MessageBox.Show("Select product or provide valid inputs!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DeliveryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DeliveryDataGridView.CellClick
        If _data IsNot Nothing Then
            MsgBox("clicked!")
        End If
    End Sub
End Class
