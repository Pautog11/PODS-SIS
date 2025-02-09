
Public Class Account
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblaccountsTableAdapter 'podsTableAdapters.tblaccountsTableAdapter
    Private _dataTable As New pods.viewtblaccountsDataTable 'pods.tblaccountsDataTable

    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        AccountsDataGridView.DataSource = _dataTable
        AccountsDataGridView.Columns.Item("ID").Visible = False
    End Sub

    Private Sub AddAccountButton_Click(sender As Object, e As EventArgs) Handles AddAccountButton.Click
        Dim Dialog As New AccountDialog(subject:=_subject)
        Dialog.ShowDialog()
    End Sub

    Private Sub AccountDataGridView_CellClick(sender As Object, e As EventArgs) Handles AccountsDataGridView.CellClick
        If AccountsDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRows As DataGridViewSelectedRowCollection = AccountsDataGridView.SelectedRows
            Dim row As DataGridViewRow = selectedRows(0)
            Dim full_name As String() = row.Cells(3).Value.ToString().ToString.Split(" ")
            Dim data As New Dictionary(Of String, String) From {
                {"id", row.Cells(0).Value.ToString()},
                {"role", BaseAccount.ScalarRoleName(row.Cells(1).Value.ToString())},'row.Cells(1).Value.ToString()},
                {"status", BaseAccount.ScalarStatusName(row.Cells(2).Value.ToString())},
                {"first_name", String.Join(" ", full_name.Take(full_name.Count - 1))},  '{"first_name", row.Cells(3).Value.ToString()}, 'row.Cells(3).Value.ToString()},
                {"last_name", full_name.Last}, 'row.Cells(4).Value.ToString()},'
                {"phone_number", row.Cells(4).Value.ToString()},
                {"address", row.Cells(5).Value.ToString()},
                {"username", row.Cells(6).Value.ToString()}
            }

            If My.Settings.roleId > BaseAccount.ScalarRoleName(row.Cells(1).Value.ToString()) Then
                MessageBox.Show("You cant edit this account.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim Dialog As New AccountDialog(data:=data, subject:=_subject)
                Dialog.Password2TextBox.Visible = False
                Dialog.Guna2CheckBox1.Visible = False
                Dialog.ShowDialog()
            End If
        End If
    End Sub
    Private Sub AccountSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles AccountSearchTextBox.TextChanged
        _dataTable = BaseAccount.Search(AccountSearchTextBox.Text)
        AccountsDataGridView.DataSource = _dataTable
    End Sub
End Class