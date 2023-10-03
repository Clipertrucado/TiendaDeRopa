using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa.Servicios
{
    /// <summary>
    /// interfaz que contiene todas las cabeceras 
    /// 031023 - sav
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Muestra el mensaje de bienvenida
        /// 031023 - sav
        /// </summary>
        public void nombreEmpresa();

        /// <summary>
        /// Muestra el menu y pide una de las opciones 
        /// 031023 - sav
        /// </summary>
        /// <returns></returns>
        public int mostrarMenu();
    }
}
