Imports System.Data.SqlClient
Public Class BaseNotifications
    Public Shared Function CriticalLevel() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT concat(product_name,' ', quantity) FROM tblproducts WHERE quantity < stock_level", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
