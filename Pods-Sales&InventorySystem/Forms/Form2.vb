Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pods.viewtblcategories' table. You can move, or remove it, as needed.
        Me.ViewtblcategoriesTableAdapter.Fill(Me.Pods.viewtblcategories)
        'TODO: This line of code loads data into the 'Pods.viewtblvat' table. You can move, or remove it, as needed.
        'Me.ViewtblvatTableAdapter.Fill(Me.Pods.viewtblvat)
    End Sub

    Private Sub PulloutDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PulloutDataGridView.CellContentClick
        If PulloutDataGridView.SelectedRows.Count > 0 Then
            Dim selectedData = PulloutDataGridView.Columns.Cast(Of DataGridViewColumn)().
                      ToDictionary(Function(c) c.HeaderText,
                                   Function(c) If(PulloutDataGridView.SelectedRows(0).Cells(c.Index).Value?.ToString(), "NULL"))
            Dim dialog As New Dialog1(selectedData, Me)
            dialog.ShowDialog()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        MsgBox(Guna2DateTimePicker1.Value)
        MsgBox(Guna2DateTimePicker1.Value.ToString("MMM dd yyyy"))
        'MsgBox(Guna2DateTimePicker1.CustomFormat = "yyyy-MM-dd")

    End Sub
End Class