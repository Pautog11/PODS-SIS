﻿Imports System.Data.SqlClient
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
        Throw New NotImplementedException()
    End Sub

    Public Sub Update() Implements ICommandPanel.Update
        Throw New NotImplementedException()
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        Dim transaction As SqlTransaction = SqlConnectionPods.GetInstance.BeginTransaction()
        Try
            _sqlCommand = New SqlCommand("INSERT INTO tbldeliverypullouts (account_id, delivery_id, total, reason, date) VALUES (@account_id, @delivery_id, @total, @reason, @date);SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@account_id", My.Settings.myId)
            _sqlCommand.Parameters.AddWithValue("@delivery_id", _data.Item("delivery_id"))
            _sqlCommand.Parameters.AddWithValue("@total", _data.Item("total"))
            _sqlCommand.Parameters.AddWithValue("@reason", _data.Item("reason"))
            _sqlCommand.Parameters.AddWithValue("@date", _data.Item("date"))

            Dim pullout_id As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())

            If pullout_id <= 0 Then
                Throw New Exception("Failed to add delivery items!")
            End If

            For Each item In _item
                If item IsNot Nothing AndAlso item.Count > 0 Then
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand = New SqlCommand("INSERT INTO tbldeliverypullout_items (deliverypullout_id, product_id, price, quantity, total) VALUES (@deliverypullout_id, @product_id, @price, @quantity, @total)", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@deliverypullout_id", pullout_id)
                    _sqlCommand.Parameters.AddWithValue("@product_id", item("pid"))
                    _sqlCommand.Parameters.AddWithValue("@price", item("price"))
                    _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                    _sqlCommand.Parameters.AddWithValue("@total", item("total"))

                    If _sqlCommand.ExecuteNonQuery() <= 0 Then
                        Throw New Exception("Failed to add delivery items with expiry date!")
                    End If

                    '_sqlCommand.Parameters.Clear()
                    '_sqlCommand = New SqlCommand("INSERT INTO tbldeliveries_items (delivery_id, product_id, price, quantity, total) VALUES (@delivery_id, @product_id, @price, @quantity, @total)", _sqlConnection, transaction)
                    '_sqlCommand.Parameters.AddWithValue("@delivery_id", item("delivery_id"))
                    '_sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
                    '_sqlCommand.Parameters.AddWithValue("@price", item("price"))
                    '_sqlCommand.Parameters.AddWithValue("@quantity", item("quantity") * -1)
                    '_sqlCommand.Parameters.AddWithValue("@total", item("total") * -1)

                    'If _sqlCommand.ExecuteNonQuery() <= 0 Then
                    '    Throw New Exception("Failed to add delivery items with expiry date!")
                    'End If

                    'If String.IsNullOrEmpty(item("exd")) AndAlso String.Empty Then
                    '    '_sqlCommand.Parameters.Clear()
                    '    '_sqlCommand = New SqlCommand("UPDATE tblproduct_notif SET quantity = quantity - @quantity where delivery_id = @delivery_id", _sqlConnection, transaction)
                    '    '_sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                    '    '_sqlCommand.Parameters.AddWithValue("@delivery_id", item("delivery_id"))

                    '    'If _sqlCommand.ExecuteNonQuery() <= 0 Then
                    '    '    Throw New Exception("Failed to add delivery items with expiry date!")
                    '    'End If
                    '    MsgBox(item("exd"))
                    'End If

                End If
            Next

            For Each item In _item
                If item IsNot Nothing AndAlso item.Count > 0 Then
                    If Not item("exd") = "N/A" Then 'String.IsNullOrEmpty(item("exd")) OrElse item("exd").ToString() <> "N/A" Then
                        _sqlCommand = New SqlCommand()

                        _sqlCommand.Parameters.Clear()
                        _sqlCommand = New SqlCommand("UPDATE tblproduct_notif SET quantity = quantity - @quantity where product_info_id = @product_info_id", _sqlConnection, transaction)
                        _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                        _sqlCommand.Parameters.AddWithValue("@product_info_id", item("product_id"))

                        If _sqlCommand.ExecuteNonQuery() <= 0 Then
                            Throw New Exception("Failed to add delivery items with expiry date!")
                        End If
                    End If
                End If
            Next

            For Each item In _item
                _sqlCommand.Parameters.Clear()
                _sqlCommand = New SqlCommand("UPDATE tblproducts SET quantity = quantity - @quantity where id = @id", _sqlConnection, transaction)
                _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                _sqlCommand.Parameters.AddWithValue("@id", item("pid"))

                If _sqlCommand.ExecuteNonQuery() <= 0 Then
                    Throw New Exception("Failed to update quantity!")
                End If
            Next

            MessageBox.Show("Product has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            transaction.Commit()
        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ''' <summary>
    ''' Fetch all product by delivery id
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Shared Function SelectAllProductByDeliveryId(id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT b.id, product_name, cost_price, inventory_quantity, ISNULL(expiration_date, NULL) AS expiration FROM tbldeliveries_items a
                                  JOIN tblproducts b ON a.product_id = b.id WHERE delivery_id = @id", conn)
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
