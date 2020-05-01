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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }
        //Se usa para consultar la tabla
        public static DataRow Fila;

        //Tabla que uso para guardar los datos de las consultas
        public static DataTable Tabla = new DataTable();

        private void tb_inventarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_inventarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_asiloDataSet);

        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_tipo' Puede moverla o quitarla según sea necesario.
            this.tb_tipoTableAdapter.Fill(this.db_asiloDataSet.tb_tipo);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_Mostrar_Inventario' Puede moverla o quitarla según sea necesario.
            this.tb_Mostrar_InventarioTableAdapter.Fill(this.db_asiloDataSet.tb_Mostrar_Inventario);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_inventario' Puede moverla o quitarla según sea necesario.
            this.tb_inventarioTableAdapter.Fill(this.db_asiloDataSet.tb_inventario);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void llenardatos_subtipo()
        {
            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
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
            this.tb_Mostrar_InventarioTableAdapter.Buscar_por_tipo(this.db_asiloDataSet.tb_Mostrar_Inventario, id_tipos);
        }

        private void comboBox_tipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenardatos_subtipo();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                panel_busqueda.Visible = true;
                combo_subtipos.Items.Clear();
                llenardatos_subtipo();
            }
            else
            {
                panel_busqueda.Visible = false;
                this.tb_Mostrar_InventarioTableAdapter.Fill(this.db_asiloDataSet.tb_Mostrar_Inventario);
            }
        }

        private void combo_subtipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_subtipos.Text == "Ninguno")
            {
                int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
                this.tb_Mostrar_InventarioTableAdapter.Buscar_por_tipo(this.db_asiloDataSet.tb_Mostrar_Inventario, id_tipos);
            }
            else
            {
                int ID_tipo = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
                int ID_subtipo = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(ID_tipo, combo_subtipos.Text));
                this.tb_Mostrar_InventarioTableAdapter.Buscar_por_sub_tipo(this.db_asiloDataSet.tb_Mostrar_Inventario, ID_tipo,ID_subtipo);

            }
        }
    }
}
