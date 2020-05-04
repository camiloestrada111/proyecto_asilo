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
    public partial class frmMessageBoxNoLogin : Form
    {
        public frmMessageBoxNoLogin()
        {
            InitializeComponent();
        }

        private void tmrCerrar_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMessageBoxNoLogin_Load(object sender, EventArgs e)
        {
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
