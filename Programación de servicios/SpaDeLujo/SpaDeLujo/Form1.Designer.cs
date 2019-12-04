namespace SpaDeLujo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Toalla");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Toalla");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Toalla");
            this.crono = new System.Windows.Forms.Timer(this.components);
            this.cbxDucha = new System.Windows.Forms.CheckBox();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.lvUsuarios = new System.Windows.Forms.ListView();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // crono
            // 
            this.crono.Tick += new System.EventHandler(this.Crono_Tick);
            // 
            // cbxDucha
            // 
            this.cbxDucha.AutoSize = true;
            this.cbxDucha.Location = new System.Drawing.Point(247, 57);
            this.cbxDucha.Name = "cbxDucha";
            this.cbxDucha.Size = new System.Drawing.Size(58, 17);
            this.cbxDucha.TabIndex = 0;
            this.cbxDucha.Text = "Ducha";
            this.cbxDucha.UseVisualStyleBackColor = true;
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(44, 35);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(51, 13);
            this.lblUsuarios.TabIndex = 1;
            this.lblUsuarios.Text = "Usuarios ";
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.Location = new System.Drawing.Point(47, 55);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarios.TabIndex = 2;
            // 
            // lvUsuarios
            // 
            this.lvUsuarios.HideSelection = false;
            this.lvUsuarios.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lvUsuarios.Location = new System.Drawing.Point(47, 81);
            this.lvUsuarios.Name = "lvUsuarios";
            this.lvUsuarios.Size = new System.Drawing.Size(237, 97);
            this.lvUsuarios.TabIndex = 3;
            this.lvUsuarios.UseCompatibleStateImageBehavior = false;
            this.lvUsuarios.View = System.Windows.Forms.View.List;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Location = new System.Drawing.Point(290, 81);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(104, 23);
            this.btnNuevoUsuario.TabIndex = 4;
            this.btnNuevoUsuario.Text = "Nuevo Usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.BtnNuevoUsuario_Click);
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(47, 195);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(237, 153);
            this.tbLog.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.lvUsuarios);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.cbxDucha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer crono;
        private System.Windows.Forms.CheckBox cbxDucha;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.ListView lvUsuarios;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.TextBox tbLog;
    }
}

