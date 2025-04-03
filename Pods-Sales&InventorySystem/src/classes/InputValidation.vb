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
                'If Not String.IsNullOrEmpty(stringInput) AndAlso Not String.IsNullOrWhiteSpace(stringInput) Then
                '    If stringInput.Length > 1 Then
                '        Dim nameString As String() = stringInput.Split(" ")
                '        For i = 0 To nameString.Count - 1
                '            Dim charArr As Char() = nameString(i).ToArray()
                '            charArr(0) = CStr(charArr(0)).ToUpper
                '            nameString(i) = String.Join("", charArr)
                '        Next
                '        Return {True, String.Join(" ", nameString)}
                '    End If
                'End If

                'If Not String.IsNullOrEmpty(stringInput) AndAlso Not String.IsNullOrWhiteSpace(stringInput) Then
                '    If stringInput.Length > 1 Then
                '        Dim cleanedString As String = String.Join(" ", stringInput.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries))
                '        Dim nameString As String() = cleanedString.Split(" "c)
                '        For i = 0 To nameString.Length - 1
                '            nameString(i) = Char.ToUpper(nameString(i)(0)) & nameString(i).Substring(1).ToLower()
                '        Next
                '        Return {True, String.Join(" ", nameString)}
                '    End If
                'End If

                'If Not String.IsNullOrEmpty(stringInput) AndAlso Not String.IsNullOrWhiteSpace(stringInput) Then
                '    ' Remove any invalid characters (non-alphanumeric and non-space)
                '    Dim cleanedInput As String = New String(stringInput.Where(Function(c) Char.IsLetterOrDigit(c) OrElse Char.IsWhiteSpace(c)).ToArray())

                '    ' Check if cleanedInput is equal to the original input to ensure only valid characters were present
                '    If cleanedInput <> stringInput Then
                '        MessageBox.Show("Input contains invalid characters. Only letters, numbers, and spaces are allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '        Exit Select
                '    End If

                '    ' Replace multiple spaces with a single space
                '    Dim cleanedString As String = String.Join(" ", cleanedInput.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries))

                '    ' Only process if the cleaned string has more than 1 character
                '    If cleanedString.Length > 1 Then
                '        ' Split into words
                '        Dim nameString As String() = cleanedString.Split(" "c)

                '        ' Capitalize the first letter of each word and ensure the rest are lowercase
                '        For i = 0 To nameString.Length - 1
                '            nameString(i) = Char.ToUpper(nameString(i)(0)) & nameString(i).Substring(1).ToLower()
                '        Next

                '        ' Return the cleaned, properly capitalized string
                '        Return {True, String.Join(" ", nameString)}
                '    Else
                '        MessageBox.Show("Input is too short or invalid. Please provide a valid input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '        Exit Select
                '    End If
                'Else
                '    MessageBox.Show("Input is empty or only contains spaces. Please provide a valid input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Exit Select
                'End If



                If Not String.IsNullOrEmpty(stringInput) AndAlso Not String.IsNullOrWhiteSpace(stringInput) Then
                    ' Remove any invalid characters (non-alphanumeric and non-space)
                    Dim cleanedInput As String = New String(stringInput.Where(Function(c) Char.IsLetterOrDigit(c) OrElse Char.IsWhiteSpace(c)).ToArray())

                    ' Check if the cleaned input contains only numbers (and no letters)
                    If cleanedInput.All(Function(c) Char.IsDigit(c) OrElse Char.IsWhiteSpace(c)) Then
                        MessageBox.Show("Input cannot contain numbers only. It must include at least one letter.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Select
                    End If

                    ' Replace multiple spaces with a single space
                    Dim cleanedString As String = String.Join(" ", cleanedInput.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries))

                    ' Only process if the cleaned string has more than 1 character
                    If cleanedString.Length > 1 Then
                        ' Split into words
                        Dim nameString As String() = cleanedString.Split(" "c)

                        ' Capitalize the first letter of each word and ensure the rest are lowercase
                        For i = 0 To nameString.Length - 1
                            nameString(i) = Char.ToUpper(nameString(i)(0)) & nameString(i).Substring(1).ToLower()
                        Next

                        ' Return the cleaned, properly capitalized string
                        Return {True, String.Join(" ", nameString)}
                    Else
                        MessageBox.Show("Input is too short or invalid. Please provide a valid input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Select
                    End If
                Else
                    MessageBox.Show("Input is empty or only contains spaces. Please provide a valid input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Select
                End If




            Case DataInput.STRING_NAME
                If stringInput.Count > 1 Then
                    Dim nameString As String() = stringInput.Split(" "c)
                    Dim allowedCharsRegex As New Regex("^[A-Za-z,.'&-]+$")
                    For i = 0 To nameString.Count - 1
                        If Not allowedCharsRegex.IsMatch(nameString(i)) Then
                            MessageBox.Show("Invalid characters detected.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            'Return {False}
                            Exit Select
                        End If
                        If nameString(i).Any(Function(c) Char.IsLetter(c)) Then
                            Dim charArr As Char() = nameString(i).ToArray()
                            charArr(0) = Char.ToUpper(charArr(0))
                            nameString(i) = String.Join("", charArr)
                        End If
                    Next
                    Return {True, String.Join(" ", nameString)}
                Else
                    MessageBox.Show("Invalid name.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case DataInput.STRING_PRODUCTNAME
                If stringInput.Count > 1 Then
                    Dim nameString As String() = stringInput.Split(" "c)
                    'Dim allowedCharsRegex As New Regex("^[A-Za-z0-9,.'&-]+$")
                    Dim allowedCharsRegex As New Regex("^[A-Za-z0-9,.'&()-]+$")

                    For i = 0 To nameString.Count - 1
                        If Not allowedCharsRegex.IsMatch(nameString(i)) Then
                            MessageBox.Show("Invalid characters detected.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Select
                        End If
                        If nameString(i).Any(Function(c) Char.IsLetter(c)) Then
                            Dim charArr As Char() = nameString(i).ToArray()
                            charArr(0) = Char.ToUpper(charArr(0))
                            nameString(i) = String.Join("", charArr)
                        End If
                    Next
                    Return {True, String.Join(" ", nameString)}
                Else
                    MessageBox.Show("Invalid name.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Select
                End If


            Case DataInput.STRING_PASSWORD
                'if Regex.IsMatch(stringInput, "^(?=.*[0-9])(?= .*[@#$%^&+=]).{8,}$") Then
                Return {True, stringInput}
                'End If

            Case DataInput.STRING_PHONE
                start_trim_o = start_trim_o.Trim()
                If Regex.IsMatch(start_trim_o, "^(\+639|09)\d{2}[-\s]?\d{3}[-\s]?\d{4}$") Then
                    If start_trim_o.StartsWith("+63") Then
                        start_trim_o = "0" & start_trim_o.Substring(3)
                    End If
                    start_trim_o = Regex.Replace(start_trim_o, "[-\s]", "")
                    Return {True, start_trim_o}
                Else
                    MessageBox.Show("Invalid phone number.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Select
                End If

            Case DataInput.STRING_USERNAME
                If Not Regex.IsMatch(stringInput, "[^\w]+") Then
                    Return {True, stringInput}
                Else
                    MessageBox.Show("Invalid username.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Select
                End If

            Case DataInput.STRING_INTEGER
                If Regex.IsMatch(stringInput, "^\d+$") AndAlso Not stringInput = "0" Then
                    Return {True, stringInput}
                Else
                    MessageBox.Show("Invalid number.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Select
                End If

            Case DataInput.STRING_PRICE
                If Regex.IsMatch(stringInput, "^(\d+)?\.?(\d+)$") Then
                    Return {True, stringInput}
                Else
                    MessageBox.Show("Invalid price.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Select
                End If

            Case DataInput.STRING_DATE
                Dim dateValue As DateTime
                If Regex.IsMatch(stringInput, "^\d{4}-(0?[1-9]|1[0-2])-(0?[1-9]|[12][0-9]|3[01])$") Then
                    If DateTime.TryParseExact(stringInput, "yyyy-M-d", Nothing, Globalization.DateTimeStyles.None, dateValue) Then
                        Return {True, stringInput}
                    Else
                        ' MsgBox("The date is not valid.")
                        'Return {False, "Invalid date."}
                        Exit Select
                    End If
                Else
                    MessageBox.Show("Invalid date format.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case DataInput.STRING_PNAME
                If stringInput.Count > 1 Then
                    Dim nameString As String() = stringInput.Trim().Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
                    Dim regex As New Regex("^[A-Za-z.-]+$")
                    For i = 0 To nameString.Count - 1
                        If Not regex.IsMatch(nameString(i)) Then
                            MessageBox.Show("Invalid characters detected.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            'Return {False}
                            Exit Select
                        End If
                        If nameString(i).Any(Function(c) Char.IsLetter(c)) Then
                            Dim charArr As Char() = nameString(i).ToArray()
                            charArr(0) = Char.ToUpper(charArr(0))
                            nameString(i) = String.Join("", charArr)
                        End If
                    Next
                    Return {True, String.Join(" ", nameString)}
                Else
                    MessageBox.Show("Invalid name.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Select
                End If

            Case DataInput.STRING_TEL
                'If Regex.IsMatch(start_trim_o, "^(?:\+639|09)\d{2}[-\s]?\d{3}[-\s]?\d{4}$|^\d{4}[-\s]?\d{4}$|^\d{2}[-\s]?\d{3}[-\s]?\d{4}$") Then
                '    start_trim_o = start_trim_o.Trim()
                '    If start_trim_o.StartsWith("+63") Then
                '        start_trim_o = "0" & start_trim_o.Substring(3)
                '    End If
                '    start_trim_o = Regex.Replace(start_trim_o, "[-\s]", "")
                '    Return {True, start_trim_o}
                'Else
                '    MessageBox.Show("Invalid phone or telephone number.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    Exit Select
                'End If

                If Regex.IsMatch(start_trim_o, "^(?:\+639|09)\d{2}[-\s]?\d{3}[-\s]?\d{4}$|^\d{4}[-\s]?\d{4}$|^\d{2}[-\s]?\d{3}[-\s]?\d{4}$") Then
                    start_trim_o = start_trim_o.Trim()

                    ' Check if the number starts with +63 and remove it, replacing it with 0
                    If start_trim_o.StartsWith("+63") Then
                        start_trim_o = "0" & start_trim_o.Substring(3)
                    End If

                    ' Remove spaces and dashes from the phone number
                    start_trim_o = Regex.Replace(start_trim_o, "[-\s]", "")

                    ' Check if the phone number is in the form of (02)12345678 and convert it
                    If start_trim_o.StartsWith("02") AndAlso start_trim_o.Length = 10 Then
                        start_trim_o = start_trim_o.Substring(1) ' Removes (02)
                    End If

                    ' If the result is a valid 8-digit or 11-digit number
                    If (start_trim_o.Length = 8 OrElse start_trim_o.Length = 11) Then
                        Return {True, start_trim_o}
                    Else
                        MessageBox.Show("Invalid phone or telephone number.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Select
                    End If
                Else
                    MessageBox.Show("Invalid phone or telephone number.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Select
                End If


            Case DataInput.STRING_DECIMAL
                If Regex.IsMatch(stringInput, "^\d+(\.\d{1,2})?$") Then
                    Return {True, stringInput}
                Else
                    MessageBox.Show("Please enter a valid decimal number.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Return {False, Nothing}
                    Exit Select
                End If

            Case DataInput.STRING_BATCH
                If Not String.IsNullOrEmpty(stringInput) AndAlso Not String.IsNullOrWhiteSpace(stringInput) Then
                    Dim pattern As String = "^(?!-)(?!.*--)[a-zA-Z0-9-]*(?<=\S)$"

                    If System.Text.RegularExpressions.Regex.IsMatch(stringInput, pattern) Then
                        If stringInput.Length > 1 Then
                            Dim nameString As String() = stringInput.Split(" ")
                            For i = 0 To nameString.Count - 1
                                Dim charArr As Char() = nameString(i).ToArray()
                                charArr(0) = CStr(charArr(0)).ToUpper
                                nameString(i) = String.Join("", charArr)
                            Next
                            Return {True, String.Join(" ", nameString)}
                        End If
                    Else
                        MessageBox.Show("Invalid characters detected.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Return {False, Nothing}
                        Exit Select
                    End If
                End If

            Case DataInput.STRING_CODE
                'If Not String.IsNullOrEmpty(stringInput) AndAlso Not String.IsNullOrWhiteSpace(stringInput) Then
                '    If stringInput.Length > 1 Then
                '        Dim cleanedString As String = stringInput.Replace(" ", "")
                '        If cleanedString.Length > 0 Then
                '            cleanedString = Char.ToUpper(cleanedString(0)) & cleanedString.Substring(1).ToLower()
                '        End If
                '        Return {True, cleanedString}
                '    End If
                'End If

                'If Not String.IsNullOrEmpty(stringInput) AndAlso Not String.IsNullOrWhiteSpace(stringInput) Then
                '    ' Replace multiple spaces with a single space and trim leading/trailing spaces
                '    Dim cleanedString As String = System.Text.RegularExpressions.Regex.Replace(stringInput, "\s+", " ").Trim()

                '    ' Check if the cleaned string contains invalid characters (spaces or any other non-valid input)
                '    If cleanedString.Length > 0 AndAlso System.Text.RegularExpressions.Regex.IsMatch(cleanedString, "^[a-zA-Z0-9\s]+$") Then
                '        ' Capitalize the first letter and make the rest lowercase
                '        cleanedString = Char.ToUpper(cleanedString(0)) & cleanedString.Substring(1).ToLower()
                '        Return {True, cleanedString}
                '    Else
                '        ' Show message box if invalid input (contains characters other than letters, digits, and single spaces)
                '        MessageBox.Show("Invalid input!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '        'Return {False, String.Empty}
                '        Exit Select
                '    End If
                'Else
                '    ' Show message box if the input is empty or only whitespace
                '    MessageBox.Show("Invalid input!.", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    'Return {False, String.Empty}
                '    Exit Select
                'End If

                If Not String.IsNullOrEmpty(stringInput) AndAlso Not String.IsNullOrWhiteSpace(stringInput) Then
                    ' Remove all spaces and reject any string with special characters
                    Dim cleanedString As String = System.Text.RegularExpressions.Regex.Replace(stringInput, "\s+", "") ' Remove all spaces
                    ' Check if the cleaned string contains only valid characters (letters and digits)
                    If cleanedString.Length > 0 AndAlso System.Text.RegularExpressions.Regex.IsMatch(cleanedString, "^[a-zA-Z0-9]+$") Then
                        ' Capitalize the first letter and make the rest lowercase
                        cleanedString = Char.ToUpper(cleanedString(0)) & cleanedString.Substring(1).ToLower()
                        Return {True, cleanedString}
                    Else
                        ' Show message box if invalid input (contains characters other than letters and digits)
                        MessageBox.Show("Invalid input.!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Select
                    End If
                Else
                    ' Show message box if the input is empty or only whitespace
                    MessageBox.Show("Invalid input.!", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Select
                End If



            Case DataInput.STRING_DOSAGE
                'If Not String.IsNullOrEmpty(stringInput) AndAlso Not String.IsNullOrWhiteSpace(stringInput) Then
                '    ' Remove all special characters and numbers using regex
                '    Dim cleanedString As String = System.Text.RegularExpressions.Regex.Replace(stringInput, "[^a-zA-Z\s]", "")

                '    ' Trim any extra spaces
                '    cleanedString = String.Join(" ", cleanedString.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries))

                '    ' Check if the cleaned string is not empty
                '    If cleanedString.Length > 0 Then
                '        Dim nameString As String() = cleanedString.Split(" "c)
                '        For i = 0 To nameString.Length - 1
                '            ' Capitalize the first letter and make the rest lowercase
                '            nameString(i) = Char.ToUpper(nameString(i)(0)) & nameString(i).Substring(1).ToLower()
                '        Next
                '        Return {True, String.Join(" ", nameString)}
                '    End If
                'End If

                If Not String.IsNullOrEmpty(stringInput) AndAlso Not String.IsNullOrWhiteSpace(stringInput) Then
                    ' Check for invalid characters (anything other than letters and spaces)
                    If System.Text.RegularExpressions.Regex.IsMatch(stringInput, "[^a-zA-Z\s]") Then
                        ' Display a message box if invalid characters are detected
                        MessageBox.Show("Invalid characters detected", "PODS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Select
                    End If

                    ' Remove all special characters and numbers using regex
                    Dim cleanedString As String = System.Text.RegularExpressions.Regex.Replace(stringInput, "[^a-zA-Z\s]", "")

                    ' Trim any extra spaces
                    cleanedString = String.Join(" ", cleanedString.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries))

                    ' Check if the cleaned string is not empty
                    If cleanedString.Length > 0 Then
                        Dim nameString As String() = cleanedString.Split(" "c)
                        For i = 0 To nameString.Length - 1
                            ' Capitalize the first letter and make the rest lowercase
                            nameString(i) = Char.ToUpper(nameString(i)(0)) & nameString(i).Substring(1).ToLower()
                        Next
                        Return {True, String.Join(" ", nameString)}
                    End If
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
    STRING_PRODUCTNAME
    STRING_BATCH
    STRING_CODE
    STRING_DOSAGE
End Enum