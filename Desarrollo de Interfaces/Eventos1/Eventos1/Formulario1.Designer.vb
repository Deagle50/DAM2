<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario1
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
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.txtNumeros = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(59, 71)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(22, 23)
        Me.btn2.TabIndex = 9
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(31, 71)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(22, 23)
        Me.btn1.TabIndex = 8
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'txtNumeros
        '
        Me.txtNumeros.Location = New System.Drawing.Point(31, 45)
        Me.txtNumeros.Name = "txtNumeros"
        Me.txtNumeros.Size = New System.Drawing.Size(429, 20)
        Me.txtNumeros.TabIndex = 7
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(28, 29)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(44, 13)
        Me.lblNumero.TabIndex = 6
        Me.lblNumero.Text = "Número"
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(87, 71)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(22, 23)
        Me.btn3.TabIndex = 10
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(115, 71)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(22, 23)
        Me.btn4.TabIndex = 11
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'Formulario1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtNumeros)
        Me.Controls.Add(Me.lblNumero)
        Me.Name = "Formulario1"
        Me.Text = "Formulario1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents txtNumeros As TextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
End Class
