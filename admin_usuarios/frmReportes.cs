using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_us
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
            Estilo();
            date_fechaHASTA.MaxDate = fecha;

            date_fechaDESDE.MaxDate = fecha;
            date_fechaDESDE.Value = fecha.AddDays(-30);
        }

        //Se usa para consultar la tabla
        public static DataRow Fila;

        //Tabla que uso para guardar los datos de las consultas
        public static DataTable Tabla = new DataTable();

        DateTime fecha = DateTime.Now;
        public void Estilo()
        {
            tb_inventarioDataGridView.Font = new Font("Microsoft Sans Serif", 12);
            tb_inventarioDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            this.tb_inventarioDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tb_inventarioDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

        }

        private void tb_inventarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_reportesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_asiloDataSet);

        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_tipo' Puede moverla o quitarla según sea necesario.
            this.tb_tipoTableAdapter.Fill(this.db_asiloDataSet.tb_tipo);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_reportes' Puede moverla o quitarla según sea necesario.
            this.tb_reportesTableAdapter.Fill(this.db_asiloDataSet.tb_reportes);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_Mostrar_Reportes' Puede moverla o quitarla según sea necesario.
            this.tb_Mostrar_ReportesTableAdapter.Fill(this.db_asiloDataSet.tb_Mostrar_Reportes);
            
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                panel_busqueda.Visible = true;
                panel_busqueda.Location = new Point(180, 66);
                panel3.Location = new Point(167, 0);
                combo_tiempo.SelectedItem = null;
            }
            else
            {
                panel_busqueda.Visible = false;
            }
        }

        private void ComboBox_tipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                
            if (Convert.ToInt32(combo_tiempo.SelectedIndex) == 2)
            {
                panel3.Location = new Point(359, 0);
                panel_busqueda.Location = new Point(132, 66);
                panel1.Visible = true;
                llenardatos_fechas(Convert.ToString(date_fechaDESDE.Value), Convert.ToString(date_fechaHASTA.Value));

            }
            else
            {
                panel_busqueda.Location = new Point(180, 66);
                panel3.Location = new Point(167, 0);
                panel1.Visible = false;

                if (Convert.ToInt32(combo_tiempo.SelectedIndex) == 0) {
                    llenardatos_fechas(DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"));
                }
                else
                {
                    llenardatos_fechas(DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"));
                }

                
            }
        }

        public void llenardatos_fechas(String t1, String t2)
        {
            
            this.tb_Mostrar_ReportesTableAdapter.Buscar_por_fecha(this.db_asiloDataSet.tb_Mostrar_Reportes, t1, t2);
        }

        public void llenardatos_subtipo()
        {
            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(combo_cat.Text));
            Tabla = this.tb_subtipoTableAdapter.ObtenerDatos(id_tipos);
            combo_subtipos.Items.Clear();
            combo_subtipos.Items.Add("Ninguno");
            foreach (DataRow row in Tabla.Rows)
            {
                combo_subtipos.Items.Add(row["nombre"]);
            }
            try
            {
                combo_subtipos.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
            this.tb_Mostrar_ReportesTableAdapter.Buscar_por_tipo(this.db_asiloDataSet.tb_Mostrar_Reportes, id_tipos);
        }

        private void Combo_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenardatos_subtipo();
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                combo_cat.Enabled = true;
                combo_subtipos.Enabled = true;
                combo_subtipos.Items.Clear();
                llenardatos_subtipo();
            }
            else
            {
                combo_cat.Enabled = false;
                combo_subtipos.Enabled = false;
                combo_subtipos.SelectedItem = null;

                this.tb_Mostrar_ReportesTableAdapter.Fill(this.db_asiloDataSet.tb_Mostrar_Reportes);
            }
        }

        private void Combo_subtipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_subtipos.Text == "Ninguno")
            {
                int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(combo_cat.Text));
                this.tb_Mostrar_ReportesTableAdapter.Buscar_por_tipo(this.db_asiloDataSet.tb_Mostrar_Reportes, id_tipos);
            }
            else
            {
                int ID_tipo = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(combo_cat.Text));
                int ID_subtipo = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(ID_tipo, combo_subtipos.Text));
                this.tb_Mostrar_ReportesTableAdapter.Buscar_por_sub_tipo(this.db_asiloDataSet.tb_Mostrar_Reportes, ID_tipo, ID_subtipo);

            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                combo_tipo.Enabled = true;

            }
            else
            {
                combo_tipo.Enabled = false;
                combo_tipo.SelectedItem = null;
                this.tb_Mostrar_ReportesTableAdapter.Fill(this.db_asiloDataSet.tb_Mostrar_Reportes);

            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                combo_tiempo.Enabled = true;

            }
            else
            {
                combo_tiempo.Enabled = false;
                combo_tiempo.SelectedItem = null;
                this.tb_Mostrar_ReportesTableAdapter.Fill(this.db_asiloDataSet.tb_Mostrar_Reportes);

            }
        }

        private void Date_fechaDESDE_ValueChanged(object sender, EventArgs e)
        {
            llenardatos_fechas(Convert.ToString(date_fechaDESDE.Value), Convert.ToString(date_fechaHASTA.Value));
        }

        private void Date_fechaHASTA_ValueChanged(object sender, EventArgs e)
        {
            llenardatos_fechas(Convert.ToString(date_fechaDESDE.Value), Convert.ToString(date_fechaHASTA.Value));

        }

        private void Combo_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String clase;
            if (Convert.ToInt32(combo_tipo.SelectedIndex) == 0)
            {
                clase = "Ingreso";
            }
            else
            {
                clase = "Salida";
            }
            this.tb_Mostrar_ReportesTableAdapter.Buscar_por_clase(this.db_asiloDataSet.tb_Mostrar_Reportes, clase);

        }
    }
}
