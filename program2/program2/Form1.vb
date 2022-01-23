Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d As Double

        a = empsalary.Text

        b = a * 0.1
        c = a * 0.15

        d = a + b + c + 1000 - 2000

        netsalary.Text = d

    End Sub
End Class
