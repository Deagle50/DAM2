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
        Me.lblCapitalInicial = New System.Windows.Forms.Label()
        Me.txtCapitalInicial = New System.Windows.Forms.TextBox()
        Me.lblInteres = New System.Windows.Forms.Label()
        Me.txtInteres = New System.Windows.Forms.TextBox()
        Me.lblAnos = New System.Windows.Forms.Label()
        Me.txtAnos = New System.Windows.Forms.TextBox()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lbAno = New System.Windows.Forms.ListBox()
        Me.lbCapital = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblCapitalInicial
        '
        Me.lblCapitalInicial.AutoSize = True
        Me.lblCapitalInicial.Location = New System.Drawing.Point(39, 25)
        Me.lblCapitalInicial.Name = "lblCapitalInicial"
        Me.lblCapitalInicial.Size = New System.Drawing.Size(69, 13)
        Me.lblCapitalInicial.TabIndex = 0
        Me.lblCapitalInicial.Text = "Capital Inicial"
        '
        'txtCapitalInicial
        '
        Me.txtCapitalInicial.Location = New System.Drawing.Point(42, 41)
        Me.txtCapitalInicial.Name = "txtCapitalInicial"
        Me.txtCapitalInicial.Size = New System.Drawing.Size(100, 20)
        Me.txtCapitalInicial.TabIndex = 1
        '
        'lblInteres
        '
        Me.lblInteres.AutoSize = True
        Me.lblInteres.Location = New System.Drawing.Point(39, 73)
        Me.lblInteres.Name = "lblInteres"
        Me.lblInteres.Size = New System.Drawing.Size(50, 13)
        Me.lblInteres.TabIndex = 2
        Me.lblInteres.Text = "% Interés"
        '
        'txtInteres
        '
        Me.txtInteres.Location = New System.Drawing.Point(42, 89)
        Me.txtInteres.Name = "txtInteres"
        Me.txtInteres.Size = New System.Drawing.Size(100, 20)
        Me.txtInteres.TabIndex = 3
        '
        'lblAnos
        '
        Me.lblAnos.AutoSize = True
        Me.lblAnos.Location = New System.Drawing.Point(163, 73)
        Me.lblAnos.Name = "lblAnos"
        Me.lblAnos.Size = New System.Drawing.Size(31, 13)
        Me.lblAnos.TabIndex = 4
        Me.lblAnos.Text = "Años"
        '
        'txtAnos
        '
        Me.txtAnos.Location = New System.Drawing.Point(166, 89)
        Me.txtAnos.Name = "txtAnos"
        Me.txtAnos.Size = New System.Drawing.Size(100, 20)
        Me.txtAnos.TabIndex = 5
        '
        'lblAno
        '
        Me.lblAno.AutoSize = True
        Me.lblAno.Location = New System.Drawing.Point(294, 25)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(26, 13)
        Me.lblAno.TabIndex = 6
        Me.lblAno.Text = "Año"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(407, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Capital"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(297, 215)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(100, 23)
        Me.btnCalcular.TabIndex = 10
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(410, 215)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lbAno
        '
        Me.lbAno.FormattingEnabled = True
        Me.lbAno.Location = New System.Drawing.Point(297, 41)
        Me.lbAno.Name = "lbAno"
        Me.lbAno.Size = New System.Drawing.Size(100, 160)
        Me.lbAno.TabIndex = 12
        '
        'lbCapital
        '
        Me.lbCapital.FormattingEnabled = True
        Me.lbCapital.Location = New System.Drawing.Point(410, 41)
        Me.lbCapital.Name = "lbCapital"
        Me.lbCapital.Size = New System.Drawing.Size(100, 160)
        Me.lbCapital.TabIndex = 13
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbCapital)
        Me.Controls.Add(Me.lbAno)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblAno)
        Me.Controls.Add(Me.txtAnos)
        Me.Controls.Add(Me.lblAnos)
        Me.Controls.Add(Me.txtInteres)
        Me.Controls.Add(Me.lblInteres)
        Me.Controls.Add(Me.txtCapitalInicial)
        Me.Controls.Add(Me.lblCapitalInicial)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCapitalInicial As Label
    Friend WithEvents txtCapitalInicial As TextBox
    Friend WithEvents lblInteres As Label
    Friend WithEvents txtInteres As TextBox
    Friend WithEvents lblAnos As Label
    Friend WithEvents txtAnos As TextBox
    Friend WithEvents lblAno As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lbAno As ListBox
    Friend WithEvents lbCapital As ListBox
End Class
