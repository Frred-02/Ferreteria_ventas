using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**/
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
  public  class usuarios
    {
        /*variables */

        private int idusuario;
        private string nombre;
        private string apelllidos;
        private string numerodocumeto;
        private string telefono;
        private string email;
        private string acceso;
        private string usuario;
        private string contrasena;


        public int Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }

        public  string Nombre
        {
            get { return nombre; }
            set { nombre = value; }


        }

        public string Apellidos
        {
            get { return apelllidos; }
            set { apelllidos = value; }


        }

        public string Numerodocumento
        {
            get { return numerodocumeto; }
            set { numerodocumeto = value; }


        }

        public string Telefono
        {
            get { return telefono; }
            set {telefono = value; }


        }
        public string Email
        {
            get { return email; }
            set { email = value; }


        }

        public string Acceso
        {
            get { return acceso; }
            set { acceso = value; }


        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }


        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }


        }


        public  string insertar(usuarios usuario)
        {

            string rpta = "";
            SqlConnection sqlcone = new SqlConnection();


            try
            {
                sqlcone.ConnectionString = conexion.Cn;
                sqlcone.Open();

                SqlCommand comand = new SqlCommand();
                comand.Connection = sqlcone;
                comand.CommandText = "insertar_usarios";
                comand.CommandType = CommandType.StoredProcedure;

                SqlParameter paridusuario = new SqlParameter();
                paridusuario.ParameterName = "@idusuario";
                paridusuario.SqlDbType = SqlDbType.Int;
                paridusuario.Direction = ParameterDirection.Output;
                comand.Parameters.Add(paridusuario);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 20;
                ParNombre.Value = usuario.Nombre;
                comand.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 40;
                ParApellidos.Value = usuario.Apellidos;
                comand.Parameters.Add(ParApellidos);

               
                SqlParameter ParNum_Documento = new SqlParameter();
                ParNum_Documento.ParameterName = "@numerodocumento";
                ParNum_Documento.SqlDbType = SqlDbType.VarChar;
                ParNum_Documento.Size = 11;
                ParNum_Documento.Value = usuario.Numerodocumento;
                comand.Parameters.Add(ParNum_Documento);


                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 11;
                ParTelefono.Value = usuario.Telefono;
                comand.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = usuario.Email;
                comand.Parameters.Add(ParEmail);

                SqlParameter ParAcceso = new SqlParameter();
                ParAcceso.ParameterName = "@acceso";
                ParAcceso.SqlDbType = SqlDbType.VarChar;
                ParAcceso.Size = 50;
                ParAcceso.Value = usuario.Acceso;
                comand.Parameters.Add(ParAcceso);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 50;
                ParUsuario.Value = usuario.Usuario;
               comand.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 50;
                ParPassword.Value = usuario.Contrasena;
                comand.Parameters.Add(ParPassword);


                rpta = comand.ExecuteNonQuery() == 1 ? "OK" :"no ingreso ";


            }
            catch (Exception  ex)
            {

                rpta = ex.Message;
            }

            finally
            {
                if (sqlcone.State == ConnectionState.Open) sqlcone.Close();
            }
            return rpta;


        }


        public DataTable entrada_user (usuarios usur)

        {
            DataTable resultado = new DataTable("usuarios");
            SqlConnection sqlcone = new SqlConnection();


            try
            {

                sqlcone.ConnectionString = conexion.Cn;
               
              

                sqlcone.ConnectionString = conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlcone;
                SqlCmd.CommandText = "plogin";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usurio";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
            
                ParUsuario.Value = usur.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
               
                ParPassword.Value = usur.Contrasena;
                SqlCmd.Parameters.Add(ParPassword);


                SqlDataAdapter sqldata = new SqlDataAdapter(SqlCmd);
                sqldata.Fill(resultado);


            }
            catch (Exception   ex)
            {
                resultado = null;
                
            }

            return resultado;

        }


        public DataTable listausuarios()


        {

            DataTable tabla = new DataTable("usuarios");

            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = conexion.Cn;
                SqlCommand sqlcomand = new SqlCommand();

                sqlcomand.Connection = sqlcon;
                sqlcomand.CommandText = "mostrar_usuarios";
                sqlcomand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqladatp = new SqlDataAdapter(sqlcomand);
                sqladatp.Fill(tabla);



            }
            catch (Exception  ex)
            {

                tabla = null;
            }

            return tabla;
        }



    }
}
