namespace Pipería_ProyectoChat_
{
    partial class frmPrincipal
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblUltimo = new System.Windows.Forms.Label();
            this.lblMensajesRecibidos = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtUltimo = new System.Windows.Forms.TextBox();
            this.lbxMensajesRecibidos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(12, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(47, 13);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Mensaje";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(15, 25);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(100, 20);
            this.txtMensaje.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(231, 25);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // lblUltimo
            // 
            this.lblUltimo.AutoSize = true;
            this.lblUltimo.Location = new System.Drawing.Point(12, 76);
            this.lblUltimo.Name = "lblUltimo";
            this.lblUltimo.Size = new System.Drawing.Size(118, 13);
            this.lblUltimo.TabIndex = 3;
            this.lblUltimo.Text = "Último mensaje recibido";
            // 
            // lblMensajesRecibidos
            // 
            this.lblMensajesRecibidos.AutoSize = true;
            this.lblMensajesRecibidos.Location = new System.Drawing.Point(12, 177);
            this.lblMensajesRecibidos.Name = "lblMensajesRecibidos";
            this.lblMensajesRecibidos.Size = new System.Drawing.Size(102, 13);
            this.lblMensajesRecibidos.TabIndex = 5;
            this.lblMensajesRecibidos.Text = "Mensajes Recibidos";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(231, 274);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(83, 23);
            this.btnDesconectar.TabIndex = 6;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.BtnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(231, 245);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(83, 23);
            this.btnConectar.TabIndex = 7;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // txtUltimo
            // 
            this.txtUltimo.Location = new System.Drawing.Point(15, 92);
            this.txtUltimo.Name = "txtUltimo";
            this.txtUltimo.Size = new System.Drawing.Size(100, 20);
            this.txtUltimo.TabIndex = 8;
            // 
            // lbxMensajesRecibidos
            // 
            this.lbxMensajesRecibidos.FormattingEnabled = true;
            this.lbxMensajesRecibidos.Location = new System.Drawing.Point(15, 202);
            this.lbxMensajesRecibidos.Name = "lbxMensajesRecibidos";
            this.lbxMensajesRecibidos.Size = new System.Drawing.Size(120, 95);
            this.lbxMensajesRecibidos.TabIndex = 9;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxMensajesRecibidos);
            this.Controls.Add(this.txtUltimo);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblMensajesRecibidos);
            this.Controls.Add(this.lblUltimo);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lblMensaje);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblUltimo;
        private System.Windows.Forms.Label lblMensajesRecibidos;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtUltimo;
        private System.Windows.Forms.ListBox lbxMensajesRecibidos;
    }
}

