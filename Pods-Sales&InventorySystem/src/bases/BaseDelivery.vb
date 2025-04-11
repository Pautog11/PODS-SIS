Imports System.Data.SqlClient

Public Class BaseDelivery
    Inherits SqlBaseConnection
    Implements ICommandPanel

    Private ReadOnly _data As Dictionary(Of String, String)
    Private _item As IList(Of Dictionary(Of String, String))
    Private _ids As IList(Of Dictionary(Of String, String))

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
    End Sub

    Public Property Ids() As IList(Of Dictionary(Of String, String))
        Set(value As IList(Of Dictionary(Of String, String)))
            _ids = value
        End Set
        Get
            Return _ids
        End Get
    End Property

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
            _sqlCommand = New SqlCommand("UPDATE tbldeliveries SET delivery_number = @delivery_number, account_id = @account_id, supplier_id = @supplier_id, vendor_id = @vendor_id, total = @total, date = @date, vat = @vat WHERE id = @id;", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            _sqlCommand.Parameters.AddWithValue("@delivery_number", _data.Item("delivery_number"))
            _sqlCommand.Parameters.AddWithValue("@account_id", My.Settings.myId)
            _sqlCommand.Parameters.AddWithValue("@supplier_id", _data.Item("supplier_id"))
            _sqlCommand.Parameters.AddWithValue("@vendor_id", _data.Item("vendor_id"))
            _sqlCommand.Parameters.AddWithValue("@total", _data.Item("total"))
            _sqlCommand.Parameters.AddWithValue("@date", _data.Item("date"))
            _sqlCommand.Parameters.AddWithValue("@vat", _data.Item("vat"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                Throw New Exception("An error occured!")
            End If

            For Each item In _item

                If item IsNot Nothing AndAlso item.Count > 0 Then
                    _sqlCommand.Parameters.Clear()

                    If item("status") = "NEW" Then
                        _sqlCommand = New SqlCommand("INSERT INTO tbldeliveries_items (delivery_id, product_id, price_adjusment, price, cost_price, quantity, inventory_quantity, batch_number, expiration_date) 
                                                      VALUES (@id, @id2, @price, @price, @cost_price, @quantity, @inventory_quantity, @batch_number, @expiration_date)", _sqlConnection, transaction)

                    Else
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
                    End If

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
                        Throw New Exception("An error occured!")
                    End If
                End If

            Next

            transaction.Commit()
            MessageBox.Show("Delivery has been updated successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BaseAuditTrail.AuditLogin(My.Settings.myId, "Update delivery")
        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Public Sub Add() Implements ICommandPanel.Add
        Dim transaction As SqlTransaction = SqlConnectionPods.GetInstance.BeginTransaction()
        Try
            _sqlCommand = New SqlCommand("INSERT INTO tbldeliveries (delivery_number, account_id, supplier_id, vendor_id, total, deduction, date, vat) VALUES (@delivery_number, @account_id, @supplier_id, @vendor_id, @total, @deduction, @date, @vat); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@delivery_number", _data.Item("delivery_number"))
            _sqlCommand.Parameters.AddWithValue("@account_id", My.Settings.myId)
            _sqlCommand.Parameters.AddWithValue("@supplier_id", _data.Item("supplier_id"))
            _sqlCommand.Parameters.AddWithValue("@vendor_id", _data.Item("vendor_id"))
            _sqlCommand.Parameters.AddWithValue("@total", _data.Item("total"))
            _sqlCommand.Parameters.AddWithValue("@deduction", _data.Item("deduction"))
            _sqlCommand.Parameters.AddWithValue("@date", _data.Item("date"))
            _sqlCommand.Parameters.AddWithValue("@vat", _data.Item("vat"))

            Dim deliveryId As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())

            For Each item In _item
                If item IsNot Nothing AndAlso item.Count > 0 Then
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand = New SqlCommand("INSERT INTO tbldeliveries_items (delivery_id, product_id, price_adjusment, price, cost_price, quantity, inventory_quantity, batch_number, expiration_date) VALUES (@delivery_id, @product_id, @price, @price, @cost_price, @quantity,  @inventory_quantity, @batch_number, @expiration_date)", _sqlConnection, transaction)
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
                        Throw New Exception("An error occured!")
                    End If
                End If
            Next

            For Each i In Ids
                If i.Count > 0 Then
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand = New SqlCommand("INSERT INTO tbldelivery_deduction (delivery_id, delivery_pullout_id) VALUES (@delivery_id, @delivery_pullout_id)", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@delivery_id", deliveryId)
                    _sqlCommand.Parameters.AddWithValue("@delivery_pullout_id", i("id"))

                    If _sqlCommand.ExecuteNonQuery() <= 0 Then
                        Throw New Exception("An error occured!")
                    End If
                End If
            Next

            For Each i In Ids
                If i.Count > 0 Then
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand = New SqlCommand("UPDATE tbldeliverypullouts SET status = 0 WHERE id = @id", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@id", i("id"))

                    If _sqlCommand.ExecuteNonQuery() <= 0 Then
                        Throw New Exception("An error occured!")
                    End If
                End If
            Next

            transaction.Commit()
            MessageBox.Show("Delivery has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BaseAuditTrail.AuditLogin(My.Settings.myId, "Add delivery")
        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    '''
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
                                         a.product_id,
                                         'OLD'
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
                                               ISNULL(price_adjusment, 0) AS price 
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
            cmd = New SqlCommand("SELECT top 1 di.id, p.id AS id, 
                                               subcategory_id, 
                                               product_name, 
                                               ISNULL(cost_price, 0) AS cost_price, 
                                               ISNULL(price_adjusment, 0) AS price 
                                  FROM tblproducts p 
                                  LEFT JOIN tbldeliveries_items di ON p.id = di.product_id WHERE product_name = @name
                                  ORDER BY di.id DESC", conn)
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
                                  WHERE price_adjusment > @price AND inventory_quantity != 0 AND product_id = @id", conn)
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
    ''' <param name="product_name"></param>
    ''' <returns></returns>
    Public Shared Function Product_id(product_name As String) As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT id FROM tblproducts WHERE product_name = @product_name", conn)
            cmd.Parameters.AddWithValue("@product_name", product_name.Trim.ToLower())
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' To get the quantity bought
    ''' </summary>
    ''' <param name="delivery_id"></param>
    ''' <param name="product_id"></param>
    ''' <returns></returns>
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

    ''' <summary>
    ''' To fetch all previous pullouts
    ''' </summary>
    ''' <param name="supplier_id"></param>
    ''' <returns></returns>
    Public Shared Function FetchPullout(supplier_id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT id, reference_number, total, FORMAT(date, 'MMMM d, yyyy') as araw FROM tbldeliverypullouts WHERE supplier_id = @supplier_id AND status = 1", conn)
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

    Public Shared Function FetchVendor(supplier_id As Integer, id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT id, CONCAT(first_name, ' ', last_name) as name from tblvendor WHERE supplier_id = @supplier_id AND id = @id
                                  UNION ALL
                                  SELECT id, CONCAT(first_name, ' ', last_name) as name from tblvendor WHERE supplier_id = @supplier_id AND id != @id", conn)
            cmd.Parameters.AddWithValue("@supplier_id", supplier_id)
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

    Public Shared Function FetchSupplierId(company_name As String) As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT id FROM tblsuppliers WHERE company_name = @company_name", conn)
            cmd.Parameters.AddWithValue("@company_name", company_name.Trim.ToLower())
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function FetchTotalPullout(id As Integer) As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT ISNULL(SUM(b.total), 0) FROM tbldelivery_deduction a
                                  JOIN tbldeliverypullouts b ON a.delivery_pullout_id = b.id
                                  WHERE a.delivery_id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function FetchappliedPullout(id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT b.id, 
                                         b.reference_number, 
                                         b.total as total, 
                                         FORMAT(b.date, 'MMMM d yyyy')
                                  FROM tbldelivery_deduction a
                                  JOIN tbldeliverypullouts b ON a.delivery_pullout_id = b.id
                                  WHERE a.delivery_id = @id", conn)
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
