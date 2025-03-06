Imports System.Drawing
Imports System.Windows.Forms
Public Class Form1
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtblaccountsTableAdapter
    Private _dataTable As New pods.viewtblaccountsDataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fill the DataTable
        _tableAapter.Fill(_dataTable)

        ' Set the DataSource for the DataGridView
        AccountsDataGridView.DataSource = _dataTable

        ' Ensure the button column is added only once
        'If AccountsDataGridView.Columns("ActionButton") Is Nothing Then
        '    ' Create a button column
        '    Dim buttonColumn As New DataGridViewButtonColumn()
        '    buttonColumn.Name = "ActionButton"
        '    buttonColumn.HeaderText = "Action"
        '    buttonColumn.Text = "Add"
        '    buttonColumn.UseColumnTextForButtonValue = True

        '    ' Add the button column to the DataGridView
        '    AccountsDataGridView.Columns.Add(buttonColumn)
        'End If

        If AccountsDataGridView.Columns("ActionButton") Is Nothing Then
            ' Create an image column
            Dim imgColumn As New DataGridViewImageColumn()
            imgColumn.Name = "ActionButton"
            imgColumn.HeaderText = "Action"
            imgColumn.Image = My.Resources.edit 'Image.FromFile("C:\path\to\your\icon.png") ' Change to your icon path

            ' Add the image column to the DataGridView
            AccountsDataGridView.Columns.Add(imgColumn)
        End If

        ' Enable custom rendering for the button
        'AddHandler AccountsDataGridView.CellPainting, AddressOf AccountsDataGridView_CellPainting
    End Sub

    'Private Sub AccountsDataGridView_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs)
    '    If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 AndAlso
    '       TypeOf DirectCast(sender, DataGridView).Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then

    '        ' Prevent default painting
    '        e.Handled = True

    '        ' Fill cell background
    '        e.Graphics.FillRectangle(New SolidBrush(Color.White), e.CellBounds)

    '        ' Create a rounded rectangle for the button
    '        Dim buttonRect As New Rectangle(e.CellBounds.X + 5, e.CellBounds.Y + 5, e.CellBounds.Width - 10, e.CellBounds.Height - 10)
    '        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
    '        Dim cornerRadius As Integer = 15 ' Adjust for rounded effect
    '        buttonPath.AddArc(buttonRect.X, buttonRect.Y, cornerRadius, cornerRadius, 180, 90)
    '        buttonPath.AddArc(buttonRect.Right - cornerRadius, buttonRect.Y, cornerRadius, cornerRadius, 270, 90)
    '        buttonPath.AddArc(buttonRect.Right - cornerRadius, buttonRect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90)
    '        buttonPath.AddArc(buttonRect.X, buttonRect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90)
    '        buttonPath.CloseFigure()

    '        ' Draw button background
    '        e.Graphics.FillPath(New SolidBrush(Color.FromArgb(0, 79, 119)), buttonPath) ' Dark Blue

    '        ' Draw button text
    '        Dim textColor As Color = Color.White
    '        Dim textFormat As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
    '        e.Graphics.DrawString("Add", e.CellStyle.Font, New SolidBrush(textColor), buttonRect, textFormat)
    '    End If
    'End Sub

    ' Event handler for button click
    Private Sub AccountsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AccountsDataGridView.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = AccountsDataGridView.Columns("ActionButton").Index Then
            MessageBox.Show("Button clicked in row " & e.RowIndex)
        End If
    End Sub

End Class