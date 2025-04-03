Imports System.Windows.Forms

Public Class DisposalCartDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub

    Private Sub DisposalCartDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DiposalRefTextBox.Text = Helpers.GenInvoiceNumber(InvoiceType.Disposal)
            DatePicker.Value = DateTime.Now
            DatePicker.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Try
            Dim dialog As New DiposalProductDialog(parent:=Me)
            dialog.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class
