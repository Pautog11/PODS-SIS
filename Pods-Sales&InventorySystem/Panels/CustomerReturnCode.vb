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
        'RrcDataGridView.Columns.Item("ID").Visible = False
    End Sub
End Class
