Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'LoadSalesData()
        GenerateUpDownSalesData()
    End Sub

    'Dim connectionString As String = "Data Source=.;Initial Catalog=podsdb;User ID=admin;Password=admin;"

    '' Method to load data into the chart
    'Private Sub LoadSalesData()
    '    ' SQL query to fetch sales data for the last 12 months
    '    Dim query As String = "SELECT 
    '                                MONTH(date) AS Month,
    '                                YEAR(date) AS Year,
    '                                SUM(CASE WHEN YEAR(date) = YEAR(GETDATE()) THEN total ELSE 0 END) AS SalesThisYear,
    '                                SUM(CASE WHEN YEAR(date) = YEAR(GETDATE()) - 1 THEN total ELSE 0 END) AS SalesLastYear
    '                            FROM tbltransactions
    '                            WHERE date >= DATEADD(MONTH, -12, GETDATE()) 
    '                            GROUP BY YEAR(date), MONTH(date)
    '                            ORDER BY YEAR(date) DESC, MONTH(date) DESC;"

    '    Using conn As New SqlConnection(connectionString)
    '        Using cmd As New SqlCommand(query, conn)
    '            conn.Open()

    '            Using reader As SqlDataReader = cmd.ExecuteReader()
    '                ' Clear previous data from the chart
    '                Chart1.Series.Clear()

    '                ' Add series for SalesThisYear and SalesLastYear
    '                Chart1.Series.Add("SalesThisYear")
    '                Chart1.Series.Add("SalesLastYear")

    '                ' Set chart type (column chart for this example)
    '                Chart1.Series("SalesThisYear").ChartType = SeriesChartType.Column
    '                Chart1.Series("SalesLastYear").ChartType = SeriesChartType.Column

    '                ' Set colors for the series
    '                Chart1.Series("SalesThisYear").Color = Color.Blue
    '                Chart1.Series("SalesLastYear").Color = Color.Red

    '                ' Loop through the data and add it to the chart
    '                While reader.Read()
    '                    Dim month As Integer = reader("Month")
    '                    Dim year As Integer = reader("Year")
    '                    Dim salesThisYear As Decimal = reader("SalesThisYear")
    '                    Dim salesLastYear As Decimal = reader("SalesLastYear")

    '                    ' Add data points to the chart (X = Month, Y = SalesAmount)
    '                    ' For the X-axis, you can combine Month and Year as labels
    '                    Chart1.Series("SalesThisYear").Points.AddXY($"{month}-{year}", salesThisYear)
    '                    Chart1.Series("SalesLastYear").Points.AddXY($"{month}-{year}", salesLastYear)
    '                End While
    '            End Using
    '        End Using
    '    End Using
    'End Sub

    ' Method to generate random sales data for the last 12 months


    ' Method to generate random "up and down" sales data for the last 12 months
    Private Sub GenerateUpDownSalesData()
        ' Define the current month and year
        Dim currentDate As Date = Date.Now
        Dim monthsBack As Integer = 6

        ' Generate sales data for each of the last 12 months
        Dim months As New List(Of String)()
        Dim salesThisYear As New List(Of Decimal)()
        Dim salesLastYear As New List(Of Decimal)()

        ' Initial sales value (base value for this year and last year)
        Dim baseSales As Decimal = 50000

        ' Generate random sales with alternating up and down changes
        Dim currentSalesThisYear As Decimal = baseSales
        Dim currentSalesLastYear As Decimal = baseSales

        For i As Integer = monthsBack - 1 To 0 Step -1
            Dim monthDate As Date = currentDate.AddMonths(-i)
            months.Add(monthDate.ToString("MMM yyyy")) ' Add the month-year (e.g., "Mar 2025")

            ' Add "up or down" random fluctuation for each month (simulate random sales)
            currentSalesThisYear = GenerateUpDownSales(currentSalesThisYear)
            currentSalesLastYear = GenerateUpDownSales(currentSalesLastYear)

            salesThisYear.Add(currentSalesThisYear)
            salesLastYear.Add(currentSalesLastYear)
        Next

        ' Now bind the data to the chart
        Chart1.Series.Clear()

        ' Add series for SalesThisYear and SalesLastYear
        Chart1.Series.Add("SalesThisYear")
        Chart1.Series.Add("SalesLastYear")

        ' Set chart type (Column chart in this example)
        Chart1.Series("SalesThisYear").ChartType = SeriesChartType.Column
        Chart1.Series("SalesLastYear").ChartType = SeriesChartType.Column

        ' Set colors for the series
        Chart1.Series("SalesThisYear").Color = Color.DimGray
        Chart1.Series("SalesLastYear").Color = Color.Gray

        ' Add data points for each month
        For i As Integer = 0 To months.Count - 1
            Chart1.Series("SalesThisYear").Points.AddXY(months(i), salesThisYear(i))
            Chart1.Series("SalesLastYear").Points.AddXY(months(i), salesLastYear(i))
        Next
    End Sub

    ' Helper function to generate sales with up or down fluctuation
    Private Function GenerateUpDownSales(ByVal currentSales As Decimal) As Decimal
        ' Randomly generate an increase or decrease in sales
        Dim random As New Random()
        Dim change As Decimal = random.Next(200, 800) ' Change between 200 and 800 (positive or negative)

        ' 50% chance to increase or decrease the sales
        If random.Next(0, 2) = 0 Then
            ' Increase sales
            currentSales += change
        Else
            ' Decrease sales (but sales can't go below 0)
            currentSales -= change
        End If

        ' Ensure sales don't go below 0
        If currentSales < 0 Then currentSales = 0

        ' Return the new sales value
        Return Math.Round(currentSales, 2)
    End Function
End Class