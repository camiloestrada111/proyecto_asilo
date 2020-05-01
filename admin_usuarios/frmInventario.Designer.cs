namespace admin_us
{
    partial class frmInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_inventarioDataGridView = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbMostrarInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_asiloDataSet = new admin_us.db_asiloDataSet();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel_busqueda = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_tipos = new System.Windows.Forms.ComboBox();
            this.tbtipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combo_subtipos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tb_inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_inventarioTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_inventarioTableAdapter();
            this.tableAdapterManager = new admin_us.db_asiloDataSetTableAdapters.TableAdapterManager();
            this.tb_Mostrar_InventarioTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_Mostrar_InventarioTableAdapter();
            this.tb_subtipoTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_subtipoTableAdapter();
            this.tb_tipoTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_tipoTableAdapter();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_inventarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMostrarInventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_asiloDataSet)).BeginInit();
            this.panel25.SuspendLayout();
            this.panel_busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_inventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel25);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 640);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tb_inventarioDataGridView);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(157, 147);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(695, 493);
            this.panel5.TabIndex = 4;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tb_inventarioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tb_inventarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_inventarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.subcategoriaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.tb_inventarioDataGridView.DataSource = this.tbMostrarInventarioBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tb_inventarioDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tb_inventarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_inventarioDataGridView.EnableHeadersVisualStyles = false;
            this.tb_inventarioDataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.tb_inventarioDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tb_inventarioDataGridView.Name = "tb_inventarioDataGridView";
            this.tb_inventarioDataGridView.ReadOnly = true;
            this.tb_inventarioDataGridView.Size = new System.Drawing.Size(695, 463);
            this.tb_inventarioDataGridView.TabIndex = 3;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No_";
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
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            this.pesoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbMostrarInventarioBindingSource
            // 
            this.tbMostrarInventarioBindingSource.DataMember = "tb_Mostrar_Inventario";
            this.tbMostrarInventarioBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // db_asiloDataSet
            // 
            this.db_asiloDataSet.DataSetName = "db_asiloDataSet";
            this.db_asiloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 463);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(695, 30);
            this.panel6.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 493);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(852, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 493);
            this.panel4.TabIndex = 2;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.panel_busqueda);
            this.panel25.Controls.Add(this.label4);
            this.panel25.Controls.Add(this.checkBox1);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel25.Location = new System.Drawing.Point(0, 0);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(982, 147);
            this.panel25.TabIndex = 1;
            // 
            // panel_busqueda
            // 
            this.panel_busqueda.Controls.Add(this.label1);
            this.panel_busqueda.Controls.Add(this.comboBox_tipos);
            this.panel_busqueda.Controls.Add(this.combo_subtipos);
            this.panel_busqueda.Controls.Add(this.label2);
            this.panel_busqueda.Location = new System.Drawing.Point(148, 78);
            this.panel_busqueda.Name = "panel_busqueda";
            this.panel_busqueda.Size = new System.Drawing.Size(704, 60);
            this.panel_busqueda.TabIndex = 34;
            this.panel_busqueda.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Categoria";
            // 
            // comboBox_tipos
            // 
            this.comboBox_tipos.DataSource = this.tbtipoBindingSource;
            this.comboBox_tipos.DisplayMember = "nombre";
            this.comboBox_tipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_tipos.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_tipos.FormattingEnabled = true;
            this.comboBox_tipos.Location = new System.Drawing.Point(136, 27);
            this.comboBox_tipos.Name = "comboBox_tipos";
            this.comboBox_tipos.Size = new System.Drawing.Size(193, 28);
            this.comboBox_tipos.TabIndex = 21;
            this.comboBox_tipos.ValueMember = "nombre";
            this.comboBox_tipos.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipos_SelectedIndexChanged);
            // 
            // tbtipoBindingSource
            // 
            this.tbtipoBindingSource.DataMember = "tb_tipo";
            this.tbtipoBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // combo_subtipos
            // 
            this.combo_subtipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_subtipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combo_subtipos.ForeColor = System.Drawing.Color.DimGray;
            this.combo_subtipos.FormattingEnabled = true;
            this.combo_subtipos.Location = new System.Drawing.Point(360, 27);
            this.combo_subtipos.Name = "combo_subtipos";
            this.combo_subtipos.Size = new System.Drawing.Size(193, 28);
            this.combo_subtipos.TabIndex = 22;
            this.combo_subtipos.SelectedIndexChanged += new System.EventHandler(this.combo_subtipos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Subcategoria";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 40);
            this.label4.TabIndex = 33;
            this.label4.Text = "Activar Busqueda";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox1.Location = new System.Drawing.Point(82, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tb_inventarioBindingSource
            // 
            this.tb_inventarioBindingSource.DataMember = "tb_inventario";
            this.tb_inventarioBindingSource.DataSource = this.db_asiloDataSet;
            // 
            // tb_inventarioTableAdapter
            // 
            this.tb_inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_bodegaTableAdapter = null;
            this.tableAdapterManager.tb_donacionTableAdapter = null;
            this.tableAdapterManager.tb_ingresosTableAdapter = null;
            this.tableAdapterManager.tb_inventarioTableAdapter = this.tb_inventarioTableAdapter;
            this.tableAdapterManager.tb_objetoTableAdapter = null;
            this.tableAdapterManager.tb_salidasTableAdapter = null;
            this.tableAdapterManager.tb_subtipoTableAdapter = null;
            this.tableAdapterManager.tb_tipoTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = admin_us.db_asiloDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_Mostrar_InventarioTableAdapter
            // 
            this.tb_Mostrar_InventarioTableAdapter.ClearBeforeFill = true;
            // 
            // tb_subtipoTableAdapter
            // 
            this.tb_subtipoTableAdapter.ClearBeforeFill = true;
            // 
            // tb_tipoTableAdapter
            // 
            this.tb_tipoTableAdapter.ClearBeforeFill = true;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 640);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventario";
            this.Text = "frmInventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_inventarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMostrarInventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_asiloDataSet)).EndInit();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel_busqueda.ResumeLayout(false);
            this.panel_busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbtipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_inventarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private db_asiloDataSet db_asiloDataSet;
        private System.Windows.Forms.BindingSource tb_inventarioBindingSource;
        private db_asiloDataSetTableAdapters.tb_inventarioTableAdapter tb_inventarioTableAdapter;
        private db_asiloDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource tbMostrarInventarioBindingSource;
        private db_asiloDataSetTableAdapters.tb_Mostrar_InventarioTableAdapter tb_Mostrar_InventarioTableAdapter;
        private System.Windows.Forms.DataGridView tb_inventarioDataGridView;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_subtipos;
        private db_asiloDataSetTableAdapters.tb_subtipoTableAdapter tb_subtipoTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel_busqueda;
        private System.Windows.Forms.ComboBox comboBox_tipos;
        private System.Windows.Forms.BindingSource tbtipoBindingSource;
        private db_asiloDataSetTableAdapters.tb_tipoTableAdapter tb_tipoTableAdapter;
    }
}