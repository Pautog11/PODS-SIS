Imports System.Windows.Forms

Public Class SearchDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing)
        InitializeComponent()
        _data = data
    End Sub

    Private Sub SearchDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
