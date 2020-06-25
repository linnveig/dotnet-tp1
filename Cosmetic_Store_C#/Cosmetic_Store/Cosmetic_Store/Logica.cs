using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmetic_Store
{
    class Logica
    {
        //DECLARACION MATRIZ
        static string[,] matrizProductos = new string[5, 4];

        #region INICIO

        ///<summary>
        /// INICIAMOS EL PROGRAMA Y PEDIMOS INGRESAR LOS DATOS DE USUARIOS
        ///</summary>

        public static void InicioPrograma()
        {
            string user;
            string pin;
            bool datosCorrectos = false;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("BIENVENIDOS A LA TIENDA DE COSMETICA!\n");
            bool continuar = true;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Por favor ingrese su login:");
                Console.ForegroundColor = ConsoleColor.White;
                user = Console.ReadLine().Trim();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Por favor ingrese su pasword:");
                Console.ForegroundColor = ConsoleColor.White;
                //while (int.TryParse(Console.ReadLine().Trim(), out pin));
                pin = Console.ReadLine().Trim();
                Console.ResetColor();


                if ((user == "Pepe" && pin == "123") || (user == "Caro" && pin == "456"))
                {
                    datosCorrectos = true;
                    Console.WriteLine("Se ingreso correctamente");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nNo se puedo ingresar, ingrese los datos correctos");
                    Console.ResetColor();
                }

                Logica.LlenarMatriz();

                if (datosCorrectos == true)
                {
                    do
                    {
                        continuar = Menu.MainMenu();
                    }
                    while (continuar == true);
                }

            } while (continuar == true);

        }
        #endregion

        #region DATOS DE LA MATRIZ

        ///<summary>
        /// LLENAMOS LA MATRIZ
        ///</summary>

        public static void LlenarMatriz()
        {
            matrizProductos[0, 0] = "1";
            matrizProductos[1, 0] = "2";
            matrizProductos[2, 0] = "3";
            matrizProductos[3, 0] = "4";


            matrizProductos[0, 1] = "Mascara";
            matrizProductos[1, 1] = "Rush";
            matrizProductos[2, 1] = "Delineador";
            matrizProductos[3, 1] = "Desmaquillante";


            matrizProductos[0, 2] = "Maybelline";
            matrizProductos[1, 2] = "Maybelline";
            matrizProductos[2, 2] = "MaxFactor";
            matrizProductos[3, 2] = "Loreal";


            matrizProductos[0, 3] = "600";
            matrizProductos[1, 3] = "500";
            matrizProductos[2, 3] = "300";
            matrizProductos[3, 3] = "400";

        }
        #endregion

        #region MOSTRAR TODO

        ///<summary>
        /// IMPRIMIMOS TODOS LOS DATOS DE LA MATRIZ
        ///</summary>

        public static void MostrarTodo()
        {
            for (int fila = 0; fila < matrizProductos.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matrizProductos.GetLength(1); columna++)
                {
                    if (!string.IsNullOrEmpty(matrizProductos[fila, 0]))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("{0,-1}| ", matrizProductos[fila, columna]);
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nPresione una tecla para volver al menu anterior");
            Console.ResetColor();
            Console.ReadKey();
        }
        #endregion

        #region BUSCAR POR MARCA

        ///<summary>
        /// BUSCAMOS POR MARCA DENTRO DE LA MATRIZ
        ///</summary>

        public static void BuscarMarca()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ingrese la marca que quiere encontrar");
            Console.ForegroundColor = ConsoleColor.White;
            string datoBuscar = Console.ReadLine();

            while (string.IsNullOrEmpty(datoBuscar.Trim()))
            {
                Console.WriteLine("Ingrese la marca para buscar");
                datoBuscar = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nLos datos del producto buscado son:\n");

            for (int fila = 0; fila < matrizProductos.GetLength(0); fila++)
            {
                if (string.IsNullOrEmpty(matrizProductos[fila, 2]) == false && matrizProductos[fila, 2].ToLower().Contains(datoBuscar.ToLower()))
                {
                    for (int columna = 0; columna < matrizProductos.GetLength(1); columna++)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("{0} | ", matrizProductos[fila, columna]);
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nPresione una tecla para volver al menu anterior");
            Console.ResetColor();
            Console.ReadKey();
        }
        #endregion

        #region AGREGAR PRODUCTO NUEVO

        ///<summary>
        /// AGREGAMOS UN PRODUCTO NUEVO
        /// E IMPRIMIMOS LA MATRIZ CON EL PRODUCTO AGREGADO
        ///</summary>

        public static void AgregarProducto()
        {
            bool datoAgregar = false;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ingrese el id del producto nuevo:");
            Console.ForegroundColor = ConsoleColor.White;
            string idNew = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ingrese el nombre del producto nuevo:");
            Console.ForegroundColor = ConsoleColor.White;
            string nombreNew = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ingrese la marca del producto nuevo:");
            Console.ForegroundColor = ConsoleColor.White;
            string marcaNew = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ingrese el precio del producto nuevo:");
            Console.ForegroundColor = ConsoleColor.White;
            string precioNew = Console.ReadLine();

            for (int fila = 0; fila < matrizProductos.GetLength(0); fila++)
            {
                if (string.IsNullOrEmpty(matrizProductos[fila, 0]))
                {
                    matrizProductos[fila, 0] = idNew;
                    matrizProductos[fila, 1] = nombreNew;
                    matrizProductos[fila, 2] = marcaNew;
                    matrizProductos[fila, 3] = precioNew;

                    datoAgregar = true;
                    break;
                }

            }

            if (datoAgregar == true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nDato agregado correctamente!");
                Console.WriteLine("Presione ENTER para ver todo con el dato agregado\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nNo se pudo ingresar el dato\n");
            }

            Console.ResetColor();
            Console.ReadKey();
        }
        #endregion

        #region ELIMINAR PRODUCTO

        ///<summary>
        /// ELIMINAMOS EL PRODUCTO
        /// E IMPRIMIMOS LA MATRIZ SIN EL PRODUCTO ELIMINADO
        ///</summary>

        public static void EliminarProducto()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ingrese el nombre del producto que queria eliminar");
            Console.ForegroundColor = ConsoleColor.White;
            string datoEliminar = Console.ReadLine();

            while (string.IsNullOrEmpty(datoEliminar.Trim()))
            {
                Console.WriteLine("Ingrese la marca para buscar");
                datoEliminar = Console.ReadLine();
            }

            for (int fila = 0; fila < matrizProductos.GetLength(0); fila++)
            {
                if (string.IsNullOrEmpty(matrizProductos[fila, 1]) == false && matrizProductos[fila, 1].ToLower().Contains(datoEliminar.ToLower()))
                {

                    matrizProductos[fila, 0] = null;
                    matrizProductos[fila, 1] = null;
                    matrizProductos[fila, 2] = null;
                    matrizProductos[fila, 3] = null;

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nEl producto " + datoEliminar + " fue eliminado");
                    Console.WriteLine("Presione ENTER para ver todo sin el dato eliminado\n");

                    Console.WriteLine();

                }
            }
            Console.ResetColor();
            Console.ReadKey();

        }
        #endregion

        #region FACTURACION

        ///<summary>
        /// IMPRIMIMOS EL VALOR TOTAL DE UNA DE LAS COLUMNAS
        ///</summary>

        public static void Facturacion()
        {
            int montoTotal = 0;
            for (int fila = 0; fila < matrizProductos.GetLength(0); fila++)
            {
                if (matrizProductos[fila, 3] != null)
                {
                    montoTotal += int.Parse(matrizProductos[fila, 3]);

                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("La suma de todos los precios es {0}", montoTotal);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nPresione una tecla para volver al menu anterior");

            Console.ResetColor();
            Console.ReadKey();
        }
        #endregion
    }
}
