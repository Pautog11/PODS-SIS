﻿Imports System.Data.SqlClient
Public Class BaseSupplierReturnCode
    Inherits SqlBaseConnection
    Implements ICommandPanel

    Private ReadOnly _data As Dictionary(Of String, String)

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
    End Sub

    Public Sub Delete() Implements ICommandPanel.Delete
        'Throw New NotImplementedException()
    End Sub

    Public Sub Update() Implements ICommandPanel.Update
        Try
            _sqlCommand = New SqlCommand("UPDATE tblrrc SET code = @code, description = @description WHERE id = @id", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            _sqlCommand.Parameters.AddWithValue("@code", _data.Item("code"))
            _sqlCommand.Parameters.AddWithValue("@description", _data.Item("description"))

            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Return Code has been updated successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BaseAuditTrail.AuditLogin(My.Settings.myId, "Update a return code")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        Try
            _sqlCommand = New SqlCommand("INSERT INTO tblrrc (code, description) VALUES (@code, @description)", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@code", _data.Item("code"))
            _sqlCommand.Parameters.AddWithValue("@description", _data.Item("description"))

            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Return Code has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BaseAuditTrail.AuditLogin(My.Settings.myId, "Add a return code")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ''' <summary>
    ''' Check if existing
    ''' </summary>
    ''' <param name="code"></param>
    ''' <returns></returns>
    Public Shared Function Exists(code As String) As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblrrc WHERE LOWER(code) = @code", conn)
            cmd.Parameters.AddWithValue("@code", code.Trim.ToLower)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function


    Public Shared Function ExistsWithId(id As Integer, code As String) As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblrrc WHERE id = @id AND LOWER(code) = @code", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@code", code.Trim.ToLower)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function Search(query As String) As pods.viewtblrrcDataTable
        Try
            Dim conn As New SqlConnection(My.Settings.podsdbConnectionString)
            Dim cmd As New SqlCommand("SELECT * FROM viewtblrrc WHERE id <> 1 AND CODE LIKE CONCAT('%', @query, '%')", conn)
            cmd.Parameters.AddWithValue("@query", query)
            Dim dTable As New pods.viewtblrrcDataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New pods.viewtblrrcDataTable
        End Try
    End Function

    Public Shared Function FetchRrcByCode(code As String) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT id AS id, code AS code, CONCAT(code, ' ', '(', ' ', description, ' ', ')') AS codedes FROM tblrrc WHERE code = @code
                                       UNION ALL 
                                       SELECT id AS id, code AS code, CONCAT(code, ' ', '(', ' ', description, ' ', ')') AS codedes FROM tblrrc WHERE code != @code", conn)
            cmd.Parameters.AddWithValue("@code", code)
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