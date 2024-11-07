Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the chart
        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()
        Chart1.ChartAreas.Add(New ChartArea("MainArea"))

        Dim salesSeries As New Series("Sales")
        salesSeries.ChartType = SeriesChartType.Column
        Chart1.Series.Add(salesSeries)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        'Guna2ComboBox1.Items.Add("dsdsd")
        'ComboBox1.Text = "dsdsd"

        Dim enteredDate As String = Guna2TextBox1.Text
        Dim parsedDate As DateTime

        ' Try to parse the text as a DateTime
        If DateTime.TryParse(enteredDate, parsedDate) Then
            ' If successful, the input is a valid date
            If parsedDate < DateTime.Today Then
                MessageBox.Show("The date cannot be before today's date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' If the date is valid and not before today, show it
                MessageBox.Show("Valid Date: " & parsedDate.ToString())
            End If
        Else
            ' If parsing fails, the input is not a valid date
            MessageBox.Show("Invalid date entered. Please enter a valid date.")
        End If
    End Sub

    ' Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
    ' Sample data
    '    Dim salesData As New Dictionary(Of String, Integer) From {
    '        {"January", 200},
    '        {"February", 300},
    '        {"March", 150},
    '        {"April", 400},
    '        {"May", 500}
    '    }

    '    ' Load data into the chart
    '    Dim salesSeries As Series = salesChart.Series("Sales")
    '    salesSeries.Points.Clear()

    '    For Each Month In salesData.Keys
    '        salesSeries.Points.AddXY(Month, salesData(Month))
    '    Next

    '    ' Format the chart
    '    salesChart.ChartAreas("MainArea").AxisX.Title = "Months"
    '    salesChart.ChartAreas("MainArea").AxisY.Title = "Sales"
    '    salesChart.Titles.Clear()
    '    salesChart.Titles.Add("Monthly Sales Data")

    '    ' Customize the month label appearance
    '    Dim xAxis As Axis = salesChart.ChartAreas("MainArea").AxisX
    '    xAxis.LabelStyle.ForeColor = Color.Red ' Change label color to red
    '    xAxis.LabelStyle.Font = New Font("Arial", 10, FontStyle.Bold) ' Change font style and size
    'End Sub
End Class