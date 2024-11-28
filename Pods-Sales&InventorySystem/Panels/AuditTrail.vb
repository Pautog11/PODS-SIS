Public Class AuditTrail
    Implements IObserverPanel

    Private _subject As IObservablePanel
    Private _tableAapter As New podsTableAdapters.viewtblaudittrailTableAdapter
    Private _dataTable As New pods.viewtblaudittrailDataTable

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        _tableAapter.Fill(_dataTable)
        AuditTrailDataGridView.DataSource = _dataTable
        AuditTrailDataGridView.Columns.Item("ID").Visible = False
    End Sub

    Private Sub AuditTrail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
