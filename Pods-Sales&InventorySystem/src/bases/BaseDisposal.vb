Imports System.Data.SqlClient
Public Class BaseDisposal
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
        Throw New NotImplementedException()
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        Throw New NotImplementedException()
    End Sub

    Public Shared Function SelectAllProducts() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT a.id as devitemsid AS DEVITEMSID, 
                                         b.id as devid AS DEVID, 
                                         c.id as pid AS PID, 
                                         product_name AS NAME, 
                                         batch_number AS 'BATCH NUMBER', 
                                         FORMAT(expiration_date, 'yyyy-MM-dd') AS 'EXPIRATION DATE',
                                         cost_price AS 'COST PRICE',
                                         inventory_quantity AS INVENTORY
                                  FROM tbldeliveries_items a
                                  JOIN tbldeliveries b ON a.delivery_id = b.id
                                  JOIN tblproducts c ON c.id = a.product_id
                                  WHERE inventory_quantity != 0", conn)
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