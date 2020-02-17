namespace Cliente
{
    partial class frmCliente
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
            this.buttonConectar = new System.Windows.Forms.Button();
            this.textBoxSocket = new System.Windows.Forms.TextBox();
            this.labelSocket = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.textBoxPalabra = new System.Windows.Forms.TextBox();
            this.labelPalabra = new System.Windows.Forms.Label();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.listViewDatos = new System.Windows.Forms.ListView();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(163, 64);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(75, 20);
            this.buttonConectar.TabIndex = 9;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.ButtonConectar_Click);
            // 
            // textBoxSocket
            // 
            this.textBoxSocket.Location = new System.Drawing.Point(12, 64);
            this.textBoxSocket.Name = "textBoxSocket";
            this.textBoxSocket.Size = new System.Drawing.Size(100, 20);
            this.textBoxSocket.TabIndex = 8;
            // 
            // labelSocket
            // 
            this.labelSocket.AutoSize = true;
            this.labelSocket.Location = new System.Drawing.Point(12, 48);
            this.labelSocket.Name = "labelSocket";
            this.labelSocket.Size = new System.Drawing.Size(41, 13);
            this.labelSocket.TabIndex = 7;
            this.labelSocket.Text = "Socket";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(12, 25);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 6;
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(12, 9);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(17, 13);
            this.labelIP.TabIndex = 5;
            this.labelIP.Text = "IP";
            // 
            // textBoxPalabra
            // 
            this.textBoxPalabra.Location = new System.Drawing.Point(12, 126);
            this.textBoxPalabra.Name = "textBoxPalabra";
            this.textBoxPalabra.Size = new System.Drawing.Size(100, 20);
            this.textBoxPalabra.TabIndex = 10;
            // 
            // labelPalabra
            // 
            this.labelPalabra.AutoSize = true;
            this.labelPalabra.Location = new System.Drawing.Point(12, 110);
            this.labelPalabra.Name = "labelPalabra";
            this.labelPalabra.Size = new System.Drawing.Size(43, 13);
            this.labelPalabra.TabIndex = 11;
            this.labelPalabra.Text = "Palabra";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(163, 126);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviar.TabIndex = 12;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.ButtonEnviar_Click);
            // 
            // listViewDatos
            // 
            this.listViewDatos.HideSelection = false;
            this.listViewDatos.Location = new System.Drawing.Point(12, 152);
            this.listViewDatos.Name = "listViewDatos";
            this.listViewDatos.Size = new System.Drawing.Size(121, 97);
            this.listViewDatos.TabIndex = 13;
            this.listViewDatos.UseCompatibleStateImageBehavior = false;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(160, 152);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(189, 13);
            this.labelCantidad.TabIndex = 14;
            this.labelCantidad.Text = "Quedan x palabras para llenar el buffer";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.listViewDatos);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.labelPalabra);
            this.Controls.Add(this.textBoxPalabra);
            this.Controls.Add(this.buttonConectar);
            this.Controls.Add(this.textBoxSocket);
            this.Controls.Add(this.labelSocket);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.labelIP);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.TextBox textBoxSocket;
        private System.Windows.Forms.Label labelSocket;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textBoxPalabra;
        private System.Windows.Forms.Label labelPalabra;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.ListView listViewDatos;
        private System.Windows.Forms.Label labelCantidad;
    }
}

