Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms

Public Class ReportViewerDialog
    Private _transactionNumber As String

    Public Sub New(transactionNumber As String)
        InitializeComponent()
        _transactionNumber = transactionNumber
    End Sub

    Private Sub ReportViewerDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim src As New ReportDataSource("DSReport", Transactions(_transactionNumber).Tables("DT_Transaction"))
        Dim src1 As New ReportDataSource("DS_TransactionsItem", Products(_transactionNumber).Tables("DT_TransactionItems"))
        ReportViewer1.LocalReport.ReportPath = "C:\Users\Christian\Desktop\PODS-SIS\Pods-Sales&InventorySystem\Reports\Receipt.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(src)
        ReportViewer1.LocalReport.DataSources.Add(src1)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Function Transactions(transactionNumber As String) As DSReport
        Dim dset As New DSReport
        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString1)
                con.Open()
                Dim cmd As New SqlCommand("SELECT 
                                            t.transaction_number,
                                            t.subtotal,
                                            t.vat,
                                            t.discount,
                                            t.total,
                                            t.date,
                                            CONCAT(u.first_name, ' ', u.last_name) AS name,
                                            t.cash
                                          FROM tbltransactions t
                                          JOIN tblaccounts u ON t.account_id = u.id
                                          WHERE t.transaction_number = @transaction_number", con)
                cmd.Parameters.AddWithValue("@transaction_number", transactionNumber)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset.Tables("DT_Transaction"))
                Return dset
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function Products(transactionNumber As String) As DSReport
        Dim dset As New DSReport
        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString1)
                con.Open()
                Dim cmd As New SqlCommand("SELECT t.transaction_number, p.product_name AS product, ti.quantity, ti.price 
                                          FROM tbltransaction_items ti 
                                          JOIN tblproducts p ON ti.product_id = p.id
										  JOIN tbltransactions t ON ti.transaction_id = t.id
                                          WHERE t.transaction_number = @transaction_number", con)
                cmd.Parameters.AddWithValue("@transaction_number", transactionNumber)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset.Tables("DT_TransactionItems"))
                Return dset
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
