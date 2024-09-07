Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Guna.UI2.WinForms

Public Class AccountDialog
    Private _data As Dictionary(Of String, String)
    Private _subject As IObservablePanel
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub

    Private Sub AccountDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show("load")
    End Sub

    Private Sub AddAccountButton_Click(sender As Object, e As EventArgs) Handles AddAccountButton.Click
        'Guna2TextBox1.BorderColor = Color.Red
        Dim data As New Dictionary(Of String, String) From {
                {"role_id", "1"},
                {"first_name", "sample"},
                {"middle_name", "sample"},
                {"last_name", "sample"},
                {"birthday", "1999-12-07"},
                {"phone_number", "sample"},
                {"address", "sample"},
                {"username", "sample"},
                {"password", "sample"}
        }
        Dim baseCommand As New BaseAccount(data)
        Dim invoker As ICommandInvoker = Nothing
        invoker = New AddCommand(baseCommand)
        invoker?.Execute()
        _subject.NotifyObserver()

    End Sub

    'Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    '    Me.Close()
    'End Sub

    'Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    '    Me.Close()
    'End Sub

End Class
