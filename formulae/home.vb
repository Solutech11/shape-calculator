Public Class home
    Private Sub perimeter_Click(sender As Object, e As EventArgs) Handles perimeter.Click
        peri.Show()

        Me.Hide()
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Area_Click(sender As Object, e As EventArgs) Handles Area.Click
        areashape.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub
End Class
