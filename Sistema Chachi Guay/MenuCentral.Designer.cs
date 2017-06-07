namespace Sistema_Chachi_Guay
{
    partial class MenuCentral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCentral));
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pic_series = new System.Windows.Forms.PictureBox();
            this.pic_peliculas = new System.Windows.Forms.PictureBox();
            this.pic_juegos = new System.Windows.Forms.PictureBox();
            this.pic_libros = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ajustes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_series)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_peliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_juegos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_libros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("French Script MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu Principal";
            // 
            // pic_series
            // 
            this.pic_series.Image = global::Sistema_Chachi_Guay.Properties.Resources.TV;
            this.pic_series.Location = new System.Drawing.Point(12, 302);
            this.pic_series.Name = "pic_series";
            this.pic_series.Size = new System.Drawing.Size(180, 180);
            this.pic_series.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_series.TabIndex = 3;
            this.pic_series.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_series, "Ver biblioteca de series");
            this.pic_series.Click += new System.EventHandler(this.pic_series_Click);
            // 
            // pic_peliculas
            // 
            this.pic_peliculas.Image = global::Sistema_Chachi_Guay.Properties.Resources.PopCorn;
            this.pic_peliculas.Location = new System.Drawing.Point(210, 67);
            this.pic_peliculas.Name = "pic_peliculas";
            this.pic_peliculas.Size = new System.Drawing.Size(180, 180);
            this.pic_peliculas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_peliculas.TabIndex = 2;
            this.pic_peliculas.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_peliculas, "Ver biblioteca de peliculas");
            // 
            // pic_juegos
            // 
            this.pic_juegos.Image = global::Sistema_Chachi_Guay.Properties.Resources.Games;
            this.pic_juegos.Location = new System.Drawing.Point(210, 302);
            this.pic_juegos.Name = "pic_juegos";
            this.pic_juegos.Size = new System.Drawing.Size(180, 180);
            this.pic_juegos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_juegos.TabIndex = 1;
            this.pic_juegos.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_juegos, "Ver biblioteca de juegos");
            // 
            // pic_libros
            // 
            this.pic_libros.Image = global::Sistema_Chachi_Guay.Properties.Resources.Book;
            this.pic_libros.Location = new System.Drawing.Point(12, 67);
            this.pic_libros.Name = "pic_libros";
            this.pic_libros.Size = new System.Drawing.Size(180, 180);
            this.pic_libros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_libros.TabIndex = 0;
            this.pic_libros.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_libros, "Ver biblioteca de libros");
            this.pic_libros.Click += new System.EventHandler(this.pic_libros_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Sistema_Chachi_Guay.Properties.Resources.Logout;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(269, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cerrar Sesion";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Sistema_Chachi_Guay.Properties.Resources.ajustes;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(139, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Configuracion";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ajustes
            // 
            this.btn_ajustes.Image = global::Sistema_Chachi_Guay.Properties.Resources.ajustes;
            this.btn_ajustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ajustes.Location = new System.Drawing.Point(12, 253);
            this.btn_ajustes.Name = "btn_ajustes";
            this.btn_ajustes.Size = new System.Drawing.Size(121, 43);
            this.btn_ajustes.TabIndex = 5;
            this.btn_ajustes.Text = "Configuracion";
            this.btn_ajustes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ajustes.UseVisualStyleBackColor = true;
            this.btn_ajustes.Click += new System.EventHandler(this.btn_ajustes_Click);
            // 
            // MenuCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(402, 494);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ajustes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_series);
            this.Controls.Add(this.pic_peliculas);
            this.Controls.Add(this.pic_juegos);
            this.Controls.Add(this.pic_libros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(418, 533);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(418, 533);
            this.Name = "MenuCentral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuCentral_FormClosing);
            this.Load += new System.EventHandler(this.MenuCentral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_series)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_peliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_juegos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_libros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_libros;
        private System.Windows.Forms.PictureBox pic_juegos;
        private System.Windows.Forms.PictureBox pic_peliculas;
        private System.Windows.Forms.PictureBox pic_series;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_ajustes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}