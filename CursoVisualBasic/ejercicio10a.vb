Public Class ejercicio10a
    Dim contador, temp As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contador = contador + 1

        If TextBox1.Text = "admin" And TextBox2.Text = "123" Then

            ejercicio10.Show()

        ElseIf contador > 3 Then

            TextBox1.Enabled = False
            TextBox2.Enabled = False
            MsgBox("ha superado el numero de intentos")

        Else
            MsgBox("el nombre o contraseña ingresados son incorrectos Intento " + contador.ToString)

        End If


    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label3.Text += -1

        If Label3.Text = 0 Then

            TextBox1.Enabled = False
            TextBox2.Enabled = False
            MsgBox("El tiempo para colocar la contraseña ha expirado")
            Me.Close()

        End If

    End Sub
End Class
