Public Class parralelogramA
    Dim bb, hh, sol As Double

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        b.Clear()
        h.Clear()
        ansP.Text = "..."
        areashape.Show()
        Me.Hide()

    End Sub

    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click
        If IsNumeric(b.Text) And IsNumeric(h.Text) Then
            bb = b.Text
            hh = h.Text
            sol = bb * hh
            ansP.Text = Math.Round(sol, 3)

        Else
            MsgBox("please insert a number")
            b.Clear()
            h.Clear()
            ansP.Text = "..."

        End If
    End Sub
End Class