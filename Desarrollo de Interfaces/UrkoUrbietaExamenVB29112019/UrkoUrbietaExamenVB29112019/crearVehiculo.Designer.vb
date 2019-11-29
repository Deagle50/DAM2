<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crearVehiculo
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
        Me.txtAntelacion = New System.Windows.Forms.TextBox()
        Me.lblAntelacion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtIdVehiculo = New System.Windows.Forms.TextBox()
        Me.lblIdVehiculo = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAntelacion
        '
        Me.txtAntelacion.Location = New System.Drawing.Point(12, 104)
        Me.txtAntelacion.Name = "txtAntelacion"
        Me.txtAntelacion.Size = New System.Drawing.Size(100, 20)
        Me.txtAntelacion.TabIndex = 13
        '
        'lblAntelacion
        '
        Me.lblAntelacion.AutoSize = True
        Me.lblAntelacion.Location = New System.Drawing.Point(9, 88)
        Me.lblAntelacion.Name = "lblAntelacion"
        Me.lblAntelacion.Size = New System.Drawing.Size(57, 13)
        Me.lblAntelacion.TabIndex = 12
        Me.lblAntelacion.Text = "Antelación"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 62)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcion.TabIndex = 11
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(9, 46)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 10
        Me.lblDescripcion.Text = "Descripción"
        '
        'txtIdVehiculo
        '
        Me.txtIdVehiculo.Enabled = False
        Me.txtIdVehiculo.Location = New System.Drawing.Point(12, 23)
        Me.txtIdVehiculo.Name = "txtIdVehiculo"
        Me.txtIdVehiculo.Size = New System.Drawing.Size(100, 20)
        Me.txtIdVehiculo.TabIndex = 9
        '
        'lblIdVehiculo
        '
        Me.lblIdVehiculo.AutoSize = True
        Me.lblIdVehiculo.Location = New System.Drawing.Point(9, 7)
        Me.lblIdVehiculo.Name = "lblIdVehiculo"
        Me.lblIdVehiculo.Size = New System.Drawing.Size(62, 13)
        Me.lblIdVehiculo.TabIndex = 8
        Me.lblIdVehiculo.Text = "Id Vehículo"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(200, 62)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'crearVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtAntelacion)
        Me.Controls.Add(Me.lblAntelacion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtIdVehiculo)
        Me.Controls.Add(Me.lblIdVehiculo)
        Me.Name = "crearVehiculo"
        Me.Text = "crearVehiculo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAntelacion As TextBox
    Friend WithEvents lblAntelacion As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtIdVehiculo As TextBox
    Friend WithEvents lblIdVehiculo As Label
    Friend WithEvents btnAgregar As Button
End Class
