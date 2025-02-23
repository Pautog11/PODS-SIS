Imports System.Data.SqlClient

Public Class SalesReport
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private triggers As Boolean = False

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
        Try
            Dim fuckme As DataTable = BaseReports.Getsales
            SalesReportsDataGridView.DataSource = fuckme.DefaultView
        Catch ex As Exception

        End Try
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
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            PrintButton.Enabled = True
        End Try
    End Sub

    Private Sub DateFrom_ValueChanged(sender As Object, e As EventArgs) Handles DateFrom.ValueChanged
        DateTo.MinDate = DateFrom.Value
    End Sub

    Private Sub DateTo_ValueChanged(sender As Object, e As EventArgs) Handles DateTo.ValueChanged
        If triggers = True Then
            FetchFuckingData()
            'MsgBox(DateTo.Value.ToString("yyyy-MM-dd"))
        End If
    End Sub
    Private Sub DateTo_Enter(sender As Object, e As EventArgs) Handles DateTo.Enter
        triggers = True
    End Sub

    Public Sub FetchFuckingData()
        Try
            Dim fuckme As DataTable = BaseReports.GetSalesByDate(DateFrom.Value.ToString("yyyy-MM-dd"), DateTo.Value.ToString("yyyy-MM-dd"))
            SalesReportsDataGridView.DataSource = fuckme.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class
