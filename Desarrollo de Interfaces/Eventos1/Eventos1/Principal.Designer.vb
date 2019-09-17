<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnFormulario1 = New System.Windows.Forms.Button()
        Me.btnFormulario2 = New System.Windows.Forms.Button()
        Me.btnFormulario3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFormulario1
        '
        Me.btnFormulario1.Location = New System.Drawing.Point(12, 12)
        Me.btnFormulario1.Name = "btnFormulario1"
        Me.btnFormulario1.Size = New System.Drawing.Size(75, 23)
        Me.btnFormulario1.TabIndex = 1
        Me.btnFormulario1.Text = "Formulario 1"
        Me.btnFormulario1.UseVisualStyleBackColor = True
        '
        'btnFormulario2
        '
        Me.btnFormulario2.Location = New System.Drawing.Point(93, 12)
        Me.btnFormulario2.Name = "btnFormulario2"
        Me.btnFormulario2.Size = New System.Drawing.Size(75, 23)
        Me.btnFormulario2.TabIndex = 3
        Me.btnFormulario2.Text = "Formulario 2"
        Me.btnFormulario2.UseVisualStyleBackColor = True
        '
        'btnFormulario3
        '
        Me.btnFormulario3.Location = New System.Drawing.Point(174, 12)
        Me.btnFormulario3.Name = "btnFormulario3"
        Me.btnFormulario3.Size = New System.Drawing.Size(75, 23)
        Me.btnFormulario3.TabIndex = 5
        Me.btnFormulario3.Text = "Formulario 3"
        Me.btnFormulario3.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnFormulario3)
        Me.Controls.Add(Me.btnFormulario2)
        Me.Controls.Add(Me.btnFormulario1)
        Me.IsMdiContainer = True
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFormulario1 As Button
    Friend WithEvents btnFormulario2 As Button
    Friend WithEvents btnFormulario3 As Button
End Class
