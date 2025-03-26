Imports System.Data.SqlClient

Public Class FinancialReport
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblrevenueTableAdapter
    Private _dataTable As New pods.viewtblrevenueDataTable
    Private Sub FinancialReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        _tableAapter.Fill(_dataTable)
        FinancialReportsDataGridView.DataSource = _dataTable
        FinancialReportsDataGridView.Columns.Item("ID").Visible = False
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Try
            PrintButton.Enabled = False
            Dim startDate As DateTime = DateFrom.Value.ToString("yyyy-MM-dd")
            Dim endDate As DateTime = DateTo.Value.ToString("yyyy-MM-dd")
            Using dialog As New FinancialReportViewer(startDate, endDate)
                dialog.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            PrintButton.Enabled = True
        End Try
    End Sub
End Class
