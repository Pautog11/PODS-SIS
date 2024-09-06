Public Class Account
    Implements IObserverPanel
    Private _subject As IObservablePanel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        'Application.Current.Windows.OfType(Of Dashboard).FirstOrDefault
        ' Add any initialization after the InitializeComponent() call.
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error")
        End Try
    End Sub

    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Filldatagridview()
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        Filldatagridview()
    End Sub

    Public Sub Filldatagridview()
        AccountDataGridView.DataSource = BaseAccount.Accounts.DefaultView
    End Sub

    Private Sub AddAccountButton_Click(sender As Object, e As EventArgs) Handles AddAccountButton.Click
        'AccountDialog.Show()

        Dim Dialog As New AccountDialog(subject:=_subject)
        Dialog.StartPosition = FormStartPosition.CenterParent
        Dialog.ShowDialog(Me)

        'AccountDialog.Show(New AccountDialog().ActiveMdiChild)
        'AccountDialog.Show(New AccountDialog().MdiParent)
    End Sub
End Class
