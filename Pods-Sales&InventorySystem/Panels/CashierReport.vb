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
                                   WHERE t.date BETWEEN @start_date AND @end_date", conn)
            cmd.Parameters.AddWithValue("@start_date", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@start_date", CashierNameComboBox.ToString)
            'End If
            Dim dTable As New DataTable
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dTable)
            CashierReportsDataGridView.DataSource = dTable
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class
