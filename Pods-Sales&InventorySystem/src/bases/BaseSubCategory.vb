Imports System.Data.SqlClient
Public Class BaseSubCategory
    Inherits SqlBaseConnection
    Implements ICommandPanel
    Private ReadOnly _data As Dictionary(Of String, String)

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
    End Sub

    Public Sub Delete() Implements ICommandPanel.Delete
        Try
            _sqlCommand = New SqlCommand("DELETE tblsubcategories WHERE id = @id", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Account has been deleted successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub Update() Implements ICommandPanel.Update
        Try
            _sqlCommand = New SqlCommand("UPDATE tblsubcategories SET category_id = @category_id, subcategory = @subcategory, description = @description WHERE id = @id", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            _sqlCommand.Parameters.AddWithValue("@category_id", _data.Item("category_id"))
            _sqlCommand.Parameters.AddWithValue("@subcategory", _data.Item("subcategory"))
            _sqlCommand.Parameters.AddWithValue("@description", _data.Item("description"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Account has been updated successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        Try
            _sqlCommand = New SqlCommand("INSERT INTO tblsubcategories (category_id, subcategory, description) VALUES (@category_id, @subcategory, @description)", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@category_id", _data.Item("category_id"))
            _sqlCommand.Parameters.AddWithValue("@subcategory", _data.Item("subcategory"))
            _sqlCommand.Parameters.AddWithValue("@description", _data.Item("description"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Account has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Shared Function FillByCategory() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT * FROM tblcategories", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    Public Shared Function ScalarsCategoryName(category As String) As Integer
        Try

            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT id FROM tblcategories WHERE category = @category", conn)
            cmd.Parameters.AddWithValue("@category", category)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function FetchCategory(id As Integer) As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT category FROM tblcategories WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function Exists(subcategory As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblsubcategories WHERE lower(subcategory) = @subcategory", conn)
            cmd.Parameters.AddWithValue("@subcategory", subcategory.Trim.ToLower)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function FetchSubCategory(category_id As String) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT id, subcategory FROM tblsubcategories WHERE category_id = @category_id", conn)
            cmd.Parameters.AddWithValue("@category_id", category_id)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    Public Shared Function CategoryAndSubcategoryExists(id As Integer, subcategory As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            'Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblsubcategories WHERE lower(subcategory) = @subcategory", conn)
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblsubcategories WHERE category_id = @category_id AND lower(subcategory) = @subcategory", conn)
            cmd.Parameters.AddWithValue("@category_id", id)
            cmd.Parameters.AddWithValue("@subcategory", subcategory.Trim.ToLower)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function
End Class