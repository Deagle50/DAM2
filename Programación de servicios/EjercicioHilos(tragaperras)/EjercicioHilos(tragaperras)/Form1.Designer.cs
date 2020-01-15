namespace EjercicioHilos_tragaperras_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.btnParar1 = new System.Windows.Forms.Button();
            this.btnParar2 = new System.Windows.Forms.Button();
            this.btnParar3 = new System.Windows.Forms.Button();
            this.tbPalanca = new System.Windows.Forms.TrackBar();
            this.listaImg = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPalanca)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx1
            // 
            this.pbx1.Image = global::EjercicioHilos_tragaperras_.Properties.Resources.Uva;
            this.pbx1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbx1.InitialImage")));
            this.pbx1.Location = new System.Drawing.Point(12, 12);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(495, 508);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            // 
            // pbx2
            // 
            this.pbx2.Image = global::EjercicioHilos_tragaperras_.Properties.Resources.Uva;
            this.pbx2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbx2.InitialImage")));
            this.pbx2.Location = new System.Drawing.Point(513, 12);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(495, 508);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 1;
            this.pbx2.TabStop = false;
            // 
            // pbx3
            // 
            this.pbx3.Image = global::EjercicioHilos_tragaperras_.Properties.Resources.Uva;
            this.pbx3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbx3.InitialImage")));
            this.pbx3.Location = new System.Drawing.Point(1014, 12);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(495, 508);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 2;
            this.pbx3.TabStop = false;
            // 
            // btnParar1
            // 
            this.btnParar1.Enabled = false;
            this.btnParar1.Location = new System.Drawing.Point(219, 526);
            this.btnParar1.Name = "btnParar1";
            this.btnParar1.Size = new System.Drawing.Size(75, 23);
            this.btnParar1.TabIndex = 3;
            this.btnParar1.Text = "Parar";
            this.btnParar1.UseVisualStyleBackColor = true;
            // 
            // btnParar2
            // 
            this.btnParar2.Enabled = false;
            this.btnParar2.Location = new System.Drawing.Point(729, 526);
            this.btnParar2.Name = "btnParar2";
            this.btnParar2.Size = new System.Drawing.Size(75, 23);
            this.btnParar2.TabIndex = 4;
            this.btnParar2.Text = "Parar";
            this.btnParar2.UseVisualStyleBackColor = true;
            // 
            // btnParar3
            // 
            this.btnParar3.Enabled = false;
            this.btnParar3.Location = new System.Drawing.Point(1235, 526);
            this.btnParar3.Name = "btnParar3";
            this.btnParar3.Size = new System.Drawing.Size(75, 23);
            this.btnParar3.TabIndex = 5;
            this.btnParar3.Text = "Parar";
            this.btnParar3.UseVisualStyleBackColor = true;
            // 
            // tbPalanca
            // 
            this.tbPalanca.Location = new System.Drawing.Point(1545, 214);
            this.tbPalanca.Name = "tbPalanca";
            this.tbPalanca.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbPalanca.Size = new System.Drawing.Size(45, 104);
            this.tbPalanca.TabIndex = 6;
            this.tbPalanca.Value = 10;
            this.tbPalanca.ValueChanged += new System.EventHandler(this.TbPalanca_ValueChanged);
            // 
            // listaImg
            // 
            this.listaImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaImg.ImageStream")));
            this.listaImg.TransparentColor = System.Drawing.Color.Transparent;
            this.listaImg.Images.SetKeyName(0, "7.png");
            this.listaImg.Images.SetKeyName(1, "Campana.png");
            this.listaImg.Images.SetKeyName(2, "Cereza.png");
            this.listaImg.Images.SetKeyName(3, "Diamante.png");
            this.listaImg.Images.SetKeyName(4, "Fresa.png");
            this.listaImg.Images.SetKeyName(5, "Limon.png");
            this.listaImg.Images.SetKeyName(6, "Naranja.png");
            this.listaImg.Images.SetKeyName(7, "Sandia.png");
            this.listaImg.Images.SetKeyName(8, "Uva.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 629);
            this.Controls.Add(this.tbPalanca);
            this.Controls.Add(this.btnParar3);
            this.Controls.Add(this.btnParar2);
            this.Controls.Add(this.btnParar1);
            this.Controls.Add(this.pbx3);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.pbx1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPalanca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.Button btnParar1;
        private System.Windows.Forms.Button btnParar2;
        private System.Windows.Forms.Button btnParar3;
        private System.Windows.Forms.TrackBar tbPalanca;
        private System.Windows.Forms.ImageList listaImg;
    }
}

