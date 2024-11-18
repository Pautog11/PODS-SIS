Imports System.Data.SqlClient
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
                    _sqlCommand = New SqlCommand("INSERT INTO tblreturn_items (tblreturn_id, product_id, price, quantity, total) VALUES (@tblreturn_id, @product_id, @price, @quantity, @total); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@tblreturn_id", deliveryId)
                    _sqlCommand.Parameters.AddWithValue("@product_id", item("pid"))
                    _sqlCommand.Parameters.AddWithValue("@price", item("price"))
                    _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                    _sqlCommand.Parameters.AddWithValue("@total", item("total"))

                    If _sqlCommand.ExecuteNonQuery <= 0 Then
                        Throw New Exception("Failed to add return items!")
                    End If
                End If
            Next

            ''will minus the grandtotal of transaction
            '_sqlCommand.Parameters.Clear()
            '_sqlCommand = New SqlCommand("UPDATE tbltransactions SET total = total - @total where id = @id;", _sqlConnection, transaction)
            '_sqlCommand.Parameters.AddWithValue("@total", _data.Item("total"))
            '_sqlCommand.Parameters.AddWithValue("@id", _data.Item("transaction_id"))
            'If _sqlCommand.ExecuteNonQuery <= 0 Then
            '    Throw New Exception("Failed to update return to transactions!")
            'End If

            ''To insert return items to tbltransaction_items
            'For Each item In _item
            '    If item IsNot Nothing AndAlso item.Count > 0 Then
            '        ' Insert into tbldeliveries_items
            '        _sqlCommand.Parameters.Clear()
            '        _sqlCommand = New SqlCommand("INSERT INTO tbltransaction_items (transaction_id, product_id, price, quantity, total) VALUES (@transaction_id, @product_id, @price, @quantity, @total); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
            '        _sqlCommand.Parameters.AddWithValue("@transaction_id", _data.Item("transaction_id"))
            '        _sqlCommand.Parameters.AddWithValue("@product_id", item("pid"))
            '        _sqlCommand.Parameters.AddWithValue("@price", item("price"))
            '        _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity") * -1)
            '        _sqlCommand.Parameters.AddWithValue("@total", item("total") * -1)
            '        If _sqlCommand.ExecuteNonQuery <= 0 Then
            '            Throw New Exception("Failed to add return items!")
            '        End If
            '    End If
            'Next


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
            cmd = New SqlCommand("select a.id, transaction_id, b.id as pid, b.product_name as name, price, a.quantity, total from tbltransaction_items a
                                    join tblproducts b on b.id = a.product_id
                                    where transaction_id = @transaction_id", conn)
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


    Public Shared Function SelectAllReturnById(id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("select * from tblreturn_items where tblreturn_id = @transaction_id", conn)
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
End Class
