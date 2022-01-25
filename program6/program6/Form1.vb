Public Class Form1
    Private Sub l2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles l2.SelectedIndexChanged
        l1.ClearSelected()
        For i As Integer = 0 To l1.Items.Count - 1
            If l1.Items(i).ToString().StartsWith(l2.SelectedItem) = True Then
                l1.SetSelected(i, True)
            End If
        Next

        mess.text = "Total No Of Selected Items " & l1.SelectedItems.Count.ToString

    End Sub
End Class
