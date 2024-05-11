Imports System.Runtime.CompilerServices

Public Class splashScreen
    Private Sub splashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 5
        Label1.Text = ProgressBar1.Value & "%"

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Form1.Show()
            Me.Hide()

        End If
    End Sub

End Class