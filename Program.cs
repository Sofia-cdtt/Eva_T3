using System;

namespace T3_PRÁCTICA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar;
            Librería e = new Librería();
            
            
            do 
            {
                Console.Clear();
                Console.WriteLine("*-----------------------------------------------*");
                Console.WriteLine("| BIENVENIDOS AL SISTEMA DE REGISTROS DE LIBROS |");
                Console.WriteLine("*-----------------------------------------------*");
                Console.WriteLine("****             Menú de opciones:           ****\n");
                Console.WriteLine(" 1. Registrar ");
                Console.WriteLine(" 2. Mostrar ");
                Console.WriteLine(" 3. Modificar ");
                Console.WriteLine(" 4. Eliminar ");
                Console.WriteLine(" 0. Salir\n ");

                int opc;

                while (true) 
                {
                    Console.Write("Ingrese una opción: ");
                    if (int.TryParse(Console.ReadLine(), out opc) & opc >= 0 && opc <= 4) break;
                    else Console.WriteLine("¡Ingrese una opción correcta\n!");
                }

                switch (opc) 
                {
                    case 0:  return;
                    case 1: e.Registrar(); break;
                    case 2: e.Mostrar(); break;
                    case 3: e.Modificar(); break;
                    case 4: e.Eliminar(); break;
                }

                while (true) 
                {
                    Console.Write("\n¿Desea continuar? [S/N] : ");
                    continuar = Console.ReadLine().ToUpper();
                    if (continuar == "S" || continuar == "N") break;
                    else Console.WriteLine("ERROR. Ingrese solo 's' o 'n'.\n");
                }
                Console.WriteLine("\nGracias por utilizar el sistema. ");

            } while (continuar == "S");
        }
    }
}
