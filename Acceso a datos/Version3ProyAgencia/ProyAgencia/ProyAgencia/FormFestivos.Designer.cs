namespace ProyAgencia
{
    partial class FormFestivos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.calFiestas = new System.Windows.Forms.MonthCalendar();
            this.cmdEnviar = new System.Windows.Forms.Button();
            this.panelFiestas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdEliminar.Location = new System.Drawing.Point(349, 510);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(110, 23);
            this.cmdEliminar.TabIndex = 12;
            this.cmdEliminar.Text = "Eliminar controles";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // calFiestas
            // 
            this.calFiestas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calFiestas.CalendarDimensions = new System.Drawing.Size(2, 3);
            this.calFiestas.Location = new System.Drawing.Point(310, 29);
            this.calFiestas.Margin = new System.Windows.Forms.Padding(7);
            this.calFiestas.Name = "calFiestas";
            this.calFiestas.TabIndex = 10;
            this.calFiestas.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calFiestas_DateSelected);
            // 
            // cmdEnviar
            // 
            this.cmdEnviar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdEnviar.Location = new System.Drawing.Point(246, 510);
            this.cmdEnviar.Name = "cmdEnviar";
            this.cmdEnviar.Size = new System.Drawing.Size(97, 23);
            this.cmdEnviar.TabIndex = 14;
            this.cmdEnviar.Text = "Enviar cambios";
            this.cmdEnviar.UseVisualStyleBackColor = true;
            this.cmdEnviar.Click += new System.EventHandler(this.cmdEnviar_Click);
            // 
            // panelFiestas
            // 
            this.panelFiestas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelFiestas.AutoScroll = true;
            this.panelFiestas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFiestas.Location = new System.Drawing.Point(12, 29);
            this.panelFiestas.Name = "panelFiestas";
            this.panelFiestas.Size = new System.Drawing.Size(280, 460);
            this.panelFiestas.TabIndex = 15;
            this.panelFiestas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFiestas_Paint);
            // 
            // FormFestivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 545);
            this.Controls.Add(this.panelFiestas);
            this.Controls.Add(this.cmdEnviar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.calFiestas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFestivos";
            this.Text = "FormFestivos";
            this.Load += new System.EventHandler(this.FormFestivos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.MonthCalendar calFiestas;
        private System.Windows.Forms.Button cmdEnviar;
        private System.Windows.Forms.Panel panelFiestas;
    }
}