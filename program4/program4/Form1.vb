Public Class Form1
    Private Sub hitme_Click(sender As Object, e As EventArgs) Handles hitme.Click
        Dim gen As String
        If gmale.Checked = True Then
            gen = "Male"
            MessageBox.Show(" Your gender is : " & gen, "Gender")

        ElseIf gfemale.Checked = True Then
            gen = "Female"
            MessageBox.Show(" Your gender is : " & gen, "Gender")
        Else

        End If
    End Sub

    Private Sub fclose_Click(sender As Object, e As EventArgs) Handles fclose.Click
        Me.Close()
    End Sub

    Private Sub fnext_Click(sender As Object, e As EventArgs) Handles fnext.Click
        If gmale.Checked = False And gfemale.Checked = False Then
            mess.Text = "Select Gender First"
        Else
            Me.Close()
            'Form2.show() 
            'VS Code 2019 => Not Supported This Line
        End If
    End Sub
End Class
