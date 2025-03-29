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
        Try
            _tableAapter.Fill(_dataTable)
            DiscountDataGridView.DataSource = _dataTable
            DiscountDataGridView.Columns.Item("ID").Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddDiscountButton_Click(sender As Object, e As EventArgs) Handles AddDiscountButton.Click
        Try
            Dim dialog As New DiscountDialog(subject:=_subject)
            dialog.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DiscountDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DiscountDataGridView.CellClick
        Try
            If DiscountDataGridView.Rows.Count > 0 Then
                Dim selectedRows As DataGridViewSelectedRowCollection = DiscountDataGridView.SelectedRows
                Dim row As DataGridViewRow = selectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                    {"id", row.Cells(0).Value.ToString()},
                    {"discount", row.Cells(1).Value.ToString()},
                    {"description", row.Cells(2).Value.ToString()}
                }
                Dim dialog As New DiscountDialog(data:=data, subject:=_subject)
                dialog.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class


