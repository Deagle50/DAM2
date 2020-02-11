namespace Enunciado3
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
            this.LabelHost = new System.Windows.Forms.Label();
            this.TextBoxHost = new System.Windows.Forms.TextBox();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelHost
            // 
            this.LabelHost.AutoSize = true;
            this.LabelHost.Location = new System.Drawing.Point(40, 32);
            this.LabelHost.Name = "LabelHost";
            this.LabelHost.Size = new System.Drawing.Size(29, 13);
            this.LabelHost.TabIndex = 0;
            this.LabelHost.Text = "Host";
            // 
            // TextBoxHost
            // 
            this.TextBoxHost.Location = new System.Drawing.Point(43, 48);
            this.TextBoxHost.Name = "TextBoxHost";
            this.TextBoxHost.Size = new System.Drawing.Size(168, 20);
            this.TextBoxHost.TabIndex = 1;
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(217, 48);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(65, 20);
            this.buttonConectar.TabIndex = 2;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.ButtonConectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConectar);
            this.Controls.Add(this.TextBoxHost);
            this.Controls.Add(this.LabelHost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHost;
        private System.Windows.Forms.TextBox TextBoxHost;
        private System.Windows.Forms.Button buttonConectar;
    }
}

