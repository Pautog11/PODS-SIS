Imports System.Data.SqlClient
Public Class BaseDiscount
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
            _sqlCommand = New SqlCommand("UPDATE tbldiscounts SET discount = @discount, description = @description WHERE id = @id", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@discount", _data.Item("discount"))
            _sqlCommand.Parameters.AddWithValue("@description", _data.Item("description"))
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Discount has been updated successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BaseAuditTrail.AuditLogin(My.Settings.myId, "Update discount")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        Try
            _sqlCommand = New SqlCommand("INSERT INTO tbldiscounts (discount, description) VALUES (@discount, @description)", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@discount", _data.Item("discount"))
            _sqlCommand.Parameters.AddWithValue("@description", _data.Item("description"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Discount has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BaseAuditTrail.AuditLogin(My.Settings.myId, "Add discount")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Shared Function Exists(discount As Integer) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT count(*) FROM tbldiscounts WHERE discount = @discount", conn)
            cmd.Parameters.AddWithValue("@discount", discount)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function IdExists(id As Integer, discount As Integer) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT count(*) FROM tbldiscounts WHERE id = @id and discount = @discount", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@discount", discount)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function FetchDiscount(id As Integer) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT discount FROM tbldiscounts WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function
End Class
