﻿Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class CashierViewer
    Private _date As DateTime
    Private _name As String

    '' Constructor to accept the date range for filtering
    Public Sub New(selectedDate As DateTime, cashierName As String)
        InitializeComponent()
        _date = selectedDate
        _name = cashierName
    End Sub
    Private Sub CashierViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CashierData As DataSet = Cashier(_date, _name)

        If CashierData Is Nothing Then
            MessageBox.Show("Failed to load one or more datasets.")
            Exit Sub
        End If

        If CashierData.Tables.Contains("DT_CashiersReport") Then
            Dim reportDocument As New CashierRpt()
            reportDocument.SetDataSource(CashierData.Tables("DT_CashiersReport"))

            CrystalReportViewer1.ReportSource = reportDocument
            CrystalReportViewer1.RefreshReport()
        Else
            MessageBox.Show("One or more required tables are missing from the datasets.")
        End If
    End Sub
    Private Function Cashier(selectedDate As DateTime, cashierName As String) As DataSet
        Dim dset As New DataSet

        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString)
                con.Open()
                Dim cmd As New SqlCommand("SELECT CONCAT(a.first_name, ' ', a.last_name) AS cashier,
                                                      t.transaction_number,
                                                      t.total AS total,
                                                      t.date AS DATE,
                                                      CONVERT(TIME, t.date) AS time
                                               FROM tbltransactions t
                                               JOIN tblaccounts a ON t.account_id = a.id
                                               WHERE CONVERT(DATE, t.date) = @startDate AND t.account_id = @cashierNameCmb

                                               UNION ALL

                                               SELECT CONCAT(first_name, ' ', last_name) AS 'cashier', 
                                                      transaction_number, 
                                                      -1 * a.total as total, 
                                                      a.date, 
                                                      CONVERT(TIME, a.date) AS time
                                               FROM tblreturns a 
                                               JOIN tbltransactions b on a.transaction_id = b.id
                                               JOIN tblaccounts c on a.account_id = c.id
                                               WHERE a.account_id = @cashierNameCmb AND CONVERT(DATE, a.date) = @startDate", con)
                cmd.Parameters.AddWithValue("@startDate", selectedDate)
                cmd.Parameters.AddWithValue("@cashierNameCmb", cashierName)
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset, "DT_CashiersReport")
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading inventory data: {ex.Message}")
        End Try
        Return dset
    End Function
End Class
