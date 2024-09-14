Imports System.Data.SqlClient

Public Class BaseCategory
    Inherits SqlBaseConnection
    Implements ICommandPanel

    Public Sub Delete() Implements ICommandPanel.Delete
        Throw New NotImplementedException()
    End Sub

    Public Sub Update() Implements ICommandPanel.Update
        Throw New NotImplementedException()
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        Throw New NotImplementedException()
    End Sub

    Public Shared Function Search(query As String) As pods.tblcategoryDataTable
        Try
            Dim conn As New SqlConnection(My.Settings.podsdbConnectionString)
            Dim cmd As New SqlCommand("SELECT * FROM tblcategory WHERE id <> 1 AND category LIKE CONCAT('%', @query, '%')", conn)
            cmd.Parameters.AddWithValue("@query", query)
            Dim dTable As New pods.tblcategoryDataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return New pods.tblcategoryDataTable
        End Try
    End Function
End Class
