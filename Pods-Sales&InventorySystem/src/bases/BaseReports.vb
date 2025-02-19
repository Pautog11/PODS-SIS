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

    Public Shared Function Getsales(date1 As Date, date2 As Date) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT CONCAT(a.first_name, ' ', a.last_name) AS CASHIER,
                                   t.transaction_number AS TRANSACTION#,
                                   t.date AS DATE
                                   FROM tbltransactions t
                                   JOIN tblaccounts a ON t.account_id = a.id
                                   WHERE t.date BETWEEN @start_date AND @end_date", conn)
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
End Class
