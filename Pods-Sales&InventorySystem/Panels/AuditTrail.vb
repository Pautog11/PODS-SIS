Public Class AuditTrail
    Implements IObserverPanel

    Private _subject As IObservablePanel
    Private _tableAapter As New podsTableAdapters.viewtblaccount_logsTableAdapter
    Private _dataTable As New pods.viewtblaccount_logsDataTable

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        _tableAapter.Fill(_dataTable)
        AuditTrailDataGridView.DataSource = _dataTable
        AuditTrailDataGridView.Columns.Item("ID").Visible = False
    End Sub

    Private Sub AuditTrail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
