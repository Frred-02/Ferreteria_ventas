using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system_hardware_store
{
    public partial class Form_reporte_cliente : Form

    {

        /*creamos una variable  y metodo*/

        public string texto_;

        /*creamos un  metodo*/

            public string texto
        {
            get { return texto_; }
            set { texto_ = value; }
        }

        public Form_reporte_cliente()
        {
            InitializeComponent();
        }

        private void Form_reporte_cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Datosprincipal.buscarcliente_apellidos' Puede moverla o quitarla según sea necesario.
            this.buscarcliente_apellidosTableAdapter.Fill(this.Datosprincipal.buscarcliente_apellidos,texto);
            // TODO: esta línea de código carga datos en la tabla 'Datosprincipal.ventas' Puede moverla o quitarla según sea necesario.
            

            this.reportViewer1.RefreshReport();
            
        }
    }
}
