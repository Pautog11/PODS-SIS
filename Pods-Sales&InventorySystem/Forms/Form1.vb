Public Class Form1
    'Private parents As New List(Of Parent) From {
    '    New Parent With {
    '        .Name = "Fruits",
    '        .Children = New List(Of Child) From {
    '            New Child With {.Name = "Apple"},
    '            New Child With {.Name = "Banana"}
    '        }
    '    },
    '    New Parent With {
    '        .Name = "Vegetables",
    '        .Children = New List(Of Child) From {
    '            New Child With {.Name = "Carrot"},
    '            New Child With {.Name = "Broccoli"}
    '        }
    '    }
    '}
    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim dt As New DataTable()
    '    dt.Columns.Add("Name")
    '    dt.Columns.Add("IsParent", GetType(Boolean))

    '    For Each Parent In parents
    '        dt.Rows.Add(Parent.Name, True) ' Parent row
    '        For Each child In Parent.Children
    '            dt.Rows.Add(child.Name, False) ' Child row
    '        Next
    '    Next

    '    Guna2DataGridView1.DataSource = dt
    '    Guna2DataGridView1.Columns(0).HeaderText = "Name"
    '    Guna2DataGridView1.Columns(1).Visible = False ' Hide the IsParent column
    'End Sub
    'Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
    '    If e.RowIndex >= 0 Then
    '        Dim clickedRow = Guna2DataGridView1.Rows(e.RowIndex)

    '        If Convert.ToBoolean(clickedRow.Cells("IsParent").Value) Then
    '            Dim parentRowIndex As Integer = e.RowIndex + 1

    '            ' Toggle visibility of child rows
    '            While parentRowIndex < Guna2DataGridView1.Rows.Count AndAlso
    '                  Not Convert.ToBoolean(Guna2DataGridView1.Rows(parentRowIndex).Cells("IsParent").Value)
    '                Dim childRow = Guna2DataGridView1.Rows(parentRowIndex)
    '                childRow.Visible = Not childRow.Visible ' Toggle visibility
    '                parentRowIndex += 1
    '            End While
    '        End If
    '    End If
    'End Sub
End Class
Public Class Parent
    Public Property Name As String
    Public Property Children As List(Of Child)
End Class

Public Class Child
    Public Property Name As String
End Class
