<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio_6
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroBot = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VelocidadTextBox = New System.Windows.Forms.TextBox()
        Me.AlturaTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MetroBot)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.VelocidadTextBox)
        Me.GroupBox1.Controls.Add(Me.AlturaTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 178)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conversión de Volumen"
        '
        'MetroBot
        '
        Me.MetroBot.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MetroBot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroBot.Location = New System.Drawing.Point(17, 77)
        Me.MetroBot.Name = "MetroBot"
        Me.MetroBot.Size = New System.Drawing.Size(75, 23)
        Me.MetroBot.TabIndex = 6
        Me.MetroBot.Text = "Calcular"
        Me.MetroBot.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(161, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Velocidad inicial"
        '
        'VelocidadTextBox
        '
        Me.VelocidadTextBox.Location = New System.Drawing.Point(17, 135)
        Me.VelocidadTextBox.Name = "VelocidadTextBox"
        Me.VelocidadTextBox.Size = New System.Drawing.Size(138, 20)
        Me.VelocidadTextBox.TabIndex = 2
        '
        'AlturaTextBox
        '
        Me.AlturaTextBox.Location = New System.Drawing.Point(17, 42)
        Me.AlturaTextBox.Name = "AlturaTextBox"
        Me.AlturaTextBox.Size = New System.Drawing.Size(79, 20)
        Me.AlturaTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Altura Máxima en Metros"
        '
        'Ejercicio_6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 202)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Ejercicio_6"
        Me.Text = "Tema 1 Operaciones Basicas - Ejercicio 6"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MetroBot As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents VelocidadTextBox As TextBox
    Friend WithEvents AlturaTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
