using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Matrices
    {
        private int[,] Matriz1;
        private int[,] Matriz2;
        private int[,] Matriz3;


        public void Cargar()
        {
            int n;
            int m;
            Console.WriteLine("Ingrese la cantidad de filas");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas");
            m = int.Parse(Console.ReadLine());


            Matriz1 = new int[10, 10];
            Matriz2 = new int[10, 10];
            Matriz3 = new int[10, 10];
            Console.WriteLine("Ingresando datos a la matriz 1");
            for (int i = 1; i <= n; i++)
            {
                for (int i2 = 1; i2 <= m; i2++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + i2 + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    Matriz1[i, i2] = int.Parse(linea);

                }
            }
            Console.WriteLine("Ingresando datos a la matriz 2");
            for (int i = 1; i <= n; i++)
            {
                for (int i2 = 1; i2 <= m; i2++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + i2 + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    Matriz2[i, i2] = int.Parse(linea);
                }




            }
            //Sumamos la Matriz 1 y la Matriz 2
            for (int i = 1; i <= n; i++)
            {
                for (int i2 = 1; i2 <= m; i2++)
                {
                    Matriz3[i, i2] = Matriz1[i, i2] + Matriz2[i, i2];
                }
            }

            Console.WriteLine("La suma de la Matriz 1 y Matriz 2 es :");
            for (int i = 1; i <= n; i++)
            {
                Console.Write("\n");
                for (int i2 = 1; i2 <= m; i2++)
                {
                    Console.Write(Matriz3[i, i2] + "  ");
                }
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Matrices pv = new Matrices();
            pv.Cargar();
        }
    }
}