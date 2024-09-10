
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
        Dim Dialog As New AccountDialog(subject:=_subject) With {
            .StartPosition = FormStartPosition.CenterParent}
        Dialog.ShowDialog()
    End Sub

    Private Sub AccountDataGridView_Click(sender As Object, e As EventArgs) Handles AccountDataGridView.Click

        If AccountDataGridView.SelectedRows.Count > 0 Then
            Dim selected As DataGridViewRow = AccountDataGridView.SelectedRows(0)
            Dim cellValue As Object = selected.Cells("id").Value
            Dim a As New AccountDialog(a:=cellValue)
            a.Show()

            '===================================
            'Dim cols As IList(Of DataGridView) = AccountDataGridView.SelectedCells()
            ''Dim full_name As String() = cols.Item(0).Item(1).ToString.Split(" ")
            'Dim data As New Dictionary(Of String, String) From {
            '    {"id", }
            'Dim a As New AccountDialog(data, _subject)
            'a.Show()
        End If
    End Sub
End Class
