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
    public partial class frmproductos : Form
    {  
        //Se usa para consultar la tabla
        public static DataRow Fila;

        //Tabla que uso para guardar los datos de las consultas
        public static DataTable Tabla = new DataTable();

        //Mas de los datos
        public string PESO1;

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                panel_objetos.Visible = true;
                llenardatos_objetos();
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                txtNombre.Text = comboBox_objetos.Text;
                int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
                int id_subtipos = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipos, comboBox_subtipos.Text));
                int id_objeto = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_id(comboBox_objetos.Text, id_tipos, id_subtipos));
                string pesos = Convert.ToString(this.tb_objetoTableAdapter.obtener_peso(id_objeto));
                txtUsuario.Text = pesos;
                PESO1 = pesos;
            }
            else
            {
                panel_objetos.Visible = false;
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                txtNombre.Text = "Nombre";
                txtUsuario.Text = "Peso";
            }
        }

        private void comboBox_subtipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                llenardatos_objetos();
            }
            llenardatos_pesos();
        }

        private void comboBox_tipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenardatos_subtipo();
            llenardatos_pesos();
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                if (txtNombre.Text == "Nombre")
                {
                    txtNombre.Text = "";
                }
            }else
            {
                if (txtNombre.Text == comboBox_objetos.Text)
                {
                    txtNombre.Text = "";
                }
            }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                if (txtNombre.Text.Length == 0)
                {
                    txtNombre.Text = "Nombre";
                }
            }else
            {
                if (txtNombre.Text.Length == 0)
                {
                    txtNombre.Text = comboBox_objetos.Text;
                }
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                if (txtUsuario.Text.Length == 0)
                {
                    txtUsuario.Text = "Peso";
                }
            }
            else
            {
                if (txtUsuario.Text.Length == 0)
                {
                    int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
                    int id_subtipos = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipos, comboBox_subtipos.Text));
                    int id_objeto = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_id(comboBox_objetos.Text, id_tipos, id_subtipos));
                    string pesos = Convert.ToString(this.tb_objetoTableAdapter.obtener_peso(id_objeto));
                    txtUsuario.Text = pesos;
                    PESO1 = pesos;
                }
            }
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                if (txtUsuario.Text == "Peso")
                {
                    txtUsuario.Text = "";
                }
            }
            else
            {
                if (txtUsuario.Text == PESO1)
                {
                    txtUsuario.Text = "";
                }
            }
        }

        public frmproductos()
        {
            InitializeComponent();
        }
        public void llenardatos_subtipo()
        {
            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
            Tabla = this.tb_subtipoTableAdapter.ObtenerDatos(id_tipos);
            comboBox_subtipos.Items.Clear();
            foreach (DataRow row in Tabla.Rows)
            {
                comboBox_subtipos.Items.Add(row["nombre"]);
            }
            try
            {
                comboBox_subtipos.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
            llenardatos_pesos();
        }
        public void llenardatos_objetos()
        {
            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
            int id_subtipos = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipos, comboBox_subtipos.Text));
            Tabla = this.tb_objetoTableAdapter.obtener_objetos(id_tipos, id_subtipos);
            comboBox_objetos.Items.Clear();
            foreach (DataRow row in Tabla.Rows)
            {
                comboBox_objetos.Items.Add(row["nombre"]);
            }
            try
            {
                comboBox_objetos.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
            txtNombre.Text = comboBox_objetos.Text;
            int id_objeto = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_id(comboBox_objetos.Text, id_tipos, id_subtipos));
            string pesos = Convert.ToString(this.tb_objetoTableAdapter.obtener_peso(id_objeto));
            txtUsuario.Text = pesos;
            PESO1 = pesos;
        }
        public void llenardatos_pesos()
        {
            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
            int id_subtipos = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipos, comboBox_subtipos.Text));
            Tabla = this.tb_objetoTableAdapter.obtener_pesos(id_tipos, id_subtipos);
            comboBox_pesos.Items.Clear();
            foreach (DataRow row in Tabla.Rows)
            {
                comboBox_pesos.Items.Add(row["peso"]);
            }
            try
            {
                comboBox_pesos.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
        }
        private void frmproductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_inventario' Puede moverla o quitarla según sea necesario.
            this.tb_inventarioTableAdapter.Fill(this.db_asiloDataSet.tb_inventario);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_objeto' Puede moverla o quitarla según sea necesario.
            this.tb_objetoTableAdapter.Fill(this.db_asiloDataSet.tb_objeto);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_subtipo' Puede moverla o quitarla según sea necesario.
            this.tb_subtipoTableAdapter.Fill(this.db_asiloDataSet.tb_subtipo);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_tipo' Puede moverla o quitarla según sea necesario.
            this.tb_tipoTableAdapter.Fill(this.db_asiloDataSet.tb_tipo);
            llenardatos_subtipo();
        }

        private void comboBox_objetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Text = comboBox_objetos.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox_pesos.Visible = false;
                txtUsuario.Visible = true;
                int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
                int id_subtipos = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipos, comboBox_subtipos.Text));
                int id_objeto = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_id(comboBox_objetos.Text, id_tipos, id_subtipos));
                string pesos = Convert.ToString(this.tb_objetoTableAdapter.obtener_peso(id_objeto));
            }
            else
            {
                comboBox_pesos.Visible = true;
                txtUsuario.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
            int id_subtipos = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipos, comboBox_subtipos.Text));
            int existe = 0;
            if (checkBox1.Checked == true)
            {
                existe = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_siexiste(txtNombre.Text, id_tipos,comboBox_pesos.Text,id_subtipos));
            }
            else
            {
                existe = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_siexiste(txtNombre.Text, id_tipos, txtUsuario.Text, id_subtipos));
            }
            MessageBox.Show(Convert.ToString(existe));
            if(existe == 0)
            {
                if (txtNombre.Text == "Nombre")
                {
                    MessageBox.Show("1");
                }
                else
                {
                    if (checkBox1.Checked == false)
                    {
                        if (comboBox_pesos.Text == "")
                        {

                            MessageBox.Show("2");
                        }
                        else
                        {
                            this.tb_objetoTableAdapter.agregar_objeto(txtNombre.Text, id_tipos, comboBox_objetos.Text, id_subtipos);
                            txtNombre.Text = "Nombre";
                            int id_obj = Convert.ToInt32(this.tb_objetoTableAdapter.Selecionar_ultimo());
                            this.tb_inventarioTableAdapter.agregar_inventario(id_obj, 0, 0);
                            MessageBox.Show("Agregado");                       }
                    }
                    else
                    {
                        if (txtUsuario.Text == "Peso")
                        {

                            MessageBox.Show("3");
                        }
                        else
                        {
                            this.tb_objetoTableAdapter.agregar_objeto(txtNombre.Text, id_tipos, txtUsuario.Text, id_subtipos);
                            int id_obj = Convert.ToInt32(this.tb_objetoTableAdapter.Selecionar_ultimo());
                            this.tb_inventarioTableAdapter.agregar_inventario(id_obj, 0, 0);
                            MessageBox.Show("Agregado");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error Ya existe");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
            int id_subtipos = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipos, comboBox_subtipos.Text));
            int id_objetos = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_id(comboBox_objetos.Text, id_tipos, id_subtipos));
            int existe = 0;
            if (txtNombre.Text == comboBox_objetos.Text)
            {
                if (checkBox1.Checked == false)
                {
                    existe = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_siexiste(txtNombre.Text, id_tipos, comboBox_pesos.Text, id_subtipos));
                    if (existe == 0)
                    {
                        if (comboBox_pesos.Text == "")
                        {

                        }else
                        {
                           this.tb_objetoTableAdapter.modificar_objeto(txtNombre.Text, id_tipos, comboBox_pesos.Text, id_subtipos, id_objetos);
                            llenardatos_objetos();
                            llenardatos_pesos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error Ya existe");
                    }
                }
                else
                {
                    existe = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_siexiste(txtNombre.Text, id_tipos, txtUsuario.Text, id_subtipos));
                    if (existe == 0)
                    {
                        if (txtUsuario.Text == PESO1)
                        {

                        }else
                        {
                            this.tb_objetoTableAdapter.modificar_objeto(txtNombre.Text, id_tipos, txtUsuario.Text, id_subtipos, id_objetos);
                            llenardatos_objetos();
                            llenardatos_pesos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error Ya existe");
                    }
                }
            }else
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
            int id_subtipos = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipos, comboBox_subtipos.Text));
            int id_objetos = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_id(comboBox_objetos.Text, id_tipos, id_subtipos));
            this.tb_objetoTableAdapter.eliminar_objeto(id_objetos);
            llenardatos_objetos();
            llenardatos_pesos();
        }
    }
}
