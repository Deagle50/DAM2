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
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.btnPulsar = New System.Windows.Forms.Button()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.btnPulsar2 = New System.Windows.Forms.Button()
        Me.gbxSFW = New System.Windows.Forms.GroupBox()
        Me.gbxJoin = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxDatos = New System.Windows.Forms.ComboBox()
        Me.btnPulsar3 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnPulsar4 = New System.Windows.Forms.Button()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxSFW.SuspendLayout()
        Me.gbxJoin.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(6, 23)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(100, 20)
        Me.txtEstado.TabIndex = 0
        '
        'btnPulsar
        '
        Me.btnPulsar.Location = New System.Drawing.Point(112, 20)
        Me.btnPulsar.Name = "btnPulsar"
        Me.btnPulsar.Size = New System.Drawing.Size(75, 23)
        Me.btnPulsar.TabIndex = 1
        Me.btnPulsar.Text = "Pulsar"
        Me.btnPulsar.UseVisualStyleBackColor = True
        '
        'dgvDatos
        '
        Me.dgvDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(526, 155)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.Size = New System.Drawing.Size(262, 283)
        Me.dgvDatos.TabIndex = 2
        '
        'btnPulsar2
        '
        Me.btnPulsar2.Location = New System.Drawing.Point(112, 19)
        Me.btnPulsar2.Name = "btnPulsar2"
        Me.btnPulsar2.Size = New System.Drawing.Size(75, 23)
        Me.btnPulsar2.TabIndex = 3
        Me.btnPulsar2.Text = "Pulsar"
        Me.btnPulsar2.UseVisualStyleBackColor = True
        '
        'gbxSFW
        '
        Me.gbxSFW.Controls.Add(Me.btnPulsar)
        Me.gbxSFW.Controls.Add(Me.txtEstado)
        Me.gbxSFW.Location = New System.Drawing.Point(12, 12)
        Me.gbxSFW.Name = "gbxSFW"
        Me.gbxSFW.Size = New System.Drawing.Size(200, 54)
        Me.gbxSFW.TabIndex = 4
        Me.gbxSFW.TabStop = False
        Me.gbxSFW.Text = "Select From Where"
        '
        'gbxJoin
        '
        Me.gbxJoin.Controls.Add(Me.btnPulsar2)
        Me.gbxJoin.Location = New System.Drawing.Point(12, 72)
        Me.gbxJoin.Name = "gbxJoin"
        Me.gbxJoin.Size = New System.Drawing.Size(200, 58)
        Me.gbxJoin.TabIndex = 5
        Me.gbxJoin.TabStop = False
        Me.gbxJoin.Text = "Join"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxDatos)
        Me.GroupBox1.Controls.Add(Me.btnPulsar3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 54)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Propiedades de navegación"
        '
        'cbxDatos
        '
        Me.cbxDatos.FormattingEnabled = True
        Me.cbxDatos.Location = New System.Drawing.Point(6, 21)
        Me.cbxDatos.Name = "cbxDatos"
        Me.cbxDatos.Size = New System.Drawing.Size(100, 21)
        Me.cbxDatos.TabIndex = 7
        '
        'btnPulsar3
        '
        Me.btnPulsar3.Location = New System.Drawing.Point(112, 19)
        Me.btnPulsar3.Name = "btnPulsar3"
        Me.btnPulsar3.Size = New System.Drawing.Size(75, 23)
        Me.btnPulsar3.TabIndex = 3
        Me.btnPulsar3.Text = "Pulsar"
        Me.btnPulsar3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnPulsar4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 196)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 54)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Propiedades de navegación"
        '
        'btnPulsar4
        '
        Me.btnPulsar4.Location = New System.Drawing.Point(112, 19)
        Me.btnPulsar4.Name = "btnPulsar4"
        Me.btnPulsar4.Size = New System.Drawing.Size(75, 23)
        Me.btnPulsar4.TabIndex = 3
        Me.btnPulsar4.Text = "Pulsar"
        Me.btnPulsar4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxJoin)
        Me.Controls.Add(Me.gbxSFW)
        Me.Controls.Add(Me.dgvDatos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxSFW.ResumeLayout(False)
        Me.gbxSFW.PerformLayout()
        Me.gbxJoin.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtEstado As TextBox
    Friend WithEvents btnPulsar As Button
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents btnPulsar2 As Button
    Friend WithEvents gbxSFW As GroupBox
    Friend WithEvents gbxJoin As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPulsar3 As Button
    Friend WithEvents cbxDatos As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnPulsar4 As Button
End Class
