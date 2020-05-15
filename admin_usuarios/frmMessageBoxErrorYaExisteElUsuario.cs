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
    public partial class frmMessageBoxErrorYaExisteElUsuario : Form
    {
        public frmMessageBoxErrorYaExisteElUsuario()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMessageBoxErrorYaExisteElUsuario_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width + 282) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            this.Close();

        }


        private void tmr_Tick_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
