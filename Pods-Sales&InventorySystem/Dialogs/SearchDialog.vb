Imports System.Windows.Forms

Public Class SearchDialog
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblproductsTableAdapter
    Private _dataTable As New pods.viewtblproductsDataTable
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _parent As TransactionDialog = Nothing
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional parent As TransactionDialog = Nothing)
        InitializeComponent()
        _data = data
        _parent = parent
    End Sub

    Private Sub SearchDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        _tableAapter.Fill(_dataTable)
        ProductDataGridView.DataSource = _dataTable
        ProductDataGridView.DataSource = _dataTable
        ProductDataGridView.Columns.Item("STOCK_LEVEL").Visible = False
        ProductDataGridView.Columns.Item("SUBCATEGORY").Visible = False
        ProductDataGridView.Columns.Item("BARCODE").Visible = False
        ProductDataGridView.Columns.Item("SKU").Visible = False
        ProductDataGridView.Columns.Item("DESCRIPTION").Visible = False
        ProductDataGridView.Columns.Item("COST").Visible = False
    End Sub
    Private Sub ProductSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductSearchTextBox.TextChanged
        _dataTable = BaseProduct.Search(ProductSearchTextBox.Text)
        ProductDataGridView.DataSource = _dataTable
    End Sub

    Private Sub ProductDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDataGridView.CellClick
        If ProductDataGridView.Rows.Count > 0 Then
            Dim selectedRows As DataGridViewSelectedRowCollection = ProductDataGridView.SelectedRows
            Dim row As DataGridViewRow = selectedRows(0)
            Dim data As New Dictionary(Of String, String) From {
                {"id", row.Cells(0).Value.ToString()},
                {"productname", row.Cells(4).Value.ToString()},
                {"price", row.Cells(7).Value.ToString()},
                {"quantity", row.Cells(6).Value.ToString()}
            }
            Dim dialog As New TransactionCartDailog(dat2:=data, parent:=_parent)
            dialog.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class
