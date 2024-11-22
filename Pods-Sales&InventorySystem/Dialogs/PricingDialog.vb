Imports System.Windows.Forms

Public Class PricingDialog
    Private _data As New Dictionary(Of String, String)

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing)
        InitializeComponent()
        _data = data
    End Sub
    Private Sub PricingDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _data IsNot Nothing Then
            CostTextBox.Text = _data.Item("cost")
            txtPrays.Text = _data.Item("price")
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

    End Sub
End Class
