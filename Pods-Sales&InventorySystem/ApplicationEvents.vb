Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub Application_Startup(sender As Object, e As EventArgs) Handles Me.Startup
            ''My.Settings.con = ""
            ''My.Settings.Save()
            ''MsgBox(My.Settings.con)
            If My.Settings.con = "" Then
                Dim pota As New Server
                pota.ShowDialog()
            End If

            AddHandler AppDomain.CurrentDomain.ProcessExit, AddressOf OnProcessExit
            ' AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf OnUnhandledException
        End Sub

        Private Sub OnProcessExit(sender As Object, e As EventArgs)

            MsgBox("on process")
        End Sub

        'Private Sub OnUnhandledException(sender As Object, e As UnhandledExceptionEventArgs)
        '    ' Handle the unhandled exception before the app crashes
        '    HandleApplicationStop()
        'End Sub

        '' Private subroutine to handle application stop
        'Private Sub HandleApplicationStop()
        '    ' Logic to execute on forced shutdown or crash
        '    MsgBox("The application has encountered an error and is shutting down.")
        'End Sub
    End Class
End Namespace
