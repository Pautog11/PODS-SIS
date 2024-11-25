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
            cmd = New SqlCommand("EXEC SalesReportProcedure @start_date = @start_date, @end_date = @end_date, @group_by = @group_by", conn)
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

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub SalesReportComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SalesReportComboBox.SelectionChangeCommitted
        'MsgBox(SalesReportComboBox.Text)
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As SqlCommand

            'If SalesReportComboBox.Text = "All" Then
            '    cmd = New SqlCommand("SELECT * FROM tbltransactions", conn)
            'Else
            cmd = New SqlCommand("EXEC SalesReportProcedure @start_date = @start_date, @end_date = @end_date, @group_by = @group_by", conn)
                cmd.Parameters.AddWithValue("@start_date", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@end_date", DateTimePicker2.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@group_by", SalesReportComboBox.Text)
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
        'MsgBox(DateTimePicker1.Value.ToString("yyyy-MM-dd"))
        'Dim startDate As DateTime = Format(DateTimePicker1.Value, "yyyy/MM/dd").ToString
        'Dim endDate As DateTime = Format(DateTimePicker2.Value, "yyyy/MM/dd").ToString

        Using dialog As New SalesReportViewer()
            dialog.ShowDialog()
        End Using
    End Sub
End Class
