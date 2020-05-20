Public Class CaidaLibre
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, g, r, r2 As Double

        n = Val(TextBox1.Text)
        g = 9.81

        r = g * (n) ^ 2
        r2 = r / 2

        TextBox2.Text = r2


    End Sub
End Class
