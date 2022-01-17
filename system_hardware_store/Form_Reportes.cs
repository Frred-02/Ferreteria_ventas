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
    public partial class Form_Reportes : Form
    {
        public Form_Reportes()
        {
            InitializeComponent();
        }

        private void Form_Reportes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
