Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard
    Implements IObservablePanel, IObserverPanel
    Private ReadOnly _observables As New List(Of IObserverPanel)
    'Private toggleState As Boolean = False
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        RegisterObserver(Me)
        NotifyObserver()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For i As Integer = 1 To 2
        '    NotificationDataGridView.Rows.Add("Your product is running out of stock!")
        '    NotificationDataGridView.Rows.Add("Your product will expire in 7 days. Please take action.")
        'Next

        ComboBox1.Items.Clear() ' Clear any existing items (if any)
        ComboBox1.Items.Add("Daily")
        ComboBox1.Items.Add("Weekly")
        ComboBox1.Items.Add("Monthly")
        ComboBox1.Items.Add("Annually")

        UpdateChart("daily")
    End Sub

    Public Sub RegisterObserver(o As IObserverPanel) Implements IObservablePanel.RegisterObserver
        _observables.Add(o)
    End Sub

    Public Sub NotifyObserver() Implements IObservablePanel.NotifyObserver
        For Each o As IObserverPanel In _observables
            o.Update()
        Next
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        Accounts.Text = BaseAccount.ScalarAccount
        Sales.Text = BaseTransaction.ScalarTransaction

        'Dim critical As DataTable = BaseNotifications.CriticalLevel
        'For Each row As DataRow In critical.Rows
        '    Dim rowData As New List(Of Object)()
        '    For Each column As DataColumn In critical.Columns
        '        rowData.Add(row(column))
        '    Next
        '    NotificationDataGridView.Rows.Add(rowData.ToArray())
        'Next

        'Dim expiry As DataTable = BaseNotifications.Expiry
        'Dim critical As DataTable = BaseNotifications.CriticalLevel
        'NotificationDataGridView.Rows.Clear()
        'For Each row As DataRow In critical.Rows
        '    Dim rowData(critical.Columns.Count - 1) As Object
        '    For i As Integer = 0 To critical.Columns.Count - 1
        '        rowData(i) = row(i)
        '    Next
        '    NotificationDataGridView.Rows.Add(rowData)
        'Next

        Dim expiry As DataTable = BaseNotifications.Expiry
        Dim critical As DataTable = BaseNotifications.CriticalLevel

        ' Clear the existing rows in the DataGridView
        NotificationDataGridView.Rows.Clear()

        ' Add rows from the "critical" DataTable
        For Each row As DataRow In critical.Rows
            Dim rowData(critical.Columns.Count - 1) As Object
            For i As Integer = 0 To critical.Columns.Count - 1
                rowData(i) = row(i)
            Next
            NotificationDataGridView.Rows.Add(rowData)
        Next

        ' Add rows from the "expiry" DataTable
        For Each row As DataRow In expiry.Rows
            Dim rowData(expiry.Columns.Count - 1) As Object
            For i As Integer = 0 To expiry.Columns.Count - 1
                rowData(i) = row(i)
            Next
            NotificationDataGridView.Rows.Add(rowData)
        Next


    End Sub

    'Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
    '    ' Toggle the boolean value
    '    toggleState = Not toggleState

    '    ' Update the label to show the current state
    '    DashboardTabControl.TabMenuVisible = toggleState
    'End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        BaseAccountLog.Logout(My.Settings.myId, "Logout")
        Me.Close()
        Login.Show()
    End Sub

    Private Sub SettingButton_Click(sender As Object, e As EventArgs) Handles SettingButton.Click
        Guna2ContextMenuStrip1.Show(SettingButton, New Point(0, SettingButton.Height))
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        BaseAccountLog.Logout(My.Settings.myId, "Logout")
        Me.Close()
        Login.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem IsNot Nothing Then
            Dim timePeriod As String = ComboBox1.SelectedItem.ToString().ToLower()

            UpdateChart(timePeriod)
        End If
    End Sub

    Private Sub UpdateChart(timePeriod As String)
        Try
            ' Get the data from ScalarTransaction based on the selected time period
            Dim transac As DataTable = BaseTransaction.ScalarChartTransaction(timePeriod)
            ' Check if the DataTable is not null and contains rows
            If transac IsNot Nothing AndAlso transac.Rows.Count > 0 Then
                ' Set the DataSource of the chart to the DataTable
                Chart1.DataSource = transac

                ' Ensure the chart has at least one ChartArea
                If Chart1.ChartAreas.Count = 0 Then
                    Chart1.ChartAreas.Add("ChartArea1")
                End If

                ' Ensure the Series exists before accessing it
                If Not Chart1.Series.IsUniqueName("Series1") Then
                    ' Clear any existing series if present
                    Chart1.Series.Clear()
                    ' Add the Series dynamically
                    Chart1.Series.Add("Series1")
                End If

                ' Access the newly created series "Series1"
                Dim series1 As Series = Chart1.Series("Series1")
                series1.ChartType = SeriesChartType.FastLine
                series1.Name = "Series1"

                ' Customize the appearance of the series
                With Chart1
                    .Series("Series1").BorderWidth = 2
                    .Series("Series1").Color = System.Drawing.Color.Blue
                    .ChartAreas(0).Area3DStyle.Enable3D = False

                    ' Set the X and Y value members based on the time period
                    If timePeriod = "daily" Then
                        .Series("Series1").XValueMember = "TransactionDate"  ' Use TransactionDate for daily
                    ElseIf timePeriod = "weekly" Then
                        .Series("Series1").XValueMember = "WeekStart"  ' Use WeekStart for weekly data
                    ElseIf timePeriod = "monthly" Then
                        .Series("Series1").XValueMember = "Month"  ' Use Month for monthly
                    ElseIf timePeriod = "annually" Then
                        .Series("Series1").XValueMember = "Year"  ' Use Year for annually
                    End If

                    .Series("Series1").YValueMembers = "Total"  ' Y-axis will always be 'Total' column
                    .Series("Series1").LabelFormat = "{#,##0}"
                    .Series("Series1").IsValueShownAsLabel = True
                    .Series("Series1").IsVisibleInLegend = True
                End With
            Else
                'MessageBox.Show("No data available for the selected time period.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class