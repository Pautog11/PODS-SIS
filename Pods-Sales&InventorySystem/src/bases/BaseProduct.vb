Imports System.Data.SqlClient
Public Class BaseProduct
    Inherits SqlBaseConnection
    Implements ICommandPanel

    Private ReadOnly _data As Dictionary(Of String, String)

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
    End Sub

    Public Sub Delete() Implements ICommandPanel.Delete
        Try
            _sqlCommand = New SqlCommand("DELETE tblproducts WHERE id = @id", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!")
            Else
                MessageBox.Show("Product has been deleted successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BaseAuditTrail.AuditLogin(My.Settings.myId, "Delete a product")
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
                Throw New Exception("An error occured!")
            End If

            _sqlCommand.Parameters.Clear()
            _sqlCommand = New SqlCommand("UPDATE tblproduct_info SET dosage_form = @dosage_form, strength = @strength, dose = @dose, manufacturer = @manufacturer WHERE product_id = @product_id;", _sqlConnection, Transaction)
            _sqlCommand.Parameters.AddWithValue("@product_id", _data.Item("id"))
            _sqlCommand.Parameters.AddWithValue("@dosage_form", If(String.IsNullOrEmpty(_data.Item("dosage_form")), DBNull.Value, _data.Item("dosage_form")))
            _sqlCommand.Parameters.AddWithValue("@strength", If(String.IsNullOrEmpty(_data.Item("strength")), DBNull.Value, _data.Item("strength")))
            _sqlCommand.Parameters.AddWithValue("@dose", If(String.IsNullOrEmpty(_data.Item("dose")), DBNull.Value, _data.Item("dose")))
            _sqlCommand.Parameters.AddWithValue("@manufacturer", If(String.IsNullOrEmpty(_data.Item("manufacturer")), DBNull.Value, _data.Item("manufacturer")))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                Throw New Exception("An error occured!")
            End If
            MessageBox.Show("Product has been updated successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            transaction.Commit()
            BaseAuditTrail.AuditLogin(My.Settings.myId, $"Update the product {_data.Item("product_name")}")
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
                Throw New Exception("An error occured!")
            End If

            MessageBox.Show("Product has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            transaction.Commit()
            BaseAuditTrail.AuditLogin(My.Settings.myId, $"Add a product {_data.Item("product_name")}")
        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
    Public Shared Function FillBySubCategory(subcategory_id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("WITH 
	                                Top_table as (select id, category_id, subcategory FROM tblsubcategories WHERE id = @subcategory_id),
	                                Others AS (SELECT * FROM tblsubcategories WHERE category_id = (SELECT category_id FROM Top_table))
	                                SELECT * FROM  tblsubcategories WHERE id = @subcategory_id
	                                UNION ALL 
	                                SELECT * FROM Others WHERE id <> @subcategory_id", conn)
            cmd.Parameters.AddWithValue("@subcategory_id", subcategory_id)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    Public Shared Function Filltite(category_id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT * FROM tblsubcategories WHERE category_id = @category_id", conn)
            cmd.Parameters.AddWithValue("@category_id", category_id)
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

    Public Shared Function CheckProductnameWithID(id As Integer, name As String) As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblproducts WHERE id = @id AND LOWER(product_name) = @product_name", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@product_name", name.Trim.ToLower)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function Getname(id As Integer) As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT product_name FROM tblproducts WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function NameExist(name As String) As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT count(*) FROM tblproducts WHERE LOWER(product_name) = @name", conn)
            cmd.Parameters.AddWithValue("@name", name.Trim.ToLower)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function
End Class
