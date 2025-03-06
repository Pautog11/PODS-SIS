Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class PullOutProductDialog
    Private Sub PullOutProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection(My.Settings.podsdbConnectionString)
        Dim cmd As New SqlCommand("select b.id, delivery_number, product_id, batch_number, cost_price, inventory_quantity, sum(cost_price * inventory_quantity) as total, expiration_date, supplier_id, 'Inventory' as 'from'
                                    from tbldeliveries a
                                    join tbldeliveries_items b on a.id = b.delivery_id
                                    join tblproducts c on b.product_id = c.id
                                    group by b.id, delivery_number, product_id, batch_number, cost_price, inventory_quantity, expiration_date, supplier_id

                                    union all 

                                    select b.id, delivery_number, f.product_id, batch_number, cost_price, remaining_quantity, sum(cost_price * remaining_quantity) as total, expiration_date, supplier_id, 'Return' as 'from'
                                    from tblreturns a
                                    join tblreturn_items b on a.id = b.tblreturn_id
                                    join tbltransactions c on a.transaction_id = c.id
                                    join getrev d on c.id = d.transaction_id
                                    join tbldeliveries e on d.delivery_id = e.id
                                    join tbldeliveries_items f on e.id = f.delivery_id
                                    group by b.id, delivery_number, f.product_id, batch_number, cost_price, remaining_quantity, expiration_date, supplier_id", conn)
        Dim dTable As New DataTable
        Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(dTable)
        Guna2DataGridView1.DataSource = dTable.DefaultView
    End Sub
    'Private ReadOnly _data As Dictionary(Of String, String)
    'Private ReadOnly _data2 As Dictionary(Of String, String)
    ''Private dt As DataTable
    'Private ReadOnly _parent As DeliveryPulloutCart = Nothing
    'Dim pid As String = Nothing
    'Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
    '               Optional data2 As Dictionary(Of String, String) = Nothing,
    '               Optional parent As DeliveryPulloutCart = Nothing)
    '    InitializeComponent()
    '    _data = data
    '    _parent = parent
    '    _data2 = data2
    'End Sub
    'Private Sub PullOutProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Try
    '        Dim dt As DataTable = BasePullouts.SelectAllProductByDeliveryId(_data.Item("id"))

    '        If _data IsNot Nothing Then
    '            'dt = BaseDelivery.FillPulloutProduct(_data.Item("id"))
    '            ProductComboBox.DataSource = dt.DefaultView
    '            ProductComboBox.DisplayMember = "product_name"
    '            VoidButton.Visible = False

    '            'MsgBox(_data.Item("id"))
    '            'Else
    '            '    'MsgBox(_data2.Item("did"))


    '            '    'dt = BaseDelivery.FillPulloutProduct(_data2.Item("did"))
    '            '    ProductComboBox.DataSource = dt.DefaultView
    '            '    ProductComboBox.DisplayMember = "name"
    '            '    StocksTextBox.Text = dt.Rows(0)("quantity").ToString
    '            '    pid = dt.Rows(0)("pid").ToString

    '            '    ExdTextBox.Text = _data2.Item("exd")
    '            '    CostTextBox.Text = _data2.Item("cost")
    '            '    ProductComboBox.Enabled = False

    '        End If
    '        'MsgBox(_data.Item("id"))

    '        'MfdTextBox.Enabled = False
    '        ExdTextBox.Enabled = False
    '        StocksTextBox.Enabled = False
    '        CostTextBox.Enabled = False
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub ProductComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ProductComboBox.SelectionChangeCommitted
    '    Try
    '        'StocksTextBox.Text = DataTable.Rows(0).Item("quantity").ToString()
    '        If ProductComboBox.SelectedIndex >= 0 Then
    '            Dim selectedRow As DataRowView = DirectCast(ProductComboBox.SelectedItem, DataRowView)
    '            StocksTextBox.Text = selectedRow("inventory_quantity").ToString()
    '            CostTextBox.Text = selectedRow("cost_price").ToString()
    '            pid = selectedRow("pid").ToString()
    '            If selectedRow("exd") IsNot DBNull.Value Then
    '                ExdTextBox.Text = Convert.ToDateTime(selectedRow("exd")).ToString("yyyy-MM-dd")
    '                PullOutProductSaveButton.Enabled = True
    '            Else
    '                ExdTextBox.Text = "N/A"
    '                PullOutProductSaveButton.Enabled = False
    '            End If
    '            'MsgBox(selectedRow("id"))
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub PullOutProductSaveButton_Click(sender As Object, e As EventArgs) Handles PullOutProductSaveButton.Click
    '    Try
    '        If ExdTextBox.Text = "" AndAlso CostTextBox.Text = "" Then
    '            MessageBox.Show("No product selected!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Else
    '            Dim result As New List(Of Object()) From {InputValidation.ValidateInputString(QuantityTextBox, DataInput.STRING_INTEGER)}
    '            Dim is_existing As Boolean = False
    '            If Not result.Any(Function(item As Object()) Not item(0)) Then
    '                For Each item As DataGridViewRow In _parent.DeliveryPulloutDataGridView.Rows
    '                    If item.Cells("PRODUCT").Value.ToString() = ProductComboBox.Text Then
    '                        item.Cells("PID").Value = If(String.IsNullOrEmpty(pid), 0, pid)
    '                        item.Cells("PRICE").Value = Decimal.Parse(CostTextBox.Text)
    '                        item.Cells("QUANTITY").Value = If(String.IsNullOrEmpty(CInt(QuantityTextBox.Text)), 0, CInt(QuantityTextBox.Text))
    '                        item.Cells("TOTAL").Value = Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)
    '                        is_existing = True
    '                        Exit For
    '                    End If
    '                Next
    '                If Not is_existing Then
    '                    If CInt(StocksTextBox.Text) >= QuantityTextBox.Text Then
    '                        _parent.DeliveryPulloutDataGridView.Rows.Add({ProductComboBox.SelectedItem("ID"),
    '                                                     If(String.IsNullOrEmpty(pid), 0, pid),
    '                                                     If(String.IsNullOrEmpty(ProductComboBox.Text), 0, ProductComboBox.Text),
    '                                                     If(String.IsNullOrEmpty(ExdTextBox.Text), 0, ExdTextBox.Text),
    '                                                     If(String.IsNullOrEmpty(CostTextBox.Text), 0, CostTextBox.Text),
    '                                                     If(String.IsNullOrEmpty(QuantityTextBox.Text), 0, QuantityTextBox.Text),
    '                                                     CDec(CostTextBox.Text) * CDec(QuantityTextBox.Text)
    '                                                     })
    '                    Else
    '                        MessageBox.Show("Insufficient stocks!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                    End If
    '                End If
    '                _parent.UpdateVisualData()
    '                Me.Close()
    '            Else
    '                MessageBox.Show("Invalid quantity!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            End If
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub VoidButton_Click(sender As Object, e As EventArgs) Handles VoidButton.Click
    '    Try
    '        For Each row As DataGridViewRow In _parent.DeliveryPulloutDataGridView.Rows
    '            If row.Cells("ID").Value.ToString() = _data2.Item("id").ToString() Then
    '                _parent.DeliveryPulloutDataGridView.Rows.Remove(row)
    '                Exit For
    '            End If
    '        Next
    '        _parent.UpdateVisualData()
    '        Me.Close()
    '        'MsgBox(_data2.Item("id"))
    '    Catch ex As Exception

    '    End Try
    'End Sub
End Class
