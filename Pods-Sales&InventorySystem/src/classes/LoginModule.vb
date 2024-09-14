Imports System.Data.SqlClient
Public Class LoginModule
    Private _sqlConnection As SqlConnection = SqlConnectionPods.GetInstance
    Private _sqlCommand As SqlCommand
    Private _dataSet As DataTable
    Private _sqlAdapter As SqlDataAdapter

    Public Function LoginAccount(username As String, password As String) As Object()
        _sqlCommand = New SqlCommand("SELECT id, role_id, status_id, password FROM tblaccount WHERE username = @username", _sqlConnection)
        _sqlCommand.Parameters.AddWithValue("@username", username)
        _sqlAdapter = New SqlDataAdapter(_sqlCommand)
        _dataSet = New DataTable
        _sqlAdapter.Fill(_dataSet)

        If _dataSet.Rows.Count > 0 Then
            'If _dataSet.Rows(0)(2) = 1 Then
            If BCrypt.Net.BCrypt.Verify(password, _dataSet.Rows(0)(3)) Then
                If _dataSet.Rows(0)(2) = 1 Then
                    My.Settings.myId = _dataSet.Rows(0).Item("id")
                    My.Settings.Save()
                    Return {True}
                Else
                    Return {False, "Your account is deactivated"}
                End If
            Else
                Return {False, "Incorrect  username or password!"}
            End If
        Else
            Return {False, "Incorrect  username or password!"}
        End If
        Return {False, "Unknown error please try again."}
    End Function
End Class
