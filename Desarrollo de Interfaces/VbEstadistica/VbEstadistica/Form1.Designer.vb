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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTamano = New System.Windows.Forms.Label()
        Me.txtTamano = New System.Windows.Forms.TextBox()
        Me.txtMaximo = New System.Windows.Forms.TextBox()
        Me.txtMedia = New System.Windows.Forms.TextBox()
        Me.btnMaximo = New System.Windows.Forms.Button()
        Me.btnMedia = New System.Windows.Forms.Button()
        Me.NuevoDatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarDatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoDatoToolStripMenuItem, Me.CambiarDatoToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'lblTamano
        '
        Me.lblTamano.AutoSize = True
        Me.lblTamano.Location = New System.Drawing.Point(40, 34)
        Me.lblTamano.Name = "lblTamano"
        Me.lblTamano.Size = New System.Drawing.Size(86, 13)
        Me.lblTamano.TabIndex = 1
        Me.lblTamano.Text = "Tamaño muestra"
        '
        'txtTamano
        '
        Me.txtTamano.Location = New System.Drawing.Point(132, 31)
        Me.txtTamano.Name = "txtTamano"
        Me.txtTamano.Size = New System.Drawing.Size(100, 20)
        Me.txtTamano.TabIndex = 2
        '
        'txtMaximo
        '
        Me.txtMaximo.Location = New System.Drawing.Point(43, 57)
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Size = New System.Drawing.Size(100, 20)
        Me.txtMaximo.TabIndex = 3
        '
        'txtMedia
        '
        Me.txtMedia.Location = New System.Drawing.Point(43, 83)
        Me.txtMedia.Name = "txtMedia"
        Me.txtMedia.Size = New System.Drawing.Size(100, 20)
        Me.txtMedia.TabIndex = 4
        '
        'btnMaximo
        '
        Me.btnMaximo.Location = New System.Drawing.Point(166, 57)
        Me.btnMaximo.Name = "btnMaximo"
        Me.btnMaximo.Size = New System.Drawing.Size(75, 20)
        Me.btnMaximo.TabIndex = 5
        Me.btnMaximo.Text = "Máximo"
        Me.btnMaximo.UseVisualStyleBackColor = True
        '
        'btnMedia
        '
        Me.btnMedia.Location = New System.Drawing.Point(166, 83)
        Me.btnMedia.Name = "btnMedia"
        Me.btnMedia.Size = New System.Drawing.Size(75, 20)
        Me.btnMedia.TabIndex = 6
        Me.btnMedia.Text = "Media"
        Me.btnMedia.UseVisualStyleBackColor = True
        '
        'NuevoDatoToolStripMenuItem
        '
        Me.NuevoDatoToolStripMenuItem.Name = "NuevoDatoToolStripMenuItem"
        Me.NuevoDatoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NuevoDatoToolStripMenuItem.Text = "Nuevo dato"
        '
        'CambiarDatoToolStripMenuItem
        '
        Me.CambiarDatoToolStripMenuItem.Name = "CambiarDatoToolStripMenuItem"
        Me.CambiarDatoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CambiarDatoToolStripMenuItem.Text = "Cambiar dato"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMedia)
        Me.Controls.Add(Me.btnMaximo)
        Me.Controls.Add(Me.txtMedia)
        Me.Controls.Add(Me.txtMaximo)
        Me.Controls.Add(Me.txtTamano)
        Me.Controls.Add(Me.lblTamano)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTamano As Windows.Forms.Label
    Friend WithEvents txtTamano As Windows.Forms.TextBox
    Friend WithEvents txtMaximo As Windows.Forms.TextBox
    Friend WithEvents txtMedia As Windows.Forms.TextBox
    Friend WithEvents btnMaximo As Windows.Forms.Button
    Friend WithEvents btnMedia As Windows.Forms.Button
    Friend WithEvents NuevoDatoToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarDatoToolStripMenuItem As Windows.Forms.ToolStripMenuItem
End Class
