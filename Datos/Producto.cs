using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos

{
    // OJO PONERLO PUBLIC
   public class Producto
    {

        private conexion Conexion = new conexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;


        private int idproducto;
        private int idcategoria;
        private string nombre_product;
        private string descripcion;
        private string marca;
        private decimal precio;
        private int stock;
        private DateTime fecha;


        private string _textbuscar;
        
        
        public int Idproducto
        {
            get { return this.idproducto; }
            set { this.idproducto = value; }
        }
        
        public int Idcategoria
        {
            get{ return this.idcategoria; }
            set { this.idcategoria = value; }
        }
        
        public string Nombre_product
        {
            get { return this.nombre_product; }
            set { this.nombre_product = value; }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }
        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public decimal Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public int Stock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }

        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }


        /** texto buscar*/

            public string textobuscar
        {
            get { return _textbuscar; }
            set { _textbuscar = value; }
        }



        public string Insertarproducto(Producto producto)
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
                SqlCmd.CommandText = "insertar_producto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idproducto";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcliente);


                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = producto.idcategoria;
                SqlCmd.Parameters.Add(ParIdcategoria);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre_product";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = producto.Nombre_product;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter Pardescripcion = new SqlParameter();
                Pardescripcion.ParameterName = "@descripcion";
                Pardescripcion.SqlDbType = SqlDbType.VarChar;
                Pardescripcion.Size = 50;
                Pardescripcion.Value = producto.descripcion;
                SqlCmd.Parameters.Add(Pardescripcion);

                SqlParameter Parmarca = new SqlParameter();
                Parmarca.ParameterName = "@marca";
                Parmarca.SqlDbType = SqlDbType.VarChar;
                Parmarca.Size = 50;
                Parmarca.Value = producto.Marca;
                SqlCmd.Parameters.Add(Parmarca);

                SqlParameter Parprecio = new SqlParameter();
                Parprecio.ParameterName = "@precio";
                Parprecio.SqlDbType = SqlDbType.Money;
                Parprecio.Size = 50;
                Parprecio.Value = producto.Precio;
                SqlCmd.Parameters.Add(Parprecio);




                SqlParameter Parstock = new SqlParameter();
                Parstock.ParameterName = "@stock";
                Parstock.SqlDbType = SqlDbType.Int;
                Parstock.Size = 50;
                Parstock.Value = producto.Precio;
                SqlCmd.Parameters.Add(Parstock);



                SqlParameter Parfecha = new SqlParameter();
                Parfecha.ParameterName = "@fechaventa";
                Parfecha.SqlDbType = SqlDbType.Date;
                Parfecha.Size = 50;
                Parfecha.Value = producto.Fecha;
                SqlCmd.Parameters.Add(Parfecha);

                

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";




                //Ejecutamos nuestro comando

           

            }
            catch (Exception ex)
            {
                rpta = ex.Message;

                
            }
            finally
            {
                
            }
            return rpta;
        }

        public DataTable Listarproducto()
        {


          
            DataTable Tabla = new DataTable("producto");
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = conexion.Cn;
            SqlCon.Open();

            Comando.Connection = SqlCon;
            Comando.CommandText = "mostrar_producto";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
           /* Conexion.CerrarConexion();*/
            return Tabla;
        }


        public string Eliminarproducto(Producto product)
        {
            string rpta = "";

            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = conexion.Cn;
                SqlCon.Open();

                SqlCommand sqlcomad = new SqlCommand();
                sqlcomad.Connection = SqlCon;
                sqlcomad.CommandText = "eliminar_producto";
                sqlcomad.CommandType = CommandType.StoredProcedure;


                SqlParameter parproduct = new SqlParameter();
                parproduct.ParameterName = "@idproducto";
                parproduct.SqlDbType = SqlDbType.Int;
                parproduct.Value = product.Idproducto;
                sqlcomad.Parameters.Add(parproduct);


                // Ejecutamos nuestro comando

                rpta = sqlcomad.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";

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


        /*BUSCAR PRODUCTOS */

        public DataTable buscarproducto  (Producto prod)
        {

            DataTable resultado = new DataTable();
            SqlConnection sqlcon =  new  SqlConnection();



            try
            {

                sqlcon.ConnectionString = conexion.Cn;
                SqlCommand sqlcomand = new SqlCommand();
                sqlcomand.Connection = sqlcon;


                sqlcomand.CommandText = "buscarproducto";
                sqlcomand.CommandType = CommandType.StoredProcedure;

                SqlParameter partextobuscar = new SqlParameter();
                partextobuscar.ParameterName = "@textbuscar";
                partextobuscar.SqlDbType = SqlDbType.VarChar;
                partextobuscar.Value = prod.textobuscar;
                sqlcomand.Parameters.Add(partextobuscar);


                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcomand);
                sqldat.Fill(resultado);



            }
            catch (Exception)
            {

                resultado = null;

            }

            return resultado;

        }



    }





}
