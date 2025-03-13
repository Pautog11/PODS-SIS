Imports System.Windows.Forms

Public Class ReturnDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Dim dt As DataTable = Nothing
    Dim num As Integer = 1
    Private ReadOnly _parent As ReturnCartDialog = Nothing
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional parent As ReturnCartDialog = Nothing)
        InitializeComponent()
        _data = data
        _parent = parent
    End Sub

    Private Sub ReturnDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                dt = BaseReturn.SelectTransactionbyTransaction_id(_data.Item("delivery_id"))
                ProductComboBox.DataSource = dt.DefaultView
                ProductComboBox.DisplayMember = "name"

                If dt.Rows.Count > 0 Then
                    ProductComboBox.SelectedIndex = -1
                End If

                CostTextBox.Enabled = False
                StocksTextBox.Enabled = False

                If _parent.ReturnDataGridView.Rows.Count > 0 Then
                    num = _parent.ReturnDataGridView.Rows.Cast(Of DataGridViewRow)().Max(Function(row) Convert.ToInt32(row.Cells("target").Value)) + 1
                Else
                    num = 1
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProductComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ProductComboBox.SelectionChangeCommitted
        Try
            If ProductComboBox.SelectedIndex >= 0 Then
                Dim selectedRow As DataRowView = DirectCast(ProductComboBox.SelectedItem, DataRowView)
                CostTextBox.Text = selectedRow("price").ToString()
                StocksTextBox.Text = selectedRow("quantity").ToString()
            End If
        Catch ex As Exception

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
                        item.Cells("PRICE").Value = Decimal.Parse(CostTextBox.Text)
                        item.Cells("QUANTITY").Value = CInt(QuantityTextBox.Text)
                        item.Cells("TOTAL").Value = Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)
                        is_existing = True
                        Exit For
                    End If
                Next
                If Not is_existing Then
                    'If CInt(StocksTextBox.Text) >= QuantityTextBox.Text Then
                    _parent.ReturnDataGridView.Rows.Add({If(String.IsNullOrEmpty(ProductComboBox.SelectedItem("ID")), 0, ProductComboBox.SelectedItem("ID")), 'If(String.IsNullOrEmpty(pid), 0, pid),
                                                     If(String.IsNullOrEmpty(ProductComboBox.Text), 0, ProductComboBox.Text),
                                                     If(String.IsNullOrEmpty(CostTextBox.Text), 0, CostTextBox.Text),
                                                     If(String.IsNullOrEmpty(QuantityTextBox.Text), 0, QuantityTextBox.Text),
                                                     CDec(CostTextBox.Text) * CDec(QuantityTextBox.Text),
                                                     num
                                                     })
                    num += 1
                    'Else
                    '    MessageBox.Show("Insufficient stocks!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'End If
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
End Class
