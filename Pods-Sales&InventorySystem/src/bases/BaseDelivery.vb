Imports System.Data.SqlClient

Public Class BaseDelivery
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
        Dim transaction As SqlTransaction = SqlConnectionPods.GetInstance.BeginTransaction()
        Try
            ' Prepare and execute the main delivery insertion
            _sqlCommand = New SqlCommand("UPDATE tbldeliveries SET delivery_number = @delivery_number, account_id = @account_id, supplier_id = @supplier_id, vendor_id = @vendor_id, total = @total, date = @date WHERE id = @id;", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            _sqlCommand.Parameters.AddWithValue("@delivery_number", _data.Item("delivery_number"))
            _sqlCommand.Parameters.AddWithValue("@account_id", My.Settings.myId)
            _sqlCommand.Parameters.AddWithValue("@supplier_id", _data.Item("supplier_id"))
            _sqlCommand.Parameters.AddWithValue("@vendor_id", _data.Item("vendor_id"))
            _sqlCommand.Parameters.AddWithValue("@total", _data.Item("total"))
            _sqlCommand.Parameters.AddWithValue("@date", _data.Item("date"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            For Each item In _item
                If item IsNot Nothing AndAlso item.Count > 0 Then
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand = New SqlCommand("WITH 
                                                 Total_deducted AS (
                                                     SELECT SUM(quantity) AS bought 
                                                     FROM getrev 
                                                     WHERE delivery_id = @id AND product_id = @product_id)

                                                 UPDATE a SET product_id = @product_id, 
                                                              price = @price, 
                                                              cost_price = @cost_price, 
                                                              a.quantity = @quantity, 
			                                                  a.inventory_quantity = @quantity - COALESCE(b.bought, 0),
                                                              batch_number = @batch_number, 
                                                              expiration_date = @expiration_date 
                                                 FROM tbldeliveries_items a
                                                 LEFT JOIN Total_deducted b ON 1 = 1
                                                 WHERE a.delivery_id = @id AND a.id = @id2;", _sqlConnection, transaction)

                    _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
                    _sqlCommand.Parameters.AddWithValue("@id2", item("id"))
                    _sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
                    _sqlCommand.Parameters.AddWithValue("@price", item("price"))
                    _sqlCommand.Parameters.AddWithValue("@cost_price", item("cost_price"))
                    _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                    _sqlCommand.Parameters.AddWithValue("@inventory_quantity", item("quantity"))
                    If String.IsNullOrEmpty(item("batch_number").ToString()) Then
                        _sqlCommand.Parameters.AddWithValue("@batch_number", DBNull.Value)
                    Else
                        _sqlCommand.Parameters.AddWithValue("@batch_number", item("batch_number"))
                    End If

                    If String.IsNullOrEmpty(item("expiration_date").ToString()) Then
                        _sqlCommand.Parameters.AddWithValue("@expiration_date", DBNull.Value)
                    Else
                        _sqlCommand.Parameters.AddWithValue("@expiration_date", item("expiration_date"))
                    End If

                    If _sqlCommand.ExecuteNonQuery() <= 0 Then
                        MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Next

            transaction.Commit()
            MessageBox.Show("Delivery has been updated successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        Dim transaction As SqlTransaction = SqlConnectionPods.GetInstance.BeginTransaction()
        Try
            _sqlCommand = New SqlCommand("INSERT INTO tbldeliveries (delivery_number, account_id, supplier_id, vendor_id, total, date) VALUES (@delivery_number, @account_id, @supplier_id, @vendor_id, @total, @date); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@delivery_number", _data.Item("delivery_number"))
            _sqlCommand.Parameters.AddWithValue("@account_id", My.Settings.myId)
            _sqlCommand.Parameters.AddWithValue("@supplier_id", _data.Item("supplier_id"))
            _sqlCommand.Parameters.AddWithValue("@vendor_id", _data.Item("vendor_id"))
            _sqlCommand.Parameters.AddWithValue("@total", _data.Item("total"))
            _sqlCommand.Parameters.AddWithValue("@date", _data.Item("date"))

            Dim deliveryId As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())

            For Each item In _item
                If item IsNot Nothing AndAlso item.Count > 0 Then
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand = New SqlCommand("INSERT INTO tbldeliveries_items (delivery_id, product_id, price, cost_price, quantity, inventory_quantity, batch_number, expiration_date) VALUES (@delivery_id, @product_id, @price, @cost_price, @quantity,  @inventory_quantity, @batch_number, @expiration_date)", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@delivery_id", deliveryId)
                    _sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
                    _sqlCommand.Parameters.AddWithValue("@price", item("price"))
                    _sqlCommand.Parameters.AddWithValue("@cost_price", item("cost_price"))
                    _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                    _sqlCommand.Parameters.AddWithValue("@inventory_quantity", item("quantity"))
                    If String.IsNullOrEmpty(item("batch_number").ToString()) Then
                        _sqlCommand.Parameters.AddWithValue("@batch_number", DBNull.Value)
                    Else
                        _sqlCommand.Parameters.AddWithValue("@batch_number", item("batch_number"))
                    End If

                    If String.IsNullOrEmpty(item("expiration_date").ToString()) Then
                        _sqlCommand.Parameters.AddWithValue("@expiration_date", DBNull.Value)
                    Else
                        _sqlCommand.Parameters.AddWithValue("@expiration_date", item("expiration_date"))
                    End If

                    If _sqlCommand.ExecuteNonQuery() <= 0 Then
                        MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Next

            transaction.Commit()
            MessageBox.Show("Delivery has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Shared Function SelectAllDeliveryItems(delivery_id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT a.id, 
                                         product_name, 
                                         ISNULL(expiration_date, NULL) AS expiration,
                                         a.batch_number,
                                         a.price, 
                                         a.cost_price, 
                                         a.quantity, 
                                         a.cost_price * a.quantity as total,
                                         a.product_id
                                        FROM tbldeliveries_items a
                                        JOIN tblproducts ON a.product_id = tblproducts.id 
                                        WHERE a.delivery_id = @delivery_id", conn)
            cmd.Parameters.AddWithValue("@delivery_id", delivery_id)
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
    ''' Check if delivery number is already exist
    ''' </summary>
    ''' <param name="delivery_number"></param>
    ''' <returns></returns>
    Public Shared Function Exists(delivery_number As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tbldeliveries WHERE lower(delivery_number) = @delivery_number", conn)
            cmd.Parameters.AddWithValue("@delivery_number", delivery_number.Trim.ToLower)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Check if the id and delvery number is exist
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="delivery_number"></param>
    ''' <returns></returns>
    Public Shared Function IdExist(id As Integer, delivery_number As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tbldeliveries WHERE id = @id AND LOWER(delivery_number) = @delivery_number", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@delivery_number", delivery_number.Trim.ToLower)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' To identify the product if expiration date is needed
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Shared Function EnableExp(id As Integer) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT expiration FROM tblproducts WHERE id =  @id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Searching items query for deliveries
    ''' </summary>
    ''' <param name="barcode"></param>
    ''' <returns></returns>
    Public Shared Function BarcodeFetching(barcode As String) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT TOP 1 p.id AS id, di.id as idngdeli,
                                               subcategory_id,
                                               product_name, 
                                               ISNULL(cost_price, 0) AS cost_price, 
                                               ISNULL(price, 0) AS price 
                                  FROM tblproducts p 
                                  LEFT JOIN tbldeliveries_items di ON p.id = di.product_id WHERE barcode = @barcode
                                  ORDER BY idngdeli DESC", conn)
            cmd.Parameters.AddWithValue("@barcode", barcode)
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
    ''' Searching items by name
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns></returns>
    Public Shared Function NameFetching(name As String) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT top 1 p.id AS id, 
                                               subcategory_id, 
                                               product_name, 
                                               ISNULL(cost_price, 0) AS cost_price, 
                                               ISNULL(price, 0) AS price 
                                  FROM tblproducts p 
                                  LEFT JOIN tbldeliveries_items di ON p.id = di.product_id WHERE product_name = @name
                                  ORDER BY price DESC", conn)
            cmd.Parameters.AddWithValue("@name", name)
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
    ''' Price check shoild not lower than from the current price
    ''' </summary>
    ''' <param name="price"></param>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Shared Function Pricing(price As Decimal, id As Integer) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT COUNT(*) 
                                 FROM tbldeliveries_items 
                                 WHERE cost_price >= @price 
                                 AND inventory_quantity != 0 
                                 AND product_id = @id", conn)
            cmd.Parameters.AddWithValue("@price", price)
            cmd.Parameters.AddWithValue("@id", id)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Get the id of product
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Shared Function Product_id(id As Integer) As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT product_id FROM tbldeliveries_items WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' To add items on item deliveries
    ''' </summary>
    ''' <param name="_data"></param>
    ''' <returns></returns>
    Public Shared Function Insert_Items(_data)
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("INSERT INTO tbldeliveries_items (delivery_id, product_id, price, cost_price, quantity, inventory_quantity, batch_number, expiration_date) 
                                  VALUES (@delivery_id, @product_id, @price, @cost_price, @quantity, @quantity, @batch_number, @expiration_date)", conn)
            cmd.Parameters.AddWithValue("@delivery_id", _data.item("delivery_id"))
            cmd.Parameters.AddWithValue("@product_id", _data.item("product_id"))
            cmd.Parameters.AddWithValue("@price", _data.item("price"))
            cmd.Parameters.AddWithValue("@cost_price", _data.item("cost_price"))
            cmd.Parameters.AddWithValue("@quantity", _data.item("quantity"))
            If String.IsNullOrEmpty(_data.item("batch_number").ToString()) Then
                cmd.Parameters.AddWithValue("@batch_number", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@batch_number", _data.item("batch_number"))
            End If

            If String.IsNullOrEmpty(_data.item("expiration_date").ToString()) Then
                cmd.Parameters.AddWithValue("@expiration_date", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@expiration_date", _data.item("expiration_date"))
            End If

            If cmd.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            Return Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End Try
    End Function

    Public Shared Function Count_bought_quantity(delivery_id As Integer, product_id As Integer) As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT COALESCE(SUM(CASE WHEN quantity IS NULL THEN 0 ELSE quantity END), 0)
                                 FROM getrev
                                 WHERE delivery_id = @delivery_id
                                 AND product_id = @product_id;", conn)
            cmd.Parameters.AddWithValue("@delivery_id", delivery_id)
            cmd.Parameters.AddWithValue("@product_id", product_id)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function
End Class
