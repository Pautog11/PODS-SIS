Public Class Returns
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblreturnsTableAdapter 'podsTableAdapters.tblaccountsTableAdapter
    Private _dataTable As New pods.viewtblreturnsDataTable 'pods.tblaccountsDataTable

    Private Sub Returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ReturnsDataGridView.DataSource = _dataTable
        ReturnsDataGridView.Columns.Item("ID").Visible = False
    End Sub

    Private Sub ReturnsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReturnsDataGridView.CellClick
        Try
            If ReturnsDataGridView.Rows.Count > 0 Then
                Dim selectedRows As DataGridViewSelectedRowCollection = ReturnsDataGridView.SelectedRows
                Dim row As DataGridViewRow = selectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                  {"ref", row.Cells(2).Value.ToString},
                  {"total", row.Cells(4).Value.ToString},
                  {"date", row.Cells(5).Value.ToString}
                }
                Dim dialog As New ReturnCartDialog(dat2:=data)
                dialog.AddReturnButton.Visible = False
                'dialog.ReturnDataGridView.Columns.Item("PID").Visible = False

                dialog.ReturnDataGridView.Rows.Clear()
                Dim DeliveryItems As DataTable = BaseReturn.SelectAllReturnById(row.Cells(0).Value.ToString)
                For Each i As DataRow In DeliveryItems.Rows
                    Dim rowData As New List(Of Object)()
                    For Each column As DataColumn In DeliveryItems.Columns
                        rowData.Add(i(column))
                    Next
                    dialog.ReturnDataGridView.Rows.Add(rowData.ToArray())
                Next


                dialog.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
