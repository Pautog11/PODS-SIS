Imports System.Windows.Forms

Public Class DiscountDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel
    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub
    Private Sub DiscountDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _data IsNot Nothing Then
            DiscountTextBox.Text = _data.Item("discount")
        End If
    End Sub

    Private Sub AddDiscountButton_Click(sender As Object, e As EventArgs) Handles AddDiscountButton.Click
        Dim result As New List(Of Object()) From {InputValidation.ValidateInputString(DiscountTextBox, DataInput.STRING_INTEGER)}

        If Not result.Any(Function(item As Object()) Not item(0)) Then
            Dim data As New Dictionary(Of String, String) From {
                {"id", _data?.Item("id")},
                {"discount", result(0)(1)}
            }

            Dim baseCommand As New BaseDiscount(data)
            Dim invoker As ICommandInvoker = Nothing
            If BaseDiscount.Exists(result(0)(1)) = 0 AndAlso _data Is Nothing Then
                invoker = New AddCommand(baseCommand)
            ElseIf _data IsNot Nothing Then
                invoker = New UpdateCommand(baseCommand)
            Else
                MessageBox.Show("Discount exists!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            invoker?.Execute()
            _subject.NotifyObserver()
            Me.Close()
        Else
            MessageBox.Show("Please provide valid discount.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
