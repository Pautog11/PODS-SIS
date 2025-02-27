Public Class Form1
    'Dim num As Integer = 1
    Dim number As Decimal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        'MsgBox(num)
        'num += 1
        'If Decimal.TryParse(Guna2TextBox1.Text, number) Then
        '    ' If parsing is successful, show the number in the message box with 2 decimal places
        '    MsgBox(number.ToString("F2"))
        'Else
        '    ' If parsing fails, show an error message
        '    MsgBox("Failed to parse input. Please enter a valid decimal number.")
        'End If

        If Decimal.TryParse(Guna2TextBox1.Text, number) Then
            ' If parsing is successful, show the number in the message box with commas and 2 decimal places
            MsgBox(number.ToString("#,0.00"))
        Else
            ' If parsing fails, show an error message
            MsgBox("Failed to parse input. Please enter a valid decimal number.")
        End If
    End Sub

    'Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
    '    ' Temporarily disable the TextChanged event to prevent an infinite loop
    '    RemoveHandler Guna2TextBox1.TextChanged, AddressOf Guna2TextBox1_TextChanged

    '    ' Attempt to parse the text from Guna2TextBox1 into the 'number' variable
    '    Dim number As Decimal
    '    If Decimal.TryParse(Guna2TextBox1.Text, number) Then
    '        ' If parsing is successful, format the number with commas and 2 decimal places
    '        Guna2TextBox1.Text = number.ToString("#,0.00")
    '        ' Move the cursor to the end of the text after formatting
    '        Guna2TextBox1.SelectionStart = Guna2TextBox1.Text.Length
    '    Else
    '        ' If parsing fails, show an error message or handle it as needed
    '        ' Optionally, you can display an error message or reset the text box
    '        ' Guna2TextBox1.Text = "Invalid input"
    '    End If

    '    ' Re-enable the TextChanged event
    '    AddHandler Guna2TextBox1.TextChanged, AddressOf Guna2TextBox1_TextChanged
    'End Sub
End Class