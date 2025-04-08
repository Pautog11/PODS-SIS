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
        Dim transaction As SqlTransaction = SqlConnectionPods.GetInstance.BeginTransaction()
        Try
            _sqlCommand = New SqlCommand("INSERT INTO tbldeliverypullouts(account_id, supplier_id, vendor_id, reference_number, total, date) VALUES (@account_id, @supplier_id, @vendor_id, @reference_number, @total, @date); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@account_id", My.Settings.myId)
            _sqlCommand.Parameters.AddWithValue("@supplier_id", _data.Item("supplier_id"))
            _sqlCommand.Parameters.AddWithValue("@vendor_id", _data.Item("vendor_id"))
            _sqlCommand.Parameters.AddWithValue("@reference_number", _data.Item("reference_number"))
            _sqlCommand.Parameters.AddWithValue("@total", _data.Item("total"))
            _sqlCommand.Parameters.AddWithValue("@date", _data.Item("date"))

            Dim deliveryId As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())

            For Each item In _item
                If item IsNot Nothing AndAlso item.Count > 0 Then
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand = New SqlCommand("INSERT INTO tbldeliverypullout_items(deliverypullout_id, delivery_id, product_id, atp, batch_number, expiration_date, rrc_id, price, quantity) VALUES (@deliverypullout_id, @delivery_id, @product_id, @atp, @batch_number, @expiration_date, @rrc_id, @price, @quantity)", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@deliverypullout_id", deliveryId)
                    _sqlCommand.Parameters.AddWithValue("@delivery_id", item("tran_id"))
                    _sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
                    _sqlCommand.Parameters.AddWithValue("@atp", item("atp"))
                    _sqlCommand.Parameters.AddWithValue("@batch_number", item("batch_number"))
                    _sqlCommand.Parameters.AddWithValue("@expiration_date", item("expiration_date"))
                    _sqlCommand.Parameters.AddWithValue("@rrc_id", item("rrc_id"))
                    _sqlCommand.Parameters.AddWithValue("@price", item("price"))
                    _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))

                    If _sqlCommand.ExecuteNonQuery() <= 0 Then
                        Throw New Exception("An error occured!")
                    End If
                End If
            Next


            For Each item In _item
                If item("from") = "Inventory" Then
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand = New SqlCommand("UPDATE tbldeliveries_items SET inventory_quantity = inventory_quantity - @inventory_quantity WHERE id = @id", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@id", item("id"))
                    _sqlCommand.Parameters.AddWithValue("@inventory_quantity", item("quantity"))

                    If _sqlCommand.ExecuteNonQuery() <= 0 Then
                        Throw New Exception("An error occured!")
                    End If
                End If

                If item("from") = "Returned" Then
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand = New SqlCommand("UPDATE tblreturn_items SET remaining_quantity = remaining_quantity - @remaining_quantity WHERE id = @id", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@id", item("id"))
                    _sqlCommand.Parameters.AddWithValue("@remaining_quantity", item("quantity"))

                    If _sqlCommand.ExecuteNonQuery() <= 0 Then
                        Throw New Exception("An error occured!")
                    End If
                End If
            Next

            For Each item In _item
                If item("from") = "Returned" Then
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand = New SqlCommand("SELECT delivery_items_id from tblreturn_items a
                                                  JOIN tblreturns b ON a.tblreturn_id = b.id
                                                  JOIN tbltransactions c ON b.transaction_id = c.id
                                                  JOIN getrev d ON c.id = d.transaction_id
                                                  WHERE a.id = @return_id", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@return_id", item("id"))
                    'MsgBox(item("id"))
                    'MsgBox(item("id"))
                    '_sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
                    Dim result As Object = _sqlCommand.ExecuteScalar()
                    'MsgBox(result)
                    If result IsNot DBNull.Value Then
                        item("id") = result
                    Else
                        Throw New Exception("An error occured!")
                    End If
                    'MsgBox(result)
                End If
                _sqlCommand.Parameters.Clear()
                _sqlCommand = New SqlCommand("WITH 
                                                    oldprice AS (
                                                        SELECT delivery_id, product_id, cost_price 
                                                        FROM tbldeliveries_items 
                                                        WHERE product_id = @id AND id = @idngitems),
                                                    newprice AS (
                                                        SELECT product_id, cost_price 
                                                        FROM tbldeliveries_items 
                                                        WHERE id = (SELECT MAX(id) FROM tbldeliveries_items WHERE product_id = @id) 
                                                        AND product_id = @id)
                                                    INSERT INTO tblpullout_revenue (refference_number, product_id, quantity, old, new, total)
                                                    SELECT a.delivery_id,
                                                           a.product_id, 
                                                           @quantity,
                                                           a.cost_price AS old, 
                                                           b.cost_price AS new, 
                                                           (b.cost_price - a.cost_price) AS rev 
                                                    FROM oldprice a
                                                    JOIN newprice b ON a.product_id = b.product_id;", _sqlConnection, transaction)

                'MsgBox(item("product_id"))
                'MsgBox(item("id"))
                'MsgBox(item("quantity"))
                _sqlCommand.Parameters.AddWithValue("@id", item("product_id"))
                'MsgBox(item("id"))
                _sqlCommand.Parameters.AddWithValue("@idngitems", item("id"))
                _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))

                'If _sqlCommand.ExecuteNonQuery() <= 0 Then
                '    Throw New Exception("An error occured!")
                'End If
                If _sqlCommand.ExecuteNonQuery() <= 0 Then
                    Throw New Exception()
                End If

            Next
            transaction.Commit()
            MessageBox.Show("Pullout has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'transaction.Rollback()
        Catch ex As Exception
            transaction.Rollback()
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
	                                                     JOIN getrev d ON d.transaction_id = a.transaction_id
	                                                     JOIN tbldeliveries e ON d.delivery_id = e.id
	                                                     JOIN tbldeliveries_items f ON e.id = f.delivery_id AND f.product_id = b.product_id
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
            cmd = New SqlCommand("SELECT id, CONCAT(code, ' ', '(', description, ')') AS codedes, code AS code FROM tblrrc", conn)
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
    ''' To get id the return reason code
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function SupplierIdRrc(code As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT id FROM tblrrc WHERE LOWER(code) = @code", conn)
            cmd.Parameters.AddWithValue("@code", code.Trim.ToLower)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function InventoryQuantity(id As Integer) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT inventory_quantity FROM tbldeliveries_items WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function ReturnedQuantity(id As Integer) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT remaining_quantity FROM tblreturn_items WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function GetDelivery_items_idBy_Return_id(id As Integer, product_id As Integer) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("select delivery_items_id from tblreturn_items a
                                        join tblreturns b on a.tblreturn_id = b.id
                                        join tbltransactions c on b.transaction_id = c.id
                                        join getrev d on c.id = d.transaction_id
                                        WHERE a.tblreturn_id = @return_id and a.product_id = @product_id", conn)
            cmd.Parameters.AddWithValue("@return_id", id)
            cmd.Parameters.AddWithValue("@product_id", product_id)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function Search(query As String) As pods.viewtbldeliverypulloutsDataTable
        Try
            Dim conn As New SqlConnection(My.Settings.podsdbConnectionString)
            Dim cmd As New SqlCommand("SELECT * FROM viewtbldeliverypullouts WHERE id <> 1 AND [REFERENCE NUMBER] LIKE CONCAT('%', @query, '%') OR [PROCESS BY] LIKE CONCAT('%', @query, '%')", conn)
            cmd.Parameters.AddWithValue("@query", query)
            Dim dTable As New pods.viewtbldeliverypulloutsDataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New pods.viewtbldeliverypulloutsDataTable
        End Try
    End Function

    Public Shared Function FetchPulloutItems(id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT a.id, 
                                         delivery_id, 
                                         a.product_id, 
                                         c.delivery_number, 
                                         product_name, 
                                         atp, 
                                         expiration_date, 
                                         batch_number, 
                                         (SELECT code FROM tblrrc WHERE id = rrc_id), 
                                         price, 
                                         quantity, 
                                         (price * quantity) as total
                                  FROM tbldeliverypullout_items a
                                  JOIN tblproducts b ON a.product_id = b.id
                                  JOIN tbldeliveries c ON a.delivery_id = c.id
                                  WHERE a.deliverypullout_id = @id", conn)
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
End Class
