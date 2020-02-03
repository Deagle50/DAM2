namespace LectoresEscritores
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
            this.lblPosicion = new System.Windows.Forms.Label();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.lblContenido = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.lvDatos = new System.Windows.Forms.ListView();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.chPosicion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chContenido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(12, 9);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(47, 13);
            this.lblPosicion.TabIndex = 0;
            this.lblPosicion.Text = "Posición";
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(80, 6);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(100, 20);
            this.txtPosicion.TabIndex = 1;
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(12, 43);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 2;
            this.lblContenido.Text = "Contenido";
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(80, 40);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(100, 20);
            this.txtContenido.TabIndex = 3;
            // 
            // lvDatos
            // 
            this.lvDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPosicion,
            this.chContenido});
            this.lvDatos.HideSelection = false;
            this.lvDatos.Location = new System.Drawing.Point(186, 6);
            this.lvDatos.Name = "lvDatos";
            this.lvDatos.Size = new System.Drawing.Size(179, 153);
            this.lvDatos.TabIndex = 4;
            this.lvDatos.UseCompatibleStateImageBehavior = false;
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(15, 102);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 5;
            this.btnEscribir.Text = "Escribir dato";
            this.btnEscribir.UseVisualStyleBackColor = true;
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(15, 131);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 6;
            this.btnParar.Text = "Parar escritor";
            this.btnParar.UseVisualStyleBackColor = true;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(186, 165);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 7;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            // 
            // chPosicion
            // 
            this.chPosicion.Text = "Posición";
            // 
            // chContenido
            // 
            this.chContenido.Text = "chContenido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.lvDatos);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.lblPosicion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.ListView lvDatos;
        private System.Windows.Forms.ColumnHeader chPosicion;
        private System.Windows.Forms.ColumnHeader chContenido;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnLeer;
    }
}

