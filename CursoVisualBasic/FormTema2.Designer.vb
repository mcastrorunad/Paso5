<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTema2
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
        Me.Regresar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Regresar
        '
        Me.Regresar.Location = New System.Drawing.Point(2, 2)
        Me.Regresar.Margin = New System.Windows.Forms.Padding(2)
        Me.Regresar.Name = "Regresar"
        Me.Regresar.Size = New System.Drawing.Size(53, 19)
        Me.Regresar.TabIndex = 12
        Me.Regresar.Text = "Atras"
        Me.Regresar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.label1.Location = New System.Drawing.Point(8, 48)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(161, 24)
        Me.label1.TabIndex = 45
        Me.label1.Text = "En costrucción......"
        '
        'FormTema2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 145)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Regresar)
        Me.Name = "FormTema2"
        Me.Text = "Estamos Trabajando en ello....."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Regresar As Button
    Friend WithEvents Button2 As Button
    Private WithEvents label1 As Label
End Class
