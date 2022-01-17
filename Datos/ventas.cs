using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
namespace Datos
{
    public class ventas
    {


        private conexion Conexion = new conexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;
        private int id_venta;
        private int id_cliente;
        private string tipocomprobante;
        private string serie;

        private DateTime _fecha;
        private decimal _igv;

        public int idventa
        {
            get { return this.id_venta; }
            set { this.id_venta = value; }
        }
        public int idcliente
        {
            get { return this.id_cliente; }
            set { this.id_cliente = value; }
        }

        public string Tipocomprobante
        {
            get { return this.tipocomprobante; }
            set { this.tipocomprobante = value; }
        }

        public string Serie
        {
            get { return this.serie; }
            set { this.serie = value; }
        }



        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public decimal Igv
        {
            get { return _igv; }
            set { _igv = value; }
        }


       



    


        public DataTable Mostrar_ventas()
        {
            DataTable result = new DataTable("ventas");
                SqlConnection sqlcom = new SqlConnection();
            try
            {

                sqlcom.ConnectionString = conexion.Cn;
                SqlCommand sqlcomand = new SqlCommand();
                sqlcomand.Connection = sqlcom;
               
                sqlcomand.CommandText = "mostrarventas";
                sqlcomand.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqldata = new SqlDataAdapter(sqlcomand);
                sqldata.Fill(result);

            }
            catch (Exception ex)
            {

                result = null;
            }
            return result;

        }


        public string Insertarventas(ventas Venta,List<Detalle_Ventas> Detalle )
        {
            //see crea un variable rpta
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {



                //Código
                SqlCon.ConnectionString = conexion.Cn;
                SqlCon.Open();
                //Establecer la trasacción
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "insertar_ventas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@idventa";
                ParIdventa.SqlDbType = SqlDbType.Int;
                ParIdventa.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdventa);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Venta.idcliente;
                SqlCmd.Parameters.Add(ParIdCliente);


                SqlParameter ParTipo_Comprobante = new SqlParameter();
                ParTipo_Comprobante.ParameterName = "@tipo_comprobante";
                ParTipo_Comprobante.SqlDbType = SqlDbType.VarChar;
                ParTipo_Comprobante.Size = 20;
                ParTipo_Comprobante.Value = Venta.Tipocomprobante;
                SqlCmd.Parameters.Add(ParTipo_Comprobante);



                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fechaventa";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Venta.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                

                SqlParameter ParSerie = new SqlParameter();
                ParSerie.ParameterName = "@serie";
                ParSerie.SqlDbType = SqlDbType.VarChar;
                ParSerie.Size = 4;
                ParSerie.Value = Venta.Serie;
                SqlCmd.Parameters.Add(ParSerie);

          

                SqlParameter ParIgv = new SqlParameter();
                ParIgv.ParameterName = "@igv";
                ParIgv.SqlDbType = SqlDbType.Decimal;
                ParIgv.Precision = 4;
                ParIgv.Scale = 2;
                ParIgv.Value = Venta.Igv;
                SqlCmd.Parameters.Add(ParIgv);






                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";








               

                if (rpta.Equals("OK"))
                {
                    //Obtener el código del ingreso generado
                    this.idventa = Convert.ToInt32(SqlCmd.Parameters["@idventa"].Value);
                    foreach (Detalle_Ventas det in Detalle)
                    {
                        det.Idventa = this.idventa;
                        //Llamar al método insertar de la clase DDetalle_Ingreso
                        rpta = det.Insertardetalle_ventas(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                        else
                        {
                            //Actualizamos el stock
                            rpta = desminuirstock(det.Idproducto, det.Cantidad);
                            if (!rpta.Equals("OK"))
                            {
                                break;
                            }
                        }
                   }

                }
                if (rpta.Equals("OK"))
                {
                    SqlTra.Commit();
                }
                else
                {
                    SqlTra.Rollback();
                }





                

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

        public void Editarventas()
        {
           /* Comando.Connection = Conexion.AbrirConexion();*/
            Comando.CommandText = "editar_ventas";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@idventa", id_venta);
            Comando.Parameters.AddWithValue("@idcliente", id_cliente);
           /* Comando.Parameters.AddWithValue("@tipo_documento", Tipodocumento);*/
          
            Comando.Parameters.AddWithValue("@fechaventa", Fecha);
            Comando.Parameters.AddWithValue("@igv", Igv);

            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        public string Eliminarventas(ventas vent)
        {
            string rpta = "";
            try
            {

               /* Comando.Connection = Conexion.AbrirConexion();*/
                Comando.CommandText = "eliminar_ventas";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@idventa", idventa);


                // Ejecutamos nuestro comando

                rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";

            }
            catch (Exception)
            {


            }
            return rpta;
        }



        public string desminuirstock(int idproducto,int cantidad )
        {
            //see crea un variable rpta
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {


                //Código
                SqlCon.ConnectionString = conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "desminuir_stock";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_Ingreso = new SqlParameter();
                ParIddetalle_Ingreso.ParameterName = "@idproducto";
                ParIddetalle_Ingreso.SqlDbType = SqlDbType.Int;
                ParIddetalle_Ingreso.Value = idproducto;
                SqlCmd.Parameters.Add(ParIddetalle_Ingreso);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = cantidad;
                SqlCmd.Parameters.Add(ParCantidad);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizó el stock";


                /* SqlCon.ConnectionString = conexion.Cn;
                 SqlCon.Open();
                 /* Comando.Connection = Conexion.AbrirConexion();*/
                /* Comando.CommandText = "desminuir_stock";
                 Comando.CommandType = CommandType.StoredProcedure;
                 Comando.Parameters.AddWithValue("@idproducto", idproducto);
                 Comando.Parameters.AddWithValue("@Stock", stock);


                 rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "";
                 Comando.Parameters.Clear();*/
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


        /*METODO BUSCAR FECHAS */

        public DataTable buscarfechas (string textobuscar, string textobuscar2)

        {
            DataTable resultado = new DataTable("venta");
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = Sqlcon;
                SqlCmd.CommandText = "buscar_venta_fecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
               
                ParTextoBuscar.Value = textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textbuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
              
                ParTextoBuscar2.Value = textobuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(resultado);




            }
            catch (Exception)
            {

                resultado = null;
            }


            return resultado;

        }





    }
}

