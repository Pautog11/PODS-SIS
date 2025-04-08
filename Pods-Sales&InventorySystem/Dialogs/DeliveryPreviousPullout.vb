Imports System.Windows.Forms

Public Class DeliveryPreviousPullout
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _parent As DeliveryCartDialog = Nothing
    Private selectedIds As List(Of String)

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional parent As DeliveryCartDialog = Nothing)
        InitializeComponent()
        _data = data
        _parent = parent
    End Sub

    Public Sub New(message As String)
        InitializeComponent()

        ' Parse the message (comma-separated IDs) into a list of strings
        selectedIds = message.Split(New String() {", "}, StringSplitOptions.None).ToList()
    End Sub

    Private Sub DeliveryPreviousPullout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                'MsgBox(_data.Item("supplier_id"))
                Dim dt As DataTable = BaseDelivery.FetchPullout(_data.Item("supplier_id"))

                If dt.Rows.Count > 0 Then
                    'PreviousPulloutDataGridView.DataSource = dt.DefaultView
                    PreviousPulloutDataGridView.Rows.Clear()
                    For Each i As DataRow In dt.Rows

                        Dim rowData As Object() = i.ItemArray

                        ' Add the row to the DataGridView
                        PreviousPulloutDataGridView.Rows.Add(rowData)
                    Next
                End If
            End If


            ' Assuming you have checkboxes in the form named Checkbox1, Checkbox2, ...
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is CheckBox Then
                    Dim chkBox As CheckBox = CType(ctrl, CheckBox)

                    ' Check if the checkbox's ID is in the selectedIds list
                    If selectedIds.Contains(chkBox.Tag.ToString()) Then
                        chkBox.Checked = True
                    End If
                End If
            Next


        Catch ex As Exception

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

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
        'Try
        '    If PreviousPulloutDataGridView.SelectedRows.Count > 0 Then
        '        Dim selectedRows As DataGridViewSelectedRowCollection = PreviousPulloutDataGridView.SelectedRows
        '        Dim row As DataGridViewRow = selectedRows(0)
        '        Dim data As New Dictionary(Of String, String) From {
        '            {"id", row.Cells(0).Value.ToString()}
        '        }
        '        'Dim Dialog As New DeliveryCartDialog(data:=data, subject:=_subject)
        '        'Dialog.ShowDialog()
        '    End If
        'Catch ex As Exception

        'End Try


        'Try
        '    ' Initialize a list to hold the dictionaries for each checked row
        '    Dim selectedData As New List(Of Dictionary(Of String, String))()

        '    ' Loop through each row in the DataGridView
        '    For Each row As DataGridViewRow In PreviousPulloutDataGridView.Rows
        '        ' Check if the checkbox in the row is checked
        '        If Convert.ToBoolean(row.Cells("checkbox").Value) Then
        '            ' Create a dictionary for the checked row and add row data
        '            Dim data As New Dictionary(Of String, String) From {
        '                {"id", row.Cells("id").Value.ToString()}
        '            }

        '            ' Add the dictionary to the list
        '            selectedData.Add(data)
        '            MsgBox(selectedData)
        '        End If
        '    Next

        '    ' After the loop, you can now work with the selectedData list of dictionaries
        '    ' For example, pass the selectedData to another form/dialog
        '    'If selectedData.Count > 0 Then
        '    '    ' Pass the selectedData to another form or process it as needed
        '    '    ' Dim Dialog As New DeliveryCartDialog(data:=selectedData, subject:=_subject)
        '    '    ' Dialog.ShowDialog()
        '    'Else
        '    '    MessageBox.Show("No rows selected.")
        '    'End If

        '    'For Each i In selectedData
        '    '    MsgBox(i)
        '    'Next

        'Catch ex As Exception
        '    ' Optionally log the exception or show an error message
        '    MessageBox.Show("An error occurred: " & ex.Message)
        'End Try















        Try
            Dim selectedData As New List(Of Dictionary(Of String, String))()
            Dim selectedIds As New List(Of String)()

            For Each row As DataGridViewRow In PreviousPulloutDataGridView.Rows
                If Convert.ToBoolean(row.Cells("checkbox").Value) Then
                    selectedIds.Add(row.Cells("id").Value.ToString())

                    Dim data As New Dictionary(Of String, String) From {
                        {"id", row.Cells("id").Value.ToString()}
                    }

                    selectedData.Add(data)
                End If
            Next

            If selectedIds.Count > 0 Then
                'message &= String.Join(" ", selectedIds)

                'MsgBox(message)_
                '(selectedData)
            Else
                MessageBox.Show("No rows selected.")
            End If





            '' Create a list to store the selected checkbox IDs
            'Dim selectedIds As New List(Of String)

            '' Loop through the checkboxes (assuming you have a set of checkboxes named Checkbox1, Checkbox2, etc.)
            'For Each ctrl As Control In Me.Controls
            '    If TypeOf ctrl Is CheckBox Then
            '        Dim chkBox As CheckBox = CType(ctrl, CheckBox)
            '        If chkBox.Checked Then
            '            ' Add the checkbox ID to the list (e.g., use the checkbox's Tag or Name property as the ID)
            '            selectedIds.Add(chkBox.Tag.ToString()) ' Assuming Tag contains the ID
            '        End If
            '    End If
            'Next


            '' Pass the selected IDs back to the parent form
            ''_parent.ReceiveSelectedIds(selectedIds)

            ''_parent.Guna2TextBox1.Text = selectedIds
            '' Close the child form


            ''Me.Close()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Public Sub CheckSelectedRows(selectedIds As List(Of String))
        ' Loop through all rows in the DataGridView
        For Each row As DataGridViewRow In PreviousPulloutDataGridView.Rows
            ' If the current row's ID matches one of the selected IDs
            If selectedIds.Contains(row.Cells("id").Value.ToString()) Then
                ' Set the checkbox value to True to mark it as checked
                row.Cells("checkbox").Value = True
            End If
        Next
    End Sub

End Class
