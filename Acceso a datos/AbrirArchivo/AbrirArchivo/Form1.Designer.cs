namespace AbrirArchivo
{
    partial class AbrirArchivo
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSeleccionarArchivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(239, 3);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(89, 23);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.Text = "Selecccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(797, 418);
            this.textBox1.TabIndex = 1;
            // 
            // txtSeleccionarArchivo
            // 
            this.txtSeleccionarArchivo.Location = new System.Drawing.Point(3, 6);
            this.txtSeleccionarArchivo.Name = "txtSeleccionarArchivo";
            this.txtSeleccionarArchivo.Size = new System.Drawing.Size(230, 20);
            this.txtSeleccionarArchivo.TabIndex = 2;
            this.txtSeleccionarArchivo.TextChanged += new System.EventHandler(this.TxtSeleccionarArchivo_TextChanged);
            // 
            // AbrirArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSeleccionarArchivo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSeleccionar);
            this.Name = "AbrirArchivo";
            this.Text = "AbrirArchivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSeleccionarArchivo;
    }
}

