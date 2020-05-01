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
    public partial class frmMessageBoxActualizar : Form
    {
        public frmMessageBoxActualizar()
        {
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
