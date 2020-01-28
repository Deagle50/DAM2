<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioProgramar
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
        Me.lblCodigoCine = New System.Windows.Forms.Label()
        Me.txtCodigoCine = New System.Windows.Forms.TextBox()
        Me.lblCodigoPelicula = New System.Windows.Forms.Label()
        Me.txtCodigoPelicula = New System.Windows.Forms.TextBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.lblMinutos = New System.Windows.Forms.Label()
        Me.txtMinutos = New System.Windows.Forms.TextBox()
        Me.btnProgramar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCodigoCine
        '
        Me.lblCodigoCine.AutoSize = True
        Me.lblCodigoCine.Location = New System.Drawing.Point(32, 44)
        Me.lblCodigoCine.Name = "lblCodigoCine"
        Me.lblCodigoCine.Size = New System.Drawing.Size(64, 13)
        Me.lblCodigoCine.TabIndex = 0
        Me.lblCodigoCine.Text = "Código Cine"
        '
        'txtCodigoCine
        '
        Me.txtCodigoCine.Location = New System.Drawing.Point(126, 41)
        Me.txtCodigoCine.Name = "txtCodigoCine"
        Me.txtCodigoCine.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoCine.TabIndex = 1
        '
        'lblCodigoPelicula
        '
        Me.lblCodigoPelicula.AutoSize = True
        Me.lblCodigoPelicula.Location = New System.Drawing.Point(32, 75)
        Me.lblCodigoPelicula.Name = "lblCodigoPelicula"
        Me.lblCodigoPelicula.Size = New System.Drawing.Size(82, 13)
        Me.lblCodigoPelicula.TabIndex = 2
        Me.lblCodigoPelicula.Text = "Código Película"
        '
        'txtCodigoPelicula
        '
        Me.txtCodigoPelicula.Location = New System.Drawing.Point(126, 72)
        Me.txtCodigoPelicula.Name = "txtCodigoPelicula"
        Me.txtCodigoPelicula.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoPelicula.TabIndex = 3
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(32, 105)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(30, 13)
        Me.lblHora.TabIndex = 4
        Me.lblHora.Text = "Hora"
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(126, 102)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(100, 20)
        Me.txtHora.TabIndex = 5
        '
        'lblMinutos
        '
        Me.lblMinutos.AutoSize = True
        Me.lblMinutos.Location = New System.Drawing.Point(32, 134)
        Me.lblMinutos.Name = "lblMinutos"
        Me.lblMinutos.Size = New System.Drawing.Size(44, 13)
        Me.lblMinutos.TabIndex = 6
        Me.lblMinutos.Text = "Minutos"
        '
        'txtMinutos
        '
        Me.txtMinutos.Location = New System.Drawing.Point(126, 131)
        Me.txtMinutos.Name = "txtMinutos"
        Me.txtMinutos.ReadOnly = True
        Me.txtMinutos.Size = New System.Drawing.Size(100, 20)
        Me.txtMinutos.TabIndex = 7
        '
        'btnProgramar
        '
        Me.btnProgramar.Location = New System.Drawing.Point(88, 169)
        Me.btnProgramar.Name = "btnProgramar"
        Me.btnProgramar.Size = New System.Drawing.Size(75, 23)
        Me.btnProgramar.TabIndex = 8
        Me.btnProgramar.Text = "Programar"
        Me.btnProgramar.UseVisualStyleBackColor = True
        '
        'FormularioProgramar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 220)
        Me.Controls.Add(Me.btnProgramar)
        Me.Controls.Add(Me.txtMinutos)
        Me.Controls.Add(Me.lblMinutos)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.txtCodigoPelicula)
        Me.Controls.Add(Me.lblCodigoPelicula)
        Me.Controls.Add(Me.txtCodigoCine)
        Me.Controls.Add(Me.lblCodigoCine)
        Me.Name = "FormularioProgramar"
        Me.Text = "FormularioProgramar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCodigoCine As Label
    Friend WithEvents txtCodigoCine As TextBox
    Friend WithEvents lblCodigoPelicula As Label
    Friend WithEvents txtCodigoPelicula As TextBox
    Friend WithEvents lblHora As Label
    Friend WithEvents txtHora As TextBox
    Friend WithEvents lblMinutos As Label
    Friend WithEvents txtMinutos As TextBox
    Friend WithEvents btnProgramar As Button
End Class
