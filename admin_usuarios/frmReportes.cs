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
            date_fechaHASTA.MaxDate = DateTime.Now;

            date_fechaDESDE.MaxDate = DateTime.Now;
            date_fechaDESDE.Value = DateTime.Now.AddDays(-30);
        }

        //Se usa para consultar la tabla
        public static DataRow Fila;

        //Tabla que uso para guardar los datos de las consultas
        public static DataTable Tabla = new DataTable();

        //Método para formatear la tabla
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

        //Checkbox para habilitar la busqueda por tiempo
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
                
                //Se reinician todos los comboBox y los checkBox
                checkBox4.Checked = false;
                checkBox3.Checked = false;
                checkBox2.Checked = false;

                combo_cat.Enabled = false;
                combo_subtipos.Enabled = false;
                combo_tiempo.Enabled = false;
                combo_tipo.Enabled = false;

                combo_tiempo.SelectedItem = null;
                combo_subtipos.SelectedItem = null;
                combo_tipo.SelectedItem = null;
                this.tb_Mostrar_ReportesTableAdapter.Fill(this.db_asiloDataSet.tb_Mostrar_Reportes);
            }
        }


        
        String fecha1;
        String fecha2;

        //ComboBox para habilitar la busqueda por tiempo
        private void ComboBox_tipos_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (Convert.ToInt32(combo_tiempo.SelectedIndex) == 2)
            {
                panel3.Location = new Point(359, 0);
                panel_busqueda.Location = new Point(132, 66);
                panel1.Visible = true;


                fecha1 = Convert.ToString(date_fechaDESDE.Value);
                fecha2 = Convert.ToString(date_fechaHASTA.Value);
                
            }
            else
            {
                panel_busqueda.Location = new Point(180, 66);
                panel3.Location = new Point(167, 0);
                panel1.Visible = false;

                fecha2 = DateTime.Now.ToString("yyyy-MM-dd");

                if (Convert.ToInt32(combo_tiempo.SelectedIndex) == 0)
                {
                    fecha1 = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd");
                    
                }
                else
                {
                    fecha1 = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
                   
                }

            }

            llenardatos_fechas(fecha1, fecha2);
        }


        //Se realiza la busqueda respecto a cuales CheckBox esten activos
        public void llenardatos_fechas(String t1, String t2)
        {
            
            if (checkBox4.Checked == false && checkBox3.Checked == false && checkBox2.Checked == true) //Busqueda por fecha
            {
                this.tb_Mostrar_ReportesTableAdapter.Buscar_por_fecha(this.db_asiloDataSet.tb_Mostrar_Reportes, t1, t2);

            }
            else if (checkBox4.Checked == false && checkBox3.Checked == true && checkBox2.Checked == true) //Busqueda por fecha y clase
            {
                this.tb_Mostrar_ReportesTableAdapter.Buscar_Tiempo_y_Clase(this.db_asiloDataSet.tb_Mostrar_Reportes, clase, t1, t2);

            }            
            else if (checkBox4.Checked == false && checkBox3.Checked == true && checkBox2.Checked == false) //Busqueda por clase
            {
                this.tb_Mostrar_ReportesTableAdapter.Buscar_por_clase(this.db_asiloDataSet.tb_Mostrar_Reportes, clase);

            }
            else if (checkBox4.Checked == true && combo_subtipos.Text == "Ninguno") //Busquedas por categorías
            {
                llenardatos_subtipo();

            }
            else //Busqueda por subcategorías
            {
                int ID_tipo = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(combo_cat.Text));
                int ID_subtipo = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(ID_tipo, combo_subtipos.Text));
                Formas_subtipos(ID_tipo, ID_subtipo);
            }


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

            Formas_Tipos(id_tipos);
            
        }


        //Posibilidades de busqueda respecto a la categoría del producto
        public void Formas_Tipos(int id_tipos)
        {
            if (checkBox2.Checked == true && checkBox3.Checked == true) //Busqueda por fecha, categorías y clases
            {
                this.tb_Mostrar_ReportesTableAdapter.Buscar_Tiempo_Tipo_y_Clase(this.db_asiloDataSet.tb_Mostrar_Reportes, clase, id_tipos, fecha1, fecha2);
            }
            else if (checkBox2.Checked == true && checkBox3.Checked == false) //Busqueda por fecha y categorías
            {
                this.tb_Mostrar_ReportesTableAdapter.Buscar_Tiempo_y_Tipo(this.db_asiloDataSet.tb_Mostrar_Reportes, id_tipos, fecha1, fecha2);
            }
            else if (checkBox2.Checked == false && checkBox3.Checked == true) //Busqueda por clase y categorías
            {
                this.tb_Mostrar_ReportesTableAdapter.Buscar_Clase_y_Tipo(this.db_asiloDataSet.tb_Mostrar_Reportes, clase, id_tipos);
            }
            else //Busqueda por categorías
            {
                this.tb_Mostrar_ReportesTableAdapter.Buscar_por_tipo(this.db_asiloDataSet.tb_Mostrar_Reportes, id_tipos);
            }
        }


        private void Combo_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenardatos_subtipo();
        }

        //Checkbox para habilitar la busqueda por categorías y subcategorías
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

                if (checkBox2.Checked == false && checkBox3.Checked == false)
                {
                    this.tb_Mostrar_ReportesTableAdapter.Fill(this.db_asiloDataSet.tb_Mostrar_Reportes);
                }
                else
                {
                    llenardatos_fechas(fecha1, fecha2);                   
                }

            }
        }

        private void Combo_subtipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_subtipos.Text == "Ninguno")
            {
                int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(combo_cat.Text));
                Formas_Tipos(id_tipos);
            }
            else
            {
                int ID_tipo = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(combo_cat.Text));
                int ID_subtipo = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(ID_tipo, combo_subtipos.Text));
                Formas_subtipos(ID_tipo, ID_subtipo);

            }
        }

        //Posibilidades de busqueda respecto a la subcategoría del producto
        public void Formas_subtipos(int ID_tipo, int ID_subtipo)
        {
            if (checkBox2.Checked == true && checkBox3.Checked == true) //Busqueda por fecha, subcategorías y clases
            {
                this.tb_Mostrar_ReportesTableAdapter.Buscar_Tiempo_Subtipo_y_Clase(this.db_asiloDataSet.tb_Mostrar_Reportes, clase, ID_tipo, ID_subtipo, fecha1, fecha2);
            }
            else if (checkBox2.Checked == true && checkBox3.Checked == false) //Busqueda por fecha y subcategorías
            {
                this.tb_Mostrar_ReportesTableAdapter.Buscar_Tiempo_y_Subtipo(this.db_asiloDataSet.tb_Mostrar_Reportes, ID_tipo, ID_subtipo, fecha1, fecha2);
            }
            else if (checkBox2.Checked == false && checkBox3.Checked == true) //Busqueda por clase y subcategorías
            {
                this.tb_Mostrar_ReportesTableAdapter.Buscar_Clase_y_Subtipo(this.db_asiloDataSet.tb_Mostrar_Reportes, clase, ID_tipo, ID_subtipo);
            }
            else //Busqueda por subcategorías
            {
                this.tb_Mostrar_ReportesTableAdapter.Buscar_por_sub_tipo(this.db_asiloDataSet.tb_Mostrar_Reportes, ID_tipo, ID_subtipo);
            }
        }


        //Checkbox para habilitar la busqueda por tipo
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

                if (checkBox2.Checked == false && checkBox4.Checked == false)
                {
                    this.tb_Mostrar_ReportesTableAdapter.Fill(this.db_asiloDataSet.tb_Mostrar_Reportes);
                }
                else
                {
                    llenardatos_fechas(fecha1, fecha2);
                }

            }
        }


        //Checkbox para habilitar la busqueda por tiempo
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

                if (checkBox3.Checked == false && checkBox4.Checked == false)
                {
                    this.tb_Mostrar_ReportesTableAdapter.Fill(this.db_asiloDataSet.tb_Mostrar_Reportes);
                }
                else
                {
                    llenardatos_fechas(fecha1, fecha2);
                }

            }
        }


        //Se llenan los datos al modificar Datepicker
        private void Date_fechaDESDE_ValueChanged(object sender, EventArgs e)
        {
            fecha1 = Convert.ToString(date_fechaDESDE.Value);
            fecha2 = Convert.ToString(date_fechaHASTA.Value);
            llenardatos_fechas(fecha1, fecha2);
        }

        String clase;

        //ComboBox para habilitar la busqueda por tipo
        private void Combo_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(combo_tipo.SelectedIndex) == 0)
            {
                clase = "Ingreso";
            }
            else
            {
                clase = "Salida";
            }

            llenardatos_fechas(fecha1, fecha2);

        }

        //Se llenan los datos al modificar Datepicker
        private void Date_fechaHASTA_ValueChanged(object sender, EventArgs e)
        {
            fecha1 = Convert.ToString(date_fechaDESDE.Value);
            fecha2 = Convert.ToString(date_fechaHASTA.Value);
            llenardatos_fechas(fecha1, fecha2);
        }
    }
}
