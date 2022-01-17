using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class Detalle_Ventas
    {



        private int iddetalleventa;
        private int idventa;
        private int idproducto;
        private int cantidad;
        private decimal precio;


        public int IDdetalleventa
        {
            get { return this.iddetalleventa; }
            set { this.iddetalleventa = value; }
        }

        public int Idventa
        {
            get { return this.idventa; }
            set { this.idventa = value; }
        }
        public int Idproducto
        {
            get { return this.idproducto; }
            set { this.idproducto = value; }
        }
        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        public decimal Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }


        public  Detalle_Ventas()
        {

        }

        public Detalle_Ventas(int iddetalle_venta, int idventa, int idproducto,
            int cantidad, decimal precio)
        {
            this.IDdetalleventa = iddetalle_venta;
            this.Idventa = idventa;
            this.Idproducto = idproducto; ;
        
            this.Cantidad = cantidad;
            this.Precio = precio;
         
        }


        public string Insertardetalle_ventas(Detalle_Ventas detalle , 
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            //see crea un variable rpta
            string rpta = "";


            try
            {

                //Código


                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "insertar_detallesventas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_Venta = new SqlParameter();
                ParIddetalle_Venta.ParameterName = "@iddetalle_ventas";
                ParIddetalle_Venta.SqlDbType = SqlDbType.Int;
                ParIddetalle_Venta.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddetalle_Venta);

                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@idventa";
                ParIdventa.SqlDbType = SqlDbType.Int;
                ParIdventa.Value = detalle.Idventa;
                SqlCmd.Parameters.Add(ParIdventa);

                SqlParameter ParIdprdudcto = new SqlParameter();
                ParIdprdudcto.ParameterName = "@idproducto";
                ParIdprdudcto.SqlDbType = SqlDbType.Int;
                ParIdprdudcto.Value = detalle.Idproducto;
                SqlCmd.Parameters.Add(ParIdprdudcto);



                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = detalle.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParPrecioVenta = new SqlParameter();
                ParPrecioVenta.ParameterName = "@precio";
                ParPrecioVenta.SqlDbType = SqlDbType.Money;
                ParPrecioVenta.Value = detalle.Precio;
                SqlCmd.Parameters.Add(ParPrecioVenta);

               

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";



            }
            catch (Exception ex)
            {
                rpta = ex.Message;


            }
          
            return rpta;
        }
       

      

    }
}
