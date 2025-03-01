Imports System.Windows.Forms

Public Class PullOutCartDialog
    Private Sub PullOutCartDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddProduct_Click(sender As Object, e As EventArgs) Handles AddProduct.Click
        Dim dialog As New PullOutProductDialog
        dialog.ShowDialog()
    End Sub
End Class
