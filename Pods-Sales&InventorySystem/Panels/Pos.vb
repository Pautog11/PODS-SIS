Public Class Pos
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private Sub Pos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        Reference_number.Text = Helpers.GenInvoiceNumber(InvoiceType.Transaction)
        Datepurchased.Text = DateAndTime.Now.ToString("F")
    End Sub

    Private Sub Pos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            MsgBox("pressed")
        End If
    End Sub
End Class
