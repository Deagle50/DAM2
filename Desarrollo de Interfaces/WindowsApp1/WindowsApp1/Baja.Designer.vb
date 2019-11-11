<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Baja
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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(149, 134)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(101, 21)
        Me.btnAgregar.TabIndex = 33
        Me.btnAgregar.Text = "Borrar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 108)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 32
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(147, 91)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 31
        Me.lblEmail.Text = "Email"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(149, 68)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 30
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(146, 51)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 29
        Me.lblApellido.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(11, 68)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 28
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(8, 51)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 27
        Me.lblNombre.Text = "Nombre"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(149, 28)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 26
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(146, 11)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(26, 13)
        Me.lblDNI.TabIndex = 25
        Me.lblDNI.Text = "DNI"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(11, 108)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 24
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(8, 91)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(61, 13)
        Me.lblPass.TabIndex = 23
        Me.lblPass.Text = "Contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(12, 28)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Usuario"
        '
        'Baja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Baja"
        Me.Text = "Baja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents lblDNI As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
End Class
