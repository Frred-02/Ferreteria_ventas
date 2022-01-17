using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
// IMPORTAMOS
using Datos;
namespace CapasDatos2
{
  public  class NClientes
    {

        public static string Insertar(string nombre, string apellidos, string tipodocumento,string numerodocumento,string telefono,string email)
        {
            clientes client = new clientes();
            client .Nombre = nombre;
            client.Apellidos = apellidos;
            client.Tipodocumento = tipodocumento;
            client.Numerodocumento = numerodocumento;
            client.Telefono = telefono;
            client.Email = email;



            return client.InsertarCliente(client);
        }
        //Método Mostrar que llama al método Mostrar de la clase clientes
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new clientes().ListarClientes();
        }


        public static DataTable buscarcliente(string textobuscar)
        {
            clientes Obj = new clientes();
            Obj.TextoBuscar = textobuscar;
            return Obj.Bucarcliente(Obj);
        }


        
        public static string Eliminarcli(int idcliente)
        {
            clientes client = new clientes();
            client.idcliente = idcliente;
            return client.Eliminarclientes(client);
        }
    }
}
