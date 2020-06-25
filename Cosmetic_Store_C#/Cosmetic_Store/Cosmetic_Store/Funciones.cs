using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmetic_Store
{
    class Funciones
    {
        #region VALIDAR OPCION DEL MENU

        ///<summary>
        /// VALIDAMOS LAS OPCIONES DEL MENU
        ///</summary>

        public static int ValidarOpcion(int opcionMin, int opcionMax)
        {
            int opcion;

            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < opcionMin || opcion > opcionMax)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La opcion elegida es invalida. Ingrese otra opcion");
                Console.ResetColor();
            }
            return opcion;
        }
        #endregion
    }
}
