Public Class PullOuts
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private _tableAapter As New podsTableAdapters.viewtbldeliverypulloutsTableAdapter 'podsTableAdapters.tblaccountsTableAdapter
    Private _dataTable As New pods.viewtbldeliverypulloutsDataTable 'pods.tblaccountsDataTable

    Private Sub Pullout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            PullOutsGridView.DataSource = _dataTable
            PullOutsGridView.Columns.Item("ID").Visible = False
            PullOutsGridView.Columns.Item("SUPID").Visible = False
            PullOutsGridView.Columns.Item("VENID").Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PullOutsGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PullOutsGridView.CellClick
        Try
            If PullOutsGridView.Rows.Count > 0 Then
                Dim selectedRows As DataGridViewSelectedRowCollection = PullOutsGridView.SelectedRows
                Dim row As DataGridViewRow = selectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                        {"id", row.Cells(0).Value},
                        {"delivery_number", row.Cells(1).Value},
                        {"date", row.Cells(4).Value},
                        {"supid", row.Cells(5).Value},
                        {"vendid", row.Cells(6).Value}
                }
                Dim dialog As New PullOutCartDialog(data:=data)
                dialog.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Try
            Dim dialog As New PullOutCartDialog(subject:=_subject)
            dialog.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PulloutSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles PulloutSearchTextBox.TextChanged
        Try
            _dataTable = BasePullouts.Search(PulloutSearchTextBox.Text)
            PullOutsGridView.DataSource = _dataTable
        Catch ex As Exception

        End Try
    End Sub
End Class
