namespace PipesRepaso2
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
            this.lblVMenor = new System.Windows.Forms.Label();
            this.txtVMenor = new System.Windows.Forms.TextBox();
            this.lblVMayor = new System.Windows.Forms.Label();
            this.txtVMayor = new System.Windows.Forms.TextBox();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVMenor
            // 
            this.lblVMenor.AutoSize = true;
            this.lblVMenor.Location = new System.Drawing.Point(12, 9);
            this.lblVMenor.Name = "lblVMenor";
            this.lblVMenor.Size = new System.Drawing.Size(69, 13);
            this.lblVMenor.TabIndex = 0;
            this.lblVMenor.Text = "Veces menor";
            // 
            // txtVMenor
            // 
            this.txtVMenor.Location = new System.Drawing.Point(15, 25);
            this.txtVMenor.Name = "txtVMenor";
            this.txtVMenor.Size = new System.Drawing.Size(100, 20);
            this.txtVMenor.TabIndex = 1;
            // 
            // lblVMayor
            // 
            this.lblVMayor.AutoSize = true;
            this.lblVMayor.Location = new System.Drawing.Point(12, 48);
            this.lblVMayor.Name = "lblVMayor";
            this.lblVMayor.Size = new System.Drawing.Size(68, 13);
            this.lblVMayor.TabIndex = 2;
            this.lblVMayor.Text = "Veces mayor";
            // 
            // txtVMayor
            // 
            this.txtVMayor.Location = new System.Drawing.Point(15, 64);
            this.txtVMayor.Name = "txtVMayor";
            this.txtVMayor.Size = new System.Drawing.Size(100, 20);
            this.txtVMayor.TabIndex = 3;
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(15, 90);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpezar.TabIndex = 4;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.BtnEmpezar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.txtVMayor);
            this.Controls.Add(this.lblVMayor);
            this.Controls.Add(this.txtVMenor);
            this.Controls.Add(this.lblVMenor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVMenor;
        private System.Windows.Forms.TextBox txtVMenor;
        private System.Windows.Forms.Label lblVMayor;
        private System.Windows.Forms.TextBox txtVMayor;
        private System.Windows.Forms.Button btnEmpezar;
    }
}

