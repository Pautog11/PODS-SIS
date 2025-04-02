Public Class Disposal
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private Sub Disposal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update

    End Sub

    Private Sub AddDisposalButton_Click(sender As Object, e As EventArgs) Handles AddDisposalButton.Click
        Dim dialog As New DisposalCartDialog(subject:=_subject)
        dialog.ShowDialog()
    End Sub
End Class
