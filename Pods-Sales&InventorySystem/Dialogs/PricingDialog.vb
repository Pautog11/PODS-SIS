Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class PricingDialog
    Private _data As New Dictionary(Of String, String)
    Private ReadOnly _parent As DeliveryProductDialog = Nothing

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional parent As DeliveryProductDialog = Nothing)
        InitializeComponent()
        _data = data
        _parent = parent
    End Sub
    Private Sub PricingDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _data IsNot Nothing Then
            CostTextBox.Text = _data.Item("cost")
            txtPrays.Text = _data.Item("price")
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            If Val(txtPrays.Text) < Val(CostTextBox.Text) Then
                MessageBox.Show("It should not lesthan form the cost price.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim controls As Object() = {
                    CostTextBox, txtPrays
                }
                Dim types As DataInput() = {
                    DataInput.STRING_INTEGER, DataInput.STRING_INTEGER
                }
                Dim result As New List(Of Object())
                For i = 0 To controls.Count - 1
                    result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                Next
                If Not Result.Any(Function(item As Object()) Not item(0)) Then
                    Dim conn As SqlConnection = SqlConnectionPods.GetInstance
                    Dim cmd As New SqlCommand("UPDATE tblproducts set price = @price, cost = @cost WHERE id = @id", conn)
                    cmd.Parameters.AddWithValue("@price", txtPrays.Text)
                    cmd.Parameters.AddWithValue("@cost", CostTextBox.Text)
                    cmd.Parameters.AddWithValue("@id", _data.Item("id"))
                    If cmd.ExecuteNonQuery() <= 0 Then
                        MessageBox.Show("An error occured!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        MessageBox.Show("Price has been updated successfully!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        _parent.CostTextBox.Text = CostTextBox.Text
                        _parent.txtPrays.Text = txtPrays.Text
                        Me.Close()
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        '_parent.CostTextBox.Text = "jhladshld"
    End Sub
End Class
