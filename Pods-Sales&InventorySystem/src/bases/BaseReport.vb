Imports System.Data.SqlClient
Public Class BaseReport
    Public Shared Function FinancialReportView(startDate As DateTime, endDate As DateTime) As DataSet
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
            Dim cmd As New SqlCommand("SELECT c.delivery_number AS delivery_number, 
                                              b.product_name AS name, 
											  a.quantity,
                                              a.old AS old, 
                                              a.new AS new, 
                                              (a.total * a.quantity) AS totalngpullout, 
                                              FORMAT(a.date, 'MMM dd yyyy h:mm tt') AS 'date'
                                        FROM tblpullout_revenue a 
                                        JOIN tblproducts b ON a.product_id = b.id
                                        JOIN tbldeliveries c ON a.refference_number = c.id
                                        WHERE a.date BETWEEN @startDate AND @endDate;", conn)
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

    Public Shared Function GetDisposalByDate(date1 As DateTime, date2 As DateTime) As DataSet
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT reference_number as reference_number, 
                                         CONCAT(first_name, ' ', last_name) as name, 
                                         -1 * total as total,  
                                         FORMAT(date, 'MMM dd yyyy h:mm tt') AS 'date'
                                  FROM tbldisposal a
                                  JOIN tblaccounts b ON a.account_id = b.id 
                                  WHERE a.date BETWEEN @startDate AND @endDate;", conn)
            cmd.Parameters.AddWithValue("@startDate", date1)
            cmd.Parameters.AddWithValue("@endDate", date2.AddDays(+1))
            Dim dTable As New DataSet
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable, "DT_DisposalReport")
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataSet
        End Try
    End Function

    'Public Shared Function SalesReport(selectedDate As DateTime, cashierName As String) As DataSet
    '    Try
    '        Dim conn As SqlConnection = SqlConnectionPods.GetInstance
    '        Dim cmd As SqlCommand
    '        cmd = New SqlCommand("SELECT CONCAT(a.first_name, ' ', a.last_name) AS cashier,
    '                                              t.transaction_number,
    '                                              t.total AS total,
    '                                              t.date AS DATE,
    '                                              CONVERT(TIME, t.date) AS time
    '                                       FROM tbltransactions t
    '                                       JOIN tblaccounts a ON t.account_id = a.id
    '                                       WHERE CONVERT(DATE, t.date) = @startDate AND t.account_id = @cashierNameCmb

    '                                       UNION ALL

    '                                       SELECT CONCAT(first_name, ' ', last_name) AS 'cashier', 
    '                                              transaction_number, 
    '                                              -1 * a.total as total, 
    '                                              a.date, 
    '                                              CONVERT(TIME, a.date) AS time
    '                                       FROM tblreturns a 
    '                                       JOIN tbltransactions b on a.transaction_id = b.id
    '                                       JOIN tblaccounts c on a.account_id = c.id
    '                                       WHERE a.account_id = @cashierNameCmb AND CONVERT(DATE, a.date) = @startDate", conn)
    '        cmd.Parameters.AddWithValue("@startDate", selectedDate)
    '        cmd.Parameters.AddWithValue("@cashierNameCmb", cashierName)
    '        Dim dTable As New DataSet
    '        Dim adapter As New SqlDataAdapter(cmd)
    '        adapter.Fill(dTable, "DT_DisposalReport")
    '        Return dTable
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return New DataSet
    '    End Try
    'End Function
End Class