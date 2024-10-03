Imports System.Data.SqlClient

Public Class Delivery
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private Sub DeliveryCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        'Throw New NotImplementedException()
    End Sub

    Private Sub AddDeliveryButton_Click(sender As Object, e As EventArgs) Handles AddDeliveryButton.Click
        Dim dialog As New DeliveryCartDialog
        dialog.ShowDialog()
    End Sub
End Class
