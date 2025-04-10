Imports System.Data.SqlClient
Public Class LoginModule
    Private _sqlConnection As SqlConnection = SqlConnectionPods.GetInstance
    Private _sqlCommand As SqlCommand
    Private _dataSet As DataTable
    Private _sqlAdapter As SqlDataAdapter

    Public Function LoginAccount(username As String, password As String) As Object()
        _sqlCommand = New SqlCommand("SELECT id, role_id, status_id, password FROM tblaccounts WHERE username = @username COLLATE Latin1_General_BIN", _sqlConnection)
        _sqlCommand.Parameters.AddWithValue("@username", username)
        _sqlAdapter = New SqlDataAdapter(_sqlCommand)
        _dataSet = New DataTable
        _sqlAdapter.Fill(_dataSet)

        My.Settings.roleId = ""
        My.Settings.myId = ""
        My.Settings.Save()

        If _dataSet.Rows.Count > 0 Then
            If BCrypt.Net.BCrypt.Verify(password, _dataSet.Rows(0)(3).ToString()) Then
                If _dataSet.Rows(0)(2) = 1 Then
                    My.Settings.myId = _dataSet.Rows(0).Item("id").ToString()
                    My.Settings.roleId = _dataSet.Rows(0).Item("role_id").ToString()
                    My.Settings.Save()

                    BaseAuditTrail.AuditLogin(My.Settings.myId, "Login")
                    Return {True}
                Else
                    MessageBox.Show("Your account is deactivated!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return {False}
                End If
            Else
                MessageBox.Show("Incorrect username or password!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return {False}
            End If
        Else
            MessageBox.Show("Incorrect username or password!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return {False}
        End If

        Return {False, "Unknown error please try again.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information}

    End Function
End Class
