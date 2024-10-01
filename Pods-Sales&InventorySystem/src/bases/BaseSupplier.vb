Imports System.Data.SqlClient
Public Class BaseSupplier
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
            _sqlCommand = New SqlCommand("UPDATE tblsuppliers SET company_name = @company_name, company_contact_number = @company_contact_number, company_address = @company_address, first_name = @first_name, last_name = @last_name, phone_number = @phone_number", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@id", _data.Item("id"))
            _sqlCommand.Parameters.AddWithValue("@company_name", _data.Item("company_name"))
            _sqlCommand.Parameters.AddWithValue("@company_contact_number", _data.Item("company_contact_number"))
            _sqlCommand.Parameters.AddWithValue("@company_address", _data.Item("company_address"))
            _sqlCommand.Parameters.AddWithValue("@first_name", _data.Item("first_name"))
            _sqlCommand.Parameters.AddWithValue("@last_name", _data.Item("last_name"))
            _sqlCommand.Parameters.AddWithValue("@phone_number", _data.Item("phone_number"))
            _sqlCommand.Parameters.AddWithValue("@date_updated", _data.Item("date_updated"))
            _sqlCommand.Parameters.AddWithValue("@date_created", _data.Item("date_created"))
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
            _sqlCommand = New SqlCommand("INSERT INTO tblsuppliers (company_name, company_contact_number, company_address, first_name, last_name, phone_number, date_updated, date_created) VALUES (@company_name, @company_contact_number, @company_address, @first_name, @last_name, @phone_number, @date_updated, @date_created)", _sqlConnection)
            _sqlCommand.Parameters.AddWithValue("@company_name", _data.Item("company_name"))
            _sqlCommand.Parameters.AddWithValue("@company_contact_number", _data.Item("company_contact_number"))
            _sqlCommand.Parameters.AddWithValue("@company_address", _data.Item("company_address"))
            _sqlCommand.Parameters.AddWithValue("@first_name", _data.Item("first_name"))
            _sqlCommand.Parameters.AddWithValue("@last_name", _data.Item("last_name"))
            _sqlCommand.Parameters.AddWithValue("@phone_number", _data.Item("phone_number"))
            _sqlCommand.Parameters.AddWithValue("@date_updated", _data.Item("date_updated"))
            _sqlCommand.Parameters.AddWithValue("@date_created", _data.Item("date_created"))
            If _sqlCommand.ExecuteNonQuery() <= 0 Then
                MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Supplier has been added successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class
