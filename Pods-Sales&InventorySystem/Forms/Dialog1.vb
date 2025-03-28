Imports System.Windows.Forms

Public Class Dialog1
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _parent As Form2 = Nothing

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional parent As Form2 = Nothing)
        InitializeComponent()
        _data = data
        _parent = parent
    End Sub
    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _data IsNot Nothing Then
            Guna2HtmlLabel1.Text = _data.Item("ID")
            Guna2HtmlLabel2.Text = _data.Item("CATEGORY")
            Guna2HtmlLabel3.Text = _data.Item("DESCRIPTION")
        End If
    End Sub
End Class
