<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedido
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
        Me.txtPedido = New System.Windows.Forms.TextBox()
        Me.lblPedido = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.lvPedido = New System.Windows.Forms.ListView()
        Me.idDetalle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idPedido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idProducto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Unidades = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalLinea = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GBProducto = New System.Windows.Forms.GroupBox()
        Me.lblTotalLinea = New System.Windows.Forms.Label()
        Me.txtPrecioTotalLinea = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtUnidades = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblUnidades = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalPagar = New System.Windows.Forms.TextBox()
        Me.txtTotalva = New System.Windows.Forms.TextBox()
        Me.txtTotalNeto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GBProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPedido
        '
        Me.txtPedido.Location = New System.Drawing.Point(12, 24)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.Size = New System.Drawing.Size(100, 20)
        Me.txtPedido.TabIndex = 0
        '
        'lblPedido
        '
        Me.lblPedido.AutoSize = True
        Me.lblPedido.Location = New System.Drawing.Point(9, 8)
        Me.lblPedido.Name = "lblPedido"
        Me.lblPedido.Size = New System.Drawing.Size(40, 13)
        Me.lblPedido.TabIndex = 1
        Me.lblPedido.Text = "Pedido"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(335, 9)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(338, 25)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 3
        '
        'lvPedido
        '
        Me.lvPedido.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idDetalle, Me.idPedido, Me.idProducto, Me.Unidades, Me.totalLinea})
        Me.lvPedido.HideSelection = False
        Me.lvPedido.Location = New System.Drawing.Point(12, 50)
        Me.lvPedido.Name = "lvPedido"
        Me.lvPedido.Size = New System.Drawing.Size(692, 126)
        Me.lvPedido.TabIndex = 4
        Me.lvPedido.UseCompatibleStateImageBehavior = False
        Me.lvPedido.View = System.Windows.Forms.View.Details
        '
        'idDetalle
        '
        Me.idDetalle.Text = "Id detalle"
        '
        'idPedido
        '
        Me.idPedido.Text = "Id pedido"
        '
        'idProducto
        '
        Me.idProducto.Text = "Id producto"
        Me.idProducto.Width = 74
        '
        'Unidades
        '
        Me.Unidades.Text = "Unidades"
        '
        'totalLinea
        '
        Me.totalLinea.Text = "Total línea"
        Me.totalLinea.Width = 83
        '
        'GBProducto
        '
        Me.GBProducto.Controls.Add(Me.lblTotalLinea)
        Me.GBProducto.Controls.Add(Me.txtPrecioTotalLinea)
        Me.GBProducto.Controls.Add(Me.btnAgregar)
        Me.GBProducto.Controls.Add(Me.txtUnidades)
        Me.GBProducto.Controls.Add(Me.txtPrecio)
        Me.GBProducto.Controls.Add(Me.lblUnidades)
        Me.GBProducto.Controls.Add(Me.lblPrecio)
        Me.GBProducto.Controls.Add(Me.cmbProducto)
        Me.GBProducto.Location = New System.Drawing.Point(12, 267)
        Me.GBProducto.Name = "GBProducto"
        Me.GBProducto.Size = New System.Drawing.Size(776, 100)
        Me.GBProducto.TabIndex = 5
        Me.GBProducto.TabStop = False
        Me.GBProducto.Text = "Producto"
        '
        'lblTotalLinea
        '
        Me.lblTotalLinea.AutoSize = True
        Me.lblTotalLinea.Location = New System.Drawing.Point(345, 16)
        Me.lblTotalLinea.Name = "lblTotalLinea"
        Me.lblTotalLinea.Size = New System.Drawing.Size(57, 13)
        Me.lblTotalLinea.TabIndex = 7
        Me.lblTotalLinea.Text = "TotalLinea"
        '
        'txtPrecioTotalLinea
        '
        Me.txtPrecioTotalLinea.Location = New System.Drawing.Point(348, 32)
        Me.txtPrecioTotalLinea.Name = "txtPrecioTotalLinea"
        Me.txtPrecioTotalLinea.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioTotalLinea.TabIndex = 6
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(497, 33)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtUnidades
        '
        Me.txtUnidades.Location = New System.Drawing.Point(242, 33)
        Me.txtUnidades.Name = "txtUnidades"
        Me.txtUnidades.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidades.TabIndex = 4
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(136, 33)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 3
        '
        'lblUnidades
        '
        Me.lblUnidades.AutoSize = True
        Me.lblUnidades.Location = New System.Drawing.Point(239, 16)
        Me.lblUnidades.Name = "lblUnidades"
        Me.lblUnidades.Size = New System.Drawing.Size(52, 13)
        Me.lblUnidades.TabIndex = 2
        Me.lblUnidades.Text = "Unidades"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(133, 16)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 1
        Me.lblPrecio.Text = "Precio"
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(6, 32)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(121, 21)
        Me.cmbProducto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(221, 378)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Total Pagar"
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.Location = New System.Drawing.Point(224, 394)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalPagar.TabIndex = 12
        '
        'txtTotalva
        '
        Me.txtTotalva.Location = New System.Drawing.Point(118, 395)
        Me.txtTotalva.Name = "txtTotalva"
        Me.txtTotalva.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalva.TabIndex = 11
        '
        'txtTotalNeto
        '
        Me.txtTotalNeto.Location = New System.Drawing.Point(12, 395)
        Me.txtTotalNeto.Name = "txtTotalNeto"
        Me.txtTotalNeto.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalNeto.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 378)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Total IVA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total neto"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(509, 391)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 14
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GBProducto)
        Me.Controls.Add(Me.txtTotalPagar)
        Me.Controls.Add(Me.lvPedido)
        Me.Controls.Add(Me.txtTotalva)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtTotalNeto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPedido)
        Me.Controls.Add(Me.txtPedido)
        Me.Name = "Pedido"
        Me.Text = "Pedido"
        Me.GBProducto.ResumeLayout(False)
        Me.GBProducto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPedido As TextBox
    Friend WithEvents lblPedido As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents lvPedido As ListView
    Friend WithEvents idDetalle As ColumnHeader
    Friend WithEvents idPedido As ColumnHeader
    Friend WithEvents idProducto As ColumnHeader
    Friend WithEvents Unidades As ColumnHeader
    Friend WithEvents totalLinea As ColumnHeader
    Friend WithEvents GBProducto As GroupBox
    Friend WithEvents lblTotalLinea As Label
    Friend WithEvents txtPrecioTotalLinea As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtUnidades As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblUnidades As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalPagar As TextBox
    Friend WithEvents txtTotalva As TextBox
    Friend WithEvents txtTotalNeto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCerrar As Button
End Class
