﻿Imports System.Windows.Forms

Public Class DeliveryPulloutCart
    Private ReadOnly _data As Dictionary(Of String, String)

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing)
        InitializeComponent()
        _data = data
    End Sub

    Private Sub DeliveryPulloutCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _data IsNot Nothing Then
            TotalPrice.Text = _data.Item("supplier_id")
            TransactionDeliveryTextBox.Text = _data.Item("delivery_number")
            Guna2HtmlLabel1.Text = _data.Item("id")
        End If
    End Sub

    Private Sub AddPulloutProductButton_Click(sender As Object, e As EventArgs) Handles AddPulloutProductButton.Click

    End Sub
End Class