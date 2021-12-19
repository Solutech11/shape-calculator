Public Class cylinderp
    Dim r, h, solut As Double
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        inph.Clear()
        inpr.Clear()
        ansP.Text = "..."
        peri.Show()
        Me.Hide()

    End Sub

    Private Sub inpr_TextChanged(sender As Object, e As EventArgs) Handles inpr.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub perrimeter_Click(sender As Object, e As EventArgs) Handles perrimeter.Click
        If IsNumeric(inpr.Text) And IsNumeric(inph.Text) Then
            r = inpr.Text
            h = inph.Text
            solut = (2 * (22 / 7) * (r * r)) + (2 * (22 / 7) * r * h)
            ansP.Text = Math.Round(solut, 3)
        Else
            MsgBox("please insert a number")

            inph.Clear()
            inpr.Clear()
            ansP.Text = "..."
        End If

    End Sub
End Class