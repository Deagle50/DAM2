﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Source
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
        Me.lblPalabra = New System.Windows.Forms.Label()
        Me.txtPalabra = New System.Windows.Forms.TextBox()
        Me.txtSignificado = New System.Windows.Forms.TextBox()
        Me.lblSignificado = New System.Windows.Forms.Label()
        Me.btnTraducir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPalabra
        '
        Me.lblPalabra.AutoSize = True
        Me.lblPalabra.Location = New System.Drawing.Point(12, 9)
        Me.lblPalabra.Name = "lblPalabra"
        Me.lblPalabra.Size = New System.Drawing.Size(46, 13)
        Me.lblPalabra.TabIndex = 0
        Me.lblPalabra.Text = "Palabra:"
        '
        'txtPalabra
        '
        Me.txtPalabra.Location = New System.Drawing.Point(12, 25)
        Me.txtPalabra.Name = "txtPalabra"
        Me.txtPalabra.Size = New System.Drawing.Size(100, 20)
        Me.txtPalabra.TabIndex = 1
        '
        'txtSignificado
        '
        Me.txtSignificado.Location = New System.Drawing.Point(12, 66)
        Me.txtSignificado.Name = "txtSignificado"
        Me.txtSignificado.Size = New System.Drawing.Size(100, 20)
        Me.txtSignificado.TabIndex = 3
        '
        'lblSignificado
        '
        Me.lblSignificado.AutoSize = True
        Me.lblSignificado.Location = New System.Drawing.Point(12, 50)
        Me.lblSignificado.Name = "lblSignificado"
        Me.lblSignificado.Size = New System.Drawing.Size(62, 13)
        Me.lblSignificado.TabIndex = 2
        Me.lblSignificado.Text = "Significado:"
        '
        'btnTraducir
        '
        Me.btnTraducir.Location = New System.Drawing.Point(141, 45)
        Me.btnTraducir.Name = "btnTraducir"
        Me.btnTraducir.Size = New System.Drawing.Size(75, 22)
        Me.btnTraducir.TabIndex = 4
        Me.btnTraducir.Text = "Traducir"
        Me.btnTraducir.UseVisualStyleBackColor = True
        '
        'Source
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTraducir)
        Me.Controls.Add(Me.txtSignificado)
        Me.Controls.Add(Me.lblSignificado)
        Me.Controls.Add(Me.txtPalabra)
        Me.Controls.Add(Me.lblPalabra)
        Me.Name = "Source"
        Me.Text = "Source"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPalabra As Label
    Friend WithEvents txtPalabra As TextBox
    Friend WithEvents txtSignificado As TextBox
    Friend WithEvents lblSignificado As Label
    Friend WithEvents btnTraducir As Button
End Class
