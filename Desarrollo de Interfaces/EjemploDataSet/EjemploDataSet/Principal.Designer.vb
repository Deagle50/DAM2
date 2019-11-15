<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.LVPrincipal = New System.Windows.Forms.ListView()
        Me.btnVerUsuarios = New System.Windows.Forms.Button()
        Me.menuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLlenarFilasOriginal = New System.Windows.Forms.Button()
        Me.GuardarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'LVPrincipal
        '
        Me.LVPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVPrincipal.HideSelection = False
        Me.LVPrincipal.Location = New System.Drawing.Point(13, 27)
        Me.LVPrincipal.Name = "LVPrincipal"
        Me.LVPrincipal.Size = New System.Drawing.Size(775, 388)
        Me.LVPrincipal.TabIndex = 0
        Me.LVPrincipal.UseCompatibleStateImageBehavior = False
        Me.LVPrincipal.View = System.Windows.Forms.View.Details
        '
        'btnVerUsuarios
        '
        Me.btnVerUsuarios.Location = New System.Drawing.Point(13, 421)
        Me.btnVerUsuarios.Name = "btnVerUsuarios"
        Me.btnVerUsuarios.Size = New System.Drawing.Size(75, 23)
        Me.btnVerUsuarios.TabIndex = 1
        Me.btnVerUsuarios.Text = "Ver usuarios"
        Me.btnVerUsuarios.UseVisualStyleBackColor = True
        '
        'menuPrincipal
        '
        Me.menuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.menuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.menuPrincipal.Name = "menuPrincipal"
        Me.menuPrincipal.Size = New System.Drawing.Size(800, 24)
        Me.menuPrincipal.TabIndex = 2
        Me.menuPrincipal.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoUsuariosToolStripMenuItem, Me.GuardarCambiosToolStripMenuItem, Me.CancelarCambiosToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'MantenimientoUsuariosToolStripMenuItem
        '
        Me.MantenimientoUsuariosToolStripMenuItem.Name = "MantenimientoUsuariosToolStripMenuItem"
        Me.MantenimientoUsuariosToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.MantenimientoUsuariosToolStripMenuItem.Text = "Mantenimiento usuarios"
        '
        'btnLlenarFilasOriginal
        '
        Me.btnLlenarFilasOriginal.Location = New System.Drawing.Point(94, 421)
        Me.btnLlenarFilasOriginal.Name = "btnLlenarFilasOriginal"
        Me.btnLlenarFilasOriginal.Size = New System.Drawing.Size(104, 23)
        Me.btnLlenarFilasOriginal.TabIndex = 3
        Me.btnLlenarFilasOriginal.Text = "Llenar filas original"
        Me.btnLlenarFilasOriginal.UseVisualStyleBackColor = True
        '
        'GuardarCambiosToolStripMenuItem
        '
        Me.GuardarCambiosToolStripMenuItem.Name = "GuardarCambiosToolStripMenuItem"
        Me.GuardarCambiosToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.GuardarCambiosToolStripMenuItem.Text = "Guardar cambios"
        '
        'CancelarCambiosToolStripMenuItem
        '
        Me.CancelarCambiosToolStripMenuItem.Name = "CancelarCambiosToolStripMenuItem"
        Me.CancelarCambiosToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CancelarCambiosToolStripMenuItem.Text = "Cancelar cambios"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLlenarFilasOriginal)
        Me.Controls.Add(Me.btnVerUsuarios)
        Me.Controls.Add(Me.LVPrincipal)
        Me.Controls.Add(Me.menuPrincipal)
        Me.MainMenuStrip = Me.menuPrincipal
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.menuPrincipal.ResumeLayout(False)
        Me.menuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LVPrincipal As ListView
    Friend WithEvents btnVerUsuarios As Button
    Friend WithEvents menuPrincipal As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnLlenarFilasOriginal As Button
    Friend WithEvents GuardarCambiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarCambiosToolStripMenuItem As ToolStripMenuItem
End Class
