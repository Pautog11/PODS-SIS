Imports System.Data.SqlClient
Public Class BaseTransaction
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
            _sqlCommand = New SqlCommand("INSERT INTO tbltransactions (account_id, transaction_number, subtotal, vat, discount, total, date) VALUES (@account_id, @transaction_number, @subtotal, @vat, @discount, @total, @date); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@account_id", My.Settings.myId)
            _sqlCommand.Parameters.AddWithValue("@transaction_number", _data.Item("transaction_number"))
            _sqlCommand.Parameters.AddWithValue("@subtotal", _data.Item("subtotal"))
            _sqlCommand.Parameters.AddWithValue("@vat", _data.Item("vat"))
            _sqlCommand.Parameters.AddWithValue("@discount", _data.Item("discount"))
            _sqlCommand.Parameters.AddWithValue("@total", _data.Item("total"))
            _sqlCommand.Parameters.AddWithValue("@date", _data.Item("date"))

            Dim TransactionID As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())

            For Each item In _item
                If item IsNot Nothing AndAlso item.Count > 0 Then
                    _sqlCommand = New SqlCommand("INSERT INTO tbltransaction_items (transaction_id, product_id, price, quantity, total) VALUES (@transaction_id, @product_id, @price, @quantity, @total)", _sqlConnection, transaction)
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand.Parameters.AddWithValue("@transaction_id", TransactionID)
                    _sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
                    _sqlCommand.Parameters.AddWithValue("@price", item("price"))
                    _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                    _sqlCommand.Parameters.AddWithValue("@total", item("total"))

                    If _sqlCommand.ExecuteNonQuery() <= 0 Then
                        Throw New Exception("Failed to add transacation items!")
                    End If
                End If
            Next

            For Each item In _item
                _sqlCommand = New SqlCommand("UPDATE tblproducts SET quantity = quantity - @quantity where id = @id", _sqlConnection, transaction)
                _sqlCommand.Parameters.Clear()
                _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                _sqlCommand.Parameters.AddWithValue("@id", item("product_id"))
                _sqlCommand.ExecuteNonQuery()
            Next

            For Each item In _item
                _sqlCommand = New SqlCommand("EXEC updatetblproduct_notif @TargetProductID, @TargetQuantity", _sqlConnection, transaction)
                _sqlCommand.Parameters.Clear()
                _sqlCommand.Parameters.AddWithValue("@TargetProductID", item("product_id"))
                _sqlCommand.Parameters.AddWithValue("@TargetQuantity", item("quantity"))
                _sqlCommand.ExecuteNonQuery()
            Next

            transaction.Commit()
            MessageBox.Show("Transaction has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Public Shared Function ScalarTransaction() As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT CASE WHEN SUM(total) IS NULL THEN 0 ELSE SUM(total) END FROM tbltransactions;", conn)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function ScalarVat() As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT vat FROM tblvat;", conn)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function SelectAllTransactedItems(transaction_id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT id, product_id, price, quantity, total FROM tbltransaction_items WHERE transaction_id = transaction_id", conn)
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
End Class
