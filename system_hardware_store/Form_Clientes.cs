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
    public partial class Form_Clientes : Form
    {

        // IMPORTANTE EL TRUE Y FALSA PARA ACTIVAR 
        private bool IsNuevo = true;
        private bool IsEditar = false;

        public Form_Clientes()
        {
            InitializeComponent();
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
            this.clientelistado.Columns[0].Visible = false;
            this.clientelistado.Columns[1].Visible = false;

        }



        // MOSTRAR CLIENTES
        private void Mostrarclientes()
        {
          
            clientelistado.DataSource = NClientes.Mostrar();
            this.OcultarColumnas();

            lbregistro.Text = " Clientes Registrados: " + Convert.ToString(clientelistado.Rows.Count);
        }


        private void limpiar()
        {

            this.txt_nombre.Text = string.Empty;
            this.txt_idcliente.Text = string.Empty;
            this.txt_apellidos.Text = string.Empty;
            this.txtnumerodocum.Text = string.Empty;

        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                // variable 
                string rpta = "";
                // es un canpo oligatorio   mostrar error cuando el campo esta vacio
                if (this.txt_nombre.Text == string.Empty || this.txt_apellidos.Text == string.Empty || this.txtnumerodocum.Text == string.Empty )
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");

                }


                else
                {

                    if(this.IsNuevo)

                    {
                        // trim para borrar los espacios en blanco
                        //
                        rpta = NClientes.Insertar(this.txt_nombre.Text.Trim(),
                             txt_apellidos.Text, this.cbTipo_Documento.Text,txtnumerodocum.Text,txttelef.Text,txtcorreo.Text);

                       
                    }
                    else

                    {

                    }
                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        }
                        else
                        {
                            /*this.MensajeOk("Se Actualizó de forma correcta el registro");*/
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }


                    this.Mostrarclientes();
                }



            }
            catch (Exception)
            {

                throw;
            }




          


        }
        
        
        /*  METODOS BUSCAR APELLIDOS */

            private void buscarapellidos()
        {
            this.clientelistado.DataSource = NClientes.buscarcliente(this.txtBuscar.Text);
            this.OcultarColumnas();
        }



        private void Form_Clientes_Load(object sender, EventArgs e)
        {
            //mostrar en el formulario//
            Mostrarclientes();
          
        }



        /*private void icon_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        */

        //selecionar 
        private void clientelistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == clientelistado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)clientelistado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }




            /*importante selecionar los textos  y ponerlo en publico propiedades modifireis*/
            /*Form_Ventas ventas = new Form_Ventas();
            DataGridViewRow rellenar = clientelistado.Rows[e.RowIndex];
            ventas.txt_idcliente.Text = rellenar.Cells["idcliente"].Value.ToString();
            ventas.txt_nombre.Text = rellenar.Cells["Nombre"].Value.ToString();
            ventas.ShowDialog();*/
        }

        private void clientelistado_CellClick(object sender, DataGridViewCellEventArgs e)

            //selecinar un fila de  texto en datagriew//
        {


            txt_idcliente.Text = clientelistado.SelectedRows[0].Cells[0].Value.ToString();
            txt_nombre.Text = clientelistado.SelectedRows[0].Cells[1].Value.ToString();
            txt_apellidos.Text = clientelistado.SelectedRows[0].Cells[2].Value.ToString();
            txtnumerodocum.Text = clientelistado.SelectedRows[0].Cells[3].Value.ToString();
         
            
        }

        private void clientelistado_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {

        }

        private void clientelistado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            

           
        }

        private void txtidcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cerrar_cliente_Click(object sender, EventArgs e)
        {
            //cerrrar la venta cliente//
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "REGISTRO DE CLIENTES", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in clientelistado.Rows)
                    {
                        /*(Convert.ToBoolean(row.Cells[0].Value))*/
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {

                            Codigo = Convert.ToString(row.Cells[1].Value);
                        Rpta = NClientes.Eliminarcli(Convert.ToInt32(Codigo));

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
                    this.Mostrarclientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }



            /*  NClientes client = new NClientes();
              client.idcliente = Convert.ToInt32(txt_idcliente.Text);
              client.Eliminarclientes();
              /*ListarClientes();*/


        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        // para habilitar
        private void checkeliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkeliminar.Checked)
            {
                this.clientelistado.Columns[0].Visible = true;
            }
            else
            {
                this.clientelistado.Columns[0].Visible = false;
            }
        }

        private void lbregistro_Click(object sender, EventArgs e)
        {

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (cbBuscar.Text.Equals("Apellidos")) 
            {
                this.buscarapellidos();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_reporte_cliente form = new Form_reporte_cliente();
            form.texto = txtBuscar.Text;
            form.ShowDialog();

        }
    }
}
