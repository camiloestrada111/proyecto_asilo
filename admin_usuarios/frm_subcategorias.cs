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
    public partial class frm_subcategorias : Form
    {
        //Se usa para consultar la tabla
        public static DataRow Fila;

        //Tabla que uso para guardar los datos de las consultas
        public static DataTable Tabla = new DataTable();

        //Datos generales del usuario
        public int id, tipo;

        //Sirve para ver la contraseña
        int ver = 0;

        //Mas de los datos
        public string nombre, apellido, usuario, contraseña;

        public frm_subcategorias()
        {
            InitializeComponent();
            consultar();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            try
            {
                this.tb_subtipoTableAdapter.Agregar_subtipo(txt_nombre.Text, this.tb_tipoTableAdapter.Consultar_id(comboBox2_tipo.Text));
                consultar();
            }
            catch (Exception)
            {
                MessageBox.Show("Existe un error");
            }

            txt_nombre.Clear();
        }

        private void tb_subtipoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_subtipoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_asiloDataSet);

        }

        private void frm_subcategorias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_tipo' Puede moverla o quitarla según sea necesario.
            this.tb_tipoTableAdapter.Fill(this.db_asiloDataSet.tb_tipo);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_subtipo' Puede moverla o quitarla según sea necesario.
            this.tb_subtipoTableAdapter.Fill(this.db_asiloDataSet.tb_subtipo);

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 

            //define si se agrega o ya esta agregado, true=nuevo false=ya existe
            if (checkBox1.Checked == true)
            {
                comboBox1_nombre.Visible = false;
                comboBox2_tipo.Visible = true;
                btn_agregar.Enabled = true;
                btn_eliminar.Enabled = false;
                btn_modificar.Enabled = false;
            }
            else
            {
                comboBox1_nombre.Visible = true;
                comboBox2_tipo.Visible = true;
                btn_eliminar.Enabled = true;
                btn_modificar.Enabled = true;
                btn_agregar.Enabled = false;
            }

        }

        private void comboBox1_nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void consultar()
        {

            try
            {
                //comboBox1_nombre.Items.Add(this.tb_subtipoTableAdapter.buscar_nombres(this.tb_tipoTableAdapter.Consultar_id(comboBox2_tipo.Text)));
            }
            catch
            {

            }
        }
    }
}
