Imports System.Text

Public Class FrmRegistro

    Dim ActualizacionPendiente As Boolean = False

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EstudiantesDataSet.Estudiantes' table. You can move, or remove it, as needed.
        Me.EstudiantesTableAdapter.Fill(Me.EstudiantesDataSet.Estudiantes)

    End Sub

    Private Sub DataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating

        Dim cancel As Boolean
        Dim validarVacio As Boolean

        Dim valor As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue.ToString

        Dim mensaje As StringBuilder = New StringBuilder

        Select Case e.ColumnIndex
            Case 1
                validarVacio = True
                If TextoEsInvalido(valor, "Nombre", 100, mensaje) Then

                    cancel = True
                End If

            Case 2
                validarVacio = True
                If TextoEsInvalido(valor, "Apellidos", 100, mensaje) Then
                    cancel = True
                End If
            Case 3
                validarVacio = True
            Case 4
                validarVacio = True
                If NumeroEsInvalido(valor, "Número de documento", 10, mensaje) Then
                    cancel = True
                End If

            Case 5
                validarVacio = True
                If FechaEsInvalida(valor, "Fecha de Nacimiento", mensaje) Then
                    cancel = True
                End If

            Case 6
                validarVacio = True
                If NumeroEsInvalido(valor, "Teléfono", 8, mensaje) = True Then
                    cancel = True
                End If

            Case 7
                validarVacio = True
                If NumeroEsInvalido(valor, "Celular", 10, mensaje) = True Then
                    cancel = True
                End If

            Case 8
                validarVacio = True
                If CorreoEsInvalido(valor, "Correo", 256, mensaje) Then
                    cancel = True
                End If
            Case 9
                validarVacio = True
                If TextoEsInvalido(valor, "Programa", 100, mensaje) Then
                    cancel = True
                End If
            Case 10
                validarVacio = True
                If UsuarioEsInvalido(valor, "Usuario", 50, mensaje) Then
                    cancel = True
                End If
            Case 11
                validarVacio = True
        End Select

        e.Cancel = cancel

        If validarVacio And (String.IsNullOrEmpty(valor)) Then
            e.Cancel = True
            mensaje.AppendLine("Este campo no puede estar vacio. Use escape (ESC) para cancelar y deshacer los cambios en esta fila")
        End If

        If e.Cancel And mensaje.Length > 0 Then

            MessageBox.Show(mensaje.ToString)
        End If


    End Sub

    Private Function TextoEsInvalido(cadena As String, nombre As String, longitud As Integer, ByRef mensaje As StringBuilder) As Boolean

        Dim invalid As Boolean

        Dim regex As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("^[a-zA-Z]*$")

        For Each parte In cadena.Split(" ")
            If (Not regex.IsMatch(parte)) Then
                invalid = True
                mensaje.AppendLine("El campo " & nombre & " solo acepta letras.")
                Exit For
            End If
        Next


        If Not invalid Then
            invalid = ValidarLongitud(cadena, nombre, longitud, mensaje)
        End If

        Return invalid

    End Function

    Private Function UsuarioEsInvalido(cadena As String, nombre As String, longitud As Integer, ByRef mensaje As StringBuilder) As Boolean

        Dim invalid As Boolean

        Dim regex As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("^(?=.{1,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$")

        If (Not regex.IsMatch(cadena)) Then
            invalid = True
            mensaje.AppendLine("El campo " & nombre & " solo acepta numeros y letras.")
        End If

        If Not invalid Then
            invalid = ValidarLongitud(cadena, nombre, longitud, mensaje)
        End If

        Return invalid

    End Function

    Private Function NumeroEsInvalido(ByVal cadena As String, nombre As String, longitud As Integer, ByRef mensaje As StringBuilder) As Boolean

        Dim invalid As Boolean

        Dim regex As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("^(\(?\+?[0-9]*\)?)?[0-9_\- \(\)]*$")

        If (Not regex.IsMatch(cadena)) Then
            invalid = True
            mensaje.AppendLine("El campo " & nombre & " solo acepta números.")
        End If

        If Not invalid Then
            invalid = ValidarLongitud(cadena, nombre, longitud, mensaje)
        End If

        Return invalid

    End Function

    Private Function ValidarLongitud(ByVal cadena As String, nombre As String, longitud As Integer, ByRef mensaje As StringBuilder) As Boolean

        Dim invalid As Boolean

        If cadena.Length > longitud Then
            invalid = True
            mensaje.AppendLine("El campo " & nombre & "  no puede contener mas de " & longitud & " caracteres.")
        End If

        Return invalid

    End Function

    Private Function CorreoEsInvalido(ByVal cadena As String, nombre As String, longitud As Integer, ByRef mensaje As StringBuilder) As Boolean

        Dim invalid As Boolean

        Dim regex As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("^[^@]+@[^@]+\.[a-zA-Z]{2,}$")

        If (Not regex.IsMatch(cadena)) Then
            invalid = True
            mensaje.AppendLine("El campo " & nombre & " solo acepta direcciones de correo validas.")
        End If

        If Not invalid Then
            invalid = ValidarLongitud(cadena, nombre, longitud, mensaje)
        End If

        Return invalid

    End Function

    Private Function FechaEsInvalida(cadena As String, nombre As String, ByRef mensaje As StringBuilder) As Boolean

        Dim invalid As Boolean
        Dim fecha As DateTime

        If (Not DateTime.TryParse(cadena, fecha)) Then
            invalid = True
            mensaje.AppendLine("El campo " & nombre & " solo acepta fechas.")
        End If

        Return invalid

    End Function

    Private Sub EstudiantesBindingSource_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles EstudiantesBindingSource.ListChanged
        If Me.EstudiantesDataSet.HasChanges Then
            Me.ActualizacionPendiente = True
        End If
    End Sub

    Private Sub DataGridView1_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowValidated
        If ActualizacionPendiente Then
            Me.EstudiantesTableAdapter.Update(Me.EstudiantesDataSet.Estudiantes)

            'For Each row As DataRow In Me.EstudiantesDataSet.Estudiantes.Rows
            '    If row.Item(0) = -1 Then
            '        Dim retorno As Integer = Me.EstudiantesTableAdapter.Insert(
            '            row.Item("Nombres"),
            '            row.Item("Apellidos"),
            '            row.Item("TipoDocumento"),
            '            row.Item("NumeroDocumento"),
            '            row.Item("Telefono"),
            '            row.Item("Celular"),
            '            row.Item("Correo"),
            '            row.Item("Programa"),
            '            row.Item("Usuario"),
            '            row.Item("Clave"),
            '            row.Item("FechaNacimiento")
            '       )
            '    End If
            'Next
            Me.ActualizacionPendiente = False
        End If
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded

    End Sub

    Private Sub DataGridView1_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserAddedRow

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.EstudiantesTableAdapter.Update(Me.EstudiantesDataSet.Estudiantes)
    End Sub

    Private Sub DataGridView1_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow

        If EstudiantesDataSet.Estudiantes.Rows.Count = 1 Then
            MessageBox.Show("No puede eliminar todos los usuarios del sistema.")
            e.Cancel = True
            Exit Sub
        End If

        If MessageBox.Show("Esta seguro de eliminar este registro?", "Confirmacion", MessageBoxButtons.OKCancel) <> DialogResult.OK Then
            e.Cancel = True
        End If
    End Sub

    Private Sub DataGridView1_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.RowValidating


    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub
End Class
