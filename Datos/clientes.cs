using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
 public  class clientes
    {

        private conexion Conexion = new conexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        private int id_cliente;
        private string nombre;
        private string apellidos;
        private string numerodocumento;
        private string tipodocumento;
        private string telefono;
        private string email;

        private string _TextoBuscar;

        public int idcliente
        {
            get { return this.id_cliente; }
            set { this.id_cliente = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellidos
        {
            get { return this.apellidos; }
            set { this.apellidos = value; }
        }
        public string Numerodocumento
        {
            get { return this.numerodocumento; }
            set { this.numerodocumento = value; }
        }
        public string Tipodocumento
        {
            get { return this.tipodocumento; }
            set { this.tipodocumento = value; }
        }

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono= value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }


        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }


        public clientes()
        {

        }

        public clientes(string textobuscar)

        {
            this.TextoBuscar = textobuscar;

        }



        public string InsertarCliente(clientes Cliente)
        {
            //see crea un variable rpta
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            /* SqlConnection SqlCon = new SqlConnection();*/

            try
            {


                SqlCon.ConnectionString = conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "insertar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idcliente";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcliente);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Cliente.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellido";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 50;
                ParApellidos.Value = Cliente.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

              

                

                SqlParameter ParTipoDocumento = new SqlParameter();
                ParTipoDocumento.ParameterName = "@tipodocumento";
                ParTipoDocumento.SqlDbType = SqlDbType.VarChar;
                ParTipoDocumento.Size = 20;
                ParTipoDocumento.Value = Cliente.Tipodocumento;
                SqlCmd.Parameters.Add(ParTipoDocumento);

                SqlParameter ParNum_Documento = new SqlParameter();
                ParNum_Documento.ParameterName = "@numerodocumento";
                ParNum_Documento.SqlDbType = SqlDbType.VarChar;
                ParNum_Documento.Size = 11;
                ParNum_Documento.Value = Cliente.numerodocumento;
                SqlCmd.Parameters.Add(ParNum_Documento);


                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 11;
                ParTelefono.Value = Cliente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Cliente.Email;
                SqlCmd.Parameters.Add(ParEmail);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";








              
            }
            catch (Exception)
            {

            
            }
            return rpta;
        }


        public DataTable ListarClientes( )
        {
          
            DataTable Tabla = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {


                
                Comando.Connection = SqlCon;
                SqlCon.ConnectionString = conexion.Cn;
                SqlCon.Open();

                Comando.CommandText = "mostrar_cliente";
                Comando.CommandType = CommandType.StoredProcedure;
                LeerFilas = Comando.ExecuteReader();
                Tabla.Load(LeerFilas);
                LeerFilas.Close();
                /* Conexion.CerrarConexion();*/
                


            }
            catch (Exception)
            {

                throw;
            }

            return Tabla;
        }

        public string Eliminarclientes(clientes client)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {


                SqlCon.ConnectionString = conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlcomand = new SqlCommand();
                sqlcomand.Connection = SqlCon;
                sqlcomand.CommandText = "eliminar_cliente";
                sqlcomand.CommandType = CommandType.StoredProcedure;


                SqlParameter parcliente = new SqlParameter();
                parcliente.ParameterName = "@idcliente";
                parcliente.SqlDbType = SqlDbType.Int;
                parcliente.Value = client.idcliente;
                sqlcomand.Parameters.Add(parcliente);


                rpta = sqlcomand.ExecuteNonQuery() == 1 ? "OK" : "no ERROR";






                
              
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }


        public DataTable Bucarcliente (clientes client)
        {
            DataTable resultado = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

          

            try
            {
                /* Comando.Connection = Conexion.AbrirConexion();*/
                sqlcon.ConnectionString = conexion.Cn;
                SqlCommand sqlcomand = new SqlCommand();
                sqlcomand.Connection = sqlcon;
                sqlcomand.CommandText = "buscarcliente_apellidos";
                sqlcomand.CommandType = CommandType.StoredProcedure;

                SqlParameter partextobuscar = new SqlParameter();
                partextobuscar.ParameterName = "@textobuscar";
                partextobuscar.SqlDbType = SqlDbType.VarChar;
                partextobuscar.Value = client.TextoBuscar;
                sqlcomand.Parameters.Add(partextobuscar);


                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcomand);
                sqldat.Fill(resultado);



                
             

            }
            catch (Exception ex)
            {

                resultado = null;
            }
            return resultado;
        }


    }
}
