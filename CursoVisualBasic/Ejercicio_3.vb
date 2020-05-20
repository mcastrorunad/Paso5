Public Class Ejercicio_3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles MetroBot.Click
        DecimetroTextBox.Text = Val(MetroTextBox.Text) * 1000
        centimetroTextBox.Text = Val(MetroTextBox.Text) * 1000000
    End Sub

    Private Sub LitroBot_Click(sender As Object, e As EventArgs) Handles LitroBot.Click
        DecilitroTextBox.Text = Val(LitroTextBox.Text) * 10
        CentilitroTextBox.Text = Val(LitroTextBox.Text) * 100
    End Sub
End Class
