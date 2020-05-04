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
    public partial class frmMessageBoxLogin : Form
    {
        public frmMessageBoxLogin()
        {
            InitializeComponent();
        }

        private void tmrCerrar_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMessageBoxLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
