Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ReceiptViewer
    'Private _transactionNumber As String

    'Public Sub New(transactionNumber As String)
    '    InitializeComponent()
    '    _transactionNumber = transactionNumber
    'End Sub

    'Private Sub ReceiptViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    ' Retrieve transaction data and items data
    '    Dim transactionData As DataSet = Transactions(_transactionNumber)
    '    Dim productData As DataSet = Products(_transactionNumber)

    '    ' Check if data is available
    '    If transactionData Is Nothing OrElse productData Is Nothing Then
    '        MessageBox.Show("Unable to retrieve data.")
    '        Return
    '    End If-

    '    ' Set the report document
    '    Dim reportDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
    '    reportDocument.Load("C:\Users\Christian\Desktop\PODS-SIS\Pods-Sales&InventorySystem\Reports\Receipt\Receipt.rpt")

    '    ' Set the data sources for the main report
    '    reportDocument.SetDataSource(transactionData.Tables("DT_Transac"))


    '    ' Assign the report to the Crystal Report Viewer
    '    CrystalReportViewer1.ReportSource = reportDocument
    '    CrystalReportViewer1.RefreshReport()
    'End Sub

    'Private Function Transactions(transactionNumber As String) As DataSet
    '    Dim dset As New DataSet
    '    Try
    '        Using con As New SqlConnection(My.Settings.podsdbConnectionString1)
    '            con.Open()
    '            Dim cmd As New SqlCommand("SELECT 
    '                                        t.transaction_number,
    '                                        t.subtotal,
    '                                        t.vat,
    '                                        t.discount,
    '                                        t.total,
    '                                        t.date,
    '                                        CONCAT(u.first_name, ' ', u.last_name) AS name,
    '                                        t.cash, (t.cash - t.total) change,
    '							p.product_name AS product, ti.quantity, ti.price, ti.total as product_total
    '                                      FROM tbltransactions t
    '                                      JOIN tblaccounts u ON t.account_id = u.id
    '                                      JOIN tbltransaction_items ti ON t.id = ti.transaction_id
    '                                      JOIN tblproducts p ON ti.product_id = p.id
    '                                      WHERE t.transaction_number = @transaction_number", con)
    '            cmd.Parameters.AddWithValue("@transaction_number", transactionNumber)

    '            Dim adapter As New SqlDataAdapter(cmd)
    '            adapter.Fill(dset, "DT_Transaction")
    '            Return dset
    '        End Using
    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function

    'Private Function Products(transactionNumber As String) As DataSet
    '    Dim dset As New DataSet
    '    Try
    '        Using con As New SqlConnection(My.Settings.podsdbConnectionString1)
    '            con.Open()
    '            Dim cmd As New SqlCommand("SELECT t.transaction_number, p.product_name AS product, ti.quantity, ti.price, ti.total 
    '                                      FROM tbltransaction_items ti 
    '                                      JOIN tblproducts p ON ti.product_id = p.id
    '                                      JOIN tbltransactions t ON ti.transaction_id = t.id
    '                                      WHERE t.transaction_number = @transaction_number", con)
    '            cmd.Parameters.AddWithValue("@transaction_number", transactionNumber)

    '            Dim adapter As New SqlDataAdapter(cmd)
    '            adapter.Fill(dset, "DT_Transactionitems")
    '            Return dset
    '        End Using
    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function
    Private ReadOnly _transactionNumber As String
    'Private _autoPrint As Boolean

    Public Sub New(Optional transactionNumber As String = Nothing)
        'Optional autoPrint As Boolean = False)
        InitializeComponent()
        _transactionNumber = transactionNumber
        '_autoPrint = autoPrint
    End Sub

    Private Sub ReceiptViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim transactionData As DataSet = Transactions(_transactionNumber)

            If transactionData Is Nothing OrElse transactionData.Tables("DT_Transac").Rows.Count = 0 Then
                MessageBox.Show("No data found for the transaction.")
                Me.Close()
                Return
            End If

            Dim reportDocument As New Receipt()
            reportDocument.SetDataSource(transactionData.Tables("DT_Transac"))

            CrystalReportViewer1.ReportSource = reportDocument
            CrystalReportViewer1.RefreshReport()

            'If _autoPrint Then
            '    reportDocument.PrintToPrinter(1, False, 0, 0)
            '    MessageBox.Show("Receipt auto-printed successfully.")
            '    Me.Close() ' Close after printing if required
            'End If
        Catch ex As Exception
            MessageBox.Show($"Error loading receipt: {ex.Message}")
            Me.Close()
        End Try
    End Sub

    Private Function Transactions(transactionNumber As String) As DataSet
        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString)
                con.Open()
                Dim cmd As New SqlCommand("SELECT 
		                                	t.transaction_number,
                                            t.subtotal,
                                            t.vat,
                                            t.discount,
                                            t.total,
                                            t.date,
                                            CONCAT(u.first_name, ' ', u.last_name) AS name,
											p.product_name AS product, 
											ti.quantity, 
											ti.price AS price, 
											t.vatable,
											SUM(ti.quantity * price) AS product_total,
                                            t.cash,
                                            SUM(t.cash - t.total) AS CHANGE
                                          FROM tbltransactions t
                                          JOIN tblaccounts u ON t.account_id = u.id
                                          JOIN tbltransaction_items ti ON t.id = ti.transaction_id
                                          JOIN tblproducts p ON ti.product_id = p.id
                                          WHERE t.id = @transaction_number
										  group by
										  t.transaction_number,
                                            t.subtotal,
                                            t.vat,
                                            t.discount,
                                            t.total,
                                            t.date,
                                            CONCAT(u.first_name, ' ', u.last_name),
											p.product_name, 
											ti.quantity, 
											ti.price, 
											t.vatable,
                                            t.cash", con)
                cmd.Parameters.AddWithValue("@transaction_number", transactionNumber)

                Dim adapter As New SqlDataAdapter(cmd)
                Dim dset As New DataSet
                adapter.Fill(dset, "DT_Transac")
                Return dset
            End Using
        Catch ex As Exception
            'Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function Products(transactionNumber As String) As DataSet
        Dim dset As New DataSet
        Try
            Using con As New SqlConnection(My.Settings.podsdbConnectionString)
                con.Open()
                Dim cmd As New SqlCommand("SELECT t.transaction_number, p.product_name AS product, ti.quantity, ti.price, ti.total 
                                          FROM tbltransaction_items ti 
                                          JOIN tblproducts p ON ti.product_id = p.id
                                          JOIN tbltransactions t ON ti.transaction_id = t.id
                                          WHERE t.transaction_number = @transaction_number", con)
                cmd.Parameters.AddWithValue("@transaction_number", transactionNumber)

                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dset, "DT_Transactionitems")
                Return dset
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
