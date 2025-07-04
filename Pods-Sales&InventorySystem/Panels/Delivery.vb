﻿Imports System.Data.SqlClient

Public Class Delivery
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtbldeliveriesTableAdapter
    Private ReadOnly _dataTable As New pods.viewtbldeliveriesDataTable
    Private Sub DeliveryCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        Try
            _tableAapter.Fill(_dataTable)
            DeliveryDataGridView.DataSource = _dataTable
            DeliveryDataGridView.Columns.Item("ID").Visible = False
            DeliveryDataGridView.Columns.Item("VENDOR").Visible = False
            DeliveryDataGridView.Columns.Item("SUBTOTAL").Visible = False
            DeliveryDataGridView.Columns.Item("DEDUCTED").Visible = False
            DeliveryDataGridView.Columns.Item("VAT").Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddDeliveryButton_Click(sender As Object, e As EventArgs) Handles AddDeliveryButton.Click
        Try
            Dim dialog As New DeliveryCartDialog(subject:=_subject)
            dialog.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeliveryDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DeliveryDataGridView.CellClick
        Try
            If DeliveryDataGridView.SelectedRows.Count > 0 Then
                Dim selectedRows As DataGridViewSelectedRowCollection = DeliveryDataGridView.SelectedRows
                Dim row As DataGridViewRow = selectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                    {"id", row.Cells(0).Value.ToString()},
                    {"delivery_number", row.Cells(1).Value.ToString()},
                    {"supplier_id", row.Cells(3).Value.ToString()},
                    {"vendor_id", row.Cells(4).Value.ToString()},
                    {"total", row.Cells(5).Value.ToString()},
                    {"deduction", row.Cells(6).Value.ToString()},
                    {"date", row.Cells(8).Value.ToString()},
                    {"vat", row.Cells(9).Value.ToString()}
                }
                Dim Dialog As New DeliveryCartDialog(data:=data, subject:=_subject)
                Dialog.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
