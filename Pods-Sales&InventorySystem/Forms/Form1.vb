Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Using conn As SqlConnection = SqlConnectionPods.GetInstance()
            Using cmd As New SqlCommand("SELECT 
                                     tbldeliveries_items.id, 
                                     exd,  
                                     CAST(mfd AS DATE) AS mfd, 
                                     price, 
                                     tbldeliveries_items.quantity, 
                                     total 
                                 FROM 
                                     tbldeliveries_items 
                                 JOIN 
                                     tblproducts ON tbldeliveries_items.product_id = tblproducts.id 
                                 JOIN 
                                     tblproduct_notif ON tbldeliveries_items.delivery_id = tblproduct_notif.delivery_id
                                 WHERE 
                                     tbldeliveries_items.delivery_id = @delivery_id", conn)

                cmd.Parameters.AddWithValue("@delivery_id", 1025)

                ' Open connection if needed
                ' If conn.State = ConnectionState.Closed Then
                '     conn.Open()
                ' End If

                ' Execute the command and read the data
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        Dim message As String = ""

                        While reader.Read()
                            ' Format the dates
                            Dim mfdDate As Date = reader("mfd")
                            Dim exdDate As Date = reader("exd")

                            Dim formattedMfd As String = mfdDate.ToString("yyyy-MM-dd") ' Format as needed
                            Dim formattedExd As String = exdDate.ToString("yyyy-MM-dd") ' Format as needed

                            ' Concatenate the data into a message string
                            message &= String.Format("ID: {0}, MFD: {1}, EXD: {2}, Price: {3}, Quantity: {4}, Total: {5}{6}",
                                             reader("id"),
                                             formattedMfd,
                                             formattedExd,
                                             reader("price"),
                                             reader("quantity"),
                                             reader("total"),
                                             Environment.NewLine)
                        End While

                        ' Display the message box with the data
                        MessageBox.Show(message, "Delivery Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        End Using

    End Sub
End Class