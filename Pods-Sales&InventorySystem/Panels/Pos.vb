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

    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
        Using dialog As New TransactionCartDailog
            dialog.ShowDialog()
        End Using
    End Sub
End Class
