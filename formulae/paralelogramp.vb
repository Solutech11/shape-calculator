Public Class paralelogramp
    Dim a, b, finall As Double

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        inpA.Clear()
        inpS.Clear()
        ansP.Text = "..."
        peri.Show()
        Me.Hide()
    End Sub

    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click

        If IsNumeric(inpA.Text) And IsNumeric(inpS.Text) Then
            a = inpA.Text
            b = inpS.Text
            finall = 2 * (a + b)
            ansP.Text = Math.Round(finall, 3)
        Else
            MsgBox("Please insert a number")

            inpA.Clear()
            inpS.Clear()
            ansP.Text = "..."

        End If
    End Sub
End Class