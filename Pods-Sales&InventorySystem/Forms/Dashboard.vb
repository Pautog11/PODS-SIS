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
        For i As Integer = 1 To 2
            NotificationDataGridView.Rows.Add("Your product is running out of stock!")
            NotificationDataGridView.Rows.Add("Your product will expire in 7 days. Please take action.")
        Next
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

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class