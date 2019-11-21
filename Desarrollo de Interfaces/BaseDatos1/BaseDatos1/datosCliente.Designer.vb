<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class datosCliente
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
        Me.lblNCuenta = New System.Windows.Forms.Label()
        Me.txtNCuenta = New System.Windows.Forms.Label()
        Me.btnReintegro = New System.Windows.Forms.Button()
        Me.txtReintegro = New System.Windows.Forms.TextBox()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.LVDatosCliente = New System.Windows.Forms.ListView()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNCuenta
        '
        Me.lblNCuenta.AutoSize = True
        Me.lblNCuenta.Location = New System.Drawing.Point(12, 9)
        Me.lblNCuenta.Name = "lblNCuenta"
        Me.lblNCuenta.Size = New System.Drawing.Size(53, 13)
        Me.lblNCuenta.TabIndex = 0
        Me.lblNCuenta.Text = "NºCuenta"
        '
        'txtNCuenta
        '
        Me.txtNCuenta.AutoSize = True
        Me.txtNCuenta.Location = New System.Drawing.Point(71, 9)
        Me.txtNCuenta.Name = "txtNCuenta"
        Me.txtNCuenta.Size = New System.Drawing.Size(0, 13)
        Me.txtNCuenta.TabIndex = 1
        '
        'btnReintegro
        '
        Me.btnReintegro.Location = New System.Drawing.Point(12, 36)
        Me.btnReintegro.Name = "btnReintegro"
        Me.btnReintegro.Size = New System.Drawing.Size(75, 23)
        Me.btnReintegro.TabIndex = 2
        Me.btnReintegro.Text = "Reintegro"
        Me.btnReintegro.UseVisualStyleBackColor = True
        '
        'txtReintegro
        '
        Me.txtReintegro.Location = New System.Drawing.Point(93, 38)
        Me.txtReintegro.Name = "txtReintegro"
        Me.txtReintegro.Size = New System.Drawing.Size(100, 20)
        Me.txtReintegro.TabIndex = 3
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(12, 72)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(38, 13)
        Me.lblDesde.TabIndex = 4
        Me.lblDesde.Text = "Desde"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(90, 72)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 5
        Me.lblHasta.Text = "Hasta"
        '
        'txtDesde
        '
        Me.txtDesde.Location = New System.Drawing.Point(12, 88)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(75, 20)
        Me.txtDesde.TabIndex = 6
        '
        'txtHasta
        '
        Me.txtHasta.Location = New System.Drawing.Point(93, 88)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(75, 20)
        Me.txtHasta.TabIndex = 7
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(12, 114)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 8
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(93, 114)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 9
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'LVDatosCliente
        '
        Me.LVDatosCliente.HideSelection = False
        Me.LVDatosCliente.Location = New System.Drawing.Point(12, 143)
        Me.LVDatosCliente.Name = "LVDatosCliente"
        Me.LVDatosCliente.Size = New System.Drawing.Size(419, 182)
        Me.LVDatosCliente.TabIndex = 10
        Me.LVDatosCliente.UseCompatibleStateImageBehavior = False
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(9, 328)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(34, 13)
        Me.lblSaldo.TabIndex = 11
        Me.lblSaldo.Text = "Saldo"
        '
        'txtSaldo
        '
        Me.txtSaldo.AutoSize = True
        Me.txtSaldo.Location = New System.Drawing.Point(49, 328)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(0, 13)
        Me.txtSaldo.TabIndex = 12
        '
        'datosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.LVDatosCliente)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.lblHasta)
        Me.Controls.Add(Me.lblDesde)
        Me.Controls.Add(Me.txtReintegro)
        Me.Controls.Add(Me.btnReintegro)
        Me.Controls.Add(Me.txtNCuenta)
        Me.Controls.Add(Me.lblNCuenta)
        Me.Name = "datosCliente"
        Me.Text = "datosCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNCuenta As Label
    Friend WithEvents txtNCuenta As Label
    Friend WithEvents btnReintegro As Button
    Friend WithEvents txtReintegro As TextBox
    Friend WithEvents lblDesde As Label
    Friend WithEvents lblHasta As Label
    Friend WithEvents txtDesde As TextBox
    Friend WithEvents txtHasta As TextBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents LVDatosCliente As ListView
    Friend WithEvents lblSaldo As Label
    Friend WithEvents txtSaldo As Label
End Class
