Imports System.Data.SqlClient
Public Class BasePullouts
    Inherits SqlBaseConnection
    Implements ICommandPanel

    Private ReadOnly _data As Dictionary(Of String, String)
    Private _item As IList(Of Dictionary(Of String, String))

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
    End Sub
    Public Property Items() As IList(Of Dictionary(Of String, String))
        Set(value As IList(Of Dictionary(Of String, String)))
            _item = value
        End Set
        Get
            Return _item
        End Get
    End Property

    Public Sub Delete() Implements ICommandPanel.Delete
        'Throw New NotImplementedException()
    End Sub

    Public Sub Update() Implements ICommandPanel.Update
        'Throw New NotImplementedException()
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        'Dim transaction As SqlTransaction = SqlConnectionPods.GetInstance.BeginTransaction()
        Try
            For Each item In _item
                If item("from") = "Inventory" Then
                    MsgBox("inventory")
                End If

                If item("from") = "Returned" Then
                    MsgBox("returned")
                End If
            Next
            ' transaction.Commit()
        Catch ex As Exception
            'transaction.Rollback()
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ''' <summary>
    ''' Select all product by supplier
    ''' </summary>
    ''' <param name="supplier_id"></param>
    ''' <returns></returns>
    Public Shared Function AllProduct(supplier_id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("WITH 
	                                tite as (
		                                SELECT * FROM (
                                                        SELECT b.id AS ID,
															   a.id AS TRAN_ID,
                                                               'Inventory' AS 'FROM',
		                                                       delivery_number AS 'TRANSACTION', 
										                       c.id AS PID,
		                                                       product_name AS 'NAME', 
		                                                       batch_number AS 'BATCH NUMBER', 
		                                                       cost_price AS PRICE, 
		                                                       inventory_quantity AS QUANTITY,
		                                                       FORMAT(expiration_date, 'yyyy-MM-dd') AS 'EXPIRATION DATE',
		                                                       supplier_id AS SUPPLIER
	                                                     FROM tbldeliveries a
                                                         JOIN tbldeliveries_items b ON a.id = b.delivery_id
	                                                     JOIN tblproducts c ON b.product_id = c.id
	                                                     WHERE b.inventory_quantity != 0
	                                                     GROUP BY b.id, a.id, delivery_number, c.id, product_name, batch_number, cost_price, inventory_quantity, expiration_date, supplier_id

	                                                     UNION ALL 

	                                                     SELECT b.id AS ID,
																e.id AS TRAN_ID,
									                            'Returned' AS 'FROM',
		                                                        delivery_number AS 'TRANSACTION', 
										                        g.id AS PID,
		                                                        product_name AS 'NAME', 
		                                                        batch_number AS 'BATCH NUMBER', 
		                                                        cost_price AS PRICE, 
		                                                        remaining_quantity AS QUANTITY, 
		                                                        FORMAT(expiration_date, 'yyyy-MM-dd') AS 'EXPIRATION DATE', 
		                                                        supplier_id AS SUPPLIER
	                                                     FROM tblreturns a
	                                                     JOIN tblreturn_items b ON a.id = b.tblreturn_id
	                                                     JOIN tblproducts g ON b.product_id = g.id
	                                                     JOIN tbltransactions c ON a.transaction_id = c.id
	                                                     JOIN getrev d ON c.id = d.transaction_id
	                                                     JOIN tbldeliveries e ON d.delivery_id = e.id
	                                                     JOIN tbldeliveries_items f ON e.id = f.delivery_id
	                                                     WHERE b.remaining_quantity != 0
	                                                     GROUP BY b.id, 
																  e.id,
                                                                  delivery_number, 
                                                                  g.id, product_name, 
                                                                  batch_number, 
                                                                  cost_price, 
                                                                  remaining_quantity, 
                                                                  expiration_date, 
                                                                  supplier_id

                                                        ) AS combined_results
                                                        WHERE SUPPLIER = @supplier_id),

	                                                    price as (
		                                                    SELECT t1.product_id, t1.cost_price
		                                                    FROM tbldeliveries_items t1
		                                                    JOIN (
			                                                    SELECT product_id, MAX(id) AS latest_id
			                                                    FROM tbldeliveries_items
			                                                    GROUP BY product_id
		                                                    ) t2 ON t1.product_id = t2.product_id AND t1.id = t2.latest_id
	                                                    )

	                                                    SELECT a.ID, TRAN_ID, [FROM], [TRANSACTION], PID, NAME, [BATCH NUMBER], [EXPIRATION DATE], cost_price AS PRICE, QUANTITY, (cost_price * QUANTITY) AS TOTAL, SUPPLIER FROM tite a 
	                                                    JOIN price b ON a.PID = b.product_id", conn)
            cmd.Parameters.AddWithValue("@supplier_id", supplier_id)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    ''' <summary>
    ''' To fetch all return reason code
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function Rrc() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT id, CONCAT(code, ' ', '(', description, ')') AS code FROM tblrrc", conn)
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
