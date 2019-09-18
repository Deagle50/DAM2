<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculadoraMinions
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
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtMinionsCLava = New System.Windows.Forms.TextBox()
        Me.lblMinionsCLava = New System.Windows.Forms.Label()
        Me.lblMinionsSLava = New System.Windows.Forms.Label()
        Me.txtMinionsSLava = New System.Windows.Forms.TextBox()
        Me.lblCantidadXAccion = New System.Windows.Forms.Label()
        Me.txtCantidadXAccion = New System.Windows.Forms.TextBox()
        Me.txtTiempoXAccion = New System.Windows.Forms.TextBox()
        Me.lblTiempoXAccion = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.lblDias = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(102, 40)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(107, 13)
        Me.lblCantidad.TabIndex = 0
        Me.lblCantidad.Text = "Cantidad a conseguir"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(105, 56)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 1
        '
        'txtMinionsCLava
        '
        Me.txtMinionsCLava.Location = New System.Drawing.Point(105, 150)
        Me.txtMinionsCLava.Name = "txtMinionsCLava"
        Me.txtMinionsCLava.Size = New System.Drawing.Size(100, 20)
        Me.txtMinionsCLava.TabIndex = 2
        '
        'lblMinionsCLava
        '
        Me.lblMinionsCLava.AutoSize = True
        Me.lblMinionsCLava.Location = New System.Drawing.Point(102, 134)
        Me.lblMinionsCLava.Name = "lblMinionsCLava"
        Me.lblMinionsCLava.Size = New System.Drawing.Size(87, 13)
        Me.lblMinionsCLava.TabIndex = 3
        Me.lblMinionsCLava.Text = "Minions con lava"
        '
        'lblMinionsSLava
        '
        Me.lblMinionsSLava.AutoSize = True
        Me.lblMinionsSLava.Location = New System.Drawing.Point(225, 134)
        Me.lblMinionsSLava.Name = "lblMinionsSLava"
        Me.lblMinionsSLava.Size = New System.Drawing.Size(82, 13)
        Me.lblMinionsSLava.TabIndex = 5
        Me.lblMinionsSLava.Text = "Minions sin lava"
        '
        'txtMinionsSLava
        '
        Me.txtMinionsSLava.Location = New System.Drawing.Point(228, 150)
        Me.txtMinionsSLava.Name = "txtMinionsSLava"
        Me.txtMinionsSLava.Size = New System.Drawing.Size(100, 20)
        Me.txtMinionsSLava.TabIndex = 4
        '
        'lblCantidadXAccion
        '
        Me.lblCantidadXAccion.AutoSize = True
        Me.lblCantidadXAccion.Location = New System.Drawing.Point(102, 90)
        Me.lblCantidadXAccion.Name = "lblCantidadXAccion"
        Me.lblCantidadXAccion.Size = New System.Drawing.Size(102, 13)
        Me.lblCantidadXAccion.TabIndex = 6
        Me.lblCantidadXAccion.Text = "Cantidad por acción"
        '
        'txtCantidadXAccion
        '
        Me.txtCantidadXAccion.Location = New System.Drawing.Point(105, 106)
        Me.txtCantidadXAccion.Name = "txtCantidadXAccion"
        Me.txtCantidadXAccion.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadXAccion.TabIndex = 7
        '
        'txtTiempoXAccion
        '
        Me.txtTiempoXAccion.Location = New System.Drawing.Point(228, 106)
        Me.txtTiempoXAccion.Name = "txtTiempoXAccion"
        Me.txtTiempoXAccion.Size = New System.Drawing.Size(100, 20)
        Me.txtTiempoXAccion.TabIndex = 9
        '
        'lblTiempoXAccion
        '
        Me.lblTiempoXAccion.AutoSize = True
        Me.lblTiempoXAccion.Location = New System.Drawing.Point(225, 90)
        Me.lblTiempoXAccion.Name = "lblTiempoXAccion"
        Me.lblTiempoXAccion.Size = New System.Drawing.Size(95, 13)
        Me.lblTiempoXAccion.TabIndex = 8
        Me.lblTiempoXAccion.Text = "Tiempo por acción"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(102, 247)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(58, 13)
        Me.lblResultado.TabIndex = 10
        Me.lblResultado.Text = "Resultado:"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(105, 263)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 11
        '
        'lblDias
        '
        Me.lblDias.AutoSize = True
        Me.lblDias.Location = New System.Drawing.Point(211, 266)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(30, 13)
        Me.lblDias.TabIndex = 12
        Me.lblDias.Text = "Días"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(435, 104)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 13
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(435, 147)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'CalculadoraMinions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblDias)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.txtTiempoXAccion)
        Me.Controls.Add(Me.lblTiempoXAccion)
        Me.Controls.Add(Me.txtCantidadXAccion)
        Me.Controls.Add(Me.lblCantidadXAccion)
        Me.Controls.Add(Me.lblMinionsSLava)
        Me.Controls.Add(Me.txtMinionsSLava)
        Me.Controls.Add(Me.lblMinionsCLava)
        Me.Controls.Add(Me.txtMinionsCLava)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Name = "CalculadoraMinions"
        Me.Text = "CalculadoraMinions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtMinionsCLava As TextBox
    Friend WithEvents lblMinionsCLava As Label
    Friend WithEvents lblMinionsSLava As Label
    Friend WithEvents txtMinionsSLava As TextBox
    Friend WithEvents lblCantidadXAccion As Label
    Friend WithEvents txtCantidadXAccion As TextBox
    Friend WithEvents txtTiempoXAccion As TextBox
    Friend WithEvents lblTiempoXAccion As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents lblDias As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnReset As Button
End Class
