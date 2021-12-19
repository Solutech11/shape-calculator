Public Class pentagonA
    Dim aa, sol1, port, sol2, final As Double

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        a.Clear()
        ansP.Text = "..."
        areashape.Show()
        Me.Hide()

    End Sub

    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click
        If IsNumeric(a.Text) Then
            aa = a.Text()
            sol1 = Math.Sqrt(5)
            port = 5 * (5 + 2 * sol1)
            sol2 = Math.Sqrt(port)
            final = (1 / 4) * sol2 * (aa * aa)
            ansP.Text = Math.Round(final, 3)
        Else
            MsgBox("Please insert a number.")
            a.Clear()
            ansP.Text = "..."
        End If
    End Sub
End Class