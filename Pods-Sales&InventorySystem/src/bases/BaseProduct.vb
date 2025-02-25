Imports System.Data.SqlClient
Public Class BaseProduct
    Inherits SqlBaseConnection
    Implements ICommandPanel

    Private ReadOnly _data As Dictionary(Of String, String)
    'Private _item As Dictionary(Of String, String)

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
    End Sub

    'Public Property Items() As Dictionary(Of String, String)
    '    Set(value As Dictionary(Of String, String))
    '        _item = value
    '    End Set
    '    Get
    '        Return _item
    '    End Get
    'End Property

    Public Sub Delete() Implements ICommandPanel.Delete
        Try
            _sqlCommand = New SqlCommand("DELETE tblproducts WHERE id = @id", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!")
            Else
                MessageBox.Show("Product has been deleted successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub Update() Implements ICommandPanel.Update
        Dim transaction As SqlTransaction = SqlConnectionPods.GetInstance.BeginTransaction()
        Try
            'Dim pnameup As String = _data("product_name").ToString()
            '_sqlCommand = New SqlCommand("SELECT product_name FROM tblproducts WHERE id = @id", _sqlConnection)
            '_sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            'Dim pname As String = _sqlCommand.ExecuteScalar
            'BaseAuditTrail.AddProduct(My.Settings.myId, $"Updated a product {pname} to {pnameup}")

            '_sqlCommand.Parameters.Clear()
            _sqlCommand = New SqlCommand("UPDATE tblproducts SET subcategory_id = @subcategory_id, barcode = @barcode, product_name = @product_name, description = @description, critical_level = @critical_level, expiration = @expiration WHERE id = @id", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            _sqlCommand.Parameters.AddWithValue("@subcategory_id", _data.Item("subcategory_id"))
            _sqlCommand.Parameters.AddWithValue("@barcode", If(String.IsNullOrEmpty(_data.Item("barcode")), DBNull.Value, _data.Item("barcode")))
            _sqlCommand.Parameters.AddWithValue("@product_name", _data.Item("product_name"))
            _sqlCommand.Parameters.AddWithValue("@description", If(String.IsNullOrEmpty(_data.Item("description")), DBNull.Value, _data.Item("description"))) '_data.Item("description"))
            _sqlCommand.Parameters.AddWithValue("@critical_level", _data.Item("critical_level"))
            _sqlCommand.Parameters.AddWithValue("@expiration", _data.Item("expiration"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                Throw New Exception("Failed to update product!")
            End If

            _sqlCommand.Parameters.Clear()
            _sqlCommand = New SqlCommand("UPDATE tblproduct_info SET dosage_form = @dosage_form, strength = @strength, dose = @dose, manufacturer = @manufacturer WHERE product_id = @product_id;", _sqlConnection, Transaction)
            _sqlCommand.Parameters.AddWithValue("@product_id", _data.Item("id"))
            _sqlCommand.Parameters.AddWithValue("@dosage_form", If(String.IsNullOrEmpty(_data.Item("dosage_form")), DBNull.Value, _data.Item("dosage_form")))
            _sqlCommand.Parameters.AddWithValue("@strength", If(String.IsNullOrEmpty(_data.Item("strength")), DBNull.Value, _data.Item("strength")))
            _sqlCommand.Parameters.AddWithValue("@dose", If(String.IsNullOrEmpty(_data.Item("dose")), DBNull.Value, _data.Item("dose")))
            _sqlCommand.Parameters.AddWithValue("@manufacturer", If(String.IsNullOrEmpty(_data.Item("manufacturer")), DBNull.Value, _data.Item("manufacturer")))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                Throw New Exception("Failed to update product!")
            End If
            MessageBox.Show("Product has been updated successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Transaction.Commit()
        Catch ex As Exception
            Transaction.Rollback()
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        Dim transaction As SqlTransaction = SqlConnectionPods.GetInstance.BeginTransaction()
        Try
            _sqlCommand = New SqlCommand("INSERT INTO tblproducts (subcategory_id, barcode, product_name, description, critical_level, expiration) VALUES (@subcategory_id, @barcode, @product_name, @description, @critical_level, @expiration); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@subcategory_id", _data.Item("subcategory_id"))
            _sqlCommand.Parameters.AddWithValue("@barcode", If(String.IsNullOrEmpty(_data.Item("barcode")), DBNull.Value, _data.Item("barcode")))
            _sqlCommand.Parameters.AddWithValue("@product_name", _data.Item("product_name"))
            _sqlCommand.Parameters.AddWithValue("@description", If(String.IsNullOrEmpty(_data.Item("description")), DBNull.Value, _data.Item("description"))) '_data.Item("description"))
            _sqlCommand.Parameters.AddWithValue("@critical_level", _data.Item("critical_level"))
            _sqlCommand.Parameters.AddWithValue("@expiration", _data.Item("expiration"))
            Dim productid As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())

            _sqlCommand.Parameters.Clear()
            _sqlCommand = New SqlCommand("INSERT INTO tblproduct_info (product_id, dosage_form, strength, dose, manufacturer) VALUES (@product_id, @dosage_form, @strength, @dose, @manufacturer)", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@product_id", productid)
            _sqlCommand.Parameters.AddWithValue("@dosage_form", If(String.IsNullOrEmpty(_data.Item("dosage_form")), DBNull.Value, _data.Item("dosage_form")))
            _sqlCommand.Parameters.AddWithValue("@strength", If(String.IsNullOrEmpty(_data.Item("strength")), DBNull.Value, _data.Item("strength")))
            _sqlCommand.Parameters.AddWithValue("@dose", If(String.IsNullOrEmpty(_data.Item("dose")), DBNull.Value, _data.Item("dose")))
            _sqlCommand.Parameters.AddWithValue("@manufacturer", If(String.IsNullOrEmpty(_data.Item("manufacturer")), DBNull.Value, _data.Item("manufacturer")))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                Throw New Exception("Failed to add product!")
            End If

            'If _item.Item("dosage") = "" And _item.Item("strength") = "" And _item.Item("manufacturer") = "" Then
            '    _item = Nothing
            'End If

            'If String.IsNullOrEmpty(_item.Item("dosage_form")) AndAlso String.IsNullOrEmpty(_item.Item("strength")) AndAlso String.IsNullOrEmpty(_item.Item("manufacturer")) Then _item = Nothing

            'If _item IsNot Nothing Then
            '    Dim productid As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())
            '    _sqlCommand.Parameters.Clear()
            '    _sqlCommand = New SqlCommand("INSERT INTO tblproduct_info (product_id, dosage_form, strength, manufacturer) VALUES (@product_id, @dosage_form, @strength, @manufacturer)", _sqlConnection, transaction)
            '    _sqlCommand.Parameters.AddWithValue("@product_id", productid)
            '    _sqlCommand.Parameters.AddWithValue("@dosage_form", _item.Item("dosage")) '_item.Item("dosage"))
            '    _sqlCommand.Parameters.AddWithValue("@strength", _item.Item("strength"))
            '    _sqlCommand.Parameters.AddWithValue("@manufacturer", _item.Item("manufacturer"))
            'End If

            'If _item IsNot Nothing Then
            '    ' Ensure the dictionary contains the necessary keys before accessing them
            '    If _item.ContainsKey("dosage") AndAlso _item.ContainsKey("strength") AndAlso _item.ContainsKey("manufacturer") Then
            '        ' Execute the SQL query and get the product ID
            '        'Dim productid As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())
            '        _sqlCommand.Parameters.Clear()

            '        ' Prepare the SQL command for insertion
            '        _sqlCommand = New SqlCommand("INSERT INTO tblproduct_info (product_id, dosage_form, strength, dose, manufacturer) VALUES (@product_id, @dosage_form, @strength, @dose, @manufacturer)", _sqlConnection, transaction)

            '        ' Add the parameters with appropriate values from the dictionary
            '        _sqlCommand.Parameters.AddWithValue("@product_id", productid)
            '        _sqlCommand.Parameters.AddWithValue("@dosage_form", _item("dosage")) ' Using the dictionary's Item method
            '        _sqlCommand.Parameters.AddWithValue("@strength", _item("strength"))
            '        _sqlCommand.Parameters.AddWithValue("@dose", _item("dose"))
            '        _sqlCommand.Parameters.AddWithValue("@manufacturer", _item("manufacturer"))
            '        If _sqlCommand.ExecuteNonQuery() <= 0 Then
            '            Throw New Exception("Failed to add delivery items!")
            '        End If
            '        'Else
            '        '    ' Handle the case where some expected keys are missing in the dictionary
            '        '    Throw New Exception("The dictionary is missing required keys: dosage, strength, or manufacturer.")
            '    End If

            'End If

            'If _sqlCommand.ExecuteNonQuery() <= 0 Then
            '    'Throw New Exception("Failed to add delivery items!")
            '    Throw New Exception("An error occured!")
            'End If


            MessageBox.Show("Product has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            transaction.Commit()
            'Dim pname As String = _data("product_name").ToString()
            'Dim manuname As String = If(_item?.ContainsKey("manufacturer"), _item("manufacturer").ToString(), "Unknown Manufacturer")
            'BaseAuditTrail.AddProduct(My.Settings.myId, $"Added a product {pname} - {manuname}")
        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
    Public Shared Function FillBySubCategory() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT * FROM tblsubcategories", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    Public Shared Function Exists(product_name As String, barcode As Object) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("WITH freak AS (
                                        SELECT * 
                                        FROM tblproducts 
                                        WHERE product_name = @product_name)
                                        SELECT CASE 
                                               WHEN EXISTS (
                                                   SELECT 1 
                                                   FROM freak 
                                                   WHERE LOWER(product_name) = LOWER(@product_name)
                                                     AND (barcode = @barcode OR (barcode IS NULL AND @barcode IS NULL))
                                               )
                                               THEN 1
                                               ELSE 0 
                                           END AS result;", conn)
            cmd.Parameters.AddWithValue("@product_name", product_name.Trim.ToLower)
            'cmd.Parameters.AddWithValue("@barcode", If(String.IsNullOrEmpty(barcode), DBNull.Value, barcode))
            If barcode Is Nothing OrElse String.IsNullOrEmpty(barcode.ToString()) Then
                cmd.Parameters.AddWithValue("@barcode", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@barcode", barcode)
            End If

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function ScalarSubcategoryId(subcategory As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT id FROM tblsubcategories WHERE subcategory = @subcategory", conn)
            cmd.Parameters.AddWithValue("@subcategory", subcategory)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function BarcodeExist(barcode As String) As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblproducts WHERE barcode = @barcode", conn)
            cmd.Parameters.AddWithValue("@barcode", barcode)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function IdBarcodeExist(id As Integer, barcode As String) As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblproducts WHERE id = @id and barcode = @barcode", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@barcode", barcode)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function Search(query As String) As pods.viewtblproductsDataTable 'pods.tblaccountsDataTable
        Try
            Dim conn As New SqlConnection(My.Settings.podsdbConnectionString)
            Dim cmd As New SqlCommand("SELECT * 
                                        FROM viewtblproducts 
                                        WHERE id <> 1 
                                        AND (CATEGORY LIKE CONCAT('%', @query, '%') OR SUBCATEGORY LIKE CONCAT('%', @query, '%') OR PRODUCT LIKE CONCAT('%', @query, '%'))", conn)
            cmd.Parameters.AddWithValue("@query", query)
            Dim dTable As New pods.viewtblproductsDataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New pods.viewtblproductsDataTable
        End Try
    End Function

    'Public Shared Function ProductInfo(id As String) As DataTable
    '    Try
    '        Dim conn As SqlConnection = SqlConnectionPods.GetInstance
    '        Dim cmd As New SqlCommand("SELECT BARCODE, QUANTITY, PRICE, COST FROM viewtblproducts WHERE id = @id", conn)
    '        cmd.Parameters.AddWithValue("@id", id)
    '        Dim dTable As New DataTable
    '        Dim adapter As New SqlDataAdapter(cmd)
    '        adapter.Fill(dTable)
    '        Return dTable
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return New DataTable
    '    End Try
    'End Function

    'Public Shared Function FetchProductBySubcategory(subcategory_id As String) As DataTable
    '    Try
    '        Dim conn As SqlConnection = SqlConnectionPods.GetInstance
    '        Dim cmd As New SqlCommand("SELECT id, product_name FROM tblproducts WHERE subcategory_id = @subcategory_id", conn)
    '        cmd.Parameters.AddWithValue("subcategory_id", subcategory_id)
    '        Dim dTable As New DataTable
    '        Dim adapter As New SqlDataAdapter(cmd)
    '        adapter.Fill(dTable)
    '        Return dTable
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return New DataTable
    '    End Try
    'End Function
    'Public Shared Function ScalarProductId(product_name As String) As Integer
    '    Try
    '        Dim conn As SqlConnection = SqlConnectionPods.GetInstance
    '        Dim cmd As New SqlCommand("SELECT id FROM tblproducts WHERE product_name = @product_name", conn)
    '        cmd.Parameters.AddWithValue("@product_name", product_name)

    '        Return cmd.ExecuteScalar()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return 0
    '    End Try
    'End Function

    Public Shared Function Fillproductinfo(product_id As String) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT dosage_form, strength, dose, manufacturer FROM tblproduct_info WHERE product_id = @product_id", conn)
            cmd.Parameters.AddWithValue("product_id", product_id)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    Public Shared Function PopulateAutoCompleteList() As AutoCompleteStringCollection
        Try
            Dim autocompleteList As New AutoCompleteStringCollection()
            Dim _tableAdapter As New podsTableAdapters.viewtblproductsTableAdapter
            Dim accountsTable As pods.viewtblproductsDataTable = _tableAdapter.GetData()
            autocompleteList.Clear()
            For Each row As pods.viewtblproductsRow In accountsTable
                autocompleteList.Add(row.PRODUCT)
            Next
            Return autocompleteList
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New AutoCompleteStringCollection()
        End Try
    End Function

    'Public Shared Function Disableexd(id As Integer) As Integer
    '    Try
    '        Dim conn As SqlConnection = SqlConnectionPods.GetInstance
    '        Dim cmd As New SqlCommand("select count(*) from tblproducts a join tblproduct_info b on a.id = b.product_id where a.id = @id", conn)
    '        cmd.Parameters.AddWithValue("@id", id)

    '        Return cmd.ExecuteScalar()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return 0
    '    End Try
    'End Function

    'Public Shared Function BarcodeExists(barcode As String) As Integer
    '    Try
    '        Dim conn As SqlConnection = SqlConnectionPods.GetInstance
    '        Dim cmd As New SqlCommand("select count(*) from tblproducts where barcode = @barcode", conn)
    '        cmd.Parameters.AddWithValue("@barcode", barcode)

    '        Return cmd.ExecuteScalar()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return 0
    '    End Try
    'End Function

    'Public Shared Function SearchDilog(query As String) As pods.viewtblproductsearchDataTable 'pods.tblaccountsDataTable
    '    Try
    '        Dim conn As New SqlConnection(My.Settings.podsdbConnectionString)
    '        Dim cmd As New SqlCommand("SELECT * FROM viewtblproductsearch WHERE id <> 1 AND NAME LIKE CONCAT('%', @query, '%')", conn)
    '        cmd.Parameters.AddWithValue("@query", query)
    '        Dim dTable As New pods.viewtblproductsearchDataTable
    '        Dim adapter As New SqlDataAdapter(cmd)
    '        adapter.Fill(dTable)
    '        Return dTable
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return New pods.viewtblproductsearchDataTable
    '    End Try
    'End Function

    'Public Shared Function ChangeDialog(id As Integer) As Integer
    '    Try
    '        Dim conn As SqlConnection = SqlConnectionPods.GetInstance
    '        Dim cmd As New SqlCommand("SELECT 
    '                                    CASE 
    '                                        WHEN EXISTS (
    '                                            SELECT 1 
    '                                            FROM tblproduct_info t2 
    '                                            WHERE t2.product_id = t1.id
    '                                        ) THEN 1 
    '                                        ELSE 0 
    '                                    END AS id_exists
    '                                FROM tblproducts t1 where t1.id = @id", conn)
    '        cmd.Parameters.AddWithValue("@id", id)
    '        Return cmd.ExecuteScalar()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return 0
    '    End Try
    'End Function

    'Public Shared Function FetchDosage() As DataTable
    '    Try
    '        Dim conn As New SqlConnection(My.Settings.podsdbConnectionString)
    '        Dim cmd As New SqlCommand("SELECT * FROM tbldosage", conn)
    '        Dim dTable As New DataTable
    '        Dim adapter As New SqlDataAdapter(cmd)
    '        adapter.Fill(dTable)
    '        Return dTable
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return New DataTable
    '    End Try
    'End Function

    Public Shared Function DoseName(dasage As String) As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT id FROM tbldosage WHERE LOWER(dasage) = @dasage", conn)
            cmd.Parameters.AddWithValue("@dasage", dasage.Trim.ToLower)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function CheckProductname(name As String) As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblproducts WHERE LOWER(product_name) = @product_name", conn)
            cmd.Parameters.AddWithValue("@product_name", name.Trim.ToLower)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    'Private Shared Function SearchProduct() As AutoCompleteStringCollection
    '    'Using conn As New SqlConnection(connectionString)
    '    '    Using cmd As New SqlCommand(query, conn)
    '    '        conn.Open()

    '    '        Using reader As SqlDataReader = cmd.ExecuteReader()
    '    '            While reader.Read()
    '    '                autocompleteList.Add(reader("product_name").ToString())
    '    '            End While
    '    '        End Using
    '    '    End Using
    '    'End Using

    '    Try
    '        'Dim autocompleteList As New AutoCompleteStringCollection()
    '        Dim conn As SqlConnection = SqlConnectionPods.GetInstance
    '        Dim cmd As New SqlCommand("SELECT product_name FROM tblproducts", conn)
    '        Dim reader As SqlDataReader = cmd.ExecuteReader
    '        While reader.Read
    '            autocompleteList.Add(reader("product_name").ToString())
    '        End While
    '        Return autocompleteList.Count
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return 0
    '    End Try
    'End Function
End Class
