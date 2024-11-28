Imports System.Windows.Forms

Public Class DosageDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub
    Private Sub DosageDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                DoseTextBox.Text = _data.Item("dosage")
                DescriptionTextBox.Text = _data.Item("description")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AddDosageButton_Click(sender As Object, e As EventArgs) Handles AddDosageButton.Click
        Try
            Dim controls As Object() = {
                  DoseTextBox
              }
            Dim types As DataInput() = {
                DataInput.STRING_STRING
            }
            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
            Next

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim data As New Dictionary(Of String, String) From {
                    {"id", _data?.Item("id")},
                    {"dosage", result(0)(1)},
                    {"description", If(String.IsNullOrEmpty(DescriptionTextBox.Text), "", DescriptionTextBox.Text)}
                }
                Dim baseCommand As New BaseDosage(data)
                Dim invoker As ICommandInvoker = Nothing
                If _data Is Nothing Then
                    invoker = New AddCommand(baseCommand)
                ElseIf _data IsNot Nothing Then
                    invoker = New UpdateCommand(baseCommand)
                Else
                    MessageBox.Show("Dosage exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                invoker?.Execute()
                _subject.NotifyObserver()
                Me.Close()
            Else
                MessageBox.Show("Please fill out all textboxes or provide all valid inputs.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
