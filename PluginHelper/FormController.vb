Public Class FormController
    Public MyTimer As New Windows.Forms.Timer

    Public Sub LoadEverything()
        MyTimer.Interval = 500
        MyTimer.Enabled = True
        AddHandler MyTimer.Tick, AddressOf MyTimer_Tick
    End Sub

    Private Sub MyTimer_Tick(sender As Object, e As EventArgs)
        If MainClass.Form1.IsProgramClose = True Then
            MainClass.Form1.IsProgramClose = False
            MainClass.Controller.OpenFramework_SetAppNameValue("")
        End If
    End Sub
End Class