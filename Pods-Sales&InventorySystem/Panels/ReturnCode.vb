Public Class ReturnCode
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblrrcTableAdapter
    Private _dataTable As New pods.viewtblrrcDataTable
    Private Sub ReturnCode_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        Try
            _tableAapter.Fill(_dataTable)
            RrcDataGridView.DataSource = _dataTable
            'RrcDataGridView.Columns.Item("ID").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim dialog As New SupplierReturnCodeDialog(subject:=_subject)
        dialog.ShowDialog()
    End Sub

    Private Sub RrcDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles RrcDataGridView.CellClick
        Try
            If RrcDataGridView.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = RrcDataGridView.SelectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                    {"id", row.Cells(0).Value.ToString()},
                    {"code", row.Cells(1).Value.ToString()},
                    {"description", row.Cells(2).Value.ToString()}
                }
                Dim Dialog As New SupplierReturnCodeDialog(data:=data, subject:=_subject)
                Dialog.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
