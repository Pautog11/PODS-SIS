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
            _sqlCommand = New SqlCommand("INSERT INTO tbltransactions (account_id, transaction_number, subtotal,  vat, discount, total, date, cash) 
                                          VALUES (@account_id, @transaction_number, @subtotal, @vat, @discount, @total, @date, @cash); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@account_id", My.Settings.myId)
            _sqlCommand.Parameters.AddWithValue("@transaction_number", _data.Item("transaction_number"))
            _sqlCommand.Parameters.AddWithValue("@subtotal", _data.Item("subtotal")) '_sqlCommand.Parameters.AddWithValue("@vatable", _data.Item("vatable"))
            _sqlCommand.Parameters.AddWithValue("@vat", _data.Item("vat"))
            _sqlCommand.Parameters.AddWithValue("@discount", _data.Item("discount"))
            _sqlCommand.Parameters.AddWithValue("@total", _data.Item("total"))
            _sqlCommand.Parameters.AddWithValue("@date", _data.Item("date"))
            _sqlCommand.Parameters.AddWithValue("@cash", _data.Item("cash"))

            Dim TransactionID As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())

            For Each item In _item
                _sqlCommand.Parameters.Clear()
                _sqlCommand = New SqlCommand("EXEC updateinventory @id, @quantity, @transaction_id", _sqlConnection, transaction)
                _sqlCommand.Parameters.AddWithValue("@id", item("product_id"))
                _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                _sqlCommand.Parameters.AddWithValue("@transaction_id", TransactionID)
                _sqlCommand.ExecuteNonQuery()
            Next

            For Each item In _item
                _sqlCommand.Parameters.Clear()
                _sqlCommand = New SqlCommand("INSERT INTO tbltransaction_items (transaction_id, product_id, price, quantity) VALUES (@transaction_id, @product_id, @price, @quantity)", _sqlConnection, transaction)
                _sqlCommand.Parameters.Clear()
                _sqlCommand.Parameters.AddWithValue("@transaction_id", TransactionID)
                _sqlCommand.Parameters.AddWithValue("@product_id", item("product_id"))
                _sqlCommand.Parameters.AddWithValue("@price", item("price"))
                _sqlCommand.Parameters.AddWithValue("@quantity", item("quantity"))
                _sqlCommand.ExecuteNonQuery()
            Next

            transaction.Commit()
            MessageBox.Show("Transaction has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim reslt As DialogResult = MessageBox.Show("Do you want to print a receipt?", "PODS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If reslt = DialogResult.Yes Then
                Using dialog As New ReceiptViewer(TransactionID)
                    dialog.ShowDialog()
                End Using
            End If
            'MessageBox.Show("Transaction has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    'Public Shared Function ScalarTransaction() As Integer
    '    Try
    '        Dim conn As SqlConnection = SqlConnectionPods.GetInstance
    '        Dim cmd As New SqlCommand("SELECT CASE WHEN SUM(total) IS NULL THEN 0 ELSE SUM(total) END FROM tbltransactions;", conn)
    '        Return cmd.ExecuteScalar()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return 0
    '    End Try
    'End Function

    ''' <summary>
    ''' Fetch vat
    ''' </summary>
    ''' <returns></returns>
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
            cmd = New SqlCommand("SELECT b.id, 
                                        product_name, 
                                        price, quantity, 
                                        SUM(price * quantity) AS total 
                                FROM tbltransaction_items a
                                JOIN tblproducts b on  a.product_id = b.id
                                WHERE transaction_id = @transaction_id
								GROUP BY b.id, 
                                        product_name, 
                                        price, 
                                        quantity", conn)
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
    ''' fetch data by barcode
    ''' </summary>
    ''' <param name="barcode"></param>
    ''' <returns></returns>
    Public Shared Function FetchByBarcode(barcode As String) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("WITH 
                                        LatestPrice AS (
                                            SELECT 
                                                b.product_id AS idngprod,
                                                b.price,
												b.cost_price,
                                                ROW_NUMBER() OVER (PARTITION BY b.product_id ORDER BY b.id DESC) AS row_num
                                            FROM tbldeliveries_items b
                                            LEFT JOIN tblproducts a ON a.id = b.product_id
                                            WHERE a.barcode = @barcode and b.inventory_quantity != 0
                                        ),
                                        TotalQuantity AS (
                                            SELECT 
                                                b.product_id AS idngprod,
                                                SUM(b.inventory_quantity) AS total_quantity
                                            FROM tbldeliveries_items b
                                            WHERE b.product_id IN (SELECT id FROM tblproducts WHERE barcode = @barcode)
                                            GROUP BY b.product_id
                                        )
                                    SELECT 
                                        a.id AS idngprod,
                                        a.product_name,
                                        lp.price AS price,
                                        tq.total_quantity AS quantity,
										lp.cost_price AS cost
                                    FROM tblproducts a
                                    LEFT JOIN LatestPrice lp ON lp.idngprod = a.id AND lp.row_num = 1
                                    LEFT JOIN TotalQuantity tq ON tq.idngprod = a.id
                                    WHERE a.barcode = @barcode
                                    ORDER BY idngprod DESC;", conn)
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
    ''' To fetch product by name
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns></returns>
    Public Shared Function FetchByName(name As String) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("WITH 
                                        LatestPrice AS (
                                            SELECT 
                                                b.product_id AS idngprod,
                                                b.price,
												b.cost_price as cost,
                                                ROW_NUMBER() OVER (PARTITION BY b.product_id ORDER BY b.id DESC) AS row_num
                                            FROM tbldeliveries_items b
                                            LEFT JOIN tblproducts a ON a.id = b.product_id
                                            WHERE a.product_name = LOWER(@name) AND b.inventory_quantity != 0
                                        ),
                                        TotalQuantity AS (
                                            SELECT 
                                                b.product_id AS idngprod,
                                                SUM(b.inventory_quantity) AS total_quantity
                                            FROM tbldeliveries_items b
                                            WHERE b.product_id IN (SELECT id FROM tblproducts WHERE product_name = LOWER(@name))
                                            GROUP BY b.product_id
                                        )
                                    SELECT 
                                        a.id AS idngprod,
                                        a.product_name,
                                        lp.price AS price,
                                        tq.total_quantity AS quantity,
										lp.cost
                                    FROM tblproducts a
                                    LEFT JOIN LatestPrice lp ON lp.idngprod = a.id AND lp.row_num = 1
                                    LEFT JOIN TotalQuantity tq ON tq.idngprod = a.id
                                    WHERE a.product_name = LOWER(@name)
                                    ORDER BY idngprod DESC;", conn)
            cmd.Parameters.AddWithValue("@name", name.Trim.ToLower)
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
    ''' Fetch product by id
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Shared Function FetchByID(id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("WITH 
                                        LatestPrice AS (
                                            SELECT 
                                                b.product_id AS idngprod,
                                                b.price,
                                                ROW_NUMBER() OVER (PARTITION BY b.product_id ORDER BY b.id DESC) AS row_num
                                            FROM tbldeliveries_items b
                                            LEFT JOIN tblproducts a ON a.id = b.product_id
                                            WHERE a.id = @id
                                        ),
                                        TotalQuantity AS (
                                            SELECT 
                                                b.product_id AS idngprod,
                                                SUM(b.inventory_quantity) AS total_quantity
                                            FROM tbldeliveries_items b
                                            WHERE b.product_id IN (SELECT id FROM tblproducts WHERE id = @id)
                                            GROUP BY b.product_id
                                        )
                                    SELECT 
                                        a.id AS idngprod,
                                        a.product_name,
                                        lp.price AS price,
                                        tq.total_quantity AS quantity
                                    FROM tblproducts a
                                    LEFT JOIN LatestPrice lp ON lp.idngprod = a.id AND lp.row_num = 1
                                    LEFT JOIN TotalQuantity tq ON tq.idngprod = a.id
                                    WHERE a.id = @id
                                    ORDER BY idngprod DESC;", conn)
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

    Public Shared Function FetchDiscounts() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT discount, concat(discount,'%',' ',description) as des FROM tbldiscounts", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    'Public Shared Function ScalarChartTransaction(timePeriod As String) As DataTable
    '    Try
    '        ' Get a connection from the connection pool
    '        Dim conn As SqlConnection = SqlConnectionPods.GetInstance()

    '        ' Ensure the connection is open
    '        If conn.State <> ConnectionState.Open Then
    '            conn.Open()
    '        End If

    '        ' SQL query to get the sum of total transactions grouped by time period
    '        Dim cmd As New SqlCommand()

    '        ' Set the connection for the SqlCommand
    '        cmd.Connection = conn

    '        Select Case timePeriod.ToLower()
    '            Case "daily"
    '                ' Group by exact date (casting to date without time part)
    '                cmd.CommandText = "SELECT CAST(Date AS DATE) AS TransactionDate, SUM(total) AS Total FROM tbltransactions GROUP BY CAST(Date AS DATE) ORDER BY TransactionDate"

    '            Case "weekly"
    '                ' Group by week starting from Sunday to Saturday
    '                cmd.CommandText = "SELECT " &
    '                              "DATEADD(WEEK, DATEDIFF(WEEK, 0, Date), 0) AS WeekStart, " &
    '                              "SUM(total) AS Total " &
    '                              "FROM tbltransactions " &
    '                              "WHERE Date >= DATEADD(DAY, -DATEPART(WEEKDAY, GETDATE()) + 1, CAST(GETDATE() AS DATE)) " & _  ' Sunday of current week
    '                              "AND Date < DATEADD(DAY, 7 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE)) " & _  ' Saturday of current week
    '                              "GROUP BY DATEADD(WEEK, DATEDIFF(WEEK, 0, Date), 0) " &
    '                              "ORDER BY WeekStart"

    '            Case "monthly"
    '                ' Group by year and month (YEAR and MONTH)
    '                cmd.CommandText = "SELECT YEAR(Date) AS Year, MONTH(Date) AS Month, SUM(total) AS Total FROM tbltransactions GROUP BY YEAR(Date), MONTH(Date) ORDER BY Year, Month"

    '            Case "annually"
    '                ' Group by year
    '                cmd.CommandText = "SELECT YEAR(Date) AS Year, SUM(total) AS Total FROM tbltransactions GROUP BY YEAR(Date) ORDER BY Year"

    '            Case Else
    '                ' Default to daily if invalid selection
    '                cmd.CommandText = "SELECT CAST(Date AS DATE) AS TransactionDate, SUM(total) AS Total FROM tbltransactions GROUP BY CAST(Date AS DATE) ORDER BY TransactionDate"
    '        End Select

    '        ' Create a DataTable to hold the results
    '        Dim dt As New DataTable()

    '        ' Use a data adapter to fill the DataTable with the result set
    '        Dim da As New SqlDataAdapter(cmd)
    '        da.Fill(dt)

    '        ' Return the DataTable containing the aggregated data
    '        Return dt
    '    Catch ex As Exception
    '        ' If an error occurs, display a message and return an empty DataTable
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return Nothing
    '    End Try
    'End Function

    'Public Shared Function NamebyID(product_name As String) As Integer
    '    Try
    '        Dim conn As SqlConnection = SqlConnectionPods.GetInstance
    '        Dim cmd As New SqlCommand("select id from tblproducts where product_name = @product_name;", conn)
    '        cmd.Parameters.AddWithValue("@product_name", product_name)
    '        Return cmd.ExecuteScalar()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return 0
    '    End Try
    'End Function

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

    Public Shared Function ScalarSales() As Decimal
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COALESCE(SUM(total), 0) AS total_sum
                                       FROM tbltransactions
                                       WHERE CAST(date AS DATE) = CAST(GETDATE() AS DATE);", conn)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function ScalarTransaction() As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COALESCE(COUNT(*), 0) AS sale
                                       FROM tbltransactions
                                       WHERE CAST(date AS DATE) = CAST(GETDATE() AS DATE);", conn)
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function
End Class
