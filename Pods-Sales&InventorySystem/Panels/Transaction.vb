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
        _tableAapter.Fill(_dataTable)
        TransactionDataGridView.DataSource = _dataTable
        TransactionDataGridView.Columns.Item("ID").Visible = False
    End Sub

    Private Sub AddDeliveryButton_Click(sender As Object, e As EventArgs) Handles AddTransactionButton.Click
        Dim dialog As New TransactionDialog(subject:=_subject)
        dialog.ShowDialog()
    End Sub

    Private Sub TransactionDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TransactionDataGridView.CellClick
        If TransactionDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRows As DataGridViewSelectedRowCollection = TransactionDataGridView.SelectedRows
            Dim row As DataGridViewRow = selectedRows(0)
            Dim data As New Dictionary(Of String, String) From {
                {"id", row.Cells(0).Value.ToString()},
                {"transaction_number", row.Cells(2).Value.ToString()},
                {"subtotal", row.Cells(3).Value.ToString()},
                {"vat", row.Cells(4).Value.ToString()},
                {"discount", row.Cells(5).Value.ToString()},
                {"total", row.Cells(6).Value.ToString()},
                {"date", row.Cells(7).Value.ToString()},
                {"cash", row.Cells(8).Value.ToString()}
            }
            Dim Dialog As New TransactionDialog(data:=data)
            Dialog.ShowDialog()
        End If
    End Sub
End Class
