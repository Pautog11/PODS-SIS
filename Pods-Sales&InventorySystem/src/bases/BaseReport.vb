Imports System.Data.SqlClient
Public Class BaseReport
    Public Shared Function FinancialReportView(startDate As DateTime, endDate As DateTime) As DataSet
        'Public Shared Function FillByRoles() As DataTable
        Try
            Dim conn As New SqlConnection(My.Settings.podsdbConnectionString)
            Dim cmd As New SqlCommand("WITH FUCK AS (
                                                SELECT id AS ID,
                                                       NAME AS CASHIER, 
                                                       [TRANSACTION NUMBER] AS 'transaction_number', 
                                                       CAPITAL,
                                                       DISCOUNT,
                                                    REVENUE, 
                                                    TOTAL, 
                                                    FORMAT(date, 'MMM dd yyyy h:mm tt') AS 'DATE'
                                                 FROM viewtblrevenue

                                                 UNION ALL

                                                 SELECT a.id, 
                                                        CONCAT(b.first_name, ' ', b.last_name) AS cashier,
                                                        c.transaction_number, 
                                                     NULL AS CAPITAL,
                                                     NULL AS DISCOUNT,
                                                        NULL AS REVENUE,
                                                     -1 * a.total, 
                                                     FORMAT(a.date, 'MMM dd yyyy h:mm tt') AS 'DATE'
                                                  FROM tblreturns a
                                                  JOIN tblaccounts b ON a.account_id = b.id
                                                  JOIN tbltransactions c ON a.transaction_id = c.id
                                                  )
                                            SELECT *, FORMAT(@startDate, 'MMM dd yyyy') AS start_date, FORMAT(@endDate, 'MMM dd yyyy') AS end_date FROM FUCK 
                                            WHERE CAST(date AS DATE) BETWEEN @startDate AND @endDate;", conn)
            cmd.Parameters.AddWithValue("@startDate", startDate)
            cmd.Parameters.AddWithValue("@endDate", endDate)
            Dim dTable As New DataSet
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable, "DT_FinancialReport")
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataSet
        End Try
    End Function

    Public Shared Function PulloutReportView(startDate As DateTime, endDate As DateTime) As DataSet
        Try
            Dim conn As New SqlConnection(My.Settings.podsdbConnectionString)
            Dim cmd As New SqlCommand("select c.delivery_number as delivery_number, 
                                              b.product_name as name, a.old as old, a.new as new, a.total as totalngpullout, c.date as date from tblpullout_revenue a 
                                        join tblproducts b on a.product_id = b.id
                                        JOIN tbldeliveries c ON a.refference_number = c.id", conn)
            cmd.Parameters.AddWithValue("@startDate", startDate)
            cmd.Parameters.AddWithValue("@endDate", endDate)
            Dim dTable As New DataSet
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable, "DT_PulloutReport")
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataSet
        End Try
    End Function
End Class