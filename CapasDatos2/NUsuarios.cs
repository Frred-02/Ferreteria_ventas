using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*ingresamos*/
using Datos;
using System.Data;

namespace CapasDatos2
{

    /*`ponemos la clase en publico*/
    public class NUsuarios 
    {
        /* llamamos la clase   DUsuarios*/
        public static string insertar(string nombre, string apelllidos, string numerodocumento,
          string telefono, string email, string acceso, string usuario, string contrasena)
        {
            usuarios usu = new usuarios();
            usu.Nombre = nombre;
            usu.Apellidos = apelllidos;
            usu.Numerodocumento = numerodocumento;
            usu.Telefono = telefono;
            usu.Email = email;
            usu.Acceso = acceso;
            usu.Usuario = usuario;
            usu.Contrasena = contrasena;

            return usu.insertar(usu);




        }


        public static DataTable entrada(string usuario,string contrase)
        {
            usuarios usu = new usuarios();
            usu.Usuario = usuario;
            usu.Contrasena = contrase;

            return usu.entrada_user(usu);
        }
        
        


        public static  DataTable buscarproductos (string textobusca)
        {
            Producto prod = new Producto();
            prod.textobuscar = textobusca;
            return prod.buscarproducto(prod);

        }
        
        




    }
}
