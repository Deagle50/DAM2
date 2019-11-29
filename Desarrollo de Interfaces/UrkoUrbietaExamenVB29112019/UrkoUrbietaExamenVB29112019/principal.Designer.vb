<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principal
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
        Me.lblIdVehiculo = New System.Windows.Forms.Label()
        Me.txtIdVehiculo = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lvInspecciones = New System.Windows.Forms.ListView()
        Me.chIdInspeccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRealizada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblAntelacion = New System.Windows.Forms.Label()
        Me.txtAntelacion = New System.Windows.Forms.TextBox()
        Me.btnRevisar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIdVehiculo
        '
        Me.lblIdVehiculo.AutoSize = True
        Me.lblIdVehiculo.Location = New System.Drawing.Point(12, 9)
        Me.lblIdVehiculo.Name = "lblIdVehiculo"
        Me.lblIdVehiculo.Size = New System.Drawing.Size(62, 13)
        Me.lblIdVehiculo.TabIndex = 0
        Me.lblIdVehiculo.Text = "Id Vehículo"
        '
        'txtIdVehiculo
        '
        Me.txtIdVehiculo.Location = New System.Drawing.Point(15, 25)
        Me.txtIdVehiculo.Name = "txtIdVehiculo"
        Me.txtIdVehiculo.Size = New System.Drawing.Size(100, 20)
        Me.txtIdVehiculo.TabIndex = 1
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 48)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(15, 64)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(200, 25)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lvInspecciones
        '
        Me.lvInspecciones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chIdInspeccion, Me.chFecha, Me.chRealizada})
        Me.lvInspecciones.HideSelection = False
        Me.lvInspecciones.Location = New System.Drawing.Point(15, 99)
        Me.lvInspecciones.Name = "lvInspecciones"
        Me.lvInspecciones.Size = New System.Drawing.Size(328, 183)
        Me.lvInspecciones.TabIndex = 5
        Me.lvInspecciones.UseCompatibleStateImageBehavior = False
        Me.lvInspecciones.View = System.Windows.Forms.View.Details
        '
        'chIdInspeccion
        '
        Me.chIdInspeccion.Text = "Id Inspección"
        Me.chIdInspeccion.Width = 89
        '
        'chFecha
        '
        Me.chFecha.Text = "Fecha"
        '
        'chRealizada
        '
        Me.chRealizada.Text = "Realizada"
        '
        'lblAntelacion
        '
        Me.lblAntelacion.AutoSize = True
        Me.lblAntelacion.Location = New System.Drawing.Point(12, 298)
        Me.lblAntelacion.Name = "lblAntelacion"
        Me.lblAntelacion.Size = New System.Drawing.Size(57, 13)
        Me.lblAntelacion.TabIndex = 6
        Me.lblAntelacion.Text = "Antelación"
        '
        'txtAntelacion
        '
        Me.txtAntelacion.Location = New System.Drawing.Point(15, 314)
        Me.txtAntelacion.Name = "txtAntelacion"
        Me.txtAntelacion.Size = New System.Drawing.Size(100, 20)
        Me.txtAntelacion.TabIndex = 7
        '
        'btnRevisar
        '
        Me.btnRevisar.Location = New System.Drawing.Point(12, 359)
        Me.btnRevisar.Name = "btnRevisar"
        Me.btnRevisar.Size = New System.Drawing.Size(75, 23)
        Me.btnRevisar.TabIndex = 8
        Me.btnRevisar.Text = "Revisar"
        Me.btnRevisar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(227, 359)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnRevisar)
        Me.Controls.Add(Me.txtAntelacion)
        Me.Controls.Add(Me.lblAntelacion)
        Me.Controls.Add(Me.lvInspecciones)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtIdVehiculo)
        Me.Controls.Add(Me.lblIdVehiculo)
        Me.Name = "principal"
        Me.Text = "principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIdVehiculo As Label
    Friend WithEvents txtIdVehiculo As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lvInspecciones As ListView
    Friend WithEvents chIdInspeccion As ColumnHeader
    Friend WithEvents chFecha As ColumnHeader
    Friend WithEvents chRealizada As ColumnHeader
    Friend WithEvents lblAntelacion As Label
    Friend WithEvents txtAntelacion As TextBox
    Friend WithEvents btnRevisar As Button
    Friend WithEvents btnEliminar As Button
End Class
