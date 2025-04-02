Public Class Dashboard
    Implements IObservablePanel, IObserverPanel
    Private ReadOnly _observables As New List(Of IObserverPanel)

    Private GetDataByCategory As New Dictionary(Of String, Dictionary(Of String, Double))()
    Private salesSum As Double = 0.0
    Public Sub New()
        InitializeComponent()
        RegisterObserver(Me)
        NotifyObserver()

        'Guna2VScrollBar1.BindingContainer = Guna2DataGridView1
        'Guna2VScrollBar1.AutoScroll = True

        ' Initialize categories
        'GetDataByCategory.Add("Sales", New Dictionary(Of String, Double)())

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim currentYear As Integer = DateTime.Now.Year
        'For i As Integer = 0 To 9
        '    ComboBox1.Items.Add((currentYear - i).ToString())
        'Next
        'ComboBox1.SelectedIndex = 0 ' Select the latest year by default
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
        Try
            Accounts.Text = BaseAccount.ScalarAccount
            Sales.Text = BaseTransaction.ScalarSales
            Label3.Text = BaseTransaction.ScalarTransaction

            NotificationDataGridView.Rows.Clear()
            Dim dt As DataTable = BaseNotifications.CriticalLevel()
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    NotificationDataGridView.Rows.Add(row(0))
                Next
            End If

            Dim exp As DataTable = BaseNotifications.Expiry()
            If exp IsNot Nothing AndAlso exp.Rows.Count > 0 Then
                For Each row As DataRow In exp.Rows
                    NotificationDataGridView.Rows.Add(row(0))
                Next
            End If

            'Dim selectedYear As Integer
            'If ComboBox1.SelectedItem IsNot Nothing AndAlso Integer.TryParse(ComboBox1.SelectedItem.ToString(), selectedYear) Then
            '    LoadSalesData(selectedYear)
            'End If

        Catch ex As Exception

        End Try
    End Sub

    'Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
    '    BaseAccountLog.Logout("Logout")
    '    Me.Close()
    '    Login.Show()
    'End Sub

    Private Sub SettingButton_Click(sender As Object, e As EventArgs) Handles SettingButton.Click
        Guna2ContextMenuStrip1.Show(SettingButton, New Point(0, SettingButton.Height))
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        BaseLoginStatus.Logout()
        BaseAccountLog.Logout("Logout")
        Me.Close()
        Login.Show()
    End Sub

    Public Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Using dialog As New AboutBox
            dialog.ShowDialog()
        End Using
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        NotifyObserver()
    End Sub

    Private Sub Guna2ControlBox2_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox2.Click
        Try
            Application.Exit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Private Sub DashboardTabControl_Click(sender As Object, e As EventArgs) Handles DashboardTabControl.Click
    '    If DashboardTabControl.SelectedTab Is DashboardTabControl.TabPages("pos") Then
    '        'NotifyObserver()
    '        'MsgBox("pos")
    '    End If
    'End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedYear As Integer
        If ComboBox1.SelectedItem IsNot Nothing AndAlso Integer.TryParse(ComboBox1.SelectedItem.ToString(), selectedYear) Then
            LoadSalesData(selectedYear)
        End If
    End Sub

    Private Sub LoadSalesData(year As Integer)
        Dim dt As DataTable = BaseReports.GetSalesChart(year)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No data available for " & year, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Clear existing data
        GetDataByCategory("Sales").Clear()
        Guna2DataGridView1.Rows.Clear()
        cSales.DataPoints.Clear()

        ' Populate DataGridView & Chart
        For Each row As DataRow In dt.Rows
            Dim month As String = row("Month").ToString()
            Dim sales As Double
            If Not Double.TryParse(row("Sales").ToString(), sales) Then sales = 0 ' Ensure valid conversion

            GetDataByCategory("Sales")(month) = sales

            ' Add to DataGridView
            Dim rowIndex As Integer = Guna2DataGridView1.Rows.Add(New Object() {month, sales})
            Guna2DataGridView1.Rows(rowIndex).Visible = True

            ' Add to Chart
            cSales.DataPoints.Add(month, sales)
        Next

        ' Update total sales sum
        salesSum = GetDataByCategory("Sales").Values.Sum()
        'lblsales.Text = salesSum.ToString("n2")

        ' Refresh Chart
        GunaChart1.Update()
    End Sub
End Class