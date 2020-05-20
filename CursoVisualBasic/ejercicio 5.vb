Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim i As Integer
        Dim arreglo(5) As Integer
        Dim nmayor As Integer


        For i = 0 To 4
            arreglo(i) = InputBox("Digite Numero ")
            If arreglo(i) > nmayor Then
                nmayor = arreglo(i)
            End If
        Next
        For i = 0 To 4
            MsgBox("Arreglo (" + i.ToString + ") = " + arreglo(i).ToString)
        Next
        MsgBox("el numero mayor es " + nmayor.ToString)



    End Sub


End Class
