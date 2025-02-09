Imports System.Windows.Forms

Public Class VatDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub

    Private Sub VatDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                VatTextBox.Text = _data.Item("vat")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            Dim res As New List(Of Object()) From {InputValidation.ValidateInputString(VatTextBox, DataInput.STRING_INTEGER)}
            'Exit Sub
            If Not res.Any(Function(item As Object()) Not item(0)) Then
                Dim data As New Dictionary(Of String, String) From {
                    {"id", _data.Item("id")},
                    {"vat", res(0)(1)}
                }
                Dim baseCommand As New BaseVat(data)
                Dim invoker As ICommandInvoker = Nothing
                invoker = New UpdateCommand(baseCommand)
                invoker?.Execute()
                _subject.NotifyObserver()
                Me.Close()
                'Else
                '    MessageBox.Show("Please input a valid vat.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
