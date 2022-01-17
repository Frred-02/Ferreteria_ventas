using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using Datos;
using System.Data;


namespace CapasDatos2
{

    //poner public
  public  class NCategoria
    {


        //insertar categoria 
        public static string Insertarcat (string nombrecat)
        {
            Categoria cat = new Categoria();
            cat.Nombre_categoria = nombrecat;


            return cat.Insertarcategoria(cat);
        }
        
        //MOSTRAR LA TABLA CATEGORIA 
        public static DataTable mostrarcat()
        {
            return new Categoria().listacategoria();
        }

        public static string  Eliminar(int _idcategoria )
        {
            Categoria cat = new Categoria();
            cat.idcategoria = _idcategoria;
            return cat.Eliminarcategoria(cat);



        }

    }
}
