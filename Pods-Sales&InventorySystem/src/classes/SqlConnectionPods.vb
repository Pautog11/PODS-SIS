Imports System.Data.SqlClient

Public Class SqlConnectionPods
    Private Shared ReadOnly _sqlConnection As New SqlConnection(My.Settings.con)
    'Private Shared ReadOnly _sqlConnection As New SqlConnection(My.Settings.con)
    ''' <summary>
    ''' Connection string for all operation
    ''' </summary>
    ''' <returns>an open instance of the connection</returns>
    Public Shared Function GetInstance() As SqlConnection
        If _sqlConnection.State = System.Data.ConnectionState.Closed Then
            _sqlConnection.Open()
        End If
        Return _sqlConnection
    End Function
End Class
