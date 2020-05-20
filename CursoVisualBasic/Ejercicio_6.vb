Public Class Ejercicio_6
    Private Sub MetroBot_Click(sender As Object, e As EventArgs) Handles MetroBot.Click
        Dim max As Decimal
        max = (AlturaTextBox.Text) * 19.614
        VelocidadTextBox.Text = Val(max) ^ (1 / 2) & " m/s"
    End Sub
End Class