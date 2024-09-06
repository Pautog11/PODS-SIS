Imports System.Data.SqlClient

Public Class BaseAccount

    Public Shared Function ScalarAccount() As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblaccount", conn)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error")
            Return 0
        End Try
    End Function

    Public Shared Function Accounts() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT id as 'ID', concat(first_name,' ',last_name) as 'Fullname' FROM tblaccount", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return New DataTable
        End Try
    End Function
End Class
