Imports System.Data.SqlClient

Public Class BaseLoginStatus
    Public Shared Function Login() As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("INSERT INTO tbllogin_status (my_id) VALUES (@my_id)", conn)
            cmd.Parameters.AddWithValue("@my_id", My.Settings.myId)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function Logout() As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("DELETE tbllogin_status WHERE my_id = @my_id", conn)
            cmd.Parameters.AddWithValue("@my_id", My.Settings.myId)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function Status() As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tbllogin_status WHERE my_id = @my_id", conn)
            cmd.Parameters.AddWithValue("@my_id", My.Settings.myId)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function
End Class