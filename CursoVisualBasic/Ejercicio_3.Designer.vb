<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio_3
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
        Me.LitroBot = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CentilitroTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DecilitroTextBox = New System.Windows.Forms.TextBox()
        Me.LitroTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MetroBot = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.centimetroTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DecimetroTextBox = New System.Windows.Forms.TextBox()
        Me.MetroTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LitroBot)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CentilitroTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DecilitroTextBox)
        Me.GroupBox1.Controls.Add(Me.LitroTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.MetroBot)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.centimetroTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DecimetroTextBox)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 355)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conversión de Volumen"
        '
        'LitroBot
        '
        Me.LitroBot.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LitroBot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LitroBot.Location = New System.Drawing.Point(17, 247)
        Me.LitroBot.Name = "LitroBot"
        Me.LitroBot.Size = New System.Drawing.Size(75, 23)
        Me.LitroBot.TabIndex = 13
        Me.LitroBot.Text = "Convertir"
        Me.LitroBot.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(161, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Centilitro"
        '
        'CentilitroTextBox
        '
        Me.CentilitroTextBox.Location = New System.Drawing.Point(17, 311)
        Me.CentilitroTextBox.Name = "CentilitroTextBox"
        Me.CentilitroTextBox.Size = New System.Drawing.Size(138, 20)
        Me.CentilitroTextBox.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(161, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Decilitro"
        '
        'DecilitroTextBox
        '
        Me.DecilitroTextBox.Location = New System.Drawing.Point(17, 285)
        Me.DecilitroTextBox.Name = "DecilitroTextBox"
        Me.DecilitroTextBox.Size = New System.Drawing.Size(138, 20)
        Me.DecilitroTextBox.TabIndex = 9
        '
        'LitroTextBox
        '
        Me.LitroTextBox.Location = New System.Drawing.Point(17, 212)
        Me.LitroTextBox.Name = "LitroTextBox"
        Me.LitroTextBox.Size = New System.Drawing.Size(79, 20)
        Me.LitroTextBox.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(102, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Litro(s) equivale a:"
        '
        'MetroBot
        '
        Me.MetroBot.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MetroBot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroBot.Location = New System.Drawing.Point(17, 77)
        Me.MetroBot.Name = "MetroBot"
        Me.MetroBot.Size = New System.Drawing.Size(75, 23)
        Me.MetroBot.TabIndex = 6
        Me.MetroBot.Text = "Convertir"
        Me.MetroBot.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Centimetro cubico"
        '
        'centimetroTextBox
        '
        Me.centimetroTextBox.Location = New System.Drawing.Point(17, 141)
        Me.centimetroTextBox.Name = "centimetroTextBox"
        Me.centimetroTextBox.Size = New System.Drawing.Size(138, 20)
        Me.centimetroTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(161, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Decimetro cubico"
        '
        'DecimetroTextBox
        '
        Me.DecimetroTextBox.Location = New System.Drawing.Point(17, 115)
        Me.DecimetroTextBox.Name = "DecimetroTextBox"
        Me.DecimetroTextBox.Size = New System.Drawing.Size(138, 20)
        Me.DecimetroTextBox.TabIndex = 2
        '
        'MetroTextBox
        '
        Me.MetroTextBox.Location = New System.Drawing.Point(17, 42)
        Me.MetroTextBox.Name = "MetroTextBox"
        Me.MetroTextBox.Size = New System.Drawing.Size(79, 20)
        Me.MetroTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Metro(s) cubico(s) equivale a:"
        '
        'Ejercicio_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 379)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Ejercicio_3"
        Me.Text = "Tema 1 Operaciones Basicas - Ejercicio 3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MetroBot As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents centimetroTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DecimetroTextBox As TextBox
    Friend WithEvents MetroTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LitroBot As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CentilitroTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DecilitroTextBox As TextBox
    Friend WithEvents LitroTextBox As TextBox
    Friend WithEvents Label6 As Label
End Class
