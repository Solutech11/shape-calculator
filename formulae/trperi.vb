Public Class trperi
    Dim a, b, c, finalAns As Integer

    Private Sub trperi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        a = 0
        b = 0
        c = 0
        inpA.Clear()
        inpB.Clear()
        inpC.Clear()
        ansP.Text = "..."
        peri.Show()
        Me.Hide()

    End Sub

    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click
        If IsNumeric(inpA.Text) And IsNumeric(inpB.Text) And IsNumeric(inpC.Text) Then
            a = inpA.Text
            b = inpB.Text
            c = inpC.Text
            finalAns = a + b + c
            ansP.Text = finalAns
        Else
            MsgBox("please insert a number")

            inpA.Clear()
            inpB.Clear()
            inpC.Clear()
            ansP.Text = "..."
        End If


    End Sub
End Class