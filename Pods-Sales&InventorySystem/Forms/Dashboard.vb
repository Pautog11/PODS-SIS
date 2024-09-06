Public Class Dashboard
    Implements IObservablePanel, IObserverPanel
    Private _observables As New List(Of IObserverPanel)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        RegisterObserver(Me)
        NotifyObserver()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub RegisterObserver(o As IObserverPanel) Implements IObservablePanel.RegisterObserver
        _observables.Add(o)
    End Sub

    Public Sub NotifyObserver() Implements IObservablePanel.NotifyObserver
        For Each o As IObserverPanel In _observables
            o.Update()
        Next
    End Sub

    Private Sub IObserverPanel_Update() Implements IObserverPanel.Update
        Label1.Text = BaseAccount.ScalarAccount
    End Sub
End Class