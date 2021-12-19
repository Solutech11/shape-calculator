Public Class circlep
    Dim value As Double
    Dim perimeter_circle As Double
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        value = 0
        perimeter_circle = 0
        screen.Clear()
        ansP.Text = "..."
        peri.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles screen.TextChanged

    End Sub


    Private Sub circlep_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub solution_Click(sender As Object, e As EventArgs) Handles solution.Click

    End Sub

    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click
        If IsNumeric(screen.Text) Then
            value = screen.Text
            perimeter_circle = 2 * (22 / 7) * value
            ansP.Text = Math.Round(perimeter_circle, 3)
        Else
            MsgBox("please insert a number")

            value = 0
            perimeter_circle = 0
            screen.Clear()
            ansP.Text = "..."
        End If

    End Sub
End Class