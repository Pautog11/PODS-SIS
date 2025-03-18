Imports System.Windows.Forms

Public Class ReturnDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _data2 As Dictionary(Of String, String)
    Dim dt As DataTable = Nothing
    Dim num As Integer = 1
    Dim orig_price As Decimal = Nothing
    Dim target As Integer = Nothing
    Private ReadOnly _parent As ReturnCartDialog = Nothing
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional data2 As Dictionary(Of String, String) = Nothing,
                   Optional parent As ReturnCartDialog = Nothing)
        InitializeComponent()
        _data = data
        _data2 = data2
        _parent = parent
    End Sub

    Private Sub ReturnDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                dt = BaseReturn.SelectTransactionbyTransaction_id(_data.Item("delivery_id"))
                ProductComboBox.DropDownHeight = 5 * ProductComboBox.ItemHeight
                ProductComboBox.DataSource = dt.DefaultView
                ProductComboBox.DisplayMember = "name"

                If dt.Rows.Count > 0 Then
                    ProductComboBox.SelectedIndex = -1
                End If

                If _parent.ReturnDataGridView.Rows.Count > 0 Then
                    num = _parent.ReturnDataGridView.Rows.Cast(Of DataGridViewRow)().Max(Function(row) Convert.ToInt32(row.Cells("target").Value)) + 1
                Else
                    num = 1
                End If

                CostTextBox.ReadOnly = True
                StocksTextBox.ReadOnly = True
                RemoveButton.Visible = False

            ElseIf _data2 IsNot Nothing Then
                Dim dt As DataTable = BaseReturn.SelectProductReturnedByTrasaction(_data2.Item("reference"), _data2.Item("id"))
                ProductComboBox.DropDownHeight = 5 * ProductComboBox.ItemHeight
                ProductComboBox.DataSource = dt.DefaultView
                ProductComboBox.DisplayMember = "product_name"
                If dt.Rows.Count > 0 Then
                    StocksTextBox.Text = dt.Rows(0)("quantity").ToString()
                    CostTextBox.Text = dt.Rows(0)("price").ToString()
                End If
                target = _data2.Item("target")

                ProductComboBox.Enabled = False
                SaveButton.Text = "Update"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProductComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ProductComboBox.SelectionChangeCommitted
        Try
            If ProductComboBox.SelectedIndex >= 0 Then
                Dim selectedRow As DataRowView = DirectCast(ProductComboBox.SelectedItem, DataRowView)
                orig_price = selectedRow("orignal_price").ToString()
                CostTextBox.Text = selectedRow("price").ToString()
                StocksTextBox.Text = selectedRow("quantity").ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Dim controls As Object() = {ProductComboBox, QuantityTextBox}
            Dim types As DataInput() = {DataInput.STRING_STRING, DataInput.STRING_INTEGER}

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

            If Val(QuantityTextBox.Text) > Val(StocksTextBox.Text) Then
                MessageBox.Show("Quantity should not be greater than from the sold items!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                QuantityTextBox.Text = ""
                Exit Sub
            End If

            Dim is_existing As Boolean = False
            If Not result.Any(Function(item As Object()) Not item(0)) Then
                For Each item As DataGridViewRow In _parent.ReturnDataGridView.Rows
                    If item.Cells("PRODUCT").Value.ToString() = ProductComboBox.Text Then
                        item.Cells("ORIGINAL PRICE").Value = Decimal.Parse(orig_price).ToString("F2")
                        item.Cells("PRICE").Value = Decimal.Parse(CostTextBox.Text).ToString("F2")
                        item.Cells("QUANTITY").Value = CInt(QuantityTextBox.Text)
                        item.Cells("TOTAL").Value = Decimal.Parse(CDec(CostTextBox.Text) * CInt(QuantityTextBox.Text)).ToString("F2")
                        is_existing = True
                        Exit For
                    End If
                Next
                If Not is_existing Then
                    _parent.ReturnDataGridView.Rows.Add({If(String.IsNullOrEmpty(ProductComboBox.SelectedItem("ID")), 0, ProductComboBox.SelectedItem("ID")),
                                                     If(String.IsNullOrEmpty(ProductComboBox.Text), 0, ProductComboBox.Text),
                                                     If(String.IsNullOrEmpty(Decimal.Parse(orig_price).ToString("F2")), 0, Decimal.Parse(orig_price).ToString("F2")),
                                                     If(String.IsNullOrEmpty(Decimal.Parse(CostTextBox.Text).ToString("F2")), 0, Decimal.Parse(CostTextBox.Text).ToString("F2")),
                                                     If(String.IsNullOrEmpty(QuantityTextBox.Text), 0, QuantityTextBox.Text),
                                                     Decimal.Parse(CDec(CostTextBox.Text) * CInt(QuantityTextBox.Text)).ToString("F2"),
                                                     num
                                                     })
                    num += 1
                End If
                _parent.UpdateVisualData()
                Me.Close()
            Else
                MessageBox.Show("Invalid quantity!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                QuantityTextBox.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Try
            For Each row As DataGridViewRow In _parent.ReturnDataGridView.Rows
                If row.Cells("target").Value.ToString() = target Then
                    _parent.ReturnDataGridView.Rows.Remove(row)
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
