Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf


Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear() ' Clear any existing items (if any)
        ComboBox1.Items.Add("Daily")
        ComboBox1.Items.Add("Weekly")
        ComboBox1.Items.Add("Monthly")
        ComboBox1.Items.Add("Annually")

        UpdateChart("daily")
    End Sub
    Private Sub UpdateChart(timePeriod As String)
        'CartesianChart1.Series = New SeriesCollection From {
        '    New LineSeries With {
        '        .Values = New ChartValues(Of ObservablePoint) From {
        '            New ObservablePoint(0, 10),
        '            New ObservablePoint(4, 7),
        '            New ObservablePoint(5, 3),
        '            New ObservablePoint(10, 8)
        '        },
        '        .PointGeometrySize = 25
        '    },
        '    New LineSeries With {
        '        .Values = New ChartValues(Of ObservablePoint) From {
        '            New ObservablePoint(0, 2),
        '            New ObservablePoint(2, 5),
        '            New ObservablePoint(6, 8),
        '            New ObservablePoint(10, 4)
        '        },
        '        .PointGeometrySize = 15
        '    },
        '    New LineSeries With {
        '        .Values = New ChartValues(Of ObservablePoint) From {
        '            New ObservablePoint(0, 4),
        '            New ObservablePoint(7, 1),
        '            New ObservablePoint(7, 6),
        '            New ObservablePoint(10, 2)
        '        },
        '         .PointGeometrySize = 10
        '    }
        '}

        Try
            ' Get the data from ScalarTransaction based on the selected time period
            Dim transac As DataTable = BaseTransaction.ScalarChartTransaction(timePeriod)

            ' Check if the DataTable is not null and contains rows
            If transac IsNot Nothing AndAlso transac.Rows.Count > 0 Then
                ' Clear existing series
                CartesianChart1.Series.Clear()

                ' Create a new SeriesCollection
                Dim seriesCollection As New SeriesCollection()

                ' Prepare the X and Y values
                Dim xValues As New List(Of Double)()
                Dim yValues As New List(Of Double)()

                ' Loop through each row in the DataTable and map it to ObservablePoint
                For Each row As DataRow In transac.Rows
                    Dim xValue As Double = 0
                    Dim yValue As Double = 0

                    ' Get the X value based on timePeriod
                    If timePeriod = "daily" Then
                        xValue = Convert.ToDateTime(row("TransactionDate")).ToOADate()  ' Convert DateTime to OLE Automation Date
                    ElseIf timePeriod = "weekly" Then
                        xValue = Convert.ToDateTime(row("WeekStart")).ToOADate()  ' Convert DateTime to OLE Automation Date
                    ElseIf timePeriod = "monthly" Then
                        xValue = Convert.ToDateTime(row("Month")).ToOADate()  ' Convert DateTime to OLE Automation Date
                    ElseIf timePeriod = "annually" Then
                        xValue = Convert.ToDateTime(row("Year")).ToOADate()  ' Convert DateTime to OLE Automation Date
                    End If

                    ' Get the Y value (Total)
                    yValue = Convert.ToDouble(row("Total"))

                    ' Add the values to the Lists
                    xValues.Add(xValue)
                    yValues.Add(yValue)
                Next

                ' Create a LineSeries with the X and Y values
                Dim lineSeries As New LineSeries With {
            .Values = New ChartValues(Of ObservablePoint)() From {
                New ObservablePoint(xValues(0), yValues(0)) ' Add the first point
            },
            .PointGeometrySize = 10,  ' Optional: Set size of points
            .Stroke = System.Windows.Media.Brushes.Blue,  ' Optional: Set line color
            .Fill = System.Windows.Media.Brushes.Transparent,  ' Optional: Set fill color for the line
            .Title = "Sales Data"
        }

                ' Add the points to the series
                For i As Integer = 1 To xValues.Count - 1
                    lineSeries.Values.Add(New ObservablePoint(xValues(i), yValues(i)))
                Next

                ' Add the series to the chart
                seriesCollection.Add(lineSeries)

                ' Set the SeriesCollection to the chart
                CartesianChart1.Series = seriesCollection

            Else
                MessageBox.Show("No data available for the selected time period.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem IsNot Nothing Then
            Dim timePeriod As String = ComboBox1.SelectedItem.ToString().ToLower()

            UpdateChart(timePeriod)
        End If
    End Sub
End Class
