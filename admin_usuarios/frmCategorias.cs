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

        private void btnAgregar_Click(object sender, EventArgs e)
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
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

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
                //llenardatos(comboBox2.Text);

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
    }
}
