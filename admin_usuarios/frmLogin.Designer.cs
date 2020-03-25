namespace admin_us
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tbusuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbasiloDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_asiloDataSet = new admin_us.db_asiloDataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picContra = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_usuarioTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_usuarioTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbusuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbasiloDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_asiloDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(177)))), ((int)(((byte)(247)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 18);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Valken", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(104, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre de Usuario";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnAceptar);
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 432);
            this.panel3.TabIndex = 19;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tbusuarioBindingSource;
            this.comboBox2.DisplayMember = "usuario";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Valken", 12F);
            this.comboBox2.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(31, 191);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(308, 28);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.ValueMember = "usuario";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.txtContra_TextChanged);
            // 
            // tbusuarioBindingSource
            // 
            this.tbusuarioBindingSource.DataMember = "tb_usuario";
            this.tbusuarioBindingSource.DataSource = this.dbasiloDataSetBindingSource;
            // 
            // dbasiloDataSetBindingSource
            // 
            this.dbasiloDataSetBindingSource.DataSource = this.db_asiloDataSet;
            this.dbasiloDataSetBindingSource.Position = 0;
            // 
            // db_asiloDataSet
            // 
            this.db_asiloDataSet.DataSetName = "db_asiloDataSet";
            this.db_asiloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel4.Controls.Add(this.picContra);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.txtContra);
            this.panel4.Location = new System.Drawing.Point(31, 235);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 40);
            this.panel4.TabIndex = 21;
            // 
            // picContra
            // 
            this.picContra.BackColor = System.Drawing.Color.Transparent;
            this.picContra.Image = global::admin_us.Properties.Resources.oculta;
            this.picContra.Location = new System.Drawing.Point(277, 7);
            this.picContra.Name = "picContra";
            this.picContra.Size = new System.Drawing.Size(25, 25);
            this.picContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContra.TabIndex = 9;
            this.picContra.TabStop = false;
            this.picContra.Visible = false;
            this.picContra.Click += new System.EventHandler(this.picContra_Click);
            this.picContra.MouseLeave += new System.EventHandler(this.picContra_MouseLeave);
            this.picContra.MouseHover += new System.EventHandler(this.picContra_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::admin_us.Properties.Resources.key_6x;
            this.pictureBox3.Location = new System.Drawing.Point(3, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContra.Font = new System.Drawing.Font("Valken", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.ForeColor = System.Drawing.Color.DimGray;
            this.txtContra.Location = new System.Drawing.Point(37, 9);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(234, 20);
            this.txtContra.TabIndex = 1;
            this.txtContra.Text = "Contraseña";
            this.txtContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContra.Click += new System.EventHandler(this.txtContra_Click);
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            this.txtContra.Leave += new System.EventHandler(this.txtContra_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(215)))), ((int)(((byte)(116)))));
            this.btnAceptar.Enabled = false;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Valken", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(31, 291);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(308, 40);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "INGRESAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Valken", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(31, 347);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(308, 40);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::admin_us.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(127, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // tb_usuarioTableAdapter
            // 
            this.tb_usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbusuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbasiloDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_asiloDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.PictureBox picContra;
        internal System.Windows.Forms.PictureBox pictureBox3;
        internal System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource dbasiloDataSetBindingSource;
        private db_asiloDataSet db_asiloDataSet;
        private System.Windows.Forms.BindingSource tbusuarioBindingSource;
        private db_asiloDataSetTableAdapters.tb_usuarioTableAdapter tb_usuarioTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}