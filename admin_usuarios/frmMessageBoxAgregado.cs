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
    public partial class frmMessageBoxAgregado : Form
    {
        public frmMessageBoxAgregado()
        {
            InitializeComponent();
        }

        private void frmMessageBoxAgregado_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width + 282) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);

        }

        private void lblInicio_Click(object sender, EventArgs e)
        {

        }
    }
}
