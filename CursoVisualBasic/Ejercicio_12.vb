Public Class Ejercicio_12
    Dim i As Integer
    Dim total As Integer
    Dim lista As String

    Private Sub Ejercicio_12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ArticuloComboBox.Items.Add("Televisor led 45'")
        ArticuloComboBox.Items.Add("Televisor led 58'")
        ArticuloComboBox.Items.Add("Televisor Led 68'")
        ArticuloComboBox.Items.Add("Nevera")
        ArticuloComboBox.Items.Add("Nevecon")
        ArticuloComboBox.Items.Add("Equipo de sonido")
        ArticuloComboBox.Items.Add("Consola de videjuego")
        ArticuloComboBox.Items.Add("Radio Grabadora")
        ArticuloComboBox.Items.Add("BlueRay")



    End Sub

    Private Sub ArticuloComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ArticuloComboBox.SelectedIndexChanged

        Select Case ArticuloComboBox.SelectedIndex
            Case 0
                ListBox1.Items.Add("Televisor led 45'")
                ListBox2.Items.Add("IVA 19%")
                ListBox3.Items.Add("1500000")
                ListBox4.Items.Add("$ " & 1500000 * 0.19 + 1500000)
            Case 1
                ListBox1.Items.Add("Televisor led 58'")
                ListBox2.Items.Add("IVA 19%")
                ListBox3.Items.Add("2000000")
                ListBox4.Items.Add("$ " & 2000000 * 0.19 + 2000000)
            Case 2
                ListBox1.Items.Add("Televisor Led 68'")
                ListBox2.Items.Add("IVA 19%")
                ListBox3.Items.Add("2500000")
                ListBox4.Items.Add("$ " & 2500000 * 0.19 + 2500000)
            Case 3
                ListBox1.Items.Add("Nevera")
                ListBox2.Items.Add("IVA 16%")
                ListBox3.Items.Add("2000000")
                ListBox4.Items.Add("$ " & 2000000 * 0.16 + 2000000)
            Case 4
                ListBox1.Items.Add("Nevecon")
                ListBox2.Items.Add("IVA 16%")
                ListBox3.Items.Add("3000000")
                ListBox4.Items.Add("$ " & 3000000 * 0.16 + 3000000)
            Case 5
                ListBox1.Items.Add("Equipo de sonido")
                ListBox2.Items.Add("IVA 16%")
                ListBox3.Items.Add("1250000")
                ListBox4.Items.Add("$ " & 1250000 * 0.16 + 1250000)
            Case 6
                ListBox1.Items.Add("Consola de videjuego")
                ListBox2.Items.Add("IVA 15%")
                ListBox3.Items.Add("1400000")
                ListBox4.Items.Add("$ " & 1400000 * 0.15 + 1400000)
            Case 7
                ListBox1.Items.Add("Radio Grabadora")
                ListBox2.Items.Add("IVA 15%")
                ListBox3.Items.Add("250000")
                ListBox4.Items.Add("$ " & 250000 * 0.15 + 250000)
            Case 8
                ListBox1.Items.Add("BlueRay")
                ListBox2.Items.Add("IVA 15%")
                ListBox3.Items.Add("600000")
                ListBox4.Items.Add("$ " & 600000 * 0.15 + 600000)
        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox4.Items.Count < 1 Then
            MsgBox("No hay valores que totalizar")
        Else
            For Each i In ListBox4.Items
                total = total + CInt(i)
            Next
            TotalLebel.Text = total
        End If
    End Sub

End Class