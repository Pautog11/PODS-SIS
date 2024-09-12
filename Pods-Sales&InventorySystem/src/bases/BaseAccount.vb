Imports System.Data.SqlClient

Public Class BaseAccount
    Inherits SqlBaseConnection
    Implements ICommandPanel

    Private ReadOnly _data As Dictionary(Of String, String)

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
    End Sub

    Public Sub Delete() Implements ICommandPanel.Delete
        Try
            _sqlCommand = New SqlCommand("DELETE tblaccount WHERE id = @id", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@id", "id")
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!")
            Else
                MessageBox.Show("Account has been deleted successfully!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Update() Implements ICommandPanel.Update
        Throw New NotImplementedException()
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        Try
            _sqlCommand = New SqlCommand("INSERT INTO tblaccount (role_id, first_name, middle_name, last_name, phone_number, address, username, password) VALUES (@role_id, @first_name, @middle_name, @last_name, @phone_number, @address, @username, @password)", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@role_id", _data.Item("role_id"))
            _sqlCommand.Parameters.AddWithValue("@first_name", _data.Item("first_name"))
            _sqlCommand.Parameters.AddWithValue("@middle_name", _data.Item("middle_name"))
            _sqlCommand.Parameters.AddWithValue("@last_name", _data.Item("last_name"))
            _sqlCommand.Parameters.AddWithValue("@phone_number", _data.Item("phone_number"))
            _sqlCommand.Parameters.AddWithValue("@address", _data.Item("address"))
            _sqlCommand.Parameters.AddWithValue("@username", _data.Item("username"))
            _sqlCommand.Parameters.AddWithValue("@password", _data.Item("password"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!")
            Else
                MessageBox.Show("Account has been updated successfully!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

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
            cmd = New SqlCommand("SELECT * from tblaccount", conn)
            '       a.id, 
            '       b.role, 
            '       c.status, 
            '       first_name, 
            '       middle_name, 
            '       last_name, 
            '       phone_number, 
            '       address, 
            '       username, 
            '       password, 
            '       date_updated 
            'FROM tblaccount a 
            'JOIN tblrole b ON a.role_id = b.id 
            'JOIN tblaccount_status c ON c.id = a.status_id", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return New DataTable
        End Try
    End Function

    'Public Shared Function FetchRole(id As String) As String
    '    Try
    '        Dim conn As SqlConnection = SqlConnectionPods.GetInstance
    '        Dim cmd As New SqlCommand("SELECT role FROM tblrole WHERE id = @id", conn)
    '        cmd.Parameters.AddWithValue("@id", id)

    '        Return cmd.ExecuteScalar()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '        Return Nothing
    '    End Try
    'End Function

    Public Shared Function ScalarRoleName(rolename As String) As Integer
        Try

            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT id FROM tblrole WHERE role = @role", conn)
            cmd.Parameters.AddWithValue("@role", rolename)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return 0
        End Try
    End Function

    Public Shared Function FillByRoles() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT * FROM tblrole", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return New DataTable
        End Try
    End Function

    Public Shared Function Exists(data As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblaccount WHERE lower(username) = @data", conn)
            cmd.Parameters.AddWithValue("@data", data.Trim.ToLower)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return 0
        End Try
    End Function
End Class
