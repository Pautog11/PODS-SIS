Imports System.Data.SqlClient
Public Class BaseNotifications
    Public Shared Function CriticalLevel() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT CONCAT(product_name, ' is running out of stock.') FROM tblproducts a join viewtblinventory b ON a.id = b.ID WHERE a.critical_level > QUANTITY", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function Expiry() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT CONCAT(product_name, ' will be expire on ',expiration_date)
                                  FROM tbldeliveries_items a 
                                  JOIN tblproducts b ON a.product_id = b.id
                                  WHERE expiration_date BETWEEN GETDATE() AND DATEADD(MONTH, 6, GETDATE());", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
