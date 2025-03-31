Public Class Dashboard
    Implements IObservablePanel, IObserverPanel
    Private ReadOnly _observables As New List(Of IObserverPanel)
    Public Sub New()
        InitializeComponent()
        RegisterObserver(Me)
        NotifyObserver()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        BaseAccountLog.Logout(My.Settings.myId, "Logout")
        Me.Close()
        Login.Show()
    End Sub

    Private Sub SettingButton_Click(sender As Object, e As EventArgs) Handles SettingButton.Click
        Guna2ContextMenuStrip1.Show(SettingButton, New Point(0, SettingButton.Height))
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        BaseLoginStatus.Logout()
        'BaseAccountLog.Logout(My.Settings.myId, "Logout")
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

    'Private Sub DashboardTabControl_Click(sender As Object, e As EventArgs) Handles DashboardTabControl.Click
    '    If DashboardTabControl.SelectedTab Is DashboardTabControl.TabPages("pos") Then
    '        'NotifyObserver()
    '        'MsgBox("pos")
    '    End If
    'End Sub
End Class