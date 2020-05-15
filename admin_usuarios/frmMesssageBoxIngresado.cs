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
    public partial class frmMesssageBoxIngresado : Form
    {
        public frmMesssageBoxIngresado()
        {
            InitializeComponent();
        }


        private void frmMesssageBoxIngresado_Load(object sender, EventArgs e)
        {

        }

        private void tmrCerrar_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tmrCerrar_Tick_1(object sender, EventArgs e)
        {

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
