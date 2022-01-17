using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//importamos
using CapasDatos2;

namespace system_hardware_store
{
    public partial class Formselecproducto : Form
    {
        public Formselecproducto()
        {
            InitializeComponent();
        }


        private void Mostrarprocutos()
        {
            productolistado.DataSource = NProductos.Mostrar();
            lbregistro.Text = " Clientes Registrados: " + Convert.ToString(productolistado.Rows.Count);
        }

        private void productolistado_DoubleClick(object sender, EventArgs e)
        {
            
            Form_Ventas registrovent = Form_Ventas.GetInstancia();


            string par1, par2,par3,par4;
            par1 = Convert.ToString(this.productolistado.CurrentRow.Cells["idproducto"].Value);
            par2 = Convert.ToString(this.productolistado.CurrentRow.Cells["Nombre_product"].Value);
            par3 = Convert.ToString(this.productolistado.CurrentRow.Cells["Stock"].Value);
            par4 = Convert.ToString(this.productolistado.CurrentRow.Cells["Precio"].Value);
            registrovent.setproductoo(par1, par2,par3,par4);
            this.Hide();

        }

        private void Formselecproducto_Load(object sender, EventArgs e)
        {



            Mostrarprocutos();
        }
    }
}
