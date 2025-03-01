Imports System.Data.SqlClient
Public Class BaseSupplier
    Inherits SqlBaseConnection
    Implements ICommandPanel

    Private ReadOnly _data As Dictionary(Of String, String)

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
    End Sub

    Public Sub Delete() Implements ICommandPanel.Delete
        Try
            _sqlCommand = New SqlCommand("DELETE tblsuppliers WHERE id = @id", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Supplier has been deleted successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub Update() Implements ICommandPanel.Update
        Try
            _sqlCommand = New SqlCommand("UPDATE tblsuppliers SET company_name = @company_name, company_contact_number = @company_contact_number, company_address = @company_address, first_name = @first_name, last_name = @last_name, phone_number = @phone_number, allow_refund = @allow_refund WHERE id = @id", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            _sqlCommand.Parameters.AddWithValue("@company_name", _data.Item("company_name"))
            _sqlCommand.Parameters.AddWithValue("@company_contact_number", _data.Item("company_contact_number"))
            _sqlCommand.Parameters.AddWithValue("@company_address", _data.Item("company_address"))
            _sqlCommand.Parameters.AddWithValue("@first_name", _data.Item("first_name"))
            _sqlCommand.Parameters.AddWithValue("@last_name", _data.Item("last_name"))
            _sqlCommand.Parameters.AddWithValue("@phone_number", _data.Item("phone_number"))
            _sqlCommand.Parameters.AddWithValue("@allow_refund", _data.Item("allow_refund"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Supplier has been updated successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        Try
            _sqlCommand = New SqlCommand("INSERT INTO tblsuppliers (company_name, company_contact_number, company_address, first_name, last_name, phone_number, allow_refund) VALUES (@company_name, @company_contact_number, @company_address, @first_name, @last_name, @phone_number, @allow_refund)", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@company_name", _data.Item("company_name"))
            _sqlCommand.Parameters.AddWithValue("@company_contact_number", _data.Item("company_contact_number"))
            _sqlCommand.Parameters.AddWithValue("@company_address", _data.Item("company_address"))
            _sqlCommand.Parameters.AddWithValue("@first_name", _data.Item("first_name"))
            _sqlCommand.Parameters.AddWithValue("@last_name", _data.Item("last_name"))
            _sqlCommand.Parameters.AddWithValue("@phone_number", _data.Item("phone_number"))
            _sqlCommand.Parameters.AddWithValue("@allow_refund", _data.Item("allow_refund"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Supplier has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Shared Function Fetchsupplier() As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT * FROM tblsuppliers", conn)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function
    Public Shared Function Exists(fn As String, ln As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblsuppliers WHERE lower(first_name) = @first_name AND lower(last_name) = @last_name", conn)
            cmd.Parameters.AddWithValue("@first_name", fn.Trim.ToLower)
            cmd.Parameters.AddWithValue("@last_name", ln.Trim.ToLower)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function Search(query As String) As pods.viewtblsuppliersDataTable 'pods.tblaccountsDataTable
        Try
            Dim conn As New SqlConnection(My.Settings.podsdbConnectionString)
            Dim cmd As New SqlCommand("SELECT * FROM viewtblsuppliers WHERE id <> 1 AND NAME LIKE CONCAT('%', @query, '%') OR COMPANY LIKE CONCAT('%', @query, '%')", conn)
            cmd.Parameters.AddWithValue("@query", query)
            Dim dTable As New pods.viewtblsuppliersDataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New pods.viewtblsuppliersDataTable
        End Try
    End Function

    Public Shared Function AllowsRefund(id As Integer) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT allow_refund FROM tblsuppliers WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@id", id)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function
End Class
