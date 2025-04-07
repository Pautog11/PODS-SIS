Imports System.Windows.Forms

Public Class ReturnProductDialog
    Private ReadOnly _subject As IObservablePanel
    Private ReadOnly _data As Dictionary(Of String, String)
    Private _parent As ReturnCartDialog = Nothing
    Dim delivery_id As Integer = Nothing
    Dim product_id As Integer = Nothing
    Dim delivery_items_id As Integer = Nothing
    Dim tran_id As Integer = Nothing
    Dim dt As DataTable
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing,
                   Optional parent As ReturnCartDialog = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
        _parent = parent
    End Sub

    Private Sub ReturnProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                dt = BaseReturn.SelectProductReturned(_data.Item("id"))
                If dt.Rows.Count > 0 Then
                    ProductTextBox.Text = dt.Rows(0)("product_name").ToString()
                    PriceTextBox.Text = dt.Rows(0)("price").ToString()
                    delivery_id = dt.Rows(0)("delivery_id").ToString()
                    product_id = dt.Rows(0)("id").ToString()
                    delivery_items_id = dt.Rows(0)("delivery_items_id").ToString()
                    tran_id = dt.Rows(0)("transaction_id").ToString()

                    BatchComboBox.DropDownHeight = 5 * BatchComboBox.ItemHeight
                    BatchComboBox.DataSource = dt.DefaultView
                    BatchComboBox.DisplayMember = "batch_number"

                    Guna2ComboBox1.DropDownHeight = 5 * Guna2ComboBox1.ItemHeight
                    Guna2ComboBox1.DataSource = dt.DefaultView
                    Guna2ComboBox1.DisplayMember = "expiration_date"

                    Guna2ComboBox2.DropDownHeight = 5 * Guna2ComboBox2.ItemHeight
                    Guna2ComboBox2.DataSource = dt.DefaultView
                    Guna2ComboBox2.DisplayMember = "remaining_quantity"

                    If BaseDelivery.EnableExp(product_id) = 0 Then
                        BatchComboBox.Enabled = False
                        Guna2ComboBox1.Enabled = False
                    End If


                    'If dt.Rows.Count > 0 Then
                    '    BatchComboBox.SelectedIndex = -1
                    '    Guna2ComboBox1.SelectedIndex = -1
                    '    Guna2ComboBox2.SelectedIndex = -1
                    'End If


                    'MsgBox(dt.Rows(0)("delivery_id").ToString())
                    'Guna2ComboBox1.Text = dt.Rows(0)("expiration_date").ToString()

                    'MsgBox(delivery_id)
                    'MsgBox(delivery_items_id)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Dim controls As Object() = {
                DesiredQuantityTextBox
            }
            Dim types As DataInput() = {
                DataInput.STRING_INTEGER
            }

            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                Dim validationResult = TryCast(result(i), Object())
                If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                    If Not validationResult(0) = True Then
                        Exit Sub
                    End If
                End If
            Next

            If Val(Guna2ComboBox2.Text) < Val(DesiredQuantityTextBox.Text) Then
                MessageBox.Show("You cannot add more than the quantity of sold items!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim data As New Dictionary(Of String, String) From {
                    {"inventory_quantity", DesiredQuantityTextBox.Text},
                    {"delivery_id", delivery_id},
                    {"product_id", product_id},
                    {"batch_number", BatchComboBox.Text},
                    {"expiration_date", Guna2ComboBox1.Text},
                    {"id", _data.Item("id")},
                    {"delivery_items_id", delivery_items_id},
                    {"tran_id", tran_id}
                }
                BaseReturn.Update_deliveries(data)
                'MessageBox.Show("Successfully added to the inventory.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                _subject.NotifyObserver()
                Me.Close()
            Else
                MessageBox.Show("Please provide valid inputs.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception

        End Try
        'MsgBox(delivery_items_id)
    End Sub

    Private Sub BatchComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles BatchComboBox.SelectionChangeCommitted
        delivery_items_id = BatchComboBox.SelectedItem("delivery_items_id")
        delivery_id = BatchComboBox.SelectedItem("delivery_id")
        tran_id = BatchComboBox.SelectedItem("transaction_id")
    End Sub
End Class
