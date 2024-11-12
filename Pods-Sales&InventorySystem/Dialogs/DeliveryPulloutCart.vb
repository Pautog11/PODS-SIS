Imports System.Windows.Forms

Public Class DeliveryPulloutCart
    Private ReadOnly _data As Dictionary(Of String, String)
    Public _itemSource As DataTable
    Private ReadOnly _subject As IObservablePanel
    Private ReadOnly _parent As DeliveryCartDialog = Nothing


    Public Sub New(Optional subject As IObservablePanel = Nothing,
                   Optional data As Dictionary(Of String, String) = Nothing,
                   Optional parent As DeliveryCartDialog = Nothing)
        InitializeComponent()
        _data = data
        _subject = subject
        _parent = parent

    End Sub

    Private Sub DeliveryPulloutCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim roles As DataTable = BaseSupplier.Fetchsupplier()
        'SupplierComboBox.DataSource = roles
        'SupplierComboBox.DisplayMember = "first_name"
        'SupplierComboBox.ValueMember = "id"

        If _data IsNot Nothing Then
            DateTimePicker.MinDate = _data.Item("date")
            DateTimePicker.MaxDate = DateTime.Today

            SupplierComboBox.Text = _data.Item("supplier_id")
            TransactionDeliveryTextBox.Text = _data.Item("delivery_number")
            Guna2HtmlLabel1.Text = _data.Item("id")
        End If
    End Sub

    Private Sub AddPulloutProductButton_Click(sender As Object, e As EventArgs) Handles AddPulloutProductButton.Click
        Dim dialog As New PullOutProductDialog(data:=_data, parent:=Me)
        dialog.ShowDialog()

        'If SupplierComboBox.Text = "" Then
        '    MsgBox("wala")
        'End If
    End Sub
    Public Sub UpdateVisualData()
        DeliveryPulloutDataGridView.DataSource = _itemSource?.DefaultView
        Dim total As Decimal = 0
        For i = 0 To DeliveryPulloutDataGridView?.Rows.Count - 1
            total += DeliveryPulloutDataGridView.Rows(i).Cells("TOTAL").Value
        Next
        TotalPrice.Text = total
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'If SupplierComboBox.Text = "" Then
        '    MsgBox("wala")
        'End If
        'If DeliveryPulloutDataGridView.Rows.Count > 0 Then
        Dim items As New List(Of Dictionary(Of String, String))()
        Dim data As New Dictionary(Of String, String) From {
            {"id", _data?.Item("id")},
            {"account_id", My.Settings.myId},
            {"delivery_id", _data.Item("id")},
            {"total", TotalPrice.Text},
            {"reason", _data?.Item("id")},
            {"date", DateTimePicker.Value.ToString("MMM dd yyyy")}
         }

        For Each row As DataGridViewRow In DeliveryPulloutDataGridView.Rows
            Dim item As New Dictionary(Of String, String) From {
                {"product_id", row.Cells(0).Value},
                {"price", If(row.Cells(4).Value?.ToString(), "0")},
                {"quantity", If(row.Cells(5).Value?.ToString(), "0")},
                {"total", If(row.Cells(6).Value?.ToString(), "0")}
            }
            items.Add(item)
        Next

        Dim baseCommand As New BasePullouts(data) With {
            .Items = items
        }
        Dim invoker As ICommandInvoker = Nothing

        invoker = New AddCommand(baseCommand)

        invoker?.Execute()
        _subject.NotifyObserver()
        Me.Close()
        _parent.Close()
        'Else
        '    MessageBox.Show("No product selected!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End If
    End Sub
End Class
