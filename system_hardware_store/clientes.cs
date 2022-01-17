using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace system_hardware_store
{
    class clientes:conexion
    {

        private conexion Conexion = new conexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        private int id_cliente;
        private string nombre;
        private string apellidos;
        private string dni;
        

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
        public string Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public void InsertarCliente()
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "AgregarCliente";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@nombre", nombre);
            Comando.Parameters.AddWithValue("@apellidos", apellidos);
            Comando.Parameters.AddWithValue("@dni", dni);
          
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }


        public DataTable ListarClientes()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarClientes";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public void Eliminarclientes()
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "eliminar_cliente";

            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@idcliente",id_cliente);

            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

    }
}
