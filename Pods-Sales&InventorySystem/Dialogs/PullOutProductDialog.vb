Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class PullOutProductDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _data2 As Dictionary(Of String, String)
    Private ReadOnly _parent As PullOutCartDialog = Nothing
    Dim dt As DataTable = Nothing
    Dim num As Integer = 1
    Dim tran_id As Integer = Nothing
    Dim p_id As Integer = Nothing

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional data2 As Dictionary(Of String, String) = Nothing,
                   Optional parent As PullOutCartDialog = Nothing)
        InitializeComponent()
        _data = data
        _data2 = data2
        _parent = parent
    End Sub

    Private Sub PullOutProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim rrc As DataTable = BasePullouts.Rrc()
            RrcComboBox.DataSource = rrc
            RrcComboBox.DisplayMember = "codedes"
            RrcComboBox.ValueMember = "id"

            If _data IsNot Nothing Then
                'MsgBox(_data.Item("id"))
                dt = BasePullouts.AllProduct(_data.Item("id"))
                If dt.Rows.Count > 0 Then
                    PulloutDataGridView.DataSource = dt.DefaultView

                    If _parent.DeliveryPulloutDataGridView.Rows.Count > 0 Then
                        num = _parent.DeliveryPulloutDataGridView.Rows.Cast(Of DataGridViewRow)().Max(Function(row) Convert.ToInt32(row.Cells("target").Value)) + 1
                    Else
                        num = 1
                    End If

                    PulloutDataGridView.Columns.Item("ID").Visible = False
                    PulloutDataGridView.Columns.Item("TRAN_ID").Visible = False
                    PulloutDataGridView.Columns.Item("PID").Visible = False
                    PulloutDataGridView.Columns.Item("SUPPLIER").Visible = False
                End If
                RemoveButton.Visible = False
            End If

            If _data2 IsNot Nothing Then
                ProductTextBox.Text = _data2.Item("name")
                AtpTextBox.Text = _data2.Item("atp_number")
                ExpiryDateTextBox.Text = _data2.Item("expiry_date")
                BatchNumberTextBox.Text = _data2.Item("batch_number")
                CostTextBox.Text = _data2.Item("cost")
                QuantityTextBox.Text = _data2.Item("quantity")
                tran_id = _data2.Item("tran_id")
                p_id = _data2.Item("pid")



                'MsgBox(_data2.Item("rrc"))


                TableLayoutPanel1.RowStyles(0).Height = 0
                TableLayoutPanel1.RowStyles(1).Height = 0
                Me.Height = 300
                Me.StartPosition = FormStartPosition.Manual
                Me.CenterToScreen()

                PullOutProductSaveButton.Text = "Update"
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub PulloutDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PulloutDataGridView.CellClick
        Try
            If PulloutDataGridView.Rows.Count > 0 AndAlso PulloutDataGridView.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = PulloutDataGridView.SelectedRows(0)
                _data.Item("id") = row.Cells(0).Value?.ToString()
                _data.Item("tran_id") = row.Cells(1).Value?.ToString()
                _data.Item("inventory_location") = row.Cells(2).Value?.ToString()
                _data.Item("delivery_reference") = row.Cells(3).Value?.ToString()
                _data.Item("pid") = row.Cells(4).Value?.ToString()
                ProductTextBox.Text = row.Cells(5).Value?.ToString()
                BatchNumberTextBox.Text = row.Cells(6).Value?.ToString()
                ExpiryDateTextBox.Text = row.Cells(7).Value?.ToString()
                CostTextBox.Text = row.Cells(8).Value?.ToString()
                StocksTextBox.Text = row.Cells(9).Value?.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error selecting product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Try
            If dt IsNot Nothing Then
                Dim dv As DataView = dt.DefaultView
                dv.RowFilter = String.Format("NAME LIKE '%{0}%' OR [BATCH NUMBER] LIKE '%{0}%'", SearchTextBox.Text.Trim().Replace("'", "''"))

                PulloutDataGridView.DataSource = dv
            End If
        Catch ex As Exception
            MessageBox.Show("Error filtering products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PullOutProductSaveButton_Click(sender As Object, e As EventArgs) Handles PullOutProductSaveButton.Click
        Try
            Dim result As New List(Of Object()) From {InputValidation.ValidateInputString(QuantityTextBox, DataInput.STRING_INTEGER)}
            Dim validationResult = TryCast(result(0), Object())
            If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                If Not validationResult(0) = True Then
                    Exit Sub
                End If
            Else
                Throw New Exception
            End If

            Dim is_existing As Boolean = False

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                For Each item As DataGridViewRow In _parent.DeliveryPulloutDataGridView.Rows
                    'MsgBox(tran_id)
                    'MsgBox(p_id)
                    If item.Cells("tran_id").Value.ToString() = tran_id AndAlso item.Cells("pid").Value = p_id Then
                        'item.Cells("id").Value = _data.Item("id")
                        'item.Cells("tran_id").Value = tran_id
                        'item.Cells("pid").Value = p_id
                        item.Cells("delivery_reference").Value = 1111 '_data.Item("delivery_reference")
                        item.Cells("product").Value = ProductTextBox.Text
                        item.Cells("atp_number").Value = AtpTextBox.Text
                        item.Cells("expiry_date").Value = ExpiryDateTextBox.Text
                        item.Cells("batch_number").Value = BatchNumberTextBox.Text
                        item.Cells("rrc").Value = RrcComboBox.SelectedItem("code")
                        item.Cells("cost_price").Value = Decimal.Parse(CostTextBox.Text).ToString("F2")
                        item.Cells("quantity").Value = CInt(QuantityTextBox.Text)
                        item.Cells("total").Value = Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)
                        'item.Cells("from").Value = _data.Item("inventory_location")
                        is_existing = True
                        Exit For
                    End If
                Next

                If Not is_existing Then
                    _parent.DeliveryPulloutDataGridView.Rows.Add({_data.Item("id"),
                                                                 _data.Item("tran_id"),
                                                                 _data.Item("pid"),
                                                                 _data.Item("delivery_reference"),
                                                                 ProductTextBox.Text,
                                                                 AtpTextBox.Text,
                                                                 ExpiryDateTextBox.Text,
                                                                 BatchNumberTextBox.Text,
                                                                 RrcComboBox.SelectedItem("code"),
                                                                 Decimal.Parse(CostTextBox.Text).ToString("F2"),
                                                                 CInt(QuantityTextBox.Text),
                                                                 Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text),
                                                                 _data.Item("inventory_location"),
                                                                 num
                                                                 })
                    num += 1
                End If
                _parent.UpdateVisualData()
                Me.Close()
            Else
                MessageBox.Show("Invalid quantity!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Try
            For Each row As DataGridViewRow In _parent.DeliveryPulloutDataGridView.Rows
                If row.Cells("target").Value.ToString() = _data2.Item("target").ToString() Then
                    _parent.DeliveryPulloutDataGridView.Rows.Remove(row)
                    Exit For
                End If
            Next
            _parent.UpdateVisualData()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
