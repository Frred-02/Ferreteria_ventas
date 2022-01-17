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
    public partial class Form_reporteproductos : Form
    {
        /*creamos una variable  y metodo*/

        public string texto_;

        /*creamos un  metodo*/

        public string texto
        {
            get { return texto_; }
            set { texto_ = value; }
        }



        public Form_reporteproductos()
        {
            InitializeComponent();
        }

        private void Form_reporteproductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Datosprincipal.buscarproducto' Puede moverla o quitarla según sea necesario.
            this.buscarproductoTableAdapter.Fill(this.Datosprincipal.buscarproducto,texto);

            this.reportViewer1.RefreshReport();
        }
    }
}
