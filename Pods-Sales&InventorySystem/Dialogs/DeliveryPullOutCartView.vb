Imports System.Windows.Forms

Public Class DeliveryPullOutCartView
    Private ReadOnly _data As Dictionary(Of String, String)
    Public _itemSource As DataTable

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing)
        InitializeComponent()
        _data = data
    End Sub

    Private Sub DeliveryPullOutCartView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                TransactionDeliveryTextBox.Text = _data.Item("delivery_number")
                TotalPrice.Text = _data.Item("total")
                'MsgBox(_data.Item("id"))

                DeliveryPulloutDataGridView.Rows.Clear()
                Dim DeliveryItems As DataTable = BaseDelivery.Fillpulloutproducts(_data("id"))
                For Each row As DataRow In DeliveryItems.Rows
                    Dim rowData As New List(Of Object)()
                    For Each column As DataColumn In DeliveryItems.Columns
                        If column.ColumnName = "exd" Then
                            If row(column) IsNot DBNull.Value Then
                                Dim dateValue As Date = Convert.ToDateTime(row(column))
                                rowData.Add(dateValue.ToString("yyyy-MM-dd"))
                            Else
                                rowData.Add("N/A")
                            End If
                        Else
                            rowData.Add(row(column))
                        End If
                    Next
                    DeliveryPulloutDataGridView.Rows.Add(rowData.ToArray())
                Next
            End If
            SupplierComboBox.Enabled = False
            TransactionDeliveryTextBox.Enabled = False
            DateTimePicker.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
End Class
