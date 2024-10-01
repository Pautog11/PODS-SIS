Public Class Supplier
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private _tableAapter As New podsTableAdapters.viewtblsuppliersTableAdapter
    Private _dataTable As New pods.viewtblsuppliersDataTable

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error")
        End Try
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        _tableAapter.Fill(_dataTable)
        SupplierDataGridView.DataSource = _dataTable
    End Sub

    Private Sub AddSupplierButton_Click(sender As Object, e As EventArgs) Handles AddSupplierButton.Click
        Dim dialog As New SupplierDialog
        dialog.ShowDialog()
    End Sub
End Class
