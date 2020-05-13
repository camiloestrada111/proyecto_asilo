namespace admin_us
{
    partial class frmReportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_busqueda = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_cat = new System.Windows.Forms.ComboBox();
            this.db_asiloDataSet = new admin_us.db_asiloDataSet();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.combo_subtipos = new System.Windows.Forms.ComboBox();
            this.combo_tipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_fechaHASTA = new System.Windows.Forms.DateTimePicker();
            this.date_fechaDESDE = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_tiempo = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tb_inventarioDataGridView = new System.Windows.Forms.DataGridView();
            this.tb_tipoTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_tipoTableAdapter();
            this.tb_subtipoTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_subtipoTableAdapter();
            this.tb_reportesTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_reportesTableAdapter();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbMostrarReportesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbtipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_reportesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new admin_us.db_asiloDataSetTableAdapters.TableAdapterManager();
            this.tb_Mostrar_ReportesTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_Mostrar_ReportesTableAdapter();
            this.panel25.SuspendLayout();
            this.panel_busqueda.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_asiloDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_inventarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMostrarReportesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_reportesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.label3);
            this.panel25.Controls.Add(this.panel_busqueda);
            this.panel25.Controls.Add(this.label4);
            this.panel25.Controls.Add(this.checkBox1);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel25.Location = new System.Drawing.Point(0, 0);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(1006, 164);
            this.panel25.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(461, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Reportes";
            // 
            // panel_busqueda
            // 
            this.panel_busqueda.Controls.Add(this.panel3);
            this.panel_busqueda.Controls.Add(this.panel1);
            this.panel_busqueda.Controls.Add(this.combo_tiempo);
            this.panel_busqueda.Controls.Add(this.checkBox2);
            this.panel_busqueda.Controls.Add(this.label1);
            this.panel_busqueda.Location = new System.Drawing.Point(132, 66);
            this.panel_busqueda.Name = "panel_busqueda";
            this.panel_busqueda.Size = new System.Drawing.Size(840, 92);
            this.panel_busqueda.TabIndex = 34;
            this.panel_busqueda.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.combo_cat);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.combo_subtipos);
            this.panel3.Controls.Add(this.combo_tipo);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.checkBox4);
            this.panel3.Location = new System.Drawing.Point(359, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 92);
            this.panel3.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Location = new System.Drawing.Point(129, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 75);
            this.panel7.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(3, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 75);
            this.panel5.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(162, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Categoría";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(38, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 38;
            this.label6.Text = "Por Tipo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // combo_cat
            // 
            this.combo_cat.DataSource = this.tbtipoBindingSource;
            this.combo_cat.DisplayMember = "nombre";
            this.combo_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cat.Enabled = false;
            this.combo_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combo_cat.ForeColor = System.Drawing.Color.DimGray;
            this.combo_cat.FormattingEnabled = true;
            this.combo_cat.Location = new System.Drawing.Point(275, 25);
            this.combo_cat.Name = "combo_cat";
            this.combo_cat.Size = new System.Drawing.Size(193, 28);
            this.combo_cat.TabIndex = 43;
            this.combo_cat.ValueMember = "nombre";
            this.combo_cat.SelectedIndexChanged += new System.EventHandler(this.Combo_cat_SelectedIndexChanged);
            // 
            // db_asiloDataSet
            // 
            this.db_asiloDataSet.DataSetName = "db_asiloDataSet";
            this.db_asiloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox3.Location = new System.Drawing.Point(17, 11);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 39;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // combo_subtipos
            // 
            this.combo_subtipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_subtipos.Enabled = false;
            this.combo_subtipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_subtipos.ForeColor = System.Drawing.Color.DimGray;
            this.combo_subtipos.FormattingEnabled = true;
            this.combo_subtipos.Location = new System.Drawing.Point(275, 61);
            this.combo_subtipos.Name = "combo_subtipos";
            this.combo_subtipos.Size = new System.Drawing.Size(193, 28);
            this.combo_subtipos.TabIndex = 44;
            this.combo_subtipos.SelectedIndexChanged += new System.EventHandler(this.Combo_subtipos_SelectedIndexChanged);
            // 
            // combo_tipo
            // 
            this.combo_tipo.DisplayMember = "nombre";
            this.combo_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tipo.Enabled = false;
            this.combo_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combo_tipo.ForeColor = System.Drawing.Color.DimGray;
            this.combo_tipo.FormattingEnabled = true;
            this.combo_tipo.Items.AddRange(new object[] {
            "Entradas",
            "Salidas"});
            this.combo_tipo.Location = new System.Drawing.Point(17, 35);
            this.combo_tipo.Name = "combo_tipo";
            this.combo_tipo.Size = new System.Drawing.Size(103, 28);
            this.combo_tipo.TabIndex = 40;
            this.combo_tipo.ValueMember = "nombre";
            this.combo_tipo.SelectedIndexChanged += new System.EventHandler(this.Combo_tipo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(162, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Subcategoría";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(162, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 41;
            this.label7.Text = "Por Categoría";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox4.Location = new System.Drawing.Point(141, 11);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 42;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.date_fechaHASTA);
            this.panel1.Controls.Add(this.date_fechaDESDE);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(167, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 92);
            this.panel1.TabIndex = 37;
            this.panel1.Visible = false;
            // 
            // date_fechaHASTA
            // 
            this.date_fechaHASTA.CalendarForeColor = System.Drawing.Color.DimGray;
            this.date_fechaHASTA.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.date_fechaHASTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.date_fechaHASTA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_fechaHASTA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.date_fechaHASTA.Location = new System.Drawing.Point(58, 51);
            this.date_fechaHASTA.Name = "date_fechaHASTA";
            this.date_fechaHASTA.Size = new System.Drawing.Size(120, 26);
            this.date_fechaHASTA.TabIndex = 52;
            this.date_fechaHASTA.Value = new System.DateTime(2020, 5, 13, 0, 0, 0, 0);
            // 
            // date_fechaDESDE
            // 
            this.date_fechaDESDE.CalendarForeColor = System.Drawing.Color.DimGray;
            this.date_fechaDESDE.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.date_fechaDESDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.date_fechaDESDE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_fechaDESDE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.date_fechaDESDE.Location = new System.Drawing.Point(58, 8);
            this.date_fechaDESDE.Name = "date_fechaDESDE";
            this.date_fechaDESDE.Size = new System.Drawing.Size(119, 26);
            this.date_fechaDESDE.TabIndex = 51;
            this.date_fechaDESDE.Value = new System.DateTime(2020, 5, 13, 0, 0, 0, 0);
            this.date_fechaDESDE.ValueChanged += new System.EventHandler(this.Date_fechaDESDE_ValueChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(-1, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Hasta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Desde";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // combo_tiempo
            // 
            this.combo_tiempo.DisplayMember = "nombre";
            this.combo_tiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_tiempo.Enabled = false;
            this.combo_tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combo_tiempo.ForeColor = System.Drawing.Color.DimGray;
            this.combo_tiempo.FormattingEnabled = true;
            this.combo_tiempo.Items.AddRange(new object[] {
            "Último mes",
            "Última semana",
            "Seleccionar fecha"});
            this.combo_tiempo.Location = new System.Drawing.Point(6, 35);
            this.combo_tiempo.Name = "combo_tiempo";
            this.combo_tiempo.Size = new System.Drawing.Size(155, 28);
            this.combo_tiempo.TabIndex = 36;
            this.combo_tiempo.ValueMember = "nombre";
            this.combo_tiempo.SelectedIndexChanged += new System.EventHandler(this.ComboBox_tipos_SelectedIndexChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox2.Location = new System.Drawing.Point(6, 11);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 35;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(27, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Por Tiempo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(21, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 40);
            this.label4.TabIndex = 33;
            this.label4.Text = "Activar Búsqueda";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox1.Location = new System.Drawing.Point(57, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 519);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(889, 164);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(117, 519);
            this.panel4.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(147, 653);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(742, 30);
            this.panel6.TabIndex = 6;
            // 
            // tb_inventarioDataGridView
            // 
            this.tb_inventarioDataGridView.AllowUserToAddRows = false;
            this.tb_inventarioDataGridView.AllowUserToDeleteRows = false;
            this.tb_inventarioDataGridView.AllowUserToOrderColumns = true;
            this.tb_inventarioDataGridView.AutoGenerateColumns = false;
            this.tb_inventarioDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.tb_inventarioDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_inventarioDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tb_inventarioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tb_inventarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_inventarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.subcategoriaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.tb_inventarioDataGridView.DataSource = this.tbMostrarReportesBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tb_inventarioDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.tb_inventarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_inventarioDataGridView.EnableHeadersVisualStyles = false;
            this.tb_inventarioDataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.tb_inventarioDataGridView.Location = new System.Drawing.Point(147, 164);
            this.tb_inventarioDataGridView.Name = "tb_inventarioDataGridView";
            this.tb_inventarioDataGridView.ReadOnly = true;
            this.tb_inventarioDataGridView.Size = new System.Drawing.Size(742, 489);
            this.tb_inventarioDataGridView.TabIndex = 7;
            // 
            // tb_tipoTableAdapter
            // 
            this.tb_tipoTableAdapter.ClearBeforeFill = true;
            // 
            // tb_subtipoTableAdapter
            // 
            this.tb_subtipoTableAdapter.ClearBeforeFill = true;
            // 
            // tb_reportesTableAdapter
            // 
            this.tb_reportesTableAdapter.ClearBeforeFill = true;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subcategoriaDataGridViewTextBoxColumn
            // 
            this.subcategoriaDataGridViewTextBoxColumn.DataPropertyName = "Subcategoria";
            this.subcategoriaDataGridViewTextBoxColumn.HeaderText = "Subcategoria";
            this.subcategoriaDataGridViewTextBoxColumn.Name = "subcategoriaDataGridViewTextBoxColumn";
            this.subcategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbMostrarReportesBindingSource
            // 
            this.tbMostrarReportesBindingSource.DataMember = "tb_Mostrar_Reportes";
            this.tbMostrarReportesBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // tbtipoBindingSource
            // 
            this.tbtipoBindingSource.DataMember = "tb_tipo";
            this.tbtipoBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // tb_reportesBindingSource
            // 
            this.tb_reportesBindingSource.DataMember = "tb_reportes";
            this.tb_reportesBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tb_bodegaTableAdapter = null;
            this.tableAdapterManager.tb_donacionTableAdapter = null;
            this.tableAdapterManager.tb_ingresosTableAdapter = null;
            this.tableAdapterManager.tb_inventarioTableAdapter = null;
            this.tableAdapterManager.tb_objetoTableAdapter = null;
            this.tableAdapterManager.tb_reportesTableAdapter = null;
            this.tableAdapterManager.tb_salidasTableAdapter = null;
            this.tableAdapterManager.tb_subtipoTableAdapter = null;
            this.tableAdapterManager.tb_tipoTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = admin_us.db_asiloDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_Mostrar_ReportesTableAdapter
            // 
            this.tb_Mostrar_ReportesTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 683);
            this.Controls.Add(this.tb_inventarioDataGridView);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel25);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel_busqueda.ResumeLayout(false);
            this.panel_busqueda.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_asiloDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_inventarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMostrarReportesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_reportesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView tb_inventarioDataGridView;
        private db_asiloDataSet db_asiloDataSet;
        private System.Windows.Forms.BindingSource tbMostrarReportesBindingSource;
        private db_asiloDataSetTableAdapters.tb_Mostrar_ReportesTableAdapter tb_Mostrar_ReportesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel_busqueda;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_tiempo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo_tipo;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_fechaHASTA;
        private System.Windows.Forms.DateTimePicker date_fechaDESDE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_cat;
        private System.Windows.Forms.ComboBox combo_subtipos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private db_asiloDataSetTableAdapters.tb_tipoTableAdapter tb_tipoTableAdapter;
        private db_asiloDataSetTableAdapters.tb_subtipoTableAdapter tb_subtipoTableAdapter;
        private System.Windows.Forms.BindingSource tb_reportesBindingSource;
        private db_asiloDataSetTableAdapters.tb_reportesTableAdapter tb_reportesTableAdapter;
        private System.Windows.Forms.BindingSource tbtipoBindingSource;
        private db_asiloDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}