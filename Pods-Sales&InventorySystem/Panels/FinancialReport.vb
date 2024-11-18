Imports System.Data.SqlClient

Public Class FinancialReport
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private Sub FinancialReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("DECLARE @StartDate DATETIME = '2024-11-17 00:00:00';
                                DECLARE @EndDate DATETIME = '2025-11-17 23:59:59';

                                SELECT 
                                    t.id AS TransactionID,
                                    t.transaction_number,
                                    t.date AS TransactionDate,
                                    SUM(ti.total) AS TotalTransactionAmount,
                                    SUM((ti.price - p.product_cost) * ti.quantity) AS TotalRevenue
                                FROM tbltransactions t
                                INNER JOIN tbltransaction_items ti ON t.id = ti.transaction_id
                                INNER JOIN tblproducts p ON ti.product_id = p.id
                                WHERE t.date BETWEEN @StartDate AND @EndDate
                                GROUP BY t.id, t.transaction_number, t.date
                                ORDER BY t.date;", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            'Return dTable
            FinancialReportsDataGridView.DataSource = dTable.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'Return New DataTable
        End Try
    End Sub
End Class
