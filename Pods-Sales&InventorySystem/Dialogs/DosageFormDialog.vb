Imports System.Windows.Forms

Public Class DosageFormDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub

    Private Sub DosageFormDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If _data IsNot Nothing Then
                DosageFormTextBox.Text = _data.Item("dosageform")
                DescriptionTextBox.Text = _data.Item("description")

                AddDosageFormButton.Text = "Update"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddDosageFormButton_Click(sender As Object, e As EventArgs) Handles AddDosageFormButton.Click
        Try
            Dim controls As Object() = {
                DosageFormTextBox
            }
            Dim types As DataInput() = {
                DataInput.STRING_NAME
            }
            Dim result As New List(Of Object())
            'For i = 0 To controls.Count - 1
            '    result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
            'Next


            For i = 0 To controls.Count - 1
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                Dim validationResult = TryCast(result(i), Object())
                If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                    If Not validationResult(0) = True Then
                        Exit Sub
                    End If
                End If
            Next

            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim data As New Dictionary(Of String, String) From {
                    {"id", _data?.Item("id")},
                    {"dosageform", result(0)(1)},
                    {"description", If(String.IsNullOrEmpty(DescriptionTextBox.Text), "", DescriptionTextBox.Text)}
                }
                Dim baseCommand As New BaseDosageForm(data)
                Dim invoker As ICommandInvoker = Nothing
                If BaseDosageForm.Exists(result(0)(1)) = 0 AndAlso _data Is Nothing Then
                    invoker = New AddCommand(baseCommand)
                ElseIf _data IsNot Nothing Then
                    invoker = New UpdateCommand(baseCommand)
                Else
                    MessageBox.Show("Dosage form exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
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
