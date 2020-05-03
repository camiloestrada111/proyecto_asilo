namespace admin_us
{
    partial class frmIngresos
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
            this.paneldonador = new System.Windows.Forms.Panel();
            this.db_asiloDataSet = new admin_us.db_asiloDataSet();
            this.tbtipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_tipoTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_tipoTableAdapter();
            this.tbingresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ingresosTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_ingresosTableAdapter();
            this.tbdonacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_donacionTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_donacionTableAdapter();
            this.tbsubtipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_subtipoTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_subtipoTableAdapter();
            this.tbobjetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_objetoTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_objetoTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox_tipoingreso = new System.Windows.Forms.ComboBox();
            this.panel_objetos = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboBox_objetos = new System.Windows.Forms.ComboBox();
            this.comboBox1_nombre = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_subtipos = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.comboBox_tipos = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.db_asiloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbingresosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdonacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsubtipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbobjetoBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_objetos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.comboBox1_nombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldonador
            // 
            this.paneldonador.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneldonador.Location = new System.Drawing.Point(670, 0);
            this.paneldonador.Name = "paneldonador";
            this.paneldonador.Size = new System.Drawing.Size(296, 601);
            this.paneldonador.TabIndex = 40;
            this.paneldonador.Visible = false;
            // 
            // db_asiloDataSet
            // 
            this.db_asiloDataSet.DataSetName = "db_asiloDataSet";
            this.db_asiloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbtipoBindingSource
            // 
            this.tbtipoBindingSource.DataMember = "tb_tipo";
            this.tbtipoBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // tb_tipoTableAdapter
            // 
            this.tb_tipoTableAdapter.ClearBeforeFill = true;
            // 
            // tbingresosBindingSource
            // 
            this.tbingresosBindingSource.DataMember = "tb_ingresos";
            this.tbingresosBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // tb_ingresosTableAdapter
            // 
            this.tb_ingresosTableAdapter.ClearBeforeFill = true;
            // 
            // tbdonacionBindingSource
            // 
            this.tbdonacionBindingSource.DataMember = "tb_donacion";
            this.tbdonacionBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // tb_donacionTableAdapter
            // 
            this.tb_donacionTableAdapter.ClearBeforeFill = true;
            // 
            // tbsubtipoBindingSource
            // 
            this.tbsubtipoBindingSource.DataMember = "tb_subtipo";
            this.tbsubtipoBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // tb_subtipoTableAdapter
            // 
            this.tb_subtipoTableAdapter.ClearBeforeFill = true;
            // 
            // tbobjetoBindingSource
            // 
            this.tbobjetoBindingSource.DataMember = "tb_objeto";
            this.tbobjetoBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // tb_objetoTableAdapter
            // 
            this.tb_objetoTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel_objetos);
            this.panel3.Controls.Add(this.comboBox1_nombre);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(201, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 388);
            this.panel3.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.comboBox_tipoingreso);
            this.panel1.Location = new System.Drawing.Point(71, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 44);
            this.panel1.TabIndex = 45;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::admin_us.Properties.Resources.pencil_6x;
            this.pictureBox2.Location = new System.Drawing.Point(6, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox_tipoingreso
            // 
            this.comboBox_tipoingreso.DisplayMember = "nombre";
            this.comboBox_tipoingreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipoingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_tipoingreso.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_tipoingreso.FormattingEnabled = true;
            this.comboBox_tipoingreso.Items.AddRange(new object[] {
            "Compra",
            "Donación"});
            this.comboBox_tipoingreso.Location = new System.Drawing.Point(34, 8);
            this.comboBox_tipoingreso.Name = "comboBox_tipoingreso";
            this.comboBox_tipoingreso.Size = new System.Drawing.Size(332, 28);
            this.comboBox_tipoingreso.TabIndex = 20;
            this.comboBox_tipoingreso.ValueMember = "nombre";
            // 
            // panel_objetos
            // 
            this.panel_objetos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel_objetos.Controls.Add(this.pictureBox3);
            this.panel_objetos.Controls.Add(this.comboBox_objetos);
            this.panel_objetos.Location = new System.Drawing.Point(71, 200);
            this.panel_objetos.Name = "panel_objetos";
            this.panel_objetos.Size = new System.Drawing.Size(369, 44);
            this.panel_objetos.TabIndex = 44;
            this.panel_objetos.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::admin_us.Properties.Resources.pencil_6x;
            this.pictureBox3.Location = new System.Drawing.Point(5, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // comboBox_objetos
            // 
            this.comboBox_objetos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_objetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_objetos.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_objetos.FormattingEnabled = true;
            this.comboBox_objetos.Location = new System.Drawing.Point(34, 8);
            this.comboBox_objetos.Name = "comboBox_objetos";
            this.comboBox_objetos.Size = new System.Drawing.Size(332, 28);
            this.comboBox_objetos.TabIndex = 20;
            // 
            // comboBox1_nombre
            // 
            this.comboBox1_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.comboBox1_nombre.Controls.Add(this.pictureBox1);
            this.comboBox1_nombre.Controls.Add(this.comboBox_subtipos);
            this.comboBox1_nombre.Location = new System.Drawing.Point(72, 139);
            this.comboBox1_nombre.Name = "comboBox1_nombre";
            this.comboBox1_nombre.Size = new System.Drawing.Size(369, 44);
            this.comboBox1_nombre.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::admin_us.Properties.Resources.pencil_6x;
            this.pictureBox1.Location = new System.Drawing.Point(5, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_subtipos
            // 
            this.comboBox_subtipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_subtipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_subtipos.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_subtipos.FormattingEnabled = true;
            this.comboBox_subtipos.Location = new System.Drawing.Point(34, 8);
            this.comboBox_subtipos.Name = "comboBox_subtipos";
            this.comboBox_subtipos.Size = new System.Drawing.Size(332, 28);
            this.comboBox_subtipos.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.comboBox_tipos);
            this.panel7.Location = new System.Drawing.Point(71, 78);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(369, 44);
            this.panel7.TabIndex = 42;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::admin_us.Properties.Resources.pencil_6x;
            this.pictureBox5.Location = new System.Drawing.Point(6, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // comboBox_tipos
            // 
            this.comboBox_tipos.DataSource = this.tbobjetoBindingSource;
            this.comboBox_tipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_tipos.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_tipos.FormattingEnabled = true;
            this.comboBox_tipos.Location = new System.Drawing.Point(34, 8);
            this.comboBox_tipos.Name = "comboBox_tipos";
            this.comboBox_tipos.Size = new System.Drawing.Size(332, 28);
            this.comboBox_tipos.TabIndex = 20;
            this.comboBox_tipos.ValueMember = "nombre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.PictureBox4);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Location = new System.Drawing.Point(71, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 44);
            this.panel2.TabIndex = 40;
            // 
            // PictureBox4
            // 
            this.PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox4.Image = global::admin_us.Properties.Resources.pencil_6x;
            this.PictureBox4.Location = new System.Drawing.Point(6, 10);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(25, 25);
            this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox4.TabIndex = 8;
            this.PictureBox4.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(37, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(302, 19);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Cantidad";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.btnAgregar);
            this.panel6.Location = new System.Drawing.Point(71, 334);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(369, 40);
            this.panel6.TabIndex = 41;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(215)))), ((int)(((byte)(116)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(127, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 40);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // frmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 601);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.paneldonador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngresos";
            this.Text = "frmIngresos";
            this.Load += new System.EventHandler(this.frmIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_asiloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbingresosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdonacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsubtipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbobjetoBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_objetos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.comboBox1_nombre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel paneldonador;
        private db_asiloDataSet db_asiloDataSet;
        private System.Windows.Forms.BindingSource tbtipoBindingSource;
        private db_asiloDataSetTableAdapters.tb_tipoTableAdapter tb_tipoTableAdapter;
        private System.Windows.Forms.BindingSource tbingresosBindingSource;
        private db_asiloDataSetTableAdapters.tb_ingresosTableAdapter tb_ingresosTableAdapter;
        private System.Windows.Forms.BindingSource tbdonacionBindingSource;
        private db_asiloDataSetTableAdapters.tb_donacionTableAdapter tb_donacionTableAdapter;
        private System.Windows.Forms.BindingSource tbsubtipoBindingSource;
        private db_asiloDataSetTableAdapters.tb_subtipoTableAdapter tb_subtipoTableAdapter;
        private System.Windows.Forms.BindingSource tbobjetoBindingSource;
        private db_asiloDataSetTableAdapters.tb_objetoTableAdapter tb_objetoTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox_tipoingreso;
        private System.Windows.Forms.Panel panel_objetos;
        internal System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboBox_objetos;
        private System.Windows.Forms.Panel comboBox1_nombre;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_subtipos;
        private System.Windows.Forms.Panel panel7;
        internal System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox comboBox_tipos;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.PictureBox PictureBox4;
        internal System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Button btnAgregar;
    }
}