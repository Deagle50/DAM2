<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario3
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
        Me.lblN = New System.Windows.Forms.Label()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.btnIntro = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblMaximo = New System.Windows.Forms.Label()
        Me.lblMinimo = New System.Windows.Forms.Label()
        Me.lblMedia = New System.Windows.Forms.Label()
        Me.txtMaximo = New System.Windows.Forms.TextBox()
        Me.txtMinimo = New System.Windows.Forms.TextBox()
        Me.txtMedia = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(34, 25)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(19, 13)
        Me.lblN.TabIndex = 0
        Me.lblN.Text = "Nº"
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(37, 41)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(100, 20)
        Me.txtN.TabIndex = 1
        '
        'btnIntro
        '
        Me.btnIntro.Location = New System.Drawing.Point(37, 90)
        Me.btnIntro.Name = "btnIntro"
        Me.btnIntro.Size = New System.Drawing.Size(59, 24)
        Me.btnIntro.TabIndex = 2
        Me.btnIntro.Text = "Intro"
        Me.btnIntro.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(37, 120)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(59, 24)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblMaximo
        '
        Me.lblMaximo.AutoSize = True
        Me.lblMaximo.Location = New System.Drawing.Point(202, 25)
        Me.lblMaximo.Name = "lblMaximo"
        Me.lblMaximo.Size = New System.Drawing.Size(43, 13)
        Me.lblMaximo.TabIndex = 4
        Me.lblMaximo.Text = "Máximo"
        '
        'lblMinimo
        '
        Me.lblMinimo.AutoSize = True
        Me.lblMinimo.Location = New System.Drawing.Point(202, 64)
        Me.lblMinimo.Name = "lblMinimo"
        Me.lblMinimo.Size = New System.Drawing.Size(42, 13)
        Me.lblMinimo.TabIndex = 5
        Me.lblMinimo.Text = "Mínimo"
        '
        'lblMedia
        '
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Location = New System.Drawing.Point(202, 103)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(36, 13)
        Me.lblMedia.TabIndex = 6
        Me.lblMedia.Text = "Media"
        '
        'txtMaximo
        '
        Me.txtMaximo.Location = New System.Drawing.Point(205, 41)
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Size = New System.Drawing.Size(100, 20)
        Me.txtMaximo.TabIndex = 7
        '
        'txtMinimo
        '
        Me.txtMinimo.Location = New System.Drawing.Point(205, 80)
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.Size = New System.Drawing.Size(100, 20)
        Me.txtMinimo.TabIndex = 8
        '
        'txtMedia
        '
        Me.txtMedia.Location = New System.Drawing.Point(205, 119)
        Me.txtMedia.Name = "txtMedia"
        Me.txtMedia.Size = New System.Drawing.Size(100, 20)
        Me.txtMedia.TabIndex = 9
        '
        'Formulario3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtMedia)
        Me.Controls.Add(Me.txtMinimo)
        Me.Controls.Add(Me.txtMaximo)
        Me.Controls.Add(Me.lblMedia)
        Me.Controls.Add(Me.lblMinimo)
        Me.Controls.Add(Me.lblMaximo)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnIntro)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.lblN)
        Me.Name = "Formulario3"
        Me.Text = "Formulario3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblN As Label
    Friend WithEvents txtN As TextBox
    Friend WithEvents btnIntro As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblMaximo As Label
    Friend WithEvents lblMinimo As Label
    Friend WithEvents lblMedia As Label
    Friend WithEvents txtMaximo As TextBox
    Friend WithEvents txtMinimo As TextBox
    Friend WithEvents txtMedia As TextBox
End Class
