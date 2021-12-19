Public Class TrapA
    Dim aa, bb, hh, sol As Double

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        a.Clear()
        b.Clear()
        h.Clear()
        ansP.Text = "..."
        areashape.Show()
        Me.Hide()

    End Sub

    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click
        If IsNumeric(a.Text) And IsNumeric(b.Text) And IsNumeric(h.Text) Then
            aa = a.Text
            bb = b.Text
            hh = h.Text
            sol = ((aa + bb) / 2) * hh
            ansP.Text = Math.Round(sol, 3)
        Else
            MsgBox("Please insert a number.")
            a.Clear()
            b.Clear()
            h.Clear()
            ansP.Text = "..."

        End If
    End Sub
End Class