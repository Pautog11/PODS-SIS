Public Class PullOuts
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private _tableAapter As New podsTableAdapters.viewtbldeliverypulloutsTableAdapter 'podsTableAdapters.tblaccountsTableAdapter
    Private _dataTable As New pods.viewtbldeliverypulloutsDataTable 'pods.tblaccountsDataTable

    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'PullOutsGridView.Columns.Item("ID").Visible = False
    End Sub

    Private Sub PullOutsvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PullOutsGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PullOutsGridView.CellClick
        Dim dialog As New DeliveryPulloutCart
        dialog.ShowDialog()
    End Sub

    Private Sub AddPulloutButton_Click(sender As Object, e As EventArgs) Handles AddPulloutButton.Click
        Dim dialog As New DeliveryPulloutCart
        dialog.ShowDialog()
    End Sub
End Class
