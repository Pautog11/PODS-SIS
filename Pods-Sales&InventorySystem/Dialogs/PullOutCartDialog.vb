Imports System.Windows.Forms

Public Class PullOutCartDialog
    Private _subject As IObservablePanel
    Public _itemSource As DataTable

    Public Sub New(Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
    End Sub

    Private Sub PullOutCartDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = BaseSupplier.Fetchsupplier_allow_refund()
        SupplierNameComboBox.DataSource = dt
        SupplierNameComboBox.DisplayMember = "name"
        SupplierNameComboBox.ValueMember = "id"

        If dt.Rows.Count > 0 Then
            SupplierNameComboBox.SelectedIndex = -1
        End If
    End Sub

    Private Sub AddProduct_Click(sender As Object, e As EventArgs) Handles AddProduct.Click
        Try
            If SupplierNameComboBox.Text = "" Then
                MessageBox.Show("Please select a supplier first!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SupplierNameComboBox.BorderColor = Color.Red
                Exit Sub
            End If

            If VendorComboBox.Text = "" Then
                MessageBox.Show("Please select a vendor first!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                VendorComboBox.BorderColor = Color.Red
                Exit Sub
            End If

            Dim data As New Dictionary(Of String, String) From {
                {"id", SupplierNameComboBox.SelectedItem("ID")}
            }
            Dim dialog As New PullOutProductDialog(data:=data, parent:=Me)
            dialog.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SupplierNameComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SupplierNameComboBox.SelectionChangeCommitted
        Try
            SupplierNameComboBox.BorderColor = Color.Gray

            Dim dt As DataTable = BaseVendor.GetVendorBySupplierId(SupplierNameComboBox.SelectedItem("ID"))
            VendorComboBox.DataSource = dt.DefaultView
            VendorComboBox.DisplayMember = "name"
            VendorComboBox.SelectedItem = "id"
            If dt.Rows.Count > 0 Then
                VendorComboBox.SelectedIndex = -1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeliveryPulloutDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DeliveryPulloutDataGridView.CellClick
        Try
            If DeliveryPulloutDataGridView.Rows.Count > 0 Then
                Dim row As DataGridViewRow = DeliveryPulloutDataGridView.SelectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                    {"id", If(row.Cells(0).Value?.ToString(), "0")},
                    {"tran_id", If(row.Cells(1).Value?.ToString(), "")},
                    {"pid", If(row.Cells(2).Value?.ToString(), "")},
                    {"delivery_reference", If(row.Cells(3).Value?.ToString(), "")},
                    {"name", If(row.Cells(4).Value?.ToString(), "")},
                    {"atp_number", If(row.Cells(5).Value?.ToString(), "0")},
                    {"expiry_date", If(row.Cells(6).Value?.ToString(), "")},
                    {"batch_number", If(row.Cells(7).Value?.ToString(), "")},
                    {"rrc", If(row.Cells(8).Value?.ToString(), "")},
                    {"cost", If(row.Cells(9).Value?.ToString(), "0")},
                    {"quantity", If(row.Cells(10).Value?.ToString(), "0")},
                    {"total", If(row.Cells(11).Value?.ToString(), "0")},
                    {"from", If(row.Cells(12).Value?.ToString(), "0")},
                    {"target", If(row.Cells(13).Value?.ToString(), "0")}
                }
                Dim dialog As New PullOutProductDialog(data2:=data, parent:=Me)
                dialog.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdateVisualData()
        Try
            DeliveryPulloutDataGridView.DataSource = _itemSource?.DefaultView
            Dim total As Decimal = 0
            For i = 0 To DeliveryPulloutDataGridView?.Rows.Count - 1
                total += DeliveryPulloutDataGridView.Rows(i).Cells("TOTAL").Value
            Next
            TotalPrice.Text = total
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Dim controls As Object() = {SupplierNameComboBox, VendorComboBox, ReferennceTextBox}

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

            If DeliveryPulloutDataGridView.Rows.Count > 0 AndAlso Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim items As New List(Of Dictionary(Of String, String))()
                Dim baseCommand As ICommandPanel
                Dim invoker As ICommandInvoker
                Dim data As New Dictionary(Of String, String) From {
                    {"reference_number", ReferennceTextBox.Text},
                    {"supplier_id", If(DirectCast(SupplierNameComboBox.SelectedItem, DataRowView)("id"), String.Empty)},
                    {"vendor_id", If(DirectCast(VendorComboBox.SelectedItem, DataRowView)("id"), String.Empty)},
                    {"total", If(String.IsNullOrEmpty(TotalPrice.Text), 0, TotalPrice.Text)},
                    {"date", DatePicker.Value.ToString("MMM dd yyyy")}
                }

                For Each row As DataGridViewRow In DeliveryPulloutDataGridView.Rows
                    Dim item As New Dictionary(Of String, String) From {
                        {"id", row.Cells(0).Value},
                        {"tran_id", If(row.Cells(1).Value?.ToString(), "0")},
                        {"product_id", If(row.Cells(2).Value?.ToString(), "0")},
                        {"atp", If(row.Cells(5).Value?.ToString(), "0")},
                        {"expiration_date", If(row.Cells(6).Value?.ToString(), "0")},
                        {"batch_number", If(row.Cells(7).Value?.ToString(), "0")},
                        {"rrc_id", BasePullouts.SupplierIdRrc(If(row.Cells(8).Value?.ToString(), ""))},
                        {"price", If(row.Cells(9).Value?.ToString(), "0")},
                        {"quantity", If(row.Cells(10).Value?.ToString(), "0")},
                        {"from", If(row.Cells(12).Value?.ToString(), "")}
                    }
                    items.Add(item)
                Next

                baseCommand = New BasePullouts(data) With {.Items = items}

                invoker = New AddCommand(baseCommand)
                invoker?.Execute()
                _subject.NotifyObserver()
                Me.Close()
            Else
                MessageBox.Show("Please select product first.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
