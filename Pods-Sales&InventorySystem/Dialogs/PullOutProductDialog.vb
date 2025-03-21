﻿Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class PullOutProductDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _parent As DeliveryPulloutCart = Nothing
    Dim dt As DataTable = Nothing

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional parent As DeliveryPulloutCart = Nothing)
        InitializeComponent()
        _data = data
        _parent = parent
    End Sub

    Private Sub PullOutProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim rrc As DataTable = BasePullouts.Rrc()
            RrcComboBox.DataSource = rrc
            RrcComboBox.DisplayMember = "code"
            RrcComboBox.ValueMember = "id"


            If _data IsNot Nothing AndAlso _data.ContainsKey("id") Then
                dt = BasePullouts.AllProduct(_data("id"))
                If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                    PulloutDataGridView.DataSource = dt.DefaultView
                End If
                'PulloutDataGridView.Columns.Item("ID").Visible = False
                'PulloutDataGridView.Columns.Item("SUPPLIER").Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'TableLayoutPanel1.RowStyles(0).Height = 0 ' Collapses the second row
        'TableLayoutPanel1.RowStyles(1).Height = 0 ' Collapses the second row
        'Me.Height = 300
        'Me.StartPosition = FormStartPosition.Manual
        'Me.CenterToScreen()

    End Sub

    Private Sub PulloutDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PulloutDataGridView.CellClick
        Try
            If PulloutDataGridView.Rows.Count > 0 AndAlso PulloutDataGridView.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = PulloutDataGridView.SelectedRows(0)
                ProductTextBox.Text = row.Cells(3).Value?.ToString()
                BatchNumberTextBox.Text = row.Cells(4).Value?.ToString()
                CostTextBox.Text = row.Cells(5).Value?.ToString()
                StocksTextBox.Text = row.Cells(6).Value?.ToString()
                ExpiryDateTextBox.Text = row.Cells(8).Value?.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error selecting product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        Try
            If dt IsNot Nothing Then
                Dim dv As DataView = dt.DefaultView
                dv.RowFilter = String.Format("NAME LIKE '%{0}%' OR [BATCH NUMBER] LIKE '%{0}%'", SearchTextBox.Text.Trim().Replace("'", "''"))

                PulloutDataGridView.DataSource = dv
            End If
        Catch ex As Exception
            MessageBox.Show("Error filtering products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
