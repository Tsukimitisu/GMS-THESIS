Public Class Loading_Screen

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        Guna2Panel2.Width += 20


        If Guna2Panel2.Width >= 565 Then
            Timer1.Stop()
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Loading_Screen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Guna2Panel2.Width = 0
        Timer1.Interval = 100
        Timer1.Start()
    End Sub

End Class
