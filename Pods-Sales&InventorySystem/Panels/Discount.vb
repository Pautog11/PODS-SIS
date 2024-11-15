Public Class Discount
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtbldiscountsTableAdapter 'podsTableAdapters.tblaccountsTableAdapter
    Private ReadOnly _dataTable As New pods.viewtbldiscountsDataTable 'pods.tblaccountsDataTable

    Private Sub Discount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        DiscountDataGridView.DataSource = _dataTable
        DiscountDataGridView.Columns.Item("ID").Visible = False
    End Sub
End Class


