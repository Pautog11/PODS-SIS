Public Class Vat
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblvatTableAdapter 'podsTableAdapters.tblaccountsTableAdapter
    Private ReadOnly _dataTable As New pods.viewtblvatDataTable 'pods.tblaccountsDataTable

    Private Sub Vat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        VatDataGridView.DataSource = _dataTable
        VatDataGridView.Columns.Item("ID").Visible = False
    End Sub

    Private Sub VatDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles VatDataGridView.CellClick
        Try
            If VatDataGridView.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = VatDataGridView.SelectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                    {"id", If(row.Cells(0).Value?.ToString(), String.Empty)},
                    {"vat", If(row.Cells(1).Value?.ToString(), String.Empty)}
                }
                Dim dialog As New VatDialog(data:=data, subject:=_subject)
                dialog.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class