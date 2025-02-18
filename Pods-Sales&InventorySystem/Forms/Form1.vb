Imports System.Data.SqlClient

Public Class Form1
    Dim connectionString As String = My.Settings.podsdbConnectionString
    Dim query As String = "select * from tblproducts"
    Dim autocompleteList As New AutoCompleteStringCollection()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2TextBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Guna2TextBox2.AutoCompleteSource = AutoCompleteSource.CustomSource

        PopulateAutoCompleteList()

        Guna2TextBox2.AutoCompleteCustomSource = autocompleteList
    End Sub


    Private Sub PopulateAutoCompleteList()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        autocompleteList.Add(reader("product_name").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub Guna2TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            'If Guna2TextBox2.Text.Length > 0 AndAlso Not autocompleteList.Contains(Guna2TextBox2.Text) Then
            '    MsgBox(Guna2TextBox2.Text)
            'End If

            MsgBox(Guna2TextBox2.Text)
        End If

        Guna2TextBox2.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim a As Integer = 184
        'Using dialog As New ReceiptViewer(transactionNumber:=a)
        '    dialog.ShowDialog()
        'End Using
        Try
            Dim conn As SqlConnection = SqlConnectionPods.GetInstance()
            Dim cmd As New SqlCommand("DECLARE @tite VARCHAR(50)
                                    SET @tite = 'papapqqqpa'
                                    print('The value of tite is: %s'+ @tite);", conn)

            ' Execute the command
            Throw New Exception(cmd.ExecuteNonQuery)

        Catch ex As SqlException
            ' Capture and show the message from the SQL Server error
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    '' This function will be triggered when the user types something into the ComboBox
    'Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
    '    ' Check if the user has typed something not in the autocomplete list
    '    If ComboBox1.Text.Length > 0 AndAlso Not autocompleteList.Contains(ComboBox1.Text) Then
    '        ' Trigger the append function (e.g., user is typing a new item)
    '        TriggerAppendFunction(ComboBox1.Text)
    '    End If
    'End Sub

    '' Define the function that will be triggered when an append action occurs
    'Private Sub TriggerAppendFunction(newProduct As String)
    '    ' Check if the text in ComboBox1 is found in the autocomplete list (this means it's a valid selection)
    '    If autocompleteList.Contains(newProduct) Then
    '        MessageBox.Show("Item appended: " & newProduct)
    '        ' Your custom logic to handle the append action (e.g., insert the new product into the database)
    '    End If
    'End Sub
End Class