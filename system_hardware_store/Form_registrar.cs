using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/**/
using CapasDatos2;
 

namespace system_hardware_store
{
    public partial class Form_registrar : Form

    
    {
        private bool Isnuevo = true;



        public Form_registrar()
        {
            InitializeComponent();
        }


        /**/

        private void  Mensajeok(string Mensaje)
        {
            MessageBox.Show(Mensaje, "usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /**/
        private void Mensajeerror(string Mensaje)
        {
            MessageBox.Show(Mensaje, "usuario error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string rpta = "";

                if (this.txtcorreo.Text== string.Empty) 
                {

                }

                else
                {
                    if(this.Isnuevo)
                    {
                        rpta = NUsuarios.insertar(this.txtnombre.Text, this.txtapellidos.Text, this.txtdni.Text, this.txtelefono.Text, this.txtcorreo.Text,
                            this.cboaccceso.Text, this.txtusuario.Text, this.txtpassw.Text);


                    }

                    else
                    {

                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.Isnuevo)
                        {
                            this.Mensajeok("Se insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.Mensajeok("Se actualizó de forma correcta el registro");
                        }

                        


                    }

                    else
                    {
                        this.Mensajeerror(rpta);
                    }

                }


            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message + ex.StackTrace);
            }


        }
    }
}
