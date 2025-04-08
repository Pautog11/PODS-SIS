Imports System.Data.SqlClient

Public Class Pricing
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Dim dt As DataTable
    Private Sub Pricing_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        Try
            dt = BasePricing.Pricing
            'If dt.Rows.Count > 0 Then
            '    PricingDataGridView.DataSource = dt.DefaultView
            '    PricingDataGridView.Columns.Item("ID").Visible = False
            'End If

            If dt.Rows.Count > 0 Then
                'PreviousPulloutDataGridView.DataSource = dt.DefaultView
                PricingDataGridView.Rows.Clear()
                For Each i As DataRow In dt.Rows

                    Dim rowData As Object() = i.ItemArray

                    ' Add the row to the DataGridView
                    PricingDataGridView.Rows.Add(rowData)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PricingDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PricingDataGridView.CellClick
        Try
            If PricingDataGridView.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = PricingDataGridView.SelectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                    {"id", row.Cells(0).Value.ToString()},
                    {"name", row.Cells(1).Value.ToString()},
                    {"selling_price", row.Cells(2).Value.ToString()},
                    {"cost_price", row.Cells(3).Value.ToString()}
                }
                Using dialog As New PricingDialog(data:=data, subject:=_subject)
                    dialog.ShowDialog()
                End Using
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProductSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductSearchTextBox.TextChanged
        Try
            If dt IsNot Nothing Then
                Dim dv As DataView = dt.DefaultView
                dv.RowFilter = String.Format("NAME LIKE '%{0}%'", ProductSearchTextBox.Text.Trim().Replace("'", "''"))

                PricingDataGridView.DataSource = dv
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
