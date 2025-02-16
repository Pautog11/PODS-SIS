Public Class SearchDialog
    Implements IObserverPanel
    Private _subject As IObservablePanel
    'Private ReadOnly _tableAapter As New podsTableAdapters.viewtblproductsearchTableAdapter
    'Private _dataTable As New pods.viewtblproductsearchDataTable
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _parent As TransactionDialog = Nothing
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional parent As TransactionDialog = Nothing)
        InitializeComponent()
        _data = data
        _parent = parent
    End Sub

    Private Sub SearchDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '    _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
        '    _subject?.RegisterObserver(Me)
        '    _subject?.NotifyObserver()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        '_tableAapter.Fill(_dataTable)
        'ProductDataGridView.DataSource = _dataTable
        'ProductDataGridView.DataSource = _dataTable
        ''ProductDataGridView.Columns.Item("STOCK_LEVEL").Visible = False
        ''ProductDataGridView.Columns.Item("SUBCATEGORY").Visible = False
        ''ProductDataGridView.Columns.Item("BARCODE").Visible = False
        ''ProductDataGridView.Columns.Item("SKU").Visible = False
        ''ProductDataGridView.Columns.Item("DESCRIPTION").Visible = False
        ''ProductDataGridView.Columns.Item("COST").Visible = False



        'Try
        '    Dim conn As SqlConnection = SqlConnectionPods.GetInstance
        '    Dim cmd As SqlCommand
        '    cmd = New SqlCommand("SELECT 
        '                            product_id,
        '                            SUM(quantity) AS total_quantity,
        '                            (SELECT TOP 1 price 
        '                             FROM tbldeliveries_items t2 
        '                             WHERE t1.product_id = t2.product_id 
        '                             ORDER BY id DESC) AS latest_cost_price
        '                        FROM tbldeliveries_items t1
        '                        GROUP BY product_id", conn)
        '    Dim dTable As New DataTable
        '    Dim adapter As New SqlDataAdapter(cmd)
        '    adapter.Fill(dTable)
        '    ProductDataGridView.DataSource = dTable
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End Try
    End Sub
    Private Sub ProductSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductSearchTextBox.TextChanged
        '_dataTable = BaseProduct.SearchDilog(ProductSearchTextBox.Text)
        'ProductDataGridView.DataSource = _dataTable
    End Sub

    Private Sub ProductDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDataGridView.CellClick
        'Try
        '    If ProductDataGridView.Rows.Count > 0 Then
        '        Dim selectedRows As DataGridViewSelectedRowCollection = ProductDataGridView.SelectedRows
        '        Dim row As DataGridViewRow = selectedRows(0)
        '        Dim data As New Dictionary(Of String, String) From {
        '            {"id", If(String.IsNullOrEmpty(row.Cells(0).Value.ToString()), 0, row.Cells(0).Value.ToString())},
        '            {"productname", If(String.IsNullOrEmpty(row.Cells(1).Value.ToString()), 0, row.Cells(1).Value.ToString())},
        '            {"price", If(String.IsNullOrEmpty(row.Cells(2).Value.ToString()), 0, row.Cells(2).Value.ToString())},
        '            {"quantity", If(String.IsNullOrEmpty(row.Cells(3).Value.ToString()), 0, row.Cells(3).Value.ToString())}
        '        }
        '        Dim dialog As New TransactionProductDailog(dat2:=data, parent:=_parent)
        '        dialog.ShowDialog()
        '        Me.Close()
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub
End Class
