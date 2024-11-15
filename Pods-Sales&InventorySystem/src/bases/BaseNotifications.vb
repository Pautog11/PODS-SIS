Imports System.Data.SqlClient
Public Class BaseNotifications
    Public Shared Function CriticalLevel() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT concat('Your product ',product_name,' ', 'is running out of stock') FROM tblproducts WHERE quantity <= stock_level", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function Expiry() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT concat('Your product ', b.product_name, ' will be expire on ', a.exd)
                                    FROM tblproduct_notif a join tblproducts b on a.product_id = b.id 
                                    WHERE exd >= DATEADD(MONTH, -1, CAST(GETDATE() AS DATE)) 
                                      AND exd < DATEADD(MONTH, 1, CAST(GETDATE() AS DATE));", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
