namespace Enunciado5Servidor
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
            this.lblContador = new System.Windows.Forms.Label();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.lblCadena = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(21, 38);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(50, 13);
            this.lblContador.TabIndex = 10;
            this.lblContador.Text = "Contador";
            // 
            // txtContador
            // 
            this.txtContador.Location = new System.Drawing.Point(21, 54);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(100, 20);
            this.txtContador.TabIndex = 11;
            // 
            // lblCadena
            // 
            this.lblCadena.AutoSize = true;
            this.lblCadena.Location = new System.Drawing.Point(21, 86);
            this.lblCadena.Name = "lblCadena";
            this.lblCadena.Size = new System.Drawing.Size(44, 13);
            this.lblCadena.TabIndex = 12;
            this.lblCadena.Text = "Cadena";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(21, 102);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(100, 20);
            this.txtCadena.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 165);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.lblCadena);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.lblContador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Label lblCadena;
        private System.Windows.Forms.TextBox txtCadena;
    }
}

