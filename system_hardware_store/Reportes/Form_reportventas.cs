using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*boorar el nonmbre reporte  y tanbien en el diseñador*/
 //*selecinar la flecha del registro*

namespace system_hardware_store
{
    public partial class Form_reportventas : Form
    {
        public Form_reportventas()
        {
            InitializeComponent();
        }

        private void Form_reportventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Datosprincipal.ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.Datosprincipal.ventas);

            this.reportViewer1.RefreshReport();
        }
    }
}
