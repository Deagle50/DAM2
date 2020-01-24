<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuenta
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
        Me.lblNcuenta = New System.Windows.Forms.Label()
        Me.btReintegro = New System.Windows.Forms.Button()
        Me.txtReintegro = New System.Windows.Forms.TextBox()
        Me.lblCuentaN = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.BtConsultar = New System.Windows.Forms.Button()
        Me.BtBorrar = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Movimiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Importe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Concepto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNcuenta
        '
        Me.lblNcuenta.AutoSize = True
        Me.lblNcuenta.Location = New System.Drawing.Point(46, 35)
        Me.lblNcuenta.Name = "lblNcuenta"
        Me.lblNcuenta.Size = New System.Drawing.Size(78, 13)
        Me.lblNcuenta.TabIndex = 0
        Me.lblNcuenta.Text = "NumeroCuenta"
        '
        'btReintegro
        '
        Me.btReintegro.Location = New System.Drawing.Point(49, 97)
        Me.btReintegro.Name = "btReintegro"
        Me.btReintegro.Size = New System.Drawing.Size(75, 23)
        Me.btReintegro.TabIndex = 1
        Me.btReintegro.Text = "Reintegro"
        Me.btReintegro.UseVisualStyleBackColor = True
        '
        'txtReintegro
        '
        Me.txtReintegro.Location = New System.Drawing.Point(237, 97)
        Me.txtReintegro.Name = "txtReintegro"
        Me.txtReintegro.Size = New System.Drawing.Size(100, 20)
        Me.txtReintegro.TabIndex = 2
        '
        'lblCuentaN
        '
        Me.lblCuentaN.AutoSize = True
        Me.lblCuentaN.Location = New System.Drawing.Point(297, 35)
        Me.lblCuentaN.Name = "lblCuentaN"
        Me.lblCuentaN.Size = New System.Drawing.Size(0, 13)
        Me.lblCuentaN.TabIndex = 3
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(49, 161)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(36, 13)
        Me.lblDesde.TabIndex = 4
        Me.lblDesde.Text = "desde"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(234, 161)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 5
        Me.lblHasta.Text = "Hasta"
        '
        'txtDesde
        '
        Me.txtDesde.Location = New System.Drawing.Point(49, 204)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtDesde.TabIndex = 6
        '
        'txtHasta
        '
        Me.txtHasta.Location = New System.Drawing.Point(237, 204)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtHasta.TabIndex = 7
        '
        'BtConsultar
        '
        Me.BtConsultar.Location = New System.Drawing.Point(49, 254)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultar.TabIndex = 8
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'BtBorrar
        '
        Me.BtBorrar.Location = New System.Drawing.Point(237, 254)
        Me.BtBorrar.Name = "BtBorrar"
        Me.BtBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BtBorrar.TabIndex = 9
        Me.BtBorrar.Text = "Borrar"
        Me.BtBorrar.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Movimiento, Me.Importe, Me.Concepto, Me.Fecha})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(49, 301)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(432, 126)
        Me.ListView1.TabIndex = 10
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Movimiento
        '
        Me.Movimiento.Text = "Movimiento"
        Me.Movimiento.Width = 120
        '
        'Importe
        '
        Me.Importe.Text = "Importe"
        Me.Importe.Width = 91
        '
        'Concepto
        '
        Me.Concepto.Text = "Concepto"
        Me.Concepto.Width = 107
        '
        'Fecha
        '
        Me.Fecha.Text = "Fecha"
        Me.Fecha.Width = 129
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(503, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Saldo"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(506, 364)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(0, 13)
        Me.lblSaldo.TabIndex = 12
        '
        'frmCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BtBorrar)
        Me.Controls.Add(Me.BtConsultar)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.lblHasta)
        Me.Controls.Add(Me.lblDesde)
        Me.Controls.Add(Me.lblCuentaN)
        Me.Controls.Add(Me.txtReintegro)
        Me.Controls.Add(Me.btReintegro)
        Me.Controls.Add(Me.lblNcuenta)
        Me.Name = "frmCuenta"
        Me.Text = "frmCuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNcuenta As Label
    Friend WithEvents btReintegro As Button
    Friend WithEvents txtReintegro As TextBox
    Friend WithEvents lblCuentaN As Label
    Friend WithEvents lblDesde As Label
    Friend WithEvents lblHasta As Label
    Friend WithEvents txtDesde As TextBox
    Friend WithEvents txtHasta As TextBox
    Friend WithEvents BtConsultar As Button
    Friend WithEvents BtBorrar As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents Movimiento As ColumnHeader
    Friend WithEvents Importe As ColumnHeader
    Friend WithEvents Concepto As ColumnHeader
    Friend WithEvents Fecha As ColumnHeader
End Class
