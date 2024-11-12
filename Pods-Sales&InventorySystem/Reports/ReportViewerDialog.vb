Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms

Public Class ReportViewerDialog

    Private Sub ReportViewerDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim src As New ReportDataSource("DSReport", x.Tables("DT_Transaction"))
        Dim src1 As New ReportDataSource("DS_TransactionsItem", y.Tables("DT_TransactionItem"))
        ReportViewer1.LocalReport.ReportPath = "C:\Users\Christian\Desktop\PODS-SIS\Pods-Sales&InventorySystem\Reports\Receipt.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(src)
        ReportViewer1.LocalReport.DataSources.Add(src1)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Function x() As DSReport
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
	                                            CONCAT(u.first_name, ' ', u.last_name) name
                                            FROM tbltransactions t
                                            JOIN tblaccounts u ON t.account_id = u.id
                                            ", con)
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset.Tables("DT_Transaction"))
                Return dset
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Private Function y() As DSReport
        Dim dset As New DSReport
        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString1)
                con.Open()
                Dim cmd As New SqlCommand("
                                            ", con)
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset.Tables("DT_TransactionItem"))
                Return dset
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
