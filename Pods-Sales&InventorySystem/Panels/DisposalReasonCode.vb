Public Class DisposalReasonCode
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtbldisposalcodeTableAdapter
    Private _dataTable As New pods.viewtbldisposalcodeDataTable

    Private Sub DisposalReasonCode_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        DisposalDataGridView.DataSource = _dataTable
        'DisposalDataGridView.Columns.Item("ID").Visible = False
    End Sub
End Class
