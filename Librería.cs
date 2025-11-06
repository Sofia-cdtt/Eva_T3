using System;

namespace T3_PRÁCTICA
{
    internal class Librería
    {
        //Arreglos
        string[] Nombres = new string[0];
        double[] Precios = new double[0];
        int pos = 0;
        
        public void Registrar() 
        {
            Console.Clear();
            string nombre;
            double precio;

            while (true) 
            {
                
                Console.Write("Ingrese el nombre de un libro: ");
                nombre = Console.ReadLine();

                if (nombre == "") 
                {
                    Console.WriteLine("¡No se permite nombres vacíos o nulos!");
                    continue;
                }

                bool repetido = false;
                for (int i = 0; i < Nombres.Length; i++) 
                {
                    if (Nombres[i] == nombre) 
                    {
                        repetido = true;
                        break;
                    }
                        
                }

                if (repetido) 
                {
                    Console.WriteLine("¡Ya existe un libro con el mismo nombre!");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("\nIngrese el precio del libro: S/. ");
                if (double.TryParse(Console.ReadLine(), out precio) & precio >= 0 && precio <= 1000) break;
                else Console.WriteLine("¡Ingrese un precio correcto!\n");
            }

            Array.Resize(ref Nombres, Nombres.Length + 1);
            Array.Resize(ref Precios, Precios.Length + 1);
            Nombres[pos] = nombre;
            Precios[pos] = precio;
            pos++;

            Console.WriteLine("\nEl libro se registro correctamente. ");
        }

        public void Mostrar() 
        {
            Console.Clear();
            Console.WriteLine("\tLibros\t\tPrecios");

            if (Nombres.Length == 0) 
            {
                Console.WriteLine("\nNo hay libros registrados. ");
                return;
            }

            for (int i = 0; i < Precios.Length; i++) 
            {
                Console.WriteLine($"{i + 1}. {Nombres[i]}\t-\tS/. {Precios[i]}");
            }
        }

        public void Modificar() 
        {
            Console.Clear();
            if (Nombres.Length == 0)
            {
                Console.WriteLine("No hay libros registrados para modificar");
                return;
            }

            Console.Write("\nIngrese el nombre del libro a modificar: ");
            string nombreBuscar = Console.ReadLine();
            int Índice = -1;


            for (int i = 0; i < Nombres.Length; i++) 
            {
                if (Nombres[i] == nombreBuscar) 
                {
                    Índice = i;
                    break;
                }

            }

            if (Índice == -1) 
            {
                Console.WriteLine("\nNo se encontró un libro con ese nombre. ");
                return;
            }

            Console.WriteLine($"\nLibro encontrado: {Nombres[Índice]} - S/. {Precios[Índice]}");

            string NuevoNombre;
            while (true) 
            {
                Console.Write("\nIngrese el nuevo nombre del libro: ");
                NuevoNombre = Console.ReadLine();

                if (NuevoNombre == "") 
                {
                    Console.WriteLine("¡El nombre no puede estar vacío o nulo!");
                    continue;
                }

                bool repetido = false;
                for (int i = 0; i < Nombres.Length; i++) 
                {
                    if (Nombres[i] == NuevoNombre && i != Índice) 
                    {
                        repetido = true;
                        break;
                    }
                }

                if (repetido) 
                {
                    Console.WriteLine("¡Ya existe un libro con ese nombre!");
                    continue;
                }
                break;
            }

            double NuevoPrecio;
            while (true) 
            {
                Console.Write("Ingrese el nuevo precio del libro: S/. ");
                if (double.TryParse(Console.ReadLine(), out NuevoPrecio) & NuevoPrecio >= 0 && NuevoPrecio <= 1000) break;
                else Console.WriteLine("¡Ingrese un precio válido (0 - 1000) !");
            }


            Nombres[Índice] = NuevoNombre;
            Precios[Índice] = NuevoPrecio;

            Console.WriteLine("\nEl libro se modificó correctamente.");
        }

        public void Eliminar() 
        {
            Console.Clear();

            if (Nombres.Length == 0) 
            {
                Console.WriteLine("No hay libros registrados para eliminar");
                return;
            }
           
            int Índice = -1;
            Console.Write("\nIngrese el nombre del libro a eliminar: ");
            string nombreEliminar = Console.ReadLine();

            for (int i = 0; i < Nombres.Length; i++) 
            {
                if (Nombres[i] == nombreEliminar) 
                {
                    Índice = i;
                    break;
                }
            }

            if (Índice != -1)
            {
                for (int j = Índice; j < Nombres.Length - 1; j++)
                {
                    Nombres[j] = Nombres[j + 1];
                    Precios[j] = Precios[j + 1];
                }

                Array.Resize(ref Nombres, Nombres.Length - 1);
                Array.Resize(ref Precios, Precios.Length - 1);
                pos--;
                Console.WriteLine($"\nEl libro \"{nombreEliminar}\" fue eliminado correctamente.");
            }
            else Console.WriteLine("\nNo se puede eliminar porque no existe. ");
        }

    }
}
