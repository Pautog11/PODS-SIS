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
            _sqlCommand = New SqlCommand("INSERT INTO tbltransactions (account_id, transaction_number, subtotal, vatable,  vat, discount, total, date, cash) VALUES (@account_id, @transaction_number, @subtotal, @vatable, @vat, @discount, @total, @date, @cash); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@account_id", My.Settings.myId)
            _sqlCommand.Parameters.AddWithValue("@transaction_number", _data.Item("transaction_number"))
            _sqlCommand.Parameters.AddWithValue("@subtotal", _data.Item("subtotal"))
            _sqlCommand.Parameters.AddWithValue("@vatable", _data.Item("vatable"))
            _sqlCommand.Parameters.AddWithValue("@vat", _data.Item("vat"))
            _sqlCommand.Parameters.AddWithValue("@discount", _data.Item("discount"))
            _sqlCommand.Parameters.AddWithValue("@total", _data.Item("total"))
            _sqlCommand.Parameters.AddWithValue("@date", _data.Item("date"))
            _sqlCommand.Parameters.AddWithValue("@cash", _data.Item("cash"))


            Dim TransactionID As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())


            'For Each item In _item
            '    _sqlCommand = New SqlCommand("UPDATE tbldeliveries_items SET quantity_trans = quantity_trans - @quantity WHERE product_id = @id AND LOWER(status_name) = LOWER('Active')", _sqlConnection, transaction)
            '    _sqlCommand.Parameters.Clear()
            '    _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
            '    _sqlCommand.Parameters.AddWithValue("@id", item("product_id"))
            '    _sqlCommand.ExecuteNonQuery()
            'Next

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

            For Each item In _item
                Dim quant As Integer = item("quantity")
                While quant > 0
                    _sqlCommand = New SqlCommand("SELECT TOP 1 id, quantity_trans FROM tbldeliveries_items WHERE product_id = @id AND quantity_trans > 0 ORDER BY quantity_trans ASC", _sqlConnection, transaction)
                    _sqlCommand.Parameters.AddWithValue("@id", item("product_id"))
                    Dim dt As New DataTable
                    Dim adapt As New SqlDataAdapter(_sqlCommand)
                    adapt.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        Dim total As Integer = dt.Rows.Item(0).Item("quantity_trans")
                        Dim id As Integer = dt.Rows.Item(0).Item("id")

                        _sqlCommand.CommandText = "UPDATE tbldeliveries_items SET quantity_trans = quantity_trans - @rem WHERE id = @id"
                        _sqlCommand.Parameters.Clear()
                        _sqlCommand.Parameters.AddWithValue("@id", id)
                        If quant < total Then
                            _sqlCommand.Parameters.AddWithValue("@rem", quant)
                            _sqlCommand.ExecuteNonQuery()

                            If item IsNot Nothing AndAlso item.Count > 0 Then
                                _sqlCommand = New SqlCommand("INSERT INTO tbltransaction_items (transaction_id, product_id, price, quantity, total, delivery_id) VALUES (@transaction_id, @product_id, @price, @quantity, @total, @divid)", _sqlConnection, transaction)
                                _sqlCommand.Parameters.Clear()
                                _sqlCommand.Parameters.AddWithValue("@transaction_id", TransactionID)
                                _sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
                                _sqlCommand.Parameters.AddWithValue("@price", item("price"))
                                _sqlCommand.Parameters.AddWithValue("@quantity", quant)
                                _sqlCommand.Parameters.AddWithValue("@total", quant * CInt(item("price")))
                                _sqlCommand.Parameters.AddWithValue("@divid", id)

                                If _sqlCommand.ExecuteNonQuery() <= 0 Then
                                    Throw New Exception("Failed to add transacation items!")
                                End If
                            End If
                            quant -= quant
                        Else
                            quant = quant - total
                            _sqlCommand.CommandText = "UPDATE tbldeliveries_items SET quantity_trans = 0 WHERE id = @id"
                            _sqlCommand.Parameters.Clear()
                            _sqlCommand.Parameters.AddWithValue("@id", id)
                            _sqlCommand.ExecuteNonQuery()

                            If item IsNot Nothing AndAlso item.Count > 0 Then
                                _sqlCommand = New SqlCommand("INSERT INTO tbltransaction_items (transaction_id, product_id, price, quantity, total, delivery_id) VALUES (@transaction_id, @product_id, @price, @quantity, @total, @divid)", _sqlConnection, transaction)
                                _sqlCommand.Parameters.Clear()
                                _sqlCommand.Parameters.AddWithValue("@transaction_id", TransactionID)
                                _sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
                                _sqlCommand.Parameters.AddWithValue("@price", item("price"))
                                _sqlCommand.Parameters.AddWithValue("@quantity", total)
                                _sqlCommand.Parameters.AddWithValue("@total", total * CInt(item("price")))
                                _sqlCommand.Parameters.AddWithValue("@divid", id)

                                If _sqlCommand.ExecuteNonQuery() <= 0 Then
                                    Throw New Exception("Failed to add transacation items!")
                                End If
                            End If
                        End If



                    End If


                End While
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
            cmd = New SqlCommand("SELECT t1.id, t2.product_name, t2.price, t1.quantity, total FROM tbltransaction_items t1
                                        join tblproducts t2 on  t1.product_id = t2.id
                                        WHERE transaction_id =  @transaction_id", conn)
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

    Public Shared Function SelectProductsByBarcode(barcode As String) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT p.id as id, subcategory_id, sku, product_name, p.price as price, p.cost as cost, p.quantity FROM tblproducts p 
                                  LEFT JOIN tbldeliveries_items di ON p.id = di.product_id WHERE barcode = @barcode", conn)
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

    Public Shared Function FetchDiscounts() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT discount, concat(discount, ' ',description) as des FROM tbldiscounts", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    Public Shared Function ScalarChartTransaction(timePeriod As String) As DataTable
        Try
            ' Get a connection from the connection pool
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance()

            ' Ensure the connection is open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' SQL query to get the sum of total transactions grouped by time period
            Dim cmd As New SqlCommand()

            ' Set the connection for the SqlCommand
            cmd.Connection = conn

            Select Case timePeriod.ToLower()
                Case "daily"
                    ' Group by exact date (casting to date without time part)
                    cmd.CommandText = "SELECT CAST(Date AS DATE) AS TransactionDate, SUM(total) AS Total FROM tbltransactions GROUP BY CAST(Date AS DATE) ORDER BY TransactionDate"

                Case "weekly"
                    ' Group by week starting from Sunday to Saturday
                    cmd.CommandText = "SELECT " &
                                  "DATEADD(WEEK, DATEDIFF(WEEK, 0, Date), 0) AS WeekStart, " &
                                  "SUM(total) AS Total " &
                                  "FROM tbltransactions " &
                                  "WHERE Date >= DATEADD(DAY, -DATEPART(WEEKDAY, GETDATE()) + 1, CAST(GETDATE() AS DATE)) " & _  ' Sunday of current week
                                  "AND Date < DATEADD(DAY, 7 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE)) " & _  ' Saturday of current week
                                  "GROUP BY DATEADD(WEEK, DATEDIFF(WEEK, 0, Date), 0) " &
                                  "ORDER BY WeekStart"

                Case "monthly"
                    ' Group by year and month (YEAR and MONTH)
                    cmd.CommandText = "SELECT YEAR(Date) AS Year, MONTH(Date) AS Month, SUM(total) AS Total FROM tbltransactions GROUP BY YEAR(Date), MONTH(Date) ORDER BY Year, Month"

                Case "annually"
                    ' Group by year
                    cmd.CommandText = "SELECT YEAR(Date) AS Year, SUM(total) AS Total FROM tbltransactions GROUP BY YEAR(Date) ORDER BY Year"

                Case Else
                    ' Default to daily if invalid selection
                    cmd.CommandText = "SELECT CAST(Date AS DATE) AS TransactionDate, SUM(total) AS Total FROM tbltransactions GROUP BY CAST(Date AS DATE) ORDER BY TransactionDate"
            End Select

            ' Create a DataTable to hold the results
            Dim dt As New DataTable()

            ' Use a data adapter to fill the DataTable with the result set
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)

            ' Return the DataTable containing the aggregated data
            Return dt
        Catch ex As Exception
            ' If an error occurs, display a message and return an empty DataTable
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End Try
    End Function

    Public Shared Function NamebyID(product_name As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("select id from tblproducts where product_name = @product_name;", conn)
            cmd.Parameters.AddWithValue("@product_name", product_name)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function Returnbutton(id As Integer) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("select count(*) from tbltransactions a join tblreturns b on a.id = b.transaction_id where a.id = @id;", conn)
            cmd.Parameters.AddWithValue("@id", id)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function ScalarStocks(id As Integer) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("select quantity from tblproducts where id = @id;", conn)
            cmd.Parameters.AddWithValue("@id", id)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function
End Class
