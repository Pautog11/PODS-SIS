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
            cmd = New SqlCommand("SELECT b.id, 
                                         b.product_name as name, 
                                         a.price, 
                                         a.quantity
                                  FROM tbltransaction_items a
                                  JOIN tblproducts b ON b.id = a.product_id
                                  WHERE transaction_id = @transaction_id", conn)
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
            cmd = New SqlCommand("SELECT a.id,
                                         product_name, 
                                         price, 
                                         quantity,
										 SUM(price * quantity) as total
                                  FROM tblreturn_items a
                                  JOIN tblproducts b on b.id = a.product_id
                                  WHERE tblreturn_id = @transaction_id
								  GROUP BY a.id, 
                                           tblreturn_id, 
                                           b.product_name, 
                                           price, 
                                           quantity", conn)
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
            cmd = New SqlCommand("SELECT product_id, product_name, price, quantity FROM tbltransactions a 
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
            cmd = New SqlCommand("SELECT c.id, product_name, b.price, remaining_quantity, batch_number, expiration_date FROM tblreturns a
                                  JOIN tblreturn_items b ON a.id = b.tblreturn_id
                                  JOIN tblproducts c ON b.product_id = c.id
                                  JOIN getrev d ON a.transaction_id = d.transaction_id
                                  JOIN tbldeliveries_items e ON d.delivery_id = e.delivery_id
                                  WHERE b.id = @id", conn)
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
