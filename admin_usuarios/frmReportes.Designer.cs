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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tb_inventarioDataGridView = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbMostrarReportesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_asiloDataSet = new admin_us.db_asiloDataSet();
            this.tb_Mostrar_ReportesTableAdapter = new admin_us.db_asiloDataSetTableAdapters.tb_Mostrar_ReportesTableAdapter();
            this.panel_busqueda = new System.Windows.Forms.Panel();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_inventarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMostrarReportesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_asiloDataSet)).BeginInit();
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
            this.panel25.Size = new System.Drawing.Size(982, 147);
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
            this.label3.Location = new System.Drawing.Point(430, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Reportes";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(46, 79);
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
            this.checkBox1.Location = new System.Drawing.Point(82, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 458);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(888, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(94, 458);
            this.panel4.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(130, 575);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(758, 30);
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
            this.categoriaDataGridViewTextBoxColumn,
            this.subcategoriaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.tb_inventarioDataGridView.DataSource = this.tbMostrarReportesBindingSource;
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
            this.tb_inventarioDataGridView.Location = new System.Drawing.Point(130, 147);
            this.tb_inventarioDataGridView.Name = "tb_inventarioDataGridView";
            this.tb_inventarioDataGridView.ReadOnly = true;
            this.tb_inventarioDataGridView.Size = new System.Drawing.Size(758, 428);
            this.tb_inventarioDataGridView.TabIndex = 7;
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
            // db_asiloDataSet
            // 
            this.db_asiloDataSet.DataSetName = "db_asiloDataSet";
            this.db_asiloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_Mostrar_ReportesTableAdapter
            // 
            this.tb_Mostrar_ReportesTableAdapter.ClearBeforeFill = true;
            // 
            // panel_busqueda
            // 
            this.panel_busqueda.Location = new System.Drawing.Point(148, 78);
            this.panel_busqueda.Name = "panel_busqueda";
            this.panel_busqueda.Size = new System.Drawing.Size(704, 60);
            this.panel_busqueda.TabIndex = 34;
            this.panel_busqueda.Visible = false;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 605);
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
            ((System.ComponentModel.ISupportInitialize)(this.tb_inventarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMostrarReportesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_asiloDataSet)).EndInit();
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
    }
}