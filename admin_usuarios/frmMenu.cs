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

        string conocertipouser;

        public void obtenertipodeusuario(string conocer)
        {
            string ve = conocer;
            conocertipouser = ve;
            if (conocertipouser == "2")
            {
                btnUsuario.Visible = false;
            }
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
            panelAdministracion.Visible = false;
            panelInicio.Visible = false;
        }

        private void SubMenu()
        {
            if(panelAdministracion.Visible == true)
            {
                panelAdministracion.Visible = false;
            }
            else if (panelUsuario.Visible == true)
            {
                panelUsuario.Visible = false;
            }
            else if (panelInicio.Visible == true)
            {
                panelInicio.Visible = false;
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

       

      

        private void pictureBox4_Click_2(object sender, EventArgs e)
        {
            
        }

        private Form activo = null;

        private void FormsHijos(Form formNuevo)
        {
            if (activo != null)
            {
                activo.Close();
                CrearForm(formNuevo);
            }
            else
            {
                CrearForm(formNuevo);
            }
        }

        private void CrearForm(Form formNuevo)
        {
            activo = formNuevo;
            formNuevo.TopLevel = false;
            formNuevo.FormBorderStyle = FormBorderStyle.None;
            formNuevo.TopLevel = false;
            formNuevo.TopMost = true;
            formNuevo.BringToFront();

            this.Contenedor.Controls.Add(formNuevo);

            //Centrar form
            formNuevo.Location = new Point(
            this.Contenedor.Width / 2 - formNuevo.Size.Width / 2,
            this.Contenedor.Height / 2 - formNuevo.Size.Height / 2);
            formNuevo.Anchor = AnchorStyles.None;
            Contenedor.BackgroundImage = null;

            formNuevo.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            admin_usuarios.admin_usuarios llamar = new admin_usuarios.admin_usuarios();
            SubMenu(); //de ultimo
            Form frminstancia = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is admin_usuarios.admin_usuarios);
            frminstancia = new admin_usuarios.admin_usuarios();
            FormsHijos(frminstancia);
            activo = frminstancia;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelAdministracion);
           
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
            Form frminstancia = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is admin_us.frmCategorias);

            frminstancia = new admin_us.frmCategorias();
            FormsHijos(frminstancia);

            activo = frminstancia;
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

       

        private void Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112 , 0xf012, 0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_Restaurar.Visible = false;
            btn_Maximizar.Visible = true;
            Contenedor.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_Restaurar.Visible = true;
            btn_Maximizar.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(activo != null)
            {
                activo.Close();
                Contenedor.BackgroundImage = admin_us.Properties.Resources.Logo;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MostrarSubMenu(panelInicio);
        }

        private void button2_Click_2(object sender, EventArgs e)
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

        private void panelInicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SubMenu(); //de ultimo

            Form frminstancia = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is admin_us.frm_subcategorias);
            frminstancia = new admin_us.frm_subcategorias();
            FormsHijos(frminstancia);

            activo = frminstancia;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click_2(object sender, EventArgs e)
        {
            SubMenu(); //de ultimo

            Form frminstancia = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is admin_us.frmproductos);
            frminstancia = new admin_us.frmproductos();
            FormsHijos(frminstancia);

            activo = frminstancia;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frminstancia = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is admin_us.frmInventario);
            frminstancia = new admin_us.frmInventario();
            FormsHijos(frminstancia);

            activo = frminstancia;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frminstancia = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is admin_us.frmIngresos);
            frminstancia = new admin_us.frmIngresos();
            FormsHijos(frminstancia);

            activo = frminstancia;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Form frminstancia = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is admin_us.frmEgresos);
            frminstancia = new admin_us.frmEgresos();
            FormsHijos(frminstancia);

            activo = frminstancia;
        }
    }
}
