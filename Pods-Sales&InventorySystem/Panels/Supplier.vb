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
        Try
            _tableAapter.Fill(_dataTable)
            SupplierDataGridView.DataSource = _dataTable
            SupplierDataGridView.Columns.Item("ID").Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddSupplierButton_Click(sender As Object, e As EventArgs) Handles AddSupplierButton.Click
        Dim dialog As New SupplierDialog(subject:=_subject)
        dialog.ShowDialog()
    End Sub

    Private Sub AccountDataGridView_Click(sender As Object, e As EventArgs) Handles SupplierDataGridView.CellClick
        Try
            If SupplierDataGridView.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = SupplierDataGridView.SelectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                    {"id", row.Cells(0).Value.ToString()},
                    {"company_name", row.Cells(1).Value.ToString()},
                    {"company_contact_number", row.Cells(2).Value.ToString()},
                    {"company_address", row.Cells(3).Value.ToString()}
                }
                Dim Dialog As New SupplierDialog(data:=data, subject:=_subject)
                Dialog.ShowDialog()
            End If

            'Dim full_name As String() = row.Cells(4).Value.ToString().ToString.Split(" ")
            '{"first_name", String.Join(" ", full_name.Take(full_name.Count - 1))},
            '{"last_name", full_name.Last},
            '{"phone_number", row.Cells(5).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CategorySearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles CategorySearchTextBox.TextChanged
        Try
            _dataTable = BaseSupplier.Search(CategorySearchTextBox.Text)
            SupplierDataGridView.DataSource = _dataTable
        Catch ex As Exception

        End Try
    End Sub
End Class
