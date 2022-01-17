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
    public partial class FormulariolistaCATEGORIA : Form
    {
        public FormulariolistaCATEGORIA()
        {
            InitializeComponent();
        }

        private void mostrarlistadocategoria()
        {
            this.listadocategoria.DataSource = NCategoria.mostrarcat();
            this.OcultarColumnas();
        }



        private void FormulariolistaCATEGORIA_Load(object sender, EventArgs e)
        {
            
            mostrarlistadocategoria();
         

        }

        private void OcultarColumnas()
        {
            this.listadocategoria.Columns[0].Visible = false;
            this.listadocategoria.Columns[1].Visible = false;
        }

        private void listadocategoria_DoubleClick(object sender, EventArgs e)
        {
            Form_Productos product = Form_Productos.GetInstancia();

            string par1, par2;
            /*MUY IMPORTANTE MUY IMPORTANTE  PONER LOS MISMOS NOMBRES COMO ESTA EN LA TABLA*/
            par1 = Convert.ToString(this.listadocategoria.CurrentRow.Cells["Id"].Value);
            par2 = Convert.ToString(this.listadocategoria.CurrentRow.Cells["Categoria"].Value);
            product.setcategoria(par1, par2);
            this.Hide();
        }
    }
}
