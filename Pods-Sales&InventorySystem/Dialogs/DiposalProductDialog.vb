Imports System.Windows.Forms

Public Class DiposalProductDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _parent As DisposalCartDialog = Nothing
    Dim delivery_items_id As Integer = Nothing
    Dim product_id As Integer = Nothing
    Dim num As Integer = 1
    Dim from As String = Nothing

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional parent As DisposalCartDialog = Nothing)
        InitializeComponent()
        _data = data
        _parent = parent
    End Sub

    Private Sub DiposalProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As DataTable = BaseDisposal.SelectAllProducts
            DisposalDataGridView.DataSource = dt.DefaultView
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DisposalDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DisposalDataGridView.CellClick
        Try
            If DisposalDataGridView.Rows.Count > 0 AndAlso DisposalDataGridView.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = DisposalDataGridView.SelectedRows(0)
                delivery_items_id = row.Cells(0).Value?.ToString()
                product_id = row.Cells(2).Value?.ToString()
                from = row.Cells(3).Value?.ToString()
                ProductTextBox.Text = row.Cells(4).Value?.ToString()
                BatchNumberTextBox.Text = row.Cells(5).Value?.ToString()
                ExpiryDateTextBox.Text = row.Cells(6).Value?.ToString()
                CostTextBox.Text = row.Cells(7).Value?.ToString()
                StocksTextBox.Text = row.Cells(8).Value?.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PullOutProductSaveButton_Click(sender As Object, e As EventArgs) Handles PullOutProductSaveButton.Click
        Try
            Dim result As New List(Of Object()) From {InputValidation.ValidateInputString(QuantityTextBox, DataInput.STRING_INTEGER)}
            Dim validationResult = TryCast(result(0), Object())
            If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                If Not validationResult(0) = True Then
                    Exit Sub
                End If
            Else
                Throw New Exception
            End If

            Dim is_existing As Boolean = False

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                For Each item As DataGridViewRow In _parent.DisposalDataGridView.Rows
                    'MsgBox(tran_id)
                    'MsgBox(p_id)
                    If item.Cells("id").Value.ToString() = delivery_items_id AndAlso item.Cells("pid").Value = product_id Then
                        item.Cells("from").Value = from
                        item.Cells("product").Value = ProductTextBox.Text
                        item.Cells("drc").Value = 1
                        item.Cells("batch_number").Value = BatchNumberTextBox.Text
                        item.Cells("expiry_date").Value = ExpiryDateTextBox.Text
                        item.Cells("cost_price").Value = Decimal.Parse(CostTextBox.Text).ToString("F2")
                        item.Cells("quantity").Value = CInt(QuantityTextBox.Text)
                        item.Cells("total").Value = Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text)
                        item.Cells("target").Value = 454654
                        is_existing = True
                        Exit For
                    End If
                Next

                If Not is_existing Then
                    _parent.DisposalDataGridView.Rows.Add({delivery_items_id,
                                                          product_id,
                                                          from,
                                                          ProductTextBox.Text,
                                                          1,
                                                          BatchNumberTextBox.Text,
                                                          ExpiryDateTextBox.Text,
                                                          Decimal.Parse(CostTextBox.Text).ToString("F2"),
                                                          CInt(QuantityTextBox.Text),
                                                          Decimal.Parse(CostTextBox.Text) * CInt(QuantityTextBox.Text),
                                                          num
                                                          })
                    num += 1
                End If
                _parent.UpdateVisualData()
                Me.Close()
            Else
                MessageBox.Show("Invalid quantity!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
