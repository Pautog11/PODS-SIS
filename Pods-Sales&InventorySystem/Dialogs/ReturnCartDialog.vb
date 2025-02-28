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
                RetuenDatePicker.Value = _data.Item("date")

                TransactionTextBox.Enabled = False
                'Guna2Button1.Enabled = False
                'Guna2Button2.Enabled = False
                AddInventoryButton.Visible = False
            ElseIf _data2 IsNot Nothing Then
                TransactionTextBox.Text = _data2.Item("ref")
                RetuenDatePicker.Value = _data2.Item("date")
                'TotalPrice.Text = _dat2.Item("price")

                TransactionTextBox.Enabled = False
                SaveButton.Visible = False
            End If
            TransactionTextBox.Enabled = False
            RetuenDatePicker.Enabled = False
            UpdateVisualData()
        Catch ex As Exception

        End Try
        'MsgBox(_data.Item("delivery_id"))
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
                        {"price", If(String.IsNullOrEmpty(row.Cells(2).Value?.ToString()), 0, row.Cells(2).Value?.ToString())},
                        {"quantity", If(String.IsNullOrEmpty(row.Cells(3).Value?.ToString()), 0, row.Cells(3).Value?.ToString())}
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

    Private Sub AddInventoryButton_Click(sender As Object, e As EventArgs) Handles AddInventoryButton.Click
        Try
            Dim data As String = If(ReturnDataGridView.SelectedRows.Count > 0, ReturnDataGridView.SelectedRows(0).Cells(0).Value.ToString(), Nothing)
            If data IsNot Nothing Then
                Dim dialog As New ReturnInventoryDialog(id:=data)
                dialog.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
