Imports System.Data.SqlClient

Public Class Inventory
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private _tableAapter As New podsTableAdapters.viewtblinventoriesTableAdapter
    Private _dataTable As New pods.viewtblinventoriesDataTable
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ProductDataGridView.DataSource = _dataTable
    End Sub
End Class
