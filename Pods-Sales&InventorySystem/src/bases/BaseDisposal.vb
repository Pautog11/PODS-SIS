Imports System.Data.SqlClient
Public Class BaseDisposal
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
            _sqlCommand = New SqlCommand("INSERT INTO tbldisposal (reference_number, account_id, total) VALUES (@reference_number, @account_id, @total); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@reference_number", _data.Item("reference_number"))
            _sqlCommand.Parameters.AddWithValue("@account_id", My.Settings.myId)
            _sqlCommand.Parameters.AddWithValue("@total", _data.Item("total"))

            Dim disposal_id As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())

            For Each item In _item
                If item IsNot Nothing AndAlso item.Count > 0 Then
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand = New SqlCommand("INSERT INTO tbldisposal_items (disposal_id, product_id, drc, batch_number, expiration_date, price, quantity) VALUES (@disposal_id, @product_id, @drc, @batch_number, @expiration_date, @price, @quantity)", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@disposal_id", disposal_id)
                    _sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
                    _sqlCommand.Parameters.AddWithValue("@drc", item("drc"))
                    _sqlCommand.Parameters.AddWithValue("@batch_number", item("batch_number"))
                    _sqlCommand.Parameters.AddWithValue("@expiration_date", item("expiration_date"))
                    _sqlCommand.Parameters.AddWithValue("@price", item("price"))
                    _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                    If _sqlCommand.ExecuteNonQuery() <= 0 Then
                        Throw New Exception("An error occured!")
                    End If
                End If
            Next

            For Each item In _item
                If item("from") = "INVENTORY" Then
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand = New SqlCommand("UPDATE tbldeliveries_items SET inventory_quantity = inventory_quantity - @inventory_quantity WHERE id = @id", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@inventory_quantity", item("quantity"))
                    _sqlCommand.Parameters.AddWithValue("@id", item("delivery_items_id"))
                Else
                    _sqlCommand.Parameters.Clear()
                    _sqlCommand = New SqlCommand("UPDATE tblreturn_items SET remaining_quantity = remaining_quantity - @remaining_quantity WHERE id = @id", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@remaining_quantity", item("quantity"))
                    _sqlCommand.Parameters.AddWithValue("@id", item("delivery_items_id"))
                End If

                If _sqlCommand.ExecuteNonQuery() <= 0 Then
                    Throw New Exception("An error occured!")
                End If
            Next



            transaction.Commit()
            MessageBox.Show("Dispose has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Public Shared Function SelectAllProducts() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT a.id AS DEVITEMSID, 
                                         b.id AS DEVID, 
                                         c.id AS PID, 
										 'INVENTORY' AS 'FROM',
                                         product_name AS NAME, 
                                         batch_number AS 'BATCH NUMBER', 
                                         FORMAT(expiration_date, 'yyyy-MM-dd') AS 'EXPIRATION DATE',
                                         cost_price AS 'COST PRICE',
                                         inventory_quantity AS QUANTITY
                                  FROM tbldeliveries_items a
                                  JOIN tbldeliveries b ON a.delivery_id = b.id
                                  JOIN tblproducts c ON c.id = a.product_id
                                  WHERE inventory_quantity != 0

                                  UNION ALL 
    
                                  SELECT b.id, 
                                         a.id, 
                                         c.id, 
                                         'RETURNED' AS 'FROM',
                                         product_name, 
                                         batch_number, 
                                         FORMAT(expiration_date, 'yyyy-MM-dd') AS 'EXPIRATION DATE',
                                         e.cost_price, 
                                         a.remaining_quantity
                                  FROM tblreturn_items a
                                  JOIN tblreturns b ON a.tblreturn_id = b.id
                                  JOIN tblproducts c ON a.product_id = c.id
                                  JOIN getrev d ON b.transaction_id = d.transaction_id
                                  JOIN tbldeliveries_items e ON d.delivery_items_id = e.id
                                  WHERE remaining_quantity != 0", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    Public Shared Function FetchDisposalReasonCode() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT * FROM tbldisposal_reason_code", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    Public Shared Function FetchDisposalReasonCodeByName(code As String) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT id, code FROM tbldisposal_reason_code WHERE code = @code
                                  UNION ALL
                                  SELECT id, code FROM tbldisposal_reason_code WHERE code != @code", conn)
            cmd.Parameters.AddWithValue("@code", code.Trim.ToLower)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    Public Shared Function FetchInvetoryQunatity(id As Integer) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT inventory_quantity FROM tbldeliveries_items WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function FetchReturnedQunatity(id As Integer) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT remaining_quantity FROM tblreturn_items WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function Search(query As String) As pods.viewtbldisposalDataTable
        Try
            Dim conn As New SqlConnection(My.Settings.podsdbConnectionString)
            Dim cmd As New SqlCommand("SELECT * FROM viewtbldisposal WHERE id <> 1 AND [REFERENCE NUMBER] LIKE CONCAT('%', @query, '%') OR [PROCESS BY] LIKE CONCAT('%', @query, '%')", conn)
            cmd.Parameters.AddWithValue("@query", query)
            Dim dTable As New pods.viewtbldisposalDataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New pods.viewtbldisposalDataTable
        End Try
    End Function
End Class