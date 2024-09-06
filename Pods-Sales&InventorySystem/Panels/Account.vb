Imports System.Data.SqlClient

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
        Dialog.StartPosition = FormStartPosition.CenterParent
        Dialog.ShowDialog()
    End Sub

    Private Sub AccountDataGridView_Click(sender As Object, e As EventArgs) Handles AccountDataGridView.Click
        MessageBox.Show("sample")
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
