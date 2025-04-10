Imports System.Data.SqlClient

Public Class BaseDosage
    Inherits SqlBaseConnection
    Implements ICommandPanel
    Private ReadOnly _data As Dictionary(Of String, String)

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
    End Sub

    Public Sub Delete() Implements ICommandPanel.Delete
        Throw New NotImplementedException()
    End Sub

    Public Sub Update() Implements ICommandPanel.Update
        Try
            _sqlCommand = New SqlCommand("UPDATE tbldosage SET dasage = @dasage, description = @description WHERE id = @id", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@dasage", _data.Item("dosage"))
            _sqlCommand.Parameters.AddWithValue("@description", _data.Item("description"))
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Dosage has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BaseAuditTrail.AuditLogin(My.Settings.myId, "Update dosage form")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        Try
            _sqlCommand = New SqlCommand("INSERT INTO tbldosage (dasage, description) VALUES (@dosage, @description)", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@dosage", _data.Item("dosage"))
            _sqlCommand.Parameters.AddWithValue("@description", _data.Item("description"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Dosage has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Shared Function FetchDosage() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT * FROM tbldosage", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    Public Shared Function ScalarDose(data As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tbldosage where lower(dasage) = @sa", conn)
            cmd.Parameters.AddWithValue("@sa", data.Trim.ToLower)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function ScalarDoseWithId(id As Integer, data As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tbldosage WHERE id = @id AND LOWER(dasage) = @sa", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@sa", data.Trim.ToLower)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Search query
    ''' </summary>
    ''' <param name="query"></param>
    ''' <returns></returns>
    Public Shared Function Search(query As String) As pods.viewtbldosageDataTable
        Try
            Dim conn As New SqlConnection(My.Settings.podsdbConnectionString)
            Dim cmd As New SqlCommand("SELECT * FROM viewtbldosage WHERE id <> 1 AND DOSAGE LIKE CONCAT('%', @query, '%')", conn)
            cmd.Parameters.AddWithValue("@query", query)
            Dim dTable As New pods.viewtbldosageDataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New pods.viewtbldosageDataTable
        End Try
    End Function
End Class
