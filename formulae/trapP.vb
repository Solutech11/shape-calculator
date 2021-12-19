Public Class trapP
    Dim a, b, c, d, finall As Double

    Private Sub trapP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        inpA.Clear()
        inpB.Clear()
        inpC.Clear()

        inpD.Clear()
        ansP.Text = "..."
        peri.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles inpD.TextChanged

    End Sub

    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click
        If IsNumeric(inpA.Text) And IsNumeric(inpB.Text) And IsNumeric(inpC.Text) And IsNumeric(inpD.Text) Then
            a = inpA.Text
            b = inpB.Text
            c = inpC.Text
            d = inpD.Text
            finall = a + b + c + d
            ansP.Text = Math.Round(finall, 3)
        Else
            MsgBox("please insert a number")


            inpA.Clear()
            inpB.Clear()
            inpC.Clear()

            inpD.Clear()
            ansP.Text = "..."
        End If

    End Sub
End Class