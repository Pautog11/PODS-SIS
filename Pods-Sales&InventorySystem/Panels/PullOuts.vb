Public Class PullOuts
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private _tableAapter As New podsTableAdapters.viewtbldeliverypulloutsTableAdapter 'podsTableAdapters.tblaccountsTableAdapter
    Private _dataTable As New pods.viewtbldeliverypulloutsDataTable 'pods.tblaccountsDataTable

    Private Sub Pullout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        PullOutsGridView.DataSource = _dataTable
        PullOutsGridView.Columns.Item("ID").Visible = False
    End Sub

    Private Sub PullOutsGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PullOutsGridView.CellClick
        Try
            If PullOutsGridView.Rows.Count > 0 Then
                Dim row As DataGridViewRow = PullOutsGridView.Rows(0)
                Dim data As New Dictionary(Of String, String) From {
                        {"id", row.Cells(0).Value},
                        {"delivery_number", row.Cells(2).Value},
                        {"total", row.Cells(3).Value},
                        {"date", row.Cells(4).Value}
                }
                Dim dialog As New DeliveryPullOutCartView(data:=data)
                dialog.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
