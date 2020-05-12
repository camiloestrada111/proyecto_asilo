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
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_Mostrar_Reportes' Puede moverla o quitarla según sea necesario.
            this.tb_Mostrar_ReportesTableAdapter.Fill(this.db_asiloDataSet.tb_Mostrar_Reportes);

        }
    }
}
