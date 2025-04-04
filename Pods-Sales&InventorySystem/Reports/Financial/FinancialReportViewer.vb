Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FinancialReportViewer
    Private _startDate As DateTime
    Private _endDate As DateTime

    Public Sub New(startDate As DateTime, endDate As DateTime)
        InitializeComponent()
        _startDate = startDate
        _endDate = endDate
    End Sub
    Private Sub FinancialReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'FillSalesData()
            'FillPulloutData()




            Dim financialViewData As DataSet = BaseReport.FinancialReportView(_startDate, _endDate)
            Dim tite As DataSet = BaseReport.PulloutReportView(_startDate, _endDate)
            Dim dispose As DataSet = BaseReport.GetDisposalByDate(_startDate, _endDate)

            'If dispose.Tables.Count > 0 Then
            '    MsgBox("merom")
            'Else
            '    MsgBox("wala")
            'End If

            'If financialViewData Is Nothing OrElse tite Is Nothing OrElse tite.Tables.Contains("DT_PulloutReport") Then
            '    MessageBox.Show("Failed to load one or more datasets.")
            '    Exit Sub
            'End If

            ' Check if datasets have the expected tables
            If financialViewData.Tables.Contains("DT_FinancialReport") OrElse tite.Tables.Contains("DT_PulloutReport") OrElse dispose.Tables.Contains("DT_DisposalReport") Then

                Dim reportDocument As New FinancialRpt()
                reportDocument.SetDataSource(financialViewData.Tables("DT_FinancialReport"))

                Dim subreportSales = reportDocument.Subreports("SalesReportRpt.rpt")
                'subreportSales.SetDataSource(transactionData.Tables("DT_SalesReport"))



                Dim pullout = reportDocument.Subreports("PulloutRpt.rpt")
                pullout.SetDataSource(tite.Tables("DT_PulloutReport"))



                Dim taena = reportDocument.Subreports("DisposalRpt.rpt")
                taena.SetDataSource(dispose.Tables("DT_DisposalReport"))


                CrystalReportViewer1.ReportSource = reportDocument
                CrystalReportViewer1.RefreshReport()
            Else
                MessageBox.Show("One or more required tables are missing from the datasets.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Public Sub FillSalesData()
    '    Try
    '        Dim financialViewData As DataSet = BaseReport.FinancialReportView(_startDate, _endDate)

    '        If financialViewData Is Nothing Then
    '            MessageBox.Show("Failed to load one or more datasets.")
    '            Exit Sub
    '        End If

    '        ' Check if datasets have the expected tables
    '        If financialViewData.Tables.Contains("DT_FinancialReport") Then

    '            Dim reportDocument As New FinancialRpt()
    '            reportDocument.SetDataSource(financialViewData.Tables("DT_FinancialReport"))

    '            CrystalReportViewer1.ReportSource = reportDocument
    '            CrystalReportViewer1.RefreshReport()
    '        Else
    '            MessageBox.Show("One or more required tables are missing from the datasets.")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End Try
    'End Sub


    'Public Sub FillPulloutData()
    '    Try
    '        Dim financialViewData As DataSet = BaseReport.PulloutReportView(_startDate, _endDate)

    '        If financialViewData Is Nothing Then
    '            MessageBox.Show("Failed to load one or more datasets.")
    '            Exit Sub
    '        End If

    '        ' Check if datasets have the expected tables
    '        If financialViewData.Tables.Contains("DT_PulloutReport") Then

    '            Dim reportDocument As New FinancialRpt()
    '            reportDocument.SetDataSource(financialViewData.Tables("DT_PulloutReport"))

    '            CrystalReportViewer1.ReportSource = reportDocument
    '            CrystalReportViewer1.RefreshReport()
    '        Else
    '            MessageBox.Show("One or more required tables are missing from the datasets.")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    End Try
    'End Sub
End Class
