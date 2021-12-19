Public Class squarep
    Dim full As Integer
    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click
        If IsNumeric(screen.Text) Then
            full = screen.Text
            ansP.Text = full * 4
        Else
            MsgBox("please insert a number")

            ansP.Text = "..."
            screen.Clear()
            full = 0
            'peri.Show()
            'Me.Hide()
        End If


    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click

        ansP.Text = "..."
        screen.Clear()
        full = 0
        peri.Show()
        Me.Hide()
    End Sub
End Class