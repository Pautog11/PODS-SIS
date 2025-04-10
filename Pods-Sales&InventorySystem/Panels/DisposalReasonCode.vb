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
        Try
            _tableAapter.Fill(_dataTable)
            DisposalDataGridView.DataSource = _dataTable
            DisposalDataGridView.Columns.Item("ID").Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try
            Dim dialog As New DisposalCodeDialog(subject:=_subject)
            dialog.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DisposalDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DisposalDataGridView.CellClick
        Try
            If DisposalDataGridView.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = DisposalDataGridView.SelectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                    {"id", row.Cells(0).Value.ToString()},
                    {"code", row.Cells(1).Value.ToString()},
                    {"description", row.Cells(2).Value.ToString()}
                }
                Dim Dialog As New DisposalCodeDialog(data:=data, subject:=_subject)
                Dialog.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Try
            _dataTable = BaseDisposalCode.Search(SearchTextBox.Text)
            DisposalDataGridView.DataSource = _dataTable
        Catch ex As Exception

        End Try
    End Sub
End Class
