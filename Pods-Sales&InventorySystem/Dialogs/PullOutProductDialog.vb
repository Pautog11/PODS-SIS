Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class PullOutProductDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _parent As DeliveryPulloutCart = Nothing

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional parent As DeliveryPulloutCart = Nothing)
        InitializeComponent()
        _data = data
        _parent = parent
    End Sub

    Private Sub PullOutProductDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As DataTable = BasePullouts.AllProduct(_data.Item("id"))
            If dt.Rows.Count > 0 Then
                PulloutDataGridView.DataSource = dt.DefaultView
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
