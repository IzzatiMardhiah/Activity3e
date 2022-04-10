Public Class Form1
    Private Sub cmdBalls_Click(sender As Object, e As EventArgs) Handles cmdBalls.Click
        Dim Intball, n As Integer
        Dim randl As New System.Random
        lblBalls.Text = ""
        For n = 0 To 5
            Intball = randl.Next(49) + 1
            lblBalls.Text = lblBalls.Text & " " & Intball
        Next n
    End Sub
End Class
