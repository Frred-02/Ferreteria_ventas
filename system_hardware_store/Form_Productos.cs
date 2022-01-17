using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//IMPORTAMOS
using CapasDatos2;



namespace system_hardware_store
{
    public partial class Form_Productos : Form
    {  
        // IMPORTANTE EL TRUE Y FALSA PARA ACTIVAR 
        private bool IsNuevo = true;
        private bool IsEditar = false;

        private static Form_Productos _instancia;

        //se crea un metodo  getintancia(IMPORTANTE SE DEVE INSTANCIAR  ENLOS FORMULARIOS AL MOMENTO DE EJECUTAR)
        public static Form_Productos GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Form_Productos();
            }
            return _instancia;
        }


        //para llenar la caja de texto

            public void setcategoria(  string _idcategoria,  string nombrecat)
        {
            //this.txtidcategoria.Text = _idcategoria;
            this.txtidcategoria.Text = _idcategoria;
            this.txtcategoria.Text = nombrecat;
        }

        public Form_Productos()
        {
            InitializeComponent();

            /*OCULTAR EL TEXTO*/
            //this.txt_idproduct.Visible = false;
        }


        /**METODO BUCAR PRODUCTOS */

            private void  buscarproducto()
        {
            this.datalistado.DataSource = NProductos.buscarproducto(this.txt_buscar.Text);


        }


         
         
         
       

        /*IMPORTANTE */
        //Mostrar Mensaje de Error

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //ocultar COLUMNA
        private void OcultarColumnas()
        {
            this.datalistado.Columns[0].Visible = false;
            this.datalistado.Columns[1].Visible = false;
            this.datalistado.Columns[2].Visible = false;

        }




        /*----------------------------------------------------------------------------*/

        private void icon_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)

        {

            try
            {    // variable 
                string rpta = "";
                // es un canpo oligatorio   mostrar error cuando el campo esta vacio
                if (this.txt_nombre.Text == string.Empty || this.txt_descripcion.Text == string.Empty || this.txt_marca.Text == string.Empty || this.txt_precio.Text == string.Empty || this.txt_precio.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");

                }
                else


                {
                    if (this.IsNuevo)
                    {
                        // trim para borrar los espacios en blanco
                        //comvertir  ToUpper letras en mayuscula
                        rpta = NProductos.Insertar(Convert.ToInt32(this.txtidcategoria.Text),txt_nombre.Text,
                             txt_descripcion.Text, txt_marca.Text, Convert.ToDecimal(this.txt_precio.Text), Convert.ToInt32(txt_stock.Text),txtfecha.Value);
                      /* Mostrarproductos();*/
                    }
                    else
                    {
                        /* rpta = NCategoria.Editar(Convert.ToInt32(this.txtIdcategoria.Text),
                             this.txtNombre.Text.Trim().ToUpper(),
                             this.txtDescripcion.Text.Trim());*/
                    }
                    // OK es una respuesta
                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.Mostrarproductos();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            

        }


        /*MOSTRAR */
        private void Mostrarproductos()
        {

            datalistado.DataSource = NProductos.Mostrar();

            this.OcultarColumnas();

            lblistado.Text = "Total de Registros: " + Convert.ToString(datalistado.Rows.Count);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Productos_Load(object sender, EventArgs e)
        {
            Mostrarproductos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //propiedades selecionar la modifires  y poner publico el text

           /*Form_registroventa detalle = new Form_registroventa();

            dataGridView1.CurrentRow.Selected = true;
            detalle.txtidproducto.Text = dataGridView1.Rows[e.RowIndex].Cells["idproducto"].FormattedValue.ToString();
            detalle.txtproducto.Text = dataGridView1.Rows[e.RowIndex].Cells["Nombre_product"].FormattedValue.ToString();
            detalle.Show();
            this.Hide();*/
         
           

        }

        private void cerrar_producto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void Form_Productos_Load_1(object sender, EventArgs e)
        {
            Mostrarproductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "REGISTRO DE CLIENTES", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in datalistado.Rows)
                    {
                        /*(Convert.ToBoolean(row.Cells[0].Value))*/
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {

                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NProductos.Eliminarprod(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Eliminó Correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Mostrarproductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void Form_Productos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void btnenlacecatego_Click(object sender, EventArgs e)
        {
            FormulariolistaCATEGORIA fr = new FormulariolistaCATEGORIA();




            fr.ShowDialog();
        }

        private void checeliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (checeliminar.Checked)
            {
                this.datalistado.Columns[0].Visible = true;
            }
            else
            {
                this.datalistado.Columns[0].Visible = false;
            }
        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == datalistado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)datalistado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }

        }


        /*REPORTES PRODUCTOS*/
        private void btnimprimir_Click(object sender, EventArgs e)
        {
            Form_reporteproductos prod = new Form_reporteproductos();
            prod.texto = txt_buscar.Text;
            prod.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbobuscar.Text.Equals("Producto"))
            {
                this.buscarproducto();

            }
        }
    }
}