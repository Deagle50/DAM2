<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form4
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
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.lblUnidades = New System.Windows.Forms.Label()
        Me.txtPrecioUnidad = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(347, 289)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(75, 23)
        Me.btnFinalizar.TabIndex = 17
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(347, 119)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 16
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnComenzar
        '
        Me.btnComenzar.Location = New System.Drawing.Point(347, 56)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(75, 20)
        Me.btnComenzar.TabIndex = 15
        Me.btnComenzar.Text = "Comenzar"
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'txtUnidades
        '
        Me.txtUnidades.Location = New System.Drawing.Point(141, 92)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidades.TabIndex = 14
        '
        'lblUnidades
        '
        Me.lblUnidades.AutoSize = True
        Me.lblUnidades.Location = New System.Drawing.Point(55, 95)
        Me.lblUnidades.Name = "lblUnidades"
        Me.lblUnidades.Size = New System.Drawing.Size(52, 13)
        Me.lblUnidades.TabIndex = 13
        Me.lblUnidades.Text = "Unidades"
        '
        'txtPrecioUnidad
        '
        Me.txtPrecioUnidad.Location = New System.Drawing.Point(141, 131)
        Me.txtPrecioUnidad.Name = "txtPrecioUnidad"
        Me.txtPrecioUnidad.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioUnidad.TabIndex = 12
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(55, 134)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 11
        Me.lblPrecio.Text = "Precio"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(141, 202)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 10
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(55, 60)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 9
        Me.lblProducto.Text = "Producto"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(141, 167)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 18
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(141, 57)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtProducto.TabIndex = 19
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Location = New System.Drawing.Point(55, 170)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(59, 13)
        Me.lblDescuento.TabIndex = 20
        Me.lblDescuento.Text = "Descuento"
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Location = New System.Drawing.Point(55, 205)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(42, 13)
        Me.lblImporte.TabIndex = 21
        Me.lblImporte.Text = "Importe"
        '
        'form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblImporte)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.txtUnidades)
        Me.Controls.Add(Me.lblUnidades)
        Me.Controls.Add(Me.txtPrecioUnidad)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.lblProducto)
        Me.Name = "form4"
        Me.Text = "form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFinalizar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnComenzar As Button
    Friend WithEvents txtUnidades As TextBox
    Friend WithEvents lblUnidades As Label
    Friend WithEvents txtPrecioUnidad As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents lblProducto As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents lblDescuento As Label
    Friend WithEvents lblImporte As Label
End Class
