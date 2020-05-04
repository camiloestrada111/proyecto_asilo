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

        private void tb_tipoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_tipoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_asiloDataSet);

        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_tipo' Puede moverla o quitarla según sea necesario.
            this.tb_tipoTableAdapter.Fill(this.db_asiloDataSet.tb_tipo);

        }

        public void llenardatos(string tipo)
        {
            foreach (DataRow row in Tabla.Rows)
            {
                comboBox1.Items.Add(row["nombre"]);
            }
            try
            {
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
            txtNombre.Text = comboBox1.Text;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmMessageBoxExisteUnError messageBoxExisteUnError = new frmMessageBoxExisteUnError();
            frmMessageBoxLogin frm = new frmMessageBoxLogin();
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
                    this.tb_tipoTableAdapter.Agregar(txtNombre.Text, predecedor);
                    this.tb_tipoTableAdapter.Fill(this.db_asiloDataSet.tb_tipo);
                    frm.Show();
                    txtNombre.Text = "Nombre";
                }
            }
            catch (Exception)
            {
                messageBoxExisteUnError.Show();
            }
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtNombre_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            //this.tb_tipoTableAdapter.Eliminar();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {

                comboBox1_nombre.Visible = true;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnAgregar.Enabled = false;
                llenardatos(comboBox2.Text);

            }
            else
            {
                comboBox1_nombre.Visible = false;
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                txtNombre.Text = "Nombre";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txtNombre_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtNombre.Text == "Nombre" || txtNombre.Text == comboBox1.Text)
            {
                txtNombre.Text = "";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
