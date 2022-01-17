using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.SqlClient;

namespace Datos
{

    //colocar public
   public class Categoria
    {

        //
        private conexion Conexion = new conexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        //
        private int id_categoria;
        private string nombrecategoria;

        public  int idcategoria
        {
            get { return this.id_categoria; }
            set { this.id_categoria = value; }

        }

        public string Nombre_categoria
        {
            get { return this.nombrecategoria; }
            set { this.nombrecategoria = value; }
        }





        public string Insertarcategoria (Categoria cat)

        {
            
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = conexion.Cn;
                SqlCon.Open();
                SqlCommand sqlcomad = new SqlCommand();
                sqlcomad.Connection = SqlCon;
                sqlcomad.CommandText = "insertar_categoria";
                sqlcomad.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idcategoria";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Direction = ParameterDirection.Output;
                sqlcomad.Parameters.Add(ParIdcliente);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombrecategoria";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = cat.Nombre_categoria;
                sqlcomad.Parameters.Add(ParNombre);


             
               
                rpta =sqlcomad.ExecuteNonQuery() == 1 ? "OK" : "";


               
            }
            catch (Exception)
            {

           
            }
            return rpta;
        }


        public  DataTable listacategoria()
        {




            DataTable Tabla = new DataTable("categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {



                Comando.Connection = SqlCon;
                SqlCon.ConnectionString = conexion.Cn;
                SqlCon.Open();

                Comando.CommandText = "mostrar_categoria";
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

            // /*Comando.Connection = Conexion.AbrirConexion();*/
            // SqlConnection SqlCon = new SqlConnection();
            // DataTable Tabla = new DataTable();
            // Comando.Connection = SqlCon;
            // SqlCon.ConnectionString = conexion.Cn;
            // SqlCon.Open();
            // Comando.CommandText = "mostrar_categoria";
            // Comando.CommandType = CommandType.StoredProcedure;
            // LeerFilas = Comando.ExecuteReader();
            // Tabla.Load(LeerFilas);
            // LeerFilas.Close();
            ///* Conexion.CerrarConexion();*/
            // return Tabla;
        }


        public string Eliminarcategoria(Categoria cat)
        {


            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {


                SqlCon.ConnectionString = conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlcomand = new SqlCommand();
                sqlcomand.Connection = SqlCon;
                sqlcomand.CommandText = "eliminar_categoria";
                sqlcomand.CommandType = CommandType.StoredProcedure;


                SqlParameter parcatgor = new SqlParameter();
                parcatgor.ParameterName = "@idcategoria";
                parcatgor.SqlDbType = SqlDbType.Int;
                parcatgor.Value = cat.idcategoria;
                sqlcomand.Parameters.Add(parcatgor);


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















            //string rpta = "";

            //try
            //{

            //  /*  Comando.Connection = Conexion.AbrirConexion();*/
            //    Comando.CommandText = "eliminar_categoria";

            //    Comando.CommandType = CommandType.StoredProcedure;
            //    Comando.Parameters.AddWithValue("@idcategoria", id_categoria);


            //    // Ejecutamos nuestro comando

            //    rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";

            //}
            //catch (Exception)
            //{


            //}
            //return rpta;

        }



    }
}
