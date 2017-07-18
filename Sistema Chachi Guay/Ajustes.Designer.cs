namespace Sistema_Chachi_Guay
{
    partial class Ajustes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajustes));
            this.pic_AjusteUsuario = new System.Windows.Forms.PictureBox();
            this.pic_AjusteTipo = new System.Windows.Forms.PictureBox();
            this.pic_AjusteExtras = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pic_AjusteGenero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AjusteUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AjusteTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AjusteExtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AjusteGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_AjusteUsuario
            // 
            this.pic_AjusteUsuario.Location = new System.Drawing.Point(19, 40);
            this.pic_AjusteUsuario.Name = "pic_AjusteUsuario";
            this.pic_AjusteUsuario.Size = new System.Drawing.Size(178, 159);
            this.pic_AjusteUsuario.TabIndex = 0;
            this.pic_AjusteUsuario.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_AjusteUsuario, "Ajustes de usuarios");
            this.pic_AjusteUsuario.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pic_AjusteTipo
            // 
            this.pic_AjusteTipo.Location = new System.Drawing.Point(207, 40);
            this.pic_AjusteTipo.Name = "pic_AjusteTipo";
            this.pic_AjusteTipo.Size = new System.Drawing.Size(171, 159);
            this.pic_AjusteTipo.TabIndex = 1;
            this.pic_AjusteTipo.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_AjusteTipo, "Ajustes de tipos y estados");
            this.pic_AjusteTipo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pic_AjusteExtras
            // 
            this.pic_AjusteExtras.Location = new System.Drawing.Point(200, 295);
            this.pic_AjusteExtras.Name = "pic_AjusteExtras";
            this.pic_AjusteExtras.Size = new System.Drawing.Size(178, 167);
            this.pic_AjusteExtras.TabIndex = 2;
            this.pic_AjusteExtras.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_AjusteExtras, "Ajustes de sagas, calificaciones y mensajes");
            this.pic_AjusteExtras.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Configuraciones";
            // 
            // pic_AjusteGenero
            // 
            this.pic_AjusteGenero.Location = new System.Drawing.Point(19, 295);
            this.pic_AjusteGenero.Name = "pic_AjusteGenero";
            this.pic_AjusteGenero.Size = new System.Drawing.Size(171, 167);
            this.pic_AjusteGenero.TabIndex = 4;
            this.pic_AjusteGenero.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_AjusteGenero, "Ajuste de genero");
            // 
            // Ajustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(402, 494);
            this.Controls.Add(this.pic_AjusteGenero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_AjusteExtras);
            this.Controls.Add(this.pic_AjusteTipo);
            this.Controls.Add(this.pic_AjusteUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(418, 533);
            this.MinimumSize = new System.Drawing.Size(418, 533);
            this.Name = "Ajustes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            ((System.ComponentModel.ISupportInitialize)(this.pic_AjusteUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AjusteTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AjusteExtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AjusteGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_AjusteUsuario;
        private System.Windows.Forms.PictureBox pic_AjusteTipo;
        private System.Windows.Forms.PictureBox pic_AjusteExtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pic_AjusteGenero;
    }
}