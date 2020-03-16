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
    public partial class frmLogin : Form
    {   
        //Variable de color de texto
        public Color colortexto = Color.DimGray;
        //Creo que ya no la use
        public Color colorinici = Color.DimGray;
        //Sirve para ver la contraseña
        int ver = 0;
        //Datos del Usuario
        public string usuario, contraseña;

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            if(txtContra.Text != "Contraseña" && comboBox2.Text != "")
            {
                btnAceptar.Enabled = true;
            }else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.TextLength == 0)
            {
                txtContra.Text = "Contraseña";
                txtContra.ForeColor = colorinici;
                txtContra.PasswordChar = '\0';
                ver = 1;
                picContra.Visible = false;
            }
        }

        private void txtContra_Click(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.ForeColor = colortexto;
                txtContra.PasswordChar = '*';
                picContra.Visible = true;
                ver = 0;
                picContra.Image = admin_us.Properties.Resources.oculta;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_usuario' Puede moverla o quitarla según sea necesario.
            this.tb_usuarioTableAdapter.Fill(this.db_asiloDataSet.tb_usuario);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picContra_Click(object sender, EventArgs e)
        {
            if (txtContra.Text != "Contraseña")
            {
                if (txtContra.PasswordChar == '*')
                {
                    txtContra.PasswordChar = '\0';
                    picContra.Image = admin_us.Properties.Resources.muestraSelec;
                    ver = 1;
                }
                else
                {
                    txtContra.PasswordChar = '*';
                    picContra.Image = admin_us.Properties.Resources.ocultaSelec;
                    ver = 0;
                }
            }
        }

        private void picContra_MouseHover(object sender, EventArgs e)
        {
            if (ver == 0)
            {
                picContra.Image = admin_us.Properties.Resources.ocultaSelec;
            }
            else if (ver == 1)
            {
                picContra.Image = admin_us.Properties.Resources.muestraSelec;
            }
        }

        private void picContra_MouseLeave(object sender, EventArgs e)
        {
            if (ver == 0)
            {
                picContra.Image = admin_us.Properties.Resources.oculta;
            }
            else if (ver == 1)
            {
                picContra.Image = admin_us.Properties.Resources.muestra;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int x;
            x = Convert.ToInt32(this.tb_usuarioTableAdapter.iniciarsesion(comboBox2.Text, txtContra.Text));
            if(x == 1)
            {
                //MessageBox.Show("Iniciando sesion");
                MenuAsilo.Menu frmMenu = new MenuAsilo.Menu();
                frmMenu.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Error Contraseña no Valida");
            }
        }

        public frmLogin()
        {
            InitializeComponent();
        }
    }
}
