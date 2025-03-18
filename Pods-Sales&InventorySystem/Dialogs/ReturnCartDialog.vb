Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ReturnCartDialog
    Private ReadOnly _subject As IObservablePanel
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _data2 As Dictionary(Of String, String)
    Public _itemSource As DataTable
    Private _parent As TransactionDialog = Nothing
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional data2 As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing,
                   Optional parent As TransactionDialog = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
        _data2 = data2
        _parent = parent
    End Sub

    Private Sub ReturnCartDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                TransactionTextBox.Text = _data.Item("ref")
                ReturnDatePicker.Value = _data.Item("date")
                TransactionTextBox.Enabled = False

            ElseIf _data2 IsNot Nothing Then
                TransactionTextBox.Text = _data2.Item("ref")
                ReturnDatePicker.Value = _data2.Item("date")
                TransactionTextBox.Enabled = False
                SaveButton.Visible = False

            End If
            TransactionTextBox.Enabled = False
            ReturnDatePicker.Enabled = False
            UpdateVisualData()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub AddReturnButton_Click(sender As Object, e As EventArgs) Handles AddReturnButton.Click
        Dim dialog As New ReturnDialog(data:=_data, parent:=Me)
        dialog.ShowDialog()
    End Sub
    Public Sub UpdateVisualData()
        Try
            ReturnDataGridView.DataSource = _itemSource?.DefaultView
            Dim total As Decimal = 0
            For i = 0 To ReturnDataGridView?.Rows.Count - 1
                total += ReturnDataGridView.Rows(i).Cells("TOTAL").Value
            Next
            TotalPrice.Text = total
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            If ReturnDataGridView.Rows.Count > 0 Then
                Dim items As New List(Of Dictionary(Of String, String))()
                Dim data As New Dictionary(Of String, String) From {
                    {"account_id", If(String.IsNullOrEmpty(My.Settings.myId), 0, My.Settings.myId)},
                    {"transaction_id", If(String.IsNullOrEmpty(_data.Item("delivery_id")), 0, _data.Item("delivery_id"))},
                    {"reason", If(String.IsNullOrEmpty(_data.Item("delivery_id")), 0, _data.Item("delivery_id"))},
                    {"total", If(String.IsNullOrEmpty(TotalPrice.Text), 0, TotalPrice.Text)}
                }

                For Each row As DataGridViewRow In ReturnDataGridView.Rows
                    Dim item As New Dictionary(Of String, String) From {
                        {"id", If(String.IsNullOrEmpty(row.Cells(0).Value?.ToString()), 0, row.Cells(0).Value?.ToString())},
                        {"price", If(String.IsNullOrEmpty(row.Cells(3).Value?.ToString()), 0, row.Cells(3).Value?.ToString())},
                        {"quantity", If(String.IsNullOrEmpty(row.Cells(4).Value?.ToString()), 0, row.Cells(4).Value?.ToString())}
                    }
                    items.Add(item)
                Next

                Dim baseCommand As New BaseReturn(data) With {.Items = items}
                Dim invoker As ICommandInvoker = Nothing
                invoker = New AddCommand(baseCommand)

                invoker?.Execute()
                _subject.NotifyObserver()
                Me.Close()
                _parent.Close()
            Else
                MessageBox.Show("No product selected.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReturnDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReturnDataGridView.CellClick
        Try
            If _data IsNot Nothing Then
                If ReturnDataGridView.Rows.Count > 0 Then
                    Dim row As DataGridViewRow = ReturnDataGridView.SelectedRows(0)
                    Dim data As New Dictionary(Of String, String) From {
                        {"id", If(row.Cells(0).Value?.ToString(), "0")},
                        {"product", If(row.Cells(1).Value?.ToString(), "")},
                        {"price", If(row.Cells(2).Value?.ToString(), "")},
                        {"quantity", If(row.Cells(3).Value?.ToString(), "")},
                        {"total", If(row.Cells(4).Value?.ToString(), "0")},
                        {"target", If(row.Cells(5).Value?.ToString(), "0")},
                        {"reference", If(_data.Item("ref"), "0")}
                    }
                    Using dialog As New ReturnDialog(data2:=data, parent:=Me)
                        dialog.ShowDialog()
                    End Using
                End If
            End If

            If _data2 IsNot Nothing Then
                If ReturnDataGridView.Rows.Count > 0 Then
                    Dim row As DataGridViewRow = ReturnDataGridView.SelectedRows(0)
                    Dim data As New Dictionary(Of String, String) From {
                        {"id", If(row.Cells(0).Value?.ToString(), "0")}
                    }
                    Using dialog As New ReturnProductDialog(parent:=Me, data:=data, subject:=_subject)
                        dialog.ShowDialog()
                    End Using
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
