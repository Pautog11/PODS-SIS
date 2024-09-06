Public Class Dashboard
    Implements IObservablePanel, IObserverPanel
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub RegisterObserver(o As IObserverPanel) Implements IObservablePanel.RegisterObserver
        Throw New NotImplementedException()
    End Sub

    Public Sub NotifyObserver() Implements IObservablePanel.NotifyObserver
        Throw New NotImplementedException()
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        Throw New NotImplementedException()
    End Sub
End Class