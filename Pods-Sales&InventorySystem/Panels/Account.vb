
Public Class Account
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private _tableAapter As New podsTableAdapters.viewtblaccountsTableAdapter 'podsTableAdapters.tblaccountsTableAdapter
    Private _dataTable As New pods.viewtblaccountsDataTable 'pods.tblaccountsDataTable

    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error")
        End Try

    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        _tableAapter.Fill(_dataTable)
        AccountsDataGridView.DataSource = _dataTable
    End Sub

    Private Sub AddAccountButton_Click(sender As Object, e As EventArgs) Handles AddAccountButton.Click
        Dim Dialog As New AccountDialog(subject:=_subject)
        Dialog.ShowDialog()
    End Sub

    Private Sub AccountDataGridView_Click(sender As Object, e As EventArgs) Handles AccountsDataGridView.Click
        If AccountsDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRows As DataGridViewSelectedRowCollection = AccountsDataGridView.SelectedRows
            Dim row As DataGridViewRow = selectedRows(0)
            'Dim full_name As String() = row.Cells(3).Value.ToString().ToString.Split(" ")
            Dim data As New Dictionary(Of String, String) From {
                {"id", row.Cells(0).Value.ToString()},
                {"role", BaseAccount.ScalarRoleName(row.Cells(1).Value.ToString())},'row.Cells(1).Value.ToString()},
                {"status", BaseAccount.ScalarStatusName(row.Cells(2).Value.ToString())},
                {"first_name", row.Cells(3).Value.ToString()},'String.Join(" ", full_name.Take(full_name.Count - 1))},  '{"first_name", row.Cells(3).Value.ToString()},
                {"last_name", row.Cells(4).Value.ToString()},'full_name.Last},
                {"phone_number", row.Cells(5).Value.ToString()},
                {"address", row.Cells(6).Value.ToString()},
                {"username", row.Cells(7).Value.ToString()}
            }
            Dim AccountDialog As New AccountDialog(data:=data, subject:=_subject)
            AccountDialog.ShowDialog()
        Else
            MsgBox("no selected")
        End If

        'If AccountDataGridView.SelectedRows.Count > 0 Then
        '    Dim a As New AccountDialog(_subject, AccountDataGridView.SelectedRows(0))
        '    a.Show()
        'End If
    End Sub
    Private Sub AccountSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles AccountSearchTextBox.TextChanged
        _dataTable = BaseAccount.Search(AccountSearchTextBox.Text)
        AccountsDataGridView.DataSource = _dataTable
    End Sub
End Class