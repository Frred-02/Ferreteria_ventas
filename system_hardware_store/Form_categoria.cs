using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
using CapasDatos2;
namespace system_hardware_store
{
    public partial class Form_categoria : Form
    {
        //
        private bool IsNuevo = true;

        public Form_categoria()
        {
            InitializeComponent();
        }

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OcultarColumnas()
        {
            this.listadocat.Columns[0].Visible = false;

        }

        private void Mostrarcategoria()
        {
            listadocat.DataSource = NCategoria.mostrarcat();
                this.OcultarColumnas();
            lbregistro.Text = " Categoria Registrados: " + Convert.ToString(listadocat.Rows.Count);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {

                string rpta = "";
                if(this.txtcategoria.Text== string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");

                }

                else
                {
                    if(this.IsNuevo)
                    {

                        rpta = NCategoria.Insertarcat(this.txtcategoria.Text.Trim());
                        Mostrarcategoria();
                    }
                    else
                    {
                        //
                    }

                    if(rpta.Equals("OK"))
                    {
                        if(this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        }
                        else
                        {
                            //
                        }
                    }
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Form_categoria_Load(object sender, EventArgs e)
        {
            Mostrarcategoria();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "REGISTRO DE CLIENTES", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in listadocat.Rows)
                    {
                        /*(Convert.ToBoolean(row.Cells[0].Value))*/
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {

                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NCategoria.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Eliminó Correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Mostrarcategoria();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void checkeliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkeliminar.Checked)
            {
                this.listadocat.Columns[0].Visible = true;
            }
            else
            {
                this.listadocat.Columns[0].Visible = false;
            }

        }

        private void listadocat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == listadocat.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)listadocat.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }



        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
           
        }
    }
}
