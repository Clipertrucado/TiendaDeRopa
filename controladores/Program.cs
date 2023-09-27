using TiendaDeRopa.Servicios;

namespace TiendaDeRopa 
{
    class program 
    {

        static void Main(string[] args) 
        {
            MenuInterfaz mi = new MenuImplementacion();

            mi.nombreEmpresa();

            bool cerrarMenu = false;
            int opselec;

            while(opselec) 
            { 
                opselec = mi.mostrarMenu();
            }
        }
    }

}
