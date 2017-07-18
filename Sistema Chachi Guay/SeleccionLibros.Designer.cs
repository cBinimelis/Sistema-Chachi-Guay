namespace Sistema_Chachi_Guay
{
    partial class SeleccionLibros
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionLibros));
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pic_libros = new System.Windows.Forms.PictureBox();
            this.pic_manga = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_manga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Que tipo de libro?";
            // 
            // pic_libros
            // 
            this.pic_libros.Image = global::Sistema_Chachi_Guay.Properties.Resources.d815c1d4_e06a_4201_a2c5_2213b9494c94;
            this.pic_libros.Location = new System.Drawing.Point(12, 286);
            this.pic_libros.Name = "pic_libros";
            this.pic_libros.Size = new System.Drawing.Size(378, 196);
            this.pic_libros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_libros.TabIndex = 1;
            this.pic_libros.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_libros, "No tiene dibujitos");
            this.pic_libros.Click += new System.EventHandler(this.pic_libros_Click);
            // 
            // pic_manga
            // 
            this.pic_manga.Image = global::Sistema_Chachi_Guay.Properties.Resources.tumblr_mefszuAhUE1qky197o1_500;
            this.pic_manga.Location = new System.Drawing.Point(12, 12);
            this.pic_manga.Name = "pic_manga";
            this.pic_manga.Size = new System.Drawing.Size(378, 212);
            this.pic_manga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_manga.TabIndex = 0;
            this.pic_manga.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_manga, "Tiene dibujitos");
            this.pic_manga.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SeleccionLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(402, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_libros);
            this.Controls.Add(this.pic_manga);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(418, 533);
            this.MinimumSize = new System.Drawing.Size(418, 533);
            this.Name = "SeleccionLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionLibros";
            ((System.ComponentModel.ISupportInitialize)(this.pic_libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_manga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_manga;
        private System.Windows.Forms.PictureBox pic_libros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}