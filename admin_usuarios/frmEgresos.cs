using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace admin_us
{
    public partial class frmEgresos : Form
    {
        public frmEgresos()
        {
            InitializeComponent();
        }
        //Se usa para consultar la tabla
        public static DataRow Fila;

        //Tabla que uso para guardar los datos de las consultas
        public static DataTable Tabla = new DataTable();

        DateTime fecha = DateTime.Now;

        //METODOS
        public void llenardatos_subtipo()
        {
            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(combo_categoria.Text));
            Tabla = this.tb_subtipoTableAdapter.ObtenerDatos(id_tipos);
            combo_subcategoria.Items.Clear();
            foreach (DataRow row in Tabla.Rows)
            {
                combo_subcategoria.Items.Add(row["nombre"]);
            }
            try
            {
                combo_subcategoria.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
        }
        public void llenardatos_objetos()
        {
            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(combo_categoria.Text));
            int id_subtipos = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipos, combo_subcategoria.Text));
            Tabla = this.tb_objetoTableAdapter.obtener_objetos(id_tipos, id_subtipos);
            combo_producto.Items.Clear();


            foreach (DataRow row in Tabla.Rows)
            {
                combo_producto.Items.Add(row["nombre"]);
            }
            try
            {
                combo_producto.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }

        }


        //Colores para los mensajes de advertencia
        public Color Existencias = Color.FromArgb(76, 205, 76);
        public Color Pocas_unidades = Color.FromArgb(242, 189, 13);
        public Color Sin_unidades = Color.FromArgb(248, 35, 35);
        public void determinar_stock() {
            //Se busca la cantidad actual del producto seleccionado para limitar las unidades posibles de salida
            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(combo_categoria.Text));
            int id_subtipos = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(id_tipos, combo_subcategoria.Text));
            int ID_objeto = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_id(combo_producto.Text, id_tipos, id_subtipos));
            int cantidad = Convert.ToInt32(this.tb_inventarioTableAdapter.Obtener_cantidad(ID_objeto));
            numeric_cantidad.Minimum = 1;
            numeric_cantidad.Maximum = cantidad;

            btnRetirar.Enabled = true;

            //Se cambia el texto y el color del mensaje para las existencias del producto
            if (cantidad > 10)
            {
                lbl_stock.Text = "En existencias";
                lbl_stock.ForeColor = Existencias;
                Color_danger("v");
            }
            else if (cantidad > 0)
            {
                lbl_stock.Text = cantidad+" Unidad(es) existentes";
                lbl_stock.ForeColor = Pocas_unidades;
                Color_danger("a");
            }
            else
            {
                //Se inhabilita el botón de egreso si el producto no tiene stock
                btnRetirar.Enabled = false;
                lbl_stock.Text = "Temporalmente sin existencias";
                lbl_stock.ForeColor = Sin_unidades;
                Color_danger("r");
            }
           

        }


        public void Color_danger(String s)
        {
            //Se cambia el color respecto al mensaje del método anterior
            Color color = Color.FromArgb(255, 255, 255);
            if (s.Equals("r")) {
                color = Sin_unidades;
            }else if (s.Equals("a"))
            {
                color = Pocas_unidades;
            }

            byte r = color.R;
            byte g = color.G;
            byte b = color.B;

            //Se carga la imagen de advertencia y se cambia el color al mismo que el del texto
            Bitmap bmp = new Bitmap(admin_us.Properties.Resources.danger);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color nColor = bmp.GetPixel(x, y);
                    if (nColor != Color.FromArgb(255, 255, 255, 255)) {
                        nColor = Color.FromArgb(r, g, b);
                        bmp.SetPixel(x, y, nColor);
                    }
                }
            }
            pictureBox2.Image = bmp;

        }

        //EVENTOS
        private void frmIngresos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_inventario' Puede moverla o quitarla según sea necesario.
            this.tb_inventarioTableAdapter.Fill(this.db_asiloDataSet.tb_inventario);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_objeto' Puede moverla o quitarla según sea necesario.
            this.tb_objetoTableAdapter.Fill(this.db_asiloDataSet.tb_objeto);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_subtipo' Puede moverla o quitarla según sea necesario.
            this.tb_subtipoTableAdapter.Fill(this.db_asiloDataSet.tb_subtipo);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_salidas' Puede moverla o quitarla según sea necesario.
            this.tb_salidasTableAdapter.Fill(this.db_asiloDataSet.tb_salidas);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_tipo' Puede moverla o quitarla según sea necesario.
            this.tb_tipoTableAdapter.Fill(this.db_asiloDataSet.tb_tipo);
            llenardatos_subtipo();
        }


        private void combo_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenardatos_subtipo();
            llenardatos_objetos();

        }

        private void combo_subcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenardatos_objetos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmMessageBoxEgreso ms = new frmMessageBoxEgreso();

            if (combo_categoria.Text.Length == 0 || combo_subcategoria.Text.Length == 0 || combo_producto.Text.Length == 0)
            {

            }
            else
            {                
                int ID_tipo = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(combo_categoria.Text));
                int ID_subtipo = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(ID_tipo, combo_subcategoria.Text));
                int ID_objeto = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_id(combo_producto.Text, ID_tipo, ID_subtipo));
                int cantidad_actual = Convert.ToInt32(this.tb_inventarioTableAdapter.Obtener_cantidad(ID_objeto));
                int nueva_cantidad = cantidad_actual - Convert.ToInt32(numeric_cantidad.Value);
                int ID_Inver = Convert.ToInt32(this.tb_inventarioTableAdapter.Obtener_id(ID_objeto));
                this.tb_salidasTableAdapter.Egresar(ID_objeto, Convert.ToInt32(numeric_cantidad.Value), Convert.ToString(fecha));
                this.tb_inventarioTableAdapter.Actualizar_inventario(nueva_cantidad, ID_objeto, ID_Inver);
                this.tb_reportesTableAdapter.AgregarRegistro(ID_objeto, Convert.ToInt32(numeric_cantidad.Value), Convert.ToString(fecha), "Salida");
                //Mensaje Agregado cambiar
                ms.Show();
                determinar_stock();
            }
        }

        private void Combo_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            determinar_stock();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
