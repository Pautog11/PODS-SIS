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
        Dim transaction As SqlTransaction = SqlConnectionPods.GetInstance.BeginTransaction()
        Try
            _sqlCommand = New SqlCommand("INSERT INTO tbldeliveries (delivery_number, account_id, supplier_id, total, date) VALUES (@delivery_number, @account_id, @supplier_id, @total, @date); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@delivery_number", _data.Item("delivery_number"))
            _sqlCommand.Parameters.AddWithValue("@account_id", My.Settings.myId)
            _sqlCommand.Parameters.AddWithValue("@supplier_id", _data.Item("supplier_id"))
            _sqlCommand.Parameters.AddWithValue("@total", _data.Item("total"))
            _sqlCommand.Parameters.AddWithValue("@date", _data.Item("date"))

            Dim deliveryId As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())

            For Each item In _item
                If item IsNot Nothing AndAlso item.Count > 0 Then
                    _sqlCommand = New SqlCommand("INSERT INTO tbldeliveries_items (delivery_id, product_id, price, quantity, total) VALUES (@delivery_id, @product_id, @price, @quantity, @total)", _sqlConnection, transaction)
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand.Parameters.AddWithValue("@delivery_id", deliveryId)
                    _sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
                    _sqlCommand.Parameters.AddWithValue("@price", item("price"))
                    _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                    _sqlCommand.Parameters.AddWithValue("@total", item("total"))

                    If _sqlCommand.ExecuteNonQuery() <= 0 Then
                        Throw New Exception("Failed to add delivery items!")
                    Else
                        'To update the quantity of product
                        _sqlCommand.Parameters.Clear()
                        _sqlCommand = New SqlCommand("UPDATE tblproducts SET quantity = quantity + @quantity WHERE id = @id", _sqlConnection, transaction)
                        _sqlCommand.Parameters.Clear()
                        _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                        _sqlCommand.Parameters.AddWithValue("@id", item("product_id"))
                        _sqlCommand.ExecuteNonQuery()
                    End If
                End If
            Next

            For Each item In _item
                _sqlCommand.Parameters.Clear()
                _sqlCommand = New SqlCommand("INSERT INTO tblproduct_notif (product_id, delivery_id, quantity, mfd, exd) VALUES (@product_id, @delivery_id, @quantity, @mfd, @exd)", _sqlConnection, transaction)
                _sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
                _sqlCommand.Parameters.AddWithValue("@delivery_id", deliveryId)
                _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                _sqlCommand.Parameters.AddWithValue("@mfd", item("mfd"))
                _sqlCommand.Parameters.AddWithValue("@exd", item("exd"))
                If _sqlCommand.ExecuteNonQuery <= 0 Then
                    Throw New Exception("Failed to add delivery items in expiry date!")
                End If
            Next


            'MsgBox("base deliver done query")
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

            cmd = New SqlCommand("SELECT tbldeliveries_items.id, 
                                         product_name,  
                                         mfd, 
                                         exd,
                                         price, 
                                         tbldeliveries_items.quantity, 
                                         total 
                                  FROM tbldeliveries_items 
								  join tblproducts on tbldeliveries_items.product_id = tblproducts.id 
								  join tblproduct_notif on  tbldeliveries_items.delivery_id = tblproduct_notif.delivery_id
								  WHERE tbldeliveries_items.delivery_id = @delivery_id", conn)
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
            cmd = New SqlCommand("SELECT sku
                                  FROM tblproducts WHERE product_name = @product_name", conn)
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
End Class
