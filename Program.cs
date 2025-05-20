using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoBusqueda_CSharp
{
    internal class Program
    {
        static void SecuencialDesordenado(int[] V, int X)
        {
            int N = V.Length;
            int I = 0;

            while (I < N && V[I] != X)
            {
                I++;
            }

            if (I >= N)
            {
                Console.WriteLine("La información no está en el arreglo.");
            }
            else
            {
                Console.WriteLine($"La información se encuentra en la posición {I}.");
            }
        }

        static void Binaria(int[] V, int X)
        {
            Array.Sort(V); // Ordenamos el arreglo antes de hacer la búsqueda binaria
            MostrarArreglo(V); // Mostramos el arreglo ordenado

            int IZQ = 0, N = V.Length, DER = N - 1, CEN = 0;
            bool BAN = false;

            while (IZQ <= DER && !BAN)
            {
                CEN = (IZQ + DER) / 2;

                if (X == V[CEN])
                {
                    BAN = true;
                }
                else
                {
                    if (X > V[CEN])
                    {
                        IZQ = CEN + 1;
                    }
                    else
                    {
                        DER = CEN - 1;
                    }
                }
            }

            if (BAN)
            {
                Console.WriteLine($"La información está en la posición {CEN}.");
            }
            else
            {
                Console.WriteLine("La información no se encuentra en el arreglo.");
            }
        }

        static void Hash(int[] V, int X)
        {
            Dictionary<int, int> tablaHash = new Dictionary<int, int>();

            // Insertar elementos del arreglo en la tabla hash
            for (int i = 0; i < V.Length; i++)
            {
                if (!tablaHash.ContainsKey(V[i]))
                {
                    tablaHash.Add(V[i], i); // Guardamos la posición original para su uso posterior
                }
            }

            // Buscar el elemento
            if (tablaHash.ContainsKey(X))
            {
                Console.WriteLine($"La información está en la posición {tablaHash[X]}.");
            }
            else
            {
                Console.WriteLine("La información no se encuentra en el arreglo.");
            }
        }

        // Método para mostrar un arreglo
        static void MostrarArreglo(int[] arreglo)
        {
            foreach (int num in arreglo)
                Console.Write(num + " ");
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            bool seguir = true;

            while (seguir)
            {
                Console.Clear();
                Console.Write("Ingrese el tamaño del arreglo: ");
                int N = Convert.ToInt32(Console.ReadLine());

                int[] arreglo = new int[N];
                Random rnd = new Random();

                for (int i = 0; i < N; i++)
                {
                    arreglo[i] = rnd.Next(1, 101); // Números entre 1 y 100
                }

                Console.WriteLine("\nArreglo generado:");
                MostrarArreglo(arreglo);

                Console.WriteLine("¿Qué número del 1 al 100 desea encontrar en el arreglo?");
                int elemento = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nSeleccione un método de búsqueda:");
                Console.WriteLine("1. Secuencial");
                Console.WriteLine("2. Binaria");
                Console.WriteLine("3. Transformación de claves (Hash)");
                Console.WriteLine("4. Salir");

                Console.Write("\nOpción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        SecuencialDesordenado(arreglo, elemento);
                        break;
                    case 2:
                        Binaria(arreglo, elemento);
                        break;
                    case 3:
                        Hash(arreglo, elemento);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        continue;
                }

                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}