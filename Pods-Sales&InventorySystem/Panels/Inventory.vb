Imports System.Data.SqlClient

Public Class Inventory
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblinventoriesTableAdapter
    Private ReadOnly _dataTable As New pods.viewtblinventoriesDataTable
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
        'Dim dt As New DataTable
        'Try
        '    Using conn As New SqlConnection(My.Settings.con)
        '        conn.Open()
        '        'Dim cmd As New SqlCommand("SELECT  di.id ID, p.barcode BARCODE, p.product_name 'PRODUCT NAME', di.price PRICE, di.cost_price 'COST PRICE', quantity_trans QUANTITY FROM tblproducts p JOIN tbldeliveries_items di ON p.id = di.product_id", conn)
        '        Dim cmd As New SqlCommand("SELECT
        '                                    product_id,
        '                                 p.product_name,
        '                                    p.quantity,
        '                                 (SELECT TOP 1 price 
        '                                     FROM tbldeliveries_items t2 
        '                                     WHERE t1.product_id = t2.product_id 
        '                                     ORDER BY id DESC) AS latest_price,
        '                                    (SELECT TOP 1 cost_price 
        '                                     FROM tbldeliveries_items t2 
        '                                     WHERE t1.product_id = t2.product_id 
        '                                     ORDER BY id DESC) AS latest_cost_price
        '                                FROM tbldeliveries_items t1 join tblproducts p on t1.product_id = p.id
        '                                GROUP BY product_id, p.product_name, p.quantity;", conn)
        '        Dim adapter As New SqlDataAdapter(cmd)
        '        adapter.Fill(dt)
        '        ProductDataGridView.DataSource = dt
        '    End Using
        'Catch ex As Exception

        'End Try
        ProductDataGridView.DataSource = _dataTable
        ProductDataGridView.Columns.Item("ID").Visible = False
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
