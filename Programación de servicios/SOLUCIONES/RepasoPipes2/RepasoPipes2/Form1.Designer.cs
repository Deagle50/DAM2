﻿namespace RepasoPipes2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtVecesMayor = new System.Windows.Forms.TextBox();
            this.txtVecesMenor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veces Mayor";
            // 
            // txtVecesMayor
            // 
            this.txtVecesMayor.Location = new System.Drawing.Point(26, 57);
            this.txtVecesMayor.Name = "txtVecesMayor";
            this.txtVecesMayor.Size = new System.Drawing.Size(100, 20);
            this.txtVecesMayor.TabIndex = 1;
            this.txtVecesMayor.Text = "0";
            // 
            // txtVecesMenor
            // 
            this.txtVecesMenor.Location = new System.Drawing.Point(26, 157);
            this.txtVecesMenor.Name = "txtVecesMenor";
            this.txtVecesMenor.Size = new System.Drawing.Size(100, 20);
            this.txtVecesMenor.TabIndex = 3;
            this.txtVecesMenor.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Veces Menor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Empezar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtVecesMenor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVecesMayor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVecesMayor;
        private System.Windows.Forms.TextBox txtVecesMenor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

