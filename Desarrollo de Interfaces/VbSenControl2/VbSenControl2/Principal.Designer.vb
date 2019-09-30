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
        Me.FormulariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormulariosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormulariosToolStripMenuItem
        '
        Me.FormulariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Form1ToolStripMenuItem, Me.Form2ToolStripMenuItem, Me.Form3ToolStripMenuItem, Me.Form4ToolStripMenuItem})
        Me.FormulariosToolStripMenuItem.Name = "FormulariosToolStripMenuItem"
        Me.FormulariosToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.FormulariosToolStripMenuItem.Text = "Formularios"
        '
        'Form1ToolStripMenuItem
        '
        Me.Form1ToolStripMenuItem.Name = "Form1ToolStripMenuItem"
        Me.Form1ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Form1ToolStripMenuItem.Text = "Form1"
        '
        'Form2ToolStripMenuItem
        '
        Me.Form2ToolStripMenuItem.Name = "Form2ToolStripMenuItem"
        Me.Form2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Form2ToolStripMenuItem.Text = "Form2"
        '
        'Form3ToolStripMenuItem
        '
        Me.Form3ToolStripMenuItem.Name = "Form3ToolStripMenuItem"
        Me.Form3ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Form3ToolStripMenuItem.Text = "Form3"
        '
        'Form4ToolStripMenuItem
        '
        Me.Form4ToolStripMenuItem.Name = "Form4ToolStripMenuItem"
        Me.Form4ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Form4ToolStripMenuItem.Text = "Form4"
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
    Friend WithEvents FormulariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Form1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Form2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Form3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Form4ToolStripMenuItem As ToolStripMenuItem
End Class
