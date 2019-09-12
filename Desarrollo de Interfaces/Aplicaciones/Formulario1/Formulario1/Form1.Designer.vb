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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnNombre = New System.Windows.Forms.Button()
        Me.lstNombres = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(62, 55)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(82, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Agregar nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(65, 71)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 1
        '
        'btnNombre
        '
        Me.btnNombre.Location = New System.Drawing.Point(217, 71)
        Me.btnNombre.Name = "btnNombre"
        Me.btnNombre.Size = New System.Drawing.Size(75, 23)
        Me.btnNombre.TabIndex = 2
        Me.btnNombre.Text = "Agregar"
        Me.btnNombre.UseVisualStyleBackColor = True
        '
        'lstNombres
        '
        Me.lstNombres.FormattingEnabled = True
        Me.lstNombres.Location = New System.Drawing.Point(65, 97)
        Me.lstNombres.Name = "lstNombres"
        Me.lstNombres.Size = New System.Drawing.Size(120, 95)
        Me.lstNombres.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstNombres)
        Me.Controls.Add(Me.btnNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnNombre As Button
    Friend WithEvents lstNombres As ListBox
End Class
