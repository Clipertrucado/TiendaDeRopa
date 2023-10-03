using TiendaDeRopa.Servicios;

namespace TiendaDeRopa 
{       
        /// <summary>
        /// Clase principal del programa
        /// 031023 - sav
        /// </summary>
        /// <param name="args"></param>
    class program 
    {
        /// <summary>
        /// Metodo de entrada a la aplicación
        /// 031023 - sav
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args) 
        {
            //llamamos al metodo que da la bienvenida por pantalla
            MenuInterfaz mi = new MenuImplementacion();

            mi.nombreEmpresa();

            //creamos variable que controla que el menu se cierre
            bool cerrarMenu = false;

            //cereamos variable que recogera la opcion seleccionada en el menu
            int opSelec;

            //es el encargado de que la aplicacion no se cierre sin que seleccionemos alguna opcion recogida en el menu 
            while (!cerrarMenu)
            {
                //llamamos al metodo que muestra el menu 
                opSelec = mi.mostrarMenu();

                Console.WriteLine(opSelec);

                //comparara la opcion seleccionada con los diferentes casos
                switch (opSelec)
                {
                    case 0:
                        Console.WriteLine("[INFO] - La aplicacion se cerrara ");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] - Opción selecionada 1");
                        cerrarMenu = false;
                        break;

                    case 2:
                        Console.WriteLine("[INFO] - Opción selecionada 2");
                        cerrarMenu = false;
                        break;

                    default:
                        Console.WriteLine("[INFO] - La opción selecionada no se encuentra en la lista");
                        break;
                }

            }
        }
    }

}
