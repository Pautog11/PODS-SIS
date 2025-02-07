Imports System.Data.SqlClient

Public Class Inventory
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblinventoryTableAdapter
    Private ReadOnly _dataTable As New pods.viewtblinventoryDataTable
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        _tableAapter.Fill(_dataTable)
        InventoryDataGridView.DataSource = _dataTable
        'InventoryDataGridView.DataSource = BaseInventory.Inventory
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Try
            PrintButton.Enabled = False

            Using dialog As New InventoryReportsViewer()
                dialog.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error print report: {ex.Message}", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            PrintButton.Enabled = True
        End Try
        'Dim strsql As String = ""
        'Try
        '    If ProductDataGridView.SelectedRows.Count <> 0 Then
        '        For Each row As DataGridViewRow In ProductDataGridView.SelectedRows
        '            Dim prodID As String = row.Cells("").Value.ToString()
        '        Next
        '        strsql = "SELECT * FROM tblProducts"

        '        adp = New SqlClient.SqlDataAdapter(strsql, con)
        '        Dim a As New DSReport

        '        a.EnforceConstraints = True

        '        ProductDataGridView.DataSource =
        '        ProductDataGridView.AutoResizeColumns()
        '    Else
        '        MsgBox("Error!!")
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub
End Class
