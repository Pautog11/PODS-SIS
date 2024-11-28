Imports System.Data.SqlClient

Public Class BaseAuditTrail
    Public Shared Function AuditLogin(account_id As Integer, action As String)
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("INSERT INTO tblaudittrail (account_id, action) VALUES (@account_id, @action)", conn)
            cmd.Parameters.AddWithValue("@account_id", account_id)
            cmd.Parameters.AddWithValue("@action", action)
            If cmd.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!")
            End If
            Return Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function
End Class
