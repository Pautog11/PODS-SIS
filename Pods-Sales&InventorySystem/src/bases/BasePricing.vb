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
            cmd = New SqlCommand("WITH max_cost_price AS (
                                        SELECT 
                                            a.product_id,
                                            MAX(a.cost_price) AS cost_price
                                        FROM tbldeliveries_items a
                                        WHERE a.inventory_quantity != 0
                                        GROUP BY a.product_id
                                    ),
                                    latest_delivery AS (
                                        SELECT 
                                            a.product_id,
                                            MAX(a.id) AS latest_delivery_id
                                        FROM tbldeliveries_items a
                                        WHERE a.inventory_quantity != 0
                                        GROUP BY a.product_id
                                    )
                                    SELECT 
                                        d.id AS ID,
                                        p.product_name AS NAME,
                                        d.price_adjusment AS 'SELLING PRICE',
                                        m.cost_price AS 'COST PRICE'
                                    FROM latest_delivery l
                                    JOIN tbldeliveries_items d ON d.id = l.latest_delivery_id
                                    JOIN tblproducts p ON p.id = d.product_id
                                    JOIN max_cost_price m ON m.product_id = d.product_id
                                    ORDER BY d.product_id;", conn)
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