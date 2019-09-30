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
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(13, 29)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(14, 13)
        Me.lblA.TabIndex = 1
        Me.lblA.Text = "A"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(124, 29)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(14, 13)
        Me.lblB.TabIndex = 2
        Me.lblB.Text = "B"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(12, 45)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 20)
        Me.txtA.TabIndex = 3
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(118, 45)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 20)
        Me.txtB.TabIndex = 4
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(78, 121)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 5
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblA As Label
    Friend WithEvents lblB As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents btnCalcular As Button
End Class
