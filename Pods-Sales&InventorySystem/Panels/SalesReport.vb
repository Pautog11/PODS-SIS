Imports System.Data.SqlClient

Public Class SalesReport
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private _tableAapter As New podsTableAdapters.viewtbltransactionsTableAdapter
    Private _dataTable As New pods.viewtbltransactionsDataTable
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub SalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        '_tableAapter.Fill(_dataTable)
        'SalesReportsDataGridView.DataSource = _dataTable
        'SalesReportsDataGridView.Columns.Item("ID").Visible = False
        'SalesReportsDataGridView.Columns.Item("CASH").Visible = False

        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand

            'If SalesReportComboBox.Text = "All" Then
            '    cmd = New SqlCommand("SELECT * FROM tbltransactions", conn)
            'Else
            cmd = New SqlCommand("SELECT CONCAT(a.first_name, ' ', a.last_name) AS CASHIER,
                                   t.transaction_number AS TRANSACTION #,
                                   t.total AS TOTAL,
                                   t.date AS DATE
                                   FROM tbltransactions t
                                   JOIN tblaccounts a ON t.account_id = a.id
                                   WHERE t.date BETWEEN @start_date AND @end_date", conn)
            cmd.Parameters.AddWithValue("@start_date", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@end_date", DateTimePicker2.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@group_by", "Year")
            'End If
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            SalesReportsDataGridView.DataSource = dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SalesReportsDataGridView.DataSource = _dataTable
        End Try
    End Sub
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Try
            PrintButton.Enabled = False

            Dim startDate As DateTime = DateTimePicker1.Value.ToString("yyyy-MM-dd")
            Dim endDate As DateTime = DateTimePicker2.Value.ToString("yyyy-MM-dd")

            Using dialog As New SalesReportViewer(startDate, endDate)
                dialog.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error Print report: {ex.Message}", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            PrintButton.Enabled = True
        End Try
    End Sub
    Private Sub FilteredData_Click(sender As Object, e As EventArgs) Handles FilteredData.Click
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand
            'If SalesReportComboBox.Text = "All" Then
            '    cmd = New SqlCommand("SELECT * FROM tbltransactions", conn)
            'Else
            cmd = New SqlCommand("SELECT CONCAT(a.first_name, ' ', a.last_name) AS CASHIER,
                                   t.transaction_number AS TRANSACTION #,
                                   t.total AS TOTAL,
                                   t.date AS DATE
                                   FROM tbltransactions t
                                   JOIN tblaccounts a ON t.account_id = a.id
                                   WHERE t.date BETWEEN @start_date AND @end_date", conn)
            cmd.Parameters.AddWithValue("@start_date", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@end_date", DateTimePicker2.Value.ToString("yyyy-MM-dd"))
            'End If
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            SalesReportsDataGridView.DataSource = dTable
        Catch ex As Exception
            MessageBox.Show($"Error filtering data: {ex.Message}", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class
