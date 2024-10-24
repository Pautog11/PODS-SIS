﻿Imports System.Text.RegularExpressions

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
        End Select

        stringInput = stringInput.Trim()
        Dim start_trim_o As String = stringInput
        stringInput = stringInput.TrimStart("0")
        If String.IsNullOrEmpty(stringInput) OrElse String.IsNullOrWhiteSpace(stringInput) Then
            control.BorderColor = Color.Red
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
                End If
            Case DataInput.STRING_NAME
                If stringInput.Count > 1 Then
                    Dim nameString As String() = stringInput.Split(" ")
                    For i = 0 To nameString.Count - 1
                        Dim charArr As Char() = nameString(i).ToArray()
                        charArr(0) = CStr(charArr(0)).ToUpper
                        nameString(i) = String.Join("", charArr)
                    Next
                    Return {True, String.Join(" ", nameString)}
                End If
            Case DataInput.STRING_PASSWORD
                'if Regex.IsMatch(stringInput, "^(?=.*[0-9])(?=.*[@#$%^&+=]).{8,}$") Then
                Return {True, stringInput}
                'End If

            Case DataInput.STRING_PHONE
                If Regex.IsMatch(start_trim_o, "^(\+639|09)\d{2}[-\s]?\d{3}[-\s]?\d{4}$") Then
                    Return {True, start_trim_o}
                End If
            Case DataInput.STRING_USERNAME
                If Not Regex.IsMatch(stringInput, "[^\w]+") Then
                    Return {True, stringInput}
                End If
            Case DataInput.STRING_INTEGER
                If Regex.IsMatch(stringInput, "^\d+$") AndAlso Not stringInput = "0" Then
                    Return {True, stringInput}
                End If
            Case DataInput.STRING_PRICE
                If Regex.IsMatch(stringInput, "^(\d+)?\.?(\d+)$") Then
                    Return {True, stringInput}
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
End Enum