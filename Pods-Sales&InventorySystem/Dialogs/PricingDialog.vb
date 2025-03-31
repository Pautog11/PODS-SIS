Imports System.Windows.Forms

Public Class PricingDialog
    Private ReadOnly _data As Dictionary(Of String, String)
    Private ReadOnly _subject As IObservablePanel

    Public Sub New(Optional data As Dictionary(Of String, String) = Nothing,
                   Optional subject As IObservablePanel = Nothing)
        InitializeComponent()
        _subject = subject
        _data = data
    End Sub

    Private Sub PricingDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _data IsNot Nothing Then
            ProductTextBox.Text = _data.Item("name")
            SellingPriceTextBox.Text = _data.Item("selling_price")
            CostPriceTextBox.Text = _data.Item("cost_price")
        End If
    End Sub

    Private Sub UpdatePricetButton_Click(sender As Object, e As EventArgs) Handles UpdatePricetButton.Click
        Try
            Dim controls As Object() = {SellingPriceTextBox}
            Dim types As DataInput() = {DataInput.STRING_DECIMAL}

            Dim result As New List(Of Object())
            For i = 0 To controls.Count - 1
                result.Add(InputValidation.ValidateInputString(controls(i), types(i)))
                Dim validationResult = TryCast(result(i), Object())
                If validationResult IsNot Nothing AndAlso validationResult.Length > 0 Then
                    If Not validationResult(0) = True Then
                        Exit Sub
                    End If
                End If
            Next

            If Val(SellingPriceTextBox.Text) <= Val(CostPriceTextBox.Text) Then
                MessageBox.Show("The selling price cannot be less than or equal to the cost price.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SellingPriceTextBox.Text = ""
                Exit Sub
            End If


            If Not result.Any(Function(item As Object()) Not item(0)) Then
                Dim data As New Dictionary(Of String, String) From {
                    {"id", _data?.Item("id")},
                    {"selling_price", result(0)(1)}
                }
                Dim baseCommand As New BasePricing(data)
                Dim invoker As ICommandInvoker = Nothing

                If _data IsNot Nothing Then
                    invoker = New UpdateCommand(baseCommand)
                    invoker?.Execute()
                    _subject.NotifyObserver()
                    Me.Close()
                Else
                    MessageBox.Show("Invalid quantity!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    SellingPriceTextBox.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
