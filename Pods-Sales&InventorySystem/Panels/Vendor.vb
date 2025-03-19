Public Class Vendor
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblvendorTableAdapter
    Private _dataTable As New pods.viewtblvendorDataTable

    Private Sub Vendor_Load(sender As Object, e As EventArgs) Handles Me.Load
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
            VendorDataGridView.DataSource = _dataTable
            VendorDataGridView.Columns.Item("ID").Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddVendorButton_Click(sender As Object, e As EventArgs) Handles AddVendorButton.Click
        Try
            Using dialog As New VendorDialog(subject:=_subject)
                dialog.ShowDialog()
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VendorDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles VendorDataGridView.CellClick
        Try
            If VendorDataGridView.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = VendorDataGridView.SelectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                    {"id", row.Cells(0).Value.ToString()},
                    {"company", row.Cells(1).Value.ToString()},
                    {"first_name", row.Cells(2).Value.ToString()},
                    {"last_name", row.Cells(3).Value.ToString()},
                    {"contact_number", row.Cells(4).Value.ToString()}
                }
                Using dialog As New VendorDialog(data:=data, subject:=_subject)
                    dialog.ShowDialog()
                End Using
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
