Public Class Form1
    Private Sub convertinto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles convertinto.SelectedIndexChanged
        If convertinto.SelectedIndex = 0 Then
            ans.Text = enterrs.Text / 65
        ElseIf convertinto.SelectedIndex = 1 Then
            ans.Text = enterrs.Text / 0.6
        ElseIf convertinto.SelectedIndex = 2 Then
            ans.Text = enterrs.Text / 79
        End If
    End Sub
End Class
