Imports System.Data.SqlClient
Public Class CashierReport
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblaccountsTableAdapter
    Private _dataTable As New pods.viewtblaccountsDataTable
    Dim id As Integer

    Private Sub CashierReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()

            Dim dt As DataTable = BaseReports.FetchAccount
            CashierNameComboBox.DataSource = dt.DefaultView
            CashierNameComboBox.DisplayMember = "name"
            CashierNameComboBox.ValueMember = "id"


            id = CashierNameComboBox.SelectedItem("id")
            DatePicker.MaxDate = DateTime.Now
            DatePicker.Value = DateTime.Now

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        Try
            Dim startDate As DateTime = DatePicker.Value.ToString("yyyy-MM-dd")
            Dim fuck As DataTable = BaseReports.SalesReport(startDate, id)
            CashierReportsDataGridView.DataSource = fuck.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Try
            PrintButton.Enabled = False

            Dim selectedDate As DateTime = DatePicker.Value.ToString("yyyy-MM-dd")
            Dim cashierName As String = CashierNameComboBox.SelectedValue

            Using dialog As New CashierViewer(selectedDate, cashierName)
                dialog.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error Print report: {ex.Message}", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            PrintButton.Enabled = True
        End Try
    End Sub

    Private Sub DatePicker_CloseUp(sender As Object, e As EventArgs) Handles DatePicker.CloseUp
        Dim startDate As DateTime = DatePicker.Value.ToString("yyyy-MM-dd")
        Dim fuck As DataTable = BaseReports.SalesReport(startDate, id)
        CashierReportsDataGridView.DataSource = fuck.DefaultView
    End Sub

    Private Sub CashierNameComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CashierNameComboBox.SelectionChangeCommitted
        Dim startDate As DateTime = DatePicker.Value.ToString("yyyy-MM-dd")
        Dim fuck As DataTable = BaseReports.SalesReport(startDate, CashierNameComboBox.SelectedItem("id"))
        CashierReportsDataGridView.DataSource = fuck.DefaultView
    End Sub
End Class
