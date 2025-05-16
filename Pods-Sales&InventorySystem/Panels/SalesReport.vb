Imports System.Data.SqlClient

Public Class SalesReport
    Implements IObserverPanel
    Private _subject As IObservablePanel

    Private Sub SalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()

            DateFrom.Value = Date.Now.AddDays(-1)
            DateTo.Value = Date.Now

            DateTo.MaxDate = Date.Now

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        Try
            Dim startDate As DateTime = DateFrom.Value.ToString("MMM dd yyyy")
            Dim endDate As DateTime = DateTo.Value.ToString("MMM dd yyyy")
            Dim fuckme As DataTable = BaseReports.Getsales(startDate, endDate)
            SalesReportsDataGridView.DataSource = fuckme.DefaultView
            SalesReportsDataGridView.Columns.Item("ID").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Try
            PrintButton.Enabled = False
            Dim startDate As DateTime = DateFrom.Value.ToString("MMM dd yyyy")
            Dim endDate As DateTime = DateTo.Value.ToString("MMM dd yyyy")
            Using dialog As New SalesReportViewer(startDate, endDate)
                dialog.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            PrintButton.Enabled = True
        End Try
    End Sub

    Private Sub DateTo_CloseUp(sender As Object, e As EventArgs) Handles DateTo.CloseUp
        Try
            Dim startDate As DateTime = DateFrom.Value.ToString("MMM dd yyyy")
            Dim endDate As DateTime = DateTo.Value.ToString("MMM dd yyyy")
            Dim fuckme As DataTable = BaseReports.Getsales(startDate, endDate)
            SalesReportsDataGridView.DataSource = fuckme.DefaultView
            SalesReportsDataGridView.Columns.Item("ID").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
