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
    public partial class Formselecventas : Form
    {
        public Formselecventas()
        {
            InitializeComponent();
        }

        private void Mostrarclientes()
        {

            this.ventalistado.DataSource = NVentas.mostrar();

            //this.OcultarColumnas();
            lbregistro.Text = " Clientes Registrados: " + Convert.ToString(ventalistado.Rows.Count);
        }

        private void ventalistado_DoubleClick(object sender, EventArgs e)
        {
           

        }

        private void Formselecventas_Load(object sender, EventArgs e)
        {
            Mostrarclientes();
        }
    }
}
