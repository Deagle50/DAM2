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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnPulsar5 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnPulsar6 = New System.Windows.Forms.Button()
        Me.sadsa = New System.Windows.Forms.GroupBox()
        Me.btnPulsar7 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnPulsar8 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnPulsar9 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnPulsar10 = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnPulsar11 = New System.Windows.Forms.Button()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxSFW.SuspendLayout()
        Me.gbxJoin.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.sadsa.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
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
        Me.gbxSFW.Text = "Select From Where 1"
        '
        'gbxJoin
        '
        Me.gbxJoin.Controls.Add(Me.btnPulsar2)
        Me.gbxJoin.Location = New System.Drawing.Point(12, 72)
        Me.gbxJoin.Name = "gbxJoin"
        Me.gbxJoin.Size = New System.Drawing.Size(200, 58)
        Me.gbxJoin.TabIndex = 5
        Me.gbxJoin.TabStop = False
        Me.gbxJoin.Text = "Join 2"
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
        Me.GroupBox1.Text = "Propiedades de navegación 3"
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
        Me.GroupBox2.Text = "Propiedades de navegación 4"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnPulsar5)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 256)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 54)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Propiedades de navegación 5"
        '
        'btnPulsar5
        '
        Me.btnPulsar5.Location = New System.Drawing.Point(112, 19)
        Me.btnPulsar5.Name = "btnPulsar5"
        Me.btnPulsar5.Size = New System.Drawing.Size(75, 23)
        Me.btnPulsar5.TabIndex = 3
        Me.btnPulsar5.Text = "Pulsar"
        Me.btnPulsar5.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnPulsar6)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 316)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 54)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Aggregate 6"
        '
        'btnPulsar6
        '
        Me.btnPulsar6.Location = New System.Drawing.Point(112, 19)
        Me.btnPulsar6.Name = "btnPulsar6"
        Me.btnPulsar6.Size = New System.Drawing.Size(75, 23)
        Me.btnPulsar6.TabIndex = 3
        Me.btnPulsar6.Text = "Pulsar"
        Me.btnPulsar6.UseVisualStyleBackColor = True
        '
        'sadsa
        '
        Me.sadsa.Controls.Add(Me.btnPulsar7)
        Me.sadsa.Location = New System.Drawing.Point(12, 376)
        Me.sadsa.Name = "sadsa"
        Me.sadsa.Size = New System.Drawing.Size(200, 54)
        Me.sadsa.TabIndex = 11
        Me.sadsa.TabStop = False
        Me.sadsa.Text = "Agreggate 7"
        '
        'btnPulsar7
        '
        Me.btnPulsar7.Location = New System.Drawing.Point(112, 19)
        Me.btnPulsar7.Name = "btnPulsar7"
        Me.btnPulsar7.Size = New System.Drawing.Size(75, 23)
        Me.btnPulsar7.TabIndex = 3
        Me.btnPulsar7.Text = "Pulsar"
        Me.btnPulsar7.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnPulsar8)
        Me.GroupBox5.Location = New System.Drawing.Point(240, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 54)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Let, 8"
        '
        'btnPulsar8
        '
        Me.btnPulsar8.Location = New System.Drawing.Point(112, 19)
        Me.btnPulsar8.Name = "btnPulsar8"
        Me.btnPulsar8.Size = New System.Drawing.Size(75, 23)
        Me.btnPulsar8.TabIndex = 3
        Me.btnPulsar8.Text = "Pulsar"
        Me.btnPulsar8.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnPulsar9)
        Me.GroupBox6.Location = New System.Drawing.Point(240, 72)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 54)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Let, 9"
        '
        'btnPulsar9
        '
        Me.btnPulsar9.Location = New System.Drawing.Point(112, 19)
        Me.btnPulsar9.Name = "btnPulsar9"
        Me.btnPulsar9.Size = New System.Drawing.Size(75, 23)
        Me.btnPulsar9.TabIndex = 3
        Me.btnPulsar9.Text = "Pulsar"
        Me.btnPulsar9.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnPulsar10)
        Me.GroupBox7.Location = New System.Drawing.Point(240, 136)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(200, 54)
        Me.GroupBox7.TabIndex = 14
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Disctint, 10"
        '
        'btnPulsar10
        '
        Me.btnPulsar10.Location = New System.Drawing.Point(112, 19)
        Me.btnPulsar10.Name = "btnPulsar10"
        Me.btnPulsar10.Size = New System.Drawing.Size(75, 23)
        Me.btnPulsar10.TabIndex = 3
        Me.btnPulsar10.Text = "Pulsar"
        Me.btnPulsar10.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btnPulsar11)
        Me.GroupBox8.Location = New System.Drawing.Point(240, 196)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(200, 54)
        Me.GroupBox8.TabIndex = 15
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Skip, 11"
        '
        'btnPulsar11
        '
        Me.btnPulsar11.Location = New System.Drawing.Point(112, 19)
        Me.btnPulsar11.Name = "btnPulsar11"
        Me.btnPulsar11.Size = New System.Drawing.Size(75, 23)
        Me.btnPulsar11.TabIndex = 3
        Me.btnPulsar11.Text = "Pulsar"
        Me.btnPulsar11.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.sadsa)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
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
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.sadsa.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
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
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnPulsar5 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnPulsar6 As Button
    Friend WithEvents sadsa As GroupBox
    Friend WithEvents btnPulsar7 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnPulsar8 As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnPulsar9 As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btnPulsar10 As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents btnPulsar11 As Button
End Class
