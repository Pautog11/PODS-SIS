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
    Public sample As New DataTable
    Public pullout_total As Decimal = Nothing
    Dim subtotal As Decimal = 0
    Dim profit As Decimal = 0

    Public Sub New(Optional subject As IObservablePanel = Nothing,
                   Optional data As Dictionary(Of String, String) = Nothing)
        InitializeComponent()
        _data = data
        _subject = subject
    End Sub

    Private Sub DeliveryCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sample.Columns.Clear()
            sample.Columns.Add("id", GetType(String))

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
                Guna2DateTimePicker1.Enabled = False
                AddDeducttionButton.Visible = False
                VendorComboBox.Enabled = False
                TransactionDeliveryTextBox.Enabled = False
                VatTextBox.Enabled = False

                SupplierNameComboBox.Text = _data.Item("supplier_id")
                TotalPrice.Text = _data.Item("total")
                pulloutTotal.Text = _data.Item("deduction")
                Guna2DateTimePicker1.Value = _data.Item("date")
                TransactionDeliveryTextBox.Text = _data.Item("delivery_number")
                VatTextBox.Text = _data.Item("vat")

                Dim vendor As DataTable = BaseDelivery.FetchVendor(BaseDelivery.FetchSupplierId(_data.Item("supplier_id")), _data.Item("vendor_id"))
                VendorComboBox.DataSource = vendor.DefaultView
                VendorComboBox.DisplayMember = "name"
                VendorComboBox.SelectedItem = "id"

                Dim gtotal As Decimal = 0
                gtotal = Val(_data.Item("total")) - Val(_data.Item("deduction"))
                Grandtotal.Text = gtotal.ToString("F2")

                'Dim dt As DataTable = BaseVendor.GetVendorBySupplierId(SupplierNameComboBox.SelectedItem("id"))
                'VendorComboBox.DataSource = dt.DefaultView
                'VendorComboBox.DisplayMember = "name"
                'VendorComboBox.SelectedItem = "id"

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

                'ViewdeductionButton.Enabled = False
            Else
                EditButton.Visible = False
                ViewdeductionButton.Visible = False
                Guna2DateTimePicker1.MaxDate = DateTime.Now.Date
                Guna2DateTimePicker1.Value = DateTime.Now.Date
                AddDeducttionButton.Enabled = False
            End If

            AddItemButton.Visible = False
            DeliveryDataGridView.Columns.Item("EDIT").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub UpdateVisualData()
        Try
            DeliveryDataGridView.DataSource = _itemSource?.DefaultView
            Dim subtotal As Decimal = 0D
            Dim gtotal As Decimal = 0D
            Dim selling As Decimal = 0D
            Dim cost As Decimal = 0D
            If DeliveryDataGridView.Rows.Count > 0 Then
                For i As Integer = 0 To DeliveryDataGridView.Rows.Count - 1
                    Dim cellValue = DeliveryDataGridView.Rows(i).Cells("TOTAL").Value

                    If cellValue IsNot Nothing AndAlso IsNumeric(cellValue) Then
                        subtotal += Convert.ToDecimal(cellValue)
                    End If
                Next

                For s As Integer = 0 To DeliveryDataGridView.Rows.Count - 1
                    Dim priceCell = DeliveryDataGridView.Rows(s).Cells("price").Value
                    Dim quantityCell = DeliveryDataGridView.Rows(s).Cells("quantity").Value

                    If priceCell IsNot Nothing AndAlso quantityCell IsNot Nothing AndAlso
                       IsNumeric(priceCell) AndAlso IsNumeric(quantityCell) Then

                        Dim price As Decimal = Convert.ToDecimal(priceCell)
                        Dim quantity As Decimal = Convert.ToDecimal(quantityCell)

                        selling += price * quantity
                    End If
                Next

                For c As Integer = 0 To DeliveryDataGridView.Rows.Count - 1
                    Dim costpriceCell = DeliveryDataGridView.Rows(c).Cells("cost_price").Value
                    Dim costquantityCell = DeliveryDataGridView.Rows(c).Cells("quantity").Value

                    If costpriceCell IsNot Nothing AndAlso costquantityCell IsNot Nothing AndAlso
                       IsNumeric(costpriceCell) AndAlso IsNumeric(costquantityCell) Then

                        Dim price As Decimal = Convert.ToDecimal(costpriceCell)
                        Dim quantity As Decimal = Convert.ToDecimal(costquantityCell)

                        cost += price * quantity
                    End If
                Next

            End If

            'Label1.Text = selling.ToString("F2")
            'Label2.Text = cost.ToString("F2")
            Label3.Text = Val(selling.ToString("F2")) - Val(cost.ToString("F2"))

            TotalPrice.Text = subtotal.ToString("F2")
            gtotal = Val(subtotal.ToString("F2")) - Val(pulloutTotal.Text)
            Grandtotal.Text = gtotal.ToString("F2")

            AddDeducttionButton.Enabled = True
            If Val(subtotal) = 0 Then
                AddDeducttionButton.Enabled = False
                sample.Rows.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Totalpullout()
        Try
            Dim grndtotal As Decimal = 0
            pulloutTotal.Text = pullout_total.ToString("F2")
            grndtotal = Val(TotalPrice.Text) - Val(pulloutTotal.Text)
            Grandtotal.Text = grndtotal.ToString("F2")
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
            Dim controls As Object() = {SupplierNameComboBox, VendorComboBox, TransactionDeliveryTextBox, VatTextBox}

            Dim types As DataInput() = {DataInput.STRING_STRING, DataInput.STRING_STRING, DataInput.STRING_INTEGER, DataInput.STRING_INTEGER}

            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                If controls(i) Is VatTextBox AndAlso String.IsNullOrEmpty(VatTextBox.Text) Then
                    Continue For ' Skip validation for BarcodeTextBox if it's empty
                End If

                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                Dim validationResult = TryCast(result(i), Object())
                If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                    If Not validationResult(0) = True Then
                        Exit Sub
                    End If
                End If
            Next

            If Val(VatTextBox.Text) >= Val(Label3.Text) Then
                MessageBox.Show("No profit can be made from this transaction.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If DeliveryDataGridView.Rows.Count > 0 AndAlso Not result.Any(Function(item As Object()) Not item(0)) Then
                If Val(TotalPrice.Text) < Val(pulloutTotal.Text) Then
                    MessageBox.Show("The subtotal must exceed the total pulled-out amount.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Please select product first.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If DeliveryDataGridView.Rows.Count > 0 AndAlso Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim items As New List(Of Dictionary(Of String, String))()
                Dim baseCommand As ICommandPanel
                Dim invoker As ICommandInvoker
                Dim data As New Dictionary(Of String, String) From {
                    {"id", If(_data?.Item("id"), String.Empty)},
                    {"delivery_number", result(2)(1)},
                    {"supplier_id", If(DirectCast(SupplierNameComboBox.SelectedItem, DataRowView)("id"), String.Empty)},
                    {"vendor_id", If(DirectCast(VendorComboBox.SelectedItem, DataRowView)("id"), String.Empty)},
                    {"total", If(String.IsNullOrEmpty(TotalPrice.Text) OrElse TotalPrice.Text = "", 0, TotalPrice.Text)},
                    {"deduction", If(String.IsNullOrEmpty(pulloutTotal.Text) OrElse pulloutTotal.Text = "", 0, pulloutTotal.Text)},
                    {"date", Guna2DateTimePicker1.Value.ToString("MMM dd yyyy")},
                    {"vat", If(String.IsNullOrEmpty(VatTextBox.Text) OrElse VatTextBox.Text = "", 0, VatTextBox.Text)}
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


                Dim allids As New List(Of Dictionary(Of String, String))()
                If sample.Rows.Count > 0 Then
                    For Each i In sample.Rows
                        Dim ids As New Dictionary(Of String, String) From {
                            {"id", i("id").ToString()}
                        }
                        allids.Add(ids)
                    Next
                End If

                baseCommand = New BaseDelivery(data) With {.Items = items, .Ids = allids}

                If BaseDelivery.Exists(result(2)(1)) = 0 Then
                    invoker = New AddCommand(baseCommand)
                    invoker?.Execute()
                    _subject.NotifyObserver()
                    Me.Close()
                Else
                    MessageBox.Show("Transaction reference is already exist!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Please select product first.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
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
                    {"target2", If(row.Cells(9).Value?.ToString(), "0")},
                    {"transaction_id", _data.Item("id")}
                }
                Dim dialog As New EditDeliveryDialog(parent:=Me, data:=data)
                dialog.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Try
            If button = 1 Then
                Dim controls As Object() = {SupplierNameComboBox, VendorComboBox, TransactionDeliveryTextBox, VatTextBox}
                Dim types As DataInput() = {DataInput.STRING_NAME, DataInput.STRING_NAME, DataInput.STRING_INTEGER, DataInput.STRING_INTEGER}

                Dim result As New List(Of Object())
                For i = 0 To controls.Count - 1
                    If controls(i) Is VatTextBox AndAlso Not VatTextBox.Enabled OrElse String.IsNullOrEmpty(VatTextBox.Text) Then
                        'If TypeOf controls(i) Is VatTextBox AndAlso String.IsNullOrEmpty(CType(controls(i), VatTextBox).Text) AndAlso CType(controls(i), VatTextBox).Enabled Then
                        Continue For ' Skip validation for BarcodeTextBox if it's empty
                    Else
                        result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                    End If

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
                        {"delivery_number", result(2)(1)},
                        {"supplier_id", If(DirectCast(SupplierNameComboBox.SelectedItem, DataRowView)("id"), String.Empty)},
                        {"vendor_id", If(DirectCast(VendorComboBox.SelectedItem, DataRowView)("id"), String.Empty)},
                        {"total", If(String.IsNullOrEmpty(TotalPrice.Text) OrElse TotalPrice.Text = "", 0, TotalPrice.Text)},
                        {"date", Guna2DateTimePicker1.Value.ToString("MMM dd yyyy")},
                        {"vat", If(String.IsNullOrEmpty(VatTextBox.Text) OrElse VatTextBox.Text = "", 0, VatTextBox.Text)}
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
                            {"expiration_date", If(row.Cells(2).Value?.ToString(), "0")},
                            {"status", If(row.Cells(9).Value?.ToString(), "")}
                        }
                        items.Add(item)
                    Next

                    baseCommand = New BaseDelivery(data) With {.Items = items}

                    If BaseDelivery.Exists(result(2)(1)) = 1 Then
                        If BaseDelivery.IdExist(_data.Item("id"), result(2)(1)) = 1 Then
                            invoker = New UpdateCommand(baseCommand)
                            invoker?.Execute()
                            _subject.NotifyObserver()
                            Me.Close()
                        Else
                            MessageBox.Show("Transaction reference is already exist!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            TransactionDeliveryTextBox.Text = ""
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
                Guna2DateTimePicker1.Enabled = True
                SupplierNameComboBox.Enabled = True
                TransactionDeliveryTextBox.Enabled = True
                VendorComboBox.Enabled = True
                button = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
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

    Private Sub AddDeducttionButton_Click(sender As Object, e As EventArgs) Handles AddDeducttionButton.Click
        Try
            Dim controls As Object() = {SupplierNameComboBox, VendorComboBox}
            Dim types As DataInput() = {DataInput.STRING_NAME, DataInput.STRING_NAME}

            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                Dim validationResult = TryCast(result(i), Object())
                If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                    If Not validationResult(0) = True Then
                        Exit Sub
                    End If
                End If
            Next

            Dim dt As New DataTable
            dt.Columns.Add("id", GetType(String))
            If sample.Rows.Count > 0 Then
                For Each check As DataRow In sample.Rows
                    Dim i As String = check("id").ToString()
                    dt.Rows.Add(i)
                Next
            End If

            Dim data As New Dictionary(Of String, String) From {
                {"supplier_id", If(SupplierNameComboBox.SelectedItem("id"), String.Empty)}
            }

            Using dialog As New DeliveryPreviousPullout(data:=data, parent:=Me, checked:=dt)
                dialog.ShowDialog()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Try
            If sample.Rows.Count > 0 Then
                For Each row As DataRow In sample.Rows
                    MsgBox(row("id").ToString())
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ViewdeductionButton_Click(sender As Object, e As EventArgs) Handles ViewdeductionButton.Click
        Try
            Dim data As New Dictionary(Of String, String) From {
                {"id", If(_data.Item("id"), String.Empty)}
            }

            Dim dialog As New DeliveryPreviousPullout(data2:=data)
            dialog.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub VatTextBox_TextChanged(sender As Object, e As EventArgs) Handles VatTextBox.TextChanged
    '    'Try
    '    '    Dim value As Decimal
    '    '    Dim gtotal As Decimal
    '    '    Dim bgtotal As Decimal

    '    '    If Not Decimal.TryParse(VatTextBox.Text, value) Then
    '    '        value = 0D
    '    '    End If

    '    '    If Decimal.TryParse(VatTextBox.Text, value) Then
    '    '        bgtotal = Val(Grandtotal.Text)
    '    '        gtotal = Val(Grandtotal.Text) + Val(value)
    '    '        Grandtotal.Text = gtotal.ToString("F2")
    '    '    Else
    '    '        value = 0D
    '    '        Grandtotal.Text = bgtotal.ToString("F2")
    '    '    End If

    '    'Catch ex As Exception

    '    'End Try
    'End Sub
End Class

