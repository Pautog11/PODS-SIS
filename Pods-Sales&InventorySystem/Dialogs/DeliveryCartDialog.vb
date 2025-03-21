﻿Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Pods_Sales_InventorySystem.pods

Public Class DeliveryCartDialog
    Private ReadOnly _tableAdapter As New podsTableAdapters.viewtblsuppliersTableAdapter
    Private ReadOnly _subject As IObservablePanel
    Public _itemSource As DataTable
    Private ReadOnly _data As Dictionary(Of String, String)
    Dim button As Integer = 0
    Dim panel As EditDeliveryDialog = Nothing

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
            SupplierNameComboBox.DisplayMember = "COMPANY"
            SupplierNameComboBox.ValueMember = "ID"

            If supplier_data.Rows.Count > 0 Then
                SupplierNameComboBox.SelectedIndex = -1
            End If

            If My.Settings.roleId = 2 OrElse My.Settings.roleId = 3 Then
                EditButton.Visible = False
            End If

            If _data IsNot Nothing Then
                AddProductButton.Visible = False
                SaveButton.Visible = False
                SupplierNameComboBox.Enabled = False
                DatePicker.Enabled = False
                AddDeductionButton.Visible = False
                VendorComboBox.Enabled = False
                TransactionDeliveryTextBox.Enabled = False

                SupplierNameComboBox.Text = _data.Item("supplier_id")
                TotalPrice.Text = _data.Item("total")
                DatePicker.Value = _data.Item("date")
                TransactionDeliveryTextBox.Text = _data.Item("delivery_number")

                Dim dt As DataTable = BaseVendor.GetVendorBySupplierId(SupplierNameComboBox.SelectedItem("id"))
                VendorComboBox.DataSource = dt.DefaultView
                VendorComboBox.DisplayMember = "name"
                VendorComboBox.SelectedItem = "id"

                DeliveryDataGridView.Rows.Clear()
                Dim DeliveryItems As DataTable = BaseDelivery.SelectAllDeliveryItems(_data.Item("id"))
                For Each row As DataRow In DeliveryItems.Rows
                    Dim data As New List(Of Object)()
                    For Each column As DataColumn In DeliveryItems.Columns
                        If row(column) IsNot DBNull.Value AndAlso TypeOf row(column) Is DateTime Then
                            data.Add(CType(row(column), DateTime).ToString("yyyy-MM-dd"))
                        Else
                            data.Add(row(column))
                        End If
                    Next
                    DeliveryDataGridView.Rows.Add(data.ToArray())
                Next

            Else
                EditButton.Visible = False
                DatePicker.MaxDate = DateTime.Now
            End If
            AddItemButton.Visible = False
            DeliveryDataGridView.Columns.Item("EDIT").Visible = False
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
        Try
            Dim dialog As New DeliveryProductDialog(parent:=Me)
            dialog.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Dim controls As Object() = {SupplierNameComboBox, VendorComboBox, TransactionDeliveryTextBox}

            Dim types As DataInput() = {DataInput.STRING_STRING, DataInput.STRING_STRING, DataInput.STRING_STRING}

            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                Dim validationResult = TryCast(result(i), Object())
                If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                    If Not validationResult(0) = True Then
                        Exit Sub
                    End If
                Else
                    Throw New Exception
                End If
            Next

            If DeliveryDataGridView.Rows.Count > 0 AndAlso Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim items As New List(Of Dictionary(Of String, String))()
                Dim baseCommand As ICommandPanel
                Dim invoker As ICommandInvoker
                Dim data As New Dictionary(Of String, String) From {
                    {"id", If(_data?.Item("id"), String.Empty)},
                    {"delivery_number", result(1)(1)},
                    {"supplier_id", If(DirectCast(SupplierNameComboBox.SelectedItem, DataRowView)("id"), String.Empty)},
                    {"vendor_id", If(DirectCast(VendorComboBox.SelectedItem, DataRowView)("id"), String.Empty)},
                    {"total", If(String.IsNullOrEmpty(TotalPrice.Text) OrElse TotalPrice.Text = "", 0, TotalPrice.Text)},
                    {"date", DatePicker.Value.ToString("MMM dd yyyy")}
                }

                For Each row As DataGridViewRow In DeliveryDataGridView.Rows
                    Dim item As New Dictionary(Of String, String) From {
                        {"product_id", row.Cells(0).Value},
                        {"price", If(row.Cells(4).Value?.ToString(), "0")},
                        {"cost_price", If(row.Cells(5).Value?.ToString(), "0")},
                        {"quantity", If(row.Cells(6).Value?.ToString(), "0")},
                        {"batch_number", If(row.Cells(3).Value?.ToString(), "0")},
                        {"expiration_date", If(row.Cells(2).Value?.ToString(), "0")}
                    }
                    items.Add(item)
                Next

                baseCommand = New BaseDelivery(data) With {.Items = items}

                If BaseDelivery.Exists(result(2)(1)) = 0 Then
                    invoker = New AddCommand(baseCommand)
                    invoker?.Execute()
                    _subject.NotifyObserver()
                    Me.Close()
                Else
                    MessageBox.Show("Transaction reference is already exist!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Please select product first.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeliveryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DeliveryDataGridView.CellClick
        Try
            If DeliveryDataGridView.Rows.Count > 0 Then
                If _data Is Nothing Then
                    Dim row As DataGridViewRow = DeliveryDataGridView.SelectedRows(0)
                    Dim data As New Dictionary(Of String, String) From {
                        {"id", If(row.Cells(0).Value?.ToString(), "0")},
                        {"name", If(row.Cells(1).Value?.ToString(), "")},
                        {"date", If(row.Cells(2).Value?.ToString(), "")},
                        {"batch_number", If(row.Cells(3).Value?.ToString(), "")},
                        {"selling_price", If(row.Cells(4).Value?.ToString(), "0")},
                        {"cost_price", If(row.Cells(5).Value?.ToString(), "0")},
                        {"quantity", If(row.Cells(6).Value?.ToString(), "0")},
                        {"target", If(row.Cells(8).Value?.ToString(), "0")}
                    }
                    Dim dialog As New DeliveryProductDialog(data:=data, parent:=Me)
                    dialog.ShowDialog()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeliveryDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DeliveryDataGridView.CellContentClick
        Try
            Dim fuck As String = DeliveryDataGridView.Columns(e.ColumnIndex).Name
            If fuck = "EDIT" Then
                Dim row As DataGridViewRow = DeliveryDataGridView.SelectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                    {"id", If(row.Cells(0).Value?.ToString(), "0")},
                    {"name", If(row.Cells(1).Value?.ToString(), "")},
                    {"date", If(row.Cells(2).Value?.ToString(), "")},
                    {"batch_number", If(row.Cells(3).Value?.ToString(), "")},
                    {"selling_price", If(row.Cells(4).Value?.ToString(), "0")},
                    {"cost_price", If(row.Cells(5).Value?.ToString(), "0")},
                    {"quantity", If(row.Cells(6).Value?.ToString(), "0")},
                    {"target", If(row.Cells(8).Value?.ToString(), "0")},
                    {"transaction_id", _data.Item("id")}
                }
                Dim dialog As New EditDeliveryDialog(parent:=Me, data:=data)
                dialog.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Try
            If button = 1 Then
                Dim controls As Object() = {SupplierNameComboBox, TransactionDeliveryTextBox}
                Dim types As DataInput() = {DataInput.STRING_NAME, DataInput.STRING_STRING}

                Dim result As New List(Of Object())
                For i = 0 To controls.Count - 1
                    result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                    Dim validationResult = TryCast(result(i), Object())
                    If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                        If Not validationResult(0) = True Then
                            Exit Sub
                        End If
                    Else
                        Throw New Exception
                    End If
                Next

                If DeliveryDataGridView.Rows.Count > 0 AndAlso Not result.Any(Function(item As Object()) Not item(0)) Then
                    Dim items As New List(Of Dictionary(Of String, String))()
                    Dim baseCommand As ICommandPanel
                    Dim invoker As ICommandInvoker
                    Dim data As New Dictionary(Of String, String) From {
                        {"id", If(_data.Item("id"), String.Empty)},
                        {"delivery_number", result(1)(1)},
                        {"supplier_id", If(DirectCast(SupplierNameComboBox.SelectedItem, DataRowView)("id"), String.Empty)},
                        {"vendor_id", If(DirectCast(VendorComboBox.SelectedItem, DataRowView)("id"), String.Empty)},
                        {"total", If(String.IsNullOrEmpty(TotalPrice.Text) OrElse TotalPrice.Text = "", 0, TotalPrice.Text)},
                        {"date", DatePicker.Value.ToString("MMM dd yyyy")}
                    }

                    For Each row As DataGridViewRow In DeliveryDataGridView.Rows
                        Dim item As New Dictionary(Of String, String) From {
                            {"id", row.Cells(0).Value},
                            {"delivery_id", _data.Item("id")},
                            {"product_id", If(row.Cells(8).Value?.ToString(), "0")},
                            {"price", If(row.Cells(4).Value?.ToString(), "0")},
                            {"cost_price", If(row.Cells(5).Value?.ToString(), "0")},
                            {"quantity", If(row.Cells(6).Value?.ToString(), "0")},
                            {"batch_number", If(row.Cells(3).Value?.ToString(), "0")},
                            {"expiration_date", If(row.Cells(2).Value?.ToString(), "0")}
                        }
                        items.Add(item)
                    Next

                    baseCommand = New BaseDelivery(data) With {.Items = items}

                    If BaseDelivery.Exists(result(1)(1)) = 1 Then
                        If BaseDelivery.IdExist(_data.Item("id"), result(1)(1)) = 1 Then
                            invoker = New UpdateCommand(baseCommand)
                            invoker?.Execute()
                            _subject.NotifyObserver()
                            Me.Close()
                        Else
                            MessageBox.Show("Transaction reference is already exist!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        invoker = New UpdateCommand(baseCommand)
                        invoker?.Execute()
                        _subject.NotifyObserver()
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("Please select product first.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                EditButton.Text = "Save"
                AddItemButton.Visible = True
                DeliveryDataGridView.Columns.Item("EDIT").Visible = True
                DatePicker.Enabled = True
                SupplierNameComboBox.Enabled = True
                TransactionDeliveryTextBox.Enabled = True
                VendorComboBox.Enabled = True
                button = 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
        Try
            Dim dialog As New EditDeliveryDialog(parent:=Me, data2:=_data)
            panel = dialog
            dialog.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdateDataGridview()
        Try
            DeliveryDataGridView.Rows.Clear()
            Dim DeliveryItems As DataTable = BaseDelivery.SelectAllDeliveryItems(_data.Item("id"))
            For Each row As DataRow In DeliveryItems.Rows
                Dim data As New List(Of Object)()
                For Each column As DataColumn In DeliveryItems.Columns
                    If row(column) IsNot DBNull.Value AndAlso TypeOf row(column) Is DateTime Then
                        data.Add(CType(row(column), DateTime).ToString("yyyy-MM-dd"))
                    Else
                        data.Add(row(column))
                    End If
                Next
                DeliveryDataGridView.Rows.Add(data.ToArray())
            Next
            panel.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SupplierNameComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SupplierNameComboBox.SelectionChangeCommitted
        Try
            Dim dt As DataTable = BaseVendor.GetVendorBySupplierId(SupplierNameComboBox.SelectedItem("id"))
            VendorComboBox.DataSource = dt.DefaultView
            VendorComboBox.DisplayMember = "name"
            VendorComboBox.SelectedItem = "id"
            If dt.Rows.Count > 0 Then
                VendorComboBox.SelectedIndex = -1
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class