using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmetic_Store
{
    class Menu
    {
        #region OPCIONES DEL MENU SWITCH

        ///<summary>
        /// INICIAMOS EL MENU PRINCIPAL
        ///</summary>

        public static bool MainMenu()
        {
            Console.Clear();
            int opcion;
            bool continuar = true;

            OpcionesMainMenu();

            opcion = Funciones.ValidarOpcion(1, 6);
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    Logica.MostrarTodo();
                    break;

                case 2:
                    Logica.BuscarMarca();
                    break;

                case 3:
                    Logica.AgregarProducto();
                    Logica.MostrarTodo();
                    break;

                case 4:
                    Logica.EliminarProducto();
                    Logica.MostrarTodo();
                    break;

                case 5:
                    Logica.Facturacion();
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("GRACIAS POR SU VISITA! :)");
                    Console.ResetColor();
                    continuar = false;
                    break;
            }
            Console.ReadKey();
            return continuar;
        }
        #endregion

        #region OPCIONES PARA SELECCIONAR

        ///<summary>
        /// OFRECEMOS OPCIONES DEL MENU PARA ELEGIR
        ///</summary>

        public static void OpcionesMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Seleccione una opcion\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1 - Mostrar todo");
            Console.WriteLine("2 - Buscar por marca");
            Console.WriteLine("3 - Agregar producto");
            Console.WriteLine("4 - Eliminar producto");
            Console.WriteLine("5 - Facturacion");
            Console.WriteLine("6 - Salir");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nSu opcion:");
            Console.ResetColor();
        }
        #endregion
    }
}
