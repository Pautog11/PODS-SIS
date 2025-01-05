Imports System.Data.SqlClient
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
                Guna2Button1.Enabled = False
                'Guna2Button2.Enabled = False

            ElseIf _dat2 IsNot Nothing Then
                TransactionTextBox.Text = _dat2.Item("ref")
                RetuenDatePicker.Value = _dat2.Item("date")
                'TotalPrice.Text = _dat2.Item("price")

                TransactionTextBox.Enabled = False
                SaveButton.Visible = False
            End If
            TransactionTextBox.Enabled = False
            RetuenDatePicker.Enabled = False
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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim transaction As SqlTransaction = SqlConnectionPods.GetInstance.BeginTransaction()
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance
            Dim cmd As New SqlCommand

            ' Prepare and execute the main delivery insertion
            cmd = New SqlCommand("INSERT INTO tblreturns (account_id, transaction_id, reason, total) VALUES (@account_id, @transaction_id, @reason, @total); SELECT SCOPE_IDENTITY()", conn, Transaction)
            cmd.Parameters.AddWithValue("@account_id", _data.Item("account_id"))
            cmd.Parameters.AddWithValue("@transaction_id", _data.Item("transaction_id"))
            cmd.Parameters.AddWithValue("@reason", _data.Item("reason"))
            cmd.Parameters.AddWithValue("@total", _data.Item("total"))

            Dim deliveryId As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            For Each item In ReturnDataGridView.Rows
                If item IsNot Nothing AndAlso item.Count > 0 Then
                    ' Insert into tbldeliveries_items
                    cmd.Parameters.Clear()
                    cmd = New SqlCommand("INSERT INTO tblreturn_items (tblreturn_id, product_id, price, quantity, total) VALUES (@tblreturn_id, @product_id, @price, @quantity, @total); SELECT SCOPE_IDENTITY()", conn, Transaction)
                    cmd.Parameters.AddWithValue("@tblreturn_id", deliveryId)
                    cmd.Parameters.AddWithValue("@product_id", item("pid"))
                    cmd.Parameters.AddWithValue("@price", item("price"))
                    cmd.Parameters.AddWithValue("@quantity", item("quantity"))
                    cmd.Parameters.AddWithValue("@total", item("total"))

                    If cmd.ExecuteNonQuery <= 0 Then
                        Throw New Exception("Failed to add return items!")
                    End If
                End If
            Next
            Transaction.Commit()
        Catch ex As Exception
            Transaction.Rollback()
        End Try
    End Sub

    'Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
    '    Dim dialog As New UpdateExpiry
    '    dialog.ShowDialog()
    'End Sub
End Class
