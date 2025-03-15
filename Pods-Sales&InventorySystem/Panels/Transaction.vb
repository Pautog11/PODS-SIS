Public Class Transaction
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private _tableAapter As New podsTableAdapters.viewtbltransactionsTableAdapter
    Private _dataTable As New pods.viewtbltransactionsDataTable

    Private Sub Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        Try
            _tableAapter.Fill(_dataTable)
            TransactionDataGridView.DataSource = _dataTable
            TransactionDataGridView.Columns.Item("ID").Visible = False
            TransactionDataGridView.Columns.Item("VAT").Visible = False
            TransactionDataGridView.Columns.Item("CASH").Visible = False
            TransactionDataGridView.Columns.Item("DISCOUNT").Visible = False
            TransactionDataGridView.Columns.Item("SUBTOTAL").Visible = False
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TransactionDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionDataGridView.CellClick
        If TransactionDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRows As DataGridViewSelectedRowCollection = TransactionDataGridView.SelectedRows
            Dim row As DataGridViewRow = selectedRows(0)
            Dim data As New Dictionary(Of String, String) From {
                {"id", If(String.IsNullOrEmpty(row.Cells(0).Value.ToString()), "0", row.Cells(0).Value.ToString())},
                {"transaction_number", If(String.IsNullOrEmpty(row.Cells(2).Value.ToString()), "0", row.Cells(2).Value.ToString())},
                {"subtotal", If(String.IsNullOrEmpty(row.Cells(3).Value.ToString()), "0", row.Cells(3).Value.ToString())},
                {"vat", If(String.IsNullOrEmpty(row.Cells(4).Value.ToString()), "0", row.Cells(4).Value.ToString())},
                {"discount", If(String.IsNullOrEmpty(row.Cells(5).Value.ToString()), "0", row.Cells(5).Value.ToString())},
                {"total", If(String.IsNullOrEmpty(row.Cells(6).Value.ToString()), "0", row.Cells(6).Value.ToString())},
                {"date", If(String.IsNullOrEmpty(row.Cells(7).Value.ToString()), "0", row.Cells(7).Value.ToString())},
                {"cash", If(String.IsNullOrEmpty(row.Cells(8).Value.ToString()), "0", row.Cells(8).Value.ToString())}
            }
            Dim Dialog As New TransactionDialog(data:=data, subject:=_subject)
            Dialog.ShowDialog()
        End If
    End Sub

    Private Sub DeliverySearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles DeliverySearchTextBox.TextChanged
        _dataTable = BaseTransaction.Search(DeliverySearchTextBox.Text)
        TransactionDataGridView.DataSource = _dataTable
    End Sub
End Class
