Public Class pentagonP
    Dim a, ttal As Integer

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        screens.Clear()
        ansP.Text = "..."
        peri.Show()
        Me.Hide()

    End Sub

    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click
        If IsNumeric(screens.Text) Then
            a = screens.Text
            ttal = 5 * a
            ansP.Text = ttal
        Else
            MsgBox("please insert a number")

            screens.Clear()
            ansP.Text = "..."
        End If

    End Sub
End Class