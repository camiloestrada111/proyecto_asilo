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
    public partial class frmIngresos : Form
    {
        public frmIngresos()
        {
            InitializeComponent();
        }
        //Se usa para consultar la tabla
        public static DataRow Fila;

        //Tabla que uso para guardar los datos de las consultas
        public static DataTable Tabla = new DataTable();

        public int perecedero,donante;

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
        public void llenardatos_donantes()
        {
            Tabla = this.tb_donacionTableAdapter.obtener_dax();
            combo_donante.Items.Clear();
            combo_donante.Items.Add("Anonimo");
            combo_donante.Items.Add("Nuevo");
            foreach (DataRow row in Tabla.Rows)
            {
                combo_donante.Items.Add(row["nombre"]);
            }
            try
            {
                combo_donante.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
        }

        //EVENTOS
        private void frmIngresos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_reportes' Puede moverla o quitarla según sea necesario.
            this.tb_reportesTableAdapter.Fill(this.db_asiloDataSet.tb_reportes);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_inventario' Puede moverla o quitarla según sea necesario.
            this.tb_inventarioTableAdapter.Fill(this.db_asiloDataSet.tb_inventario);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_objeto' Puede moverla o quitarla según sea necesario.
            this.tb_objetoTableAdapter.Fill(this.db_asiloDataSet.tb_objeto);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_subtipo' Puede moverla o quitarla según sea necesario.
            this.tb_subtipoTableAdapter.Fill(this.db_asiloDataSet.tb_subtipo);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_usuario' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_donacion' Puede moverla o quitarla según sea necesario.
            this.tb_donacionTableAdapter.Fill(this.db_asiloDataSet.tb_donacion);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_ingresos' Puede moverla o quitarla según sea necesario.
            this.tb_ingresosTableAdapter.Fill(this.db_asiloDataSet.tb_ingresos);
            // TODO: esta línea de código carga datos en la tabla 'db_asiloDataSet.tb_tipo' Puede moverla o quitarla según sea necesario.
            this.tb_tipoTableAdapter.Fill(this.db_asiloDataSet.tb_tipo);
            comboBox_tipoingreso.SelectedIndex = 0;
            llenardatos_subtipo();
            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(combo_categoria.Text));
            perecedero = Convert.ToInt32(this.tb_tipoTableAdapter.Obtener_perecedero(id_tipos));
            if (perecedero == 1)
            {
                panel_vencimieto.Visible = true;
            }
            else
            {
                panel_vencimieto.Visible = false;
            }
        }

        private void comboBox_tipoingreso_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox_tipoingreso.Text == "Donación")
            {
                donante = 1;
                paneldonador.Visible = true;
                llenardatos_donantes();

            }else
            {
                donante = 0;
                paneldonador.Visible = false;
            }
        }

        private void combo_donante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_donante.Text == "Nuevo")
            {
                panel13.Visible = true;
                txt_donante.Text = "Nombre";
            }else
            {
                panel13.Visible = false;
            }
        }

        private void txt_donante_Click(object sender, EventArgs e)
        {
            if (txt_donante.Text == "Nombre")
            {
                txt_donante.Text = "";
            }
        }

        private void txt_donante_Leave(object sender, EventArgs e)
        {
            if (txt_donante.Text.Length == 0)
            {
                txt_donante.Text = "Nombre";
            }
        }

        private void combo_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenardatos_subtipo();
            llenardatos_objetos();
            int id_tipos = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(combo_categoria.Text));
            perecedero = Convert.ToInt32(this.tb_tipoTableAdapter.Obtener_perecedero(id_tipos));
            if (perecedero == 1)
            {
                panel_vencimieto.Visible = true;
            }else
            {
                panel_vencimieto.Visible = false;
            }
        }

        private void combo_subcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenardatos_objetos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (combo_categoria.Text.Length == 0 || combo_subcategoria.Text.Length == 0 || combo_producto.Text.Length == 0)
            {
                //Marca Mensaje de error
            }else
            {
                int ID_tipo = Convert.ToInt32(this.tb_tipoTableAdapter.Consultar_id(combo_categoria.Text));
                int ID_subtipo = Convert.ToInt32(this.tb_subtipoTableAdapter.obtener_idsubtipo(ID_tipo, combo_subcategoria.Text));
                int ID_objeto = Convert.ToInt32(this.tb_objetoTableAdapter.obtener_id(combo_producto.Text,ID_tipo,ID_subtipo));
                //Verifica si es perecedero o no par guardar fecha de vencimiento
                if (perecedero == 1)
                {
                    //Ve si la fecha de vencimiento es mayor a la de hoy
                    if (fecha < date_fechavencimiento.Value)
                    {
                        //verifica si hay donante o no
                        if (donante ==1)
                        {
                            //Ve si es necesario ingresar al donante
                            if (combo_donante.Text == "Nuevo")
                            {
                                this.tb_ingresosTableAdapter.Ingresar(ID_objeto, Convert.ToInt32(numeric_cantidad.Value), Convert.ToString(fecha), Convert.ToString(date_fechavencimiento.Value));
                                this.tb_donacionTableAdapter.Ingresar_donacion(txt_donante.Text, Convert.ToString(fecha), ID_objeto, Convert.ToInt32(numeric_cantidad.Value));
                                int cantidad_actual = Convert.ToInt32(this.tb_inventarioTableAdapter.Obtener_cantidad(ID_objeto));
                                int nueva_cantidad = cantidad_actual + Convert.ToInt32(numeric_cantidad.Value);
                                int ID_Inver = Convert.ToInt32(this.tb_inventarioTableAdapter.Obtener_id(ID_objeto));
                                this.tb_inventarioTableAdapter.Actualizar_inventario(nueva_cantidad, ID_objeto, ID_Inver);
                                this.tb_reportesTableAdapter.AgregarRegistro(ID_objeto, Convert.ToInt32(numeric_cantidad.Value), Convert.ToString(fecha), "Ingreso");
                                //Mensaje Agregado cambiar
                                MessageBox.Show("Ingresado");
                            }
                            else
                            {
                                this.tb_ingresosTableAdapter.Ingresar(ID_objeto, Convert.ToInt32(numeric_cantidad.Value), Convert.ToString(fecha), Convert.ToString(date_fechavencimiento.Value));
                                this.tb_donacionTableAdapter.Ingresar_donacion(combo_donante.Text, Convert.ToString(fecha), ID_objeto, Convert.ToInt32(numeric_cantidad.Value));
                                int cantidad_actual = Convert.ToInt32(this.tb_inventarioTableAdapter.Obtener_cantidad(ID_objeto));
                                int nueva_cantidad = cantidad_actual + Convert.ToInt32(numeric_cantidad.Value);
                                int ID_Inver = Convert.ToInt32(this.tb_inventarioTableAdapter.Obtener_id(ID_objeto));
                                this.tb_inventarioTableAdapter.Actualizar_inventario(nueva_cantidad, ID_objeto, ID_Inver);
                                this.tb_reportesTableAdapter.AgregarRegistro(ID_objeto, Convert.ToInt32(numeric_cantidad.Value), Convert.ToString(fecha), "Ingreso");
                                //Mensaje Agregado cambiar
                                MessageBox.Show("Ingresado");
                            }
                        }else
                        {
                            //Ingresa Normal Compra
                            this.tb_ingresosTableAdapter.Ingresar(ID_objeto, Convert.ToInt32(numeric_cantidad.Value), Convert.ToString(fecha), Convert.ToString(date_fechavencimiento.Value));
                            int cantidad_actual = Convert.ToInt32(this.tb_inventarioTableAdapter.Obtener_cantidad(ID_objeto));
                            int nueva_cantidad = cantidad_actual + Convert.ToInt32(numeric_cantidad.Value);
                            int ID_Inver = Convert.ToInt32(this.tb_inventarioTableAdapter.Obtener_id(ID_objeto));
                            this.tb_inventarioTableAdapter.Actualizar_inventario(nueva_cantidad, ID_objeto, ID_Inver);
                            this.tb_reportesTableAdapter.AgregarRegistro(ID_objeto, Convert.ToInt32(numeric_cantidad.Value), Convert.ToString(fecha), "Ingreso");
                            //Mensaje Agregado cambiar
                            MessageBox.Show("Ingresado");
                        }
                    }else
                    {
                        //No lo guarda agregar mensaje de error aqui
                    }
                }else
                {
                    //verifica si hay donante o no
                    if (donante == 1)
                    {
                        //Ve si es necesario ingresar al donante
                        if (combo_donante.Text == "Nuevo")
                        {
                            this.tb_ingresosTableAdapter.Ingresar(ID_objeto, Convert.ToInt32(numeric_cantidad.Value), Convert.ToString(fecha), Convert.ToString(date_fechavencimiento.Value));
                            this.tb_donacionTableAdapter.Ingresar_donacion(txt_donante.Text, Convert.ToString(fecha), ID_objeto, Convert.ToInt32(numeric_cantidad.Value));
                            int cantidad_actual = Convert.ToInt32(this.tb_inventarioTableAdapter.Obtener_cantidad(ID_objeto));
                            int nueva_cantidad = cantidad_actual + Convert.ToInt32(numeric_cantidad.Value);
                            int ID_Inver = Convert.ToInt32(this.tb_inventarioTableAdapter.Obtener_id(ID_objeto));
                            this.tb_inventarioTableAdapter.Actualizar_inventario(nueva_cantidad, ID_objeto, ID_Inver);
                            this.tb_reportesTableAdapter.AgregarRegistro(ID_objeto, Convert.ToInt32(numeric_cantidad.Value), Convert.ToString(fecha), "Ingreso");
                            //Mensaje Agregado cambiar
                            MessageBox.Show("Ingresado");
                        }
                        else
                        {
                            this.tb_ingresosTableAdapter.Ingresar(ID_objeto, Convert.ToInt32(numeric_cantidad.Value), Convert.ToString(fecha), Convert.ToString(date_fechavencimiento.Value));
                            this.tb_donacionTableAdapter.Ingresar_donacion(combo_donante.Text, Convert.ToString(fecha), ID_objeto, Convert.ToInt32(numeric_cantidad.Value));
                            int cantidad_actual = Convert.ToInt32(this.tb_inventarioTableAdapter.Obtener_cantidad(ID_objeto));
                            int nueva_cantidad = cantidad_actual + Convert.ToInt32(numeric_cantidad.Value);
                            int ID_Inver = Convert.ToInt32(this.tb_inventarioTableAdapter.Obtener_id(ID_objeto));
                            this.tb_inventarioTableAdapter.Actualizar_inventario(nueva_cantidad, ID_objeto, ID_Inver);
                            this.tb_reportesTableAdapter.AgregarRegistro(ID_objeto, Convert.ToInt32(numeric_cantidad.Value), Convert.ToString(fecha), "Ingreso");
                            //Mensaje Agregado cambiar
                            MessageBox.Show("Ingresado");
                        }
                    }
                    else
                    {
                        //Ingresa Normal Compra
                        this.tb_ingresosTableAdapter.Ingresar(ID_objeto, Convert.ToInt32(numeric_cantidad.Value), Convert.ToString(fecha), Convert.ToString(date_fechavencimiento.Value));
                        int cantidad_actual = Convert.ToInt32(this.tb_inventarioTableAdapter.Obtener_cantidad(ID_objeto));
                        int nueva_cantidad = cantidad_actual + Convert.ToInt32(numeric_cantidad.Value);
                        int ID_Inver = Convert.ToInt32(this.tb_inventarioTableAdapter.Obtener_id(ID_objeto));
                        this.tb_inventarioTableAdapter.Actualizar_inventario(nueva_cantidad, ID_objeto, ID_Inver);
                        this.tb_reportesTableAdapter.AgregarRegistro(ID_objeto, Convert.ToInt32(numeric_cantidad.Value), Convert.ToString(fecha), "Ingreso");
                        //Mensaje Agregado cambiar
                        MessageBox.Show("Ingresado");
                    }
                }
            }
        }
    }
}
