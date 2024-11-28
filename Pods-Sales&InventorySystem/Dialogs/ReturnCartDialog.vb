Imports System.Windows.Forms

Public Class ReturnCartDialog
    Private ReadOnly _subject As IObservablePanel
    Private ReadOnly _data As Dictionary(Of String, String) 'Private ReadOnly _parent As ReturnCartDialog = Nothing
    Private ReadOnly _dat2 As Dictionary(Of String, String) 'Private ReadOnly _parent As ReturnCartDialog = Nothing
    Public _itemSource As DataTable
    Private _parent As TransactionDialog = Nothing
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional dat2 As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing,
                   Optional parent As TransactionDialog = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
        _dat2 = dat2
        _parent = parent
    End Sub

    Private Sub ReturnCartDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                TransactionTextBox.Text = _data.Item("ref")
                RetuenDatePicker.Value = _data.Item("date")

                TransactionTextBox.Enabled = False
            ElseIf _dat2 IsNot Nothing Then
                TransactionTextBox.Text = _dat2.Item("ref")
                RetuenDatePicker.Value = _dat2.Item("date")

                TransactionTextBox.Enabled = False
                SaveButton.Visible = False
            End If
            TransactionTextBox.Enabled = False
            RetuenDatePicker.Enabled = False
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
                Dim data As New Dictionary(Of String, String) From { '{"id", _data?.Item("id")},
                    {"account_id", My.Settings.myId},
                    {"transaction_id", _data.Item("delivery_id")},
                    {"reason", _data.Item("delivery_id")},
                    {"total", TotalPrice.Text}
                }

                For Each row As DataGridViewRow In ReturnDataGridView.Rows
                    Dim item As New Dictionary(Of String, String) From {
                        {"pid", row.Cells(1).Value},
                        {"price", If(String.IsNullOrEmpty(row.Cells(3).Value?.ToString()), 0, row.Cells(3).Value?.ToString())},
                        {"quantity", If(String.IsNullOrEmpty(row.Cells(4).Value?.ToString()), 0, row.Cells(4).Value?.ToString())},
                        {"total", If(String.IsNullOrEmpty(row.Cells(5).Value?.ToString()), 0, row.Cells(5).Value?.ToString())}
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
                _parent.Close()
            Else
                MessageBox.Show("No product selected.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
