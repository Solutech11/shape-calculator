Public Class cubea
    Dim ss, sol As Double

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        ansP.Text = "..."
        inps.Clear()
        areashape.Show()
        Me.Hide()

    End Sub

    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click
        If IsNumeric(inps.Text) Then
            ss = inps.Text
            sol = ss * ss * ss
            ansP.Text = Math.Round(sol, 3)
        Else
            MsgBox("Please insert a number.")
            ansP.Text = "..."
            inps.Clear()

        End If
    End Sub
End Class