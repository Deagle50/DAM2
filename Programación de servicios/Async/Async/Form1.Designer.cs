namespace Async
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
            this.btnDale1 = new System.Windows.Forms.Button();
            this.btnDale2 = new System.Windows.Forms.Button();
            this.btnDale3 = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lbxNumeros = new System.Windows.Forms.ListBox();
            this.btnPares = new System.Windows.Forms.Button();
            this.btnImpares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDale1
            // 
            this.btnDale1.Location = new System.Drawing.Point(12, 12);
            this.btnDale1.Name = "btnDale1";
            this.btnDale1.Size = new System.Drawing.Size(95, 23);
            this.btnDale1.TabIndex = 0;
            this.btnDale1.Text = "Dale";
            this.btnDale1.UseVisualStyleBackColor = true;
            this.btnDale1.Click += new System.EventHandler(this.BtnDale1_Click);
            // 
            // btnDale2
            // 
            this.btnDale2.Location = new System.Drawing.Point(12, 41);
            this.btnDale2.Name = "btnDale2";
            this.btnDale2.Size = new System.Drawing.Size(95, 23);
            this.btnDale2.TabIndex = 1;
            this.btnDale2.Text = "¡Dale otra vez!";
            this.btnDale2.UseVisualStyleBackColor = true;
            this.btnDale2.Click += new System.EventHandler(this.BtnDale2_Click);
            // 
            // btnDale3
            // 
            this.btnDale3.Location = new System.Drawing.Point(12, 70);
            this.btnDale3.Name = "btnDale3";
            this.btnDale3.Size = new System.Drawing.Size(95, 23);
            this.btnDale3.TabIndex = 2;
            this.btnDale3.Text = "¡Vuélvele a dar!";
            this.btnDale3.UseVisualStyleBackColor = true;
            this.btnDale3.Click += new System.EventHandler(this.BtnDale3_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(175, 15);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(100, 20);
            this.txtLog.TabIndex = 3;
            // 
            // lbxNumeros
            // 
            this.lbxNumeros.FormattingEnabled = true;
            this.lbxNumeros.Location = new System.Drawing.Point(175, 52);
            this.lbxNumeros.Name = "lbxNumeros";
            this.lbxNumeros.Size = new System.Drawing.Size(120, 95);
            this.lbxNumeros.TabIndex = 4;
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(12, 99);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(95, 23);
            this.btnPares.TabIndex = 5;
            this.btnPares.Text = "Pares";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.BtnNums_Click);
            // 
            // btnImpares
            // 
            this.btnImpares.Location = new System.Drawing.Point(12, 128);
            this.btnImpares.Name = "btnImpares";
            this.btnImpares.Size = new System.Drawing.Size(95, 23);
            this.btnImpares.TabIndex = 6;
            this.btnImpares.Text = "Impares";
            this.btnImpares.UseVisualStyleBackColor = true;
            this.btnImpares.Click += new System.EventHandler(this.BtnImpares_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImpares);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.lbxNumeros);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnDale3);
            this.Controls.Add(this.btnDale2);
            this.Controls.Add(this.btnDale1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDale1;
        private System.Windows.Forms.Button btnDale2;
        private System.Windows.Forms.Button btnDale3;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ListBox lbxNumeros;
        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.Button btnImpares;
    }
}

