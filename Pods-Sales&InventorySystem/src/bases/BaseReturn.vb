﻿Imports System.Data.SqlClient
Public Class BaseReturn
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
        Throw New NotImplementedException()
    End Sub

    Public Sub Update() Implements ICommandPanel.Update
        Throw New NotImplementedException()
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        Dim transaction As SqlTransaction = SqlConnectionPods.GetInstance.BeginTransaction()
        Try
            ' Prepare and execute the main delivery insertion
            _sqlCommand = New SqlCommand("INSERT INTO tblreturns (account_id, transaction_id, reason, total) VALUES (@account_id, @transaction_id, @reason, @total); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@account_id", _data.Item("account_id"))
            _sqlCommand.Parameters.AddWithValue("@transaction_id", _data.Item("transaction_id"))
            _sqlCommand.Parameters.AddWithValue("@reason", _data.Item("reason"))
            _sqlCommand.Parameters.AddWithValue("@total", _data.Item("total"))

            Dim deliveryId As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())

            For Each item In _item
                If item IsNot Nothing AndAlso item.Count > 0 Then
                    ' Insert into tbldeliveries_items
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand = New SqlCommand("INSERT INTO tblreturn_items (tblreturn_id, product_id, price, quantity, remaining_quantity) VALUES (@tblreturn_id, @product_id, @price, @quantity, @remaining_quantity); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@tblreturn_id", deliveryId)
                    _sqlCommand.Parameters.AddWithValue("@product_id", item("id"))
                    _sqlCommand.Parameters.AddWithValue("@price", item("price"))
                    _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                    _sqlCommand.Parameters.AddWithValue("@remaining_quantity", item("quantity"))

                    If _sqlCommand.ExecuteNonQuery <= 0 Then
                        Throw New Exception("Failed to add return items!")
                    End If
                End If
            Next

            transaction.Commit()
            MessageBox.Show("Return has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Shared Function SelectTransactionbyTransaction_id(transaction_id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            'cmd = New SqlCommand("SELECT b.id, 
            '                             b.product_name as name, 
            '                             a.price, 
            '                             a.quantity
            '                      FROM tbltransaction_items a
            '                      JOIN tblproducts b ON b.id = a.product_id
            '                      WHERE transaction_id = @transaction_id", conn)

            ' cmd = New SqlCommand("SELECT c.id,
            '                              product_name AS name, 
            'price AS 'orignal_price',
            '                              (price - ((price / subtotal) * (subtotal * (discount/100)))) AS price, 
            '                              quantity 
            '                       FROM tbltransactions a
            '                       JOIN tbltransaction_items b ON a.id = b.transaction_id 
            '                       JOIN tblproducts c ON b.product_id = c.id
            '                       WHERE a.id = @transaction_id", conn)
            cmd = New SqlCommand("WITH
	                                price AS (SELECT TOP 1 product_id, price FROM tbldeliveries_items GROUP BY product_id, price ORDER BY price DESC)
								    SELECT c.id,
                                            product_name AS name, 
									        d.price as 'orignal_price',
                                            (b.price - ((b.price / subtotal) * (subtotal * (discount/100)))) AS price, 
                                            quantity as quantity
                                    FROM tbltransactions a
                                    JOIN tbltransaction_items b ON a.id = b.transaction_id
                                    JOIN tblproducts c ON b.product_id = c.id
							        JOIN price d ON d.product_id = c.id
                                    WHERE a.id = @transaction_id", conn)
            cmd.Parameters.AddWithValue("@transaction_id", transaction_id)
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
    ''' fetch to see all returned items by retuned id
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Shared Function SelectAllReturnById(id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            '  cmd = New SqlCommand("SELECT a.id,
            '                               product_name, 
            '                               price, 
            '                               quantity,
            '                        SUM(price * quantity) as total
            '                        FROM tblreturn_items a
            '                        JOIN tblproducts b on b.id = a.product_id
            '                        WHERE tblreturn_id = @transaction_id
            '                        GROUP BY a.id, 
            '                                 tblreturn_id, 
            '                                 b.product_name, 
            '                                 price, 
            '                                 quantity", conn)
            cmd = New SqlCommand("WITH
	                                price AS (SELECT TOP 1 product_id, price FROM tbldeliveries_items GROUP BY product_id, price ORDER BY price DESC)
	                                SELECT a.id, 
                                         product_name,
										 c.price as 'orig_price',
                                         a.price, 
                                         a.quantity,
										 (a.quantity * a.price) as total
                                  FROM tblreturn_items a
                                  JOIN tblproducts b on b.id = a.product_id
								  JOIN price c ON c.product_id = b.id
                                  WHERE tblreturn_id = @transaction_id
								  GROUP BY a.id,
										   b.id,
										   c.price,
                                           tblreturn_id, 
                                           b.product_name, 
                                           a.price, 
                                           a.quantity", conn)
            cmd.Parameters.AddWithValue("@transaction_id", id)
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
    ''' Fetch all items to bring back to inventory
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Shared Function SelectAllReturnedByID(id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT a.id, b.id as product_id, product_name, quantity_remaining FROM tblreturn_items a
                                  JOIN tblproducts b ON a.product_id = b.id WHERE a.id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)
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
    ''' To select the returned product
    ''' </summary>
    ''' <param name="transaction_number"></param>
    ''' <param name="product_id"></param>
    ''' <returns></returns>
    Public Shared Function SelectProductReturnedByTrasaction(transaction_number As String, product_id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            'cmd = New SqlCommand("SELECT product_id, product_name, price, quantity FROM tbltransactions a 
            '                      JOIN tbltransaction_items b ON a.id = b.transaction_id 
            '                      JOIN tblproducts c ON b.product_id = c.id
            '                      WHERE transaction_number = @transaction_number AND product_id = @product_id", conn)
            cmd = New SqlCommand("SELECT product_id, product_name, (price - ((price / subtotal) * (subtotal * (discount/100)))) AS price, quantity FROM tbltransactions a 
                                  JOIN tbltransaction_items b ON a.id = b.transaction_id 
                                  JOIN tblproducts c ON b.product_id = c.id
                                  WHERE transaction_number = @transaction_number AND product_id = @product_id", conn)
            cmd.Parameters.AddWithValue("@transaction_number", transaction_number)
            cmd.Parameters.AddWithValue("@product_id", product_id)
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
    ''' Fetch the product returned
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Shared Function SelectProductReturned(id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            '  cmd = New SqlCommand("SELECT c.id, 
            '                               product_name, 
            '                               b.price, 
            '                               remaining_quantity, 
            '                               batch_number, 
            '                               FORMAT(expiration_date, 'MMM dd yyyy') AS expiration_date, 
            '                               d.delivery_id 
            '                        FROM tblreturns a
            '                        JOIN tblreturn_items b ON a.id = b.tblreturn_id
            '                        JOIN tblproducts c ON b.product_id = c.id
            '                        JOIN getrev d ON a.transaction_id = d.transaction_id
            '                        JOIN tbldeliveries_items e ON d.delivery_id = e.delivery_id AND c.id = e.product_id
            '                        WHERE b.id = @id
            'GROUP BY c.id, product_name, b.price, remaining_quantity, batch_number, expiration_date, d.delivery_id", conn)
            cmd = New SqlCommand("WITH
	                                price AS (SELECT TOP 1 product_id, price FROM tbldeliveries_items GROUP BY product_id, price ORDER BY price DESC)
	                                SELECT c.id, 
                                           product_name, 
                                           f.price, 
										   remaining_quantity, 
										   batch_number, 
							               FORMAT(expiration_date, 'yyyy-MM-dd') AS expiration_date, 
										   d.delivery_id 
									 FROM tblreturns a
                                     JOIN tblreturn_items b ON a.id = b.tblreturn_id
									 JOIN tblproducts c ON b.product_id = c.id
									 JOIN price f ON f.product_id = c.id
									 JOIN getrev d ON a.transaction_id = d.transaction_id
									 JOIN tbldeliveries_items e ON d.delivery_id = e.delivery_id AND c.id = e.product_id
									 WHERE b.id = @id
									 GROUP BY c.id, 
                                              product_name, 
                                              f.price, 
                                              remaining_quantity, 
                                              batch_number, 
                                              expiration_date, 
                                              d.delivery_id", conn)
            cmd.Parameters.AddWithValue("@id", id)
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
    ''' To add items on item deliveries
    ''' </summary>
    ''' <param name="_data"></param>
    ''' <returns></returns>
    Public Shared Function Update_deliveries(_data)
        Dim transaction As SqlTransaction = SqlConnectionPods.GetInstance.BeginTransaction()
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("UPDATE tbldeliveries_items SET inventory_quantity = inventory_quantity + @inventory_quantity 
                                  WHERE delivery_id = @delivery_id AND 
                                        product_id = @product_id AND 
                                        batch_number = @batch_number AND 
                                        expiration_date = @expiration_date", conn, transaction)
            cmd.Parameters.AddWithValue("@inventory_quantity", _data.item("inventory_quantity"))
            cmd.Parameters.AddWithValue("@delivery_id", _data.item("delivery_id"))
            cmd.Parameters.AddWithValue("@product_id", _data.item("product_id"))
            cmd.Parameters.AddWithValue("@batch_number", _data.item("batch_number"))
            cmd.Parameters.AddWithValue("@expiration_date", _data.item("expiration_date"))

            'If String.IsNullOrEmpty(_data.item("batch_number").ToString()) Then
            '    cmd.Parameters.AddWithValue("@batch_number", DBNull.Value)
            'Else
            '    cmd.Parameters.AddWithValue("@batch_number", _data.item("batch_number"))
            'End If

            'If String.IsNullOrEmpty(_data.item("expiration_date").ToString()) Then
            '    cmd.Parameters.AddWithValue("@expiration_date", DBNull.Value)
            'Else
            '    cmd.Parameters.AddWithValue("@expiration_date", _data.item("expiration_date"))
            'End If

            If cmd.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If






            cmd.Parameters.Clear()
            cmd = New SqlCommand("UPDATE tblreturn_items SET remaining_quantity = remaining_quantity - @remaining_quantity WHERE id = @id", conn, transaction)
            cmd.Parameters.AddWithValue("@remaining_quantity", _data.item("inventory_quantity"))
            cmd.Parameters.AddWithValue("@id", _data.item("id"))

            If cmd.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            transaction.Commit()
            Return Nothing
        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End Try
    End Function
End Class
