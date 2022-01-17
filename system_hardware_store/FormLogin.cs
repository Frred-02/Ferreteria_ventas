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
    public partial class FormLogin : Form
    {
        private static Form_Ventas _instancia;
        public static Form_Ventas GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Form_Ventas();
            }
            return _instancia;
        }

        public FormLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text =="Usuario")
            {
                txtuser.Text ="";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txt_contrasena_Enter(object sender, EventArgs e)
        {
            if (txtcontrasena.Text == "Contraseña")
            {
                txtcontrasena.Text = "";
                txtcontrasena.ForeColor = Color.LightGray;
                txtcontrasena.UseSystemPasswordChar = true;
            }
        }

        private void txt_contrasena_Leave(object sender, EventArgs e)
        {
            if (txtcontrasena.Text == "")
            {
                txtcontrasena.Text = "Contraseña";
                txtcontrasena.ForeColor = Color.DimGray;
                txtcontrasena.UseSystemPasswordChar = false;
            }
        }

        private void icon_serrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icon_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

            DataTable datos = CapasDatos2.NUsuarios.entrada(this.txtuser.Text, this.txtcontrasena.Text);
            if(datos.Rows.Count==0)
            {
                MessageBox.Show("NO Tiene Acceso al Sistema", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                Form_Principal pri = new Form_Principal();
               pri.idusuario = datos.Rows[0][0].ToString();
                pri.Apellidos = datos.Rows[0][1].ToString();
                pri.Nombre = datos.Rows[0][2].ToString();
                pri.Acceso = datos.Rows[0][3].ToString();

                pri.Show();
                this.Hide();

            }

        }

        
private void timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    

}
