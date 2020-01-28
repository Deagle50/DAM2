<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.btnProgramar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lvDatos = New System.Windows.Forms.ListView()
        Me.chCodEmision = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPelicula = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chHoraC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chHoraF = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnProgramar
        '
        Me.btnProgramar.Location = New System.Drawing.Point(12, 12)
        Me.btnProgramar.Name = "btnProgramar"
        Me.btnProgramar.Size = New System.Drawing.Size(75, 23)
        Me.btnProgramar.TabIndex = 0
        Me.btnProgramar.Text = "Programar"
        Me.btnProgramar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(121, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(13, 353)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar cine"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(108, 355)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(168, 20)
        Me.txtBuscar.TabIndex = 4
        '
        'lvDatos
        '
        Me.lvDatos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCodEmision, Me.chPelicula, Me.chHoraC, Me.chHoraF})
        Me.lvDatos.HideSelection = False
        Me.lvDatos.Location = New System.Drawing.Point(13, 41)
        Me.lvDatos.Name = "lvDatos"
        Me.lvDatos.Size = New System.Drawing.Size(516, 308)
        Me.lvDatos.TabIndex = 5
        Me.lvDatos.UseCompatibleStateImageBehavior = False
        Me.lvDatos.View = System.Windows.Forms.View.Details
        '
        'chCodEmision
        '
        Me.chCodEmision.Text = "Cod_emision"
        Me.chCodEmision.Width = 87
        '
        'chPelicula
        '
        Me.chPelicula.Text = "Pelicula"
        '
        'chHoraC
        '
        Me.chHoraC.Text = "Hora comienzo"
        Me.chHoraC.Width = 96
        '
        'chHoraF
        '
        Me.chHoraF.Text = "Hora fin"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lvDatos)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnProgramar)
        Me.Name = "frmPrincipal"
        Me.Text = "Formulario principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProgramar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lvDatos As ListView
    Friend WithEvents chCodEmision As ColumnHeader
    Friend WithEvents chPelicula As ColumnHeader
    Friend WithEvents chHoraC As ColumnHeader
    Friend WithEvents chHoraF As ColumnHeader
End Class
