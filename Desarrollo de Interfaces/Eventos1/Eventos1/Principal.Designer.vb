<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Formulario1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Formulario1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Formulario2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Formulario3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Formulario4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Formulario1ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Formulario1ToolStripMenuItem
        '
        Me.Formulario1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Formulario1ToolStripMenuItem1, Me.Formulario2ToolStripMenuItem, Me.Formulario3ToolStripMenuItem, Me.Formulario4ToolStripMenuItem})
        Me.Formulario1ToolStripMenuItem.Name = "Formulario1ToolStripMenuItem"
        Me.Formulario1ToolStripMenuItem.Size = New System.Drawing.Size(138, 20)
        Me.Formulario1ToolStripMenuItem.Text = "Seleccionar formulario"
        '
        'Formulario1ToolStripMenuItem1
        '
        Me.Formulario1ToolStripMenuItem1.Name = "Formulario1ToolStripMenuItem1"
        Me.Formulario1ToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.Formulario1ToolStripMenuItem1.Text = "Formulario1"
        '
        'Formulario2ToolStripMenuItem
        '
        Me.Formulario2ToolStripMenuItem.Name = "Formulario2ToolStripMenuItem"
        Me.Formulario2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Formulario2ToolStripMenuItem.Text = "Formulario2"
        '
        'Formulario3ToolStripMenuItem
        '
        Me.Formulario3ToolStripMenuItem.Name = "Formulario3ToolStripMenuItem"
        Me.Formulario3ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Formulario3ToolStripMenuItem.Text = "Formulario3"
        '
        'Formulario4ToolStripMenuItem
        '
        Me.Formulario4ToolStripMenuItem.Name = "Formulario4ToolStripMenuItem"
        Me.Formulario4ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Formulario4ToolStripMenuItem.Text = "Formulario4"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Formulario1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Formulario1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Formulario2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Formulario3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Formulario4ToolStripMenuItem As ToolStripMenuItem
End Class
