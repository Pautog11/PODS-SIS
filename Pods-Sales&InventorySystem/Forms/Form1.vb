Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ''Guna2TextBox1.BorderColor = Color.Red
        ''If String.IsNullOrEmpty(Guna2TextBox1.Text, Guna2TextBox2.Text) Then
        'ShakeControl(Guna2TextBox1)
        ''End If

        'Dim a As Object() = {Guna2TextBox1.Text, Guna2TextBox2} ', Guna2TextBox3, Guna2TextBox4, Guna2TextBox5}
        'Dim b As DataInput() = {DataInput.STRING_INTEGER, DataInput.STRING_INTEGER}

        'Dim res As New List(Of Object())
        'For i = 0 To Controls.Count - 1
        '    res.Add(InputValidation.ValidateInputString(a(i), b(i)))
        'Next

        'If Not res.Any(Function(item As Object()) Not item(0)) Then
        '    Dim data As New Dictionary(Of String, String) From {
        '        {"sample", res(0)(1)}}
        '    MessageBox.Show("pass")
        'Else
        '    MessageBox.Show("no")  
        'End If
        ''For Each textBox As Control In a
        ''    ShakeControl(textBox)
        ''Next

        If BaseAccount.Exists(Guna2TextBox1.Text) = 1 Then
            MessageBox.Show("Active")
        Else
            MsgBox("Not Active")
        End If


    End Sub

    Private Sub ShakeControl(ByVal ctrl As Control)
        ' Number of pixels to shake
        Dim shakeDistance As Integer = 10
        ' Duration of the shake effect in milliseconds
        Dim shakeDuration As Integer = 500
        ' Frequency of the shake (in milliseconds)
        Dim shakeFrequency As Integer = 50

        Dim originalLocation As Point = ctrl.Location
        Dim timer As New Timer()
        Dim shakeStep As Integer = 0

        ' Timer interval (milliseconds) for each shake step
        timer.Interval = shakeFrequency

        ' Event handler for the Timer
        AddHandler timer.Tick, Sub(sender As Object, e As EventArgs)
                                   If shakeStep >= (shakeDuration / shakeFrequency) Then

                                       timer.Stop()
                                       ctrl.Location = originalLocation
                                   Else
                                       If (shakeStep Mod 2) = 0 Then
                                           ctrl.Location = New Point(originalLocation.X + shakeDistance, originalLocation.Y)
                                       Else
                                           ctrl.Location = New Point(originalLocation.X - shakeDistance, originalLocation.Y)
                                       End If
                                       shakeStep += 1
                                   End If
                               End Sub

        ' Start the shaking effect
        timer.Start()
    End Sub
End Class