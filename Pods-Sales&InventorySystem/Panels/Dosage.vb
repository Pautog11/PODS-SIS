﻿Public Class Dosage
    Implements IObserverPanel
    Private _subject As IObservablePanel
    Private ReadOnly _tableAapter As New podsTableAdapters.viewtbldosageTableAdapter
    Private _dataTable As New pods.viewtbldosageDataTable
    Private Sub Dosage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _subject = Application.OpenForms.OfType(Of Dashboard).FirstOrDefault
            _subject?.RegisterObserver(Me)
            _subject?.NotifyObserver()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Observer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        _tableAapter.Fill(_dataTable)
        DosageDataGridView.DataSource = _dataTable
        DosageDataGridView.Columns.Item("ID").Visible = False
    End Sub

    Private Sub AddDosageButton_Click(sender As Object, e As EventArgs) Handles AddDosageButton.Click
        Dim dialog As New DosageDialog(subject:=_subject)
        dialog.ShowDialog()
    End Sub

    Private Sub DosageDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DosageDataGridView.CellClick
        Try
            If DosageDataGridView.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = DosageDataGridView.SelectedRows(0)
                Dim data As New Dictionary(Of String, String) From {
                    {"id", If(row.Cells(0).Value?.ToString(), String.Empty)},
                    {"dosage", If(row.Cells(1).Value?.ToString(), String.Empty)},
                    {"description", If(row.Cells(2).Value?.ToString(), String.Empty)}
                }
                Dim dialog As New DosageDialog(data:=data, subject:=_subject)
                dialog.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DosageSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles DosageSearchTextBox.TextChanged
        _dataTable = BaseDosage.Search(DosageSearchTextBox.Text)
        DosageDataGridView.DataSource = _dataTable
    End Sub
End Class
