Public Class Form1
    Private Sub cancle_Click(sender As Object, e As EventArgs) Handles cancle.Click
        sname.Clear()
        srollno.Clear()
        sub1.Clear()
        sub2.Clear()
        sub3.Clear()
        sub4.Clear()
        sub5.Clear()
        sub6.Clear()
        sub7.Clear()
        Me.Close()
    End Sub

    Private Sub showresult_Click(sender As Object, e As EventArgs) Handles showresult.Click
        rollno.Text &= srollno.Text
        names.Text &= sname.Text

        Dim s1, s2, s3, s4, s5, s6, s7, rtotal, per As Double

        s1 = sub1.Text
        s2 = sub2.Text
        s3 = sub3.Text
        s4 = sub4.Text
        s5 = sub5.Text
        s6 = sub6.Text
        s7 = sub7.Text

        rtotal = s1 + s2 + s3 + s4 + s5 + s6 + s7
        per = rtotal / 7

        tmark.Text = rtotal
        perce.Text = per

        If per > 70 Then
            grd.Text = "First Class"
        ElseIf per > 60 Then
            grd.Text = "Second Class"
        ElseIf per > 50 Then
            grd.Text = "Third Class"
        ElseIf per > 40 Then
            grd.Text = "Fourth Class"
        ElseIf per < 40 Then
            grd.Text = "Fail"
        End If

    End Sub
End Class