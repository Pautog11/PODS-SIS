﻿Imports System.Data.SqlClient

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
        Throw New NotImplementedException()
    End Sub

    Public Sub Update() Implements ICommandPanel.Update
        Throw New NotImplementedException()
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        Dim transaction As SqlTransaction = SqlConnectionPods.GetInstance.BeginTransaction()
        Try
            ' Prepare and execute the main delivery insertion
            _sqlCommand = New SqlCommand("INSERT INTO tbldeliveries (delivery_number, account_id, supplier_id, total, date) VALUES (@delivery_number, @account_id, @supplier_id, @total, @date); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@delivery_number", _data.Item("delivery_number"))
            _sqlCommand.Parameters.AddWithValue("@account_id", My.Settings.myId)
            _sqlCommand.Parameters.AddWithValue("@supplier_id", _data.Item("supplier_id"))
            _sqlCommand.Parameters.AddWithValue("@total", _data.Item("total"))
            _sqlCommand.Parameters.AddWithValue("@date", _data.Item("date"))

            Dim deliveryId As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())

            'Dim productid As Integer = Nothing
            For Each item In _item
                If item IsNot Nothing AndAlso item.Count > 0 Then
                    ' Insert into tbldeliveries_items
                    _sqlCommand = New SqlCommand("INSERT INTO tbldeliveries_items (delivery_id, product_id, price, cost_price, quantity, inventory_quantity, batch_number, expiration_date) VALUES (@delivery_id, @product_id, @price, @cost_price, @quantity,  @inventory_quantity, @batch_number, @expiration_date); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@delivery_id", deliveryId)
                    _sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
                    _sqlCommand.Parameters.AddWithValue("@price", item("price"))
                    _sqlCommand.Parameters.AddWithValue("@cost_price", item("cost_price"))
                    _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                    _sqlCommand.Parameters.AddWithValue("@inventory_quantity", item("quantity"))
                    _sqlCommand.Parameters.AddWithValue("@batch_number", item("batch_number"))
                    If String.IsNullOrEmpty(item("expiration_date").ToString()) Then
                        _sqlCommand.Parameters.AddWithValue("@expiration_date", DBNull.Value)
                    Else
                        _sqlCommand.Parameters.AddWithValue("@expiration_date", item("expiration_date"))
                    End If
                    '_sqlCommand.Parameters.AddWithValue("@expiration_date", item("expiration_date"))

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
                                         a.cost_price * a.quantity as total
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

    'Public Shared Function FillPulloutProduct(delivery_id As Integer) As DataTable
    '    Try
    '        Dim conn As SqlConnection = SqlConnectionPods.GetInstance
    '        Dim cmd As SqlCommand
    '        cmd = New SqlCommand("SELECT tbldeliveries_items.id, tbldeliveries_items.delivery_id, tblproducts.id AS pid, tblproducts.product_name AS name, tblproduct_notif.exd, tblproducts.cost AS cost,
    '                           SUM(
    '                            CASE
    '	                            WHEN tbldeliveries_items.quantity = tblproduct_notif.quantity THEN tbldeliveries_items.quantity
    '	                            WHEN tbldeliveries_items.quantity > tblproduct_notif.quantity THEN tblproduct_notif.quantity 
    '								WHEN tbldeliveries_items.quantity <= tblproducts.quantity THEN tbldeliveries_items.quantity
    '								else 0
    '                            END
    '                           ) AS quantity
    '                          FROM 
    '                           tbldeliveries_items
    '                          LEFT JOIN 
    '                           tblproduct_notif ON tbldeliveries_items.id = tblproduct_notif.product_info_id
    '                          JOIN 
    '                           tblproducts ON tbldeliveries_items.product_id = tblproducts.id
    '                          WHERE 
    '                           tbldeliveries_items.delivery_id = @delivery_id
    '						GROUP BY tbldeliveries_items.id, tbldeliveries_items.delivery_id, tblproducts.id, tblproducts.product_name, tblproduct_notif.exd, tblproducts.cost", conn) 'Add and to fetch the product grater than 0
    '        cmd.Parameters.AddWithValue("@delivery_id", delivery_id)
    '        Dim dTable As New DataTable
    '        Dim adapter As New SqlDataAdapter(cmd)
    '        adapter.Fill(dTable)
    '        Return dTable
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return New DataTable
    '    End Try
    'End Function

    Public Shared Function Fillpulloutproducts(delivery_id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            'cmd = New SqlCommand("select deliverypullout_id, tp.product_name, isnull(exd, null) as exd, td.price, td.quantity, td.total from tbldeliverypullout_items td
            '                        join tblproducts tp on td.product_id = tp.id
            '                        left join tblproduct_notif nf on  nf.product_id = tp.id
            '                        where td.deliverypullout_id = @delivery_id", conn)

            cmd = New SqlCommand("select deliverypullout_id, tp.product_name, td.price, td.quantity, td.total from tbldeliverypullout_items td
                                    join tblproducts tp on td.product_id = tp.id
                                    where td.deliverypullout_id = @delivery_id", conn)
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
                                 WHERE price > @price 
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
End Class
