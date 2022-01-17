using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapasDatos2;
namespace system_hardware_store
{
    
    public partial class Form_Ventas : Form
    {

        // (IMPORTANTE EL TRUE PARA ACTIVAR )cuando no se esta usando el MENTODO IsNuevo
        //false para  poder usar los botones  y el metodo (IsNuevo)
        private bool IsNuevo = false;
        private bool IsEditar = false;

        /*declaramos  2 variable*/
        // LA TABLA
        private DataTable dtDetalle;

        //PAGO
        private decimal totalPagado = 0;

        //se crea un metodo instancia
        private static Form_Ventas _instancia;

        //se crea un metodo  getintancia(IMPORTANTE SE DEVE INSTANCIAR  ENLOS FORMULARIOS AL MOMENTO DE EJECUTAR)
        public static Form_Ventas GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Form_Ventas();
            }
            return _instancia;
        }

        //PARA LLAMR LA CAJAS DE TEXTO
        public void setCliente(string _idcliente, string nombre)
        {
            this.txtidcliente.Text = _idcliente;
            this.txtnombrecli.Text = nombre;
            
        }

        public void setproductoo(string idproducto, string nombre, string stock, string precio)
        {

            this.txtidproducto.Text = idproducto;
            this.txtproducto.Text = nombre;
            this.txtstock.Text = stock;
            this.txtprecio.Text = precio;


        }
        //

            /*METODO DE  BUSCAR FECHAS DE VENTAS */

            private void buscarfechas ()
        {
            this.listaventa.DataSource = NVentas.buscarfechas(this.fecha1.Value.ToString("dd/MM/yyyy"),
                this.fecha2.Value.ToString("dd/MM/yyyy"));

        }

        /*METODO PARA OCULTAR COLUMNA*/

            private void ocularcolumnas()
        {
            this.listaventa.Columns[0].Visible = false;
            this.listaventa.Columns[1].Visible = false;
        }

        //MENSAJE DE ERROR
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro  de ventas fallados", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        /*--------------------------------------------------*/

        public Form_Ventas()
        {
            InitializeComponent();
            //para no modificar la caja de texto
            // poner el boton ocualto
            /*this.txt_nombre.ReadOnly = true;*/
           /* this.txt_idcliente.Visible = false;*/
           
        }
       
        //llamar el formulario clientes
        private void button1_Click(object sender, EventArgs e)
        {
            
            Formseleccliente fr = new Formseleccliente();

           


            fr.ShowDialog();

            

        }
        /** creamos un metodo tabla para mostrar LA LISTA DE PRODUCTOS EN VENTAS*/
        private void crearTabla()
        {
            this.dtDetalle = new DataTable("fdfdsf");
            this.dtDetalle.Columns.Add("idproducto", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Nombre_product", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));

            this.dtDetalle.Columns.Add("Precio", System.Type.GetType("System.Decimal"));

            this.dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));

            //Relacionar nuestro DataGRidView con nuestro DataTable
            this.dataListadoDetalle.DataSource = this.dtDetalle;

        }

        /*MOSTRAR TABLA DE VENTAS*/
        private void Mostrar_ventas()
        {
            this.listaventa.DataSource = NVentas.mostrar();
            this.ocularcolumnas();

        }

       /* private void icon_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        */
        private void Form_Ventas_Load(object sender, EventArgs e)
        {

            /*MUY IMPORTANTE INGRESAR crearTable PARA INSTANCIAR EL DATABLE*/
            this.crearTabla();


            Mostrar_ventas();

            this.Botones();


          
        }


        private void habilitar(bool valor)
        {
            

        }

        //habilitar botones
        private void Botones()
        {
            if(this.IsNuevo)
            {

               /*EL BOTON NUEVO */
                this.btnnuevo.Enabled = false;
               
                
                this.btn_guardar.Enabled = true;
                this.btneliminar.Enabled = true;
                this.btneditar.Enabled = true;
                this.btnanulacompra.Enabled = true;
                this.btncomprar.Enabled = true;

            }

            else
            {
                /*BOION NUEVO*/
                this.btnnuevo.Enabled = true;



                this.btn_guardar.Enabled = false;
                this.btneliminar.Enabled = false;
                this.btneditar.Enabled = false;
                this.btnanulacompra.Enabled = false;
                this.btncomprar.Enabled = false;

            }
        }

        /*limpiar*/
        private void limpiar()
        {
            this.txtidcliente.Text = string.Empty;
            this.txtnombrecli.Text = string.Empty;
            this.txtserie.Text = string.Empty;
            


            /*produdctos*/

            this.crearTabla();
            this.txt_igv.Text = "18";

        }


        /*limpia las casiilas al agregar al carrito de compras*/
        private void limpiardetallesventas()
        {
            this.txtcantidad.Text = string.Empty;
            this.txtprecio.Text = string.Empty;
            this.txtstock.Text = string.Empty;
            this.txtproducto.Text = string.Empty;
            this.txtidproducto.Text = string.Empty;
        }

        /*-------------------------------------------------*/
        private void btn_guardar_Click(object sender, EventArgs e)
        {
           

            try
            {
                // variable 
                string rpta = "";
                // es un canpo oligatorio   mostrar error cuando el campo esta vacio
                if (this.cbTipo_Comprobante.Text == string.Empty || this.txtserie.Text == string.Empty )
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");

                }

                else
                {

                    if(this.IsNuevo)
                    {
                        rpta = NVentas.Insertar(Convert.ToInt32(this.txtidcliente.Text), cbTipo_Comprobante.Text, txtserie.Text,txt_fecha.Value,Convert.ToDecimal(txt_igv.Text),dtDetalle);
                        

                    }

                    else
                    {

                    }
                    if(rpta.Equals("OK"))
                    {

                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        }

                        else
                        {

                        }
                    }

                    else
                    {
                        this.MensajeError(rpta);
                    }


                    /*MOSTRAR LA TABLA VENTAS*/

                    this.Mostrar_ventas();
                    this.Botones();
                    this.limpiar();
                    this.limpiardetallesventas();

                    this.IsNuevo = false;


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }


            
        }
      

        private void cerrar_venta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
          

        }

        private void dataGridView1_Click(object sender,DataGridViewCellEventArgs   e)
        {

            




          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {



           

        }


        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "REGISTRO DE CLIENTES", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in listaventa.Rows)
                    {
                        /*(Convert.ToBoolean(row.Cells[0].Value))*/
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {

                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NVentas.Eliminarventa(Convert.ToInt32(Codigo));

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
                    this.Mostrar_ventas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }



        }

       



        //seleciomas  FormClosed para cerrar la instancia
      
        private void Form_Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            Botones();
            this.limpiar();
            this.limpiardetallesventas();
            
        }

        private void listaventa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaventa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           /* Form_registroventa registvent = new Form_registroventa();

            listaventa.CurrentRow.Selected = true;
            registvent.txtidventa.Text = listaventa.Rows[e.RowIndex].Cells["idventa"].FormattedValue.ToString();
          /*  registvent.txtidcliente.Text = listaventa.Rows[e.RowIndex].Cells["idcliente"].FormattedValue.ToString();
            registvent.txtnombrecli.Text = listaventa.Rows[e.RowIndex].Cells["nombre"].FormattedValue.ToString();
            registvent.cbotipodocu.Text = listaventa.Rows[e.RowIndex].Cells["tipodocumento"].FormattedValue.ToString();
            registvent.txtnumerodoc.Text = listaventa.Rows[e.RowIndex].Cells["numerodocumento"].FormattedValue.ToString();
            registvent.Show();
            this.Hide();*/
        }

        private void checkeliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkeliminar.Checked)
            {
                this.listaventa.Columns[0].Visible = true;
            }
            else
            {
                this.listaventa.Columns[0].Visible = false;
            }
        }

        private void listaventa_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtfecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_enlace_cli_Click(object sender, EventArgs e)
        {
            Formseleccliente cli = new Formseleccliente();
            cli.ShowDialog();
        }

        private void btn_enlace_prod_Click(object sender, EventArgs e)
        {
            Formselecproducto prod = new Formselecproducto();
            prod.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (this.txtidproducto.Text == string.Empty)
                /* || this.txtPrecio_Venta.Text == string.Empty)*/
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                }
                else
                {
                    bool registrar = true;
                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        if (Convert.ToInt32(row["idproducto"]) == Convert.ToInt32(this.txtidproducto.Text))
                        {
                            registrar = false;
                            this.MensajeError("YA se encuentra el artículo en el detalle");
                        }
                    }
                    if (registrar && Convert.ToInt32(txtcantidad.Text) <= Convert.ToInt32(txtstock.Text))
                    {
                        decimal subTotal = Convert.ToDecimal(this.txtcantidad.Text) * Convert.ToDecimal(this.txtprecio.Text);
                        totalPagado = totalPagado + subTotal;

                        //Agregar ese detalle al datalistadoDetalle
                        DataRow row = this.dtDetalle.NewRow();
                        row["idproducto"] = Convert.ToInt32(this.txtidproducto.Text);
                        row["Nombre_product"] = this.txtproducto.Text;
                        row["Cantidad"] = Convert.ToInt32(this.txtcantidad.Text);
                        row["precio"] = Convert.ToDecimal(this.txtprecio.Text);

                        row["subtotal"] = subTotal;
                        this.dtDetalle.Rows.Add(row);
                        this.limpiardetallesventas();


                    }
                    else
                    {
                        MensajeError("No hay Stock Suficiente");
                    }




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_reportventas frm = new Form_reportventas();
            frm.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.buscarfechas();
        }
    }
}
