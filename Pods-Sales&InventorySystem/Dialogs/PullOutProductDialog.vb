Imports System.Windows.Forms

Public Class PullOutProductDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private dt As DataTable
    Private ReadOnly _parent As DeliveryPulloutCart = Nothing
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional parent As DeliveryPulloutCart = Nothing)
        InitializeComponent()
        _data = data
        _parent = parent
    End Sub
    Private Sub PullOutProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _data IsNot Nothing Then
            dt = BaseDelivery.FillPulloutProduct(_data.Item("id"))
            ProductComboBox.DataSource = dt.DefaultView
            ProductComboBox.DisplayMember = "name"
        End If

        MfdTextBox.Enabled = False
        ExdTextBox.Enabled = False
        StocksTextBox.Enabled = False
        CostTextBox.Enabled = False
    End Sub

    Private Sub ProductComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ProductComboBox.SelectionChangeCommitted
        'StocksTextBox.Text = DataTable.Rows(0).Item("quantity").ToString()
        If ProductComboBox.SelectedIndex >= 0 Then
            Dim selectedRow As DataRowView = DirectCast(ProductComboBox.SelectedItem, DataRowView)
            StocksTextBox.Text = selectedRow("quantity").ToString()
            'MfdTextBox.Text = selectedRow("mfd").ToString("yyyy-MM-dd")
            'ExdTextBox.Text = selectedRow("exd").ToString("yyyy-MM-dd")
            CostTextBox.Text = selectedRow("cost").ToString()


            'If selectedRow("mfd") IsNot DBNull.Value Then
            '    MfdTextBox.Text = Convert.ToDateTime(selectedRow("mfd")).ToString("yyyy-MM-dd")
            'Else
            '    MfdTextBox.Text = "N/A"
            'End If

            If selectedRow("exd") IsNot DBNull.Value Then
                ExdTextBox.Text = Convert.ToDateTime(selectedRow("exd")).ToString("yyyy-MM-dd")
            Else
                ExdTextBox.Text = "N/A"
            End If
        End If
    End Sub

    Private Sub PullOutProductSaveButton_Click(sender As Object, e As EventArgs) Handles PullOutProductSaveButton.Click
        Dim result As New List(Of Object()) From {InputValidation.ValidateInputString(QuantityTextBox, DataInput.STRING_INTEGER)}
        Dim is_existing As Boolean = False
        If Not result.Any(Function(item As Object()) Not item(0)) Then
            For Each item As DataGridViewRow In _parent.DeliveryPulloutDataGridView.Rows
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
                    _parent.DeliveryPulloutDataGridView.Rows.Add({ProductComboBox.SelectedItem("ID"),
                                                 ProductComboBox.Text,
                                                 ExdTextBox.Text,
                                                 CostTextBox.Text,
                                                 QuantityTextBox.Text,
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
    End Sub
End Class
