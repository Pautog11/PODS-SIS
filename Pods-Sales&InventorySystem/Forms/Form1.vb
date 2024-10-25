Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim msg As DialogResult = MessageBox.Show("Meron bang expiry date?", "PODS", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If msg = DialogResult.Yes Then
            Dim a As New DatePickerDialog
            a.Show()
        Else
            Return
        End If
    End Sub
End Class