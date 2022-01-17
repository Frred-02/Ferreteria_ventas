using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace system_hardware_store
{
    public partial class Form_Principal : Form
    {

        /* creamos variables */

        public string idusuario = "";
        public string Apellidos = "";
        public string Nombre = "";
        public string Acceso = "";

       
       
        public Form_Principal( )
        {
            

            InitializeComponent();
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,int wparam, int lparam);
        private void menuslide_Click(object sender, EventArgs e)
        {
            if (panel_menu_vertical.Width == 250)
            {
                panel_menu_vertical.Width = 70;
            }
            else {
                panel_menu_vertical.Width = 250;
            }
        }

        private void icon_cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de cerrar..?","alerta..!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                 {
                Application.Exit();
            }
            
            else{
            }
        }

        private void icon_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            icon_restaurar.Visible = true;
            icon_maximizar.Visible = false;
        }

        private void icon_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            icon_restaurar.Visible = false;
            icon_maximizar.Visible = true;
        }

        private void icon_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_barra_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }
        

        private void btn_productos_Click(object sender, EventArgs e)
        {
            Form_Productos form = Form_Productos.GetInstancia();
            form.ShowDialog();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
           
            Form_Ventas form = Form_Ventas.GetInstancia();
            

            form.Show();

        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Form_Clientes());
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Form_Reportes());
        }
        //metodo para llamar a los formularios hijos
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(fh);
            this.panel_contenedor.Tag = fh;
            fh.Show();


        }

        private void panel_menu_vertical_Paint(object sender, PaintEventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Form_registrar());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void btncategoria_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Form_categoria());
        }

        private void panel_barra_titulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

