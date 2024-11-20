Imports System.Data.SqlClient

Public Class Inventory
    Implements IObserverPanel
    Private _subject As IObservablePanel
    'Private ReadOnly _tableAapter As New podsTableAdapters.viewtblinventoriesTableAdapter
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
        '_tableAapter.Fill(_dataTable)
        Dim dt As New DataTable
        Try
            Using conn As New SqlConnection(My.Settings.con)
                conn.Open()
                Dim cmd As New SqlCommand("SELECT  di.id ID, p.barcode BARCODE, p.product_name 'PRODUCT NAME', di.price PRICE, di.cost_price 'COST PRICE', quantity_trans QUANTITY FROM tblproducts p JOIN tbldeliveries_items di ON p.id = di.product_id", conn)
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        Catch ex As Exception

        End Try
        ProductDataGridView.DataSource = dt
        ProductDataGridView.Columns.Item("ID").Visible = False
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
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
