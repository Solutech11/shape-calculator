Public Class trarea
    Dim h, b, solu As Double

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click

        inpH.Clear()
        inpB.Clear()
        ansP.Text = "..."
        areashape.Show()
        Me.Hide()

    End Sub

    Private Sub inpB_TextChanged(sender As Object, e As EventArgs) Handles inpB.TextChanged

    End Sub

    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click
        If IsNumeric(inpB.Text) And IsNumeric(inpH.Text) Then
            h = inpH.Text
            b = inpB.Text
            solu = (b * h) / 2
            ansP.Text = Math.Round(solu, 3)
        Else
            MsgBox("Please insert a number.")

            inpH.Clear()
            inpB.Clear()
            ansP.Text = "..."
        End If

    End Sub
End Class