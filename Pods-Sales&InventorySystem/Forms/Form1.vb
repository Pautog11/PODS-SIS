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

        MsgBox(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))

        'Dim result As New List(Of Object()) From {InputValidation.ValidateInputString(ComboBox1, DataInput.STRING_INTEGER)}
        'Try
        '    Dim conn As SqlConnection = SqlConnectionPods.GetInstance
        '    Dim cmd As New SqlCommand("SELECT role FROM tblroles WHERE id = @id", conn)
        '    cmd = New SqlCommand("UPDATE tblaccounts SET password = @password WHERE id = @id", conn)
        '    cmd.Parameters.AddWithValue("@id", "2035")
        '    cmd.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword("sa"))
        '    cmd.ExecuteNonQuery()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End Try
        'Dim result As New List(Of Object)() From {InputValidation.ValidateInputString(Guna2TextBox1, DataInput.STRING_DATE)}

        '    ' Define the text value you want to select
        '    Dim valueToSelect As String = "dsdsd"

        '    '' Check if the item exists in the ComboBox
        '    If Not Guna2ComboBox1.Items.Contains(valueToSelect) Then
        '        ' If the item doesn't exist, add it to the ComboBox
        '        Guna2ComboBox1.Items.Add(valueToSelect)
        '    End If

        '    ' Programmatically select the item
        '    Guna2ComboBox1.SelectedItem = valueToSelect

        '    ' Optionally open the dropdown (if ShowDropDown method is available)
        '    'Guna2ComboBox1.ShowDropDown() ' This will open the dropdown if applicable

        '    ' Ensure the Text property reflects the selected value
        '    Guna2ComboBox1.Text = valueToSelect




        '    'Dim valueToSet As String = "dsdsd"
        '    'Guna2ComboBox1.DataSource = valueToSet
        '    'Guna2TextBox1.Text = valueToSet
        '    'ComboBox1.Text = "dsdsd"



        '    Dim enteredDate As String = Guna2TextBox1.Text
        '    Dim parsedDate As DateTime

        '    ' Try to parse the text as a DateTime
        '    If DateTime.TryParse(enteredDate, parsedDate) Then
        '        ' If successful, the input is a valid date
        '        If parsedDate < DateTime.Today Then
        '            MessageBox.Show("The date cannot be before today's date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Else
        '            ' If the date is valid and not before today, show it
        '            MessageBox.Show("Valid Date: " & parsedDate.ToString())
        '        End If
        '    Else
        '        ' If parsing fails, the input is not a valid date
        '        MessageBox.Show("Invalid date entered. Please enter a valid date.")
        '    End If
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