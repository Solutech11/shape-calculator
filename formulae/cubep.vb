Public Class cubep
    Dim a, b, c, full As Integer

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        a = 0
        b = 0
        c = 0
        full = 0
        inpA.Clear()
        inpb.Clear()
        inpc.Clear()
        ansP.Text = "..."
        peri.Show()
        Me.Hide()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ansP_Click(sender As Object, e As EventArgs) Handles ansP.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub inpA_TextChanged(sender As Object, e As EventArgs) Handles inpA.TextChanged

    End Sub

    Private Sub inpb_TextChanged(sender As Object, e As EventArgs) Handles inpb.TextChanged

    End Sub

    Private Sub inpc_TextChanged(sender As Object, e As EventArgs) Handles inpc.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click
        If IsNumeric(inpA.Text) And IsNumeric(inpb.Text) And IsNumeric(inpc.Text) Then
            a = inpA.Text
            b = inpb.Text
            c = inpc.Text
            full = 4 * (a + b + c)
            ansP.Text = full
        Else
            MsgBox("please insert a number")

            inpA.Clear()
            inpb.Clear()
            inpc.Clear()
            ansP.Text = "..."
        End If
    End Sub
End Class