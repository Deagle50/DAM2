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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.btn8 = New System.Windows.Forms.Button()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowDrop = True
        Me.dgvDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Location = New System.Drawing.Point(335, 12)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.Size = New System.Drawing.Size(1150, 674)
        Me.dgvDatos.TabIndex = 0
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(15, 71)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "Ejecutar"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(15, 159)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 23)
        Me.btn2.TabIndex = 4
        Me.btn2.Text = "Ejecutar"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(15, 231)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 23)
        Me.btn3.TabIndex = 6
        Me.btn3.Text = "Ejecutar"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(15, 325)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(75, 23)
        Me.btn4.TabIndex = 7
        Me.btn4.Text = "Ejecutar"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(15, 406)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(75, 23)
        Me.btn5.TabIndex = 10
        Me.btn5.Text = "Ejecutar"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(317, 53)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "1." & Global.Microsoft.VisualBasic.ChrW(9) & "Visualizar todos los datos de los clientes que " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "posean un vehículo de la marc" &
    "a Opel blanco (Consulta de selección)."
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(15, 100)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(317, 53)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.Text = "2." & Global.Microsoft.VisualBasic.ChrW(9) & "Visualizar todos los datos de los clientes que posean un vehículo de la marca " &
    "Opel o sea de color blanco o negro (Consulta de selección)."
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(15, 188)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(317, 37)
        Me.TextBox3.TabIndex = 13
        Me.TextBox3.Text = "3." & Global.Microsoft.VisualBasic.ChrW(9) & "Visualizar todos los datos de los clientes que residan en DONOSTIA (Consulta d" &
    "e selección)."
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(15, 260)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(317, 59)
        Me.TextBox4.TabIndex = 14
        Me.TextBox4.Text = resources.GetString("TextBox4.Text")
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(15, 354)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(317, 46)
        Me.TextBox5.TabIndex = 15
        Me.TextBox5.Text = "5." & Global.Microsoft.VisualBasic.ChrW(9) & "Mostrar por pantalla todos los datos de las notas de reparaciones que se han e" &
    "mitido durante el mes de Mayo (Consulta de selección)."
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(15, 435)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(314, 48)
        Me.TextBox6.TabIndex = 16
        Me.TextBox6.Text = "6." & Global.Microsoft.VisualBasic.ChrW(9) & "Visualizar por pantalla todos los datos de las notas de reparaciones que se ha" &
    "n emitido durante el primer trimestre de año 2003 (Consulta de selección)."
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(15, 489)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(75, 23)
        Me.btn6.TabIndex = 17
        Me.btn6.Text = "Ejecutar"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(15, 518)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(314, 61)
        Me.TextBox7.TabIndex = 18
        Me.TextBox7.Text = resources.GetString("TextBox7.Text")
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(15, 585)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(75, 23)
        Me.btn7.TabIndex = 19
        Me.btn7.Text = "Ejecutar"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(15, 610)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(314, 47)
        Me.TextBox8.TabIndex = 20
        Me.TextBox8.Text = "8." & Global.Microsoft.VisualBasic.ChrW(9) & "Preparar una consulta para que nos de el total a pagar por cada una de las not" &
    "as de reparaciones que tenemos registradas (Agrupación de registros)."
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(15, 663)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(75, 23)
        Me.btn8.TabIndex = 21
        Me.btn8.Text = "Ejecutar"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1497, 692)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.dgvDatos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents btn6 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents btn7 As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents btn8 As Button
End Class
