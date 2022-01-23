Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        l1.Items.Add(additem.Text)
        additem.Clear()
        additem.Focus()
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        l2.Items.Add(l1.SelectedItem.ToString)
        l1.Items.Remove(l1.SelectedItem.ToString)
    End Sub

    Private Sub bb1_Click(sender As Object, e As EventArgs) Handles bb1.Click
        l1.Items.Add(l2.SelectedItem.ToString)
        l2.Items.Remove(l2.SelectedItem.ToString)
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        For i As Integer = 0 To l1.SelectedItems.Count - 1
            l2.Items.Add(l1.SelectedItems(i))
        Next

        For i As Integer = 0 To l1.SelectedItems.Count - 1
            l1.Items.Remove(l1.SelectedIndex)
        Next
    End Sub

    Private Sub bb2_Click(sender As Object, e As EventArgs) Handles bb2.Click
        For i As Integer = 0 To l2.SelectedItems.Count - 1
            l1.Items.Add(l2.SelectedItems(i))
        Next

        For i As Integer = 0 To l2.SelectedItems.Count - 1
            l2.Items.Remove(l2.SelectedIndex)
        Next
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        For i As Integer = 0 To l1.Items.Count - 1
            l2.Items.Add(l1.Items(i))
        Next

        l1.Items.Clear()
    End Sub

    Private Sub bb3_Click(sender As Object, e As EventArgs) Handles bb3.Click
        For i As Integer = 0 To l2.Items.Count - 1
            l1.Items.Add(l2.Items(i))
        Next

        l2.Items.Clear()
    End Sub
End Class
