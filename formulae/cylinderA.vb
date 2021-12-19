Public Class cylinderA
    Dim rr, hh, sol As Double

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click

        r.Clear()
        h.Clear()
        ansP.Text = "..."
        areashape.Show()
        Me.Hide()

    End Sub

    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click
        If IsNumeric(r.Text) And IsNumeric(h.Text) Then
            rr = r.Text
            hh = h.Text
            sol = ((22 / 7) * (rr * rr)) * (hh)
            ansP.Text = Math.Round(sol, 3)

        Else
            MsgBox("Please insert a number.")

            r.Clear()
            h.Clear()
            ansP.Text = "..."
        End If
    End Sub
End Class