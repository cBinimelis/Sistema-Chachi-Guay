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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_sinopsis = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pic_imagen = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bd_bibliotecaDataSet = new Sistema_Chachi_Guay.bd_bibliotecaDataSet();
            this.bdbibliotecaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mangaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mangaTableAdapter = new Sistema_Chachi_Guay.bd_bibliotecaDataSetTableAdapters.MangaTableAdapter();
            this.idMangaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinopsisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lanzamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tomosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idestadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_bibliotecaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdbibliotecaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Nota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tomos: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Sinopsis : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("French Script MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 55);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mangas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMangaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.sinopsisDataGridViewTextBoxColumn,
            this.lanzamientoDataGridViewTextBoxColumn,
            this.tomosDataGridViewTextBoxColumn,
            this.idestadoDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mangaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(270, 456);
            this.dataGridView1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Genero:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Estado:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(390, 79);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(180, 20);
            this.txt_nombre.TabIndex = 34;
            // 
            // txt_sinopsis
            // 
            this.txt_sinopsis.Enabled = false;
            this.txt_sinopsis.Location = new System.Drawing.Point(390, 105);
            this.txt_sinopsis.Multiline = true;
            this.txt_sinopsis.Name = "txt_sinopsis";
            this.txt_sinopsis.Size = new System.Drawing.Size(180, 69);
            this.txt_sinopsis.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(390, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 36;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(390, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 20);
            this.textBox3.TabIndex = 38;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(390, 180);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 20);
            this.textBox4.TabIndex = 39;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(12, 474);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(60, 60);
            this.btn_edit.TabIndex = 41;
            this.btn_edit.Text = "button1";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(78, 474);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(138, 60);
            this.btn_new.TabIndex = 42;
            this.btn_new.Text = "button2";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(222, 474);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(60, 60);
            this.btn_delete.TabIndex = 43;
            this.btn_delete.Text = "button3";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // pic_imagen
            // 
            this.pic_imagen.Location = new System.Drawing.Point(326, 286);
            this.pic_imagen.Name = "pic_imagen";
            this.pic_imagen.Size = new System.Drawing.Size(244, 248);
            this.pic_imagen.TabIndex = 44;
            this.pic_imagen.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(390, 234);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 45;
            // 
            // bd_bibliotecaDataSet
            // 
            this.bd_bibliotecaDataSet.DataSetName = "bd_bibliotecaDataSet";
            this.bd_bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdbibliotecaDataSetBindingSource
            // 
            this.bdbibliotecaDataSetBindingSource.DataSource = this.bd_bibliotecaDataSet;
            this.bdbibliotecaDataSetBindingSource.Position = 0;
            // 
            // mangaBindingSource
            // 
            this.mangaBindingSource.DataMember = "Manga";
            this.mangaBindingSource.DataSource = this.bd_bibliotecaDataSet;
            // 
            // mangaTableAdapter
            // 
            this.mangaTableAdapter.ClearBeforeFill = true;
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
            this.nombreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // Manga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 546);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pic_imagen);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_sinopsis);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manga";
            this.Load += new System.EventHandler(this.Manga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_bibliotecaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdbibliotecaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_sinopsis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.PictureBox pic_imagen;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource bdbibliotecaDataSetBindingSource;
        private bd_bibliotecaDataSet bd_bibliotecaDataSet;
        private System.Windows.Forms.BindingSource mangaBindingSource;
        private bd_bibliotecaDataSetTableAdapters.MangaTableAdapter mangaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMangaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinopsisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanzamientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tomosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
    }
}