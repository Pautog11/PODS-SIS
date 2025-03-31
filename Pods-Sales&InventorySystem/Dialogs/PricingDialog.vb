Imports System.Windows.Forms

Public Class PricingDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub

    Private Sub PricingDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _data IsNot Nothing Then
            ProductTextBox.Text = _data.Item("name")
            SellingPriceTextBox.Text = _data.Item("selling_price")
            CostPriceTextBox.Text = _data.Item("cost_price")
        End If
    End Sub

    Private Sub UpdatePricetButton_Click(sender As Object, e As EventArgs) Handles UpdatePricetButton.Click

    End Sub
End Class
