Public Class CustomerReturnCode
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblcustomer_rrcTableAdapter
    Private _dataTable As New pods.viewtblcustomer_rrcDataTable
    Private Sub CustomerReturnCode_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        CustomerRrcDataGridView.DataSource = _dataTable
        CustomerRrcDataGridView.Columns.Item("ID").Visible = False
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim dialog As New CustomerReturnCodeDialog(subject:=_subject)
        dialog.ShowDialog()
    End Sub

    Private Sub CustomerRrcDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerRrcDataGridView.CellClick
        Try
            If CustomerRrcDataGridView.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = CustomerRrcDataGridView.SelectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                    {"id", row.Cells(0).Value.ToString()},
                    {"code", row.Cells(1).Value.ToString()},
                    {"description", row.Cells(2).Value.ToString()}
                }
                Dim Dialog As New CustomerReturnCodeDialog(data:=data, subject:=_subject)
                Dialog.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Try
            _dataTable = BaseCustomerReturnCode.Search(SearchTextBox.Text)
            CustomerRrcDataGridView.DataSource = _dataTable
        Catch ex As Exception

        End Try
    End Sub
End Class
