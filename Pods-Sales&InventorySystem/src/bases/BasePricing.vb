Imports System.Data.SqlClient

Public Class BasePricing
    Inherits SqlBaseConnection
    Implements ICommandPanel

    Private ReadOnly _data As Dictionary(Of String, String)

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
    End Sub

    Public Sub Delete() Implements ICommandPanel.Delete

    End Sub

    Public Sub Update() Implements ICommandPanel.Update
        Try
            _sqlCommand = New SqlCommand("UPDATE tbldeliveries_items SET price_adjusment = @selling_price WHERE id = @id", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@selling_price", _data.Item("selling_price"))
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!")
            Else
                MessageBox.Show("Price has been updated successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BaseAuditTrail.AuditLogin(My.Settings.myId, "Update price")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub Add() Implements ICommandPanel.Add

    End Sub

    ''' <summary>
    ''' For pricing
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function Pricing() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("WITH cost_price AS (
                                        SELECT a.id, a.product_id, b.product_name, a.cost_price
                                        FROM tbldeliveries_items a
                                        JOIN tblproducts b ON a.product_id = b.id
                                        WHERE a.inventory_quantity != 0
                                          AND a.cost_price = (SELECT MAX(b2.cost_price)
                                                              FROM tbldeliveries_items b2
                                                              WHERE b2.product_id = a.product_id and b2.inventory_quantity != 0)
                                    )
                                    SELECT 
                                        b.id AS ID, 
                                        a.product_name AS NAME, 
                                        b.price_adjusment AS 'SELLING PRICE',
                                        c.cost_price AS 'COST PRICE'
                                    FROM tblproducts a
                                    JOIN tbldeliveries_items b ON a.id = b.product_id
                                    JOIN cost_price c ON a.id = c.product_id
                                    WHERE b.inventory_quantity != 0
                                    AND b.id = (SELECT MAX(b2.id) 
                                                  FROM tbldeliveries_items b2 
                                                  WHERE b2.product_id = b.product_id)
									GROUP BY b.id, a.product_name, b.price_adjusment, c.cost_price
                                    ORDER BY b.id DESC", conn)
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