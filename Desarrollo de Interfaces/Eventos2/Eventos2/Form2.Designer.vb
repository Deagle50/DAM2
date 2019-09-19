<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblN = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.btnAdivinar = New System.Windows.Forms.Button()
        Me.btnIntro = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(34, 41)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(19, 13)
        Me.lblN.TabIndex = 0
        Me.lblN.Text = "Nº"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(37, 57)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 1
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(37, 83)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 2
        '
        'btnAdivinar
        '
        Me.btnAdivinar.Location = New System.Drawing.Point(170, 83)
        Me.btnAdivinar.Name = "btnAdivinar"
        Me.btnAdivinar.Size = New System.Drawing.Size(75, 20)
        Me.btnAdivinar.TabIndex = 3
        Me.btnAdivinar.Text = "Adivinar"
        Me.btnAdivinar.UseVisualStyleBackColor = True
        '
        'btnIntro
        '
        Me.btnIntro.Location = New System.Drawing.Point(170, 57)
        Me.btnIntro.Name = "btnIntro"
        Me.btnIntro.Size = New System.Drawing.Size(75, 20)
        Me.btnIntro.TabIndex = 4
        Me.btnIntro.Text = "Intro"
        Me.btnIntro.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnIntro)
        Me.Controls.Add(Me.btnAdivinar)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lblN)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblN As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents btnAdivinar As Button
    Friend WithEvents btnIntro As Button
End Class
