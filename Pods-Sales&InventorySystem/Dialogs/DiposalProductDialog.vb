Imports System.Windows.Forms

Public Class DiposalProductDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _parent As DisposalCartDialog = Nothing
    Dim delivery_items_id As Integer = Nothing
    Dim product_id As Integer = Nothing
    Dim num As Integer = 1
    Dim from As String = Nothing

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional parent As DisposalCartDialog = Nothing)
        InitializeComponent()
        _data = data
        _parent = parent
    End Sub

    Private Sub DiposalProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                delivery_items_id = _data.Item("id")
                product_id = _data.Item("pid")
                ProductTextBox.Text = _data.Item("name")
                BatchNumberTextBox.Text = _data.Item("batch_number")
                ExpiryDateTextBox.Text = _data.Item("expiry_date")
                CostTextBox.Text = _data.Item("cost")
                from = _data.Item("from")

                If _data.Item("from") = "INVENTORY" Then
                    StocksTextBox.Text = BaseDisposal.FetchInvetoryQunatity(_data.Item("id"))
                End If

                If _data.Item("from") = "RETURNED" Then
                    StocksTextBox.Text = BaseDisposal.FetchReturnedQunatity(_data.Item("id"))
                End If

                Dim dt2 As DataTable = BaseDisposal.FetchDisposalReasonCodeByName(_data.Item("drc"))
                RrcComboBox.DataSource = dt2.DefaultView
                RrcComboBox.DisplayMember = "code"
                RrcComboBox.ValueMember = "id"

                AddButton.Text = "Update"

                TableLayoutPanel1.RowStyles(0).Height = 0
                TableLayoutPanel1.RowStyles(1).Height = 0
                Me.Height = 300
                Me.StartPosition = FormStartPosition.Manual
                Me.CenterToScreen()
            Else
                Dim dt As DataTable = BaseDisposal.SelectAllProducts
                DisposalDataGridView.DataSource = dt.DefaultView

                Dim reason As DataTable = BaseDisposal.FetchDisposalReasonCode
                RrcComboBox.DataSource = reason.DefaultView
                RrcComboBox.DisplayMember = "code"
                RrcComboBox.ValueMember = "id"


                If _parent.DisposalDataGridView.Rows.Count > 0 Then
                    num = _parent.DisposalDataGridView.Rows.Cast(Of DataGridViewRow)().Max(Function(row) Convert.ToInt32(row.Cells("target").Value)) + 1
                Else
                    num = 1
                End If

                If reason.Rows.Count > 0 Then
                    RrcComboBox.SelectedIndex = -1
                End If

                RemoveButton.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DisposalDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DisposalDataGridView.CellClick
        Try
            If DisposalDataGridView.Rows.Count > 0 AndAlso DisposalDataGridView.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = DisposalDataGridView.SelectedRows(0)
                delivery_items_id = row.Cells(0).Value?.ToString()
                product_id = row.Cells(2).Value?.ToString()
                from = row.Cells(3).Value?.ToString()
                ProductTextBox.Text = row.Cells(4).Value?.ToString()
                BatchNumberTextBox.Text = row.Cells(5).Value?.ToString()
                ExpiryDateTextBox.Text = row.Cells(6).Value?.ToString()
                CostTextBox.Text = row.Cells(7).Value?.ToString()
                StocksTextBox.Text = row.Cells(8).Value?.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try

            Dim controls As Object() = {ProductTextBox, RrcComboBox, QuantityTextBox}

            Dim types As DataInput() = {DataInput.STRING_STRING, DataInput.STRING_STRING, DataInput.STRING_INTEGER}

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

            If Val(StocksTextBox.Text) < Val(QuantityTextBox.Text) Then
                MessageBox.Show("Insufficient quantity!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim is_existing As Boolean = False

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                For Each item As DataGridViewRow In _parent.DisposalDataGridView.Rows
                    If item.Cells("id").Value.ToString() = delivery_items_id Then
                        item.Cells("from").Value = from
                        item.Cells("product").Value = ProductTextBox.Text
                        item.Cells("drc").Value = RrcComboBox.SelectedItem("code")
                        item.Cells("batch_number").Value = BatchNumberTextBox.Text
                        item.Cells("expiry_date").Value = ExpiryDateTextBox.Text
                        item.Cells("cost_price").Value = Decimal.Parse(CostTextBox.Text).ToString("F2")
                        item.Cells("quantity").Value = CInt(QuantityTextBox.Text)
                        item.Cells("total").Value = Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)
                        item.Cells("target").Value = num
                        is_existing = True
                        Exit For
                    End If
                Next

                If Not is_existing Then
                    _parent.DisposalDataGridView.Rows.Add({If(String.IsNullOrEmpty(delivery_items_id), 0, delivery_items_id),
                                                          If(String.IsNullOrEmpty(product_id), 0, product_id),
                                                          If(String.IsNullOrEmpty(from), "", from),
                                                          If(String.IsNullOrEmpty(ProductTextBox.Text), "", ProductTextBox.Text),
                                                          If(String.IsNullOrEmpty(RrcComboBox.SelectedItem("code")), 0, RrcComboBox.SelectedItem("code")),
                                                          If(String.IsNullOrEmpty(BatchNumberTextBox.Text), "", BatchNumberTextBox.Text),
                                                          If(String.IsNullOrEmpty(ExpiryDateTextBox.Text), "", ExpiryDateTextBox.Text),
                                                          If(String.IsNullOrEmpty(Decimal.Parse(CostTextBox.Text).ToString("F2")), 0, Decimal.Parse(CostTextBox.Text).ToString("F2")),
                                                          If(String.IsNullOrEmpty(CInt(QuantityTextBox.Text)), 0, CInt(QuantityTextBox.Text)),
                                                          If(String.IsNullOrEmpty(Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)), 0, Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)),
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
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Try
            For Each row As DataGridViewRow In _parent.DisposalDataGridView.Rows
                If row.Cells("target").Value.ToString() = _data.Item("target").ToString() Then
                    _parent.DisposalDataGridView.Rows.Remove(row)
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
