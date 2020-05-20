Public Class FrmTemas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not lbxTemas.SelectedItem Is Nothing Then
            Me.Hide()

            Select Case lbxTemas.SelectedIndex
                Case 0
                    FrmTema1.ShowDialog()
                Case 1
                    Form2.ShowDialog()
                Case 2
                    Tema_3.ShowDialog()
                Case 3
                    FormCursos.ShowDialog()
            End Select

            Me.Show()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        Dim frm = New FrmRegistro

        Me.Hide()

        FrmRegistro.ShowDialog()

        Me.Show()
    End Sub
End Class