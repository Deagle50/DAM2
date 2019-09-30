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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Form1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormTool2StripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Form1ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Form1ToolStripMenuItem
        '
        Me.Form1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormToolStripMenuItem, Me.FormTool2StripMenuItem, Me.Form3ToolStripMenuItem})
        Me.Form1ToolStripMenuItem.Name = "Form1ToolStripMenuItem"
        Me.Form1ToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.Form1ToolStripMenuItem.Text = "Formularios"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FormToolStripMenuItem.Text = "Form1"
        '
        'FormTool2StripMenuItem
        '
        Me.FormTool2StripMenuItem.Name = "FormTool2StripMenuItem"
        Me.FormTool2StripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FormTool2StripMenuItem.Text = "Form2"
        '
        'Form3ToolStripMenuItem
        '
        Me.Form3ToolStripMenuItem.Name = "Form3ToolStripMenuItem"
        Me.Form3ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Form3ToolStripMenuItem.Text = "Form3"
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
    Friend WithEvents Form1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormTool2StripMenuItem As ToolStripMenuItem
    Friend WithEvents Form3ToolStripMenuItem As ToolStripMenuItem
End Class
