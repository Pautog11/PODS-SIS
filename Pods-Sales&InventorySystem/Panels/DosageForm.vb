Public Class DosageForm
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtbldosageformTableAdapter 'podsTableAdapters.tblaccountsTableAdapter
    Private ReadOnly _dataTable As New pods.viewtbldosageformDataTable 'pods.tblaccountsDataTable

    Private Sub DosageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        DosageFormDataGridView.DataSource = _dataTable
        'DosageFormDataGridView.Columns.Item("ID").Visible = False
    End Sub

    Private Sub AddDosageFormButton_Click(sender As Object, e As EventArgs) Handles AddDosageFormButton.Click
        Dim dialog As New DosageFormDialog(subject:=_subject)
        dialog.ShowDialog()
    End Sub

    Private Sub DosageFormDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DosageFormDataGridView.CellClick
        Try
            If DosageFormDataGridView.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = DosageFormDataGridView.SelectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                    {"id", If(row.Cells(0).Value?.ToString(), String.Empty)},
                    {"dosageform", If(row.Cells(1).Value?.ToString(), String.Empty)},
                    {"description", If(row.Cells(2).Value?.ToString(), String.Empty)}
                }
                Dim dialog As New DosageFormDialog(data:=data, subject:=_subject)
                dialog.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
