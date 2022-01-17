using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Data;
using System.Data.Sql;
using System.Windows.Forms;
namespace Datos
{
    class conexion
    {

        /*public string cadenaconecxion;
        protected string sql;
        //protected int  resultado;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        protected SqlConnection cnn;
        protected SqlCommand commandsq;
        protected string mensaje;
    

        class conexion()*/
        
          

             public static string Cn = "Data source=DESKTOP-50MSEBU; Initial Catalog=dbproyectoventas; User Id=sa; Password=1234";

    }
      /*  public string Mensaje

        {
            get{
                return this.mensaje;
            }
            
        }
        public void cargartabla(DataGridView dgv)
        {
            da = new SqlDataAdapter("select * from productos", cnn);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

        }


        public void mostrarusuarios(DataGridView dgv)
        {
            da = new SqlDataAdapter("select * from Usuarios", cnn);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

        }

      


        public SqlConnection AbrirConexion()
        {
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            return cnn;
        }

        public SqlConnection CerrarConexion()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();

            return cnn;
        }

    }*/
}
