Imports System.Windows.Forms

Public Class ReturnProductDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private _parent As ReturnCartDialog = Nothing
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional parent As ReturnCartDialog = Nothing)
        InitializeComponent()
        _data = data
        _parent = parent
    End Sub

    Private Sub ReturnProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                Dim dt As DataTable = BaseReturn.SelectProductReturned(_data.Item("id"))
                If dt.Rows.Count > 0 Then
                    ProductTextBox.Text = dt.Rows(0)("product_name").ToString()
                    PriceTextBox.Text = dt.Rows(0)("price").ToString()
                    QuantityTextBox.Text = dt.Rows(0)("remaining_quantity").ToString()

                    BatchComboBox.DropDownHeight = 5 * BatchComboBox.ItemHeight
                    BatchComboBox.DataSource = dt.DefaultView
                    BatchComboBox.DisplayMember = "batch_number"

                    DateComboBox.DropDownHeight = 5 * DateComboBox.ItemHeight
                    DateComboBox.DataSource = dt.DefaultView
                    DateComboBox.DisplayMember = "expiration_date"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

    End Sub
End Class
