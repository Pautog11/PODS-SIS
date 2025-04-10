Imports System.Data.SqlClient
Public Class BaseVendor
    Inherits SqlBaseConnection
    Implements ICommandPanel

    Private ReadOnly _data As Dictionary(Of String, String)

    Public Sub New(data As Dictionary(Of String, String))
        _data = data
    End Sub

    Public Sub Delete() Implements ICommandPanel.Delete
        'Throw New NotImplementedException()
    End Sub

    Public Sub Update() Implements ICommandPanel.Update
        Try
            _sqlCommand = New SqlCommand("UPDATE tblvendor  SET supplier_id = @supplier_id, first_name = @first_name, last_name = @last_name, contact_number = @contact_number WHERE id = @id", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@supplier_id", _data.Item("supplier_id"))
            _sqlCommand.Parameters.AddWithValue("@first_name", _data.Item("first_name"))
            _sqlCommand.Parameters.AddWithValue("@last_name", _data.Item("last_name"))
            _sqlCommand.Parameters.AddWithValue("@contact_number", _data.Item("contact_number"))
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))

            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Vendor has been updated successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BaseAuditTrail.AuditLogin(My.Settings.myId, "Update a vendor")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub Add() Implements ICommandPanel.Add
        Try
            _sqlCommand = New SqlCommand("INSERT INTO tblvendor (supplier_id, first_name, last_name, contact_number) VALUES (@supplier_id, @first_name, @last_name, @contact_number)", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@supplier_id", _data.Item("supplier_id"))
            _sqlCommand.Parameters.AddWithValue("@first_name", _data.Item("first_name"))
            _sqlCommand.Parameters.AddWithValue("@last_name", _data.Item("last_name"))
            _sqlCommand.Parameters.AddWithValue("@contact_number", _data.Item("contact_number"))

            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Vendor has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BaseAuditTrail.AuditLogin(My.Settings.myId, "Add a vendor")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Shared Function NameWithNumberExists(first_name As String, last_name As String, number As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblvendor WHERE LOWER(first_name) = @first_name AND LOWER(last_name) = @last_name AND contact_number = @number", conn)
            cmd.Parameters.AddWithValue("@first_name", first_name.Trim.ToLower)
            cmd.Parameters.AddWithValue("@last_name", last_name.Trim.ToLower)
            cmd.Parameters.AddWithValue("@number", number)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    Public Shared Function GetVendorBySupplierId(supplier_id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT id, CONCAT(first_name, ' ', last_name) AS 'name' FROM tblvendor WHERE supplier_id = @supplier_id", conn)
            cmd.Parameters.AddWithValue("@supplier_id", supplier_id)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    Public Shared Function GetVendorById(supplier_id As Integer) As DataTable
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            cmd = New SqlCommand("SELECT id, CONCAT(first_name, ' ', last_name) as name FROM tblvendor where id = @id", conn)
            cmd.Parameters.AddWithValue("@id", supplier_id)
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            Return dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return New DataTable
        End Try
    End Function

    Public Shared Function ContactNumberExists(number As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblvendor WHERE contact_number = @number", conn)
            cmd.Parameters.AddWithValue("@number", number)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function


    Public Shared Function NameBelongstoNumber(first_name As String, last_name As String, number As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblvendor WHERE first_name = @first_name AND last_name = @last_name AND contact_number = @number", conn)
            cmd.Parameters.AddWithValue("@first_name", first_name.Trim.ToLower)
            cmd.Parameters.AddWithValue("@last_name", last_name.Trim.ToLower)
            cmd.Parameters.AddWithValue("@number", number)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    'Public Shared Function ContactNumberExistsWithId(id As Integer, number As String) As Integer
    '    Try
    '        Dim conn As SqlConnection = SqlConnectionPods.GetInstance
    '        Dim cmd As New SqlCommand("SELECT count(*) FROM tblvendor WHERE id = @id AND contact_number = @number", conn)
    '        cmd.Parameters.AddWithValue("@id", id)
    '        cmd.Parameters.AddWithValue("@number", number)

    '        Return cmd.ExecuteScalar()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return 0
    '    End Try
    'End Function

    Public Shared Function NameExist(id As Integer, firstname As String, lastname As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblvendor WHERE supplier_id = @id AND LOWER(first_name) = @firstname AND LOWER(last_name) = @lastname;", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@firstname", firstname.Trim.ToLower)
            cmd.Parameters.AddWithValue("@lastname", lastname.Trim.ToLower)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function


    Public Shared Function IdNameExist(id As Integer, suppid As Integer, firstname As String, lastname As String) As Integer
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblvendor WHERE id = @id AND supplier_id = @supplier_id AND LOWER(first_name) = @firstname AND LOWER(last_name) = @lastname;", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@supplier_id", suppid)
            cmd.Parameters.AddWithValue("@firstname", firstname.Trim.ToLower)
            cmd.Parameters.AddWithValue("@lastname", lastname.Trim.ToLower)

            Return cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function

    'Public Shared Function IdNameExist(id As Integer, supplier_id As Integer, firstname As String, lastname As String, number As String) As Integer
    '    Try
    '        Dim conn As SqlConnection = SqlConnectionPods.GetInstance
    '        Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblvendor WHERE id = @id AND supplier_id = @supplier_id AND LOWER(first_name) = @firstname AND LOWER(last_name) = @lastname", conn)
    '        cmd.Parameters.AddWithValue("@id", id)
    '        cmd.Parameters.AddWithValue("@supplier_id", supplier_id)
    '        cmd.Parameters.AddWithValue("@firstname", firstname.Trim.ToLower)
    '        cmd.Parameters.AddWithValue("@lastname", lastname.Trim.ToLower)

    '        Return cmd.ExecuteScalar()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return 0
    '    End Try
    'End Function
End Class