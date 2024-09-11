
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
    End Sub

    Private Sub AccountDataGridView_Click(sender As Object, e As EventArgs) Handles AccountDataGridView.Click
        If AccountDataGridView.SelectedRows.Count > 0 Then
            Dim selected As DataGridViewRow = AccountDataGridView.SelectedRows(0)
            Dim cellValue As Object = selected.Cells("id").Value
            Dim a As New AccountDialog(id:=cellValue)
            a.ShowDialog()
        End If
    End Sub
End Class
