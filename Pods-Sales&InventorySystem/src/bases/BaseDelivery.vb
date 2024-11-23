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
        Throw New NotImplementedException()
    End Sub

    Public Sub Update() Implements ICommandPanel.Update
        Throw New NotImplementedException()
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        'Dim transaction As SqlTransaction = SqlConnectionPods.GetInstance.BeginTransaction()
        'Try
        '    _sqlCommand = New SqlCommand("INSERT INTO tbldeliveries (delivery_number, account_id, supplier_id, total, date) VALUES (@delivery_number, @account_id, @supplier_id, @total, @date); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
        '    _sqlCommand.Parameters.AddWithValue("@delivery_number", _data.Item("delivery_number"))
        '    _sqlCommand.Parameters.AddWithValue("@account_id", My.Settings.myId)
        '    _sqlCommand.Parameters.AddWithValue("@supplier_id", _data.Item("supplier_id"))
        '    _sqlCommand.Parameters.AddWithValue("@total", _data.Item("total"))
        '    _sqlCommand.Parameters.AddWithValue("@date", _data.Item("date"))

        '    Dim deliveryId As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())

        '    For Each item In _item
        '        If item IsNot Nothing AndAlso item.Count > 0 Then
        '            _sqlCommand = New SqlCommand("INSERT INTO tbldeliveries_items (delivery_id, product_id, price, quantity, total) VALUES (@delivery_id, @product_id, @price, @quantity, @total);  SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
        '            _sqlCommand.Parameters.Clear()
        '            _sqlCommand.Parameters.AddWithValue("@delivery_id", deliveryId)
        '            _sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
        '            _sqlCommand.Parameters.AddWithValue("@price", item("price"))
        '            _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
        '            _sqlCommand.Parameters.AddWithValue("@total", item("total"))

        '            If deliveryId = Convert.ToInt32(_sqlCommand.ExecuteScalar()) > 0 Then
        '                Throw New Exception("Failed to add delivery items!")
        '            Else
        '                'To update the quantity of product
        '                _sqlCommand.Parameters.Clear()
        '                _sqlCommand = New SqlCommand("UPDATE tblproducts SET quantity = quantity + @quantity WHERE id = @id", _sqlConnection, transaction)
        '                _sqlCommand.Parameters.Clear()
        '                _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
        '                _sqlCommand.Parameters.AddWithValue("@id", item("product_id"))
        '                _sqlCommand.ExecuteNonQuery()
        '            End If
        '        End If
        '    Next
        '    For Each item In _item
        '        If item("mfd") IsNot Nothing AndAlso Not String.IsNullOrEmpty(item("mfd").ToString()) AndAlso item("exd") IsNot Nothing AndAlso Not String.IsNullOrEmpty(item("exd").ToString()) Then
        '            _sqlCommand.Parameters.Clear()
        '            _sqlCommand = New SqlCommand("INSERT INTO tblproduct_notif (product_id, delivery_id, quantity, mfd, exd, product_notif_id) VALUES (@product_id, @delivery_id, @quantity, @mfd, @exd, @product_notif_id)", _sqlConnection, transaction)
        '            _sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
        '            _sqlCommand.Parameters.AddWithValue("@delivery_id", deliveryId)
        '            _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
        '            _sqlCommand.Parameters.AddWithValue("@mfd", item("mfd"))
        '            _sqlCommand.Parameters.AddWithValue("@exd", item("exd"))
        '            _sqlCommand.Parameters.AddWithValue("@product_notif_id", deliveryId)
        '            If _sqlCommand.ExecuteNonQuery <= 0 Then
        '                Throw New Exception("Failed to add delivery items in expiry date!")
        '            End If
        '        End If
        '    Next

        '    transaction.Commit()
        '    MessageBox.Show("Delivery has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Catch ex As Exception
        '    transaction.Rollback()
        '    MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End Try

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

            Dim productid As Integer = Nothing
            For Each item In _item
                If item IsNot Nothing AndAlso item.Count > 0 Then
                    ' Insert into tbldeliveries_items
                    _sqlCommand = New SqlCommand("INSERT INTO tbldeliveries_items (delivery_id, product_id, price, quantity, total, cost_price) VALUES (@delivery_id, @product_id, @price, @quantity, @total, @cost_price); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@delivery_id", deliveryId)
                    _sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
                    _sqlCommand.Parameters.AddWithValue("@price", item("price"))
                    _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                    _sqlCommand.Parameters.AddWithValue("@total", item("total"))
                    _sqlCommand.Parameters.AddWithValue("@cost_price", item("cost_price"))


                    productid = Convert.ToInt32(_sqlCommand.ExecuteScalar())
                    If productid <= 0 Then
                        Throw New Exception("Failed to add delivery items!")
                    End If

                    'If item.ContainsKey("exd") AndAlso Not String.IsNullOrEmpty(item("exd").ToString()) Then
                    If item.ContainsKey("exd") AndAlso Not String.IsNullOrEmpty(item("exd")?.ToString()) Then
                        _sqlCommand.Parameters.Clear()
                        _sqlCommand = New SqlCommand("INSERT INTO tblproduct_notif (product_id, delivery_id, quantity, exd, product_info_id) VALUES (@product_id, @delivery_id, @quantity, @exd, @product_info_id)", _sqlConnection, transaction)
                        _sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
                        _sqlCommand.Parameters.AddWithValue("@delivery_id", deliveryId)
                        _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                        _sqlCommand.Parameters.AddWithValue("@exd", item("exd"))
                        _sqlCommand.Parameters.AddWithValue("@product_info_id", productid)
                        If _sqlCommand.ExecuteNonQuery() <= 0 Then
                            Throw New Exception("Failed to add delivery items with expiry date!")
                        End If
                    End If

                    ' Update quantity in tblproducts
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand = New SqlCommand("UPDATE tblproducts SET quantity = quantity + @quantity WHERE id = @id", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                    _sqlCommand.Parameters.AddWithValue("@id", item("product_id"))
                    _sqlCommand.ExecuteNonQuery()


                    '' Update price in tblproducts
                    '_sqlCommand.Parameters.Clear()
                    '_sqlCommand = New SqlCommand("UPDATE tblproducts SET price = price + @price WHERE id = @id", _sqlConnection, transaction)
                    '_sqlCommand.Parameters.AddWithValue("@price", item("price"))
                    '_sqlCommand.Parameters.AddWithValue("@id", item("product_id"))
                    '_sqlCommand.ExecuteNonQuery()
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
            'cmd = New SqlCommand("SELECT id, product_id, price, quantity, total FROM tbldeliveries_items WHERE delivery_id = @delivery_id", conn)
            'cmd = New SqlCommand("SELECT tbldeliveries_items.id, product_name, price, tbldeliveries_items.quantity, total 
            '                      FROM tbldeliveries_items join tblproducts on tbldeliveries_items.product_id = tblproducts.id WHERE delivery_id = @delivery_id", conn)

            '  cmd = New SqlCommand("SELECT tbldeliveries_items.id, 
            '                               product_name,  
            '                               ISNULL(mfd, NULL) AS mfd, 
            '                               ISNULL(exd, NULL) AS exd, 
            '                               price, 
            '                               tbldeliveries_items.quantity, 
            '                               total 
            '                        FROM tbldeliveries_items 
            'JOIN tblproducts on tbldeliveries_items.product_id = tblproducts.id 
            'LEFT JOIN tblproduct_notif on  tbldeliveries_items.delivery_id = tblproduct_notif.delivery_id
            'WHERE tbldeliveries_items.delivery_id = @delivery_id;", conn)

            'cmd = New SqlCommand("SELECT tbldeliveries_items.id, product_name, ISNULL(mfd, NULL) AS mfd, ISNULL(exd, NULL) AS exd, price, tbldeliveries_items.quantity, total 
            '                                FROM tbldeliveries_items join tblproducts ON tbldeliveries_items.product_id = tblproducts.id 
            '                                LEFT JOIN tblproduct_notif ON tbldeliveries_items.delivery_id = tblproduct_notif.delivery_id AND tbldeliveries_items.product_id = tblproduct_notif.product_id
            '                                WHERE tbldeliveries_items.delivery_id = @delivery_id;", conn)

            'cmd = New SqlCommand("SELECT tbldeliveries_items.id, product_name, ISNULL(exd, NULL) AS exd, price, tbldeliveries_items.quantity, total 
            '                                FROM tbldeliveries_items join tblproducts ON tbldeliveries_items.product_id = tblproducts.id 
            '                                LEFT JOIN tblproduct_notif ON tbldeliveries_items.id = tblproduct_notif.product_info_id
            '                                WHERE tbldeliveries_items.delivery_id = @delivery_id", conn)

            cmd = New SqlCommand("SELECT tbldeliveries_items.id, product_name, ISNULL(exd, NULL) AS exd, tbldeliveries_items.price, tbldeliveries_items.cost_price, tbldeliveries_items.quantity, total 
												FROM tbldeliveries_items 
												JOIN tblproducts ON tbldeliveries_items.product_id = tblproducts.id 
												LEFT JOIN tblproduct_notif ON tbldeliveries_items.id = tblproduct_notif.product_info_id
												WHERE tbldeliveries_items.delivery_id =  @delivery_id", conn)
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

    Public Shared Function FillSkuByProduct(product_name As String) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT sku FROM tblproducts WHERE product_name = @product_name", conn)
            cmd.Parameters.AddWithValue("@product_name", product_name)
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

    Public Shared Function Daterequired(product_id As Integer) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblproduct_info where product_id = @product_id", conn)
            cmd.Parameters.AddWithValue("@product_id", product_id)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function FillPulloutProduct(delivery_id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT tbldeliveries_items.id, tbldeliveries_items.delivery_id, tblproducts.id AS pid, tblproducts.product_name AS name, tblproduct_notif.exd, tblproducts.cost AS cost,
			                            SUM(
				                            CASE
					                            WHEN tbldeliveries_items.quantity = tblproduct_notif.quantity THEN tbldeliveries_items.quantity
					                            WHEN tbldeliveries_items.quantity > tblproduct_notif.quantity THEN tblproduct_notif.quantity 
												WHEN tbldeliveries_items.quantity > tblproducts.quantity THEN tbldeliveries_items.quantity
												else 0
				                            END
			                            ) AS quantity
		                            FROM 
			                            tbldeliveries_items
		                            LEFT JOIN 
			                            tblproduct_notif ON tbldeliveries_items.id = tblproduct_notif.product_info_id
		                            JOIN 
			                            tblproducts ON tbldeliveries_items.product_id = tblproducts.id
		                            WHERE 
			                            tbldeliveries_items.delivery_id = @delivery_id
										GROUP BY tbldeliveries_items.id, tbldeliveries_items.delivery_id, tblproducts.id, tblproducts.product_name, tblproduct_notif.exd, tblproducts.cost", conn) 'Add and to fetch the product grater than 0
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
End Class
