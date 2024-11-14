Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Form2
    ' Declare the AutoCompleteStringCollection
    Private CityList As New AutoCompleteStringCollection()
    Dim dgv As New DataGridView()

    ' Load Event - Set up initial configurations

    'Inherits Form

    'Public Sub New()
    '    ' Initialize the form and the DataGridView
    '    Dim dgv As New DataGridView()
    '    dgv.Dock = DockStyle.Fill
    '    Me.Controls.Add(dgv)
    '    Me.Text = "DataGridView Modal"
    '    Me.Size = New Size(400, 300)
    'End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Configure Guna2TextBox for AutoComplete functionality
        'Guna2TextBox1.Text = "Type a product name..."
        'Me.Controls.Add(Guna2TextBox1)

        '' Set the AutoComplete properties for the TextBox
        'Guna2TextBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        'Guna2TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
        'Guna2TextBox1.AutoCompleteCustomSource = CityList
        'dgv.Show()
    End Sub

    ' This method queries the database for matching product names
    Private Sub LoadCitySuggestions()
        ' Create a new AutoCompleteStringCollection for storing results
        Dim cityList As New AutoCompleteStringCollection()

        ' Query the database for product names based on user input
        Using conn As New SqlConnection(My.Settings.con) ' Use your connection string here
            Using cmd As New SqlCommand("SELECT product_name FROM tblproducts WHERE product_name LIKE @CityName", conn)
                cmd.Parameters.AddWithValue("@CityName", Guna2TextBox1.Text & "%")  ' Add wildcard for partial matching

                ' Open the connection and execute the query
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    ' Read the results and add them to the AutoCompleteStringCollection
                    While reader.Read()
                        cityList.Add(reader("product_name").ToString())  ' Use "product_name" from query result
                    End While
                End Using
            End Using
        End Using

        ' Update the AutoComplete custom source for Guna2TextBox
        Guna2TextBox1.AutoCompleteCustomSource = cityList
    End Sub

    ' TextChanged event for the Guna2TextBox to load suggestions as the user types
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        ' Call the method to load suggestions based on user input
        If Guna2TextBox1.Text.Length >= 2 Then ' Only query after 2 or more characters are typed
            LoadCitySuggestions()
        End If
    End Sub

    Private Sub Form2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        MsgBox("HEllo")
    End Sub

    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        MsgBox("dsdsdsd")
    End Sub

    Private Sub Guna2TextBox1_Enter(sender As Object, e As EventArgs) Handles Guna2TextBox1.Enter
        dgv.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Create a new instance of the ModalForm
        'Dim modal As New ModalForm()

        '' Show the form as a modal dialog
        'modal.ShowDialog()
    End Sub


    Private Sub PopulateDataGridView()
        ' Create a DataTable with sample data
        Dim table As New DataTable()

        ' Add columns
        table.Columns.Add("ID", GetType(Integer))
        table.Columns.Add("Name", GetType(String))
        table.Columns.Add("Age", GetType(Integer))

        ' Add rows
        table.Rows.Add(1, "Alice", 25)
        table.Rows.Add(2, "Bob", 30)
        table.Rows.Add(3, "Charlie", 22)

        ' Set the DataGridView's DataSource to the DataTable
        dgv.DataSource = table
    End Sub


    Public Sub New()
        ' Initialize the form and the DataGridView
        dgv.Dock = DockStyle.Fill
        Me.Controls.Add(dgv)
        Me.Text = "DataGridView Modal"
        Me.Size = New Size(400, 300)

        PopulateDataGridView()
    End Sub

End Class
