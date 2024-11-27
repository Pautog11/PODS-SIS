Imports System.Data.SqlClient
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

        ' Check if datasets have the expected tables
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
                                                    t.total,
                                                    t.date,
                                                    CONVERT(TIME, t.date) AS time,
                                                    SUM(t.total) OVER () AS total_sales,
                                                    ISNULL(r.total, 0) AS total_return,
                                                    SUM(t.total) OVER () - ISNULL(r.total, 0) AS overall_total
                                                FROM tbltransactions t
                                                JOIN tblaccounts a ON t.account_id = a.id
                                                LEFT JOIN tblreturns r ON t.id = r.transaction_id
                                                JOIN tbltransaction_items ti ON t.id = ti.transaction_id
                                                JOIN tblproducts p ON ti.product_id = p.id
                                                WHERE CONVERT(DATE, t.date) = @startDate AND t.account_id = @cashierNameCmb
                                                GROUP BY 
                                                    CONCAT(a.first_name, ' ', a.last_name), 
                                                    t.transaction_number, 
                                                    t.total, 
                                                    t.date, 
                                                    r.total", con)
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
