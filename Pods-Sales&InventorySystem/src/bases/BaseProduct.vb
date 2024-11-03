Imports System.Data.SqlClient
Public Class BaseProduct
    Inherits SqlBaseConnection
    Implements ICommandPanel

    Private ReadOnly _data As Dictionary(Of String, String)
    Private _item As Dictionary(Of String, String)

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
    End Sub

    Public Property Items() As Dictionary(Of String, String)
        Set(value As Dictionary(Of String, String))
            _item = value
        End Set
        Get
            Return _item
        End Get
    End Property

    Public Sub Delete() Implements ICommandPanel.Delete
        Try
            _sqlCommand = New SqlCommand("DELETE tblproducts WHERE id = @id", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!")
            Else
                MessageBox.Show("Account has been deleted successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub Update() Implements ICommandPanel.Update
        Try
            _sqlCommand = New SqlCommand("UPDATE tblproducts SET subcategory_id = @subcategory_id, sku = @sku, barcode = @barcode, product_name = @product_name, description = @description, product_price = @product_price, product_cost = @product_cost, stock_level = @stock_level WHERE id = @id", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            _sqlCommand.Parameters.AddWithValue("@subcategory_id", _data.Item("subcategory_id"))
            _sqlCommand.Parameters.AddWithValue("@sku", _data.Item("sku"))
            _sqlCommand.Parameters.AddWithValue("@barcode", _data.Item("barcode"))
            _sqlCommand.Parameters.AddWithValue("@product_name", _data.Item("product_name"))
            _sqlCommand.Parameters.AddWithValue("@description", If(String.IsNullOrEmpty(_data.Item("description")), DBNull.Value, _data.Item("description"))) '_data.Item("description"))
            _sqlCommand.Parameters.AddWithValue("@product_price", _data.Item("product_price"))
            _sqlCommand.Parameters.AddWithValue("@product_cost", _data.Item("product_cost"))
            _sqlCommand.Parameters.AddWithValue("@stock_level", _data.Item("stock_level"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!")
            Else
                MessageBox.Show("Account has been updated successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        Dim transaction As SqlTransaction = SqlConnectionPods.GetInstance.BeginTransaction()
        Try
            _sqlCommand = New SqlCommand("INSERT INTO tblproducts (subcategory_id, sku, barcode, product_name, description, product_price, product_cost, stock_level) VALUES (@subcategory_id, @sku, @barcode, @product_name, @description, @product_price, @product_cost, @stock_level); SELECT SCOPE_IDENTITY()", _sqlConnection, transaction)
            _sqlCommand.Parameters.AddWithValue("@subcategory_id", _data.Item("subcategory_id"))
            _sqlCommand.Parameters.AddWithValue("@sku", _data.Item("sku"))
            _sqlCommand.Parameters.AddWithValue("@barcode", _data.Item("barcode"))
            _sqlCommand.Parameters.AddWithValue("@product_name", _data.Item("product_name"))
            _sqlCommand.Parameters.AddWithValue("@description", If(String.IsNullOrEmpty(_data.Item("description")), DBNull.Value, _data.Item("description"))) '_data.Item("description"))
            _sqlCommand.Parameters.AddWithValue("@product_price", _data.Item("product_price"))
            _sqlCommand.Parameters.AddWithValue("@product_cost", _data.Item("product_cost"))
            _sqlCommand.Parameters.AddWithValue("@stock_level", _data.Item("stock_level"))
            'Dim productid As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())

            'If _item.Item("dosage") = "" And _item.Item("strength") = "" And _item.Item("manufacturer") = "" Then
            '    _item = Nothing
            'End If

            If String.IsNullOrEmpty(_item.Item("dosage")) AndAlso String.IsNullOrEmpty(_item.Item("strength")) AndAlso String.IsNullOrEmpty(_item.Item("manufacturer")) Then _item = Nothing

            If _item IsNot Nothing Then
                Dim productid As Integer = Convert.ToInt32(_sqlCommand.ExecuteScalar())
                _sqlCommand.Parameters.Clear()
                _sqlCommand = New SqlCommand("INSERT INTO tblproduct_info (product_id, dosage_form, strength, manufacturer) VALUES (@product_id, @dosage_form, @strength, @manufacturer)", _sqlConnection, transaction)
                _sqlCommand.Parameters.AddWithValue("@product_id", productid)
                _sqlCommand.Parameters.AddWithValue("@dosage_form", _item.Item("dosage")) '_item.Item("dosage"))
                _sqlCommand.Parameters.AddWithValue("@strength", _item.Item("strength"))
                _sqlCommand.Parameters.AddWithValue("@manufacturer", _item.Item("manufacturer"))
            End If

            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                Throw New Exception("Failed to add delivery items!")
            End If
            MessageBox.Show("Product has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            transaction.Commit()
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

    Public Shared Function Exists(data As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblproducts WHERE lower(sku) = @data", conn)
            cmd.Parameters.AddWithValue("@data", data.Trim.ToLower)

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

    Public Shared Function SubcategoryName(id As String) As String
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT subcategory FROM tblsubcategories WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function Search(query As String) As pods.viewtblproductsDataTable 'pods.tblaccountsDataTable
        Try
            Dim conn As New SqlConnection(My.Settings.podsdbConnectionString)
            Dim cmd As New SqlCommand("SELECT * FROM viewtblproducts WHERE id <> 1 AND BARCODE LIKE CONCAT('%', @query, '%') OR PRODUCT LIKE CONCAT('%', @query, '%')", conn)
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

    Public Shared Function ProductInfo(id As String) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT BARCODE, PRICE, COST FROM viewtblproducts WHERE id = @id", conn)
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

    Public Shared Function FetchProductBySubcategory(subcategory_id As String) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT id, product_name FROM tblproducts WHERE subcategory_id = @subcategory_id", conn)
            cmd.Parameters.AddWithValue("subcategory_id", subcategory_id)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function
    'Public Sub Sasa()
    '    Try
    '        _sqlCommand = New SqlCommand("INSERT INTO tblproduct_info (product_id, dosage_form, strength, manufacturer) VALUES (@product_id, @dosage_form, @strength, @manufacturer)", _sqlConnection)
    '        _sqlCommand.Parameters.AddWithValue("@product_id", 2)
    '        _sqlCommand.Parameters.AddWithValue("@dosage_form", _item.Item("dosage"))
    '        _sqlCommand.Parameters.AddWithValue("@strength", _item.Item("strength"))
    '        _sqlCommand.Parameters.AddWithValue("@manufacturer", _item.Item("manufacturer"))
    '        _sqlCommand.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Public Shared Function Fillproductinfo(product_id As String) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT dosage_form, strength, manufacturer FROM tblproduct_info WHERE product_id = @product_id", conn)
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
End Class
