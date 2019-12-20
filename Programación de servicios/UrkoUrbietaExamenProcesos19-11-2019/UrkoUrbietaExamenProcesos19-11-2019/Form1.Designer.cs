namespace UrkoUrbietaExamenProcesos19_11_2019
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
            this.lvFechas = new System.Windows.Forms.ListView();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.cbxLuz = new System.Windows.Forms.CheckBox();
            this.lblProximoEncendido = new System.Windows.Forms.Label();
            this.txtProximoEncendido = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.chÑapa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvFechas
            // 
            this.lvFechas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chÑapa,
            this.chHora,
            this.chAccion});
            this.lvFechas.HideSelection = false;
            this.lvFechas.Location = new System.Drawing.Point(12, 38);
            this.lvFechas.Name = "lvFechas";
            this.lvFechas.Size = new System.Drawing.Size(305, 105);
            this.lvFechas.TabIndex = 0;
            this.lvFechas.UseCompatibleStateImageBehavior = false;
            this.lvFechas.View = System.Windows.Forms.View.Details;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(12, 22);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(44, 13);
            this.lblHistorial.TabIndex = 1;
            this.lblHistorial.Text = "Historial";
            // 
            // cbxLuz
            // 
            this.cbxLuz.AutoSize = true;
            this.cbxLuz.Location = new System.Drawing.Point(326, 38);
            this.cbxLuz.Name = "cbxLuz";
            this.cbxLuz.Size = new System.Drawing.Size(43, 17);
            this.cbxLuz.TabIndex = 2;
            this.cbxLuz.Text = "Luz";
            this.cbxLuz.UseVisualStyleBackColor = true;
            // 
            // lblProximoEncendido
            // 
            this.lblProximoEncendido.AutoSize = true;
            this.lblProximoEncendido.Location = new System.Drawing.Point(323, 78);
            this.lblProximoEncendido.Name = "lblProximoEncendido";
            this.lblProximoEncendido.Size = new System.Drawing.Size(97, 13);
            this.lblProximoEncendido.TabIndex = 3;
            this.lblProximoEncendido.Text = "Próximo encendido";
            // 
            // txtProximoEncendido
            // 
            this.txtProximoEncendido.Location = new System.Drawing.Point(326, 94);
            this.txtProximoEncendido.Name = "txtProximoEncendido";
            this.txtProximoEncendido.Size = new System.Drawing.Size(188, 20);
            this.txtProximoEncendido.TabIndex = 4;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(326, 120);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // chÑapa
            // 
            this.chÑapa.Text = "Hora";
            this.chÑapa.Width = 0;
            // 
            // chHora
            // 
            this.chHora.Text = "Hora";
            this.chHora.Width = 145;
            // 
            // chAccion
            // 
            this.chAccion.Text = "Acción";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtProximoEncendido);
            this.Controls.Add(this.lblProximoEncendido);
            this.Controls.Add(this.cbxLuz);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.lvFechas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFechas;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.CheckBox cbxLuz;
        private System.Windows.Forms.Label lblProximoEncendido;
        private System.Windows.Forms.TextBox txtProximoEncendido;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ColumnHeader chÑapa;
        private System.Windows.Forms.ColumnHeader chHora;
        private System.Windows.Forms.ColumnHeader chAccion;
    }
}

