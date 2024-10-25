Imports System.Windows.Forms

Public Class PulloutCartDialog
    Private Sub PulloutCartDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        'Dim parent As DeliveryCartDialog = CType(Me.Owner, DeliveryCartDialog)  ' Cast Owner to ParentForm
        'If parent IsNot Nothing Then
        '    ' Now you can access properties or methods of the parent form
        '    Me.Hide()
        '    parent.Show()  ' Call a method from the parent form
        'End If
    End Sub
End Class
