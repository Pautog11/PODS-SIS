Imports System.Windows.Forms

Public Class DiposalProductDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _parent As DisposalCartDialog = Nothing
    Dim delivery_items_id As Integer = Nothing
    Dim product_id As Integer = Nothing

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional parent As DisposalCartDialog = Nothing)
        InitializeComponent()
        _data = data
        _parent = parent
    End Sub

    Private Sub DiposalProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As DataTable = BaseDisposal.SelectAllProducts
            DisposalDataGridView.DataSource = dt.DefaultView
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DisposalDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DisposalDataGridView.CellClick
        Try
            If DisposalDataGridView.Rows.Count > 0 AndAlso DisposalDataGridView.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = DisposalDataGridView.SelectedRows(0)
                delivery_items_id = row.Cells(0).Value?.ToString()
                product_id = row.Cells(2).Value?.ToString()
                ProductTextBox.Text = row.Cells(3).Value?.ToString()
                BatchNumberTextBox.Text = row.Cells(4).Value?.ToString()
                ExpiryDateTextBox.Text = row.Cells(5).Value?.ToString()
                CostTextBox.Text = row.Cells(6).Value?.ToString()
                StocksTextBox.Text = row.Cells(7).Value?.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PullOutProductSaveButton_Click(sender As Object, e As EventArgs) Handles PullOutProductSaveButton.Click

    End Sub
End Class
