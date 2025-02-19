Imports System.Data.SqlClient

Public Class SalesReport
    Implements IObserverPanel
    Private _subject As IObservablePanel

    Private Sub SalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        DateFrom.MaxDate = Date.Now
        DateTo.MinDate = DateFrom.Value
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        FetchFuckingData()
    End Sub
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Try
            PrintButton.Enabled = False

            Dim startDate As DateTime = DateFrom.Value.ToString("yyyy-MM-dd")
            Dim endDate As DateTime = DateTo.Value.ToString("yyyy-MM-dd")

            Using dialog As New SalesReportViewer(startDate, endDate)
                dialog.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error Print report: {ex.Message}", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            PrintButton.Enabled = True
        End Try
    End Sub

    Private Sub DateFrom_ValueChanged(sender As Object, e As EventArgs) Handles DateFrom.ValueChanged
        DateTo.MinDate = DateFrom.Value
    End Sub

    Private Sub DateTo_ValueChanged(sender As Object, e As EventArgs) Handles DateTo.ValueChanged
        FetchFuckingData()
    End Sub

    Public Sub FetchFuckingData()
        Try
            Dim fuckme As DataTable = BaseReports.Getsales(DateFrom.Value.ToString("yyyy-MM-dd"), DateTo.Value.ToString("yyyy-MM-dd"))
            SalesReportsDataGridView.DataSource = fuckme.DefaultView
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
