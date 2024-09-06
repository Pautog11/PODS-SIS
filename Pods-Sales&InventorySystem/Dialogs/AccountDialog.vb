Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Guna.UI2.WinForms

Public Class AccountDialog
    Private _subject As IObservablePanel
    Public Sub New(Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
    End Sub

    Private Sub AccountDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show("load")
    End Sub

    Private Sub AddAccountButton_Click(sender As Object, e As EventArgs) Handles AddAccountButton.Click
        'Guna2TextBox1.BorderColor = Color.Red
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand("INSERT INTO tblaccount (role_id, first_name, middle_name, last_name, birthday, phone_number, address, username, password) values (@role_id, @first_name, @middle_name, @last_name, @birthday, @phone_number, @address, @username, @password)", conn)
            cmd.Parameters.AddWithValue("@role_id", "1")
            cmd.Parameters.AddWithValue("@first_name", "Proktoy")
            cmd.Parameters.AddWithValue("@middle_name", "Apyot")
            cmd.Parameters.AddWithValue("@last_name", "Dilalamon")
            cmd.Parameters.AddWithValue("@birthday", "1999-12-25")
            cmd.Parameters.AddWithValue("@phone_number", "09568456985")
            cmd.Parameters.AddWithValue("@address", "Taguig City")
            cmd.Parameters.AddWithValue("@username", "sample")
            cmd.Parameters.AddWithValue("@password", "pas123")
            cmd.ExecuteNonQuery()
            _subject?.NotifyObserver()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
