Imports System.Configuration
Imports System.Data.SqlClient

Public Class FrmInicioSesion
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("CursoVisualBasic.My.MySettings.EstudiantesConnectionString").ConnectionString)

        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Estudiantes WHERE upper(usuario) = upper('" & TextBox1.Text & "') AND [clave] = '" & TextBox2.Text & "' ", con)

        Dim user As String = ""

        Dim pass As String = ""


        con.Open()

        Dim sdr As SqlDataReader = cmd.ExecuteReader()

        If (sdr.Read() = True) Then

            Me.Hide()

            Dim frm = New FrmTemas

            frm.ShowDialog()

            Me.Close()

        Else

            MessageBox.Show("Usuario o clave inválidos.")

        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
End Class