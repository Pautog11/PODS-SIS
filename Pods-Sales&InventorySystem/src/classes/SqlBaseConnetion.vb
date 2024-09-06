Imports System.Data.SqlClient

Public Class SqlBaseConnetion
    ''' <summary>
    ''' A base class for the commands to inherit.
    ''' </summary>
    Public Class SqlBaseConnection
        Protected _sqlCommand As SqlCommand
        Protected _sqlConnection As SqlConnection = SqlConnectionPods.GetInstance
        Protected _sqlDataSet As DataSet
        Protected _sqlAdapter As SqlDataAdapter
    End Class
End Class
