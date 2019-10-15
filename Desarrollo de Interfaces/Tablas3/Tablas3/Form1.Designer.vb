<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnInforme = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNPedido = New System.Windows.Forms.TextBox()
        Me.lblNPedido = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnInforme
        '
        Me.btnInforme.Location = New System.Drawing.Point(286, 87)
        Me.btnInforme.Name = "btnInforme"
        Me.btnInforme.Size = New System.Drawing.Size(75, 23)
        Me.btnInforme.TabIndex = 29
        Me.btnInforme.Text = "Informe"
        Me.btnInforme.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(286, 42)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 28
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(94, 119)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 27
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(20, 122)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 26
        Me.lblPrecio.Text = "Precio"
        '
        'txtUnidades
        '
        Me.txtUnidades.Location = New System.Drawing.Point(94, 84)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidades.TabIndex = 25
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(20, 87)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 24
        Me.lblApellido.Text = "Apellido"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(94, 49)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtProducto.TabIndex = 23
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(20, 52)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 22
        Me.lblNombre.Text = "Nombre"
        '
        'txtNPedido
        '
        Me.txtNPedido.Location = New System.Drawing.Point(94, 12)
        Me.txtNPedido.Name = "txtNPedido"
        Me.txtNPedido.Size = New System.Drawing.Size(100, 20)
        Me.txtNPedido.TabIndex = 21
        '
        'lblNPedido
        '
        Me.lblNPedido.AutoSize = True
        Me.lblNPedido.Location = New System.Drawing.Point(20, 15)
        Me.lblNPedido.Name = "lblNPedido"
        Me.lblNPedido.Size = New System.Drawing.Size(48, 13)
        Me.lblNPedido.TabIndex = 20
        Me.lblNPedido.Text = "NPedido"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnInforme)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtUnidades)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNPedido)
        Me.Controls.Add(Me.lblNPedido)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInforme As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtUnidades As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNPedido As TextBox
    Friend WithEvents lblNPedido As Label
End Class
