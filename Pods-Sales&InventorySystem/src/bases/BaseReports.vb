Imports System.Data.SqlClient
Public Class BaseReports
    Public Shared Function FetchAccount() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("select id, concat(first_name, ' ', last_name)as name from tblaccounts", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    Public Shared Function Getsales() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            'cmd = New SqlCommand("SELECT CONCAT(a.first_name, ' ', a.last_name) AS CASHIER,
            '                       t.transaction_number AS TRANSACTION#,
            '                       t.date AS DATE
            '                       FROM tbltransactions t
            '                       JOIN tblaccounts a ON t.account_id = a.id
            '                       WHERE t.date BETWEEN @start_date AND @end_date", conn)
            cmd = New SqlCommand("SELECT a.id, 
                                                  CONCAT(first_name, ' ', last_name) AS cashier, 
                                                  transaction_number, 
                                                  total, 
                                                  a.date
                                           FROM tbltransactions a 
                                           JOIN tblaccounts b ON a.account_id = b.id 
                                           -- WHERE CAST(a.date AS DATE) >= @startDate
                                           -- AND CAST(a.date AS DATE) <= @endDate
   
                                           UNION ALL
 
                                          SELECT a.transaction_id, 
                                                 CONCAT(first_name, ' ', last_name) AS cashier, 
                                                 transaction_number, 
                                                 -1 * a.total, a.date
                                          FROM tblreturns a
                                          JOIN tbltransactions b ON a.transaction_id = b.id
                                          JOIN tblaccounts c ON a.account_id = c.id
                                          WHERE a.transaction_id IN (SELECT id FROM tbltransactions) 
                                                -- AND CAST(a.date AS DATE) >= @startDate
                                                -- AND CAST(a.date AS DATE) <= @endDate
                                          ORDER BY transaction_number, 
                                                   total DESC;", conn)
            'cmd.Parameters.AddWithValue("@start_date", date1)
            'cmd.Parameters.AddWithValue("@end_date", date2)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    Public Shared Function GetSalesByDate(date1 As Date, date2 As Date) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT a.id, 
                                                  CONCAT(first_name, ' ', last_name) AS cashier, 
                                                  transaction_number, 
                                                  total, 
                                                  a.date
                                           FROM tbltransactions a 
                                           JOIN tblaccounts b ON a.account_id = b.id 
                                           WHERE CAST(a.date AS DATE) >= @start_date
                                           AND CAST(a.date AS DATE) <= @end_date
   
                                           UNION ALL
 
                                          SELECT a.transaction_id, 
                                                 CONCAT(first_name, ' ', last_name) AS cashier, 
                                                 transaction_number, 
                                                 -1 * a.total, a.date
                                          FROM tblreturns a
                                          JOIN tbltransactions b ON a.transaction_id = b.id
                                          JOIN tblaccounts c ON a.account_id = c.id
                                          WHERE a.transaction_id IN (SELECT id FROM tbltransactions) 
                                                AND CAST(a.date AS DATE) >= @start_date
                                                AND CAST(a.date AS DATE) <= @end_date
                                          ORDER BY transaction_number, 
                                                   total DESC;", conn)
            cmd.Parameters.AddWithValue("@start_date", date1)
            cmd.Parameters.AddWithValue("@end_date", date2)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    Public Shared Function GetSalesChart(year As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT FORMAT(date, 'MMM') AS Month, 
                                     FORMAT(SUM(total), 'N2') AS Sales
                              FROM tbltransactions
                              WHERE YEAR(date) = @Year
                              GROUP BY FORMAT(date, 'MMM'), DATEPART(MONTH, date)
                              ORDER BY DATEPART(MONTH, date);", conn)
            cmd.Parameters.AddWithValue("@Year", year)

            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function
End Class
