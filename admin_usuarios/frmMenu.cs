using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MenuAsilo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Personalizar();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Personalizar()
        {
            panelUsuario.Visible = false;
            panelInicio.Visible = false;
        }

        private void SubMenu()
        {
            if(panelInicio.Visible == true)
            {
                panelInicio.Visible = false;
            }
            else if (panelUsuario.Visible == true)
            {
                panelUsuario.Visible = false;
            }
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                SubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void panelIzquierda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if(panelIzquierda.Width == 294)
            {
                panelIzquierda.Width = 143;
            }
            else
            {
                panelIzquierda.Width = 294;
            }
        }


        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            if (panelIzquierda.Width == 294)
            {
                panelIzquierda.Width = 143;
            }
            else
            {
                panelIzquierda.Width = 294;
            }
        }

        private void pictureBox4_Click_2(object sender, EventArgs e)
        {
            
        }

        private Form activo = null;

        private void FormsHijos(Form formNuevo)
        {
            if(activo != null)
            {
                activo.Close();
                activo = formNuevo;
                formNuevo.TopLevel = false;
                formNuevo.FormBorderStyle = FormBorderStyle.None;
                formNuevo.Dock = DockStyle.Fill;
                formNuevo.BringToFront();
                formNuevo.Show();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SubMenu(); //de ultimo
            
            Form frminstancia = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is admin_usuarios.admin_usuarios);
            if (frminstancia != null)
            {
                frminstancia.BringToFront();
                return;
            }

            frminstancia = new admin_usuarios.admin_usuarios();
            frminstancia.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelInicio);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelUsuario);
           
        }

        private void btnAdminRol_Click(object sender, EventArgs e)
        {
            SubMenu(); //de ultimo
        }

        private void btnCerrarS_Click(object sender, EventArgs e)
        {
            SubMenu(); //de ultimo

            admin_us.frmLogin frmLog = new admin_us.frmLogin();
            Form frminstancia = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is admin_usuarios.admin_usuarios);
            if (frminstancia != null)
            {
                frminstancia.Close();
            }
            frmLog.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SubMenu(); //de ultimo
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if(panelIzquierda.Width == 288)
            {
                panelIzquierda.Width = 70;
            }
            else
            {
                panelIzquierda.Width = 288;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Restaurar.Visible = true;
            Maxi.Visible = false;

        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maxi.Visible = true;
        }

        private void Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112 , 0xf012, 0);
        }
    }
}
