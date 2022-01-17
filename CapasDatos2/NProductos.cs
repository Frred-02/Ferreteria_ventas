using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//IMPORTAMOS Datos
// IMPORTANTE REFERENCIAMOS  LE DAMOS  CLIPDERECHO AGREGAMOS  CapasDatos2
using Datos;

namespace CapasDatos2
{

    // OJO PONERLO PUBLICA
  public  class NProductos
    {
        public static string Insertar( int idcategoria, string nombre, string descripcion , string marca,decimal precio,int stock,DateTime fecha  )
        {
            Producto product = new Producto();
            product.Idcategoria = idcategoria;
           
            product.Nombre_product = nombre;
            product.Descripcion = descripcion;
            product.Marca = marca;

            product.Precio = precio;
            product.Stock = stock;
            product.Fecha = fecha;


            return product.Insertarproducto( product);
        }

        //Método Mostrar que llama al método Mostrar de la clase Productos 
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new Producto().Listarproducto();
        }

        public static string Eliminarprod(int idproducto)
        {
            Producto client = new Producto();
            client.Idproducto = idproducto;
            return client.Eliminarproducto(client);
        }


        /*BUSCAR PRODUCTOS*/

        public static DataTable  buscarproducto(string textobusca)
        {

            Producto prod = new Producto();
            prod.textobuscar = textobusca;
            return prod.buscarproducto(prod);
        }


    }
}
