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
    public partial class frmIngresos : Form
    {
        public frmIngresos()
        {
            InitializeComponent();
        }

        private void comboBox_tipoingreso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_tipoingreso.Text == "Compra")
            {
                paneldonador.Visible = false;
            }else
            {
                paneldonador.Visible = true;
            }
        }

        private void frmIngresos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_objeto' Puede moverla o quitarla según sea necesario.
            this.tb_objetoTableAdapter.Fill(this.db_asiloDataSet.tb_objeto);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_subtipo' Puede moverla o quitarla según sea necesario.
            this.tb_subtipoTableAdapter.Fill(this.db_asiloDataSet.tb_subtipo);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_usuario' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_donacion' Puede moverla o quitarla según sea necesario.
            this.tb_donacionTableAdapter.Fill(this.db_asiloDataSet.tb_donacion);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_ingresos' Puede moverla o quitarla según sea necesario.
            this.tb_ingresosTableAdapter.Fill(this.db_asiloDataSet.tb_ingresos);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_tipo' Puede moverla o quitarla según sea necesario.
            this.tb_tipoTableAdapter.Fill(this.db_asiloDataSet.tb_tipo);

        }
    }
}
