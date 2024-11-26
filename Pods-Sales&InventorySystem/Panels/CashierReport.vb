Imports System.Data.SqlClient
Public Class CashierReport
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblaccountsTableAdapter
    Private _dataTable As New pods.viewtblaccountsDataTable

    Private Sub CashierReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim dt As DataTable = BaseReports.FetchAccount
        CashierNameComboBox.DataSource = dt.DefaultView
        CashierNameComboBox.DisplayMember = "name"
        CashierNameComboBox.ValueMember = "id"
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand

            'If SalesReportComboBox.Text = "All" Then
            '    cmd = New SqlCommand("SELECT * FROM tbltransactions", conn)
            'Else
            cmd = New SqlCommand("SELECT CONCAT(a.first_name, ' ', a.last_name) AS CASHIER,
                                   t.transaction_number AS TRANSACTION#,
                                   t.total AS TOTAL,
                                   t.date AS DATE
                                   FROM tbltransactions t
                                   JOIN tblaccounts a ON t.account_id = a.id
                                   WHERE t.date = @startDate AND t.account_id = @cashierNameCmb", conn)
            cmd.Parameters.AddWithValue("@startDate", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@cashierNameCmb", CashierNameComboBox.SelectedIndex)
            'End If
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            CashierReportsDataGridView.DataSource = dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub FilteredData_Click(sender As Object, e As EventArgs) Handles FilteredData.Click
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand

            cmd = New SqlCommand("SELECT CONCAT(a.first_name, ' ', a.last_name) AS CASHIER,
                                   t.transaction_number AS TRANSACTION#,
                                   t.total AS TOTAL,
                                   t.date AS DATE
                                   FROM tbltransactions t
                                   JOIN tblaccounts a ON t.account_id = a.id
                                   WHERE CONVERT(DATE, t.date) = @startDate AND t.account_id = @cashierNameCmb", conn)
            cmd.Parameters.AddWithValue("@startDate", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@cashierNameCmb", CashierNameComboBox.SelectedValue)
            'End If
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            CashierReportsDataGridView.DataSource = dTable
        Catch ex As Exception
            MessageBox.Show($"Error filtering data: {ex.Message}", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub CashierNameComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CashierNameComboBox.SelectionChangeCommitted
        'MsgBox(CashierNameComboBox.SelectedItem("id"))
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Try
            PrintButton.Enabled = False

            Dim startDate As DateTime = DateTimePicker1.Value.ToString("yyyy-MM-dd")

            'Using dialog As New CashierViewer(startDate)
            '    dialog.ShowDialog()
            'End Using
        Catch ex As Exception
            MessageBox.Show($"Error Print report: {ex.Message}", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            PrintButton.Enabled = True
        End Try
    End Sub
End Class
