Public Class Returns
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblreturnsTableAdapter 'podsTableAdapters.tblaccountsTableAdapter
    Private _dataTable As New pods.viewtblreturnsDataTable 'pods.tblaccountsDataTable

    Private Sub Returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ReturnsDataGridView.DataSource = _dataTable
        'ReturnsDataGridView.Columns.Item("ID").Visible = False
    End Sub
End Class
