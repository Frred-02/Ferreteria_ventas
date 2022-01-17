using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IMPORTAMOS
using System.Data;
using Datos;

namespace CapasDatos2
{
   public class NVentas
    {



        public static string Insertar(int idcliente ,string tipo_comprobante,string serie,DateTime fecha,decimal igv,DataTable dtDetalles)

        {
            ventas vent = new ventas();
            vent.idcliente = idcliente;
            vent.Tipocomprobante = tipo_comprobante;
           vent.Serie = serie;
           
            vent.Fecha = fecha;
            vent.Igv = igv;

            List<Detalle_Ventas> detalles = new List<Detalle_Ventas>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                Detalle_Ventas detalle = new Detalle_Ventas();
                detalle.Idproducto= Convert.ToInt32(row["idproducto"].ToString());
                detalle.Cantidad= Convert.ToInt32(row["Cantidad"].ToString());
                detalle.Precio = Convert.ToDecimal(row["Precio"].ToString());
               
                detalles.Add(detalle);
            }

            return vent.Insertarventas(vent,detalles);
        }
        



        public static DataTable mostrar()

        {

            return new ventas().Mostrar_ventas();

        }
        //Método BuscarApellidos que llama al método BuscarApellidos
        //de la clase DCLiente de la CapaDatos



        public static string Eliminarventa(int idventa)
        {
            ventas vent = new ventas();
            vent.idventa  = idventa;
            return vent.Eliminarventas(vent);
        }

        public static DataTable buscarfechas(string textobuscar , string textobuscar2)
        {
            ventas vent = new ventas();
            return vent.buscarfechas(textobuscar, textobuscar2);
        }



    }
}
