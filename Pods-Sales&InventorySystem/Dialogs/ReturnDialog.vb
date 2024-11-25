Imports System.Windows.Forms

Public Class ReturnDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Dim dt As DataTable = Nothing
    Dim pid As Decimal = Nothing
    Private ReadOnly _parent As ReturnCartDialog = Nothing
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional parent As ReturnCartDialog = Nothing)
        InitializeComponent()
        _data = data
        _parent = parent
    End Sub

    Private Sub ReturnDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _data IsNot Nothing Then
            dt = BaseReturn.SelectTransactionbyTransaction_id(_data.Item("delivery_id"))
            ProductComboBox.DataSource = dt.DefaultView
            ProductComboBox.DisplayMember = "name"

            CostTextBox.Enabled = False
            StocksTextBox.Enabled = False
        End If
    End Sub

    Private Sub ProductComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ProductComboBox.SelectionChangeCommitted
        If ProductComboBox.SelectedIndex >= 0 Then
            Dim selectedRow As DataRowView = DirectCast(ProductComboBox.SelectedItem, DataRowView)
            CostTextBox.Text = selectedRow("price").ToString()
            StocksTextBox.Text = selectedRow("quantity").ToString()
            pid = selectedRow("pid").ToString()
        End If

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If CostTextBox.Text = "" AndAlso StocksTextBox.Text = "" Then
            MessageBox.Show("No product selected", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim result As New List(Of Object()) From {InputValidation.ValidateInputString(QuantityTextBox, DataInput.STRING_INTEGER)}
            Dim is_existing As Boolean = False

            If Val(QuantityTextBox.Text) <= Val(StocksTextBox.Text) Then
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
                        If CInt(StocksTextBox.Text) >= QuantityTextBox.Text Then
                            _parent.ReturnDataGridView.Rows.Add({ProductComboBox.SelectedItem("ID"),
                                                         If(String.IsNullOrEmpty(pid), 0, pid),
                                                         If(String.IsNullOrEmpty(ProductComboBox.Text), 0, ProductComboBox.Text),
                                                         If(String.IsNullOrEmpty(CostTextBox.Text), 0, CostTextBox.Text),
                                                         If(String.IsNullOrEmpty(QuantityTextBox.Text), 0, QuantityTextBox.Text),
                                                         CDec(CostTextBox.Text) * CDec(QuantityTextBox.Text)
                                                         })
                        Else
                            MessageBox.Show("Insufficient stocks!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                    _parent.UpdateVisualData()
                    Me.Close()
                Else
                    MessageBox.Show("Invalid quantity!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Quantity should not be greater than from the sold items!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
End Class
