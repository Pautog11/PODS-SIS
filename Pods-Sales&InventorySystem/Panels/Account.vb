
Public Class Account
    Implements IObserverPanel
    Private _subject As IObservablePanel

    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error")
        End Try
        AccountDataGridView.DataSource = BaseAccount.Accounts.DefaultView()
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        AccountDataGridView.DataSource = BaseAccount.Accounts.DefaultView()
    End Sub

    Private Sub AddAccountButton_Click(sender As Object, e As EventArgs) Handles AddAccountButton.Click
        Dim Dialog As New AccountDialog(subject:=_subject)
        Dialog.ShowDialog()
        'MsgBox(My.Settings.myid)
    End Sub

    Private Sub AccountDataGridView_Click(sender As Object, e As EventArgs) Handles AccountDataGridView.Click
        If AccountDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRows As DataGridViewSelectedRowCollection = AccountDataGridView.SelectedRows
            Dim row As DataGridViewRow = selectedRows(0)
            Dim data As New Dictionary(Of String, String) From {
                {"id", row.Cells(0).Value.ToString()},
                {"role", BaseAccount.ScalarRoleName(row.Cells(1).Value.ToString())},'row.Cells(1).Value.ToString()},
                {"status", row.Cells(2).Value.ToString()},
                {"first_name", row.Cells(3).Value.ToString()},
                {"middle_name", row.Cells(4).Value.ToString()},
                {"last_name", row.Cells(5).Value.ToString()},
                {"phone_number", row.Cells(6).Value.ToString()},
                {"address", row.Cells(7).Value.ToString()},
                {"username", row.Cells(8).Value.ToString()},
                {"password", row.Cells(9).Value.ToString()}
            }
            Dim AccountDialog As New AccountDialog(data:=data)
            AccountDialog.ShowDialog()
        End If
    End Sub
    Private Sub AccountSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles AccountSearchTextBox.TextChanged
        AccountDataGridView.DataSource = BaseAccount.Search(AccountSearchTextBox.Text).DefaultView
    End Sub
End Class