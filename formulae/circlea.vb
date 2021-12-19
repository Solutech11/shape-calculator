Public Class circlea
    Dim a, ttal As Double
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        ansP.Text = "..."
        screen.Clear()

        areashape.Show()
        Me.Hide()

    End Sub

    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click
        If IsNumeric(screen.Text) Then
            a = screen.Text
            ttal = (22 / 7) * (a * a)
            ansP.Text = Math.Round(ttal, 3)
        Else
            MsgBox("Please insert a number.")

            screen.Clear()
            ansP.Text = "..."

        End If
    End Sub
End Class