Public Class conep
    Dim r, s, sol As Double

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        ansP.Text = "..."
        inpR.Clear()
        inpS.Clear()
        peri.Show()
        Me.Hide()
    End Sub

    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click
        If IsNumeric(inpR.Text) And IsNumeric(inpS.Text) Then
            r = inpR.Text
            s = inpS.Text
            sol = ((22 / 7) * r * s) + (2 * (22 / 7) * (r * r))
            ansP.Text = Math.Round(sol, 3)
        Else
            MsgBox("please insert a number")

            ansP.Text = "..."
            inpR.Clear()
            inpS.Clear()
        End If
    End Sub
End Class