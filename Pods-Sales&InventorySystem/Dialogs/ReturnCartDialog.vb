﻿Imports System.Windows.Forms

Public Class ReturnCartDialog
    Private ReadOnly _subject As IObservablePanel
    Private ReadOnly _data As Dictionary(Of String, String) 'Private ReadOnly _parent As ReturnCartDialog = Nothing
    Public _itemSource As DataTable
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
        '_parent = Parent
    End Sub

    Private Sub ReturnCartDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _data IsNot Nothing Then
            TransactionTextBox.Text = _data.Item("ref")
            RetuenDatePicker.Value = _data.Item("date")
            ' Guna2HtmlLabel2.Text = _data.Item("delivery_id")
        End If
        TransactionTextBox.Enabled = False
        RetuenDatePicker.Enabled = False
    End Sub
    Private Sub AddReturnButton_Click(sender As Object, e As EventArgs) Handles AddReturnButton.Click
        Dim dialog As New ReturnDialog(data:=_data, parent:=Me)
        dialog.ShowDialog()
    End Sub
    Public Sub UpdateVisualData()
        ReturnDataGridView.DataSource = _itemSource?.DefaultView
        Dim total As Decimal = 0
        For i = 0 To ReturnDataGridView?.Rows.Count - 1
            total += ReturnDataGridView.Rows(i).Cells("TOTAL").Value
        Next
        TotalPrice.Text = total
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If ReturnDataGridView.Rows.Count > 0 Then
            Dim items As New List(Of Dictionary(Of String, String))()
            Dim data As New Dictionary(Of String, String) From { '{"id", _data?.Item("id")},
                {"account_id", My.Settings.myId},
                {"transaction_id", _data.Item("delivery_id")},
                {"reason", _data.Item("delivery_id")},
                {"total", TotalPrice.Text}
            }

            For Each row As DataGridViewRow In ReturnDataGridView.Rows
                Dim item As New Dictionary(Of String, String) From {
                    {"pid", row.Cells(1).Value},
                    {"price", If(row.Cells(3).Value?.ToString(), "0")},
                    {"quantity", If(row.Cells(4).Value?.ToString(), "0")},
                    {"total", If(row.Cells(5).Value?.ToString(), "0")}
                }
                items.Add(item)
            Next

            Dim baseCommand As New BaseReturn(data) With {
                .Items = items
            }
            Dim invoker As ICommandInvoker = Nothing

            invoker = New AddCommand(baseCommand)

            invoker?.Execute()
            _subject.NotifyObserver()
            Me.Close()
            '_parent.Close()
        Else
            MessageBox.Show("No product selected.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class