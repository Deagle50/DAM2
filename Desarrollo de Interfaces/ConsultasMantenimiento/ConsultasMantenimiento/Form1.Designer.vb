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
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.lblConsulta1 = New System.Windows.Forms.Label()
        Me.btnConsulta1 = New System.Windows.Forms.Button()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDatos
        '
        Me.dgvDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(695, 12)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.Size = New System.Drawing.Size(746, 673)
        Me.dgvDatos.TabIndex = 0
        '
        'lblConsulta1
        '
        Me.lblConsulta1.AutoSize = True
        Me.lblConsulta1.Location = New System.Drawing.Point(12, 12)
        Me.lblConsulta1.Name = "lblConsulta1"
        Me.lblConsulta1.Size = New System.Drawing.Size(528, 13)
        Me.lblConsulta1.TabIndex = 1
        Me.lblConsulta1.Text = "o" & Global.Microsoft.VisualBasic.ChrW(9) & "Seleccionar codigo de equipo, procesador y velocidad de todos los Equipos con 6" &
    "4 Mb de memoria o menos."
        '
        'btnConsulta1
        '
        Me.btnConsulta1.Location = New System.Drawing.Point(614, 12)
        Me.btnConsulta1.Name = "btnConsulta1"
        Me.btnConsulta1.Size = New System.Drawing.Size(75, 23)
        Me.btnConsulta1.TabIndex = 2
        Me.btnConsulta1.Text = "Consulta1"
        Me.btnConsulta1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1453, 697)
        Me.Controls.Add(Me.btnConsulta1)
        Me.Controls.Add(Me.lblConsulta1)
        Me.Controls.Add(Me.dgvDatos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents lblConsulta1 As Label
    Friend WithEvents btnConsulta1 As Button
End Class
