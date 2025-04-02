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

    End Sub
End Class
