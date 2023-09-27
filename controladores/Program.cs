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
            int opSelec;

            while(!cerrarMenu) 
            { 
                opSelec = mi.mostrarMenu();

                Console.WriteLine(opSelec);

                switch (opSelec)
                {
                    case 0:
                        Console.WriteLine("hola");
                        cerrarMenu=true;
                        break;
                      
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;
                }
            }
        }
    }

}
