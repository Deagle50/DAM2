<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtSuma = New System.Windows.Forms.TextBox()
        Me.lblSuma = New System.Windows.Forms.Label()
        Me.txtInteres = New System.Windows.Forms.TextBox()
        Me.lblInteres = New System.Windows.Forms.Label()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn12 = New System.Windows.Forms.Button()
        Me.btn16 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Location = New System.Drawing.Point(52, 20)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(42, 13)
        Me.lblImporte.TabIndex = 0
        Me.lblImporte.Text = "Importe"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(55, 36)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 1
        '
        'txtSuma
        '
        Me.txtSuma.Location = New System.Drawing.Point(55, 140)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.Size = New System.Drawing.Size(100, 20)
        Me.txtSuma.TabIndex = 3
        '
        'lblSuma
        '
        Me.lblSuma.AutoSize = True
        Me.lblSuma.Location = New System.Drawing.Point(52, 124)
        Me.lblSuma.Name = "lblSuma"
        Me.lblSuma.Size = New System.Drawing.Size(34, 13)
        Me.lblSuma.TabIndex = 2
        Me.lblSuma.Text = "Suma"
        '
        'txtInteres
        '
        Me.txtInteres.Location = New System.Drawing.Point(55, 89)
        Me.txtInteres.Name = "txtInteres"
        Me.txtInteres.Size = New System.Drawing.Size(100, 20)
        Me.txtInteres.TabIndex = 5
        '
        'lblInteres
        '
        Me.lblInteres.AutoSize = True
        Me.lblInteres.Location = New System.Drawing.Point(52, 73)
        Me.lblInteres.Name = "lblInteres"
        Me.lblInteres.Size = New System.Drawing.Size(39, 13)
        Me.lblInteres.TabIndex = 4
        Me.lblInteres.Text = "Interés"
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(244, 36)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(75, 23)
        Me.btn7.TabIndex = 6
        Me.btn7.Text = "7 %"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn12
        '
        Me.btn12.Location = New System.Drawing.Point(244, 86)
        Me.btn12.Name = "btn12"
        Me.btn12.Size = New System.Drawing.Size(75, 23)
        Me.btn12.TabIndex = 7
        Me.btn12.Text = "12 %"
        Me.btn12.UseVisualStyleBackColor = True
        '
        'btn16
        '
        Me.btn16.Location = New System.Drawing.Point(244, 140)
        Me.btn16.Name = "btn16"
        Me.btn16.Size = New System.Drawing.Size(75, 23)
        Me.btn16.TabIndex = 8
        Me.btn16.Text = "16 %"
        Me.btn16.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn16)
        Me.Controls.Add(Me.btn12)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.txtInteres)
        Me.Controls.Add(Me.lblInteres)
        Me.Controls.Add(Me.txtSuma)
        Me.Controls.Add(Me.lblSuma)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.lblImporte)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblImporte As Label
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents txtSuma As TextBox
    Friend WithEvents lblSuma As Label
    Friend WithEvents txtInteres As TextBox
    Friend WithEvents lblInteres As Label
    Friend WithEvents btn7 As Button
    Friend WithEvents btn12 As Button
    Friend WithEvents btn16 As Button
End Class
