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
            '    Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            '    Dim cmd As SqlCommand

            '    'If SalesReportComboBox.Text = "All" Then
            '    '    cmd = New SqlCommand("SELECT * FROM tbltransactions", conn)
            '    'Else
            '    cmd = New SqlCommand("SELECT 
            '                                th.transaction_number AS TRANSACTION#, 
            '                                CONCAT(ac.last_name, ' ', ac.first_name) AS CASHIER,  
            '                                SUM(ti.total) AS TOTAL, 
            '                                th.date AS DATE, 
            '                                SUM((ti.price - di.cost_price) * ti.quantity) AS REVENUE
            '                            FROM 
            '                                tbldeliveries_items di
            '                            JOIN 
            '                                tbltransaction_items ti ON di.id = ti.delivery_id
            '                            JOIN 
            '                                tbltransactions th ON ti.transaction_id = th.id
            '                            JOIN 
            '                                tblaccounts ac ON th.account_id = ac.id
            '                            WHERE 
            '                                th.date BETWEEN @start_date AND @end_date
            '                            GROUP BY 
            '                                th.transaction_number, 
            '                                ac.first_name, 
            '                                ac.last_name, 
            '                                th.date", conn)
            '    cmd.Parameters.AddWithValue("@start_date", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            '    cmd.Parameters.AddWithValue("@end_date", DateTimePicker2.Value.ToString("yyyy-MM-dd"))
            '    'End If
            '    Dim dTable As New DataTable
            '    Dim adapter As New SqlDataAdapter(cmd)
            '    adapter.Fill(dTable)
            '    FinancialReportsDataGridView.DataSource = dTable
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'End Try



            'Try
            '    Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            '    Dim cmd As SqlCommand
            '    cmd = New SqlCommand("DECLARE @StartDate DATETIME = '2024-11-17 00:00:00';
            '                        DECLARE @EndDate DATETIME = '2025-11-17 23:59:59';

            '                        SELECT 
            '                            t.id AS TransactionID,
            '                            t.transaction_number,
            '                            t.date AS TransactionDate,
            '                            SUM(ti.total) AS TotalTransactionAmount,
            '                            SUM((ti.price - p.product_cost) * ti.quantity) AS TotalRevenue
            '                        FROM tbltransactions t
            '                        INNER JOIN tbltransaction_items ti ON t.id = ti.transaction_id
            '                        INNER JOIN tblproducts p ON ti.product_id = p.id
            '                        WHERE t.date BETWEEN @StartDate AND @EndDate
            '                        GROUP BY t.id, t.transaction_number, t.date
            '                        ORDER BY t.date;", conn)
            '    Dim dTable As New DataTable
            '    Dim adapter As New SqlDataAdapter(cmd)
            '    adapter.Fill(dTable)
            '    'Return dTable
            '    FinancialReportsDataGridView.DataSource = dTable.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'Return New DataTable
        End Try
    End Sub

    Private Sub FilteredData_Click(sender As Object, e As EventArgs) Handles FilteredData.Click
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            'If SalesReportComboBox.Text = "All" Then
            '    cmd = New SqlCommand("SELECT * FROM tbltransactions", conn)
            'Else
            cmd = New SqlCommand("SELECT 
                                        th.transaction_number AS TRANSACTION#, 
                                        CONCAT(ac.last_name, ' ', ac.first_name) AS CASHIER,  
                                        SUM(ti.total) AS TOTAL, 
                                        th.date AS DATE, 
                                        SUM((ti.price - di.cost_price) * ti.quantity) AS REVENUE
                                    FROM 
                                        tbldeliveries_items di
                                    JOIN 
                                        tbltransaction_items ti ON di.id = ti.delivery_id
                                    JOIN 
                                        tbltransactions th ON ti.transaction_id = th.id
                                    JOIN 
                                        tblaccounts ac ON th.account_id = ac.id
                                    WHERE 
                                        th.date BETWEEN @start_date AND @end_date
                                    GROUP BY 
                                        th.transaction_number, 
                                        ac.first_name, 
                                        ac.last_name, 
                                        th.date", conn)
            cmd.Parameters.AddWithValue("@start_date", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@end_date", DateTimePicker2.Value.ToString("yyyy-MM-dd"))
            'End If
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            FinancialReportsDataGridView.DataSource = dTable
        Catch ex As Exception
            MessageBox.Show($"Error filtering data: {ex.Message}", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Try
            PrintButton.Enabled = False

            Dim startDate As DateTime = DateTimePicker1.Value.ToString("yyyy-MM-dd")
            Dim endDate As DateTime = DateTimePicker2.Value.ToString("yyyy-MM-dd")

            Using dialog As New FinancialReportViewer(startDate, endDate)
                dialog.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error Print report: {ex.Message}", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            PrintButton.Enabled = True
        End Try
    End Sub
End Class
