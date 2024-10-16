﻿Module Helpers
    Public Function GenInvoiceNumber(type As InvoiceType) As String
        Randomize()
        Dim unixTimeString As String = CStr(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds)
        Dim timeString As String = unixTimeString.Substring(5, unixTimeString.Count - 6)
        Dim dateString As String = String.Join("", DateTime.Now.ToShortDateString.Split("/"))
        Select Case type
            Case InvoiceType.Transaction
                Return String.Format("PODST-{0}-{1}", dateString, timeString)
            Case InvoiceType.Recieved
                Return String.Format("PODSR-{0}-{1}", dateString, timeString)
        End Select
        Return Nothing
    End Function
    Enum InvoiceType
        Transaction
        Recieved
        Refunded
    End Enum
End Module
