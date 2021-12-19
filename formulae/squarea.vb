Public Class squarea
    Dim aa, bb, sol As Double

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        ansP.Text = "..."
        'h.Clear()
        b.Clear()
        areashape.Show()
        Me.Hide()

    End Sub

    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click
        If IsNumeric(b.Text) Then

            bb = b.Text
            sol = bb * bb
            ansP.Text = Math.Round(sol, 3)
        Else
            MsgBox("please insert a number")

            ansP.Text = "..."
            'h.Clear()
            b.Clear()


        End If
    End Sub
End Class