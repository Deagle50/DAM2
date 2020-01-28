<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioCancelar
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
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtMinutos = New System.Windows.Forms.TextBox()
        Me.lblMinutos = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.txtCodigoPelicula = New System.Windows.Forms.TextBox()
        Me.lblCodigoPelicula = New System.Windows.Forms.Label()
        Me.txtCodigoCine = New System.Windows.Forms.TextBox()
        Me.lblCodigoCine = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(81, 151)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtMinutos
        '
        Me.txtMinutos.Location = New System.Drawing.Point(119, 113)
        Me.txtMinutos.Name = "txtMinutos"
        Me.txtMinutos.ReadOnly = True
        Me.txtMinutos.Size = New System.Drawing.Size(100, 20)
        Me.txtMinutos.TabIndex = 16
        '
        'lblMinutos
        '
        Me.lblMinutos.AutoSize = True
        Me.lblMinutos.Location = New System.Drawing.Point(25, 116)
        Me.lblMinutos.Name = "lblMinutos"
        Me.lblMinutos.Size = New System.Drawing.Size(44, 13)
        Me.lblMinutos.TabIndex = 15
        Me.lblMinutos.Text = "Minutos"
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(119, 84)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(100, 20)
        Me.txtHora.TabIndex = 14
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(25, 87)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(30, 13)
        Me.lblHora.TabIndex = 13
        Me.lblHora.Text = "Hora"
        '
        'txtCodigoPelicula
        '
        Me.txtCodigoPelicula.Location = New System.Drawing.Point(119, 54)
        Me.txtCodigoPelicula.Name = "txtCodigoPelicula"
        Me.txtCodigoPelicula.ReadOnly = True
        Me.txtCodigoPelicula.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoPelicula.TabIndex = 12
        '
        'lblCodigoPelicula
        '
        Me.lblCodigoPelicula.AutoSize = True
        Me.lblCodigoPelicula.Location = New System.Drawing.Point(25, 57)
        Me.lblCodigoPelicula.Name = "lblCodigoPelicula"
        Me.lblCodigoPelicula.Size = New System.Drawing.Size(82, 13)
        Me.lblCodigoPelicula.TabIndex = 11
        Me.lblCodigoPelicula.Text = "Código Película"
        '
        'txtCodigoCine
        '
        Me.txtCodigoCine.Location = New System.Drawing.Point(119, 23)
        Me.txtCodigoCine.Name = "txtCodigoCine"
        Me.txtCodigoCine.ReadOnly = True
        Me.txtCodigoCine.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoCine.TabIndex = 10
        '
        'lblCodigoCine
        '
        Me.lblCodigoCine.AutoSize = True
        Me.lblCodigoCine.Location = New System.Drawing.Point(25, 26)
        Me.lblCodigoCine.Name = "lblCodigoCine"
        Me.lblCodigoCine.Size = New System.Drawing.Size(64, 13)
        Me.lblCodigoCine.TabIndex = 9
        Me.lblCodigoCine.Text = "Código Cine"
        '
        'FormularioCancelar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 207)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtMinutos)
        Me.Controls.Add(Me.lblMinutos)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.txtCodigoPelicula)
        Me.Controls.Add(Me.lblCodigoPelicula)
        Me.Controls.Add(Me.txtCodigoCine)
        Me.Controls.Add(Me.lblCodigoCine)
        Me.Name = "FormularioCancelar"
        Me.Text = "FormularioCancelar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtMinutos As TextBox
    Friend WithEvents lblMinutos As Label
    Friend WithEvents txtHora As TextBox
    Friend WithEvents lblHora As Label
    Friend WithEvents txtCodigoPelicula As TextBox
    Friend WithEvents lblCodigoPelicula As Label
    Friend WithEvents txtCodigoCine As TextBox
    Friend WithEvents lblCodigoCine As Label
End Class
