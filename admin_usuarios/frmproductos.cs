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
                txtPesos.Text = pesos;
                PESO1 = pesos;
                try
                {
                    txtNombre.Text = txtNombre.Text.Replace(pesos, "");
                }
                catch (Exception)
                {
                    
                }
            }
            else
            {
                panel_objetos.Visible = false;
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                txtNombre.Text = "Nombre";
                txtPesos.Text = "Peso";
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
                if (txtNombre.Text == comboBox_objetos.Text.Replace(PESO1, ""))
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
                    txtNombre.Text = comboBox_objetos.Text.Replace(PESO1,"");
                }
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                if (txtPesos.Text.Length == 0)
                {
                    txtPesos.Text = "Peso";
                }
            }
            else
            {
                if (txtPesos.Text.Length == 0)
                {
                    int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
                    int id_subtipos = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipos, comboBox_subtipos.Text));
                    int id_objeto = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_id(comboBox_objetos.Text, id_tipos, id_subtipos));
                    string pesos = Convert.ToString(this.tb_objetoTableAdapter.obtener_peso(id_objeto));
                    txtPesos.Text = pesos;
                    PESO1 = pesos;
                }
            }
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                if (txtPesos.Text == "Peso")
                {
                    txtPesos.Text = "";
                }
            }
            else
            {
                if (txtPesos.Text == PESO1)
                {
                    txtPesos.Text = "";
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
                checkBox2.Checked = false;
            }
            
            int id_objeto = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_id(comboBox_objetos.Text, id_tipos, id_subtipos));
            string pesos = Convert.ToString(this.tb_objetoTableAdapter.obtener_peso(id_objeto));
            txtPesos.Text = pesos;
            txtNombre.Text = comboBox_objetos.Text.Replace(pesos," ");
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
                checkBox1.Checked = true;
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
            txtNombre.Text = txtNombre.Text.Replace(PESO1, "");
            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
            int id_subtipos = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipos, comboBox_subtipos.Text));
            int id_objeto = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_id(comboBox_objetos.Text, id_tipos, id_subtipos));
            string pesos = Convert.ToString(this.tb_objetoTableAdapter.obtener_peso(id_objeto));
            if (checkBox1.Checked == true)
            {
                txtPesos.Text = pesos;
            }
            else
            {
                int salir = 23;
                int cont = 0;
                do
                {
                    comboBox_pesos.SelectedIndex = cont;
                    if (comboBox_pesos.Text == pesos)
                    {
                        salir = 0;
                    }else
                    {
                        cont++;
                    }
                } while (salir !=0);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox_pesos.Visible = false;
                txtPesos.Visible = true;
                int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
                int id_subtipos = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipos, comboBox_subtipos.Text));
                int id_objeto = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_id(comboBox_objetos.Text, id_tipos, id_subtipos));
                string pesos = Convert.ToString(this.tb_objetoTableAdapter.obtener_peso(id_objeto));
            }
            else
            {
                comboBox_pesos.Visible = true;
                txtPesos.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            frmMessageBoxLogin agregarmsg = new frmMessageBoxLogin();
            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
            int id_subtipos = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipos, comboBox_subtipos.Text));
            int existe = 0;
            if (checkBox1.Checked == true)
            {
                existe = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_siexiste(txtNombre.Text, id_tipos, txtPesos.Text, id_subtipos));
            }

            if (checkBox1.Checked == false)
            {

                existe = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_siexiste(txtNombre.Text, id_tipos, comboBox_pesos.Text, id_subtipos));
            }
            if (existe == 0)
            {
                if (txtNombre.Text == "Nombre")
                {
                }
                else
                {
                    if (checkBox1.Checked == false)
                    {
                        if (comboBox_pesos.Text == "")
                        {

                        }
                        else
                        {
                            String Nombre = txtNombre.Text + " " + comboBox_pesos.Text;
                            this.tb_objetoTableAdapter.agregar_objeto(Nombre, id_tipos, comboBox_pesos.Text, id_subtipos);
                            txtNombre.Text = "Nombre";
                            int id_obj = Convert.ToInt32(this.tb_objetoTableAdapter.Selecionar_ultimo());
                            this.tb_inventarioTableAdapter.agregar_inventario(id_obj, 0, 0);
                            agregarmsg.Show();
                        }
                    }
                    else
                    {
                        if (txtPesos.Text == "Peso")
                        {

                        }
                        else
                        {
                            String Nombre = txtNombre.Text + " " + txtPesos.Text;
                            this.tb_objetoTableAdapter.agregar_objeto(Nombre, id_tipos, txtPesos.Text, id_subtipos);
                            int id_obj = Convert.ToInt32(this.tb_objetoTableAdapter.Selecionar_ultimo());
                            this.tb_inventarioTableAdapter.agregar_inventario(id_obj, 0, 0);
                            agregarmsg.Show();
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
            frmMessageBoxModificar mensaje = new frmMessageBoxModificar();

            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
            int id_subtipos = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipos, comboBox_subtipos.Text));
            int id_objetos = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_id(comboBox_objetos.Text, id_tipos, id_subtipos));
            int existe = 0;

            DialogResult resultado = new DialogResult();
            Form mensaje1 = new frmMessageBoxModificar();

            resultado = mensaje1.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                if (txtNombre.Text != comboBox_objetos.Text)
                {
                    if (checkBox1.Checked == false)
                    {
                        existe = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_siexiste(txtNombre.Text, id_tipos, comboBox_pesos.Text, id_subtipos));
                        if (existe == 0)
                        {
                            if (comboBox_pesos.Text == "")
                            {

                            }
                            else
                            {
                                String Nombre = txtNombre.Text + " " + comboBox_pesos.Text;
                                this.tb_objetoTableAdapter.modificar_objeto(Nombre, id_tipos, comboBox_pesos.Text, id_subtipos, id_objetos);
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
                        existe = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_siexiste(txtNombre.Text, id_tipos, txtPesos.Text, id_subtipos));
                        if (existe == 0)
                        {
                            if (txtPesos.Text == PESO1)
                            {

                            }
                            else
                            {
                                String Nombre = txtNombre.Text + " " + txtPesos.Text;
                                this.tb_objetoTableAdapter.modificar_objeto(Nombre, id_tipos, txtPesos.Text, id_subtipos, id_objetos);
                                llenardatos_objetos();
                                llenardatos_pesos();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error Ya existe");
                        }
                    }
                }
                else
                {

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmMessageBoxEliminar eliminado = new frmMessageBoxEliminar();

            DialogResult resultado = new DialogResult();
            Form mensaje = new frmMessageBoxPregunta();
            frmMessageBoxEliminar eliminar = new frmMessageBoxEliminar();
            resultado = mensaje.ShowDialog();


            if (resultado == DialogResult.OK)
            {
                int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox_tipos.Text));
                int id_subtipos = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipos, comboBox_subtipos.Text));
                int id_objetos = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_id(comboBox_objetos.Text, id_tipos, id_subtipos));
                this.tb_objetoTableAdapter.eliminar_objeto(id_objetos);
                this.tb_inventarioTableAdapter.Eliminar_Inventario(id_objetos);
                llenardatos_objetos();
                llenardatos_pesos();
                checkBox2.Checked = false;
                //eliminar.Show();
            }

        }
    }
}
