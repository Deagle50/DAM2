<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario4
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
        Me.txtCentigrados = New System.Windows.Forms.TextBox()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.lblCentigrados = New System.Windows.Forms.Label()
        Me.lblFahrenheit = New System.Windows.Forms.Label()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCentigrados
        '
        Me.txtCentigrados.Location = New System.Drawing.Point(144, 50)
        Me.txtCentigrados.Name = "txtCentigrados"
        Me.txtCentigrados.Size = New System.Drawing.Size(100, 20)
        Me.txtCentigrados.TabIndex = 0
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Location = New System.Drawing.Point(144, 76)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(100, 20)
        Me.txtFahrenheit.TabIndex = 1
        '
        'lblCentigrados
        '
        Me.lblCentigrados.AutoSize = True
        Me.lblCentigrados.Location = New System.Drawing.Point(66, 57)
        Me.lblCentigrados.Name = "lblCentigrados"
        Me.lblCentigrados.Size = New System.Drawing.Size(65, 13)
        Me.lblCentigrados.TabIndex = 2
        Me.lblCentigrados.Text = "Centígrados"
        '
        'lblFahrenheit
        '
        Me.lblFahrenheit.AutoSize = True
        Me.lblFahrenheit.Location = New System.Drawing.Point(66, 83)
        Me.lblFahrenheit.Name = "lblFahrenheit"
        Me.lblFahrenheit.Size = New System.Drawing.Size(57, 13)
        Me.lblFahrenheit.TabIndex = 3
        Me.lblFahrenheit.Text = "Fahrenheit"
        '
        'btnConvertir
        '
        Me.btnConvertir.Enabled = False
        Me.btnConvertir.Location = New System.Drawing.Point(69, 119)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(175, 23)
        Me.btnConvertir.TabIndex = 4
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'Formulario4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.lblFahrenheit)
        Me.Controls.Add(Me.lblCentigrados)
        Me.Controls.Add(Me.txtFahrenheit)
        Me.Controls.Add(Me.txtCentigrados)
        Me.Name = "Formulario4"
        Me.Text = "Formulario4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCentigrados As TextBox
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents lblCentigrados As Label
    Friend WithEvents lblFahrenheit As Label
    Friend WithEvents btnConvertir As Button
End Class
