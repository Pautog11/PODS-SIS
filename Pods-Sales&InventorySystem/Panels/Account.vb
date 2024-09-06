Public Class Account
    Implements IObserverPanel
    Private _subject As IObservablePanel

    Public Sub New()

        InitializeComponent()

        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error")
        End Try

    End Sub

    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccountDataGridView.DataSource = BaseAccount.Accounts.DefaultView()
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        AccountDataGridView.DataSource = BaseAccount.Accounts.DefaultView()
    End Sub

    Private Sub AddAccountButton_Click(sender As Object, e As EventArgs) Handles AddAccountButton.Click
        'Windows.Forms.Show(New AccountDialog(subject:=_subject))

        Dim Dialog As New AccountDialog(subject:=_subject)
        Dialog.StartPosition = FormStartPosition.CenterParent
        Dialog.ShowDialog()

        'AccountDialog.Show(New AccountDialog().ActiveMdiChild)
        'AccountDialog.Show(New AccountDialog().MdiParent)

    End Sub

    Private Sub AccountDataGridView_Click(sender As Object, e As EventArgs) Handles AccountDataGridView.Click
        MessageBox.Show("sample")
    End Sub
End Class
