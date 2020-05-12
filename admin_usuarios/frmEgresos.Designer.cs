namespace admin_us
{
    partial class frmEgresos
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
            this.db_asiloDataSet = new admin_us.db_asiloDataSet();
            this.tbtipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_tipoTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_tipoTableAdapter();
            this.tb_salidasTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_salidasTableAdapter();
            this.tbsubtipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_subtipoTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_subtipoTableAdapter();
            this.tbobjetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_objetoTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_objetoTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Egreso = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.numeric_cantidad = new System.Windows.Forms.NumericUpDown();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.combo_producto = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.combo_subcategoria = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.combo_categoria = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.tbinventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_inventarioTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_inventarioTableAdapter();
            this.tb_reportesTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_reportesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_asiloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsubtipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbobjetoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.Panel_Egreso.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbinventarioBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // tb_salidasTableAdapter
            // 
            this.tb_salidasTableAdapter.ClearBeforeFill = true;
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
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(423, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 47;
            this.label8.Text = "SALIDAS";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Panel_Egreso);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 478);
            this.panel1.TabIndex = 48;
            // 
            // Panel_Egreso
            // 
            this.Panel_Egreso.AutoScroll = true;
            this.Panel_Egreso.AutoSize = true;
            this.Panel_Egreso.Controls.Add(this.panel2);
            this.Panel_Egreso.Controls.Add(this.panel14);
            this.Panel_Egreso.Controls.Add(this.panel10);
            this.Panel_Egreso.Controls.Add(this.panel8);
            this.Panel_Egreso.Controls.Add(this.panel5);
            this.Panel_Egreso.Controls.Add(this.panel6);
            this.Panel_Egreso.Location = new System.Drawing.Point(279, 66);
            this.Panel_Egreso.Name = "Panel_Egreso";
            this.Panel_Egreso.Size = new System.Drawing.Size(570, 400);
            this.Panel_Egreso.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lbl_stock);
            this.panel2.Location = new System.Drawing.Point(391, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 48);
            this.panel2.TabIndex = 52;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::admin_us.Properties.Resources.danger1;
            this.pictureBox2.Location = new System.Drawing.Point(4, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(215)))), ((int)(((byte)(116)))));
            this.lbl_stock.Location = new System.Drawing.Point(34, 8);
            this.lbl_stock.MaximumSize = new System.Drawing.Size(140, 50);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(111, 20);
            this.lbl_stock.TabIndex = 20;
            this.lbl_stock.Text = "En existencias";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Controls.Add(this.label7);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Location = new System.Drawing.Point(16, 256);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(369, 66);
            this.panel14.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(148, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Cantidad";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel15.Controls.Add(this.numeric_cantidad);
            this.panel15.Controls.Add(this.pictureBox8);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 30);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(369, 36);
            this.panel15.TabIndex = 0;
            // 
            // numeric_cantidad
            // 
            this.numeric_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numeric_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numeric_cantidad.Location = new System.Drawing.Point(38, 7);
            this.numeric_cantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numeric_cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_cantidad.Name = "numeric_cantidad";
            this.numeric_cantidad.Size = new System.Drawing.Size(326, 22);
            this.numeric_cantidad.TabIndex = 9;
            this.numeric_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::admin_us.Properties.Resources.pencil_6x;
            this.pictureBox8.Location = new System.Drawing.Point(4, 6);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(25, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 23;
            this.pictureBox8.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(16, 175);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(369, 66);
            this.panel10.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(148, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Producto";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel11.Controls.Add(this.pictureBox3);
            this.panel11.Controls.Add(this.combo_producto);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 30);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(369, 36);
            this.panel11.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::admin_us.Properties.Resources.pencil_6x;
            this.pictureBox3.Location = new System.Drawing.Point(4, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // combo_producto
            // 
            this.combo_producto.DisplayMember = "nombre";
            this.combo_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combo_producto.ForeColor = System.Drawing.Color.DimGray;
            this.combo_producto.FormattingEnabled = true;
            this.combo_producto.Items.AddRange(new object[] {
            "Compra",
            "Donación"});
            this.combo_producto.Location = new System.Drawing.Point(32, 4);
            this.combo_producto.Name = "combo_producto";
            this.combo_producto.Size = new System.Drawing.Size(332, 28);
            this.combo_producto.TabIndex = 22;
            this.combo_producto.ValueMember = "nombre";
            this.combo_producto.SelectedIndexChanged += new System.EventHandler(this.Combo_producto_SelectedIndexChanged);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(16, 94);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(369, 66);
            this.panel8.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(129, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Sub Categoria";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel9.Controls.Add(this.pictureBox1);
            this.panel9.Controls.Add(this.combo_subcategoria);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 30);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(369, 36);
            this.panel9.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::admin_us.Properties.Resources.pencil_6x;
            this.pictureBox1.Location = new System.Drawing.Point(4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // combo_subcategoria
            // 
            this.combo_subcategoria.DisplayMember = "nombre";
            this.combo_subcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_subcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combo_subcategoria.ForeColor = System.Drawing.Color.DimGray;
            this.combo_subcategoria.FormattingEnabled = true;
            this.combo_subcategoria.Items.AddRange(new object[] {
            "Compra",
            "Donación"});
            this.combo_subcategoria.Location = new System.Drawing.Point(32, 4);
            this.combo_subcategoria.Name = "combo_subcategoria";
            this.combo_subcategoria.Size = new System.Drawing.Size(332, 28);
            this.combo_subcategoria.TabIndex = 22;
            this.combo_subcategoria.ValueMember = "nombre";
            this.combo_subcategoria.SelectedIndexChanged += new System.EventHandler(this.combo_subcategoria_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(16, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 66);
            this.panel5.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(145, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Categoria";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.combo_categoria);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 30);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(369, 36);
            this.panel7.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::admin_us.Properties.Resources.pencil_6x;
            this.pictureBox5.Location = new System.Drawing.Point(4, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // combo_categoria
            // 
            this.combo_categoria.DataSource = this.tbtipoBindingSource;
            this.combo_categoria.DisplayMember = "nombre";
            this.combo_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combo_categoria.ForeColor = System.Drawing.Color.DimGray;
            this.combo_categoria.FormattingEnabled = true;
            this.combo_categoria.Location = new System.Drawing.Point(32, 4);
            this.combo_categoria.Name = "combo_categoria";
            this.combo_categoria.Size = new System.Drawing.Size(332, 28);
            this.combo_categoria.TabIndex = 22;
            this.combo_categoria.ValueMember = "nombre";
            this.combo_categoria.SelectedIndexChanged += new System.EventHandler(this.combo_categoria_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.btnRetirar);
            this.panel6.Location = new System.Drawing.Point(16, 342);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(369, 40);
            this.panel6.TabIndex = 41;
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(215)))), ((int)(((byte)(116)))));
            this.btnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.ForeColor = System.Drawing.Color.White;
            this.btnRetirar.Location = new System.Drawing.Point(127, 0);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(115, 40);
            this.btnRetirar.TabIndex = 12;
            this.btnRetirar.Text = "RETIRAR";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbinventarioBindingSource
            // 
            this.tbinventarioBindingSource.DataMember = "tb_inventario";
            this.tbinventarioBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // tb_inventarioTableAdapter
            // 
            this.tb_inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // tb_reportesTableAdapter
            // 
            this.tb_reportesTableAdapter.ClearBeforeFill = true;
            // 
            // frmEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 478);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEgresos";
            this.Text = "frmIngresos";
            this.Load += new System.EventHandler(this.frmIngresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_asiloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsubtipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbobjetoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel_Egreso.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbinventarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private db_asiloDataSet db_asiloDataSet;
        private System.Windows.Forms.BindingSource tbtipoBindingSource;
        private db_asiloDataSetTableAdapters.tb_tipoTableAdapter tb_tipoTableAdapter;
        private db_asiloDataSetTableAdapters.tb_salidasTableAdapter tb_salidasTableAdapter;
        private System.Windows.Forms.BindingSource tbsubtipoBindingSource;
        private db_asiloDataSetTableAdapters.tb_subtipoTableAdapter tb_subtipoTableAdapter;
        private System.Windows.Forms.BindingSource tbobjetoBindingSource;
        private db_asiloDataSetTableAdapters.tb_objetoTableAdapter tb_objetoTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_Egreso;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.NumericUpDown numeric_cantidad;
        internal System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel11;
        internal System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox combo_producto;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox combo_subcategoria;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        internal System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox combo_categoria;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.BindingSource tbinventarioBindingSource;
        private db_asiloDataSetTableAdapters.tb_inventarioTableAdapter tb_inventarioTableAdapter;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.PictureBox pictureBox2;
        private db_asiloDataSetTableAdapters.tb_reportesTableAdapter tb_reportesTableAdapter;
    }
}