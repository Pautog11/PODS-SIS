Public Class AccountLog
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private _tableAapter As New podsTableAdapters.viewtblaccount_logsTableAdapter
    Private _dataTable As New pods.viewtblaccount_logsDataTable
    Private Sub AccountLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        AccountLogDataGridView.DataSource = _dataTable
        AccountLogDataGridView.Columns.Item("ID").Visible = False
    End Sub
End Class
