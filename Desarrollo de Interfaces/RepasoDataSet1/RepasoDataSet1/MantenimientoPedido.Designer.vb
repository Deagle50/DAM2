<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MantenimientoPedido
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
        Me.lblTotalLinea = New System.Windows.Forms.Label()
        Me.txtPrecioTotalLinea = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtPedido = New System.Windows.Forms.TextBox()
        Me.lblUnidades = New System.Windows.Forms.Label()
        Me.lblPedido = New System.Windows.Forms.Label()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTotalLinea
        '
        Me.lblTotalLinea.AutoSize = True
        Me.lblTotalLinea.Location = New System.Drawing.Point(12, 133)
        Me.lblTotalLinea.Name = "lblTotalLinea"
        Me.lblTotalLinea.Size = New System.Drawing.Size(57, 13)
        Me.lblTotalLinea.TabIndex = 13
        Me.lblTotalLinea.Text = "TotalLinea"
        '
        'txtPrecioTotalLinea
        '
        Me.txtPrecioTotalLinea.Location = New System.Drawing.Point(15, 149)
        Me.txtPrecioTotalLinea.Name = "txtPrecioTotalLinea"
        Me.txtPrecioTotalLinea.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioTotalLinea.TabIndex = 12
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(15, 82)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcion.TabIndex = 11
        '
        'txtPedido
        '
        Me.txtPedido.Location = New System.Drawing.Point(15, 26)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.Size = New System.Drawing.Size(100, 20)
        Me.txtPedido.TabIndex = 10
        '
        'lblUnidades
        '
        Me.lblUnidades.AutoSize = True
        Me.lblUnidades.Location = New System.Drawing.Point(12, 65)
        Me.lblUnidades.Name = "lblUnidades"
        Me.lblUnidades.Size = New System.Drawing.Size(52, 13)
        Me.lblUnidades.TabIndex = 9
        Me.lblUnidades.Text = "Unidades"
        '
        'lblPedido
        '
        Me.lblPedido.AutoSize = True
        Me.lblPedido.Location = New System.Drawing.Point(12, 9)
        Me.lblPedido.Name = "lblPedido"
        Me.lblPedido.Size = New System.Drawing.Size(40, 13)
        Me.lblPedido.TabIndex = 8
        Me.lblPedido.Text = "Pedido"
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(15, 201)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnAlta.TabIndex = 14
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(96, 201)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(75, 23)
        Me.btnBaja.TabIndex = 15
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(177, 201)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(177, 26)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'MantenimientoPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.lblTotalLinea)
        Me.Controls.Add(Me.txtPrecioTotalLinea)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtPedido)
        Me.Controls.Add(Me.lblUnidades)
        Me.Controls.Add(Me.lblPedido)
        Me.Name = "MantenimientoPedido"
        Me.Text = "MantenimientoPedido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalLinea As Label
    Friend WithEvents txtPrecioTotalLinea As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtPedido As TextBox
    Friend WithEvents lblUnidades As Label
    Friend WithEvents lblPedido As Label
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBuscar As Button
End Class
