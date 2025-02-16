Imports System.Text.RegularExpressions

Public Class InputValidation

    ''' <summary>
    ''' Use to validate the control's text
    ''' </summary>
    ''' <param name="control">Control to be validated</param>
    ''' <param name="type">Type of string validation</param>
    ''' <returns></returns>
    Public Shared Function ValidateInputString(control As Object, type As DataInput) As Object()
        Dim stringInput As String = Nothing

        ' The have different properties so we have distinguish them
        Select Case True
            Case TypeOf control Is Guna.UI2.WinForms.Guna2TextBox
                stringInput = TryCast(control, Guna.UI2.WinForms.Guna2TextBox).Text
            Case TypeOf control Is TextBox
                stringInput = TryCast(control, TextBox).Text
            'Case TypeOf control Is HandyControl.Controls.PasswordBox
            '    stringInput = TryCast(control, HandyControl.Controls.PasswordBox).Password
            Case TypeOf control Is ComboBox
                stringInput = TryCast(control, ComboBox).Text
                'Case TypeOf control Is Windows.Forms.ComboBox
                '    stringInput = TryCast(control, Windows.Forms.ComboBox).Text
                'Case TypeOf control Is Windows.Forms.ComboBox
                '    Dim comboBox As Windows.Forms.ComboBox = TryCast(control, Windows.Forms.ComboBox)
                '    If comboBox IsNot Nothing Then
                '        stringInput = comboBox.Text
                '    End If

        End Select

        stringInput = stringInput.Trim()
        Dim start_trim_o As String = stringInput
        stringInput = stringInput.TrimStart("0")
        If String.IsNullOrEmpty(stringInput) OrElse String.IsNullOrWhiteSpace(stringInput) Then
            control.BorderColor = Color.Red
            MessageBox.Show("Invalid input.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return {False, stringInput}
        End If

        'control.BorderBrush = New BrushConverter().ConvertFromString("#FFE0E0E0")
        control.BorderColor = Color.LightGray
        Select Case type
            Case DataInput.STRING_STRING
                If Not String.IsNullOrEmpty(stringInput) AndAlso Not String.IsNullOrWhiteSpace(stringInput) Then
                    If stringInput.Length > 1 Then
                        Dim nameString As String() = stringInput.Split(" ")
                        For i = 0 To nameString.Count - 1
                            Dim charArr As Char() = nameString(i).ToArray()
                            charArr(0) = CStr(charArr(0)).ToUpper
                            nameString(i) = String.Join("", charArr)
                        Next
                        Return {True, String.Join(" ", nameString)}
                    End If
                    'Else
                    '    MessageBox.Show("Invalid name.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case DataInput.STRING_NAME
                'If stringInput.Count > 1 Then
                '    Dim nameString As String() = stringInput.Split(" ")
                '    For i = 0 To nameString.Count - 1
                '        Dim charArr As Char() = nameString(i).ToArray()
                '        charArr(0) = CStr(charArr(0)).ToUpper
                '        nameString(i) = String.Join("", charArr)
                '    Next
                '    Return {True, String.Join(" ", nameString)}
                'End If

                'If stringInput.Count > 1 Then
                '    Dim nameString As String() = stringInput.Split(" ")
                '    Dim regex As New Regex("^[A-Za-z]")

                '    For i = 0 To nameString.Count - 1
                '        If regex.IsMatch(nameString(i)) Then
                '            Dim charArr As Char() = nameString(i).ToArray()
                '            charArr(0) = Char.ToUpper(charArr(0))
                '            nameString(i) = String.Join("", charArr)
                '            Return {True, String.Join(" ", nameString)}
                '        End If
                '    Next
                'End If
                '---------------------------------------------------------------------------------------
                'stringInput = System.Text.RegularExpressions.Regex.Replace(stringInput.Trim(), "\s+", " ")

                '' Check if there's more than one word
                'If stringInput.Count > 1 Then
                '    ' Split the string into words
                '    Dim nameString As String() = stringInput.Split(" "c)
                '    Dim regex As New Regex("^[A-Za-z]")

                '    ' Iterate through each word
                '    For i = 0 To nameString.Count - 1
                '        ' Capitalize the first letter if the word contains alphabetic characters
                '        If regex.IsMatch(nameString(i)) Then
                '            ' Capitalize the first character and join the rest of the word
                '            Dim charArr As Char() = nameString(i).ToArray()
                '            charArr(0) = Char.ToUpper(charArr(0))
                '            nameString(i) = String.Join("", charArr)
                '        End If
                '    Next

                '    ' Return the processed result
                '    Return {True, String.Join(" ", nameString)}
                'End If

                If stringInput.Count > 1 Then
                    ' Split the string into words
                    Dim nameString As String() = stringInput.Split(" "c)

                    ' Regex to match words with only alphabetic characters or specific special symbols (",", "&", ".", "'")
                    Dim allowedCharsRegex As New Regex("^[A-Za-z,.'&-]+$")

                    ' Iterate through each word
                    For i = 0 To nameString.Count - 1
                        ' Check if the word only contains allowed characters (alphabetic or specific symbols)
                        If Not allowedCharsRegex.IsMatch(nameString(i)) Then
                            MessageBox.Show("Invalid characters detected.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return {False}
                        End If

                        ' Capitalize the first letter if the word contains alphabetic characters
                        If nameString(i).Any(Function(c) Char.IsLetter(c)) Then
                            ' Capitalize the first character and join the rest of the word
                            Dim charArr As Char() = nameString(i).ToArray()
                            charArr(0) = Char.ToUpper(charArr(0))
                            nameString(i) = String.Join("", charArr)
                        End If
                    Next

                    ' Return the processed result
                    Return {True, String.Join(" ", nameString)}
                Else
                    MessageBox.Show("Invalid name.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If



            Case DataInput.STRING_PASSWORD
                'if Regex.IsMatch(stringInput, "^(?=.*[0-9])(?= .*[@#$%^&+=]).{8,}$") Then
                Return {True, stringInput}
                'End If

            Case DataInput.STRING_PHONE
                'If Regex.IsMatch(start_trim_o, "^(\+639|09)\d{2}[-\s]?\d{3}[-\s]?\d{4}$") Then
                '    Return {True, start_trim_o}
                'End If

                ' Trim any leading/trailing spaces
                start_trim_o = start_trim_o.Trim()

                ' Check if the phone number matches the pattern for mobile numbers
                If Regex.IsMatch(start_trim_o, "^(\+639|09)\d{2}[-\s]?\d{3}[-\s]?\d{4}$") Then
                    ' Remove spaces and dashes from the phone number
                    If start_trim_o.StartsWith("+63") Then
                        start_trim_o = "0" & start_trim_o.Substring(3)
                    End If

                    start_trim_o = Regex.Replace(start_trim_o, "[-\s]", "")

                    ' Return the cleaned phone number
                    Return {True, start_trim_o}
                    'Else
                    '    ' If the phone number does not match the expected pattern
                    '    Return {False, "Invalid phone number"}
                Else
                    MessageBox.Show("Invalid phone number.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If


            Case DataInput.STRING_USERNAME
                If Not Regex.IsMatch(stringInput, "[^\w]+") Then
                    Return {True, stringInput}
                Else
                    MessageBox.Show("Invalid username.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case DataInput.STRING_INTEGER
                If Regex.IsMatch(stringInput, "^\d+$") AndAlso Not stringInput = "0" Then
                    Return {True, stringInput}
                Else
                    MessageBox.Show("Invalid number.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case DataInput.STRING_PRICE
                If Regex.IsMatch(stringInput, "^(\d+)?\.?(\d+)$") Then
                    Return {True, stringInput}
                Else
                    MessageBox.Show("Invalid price.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case DataInput.STRING_DATE
                Dim dateValue As DateTime
                If Regex.IsMatch(stringInput, "^\d{4}-(0?[1-9]|1[0-2])-(0?[1-9]|[12][0-9]|3[01])$") Then
                    If DateTime.TryParseExact(stringInput, "yyyy-M-d", Nothing, Globalization.DateTimeStyles.None, dateValue) Then
                        Return {True, stringInput}
                    Else
                        MsgBox("The date is not valid.")
                        Return {False, "Invalid date."}
                    End If
                Else
                    'MsgBox("Invalid date format.")
                    'Return {False, "Invalid date format."}
                    MessageBox.Show("Invalid date format.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case DataInput.STRING_PNAME
                'If stringInput.Count > 1 Then
                '    ' Split the string into words
                '    Dim nameString As String() = stringInput.Split(" "c)
                '    Dim regex As New Regex("^[A-Za-z]")

                '    ' Iterate through each word
                '    For i = 0 To nameString.Count - 1
                '        ' Capitalize the first letter if the word contains alphabetic characters
                '        If regex.IsMatch(nameString(i)) Then
                '            ' Capitalize the first character and join the rest of the word
                '            Dim charArr As Char() = nameString(i).ToArray()
                '            charArr(0) = Char.ToUpper(charArr(0))
                '            nameString(i) = String.Join("", charArr)
                '        End If
                '    Next
                '    Return {True, String.Join(" ", nameString)}
                'End If

                If stringInput.Count > 1 Then
                    ' Trim extra spaces and split the string into words
                    Dim nameString As String() = stringInput.Trim().Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)

                    ' Regex to match words with only alphabetic characters or specific special characters ("-" and ".")
                    Dim regex As New Regex("^[A-Za-z.-]+$")

                    ' Iterate through each word
                    For i = 0 To nameString.Count - 1
                        ' Check if the word only contains valid characters (alphabetic or "-" or ".")
                        If Not regex.IsMatch(nameString(i)) Then
                            MessageBox.Show("Invalid characters detected.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return {False}
                        End If

                        ' Capitalize the first letter if the word contains alphabetic characters
                        If nameString(i).Any(Function(c) Char.IsLetter(c)) Then
                            ' Capitalize the first character and join the rest of the word
                            Dim charArr As Char() = nameString(i).ToArray()
                            charArr(0) = Char.ToUpper(charArr(0))
                            nameString(i) = String.Join("", charArr)
                        End If
                    Next

                    ' Return the processed result (with single spaces between words)
                    Return {True, String.Join(" ", nameString)}
                Else
                    MessageBox.Show("Invalid name.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case DataInput.STRING_TEL
                If Regex.IsMatch(start_trim_o, "^(?:\+639|09)\d{2}[-\s]?\d{3}[-\s]?\d{4}$|^\d{4}[-\s]?\d{4}$") Then
                    ' Trim leading and trailing spaces before processing
                    start_trim_o = start_trim_o.Trim()

                    ' Remove spaces and dashes from the phone number
                    If start_trim_o.StartsWith("+63") Then
                        start_trim_o = "0" & start_trim_o.Substring(3) ' Convert +63 to 0
                    End If

                    ' Remove all spaces and dashes from the phone number
                    'start_trim_o = String.Join(" ", start_trim_o.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries))
                    start_trim_o = Regex.Replace(start_trim_o, "[-\s]", "")
                    ' Return the cleaned phone number
                    Return {True, start_trim_o}
                Else
                    MessageBox.Show("Invalid phone number.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case DataInput.STRING_DECIMAL
                ' Adjust Regex to allow decimals (e.g., 123.45)
                If Regex.IsMatch(stringInput, "^\d+(\.\d{1,2})?$") Then
                    Return {True, stringInput}
                Else
                    MessageBox.Show("Please enter a valid decimal number.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return {False, Nothing}
                End If

        End Select
        control.BorderColor = Color.Red
        Return {False, stringInput}
    End Function
End Class

Public Enum DataInput
    STRING_STRING
    STRING_NAME
    STRING_PASSWORD
    STRING_USERNAME
    STRING_PHONE
    STRING_INTEGER
    STRING_PRICE
    STRING_DATE
    STRING_PNAME
    STRING_TEL
    STRING_DECIMAL
End Enum