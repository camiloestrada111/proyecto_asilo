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
    public partial class frmCategorias : Form
    {

        public static DataTable Tabla = new DataTable();


        public int predecedor;
        public frmCategorias()
        {
            InitializeComponent();
        }
        public void llenardatos_tipo()
        {
            Tabla = this.tb_tipoTableAdapter.GetData();
            foreach (DataRow row in Tabla.Rows)
            {
                comboBox2.Items.Add(row["nombre"]);
            }
            try
            {
                comboBox2.SelectedIndex = 0;
            }
            catch (Exception)
            {
                checkBox2.Checked = false;
            }
            txtNombre.Text = comboBox2.Text;
            int ID_tipo = Convert.ToInt32( this.tb_tipoTableAdapter.Consultar_id(comboBox2.Text));
            int perecedero = Convert.ToInt32(this.tb_tipoTableAdapter.Obtener_perecedero(ID_tipo));
            if (perecedero == 1)
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.SelectedIndex = 1;
            }
        }
        private void tb_tipoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_tipoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_asiloDataSet);
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_tipo' Puede moverla o quitarla según sea necesario.
            //this.tb_tipoTableAdapter.Fill(this.db_asiloDataSet.tb_tipo);
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmMessageBoxExisteUnError messageBoxExisteUnError = new frmMessageBoxExisteUnError();
            frmMessageBoxLogin frm = new frmMessageBoxLogin();
            frmMessageBoxErrorYaExisteElQueQuiereAgregar yaExiste = new frmMessageBoxErrorYaExisteElQueQuiereAgregar();
            try
            {
                if (txtNombre.Text == "Nombre")
                {
                    messageBoxExisteUnError.Show();
                }
                else
                {
                    if (comboBox1.Text == "Sí")
                    {
                        predecedor = 1;
                    }
                    else if (comboBox1.Text == "No")
                    {
                        predecedor = 0;
                    }
                    int ID_tipo = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(txtNombre.Text));
                    if (ID_tipo == 0)
                    {
                        this.tb_tipoTableAdapter.Agregar(txtNombre.Text, predecedor);
                        this.tb_tipoTableAdapter.Fill(this.db_asiloDataSet.tb_tipo);
                        frm.Show();
                        txtNombre.Text = "Nombre";
                    }
                    else
                    {
                        yaExiste.Show();
                    }
                }
            }
            catch (Exception)
            {
                messageBoxExisteUnError.Show();
            }
            
        }

        private void TxtNombre_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AGREGAR EL DE PEDIR Eliminar Y QUITAR ESTE");
            frmMessageBoxExisteUnError messageBoxExisteUnError = new frmMessageBoxExisteUnError();
            frmMessageBoxEliminar mensajeeliminar = new frmMessageBoxEliminar();
            frmMessageBoxErrorYaExisteElQueQuiereAgregar yaExiste = new frmMessageBoxErrorYaExisteElQueQuiereAgregar();
            int ID_tipoReal = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox2.Text));
            this.tb_tipoTableAdapter.Eliminar(ID_tipoReal);
            checkBox2.Checked = false;
            mensajeeliminar.Show();
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {         
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnAgregar.Enabled = false;
                comboBox2.Enabled = true;
                comboBox2.Items.Clear();
                llenardatos_tipo();
            }
            else
            {
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                comboBox2.Enabled = false;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Nuevo");
                comboBox2.SelectedIndex = 0;
                txtNombre.Text = "Nombre";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AGREGAR EL DE PEDIR MODIFICACION Y QUITAR ESTE");
            frmMessageBoxExisteUnError messageBoxExisteUnError = new frmMessageBoxExisteUnError();
            frmMessageBoxActualizar messageBoxacualizado = new frmMessageBoxActualizar();
            frmMessageBoxErrorYaExisteElQueQuiereAgregar yaExiste = new frmMessageBoxErrorYaExisteElQueQuiereAgregar();
            int ID_tipoReal = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox2.Text));
            int ID_tipo = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(txtNombre.Text));
            int Perecedero = Convert.ToInt32(this.tb_tipoTableAdapter.Obtener_perecedero(ID_tipoReal));
            if (comboBox1.Text == "Sí")
            {
                predecedor = 1;
            }
            else if (comboBox1.Text == "No")
            {
                predecedor = 0;
            }
            if (ID_tipo == 0)
            {   
                this.tb_tipoTableAdapter.Actualizar(txtNombre.Text, predecedor, ID_tipoReal);
                messageBoxacualizado.Show();
                llenardatos_tipo();
            }
            else
            {
                if (Perecedero == predecedor)
                {
                    yaExiste.Show();
                }else
                {
                    this.tb_tipoTableAdapter.Actualizar(txtNombre.Text, predecedor, ID_tipoReal);
                    messageBoxacualizado.Show();
                    llenardatos_tipo();
                }
            }
        }

        private void txtNombre_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre" && checkBox2.Checked == false)
            {
                txtNombre.Text = "";
            }
            else if (txtNombre.Text == comboBox2.Text && checkBox2.Checked == true)
            {
                txtNombre.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0 && checkBox2.Checked == false)
            {
                txtNombre.Text = "Nombre";
            }
            else if (txtNombre.Text.Length == 0 && checkBox2.Checked == true)
            {
                txtNombre.Text = comboBox2.Text;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                int ID_tipo = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(comboBox2.Text));
                int perecedero = Convert.ToInt32(this.tb_tipoTableAdapter.Obtener_perecedero(ID_tipo));
                if (perecedero == 1)
                {
                    comboBox1.SelectedIndex = 0;
                }
                else
                {
                    comboBox1.SelectedIndex = 1;
                }
                txtNombre.Text = comboBox2.Text;
            }
        }
    }
}
