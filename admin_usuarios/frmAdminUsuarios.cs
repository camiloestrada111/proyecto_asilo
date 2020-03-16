using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_usuarios
{
    public partial class admin_usuarios : Form
    {
        //Variable de color de texto
        public Color colortexto = Color.DimGray;
        //Creo que ya no la use
        public Color colorinici = Color.DimGray;
        //Tabla que uso para guardar los datos de las consultas
        public static DataTable Tabla = new DataTable();
        //Se usa para consultar la tabla
        public static DataRow Fila;
        //Datos generales del usuario
        public int id, tipo;
        //Sirve para ver la contraseña
        int ver = 0;
        //Mas de los datos
        public string nombre, apellido, usuario, contraseña;
        //Se usa al agregar un usuario regresar al texto original
        public void reiniciartexto()
        {
            txtNombre.Text = "Nombre";
            txtNombre.ForeColor = colorinici;
            txtApellido.Text = "Apellido";
            txtApellido.ForeColor = colorinici;
            txtUsuario.Text = "Usuario";
            txtUsuario.ForeColor = colorinici;
            txtContra.Text = "Contraseña";
            txtContra.ForeColor = colorinici;
            txtContra.PasswordChar = '\0';
            comboBox1.Text = "";
        }
        //Cambia los datos por los del usuario seleccionado
        public void llenardatos()
        {
            comboBox2.Enabled = true;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            Tabla = this.tb_usuarioTableAdapter.Obtenerdatos(comboBox2.Text);
            try
            {
                Fila = Tabla.Rows[0];
                id = Convert.ToInt32(Fila["id_usuario"]);
                nombre = Convert.ToString(Fila["nombre"]);
                apellido = Convert.ToString(Fila["apellido"]);
                usuario = Convert.ToString(Fila["usuario"]);
                contraseña = Convert.ToString(Fila["contra"]);
                tipo = Convert.ToInt32(Fila["tipousuario"]);
                txtNombre.Text = nombre;
                txtApellido.Text = apellido;
                txtContra.Text = contraseña;
                txtUsuario.Text = usuario;
                txtNombre.ForeColor = colortexto;
                txtApellido.ForeColor = colortexto;
                txtContra.ForeColor = colortexto;
                txtUsuario.ForeColor = colortexto;
                txtContra.PasswordChar = '*';
                comboBox1.SelectedIndex = tipo - 1;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                btnAgregar.Enabled = false;
            }
            catch (Exception)
            {
                reiniciartexto();
            }
        }
        public admin_usuarios()
        {
            InitializeComponent();
            comboBox2.Enabled = false;
            comboBox2.DropDownStyle = ComboBoxStyle.Simple;
            comboBox2.Text = "Nuevo";
        }
        private void admin_usuarios_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_usuario' Puede moverla o quitarla según sea necesario.
            this.tb_usuarioTableAdapter.Fill(this.db_asiloDataSet.tb_usuario);
            comboBox2.Enabled = false;
            comboBox2.DropDownStyle = ComboBoxStyle.Simple;
            comboBox2.Text = "Nuevo";
            comboBox1.SelectedIndex = 0;
        }
        //Si tiene escrito Nombre lo cambia por vacio
        private void txtNombre_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = colortexto;
            }
        }
        //si no tiene nada escrito y cambia de casilla se vuelve a llenar
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if(txtNombre.TextLength == 0)
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = colorinici;
            }
        }
        //Lo mismo pero con apellido
        private void txtApellido_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = colortexto;
            }
        }
        //igual
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.TextLength == 0)
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = colorinici;
            }
        }
        //Lo mismo pero con usuario
        private void txtUsuario_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = colortexto;
            }
        }
        //igual
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.TextLength == 0)
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = colorinici;
            }
        }
        //Lo mismo con contraseña pero pone *
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
        //Igual pero quita los *
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
        //Al cambiar de usuario se modifica todo
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                llenardatos();
            }
        }
        //Verifica si existe ya el usuario no deja ingresar pero si hay uno igual tambien 
        //desactiva el evento de textchange que si no se bugea
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedIndexChanged -= comboBox2_SelectedIndexChanged;
            int auxiliartipo = 0;
            int verificar = 0;
            if(comboBox1.Text == "Admin")
            {
                auxiliartipo = 1;
            }
            else
            {
                auxiliartipo = 2;
            }
            try
            {
                verificar = Convert.ToInt32(this.tb_usuarioTableAdapter.buscar(txtUsuario.Text));
            }
            catch (Exception)
            {
                verificar = 0;
                throw;
            }
            if(verificar == 0)
            {
                this.tb_usuarioTableAdapter.agregarUsuarios(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtContra.Text, 1);
                this.tb_usuarioTableAdapter.Fill(this.db_asiloDataSet.tb_usuario);
                comboBox2.Enabled = false;
                comboBox2.DropDownStyle = ComboBoxStyle.Simple;
                comboBox2.Text = "Nuevo";
                MessageBox.Show("Agregado Correctamente");
                reiniciartexto();
            }
            else
            {
                MessageBox.Show("Error ya existe el usuario");
            }
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }
        //Lo mismo que con agregar pero modificando tampoco deja modificar el usuario por uno que ya exista sin contar el original
        private void btnModificar_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedIndexChanged -= comboBox2_SelectedIndexChanged;
            int auxiliartipo = 0;
            int verificar = 0;
            if (comboBox1.Text == "Admin")
            {
                auxiliartipo = 1;
            }
            else
            {
                auxiliartipo = 2;
            }
            try
            {
                if(usuario == txtUsuario.Text)
                {
                }
                else
                {
                    verificar = Convert.ToInt32(this.tb_usuarioTableAdapter.buscar(txtUsuario.Text));
                }
            }
            catch (Exception)
            {
                verificar = 0;
                throw;
            }
            if (verificar == 0)
            {
                this.tb_usuarioTableAdapter.modificar(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtContra.Text, auxiliartipo, id);
                this.tb_usuarioTableAdapter.Fill(this.db_asiloDataSet.tb_usuario);
                MessageBox.Show("Actualizado Correctamente");
            }
            else
            {
                MessageBox.Show("Error ya existe el usuario");
            }
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }

        private void picContra_MouseHover(object sender, EventArgs e)
        {
            if(ver == 0)
            {
                picContra.Image = admin_us.Properties.Resources.ocultaSelec;
            }else if(ver == 1)
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

        //Elimina el usuario que se seleciono mas adelante evitar que se borre el usuario que inicio sesion y los admin talves
        //Posdata si se borran todos los usuarios se bugea
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedIndexChanged -= comboBox2_SelectedIndexChanged;
            this.tb_usuarioTableAdapter.eliminar(id);
            this.tb_usuarioTableAdapter.Fill(this.db_asiloDataSet.tb_usuario);
            MessageBox.Show("Eliminado Correctamente");
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            llenardatos();
        }
        //Muestra o oculta la contraseña pendiente cambiar iconos
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(txtContra.Text != "Contraseña")
            {
                if(txtContra.PasswordChar == '*')
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
        //Verifica que los datos esten llenos para activar los botones dependiendo del estado del checkbox
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if(txtNombre.Text != "Nombre" && txtApellido.Text != "Apellido" && txtContra.Text != "Contraseña" && txtUsuario.Text != "Usuario" && comboBox1.Text != "")
            {
                if(checkBox1.Checked == true)
                {
                    btnAgregar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }
                else
                {
                    btnAgregar.Enabled = true;
                }
            }
            else
            {
                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }
        //Cambia del modo ingresar usuario a el de modificar y eliminar
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                comboBox2.Enabled = true;
                comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
                llenardatos();
            }
            else
            {
                comboBox2.Enabled = false;
                comboBox2.DropDownStyle = ComboBoxStyle.Simple;
                comboBox2.Text = "Nuevo";
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnAgregar.Enabled = true;
                reiniciartexto();
            }
        }

        
    }
}
