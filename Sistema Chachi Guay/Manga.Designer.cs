namespace Sistema_Chachi_Guay
{
    partial class Manga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manga));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grillaMangas = new System.Windows.Forms.DataGridView();
            this.idMangaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinopsisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lanzamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tomosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.idGeneroMangaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otrosGenerosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idestadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vMangaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_bibliotecaDataSet1 = new Sistema_Chachi_Guay.bd_bibliotecaDataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_sinopsis = new System.Windows.Forms.TextBox();
            this.txt_generos = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pic_imagen = new System.Windows.Forms.PictureBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tomos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_Lanzamiento = new System.Windows.Forms.DateTimePicker();
            this.comboGeneros = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vMangaTableAdapter = new Sistema_Chachi_Guay.bd_bibliotecaDataSet1TableAdapters.vMangaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMangas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMangaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_bibliotecaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Sinopsis : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("French Script MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 55);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mangas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grillaMangas
            // 
            this.grillaMangas.AllowUserToAddRows = false;
            this.grillaMangas.AllowUserToDeleteRows = false;
            this.grillaMangas.AutoGenerateColumns = false;
            this.grillaMangas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaMangas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMangaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.sinopsisDataGridViewTextBoxColumn,
            this.lanzamientoDataGridViewTextBoxColumn,
            this.tomosDataGridViewTextBoxColumn,
            this.imagenDataGridViewImageColumn,
            this.idGeneroMangaDataGridViewTextBoxColumn,
            this.otrosGenerosDataGridViewTextBoxColumn,
            this.idestadoDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nickDataGridViewTextBoxColumn});
            this.grillaMangas.DataSource = this.vMangaBindingSource;
            this.grillaMangas.Location = new System.Drawing.Point(12, 12);
            this.grillaMangas.Name = "grillaMangas";
            this.grillaMangas.ReadOnly = true;
            this.grillaMangas.Size = new System.Drawing.Size(270, 680);
            this.grillaMangas.TabIndex = 22;
            this.grillaMangas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaMangas_CellClick);
            // 
            // idMangaDataGridViewTextBoxColumn
            // 
            this.idMangaDataGridViewTextBoxColumn.DataPropertyName = "id_Manga";
            this.idMangaDataGridViewTextBoxColumn.HeaderText = "id_Manga";
            this.idMangaDataGridViewTextBoxColumn.Name = "idMangaDataGridViewTextBoxColumn";
            this.idMangaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMangaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sinopsisDataGridViewTextBoxColumn
            // 
            this.sinopsisDataGridViewTextBoxColumn.DataPropertyName = "Sinopsis";
            this.sinopsisDataGridViewTextBoxColumn.HeaderText = "Sinopsis";
            this.sinopsisDataGridViewTextBoxColumn.Name = "sinopsisDataGridViewTextBoxColumn";
            this.sinopsisDataGridViewTextBoxColumn.ReadOnly = true;
            this.sinopsisDataGridViewTextBoxColumn.Visible = false;
            // 
            // lanzamientoDataGridViewTextBoxColumn
            // 
            this.lanzamientoDataGridViewTextBoxColumn.DataPropertyName = "Lanzamiento";
            this.lanzamientoDataGridViewTextBoxColumn.HeaderText = "Lanzamiento";
            this.lanzamientoDataGridViewTextBoxColumn.Name = "lanzamientoDataGridViewTextBoxColumn";
            this.lanzamientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.lanzamientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // tomosDataGridViewTextBoxColumn
            // 
            this.tomosDataGridViewTextBoxColumn.DataPropertyName = "Tomos";
            this.tomosDataGridViewTextBoxColumn.HeaderText = "Tomos";
            this.tomosDataGridViewTextBoxColumn.Name = "tomosDataGridViewTextBoxColumn";
            this.tomosDataGridViewTextBoxColumn.ReadOnly = true;
            this.tomosDataGridViewTextBoxColumn.Visible = false;
            // 
            // imagenDataGridViewImageColumn
            // 
            this.imagenDataGridViewImageColumn.DataPropertyName = "Imagen";
            this.imagenDataGridViewImageColumn.HeaderText = "Imagen";
            this.imagenDataGridViewImageColumn.Name = "imagenDataGridViewImageColumn";
            this.imagenDataGridViewImageColumn.ReadOnly = true;
            this.imagenDataGridViewImageColumn.Visible = false;
            // 
            // idGeneroMangaDataGridViewTextBoxColumn
            // 
            this.idGeneroMangaDataGridViewTextBoxColumn.DataPropertyName = "id_GeneroManga";
            this.idGeneroMangaDataGridViewTextBoxColumn.HeaderText = "id_GeneroManga";
            this.idGeneroMangaDataGridViewTextBoxColumn.Name = "idGeneroMangaDataGridViewTextBoxColumn";
            this.idGeneroMangaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idGeneroMangaDataGridViewTextBoxColumn.Visible = false;
            // 
            // otrosGenerosDataGridViewTextBoxColumn
            // 
            this.otrosGenerosDataGridViewTextBoxColumn.DataPropertyName = "Otros_Generos";
            this.otrosGenerosDataGridViewTextBoxColumn.HeaderText = "Otros_Generos";
            this.otrosGenerosDataGridViewTextBoxColumn.Name = "otrosGenerosDataGridViewTextBoxColumn";
            this.otrosGenerosDataGridViewTextBoxColumn.ReadOnly = true;
            this.otrosGenerosDataGridViewTextBoxColumn.Visible = false;
            // 
            // idestadoDataGridViewTextBoxColumn
            // 
            this.idestadoDataGridViewTextBoxColumn.DataPropertyName = "id_estado";
            this.idestadoDataGridViewTextBoxColumn.HeaderText = "id_estado";
            this.idestadoDataGridViewTextBoxColumn.Name = "idestadoDataGridViewTextBoxColumn";
            this.idestadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idestadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "id_Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "id_Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // nickDataGridViewTextBoxColumn
            // 
            this.nickDataGridViewTextBoxColumn.DataPropertyName = "Nick";
            this.nickDataGridViewTextBoxColumn.HeaderText = "Nick";
            this.nickDataGridViewTextBoxColumn.Name = "nickDataGridViewTextBoxColumn";
            this.nickDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vMangaBindingSource
            // 
            this.vMangaBindingSource.DataMember = "vManga";
            this.vMangaBindingSource.DataSource = this.bd_bibliotecaDataSet1;
            // 
            // bd_bibliotecaDataSet1
            // 
            this.bd_bibliotecaDataSet1.DataSetName = "bd_bibliotecaDataSet1";
            this.bd_bibliotecaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Genero Principal :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Estado :";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(380, 79);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(211, 20);
            this.txt_nombre.TabIndex = 34;
            // 
            // txt_sinopsis
            // 
            this.txt_sinopsis.Enabled = false;
            this.txt_sinopsis.Location = new System.Drawing.Point(380, 105);
            this.txt_sinopsis.Multiline = true;
            this.txt_sinopsis.Name = "txt_sinopsis";
            this.txt_sinopsis.Size = new System.Drawing.Size(211, 268);
            this.txt_sinopsis.TabIndex = 35;
            // 
            // txt_generos
            // 
            this.txt_generos.Enabled = false;
            this.txt_generos.Location = new System.Drawing.Point(380, 458);
            this.txt_generos.Name = "txt_generos";
            this.txt_generos.Size = new System.Drawing.Size(211, 20);
            this.txt_generos.TabIndex = 38;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.LightBlue;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_edit.FlatAppearance.BorderSize = 3;
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(12, 698);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(60, 60);
            this.btn_edit.TabIndex = 41;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.LightBlue;
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_new.FlatAppearance.BorderSize = 3;
            this.btn_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Location = new System.Drawing.Point(78, 698);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(138, 60);
            this.btn_new.TabIndex = 42;
            this.btn_new.Text = "Agregar Manga";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightBlue;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_delete.FlatAppearance.BorderSize = 3;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(222, 698);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(60, 60);
            this.btn_delete.TabIndex = 43;
            this.btn_delete.Text = "Borrar";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // pic_imagen
            // 
            this.pic_imagen.Location = new System.Drawing.Point(288, 511);
            this.pic_imagen.Name = "pic_imagen";
            this.pic_imagen.Size = new System.Drawing.Size(303, 247);
            this.pic_imagen.TabIndex = 44;
            this.pic_imagen.TabStop = false;
            this.pic_imagen.Click += new System.EventHandler(this.pic_imagen_Click);
            // 
            // comboEstado
            // 
            this.comboEstado.Enabled = false;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(380, 484);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(211, 21);
            this.comboEstado.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tomos : ";
            // 
            // txt_tomos
            // 
            this.txt_tomos.Enabled = false;
            this.txt_tomos.Location = new System.Drawing.Point(380, 405);
            this.txt_tomos.Name = "txt_tomos";
            this.txt_tomos.Size = new System.Drawing.Size(211, 20);
            this.txt_tomos.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Lanzado :";
            // 
            // date_Lanzamiento
            // 
            this.date_Lanzamiento.Enabled = false;
            this.date_Lanzamiento.Location = new System.Drawing.Point(380, 379);
            this.date_Lanzamiento.Name = "date_Lanzamiento";
            this.date_Lanzamiento.Size = new System.Drawing.Size(211, 20);
            this.date_Lanzamiento.TabIndex = 48;
            // 
            // comboGeneros
            // 
            this.comboGeneros.Enabled = false;
            this.comboGeneros.FormattingEnabled = true;
            this.comboGeneros.Location = new System.Drawing.Point(380, 431);
            this.comboGeneros.Name = "comboGeneros";
            this.comboGeneros.Size = new System.Drawing.Size(211, 21);
            this.comboGeneros.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Otros Generos :";
            // 
            // vMangaTableAdapter
            // 
            this.vMangaTableAdapter.ClearBeforeFill = true;
            // 
            // Manga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 770);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboGeneros);
            this.Controls.Add(this.date_Lanzamiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.pic_imagen);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_tomos);
            this.Controls.Add(this.txt_generos);
            this.Controls.Add(this.txt_sinopsis);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaMangas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manga";
            this.Load += new System.EventHandler(this.Manga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaMangas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMangaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_bibliotecaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaMangas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_sinopsis;
        private System.Windows.Forms.TextBox txt_generos;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.PictureBox pic_imagen;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tomos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_Lanzamiento;
        private System.Windows.Forms.ComboBox comboGeneros;
        private System.Windows.Forms.Label label8;
        private bd_bibliotecaDataSet1 bd_bibliotecaDataSet1;
        private System.Windows.Forms.BindingSource vMangaBindingSource;
        private bd_bibliotecaDataSet1TableAdapters.vMangaTableAdapter vMangaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMangaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinopsisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanzamientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tomosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGeneroMangaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otrosGenerosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickDataGridViewTextBoxColumn;
    }
}