Imports System.Data.SqlClient
Public Class LoginModule
    Private _sqlConnection As SqlConnection = SqlConnectionPods.GetInstance
    Private _sqlCommand As SqlCommand
    Private _dataSet As DataTable
    Private _sqlAdapter As SqlDataAdapter

    Public Function LoginAccount(username As String, password As String) As Object()
        _sqlCommand = New SqlCommand("SELECT id, role_id, status_id, password WHERE username = @username", _sqlConnection)
        _sqlCommand.Parameters.AddWithValue("@username", username)
        _sqlAdapter = New SqlDataAdapter(_sqlCommand)
        _dataSet = New DataTable
        _sqlAdapter.Fill(_dataSet)

        If _dataSet.Rows.Count > 0 Then
            Return {True}
            MsgBox("meron")
        Else
            Return {False}
            MsgBox("wala")
        End If
        Return {False, "Unknown error please try again."}
    End Function
End Class
