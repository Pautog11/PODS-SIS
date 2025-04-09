Imports System.Windows.Forms

Public Class DeliveryPreviousPullout
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _data2 As Dictionary(Of String, String)
    Private ReadOnly _parent As DeliveryCartDialog = Nothing
    Public check As New DataTable

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional data2 As Dictionary(Of String, String) = Nothing,
                   Optional checked As DataTable = Nothing,
                   Optional parent As DeliveryCartDialog = Nothing)
        InitializeComponent()
        _data = data
        _data2 = data2
        _parent = parent
        check = checked
    End Sub

    Private Sub DeliveryPreviousPullout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                Dim dt As DataTable = BaseDelivery.FetchPullout(_data.Item("supplier_id"))
                If dt.Rows.Count > 0 Then
                    PreviousPulloutDataGridView.Rows.Clear()
                    For Each i As DataRow In dt.Rows

                        Dim rowData As Object() = i.ItemArray
                        PreviousPulloutDataGridView.Rows.Add(rowData)
                    Next
                End If

                If check.Rows.Count > 0 Then
                    For Each row As DataGridViewRow In PreviousPulloutDataGridView.Rows
                        Dim rowId As String = row.Cells("id").Value.ToString()

                        For Each checkRow As DataRow In check.Rows
                            If checkRow("id").ToString() = rowId Then
                                row.Cells("checkbox").Value = True
                                Exit For
                            End If
                        Next
                    Next
                End If
            Else
                Dim dt As DataTable = BaseDelivery.FetchappliedPullout(_data2.Item("id"))
                If dt.Rows.Count > 0 Then
                    PreviousPulloutDataGridView.Rows.Clear()
                    For Each i As DataRow In dt.Rows
                        Dim rowData As Object() = i.ItemArray
                        PreviousPulloutDataGridView.Rows.Add(rowData)
                    Next
                End If
                PreviousPulloutDataGridView.Columns.Item("checkbox").Visible = False
                ApplyButton.Visible = False
                Updatevisualdata2()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PreviousPulloutDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PreviousPulloutDataGridView.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = PreviousPulloutDataGridView.Columns("checkbox").Index Then
            Dim Checked As Boolean = Convert.ToBoolean(PreviousPulloutDataGridView.Rows(e.RowIndex).Cells("checkbox").Value)
            PreviousPulloutDataGridView.Rows(e.RowIndex).Cells("checkbox").Value = Not Checked
            Updatevisualdata()
        End If
    End Sub

    Private Sub Updatevisualdata()
        Dim total As Decimal = 0D
        For Each row As DataGridViewRow In PreviousPulloutDataGridView.Rows
            If Convert.ToBoolean(row.Cells("checkbox").Value) Then
                Dim rowTotal As Decimal
                If Decimal.TryParse(row.Cells("total").Value.ToString(), rowTotal) Then
                    total += rowTotal
                End If
            End If
        Next
        TotalLabel.Text = total.ToString("F2")
    End Sub

    Private Sub Updatevisualdata2()
        Dim total As Decimal = 0D
        For Each row As DataGridViewRow In PreviousPulloutDataGridView.Rows
            'If Convert.ToBoolean(row.Cells("checkbox").Value) Then
            Dim rowTotal As Decimal
            If Decimal.TryParse(row.Cells("total").Value.ToString(), rowTotal) Then
                total += rowTotal
            End If
            'End If
        Next
        TotalLabel.Text = total.ToString("F2")
    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
        Try
            _parent.sample.Rows.Clear()
            For Each row As DataGridViewRow In PreviousPulloutDataGridView.Rows
                If Convert.ToBoolean(row.Cells("checkbox").Value) Then
                    Dim id As String = row.Cells("id").Value.ToString()
                    _parent.sample.Rows.Add(id)
                End If
            Next
            _parent.pullout_total = TotalLabel.Text
            _parent.Totalpullout()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class
