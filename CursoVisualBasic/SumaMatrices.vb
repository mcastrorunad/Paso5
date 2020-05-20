Public Class SumaMatrices

    Public op As String

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        DataGridView1.Columns.Clear()
        DataGridView2.Columns.Clear()
        DataGridView3.Columns.Clear()

        For i = 0 To 2
            DataGridView1.Columns.Add(i, "")
            DataGridView2.Columns.Add(i, "")
            DataGridView1.Rows.Add()
            DataGridView2.Rows.Add()
        Next

        op = "3x3"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then

            For i = 0 To 2
                DataGridView3.Columns.Add(i, "")
                DataGridView3.Rows.Add()
            Next
            For i = 0 To 2
                For j = 0 To 2
                    DataGridView3.Item(i, j).Value = Val(DataGridView1.Item(i, j).Value) + Val(DataGridView2.Item(i, j).Value)
                Next
            Next

        ElseIf RadioButton2.Checked Then
            For i = 0 To 1
                DataGridView3.Columns.Add(i, "")
                DataGridView3.Rows.Add()
            Next
            For i = 0 To 1
                For j = 0 To 1
                    DataGridView3.Item(i, j).Value = Val(DataGridView1.Item(i, j).Value) + Val(DataGridView2.Item(i, j).Value)
                Next
            Next
        End If



    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        DataGridView1.Columns.Clear()
        DataGridView2.Columns.Clear()
        DataGridView3.Columns.Clear()

        For i = 0 To 1
            DataGridView1.Columns.Add(i, "")
            DataGridView2.Columns.Add(i, "")
            DataGridView1.Rows.Add()
            DataGridView2.Rows.Add()
        Next
        op = "2x2"
    End Sub
End Class
