using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_y_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU\n1. Sumar\n2. Restar\n3. Calcular distancia\n4. Terminar");
            int menu = int.Parse(Console.ReadLine());
            while (menu != 0)
            {
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        suma suma1 = new suma();
                        suma1.sumando();
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("MENU\n1. Sumar\n2. Restar\n3. Calcular distancia\n4. Terminar");
                        menu = int.Parse(Console.ReadLine());

                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Resta resta1 = new Resta();
                        resta1.restando();
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("MENU\n1. Sumar\n2. Restar\n3. Calcular distancia\n4. Terminar");
                        menu = int.Parse(Console.ReadLine());

                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Distancia distancia = new Distancia();
                        distancia.mostrarDistancia();
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("MENU\n1. Sumar\n2. Restar\n3. Calcular distancia\n4. Terminar");
                        menu = int.Parse(Console.ReadLine());

                        Console.Clear();
                        break;
                }
                if (menu == 4)
                {
                    Console.WriteLine("Gracias...");
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("MENU\n1. Sumar\n2. Restar\n3. Calcular distancia\n4. Terminar");
                menu = int.Parse(Console.ReadLine());

            }



        }
    }
    class suma
    {
        public double num1;
        public double num2;
        public double resultado;

        public void sumando()
        {
            Console.WriteLine("Ingresa un número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro número: ");
            num2 = int.Parse(Console.ReadLine());
            resultado = num1 + num2;
            Console.WriteLine("El resultado es: " + resultado);

        }
    }
    class Resta
    {
        public double num1;
        public double num2;
        public double resultado;

        public void restando()
        {
            Console.WriteLine("Ingresa un número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro número: ");
            num2 = int.Parse(Console.ReadLine());
            resultado = num1 - num2;
            Console.WriteLine("El resultado es: " + resultado);

        }
    }
    class Distancia
    {
        public double num1;
        public double num2;
        public double diferencia;

        public void mostrarDistancia()
        {
            Console.WriteLine("Ingresa un número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro número: ");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                diferencia = num1 - num2;
                if (diferencia < 0)
                {
                    diferencia = diferencia * -1;
                }

                Console.WriteLine("La distancia entre " + num1 + " y " + num2 + " es: " + diferencia);

            }
            if (num2 > num1)
            {
                diferencia = num1 - num2;
                if (diferencia < 0)
                {
                    diferencia = diferencia * -1;
                }

                Console.WriteLine("La distancia entre " + num1 + " y " + num2 + " es: " + diferencia);
            }
        }
    }
}
