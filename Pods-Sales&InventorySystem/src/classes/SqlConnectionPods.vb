Imports System.Data.SqlClient

Public Class SqlConnectionPods
    Private Shared ReadOnly _sqlConnection As New SqlConnection(My.Settings.con)
    ''' <summary>
    ''' Connection string for all operation
    ''' </summary>
    ''' <returns>an open instance of the connection</returns>
    Public Shared Function GetInstance() As SqlConnection
        'My.Settings.con = ""
        'My.Settings.Save
        'MsgBox(My.Settings.con)
        'My.Settings.con = "Data Source=.;Initial Catalog=titeko;Persist Security Info=True;User ID=admin;Password=password;"
        'My.Settings.Save()
        'MsgBox(My.Settings.con)
        Try
            If _sqlConnection.State = ConnectionState.Closed Then
                _sqlConnection.Open()
            End If
            Return _sqlConnection
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PODS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End Try
    End Function
End Class
