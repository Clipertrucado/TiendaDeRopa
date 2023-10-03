using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa.Servicios
{
    /// <summary>
    /// implementacion del as acciones del menu 
    /// 031023 - sav
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {   
        public void nombreEmpresa() 
        {
            string mensaje = "BIENVENIDO A LA TIENDA CLIPER";

            Console.WriteLine(mensaje);
        }

        int MenuInterfaz.mostrarMenu()
        {
            int opIntro;

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("0. Cerrar la aplicación");
            Console.WriteLine("1. Ver lista de nuevos pedidos");
            Console.WriteLine("2. Ver lista de pedidos en curso");
            Console.WriteLine("3. Pagos pendientes");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Seleccione una opción: ");

            //esta linea de comando solo recoge el primer caracter introducido 
            opIntro = Console.ReadKey(true).KeyChar - ('0');

            return opIntro;
        }
    }
}
