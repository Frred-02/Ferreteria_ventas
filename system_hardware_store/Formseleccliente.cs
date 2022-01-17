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
    public partial class Formseleccliente : Form
    {
        public Formseleccliente()
        {
            InitializeComponent();
        }

        private void OcultarColumnas()
        {

            

        }


        private void Buscarclientes()
        {
            this.clientelistado.DataSource = NClientes.buscarcliente(this.txtBuscar.Text);
            this.OcultarColumnas();
            lbregistro.Text = "Total de Registros: " + Convert.ToString(clientelistado.Rows.Count);
        }




        private void Mostrarclientes()
        {

            this.clientelistado.DataSource = NClientes.Mostrar();

            this.OcultarColumnas();
            lbregistro.Text = " Clientes Registrados: " + Convert.ToString(clientelistado.Rows.Count);
        }

       
        private void Formseleccliente_Load(object sender, EventArgs e)
        {
            Mostrarclientes();
        }

       
       
       

        private void clientelistado_DoubleClick_1(object sender, EventArgs e)
        {
                  Form_Ventas ventas = Form_Ventas.GetInstancia();
            

            string par1, par2;
             par1 = Convert.ToString(this.clientelistado.CurrentRow.Cells["idcliente"].Value);
            par2 = Convert.ToString(this.clientelistado.CurrentRow.Cells["Nombre"].Value) +" "+
                Convert.ToString(this.clientelistado.CurrentRow.Cells["Apellidos"].Value);
            ventas.setCliente(par1, par2);
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Apellidos"))
            {
                this.Buscarclientes();
                
            }
        }
    }
    
}
