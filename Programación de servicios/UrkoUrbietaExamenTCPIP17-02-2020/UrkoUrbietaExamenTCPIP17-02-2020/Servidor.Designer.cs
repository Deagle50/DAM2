namespace UrkoUrbietaExamenTCPIP17_02_2020
{
    partial class frmServidor
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
            this.labelIP = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxSocket = new System.Windows.Forms.TextBox();
            this.labelSocket = new System.Windows.Forms.Label();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.labelCliente = new System.Windows.Forms.Label();
            this.listViewDatos = new System.Windows.Forms.ListView();
            this.columnHeaderPosicion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(12, 9);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(17, 13);
            this.labelIP.TabIndex = 0;
            this.labelIP.Text = "IP";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(12, 25);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 1;
            // 
            // textBoxSocket
            // 
            this.textBoxSocket.Location = new System.Drawing.Point(12, 64);
            this.textBoxSocket.Name = "textBoxSocket";
            this.textBoxSocket.Size = new System.Drawing.Size(100, 20);
            this.textBoxSocket.TabIndex = 3;
            // 
            // labelSocket
            // 
            this.labelSocket.AutoSize = true;
            this.labelSocket.Location = new System.Drawing.Point(12, 48);
            this.labelSocket.Name = "labelSocket";
            this.labelSocket.Size = new System.Drawing.Size(41, 13);
            this.labelSocket.TabIndex = 2;
            this.labelSocket.Text = "Socket";
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(163, 64);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(75, 20);
            this.buttonConectar.TabIndex = 4;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.ButtonConectar_Click);
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(12, 309);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(225, 13);
            this.labelCliente.TabIndex = 5;
            this.labelCliente.Text = "El cliente que más nombres ha mandado es: X";
            // 
            // listViewDatos
            // 
            this.listViewDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPosicion,
            this.columnHeaderNombre});
            this.listViewDatos.HideSelection = false;
            this.listViewDatos.Location = new System.Drawing.Point(12, 90);
            this.listViewDatos.Name = "listViewDatos";
            this.listViewDatos.Size = new System.Drawing.Size(226, 216);
            this.listViewDatos.TabIndex = 6;
            this.listViewDatos.UseCompatibleStateImageBehavior = false;
            this.listViewDatos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPosicion
            // 
            this.columnHeaderPosicion.Text = "Posición";
            this.columnHeaderPosicion.Width = 104;
            // 
            // columnHeaderNombre
            // 
            this.columnHeaderNombre.Text = "Nombre";
            this.columnHeaderNombre.Width = 118;
            // 
            // frmServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewDatos);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.buttonConectar);
            this.Controls.Add(this.textBoxSocket);
            this.Controls.Add(this.labelSocket);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.labelIP);
            this.Name = "frmServidor";
            this.Text = "Servidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxSocket;
        private System.Windows.Forms.Label labelSocket;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.ListView listViewDatos;
        private System.Windows.Forms.ColumnHeader columnHeaderPosicion;
        private System.Windows.Forms.ColumnHeader columnHeaderNombre;
    }
}

