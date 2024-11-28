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
        Try
            Dim supplier_data As viewtblsuppliersDataTable = _tableAdapter.GetData()
            SupplierNameComboBox.DataSource = supplier_data
            SupplierNameComboBox.DisplayMember = "NAME"
            SupplierNameComboBox.ValueMember = "ID"
            If supplier_data.Rows.Count > 0 Then
                SupplierNameComboBox.SelectedIndex = -1
            End If

            If _data IsNot Nothing Then
                AddProductButton.Visible = False
                SaveButton.Visible = False
                SupplierNameComboBox.Enabled = False
                DateTimePicker1.Enabled = False

                SupplierNameComboBox.Text = _data.Item("supplier_id")
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
                        If column.ColumnName = "exd" Then
                            If row(column) IsNot DBNull.Value Then
                                Dim dateValue As Date = Convert.ToDateTime(row(column))
                                rowData.Add(dateValue.ToString("yyyy-MM-dd"))
                            Else
                                rowData.Add("N/A")
                            End If
                        Else
                            rowData.Add(row(column))
                        End If
                    Next
                    DeliveryDataGridView.Rows.Add(rowData.ToArray())
                Next
                'Clear any existing rows first to prevent duplication
                'MsgBox(DeliveryItems.Rows.Count)
            Else
                PulloutButton.Visible = False
                DateTimePicker1.MaxDate = DateTime.Now
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdateVisualData()
        Try
            DeliveryDataGridView.DataSource = _itemSource?.DefaultView
            Dim total As Decimal = 0
            For i = 0 To DeliveryDataGridView?.Rows.Count - 1
                total += DeliveryDataGridView.Rows(i).Cells("TOTAL").Value
            Next
            TotalPrice.Text = total
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Dim dialog As New DeliveryProductDialog(parent:=Me)
        dialog.ShowDialog()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Dim controls As Object() = {
                 TransactionDeliveryTextBox, SupplierNameComboBox
             }

            Dim types As DataInput() = {
                DataInput.STRING_STRING, DataInput.STRING_NAME
            }
            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
            Next


            If DeliveryDataGridView.Rows.Count > 0 AndAlso Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim items As New List(Of Dictionary(Of String, String))()
                Dim baseCommand As ICommandPanel ' = Nothing
                Dim invoker As ICommandInvoker
                Dim data As New Dictionary(Of String, String) From {
                    {"id", If(_data?.Item("id"), String.Empty)},
                    {"delivery_number", result(0)(1)},
                    {"supplier_id", If(DirectCast(SupplierNameComboBox.SelectedItem, DataRowView)("id"), String.Empty)},
                    {"total", TotalPrice.Text},
                    {"date", DateTimePicker1.Value.ToString("MMM dd yyyy")}
                }

                For Each row As DataGridViewRow In DeliveryDataGridView.Rows
                    Dim exdValue As String = row.Cells(2).Value?.ToString()
                    If exdValue = "N/A" Then
                        exdValue = Nothing
                    End If

                    Dim item As New Dictionary(Of String, String) From {
                        {"product_id", row.Cells(0).Value},
                        {"exd", exdValue},
                        {"price", If(row.Cells(3).Value?.ToString(), "0")},
                        {"quantity", If(row.Cells(5).Value?.ToString(), "0")},
                        {"total", If(row.Cells(6).Value?.ToString(), "0")},
                        {"cost_price", If(row.Cells(4).Value?.ToString(), "0")}
                    }
                    items.Add(item)
                Next

                baseCommand = New BaseDelivery(data) With {
                    .Items = items
                }
                If BaseDelivery.Exists(result(0)(1)) = 0 Then
                    invoker = New AddCommand(baseCommand)
                    invoker?.Execute()
                    _subject.NotifyObserver()
                    Me.Close()
                Else
                    MessageBox.Show("Transaction reference is already exist!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Select product or provide valid inputs!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub DeliveryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DeliveryDataGridView.CellClick
    '    If _data IsNot Nothing Then
    '        MsgBox("clicked!")
    '    End If
    ' End Sub

    'Private Sub SupplierNameComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SupplierNameComboBox.SelectionChangeCommitted
    '    MsgBox(SupplierNameComboBox.SelectedItem("ID"))
    'End Sub

    Private Sub PulloutButton_Click(sender As Object, e As EventArgs) Handles PulloutButton.Click
        Dim dialog As New DeliveryPulloutCart(data:=_data, subject:=_subject, parent:=Me)
        dialog.ShowDialog()
    End Sub

    Private Sub DeliveryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DeliveryDataGridView.CellClick
        Try
            If DeliveryDataGridView.Rows.Count > 0 Then
                If _data Is Nothing Then
                    Dim selectedRows As DataGridViewSelectedRowCollection = DeliveryDataGridView.SelectedRows
                    Dim row As DataGridViewRow = selectedRows(0)
                    Dim data As New Dictionary(Of String, String) From {
                        {"id", row.Cells(0).Value.ToString()},
                        {"name", row.Cells(1).Value.ToString()},
                        {"date", row.Cells(2).Value.ToString()},
                        {"sellingprice", row.Cells(3).Value.ToString()},
                        {"costprice", row.Cells(4).Value.ToString()}
                    }
                    Dim dialog As New DeliveryProductDialog(data:=data, parent:=Me)
                    dialog.ShowDialog()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
