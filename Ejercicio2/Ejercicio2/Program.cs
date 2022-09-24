using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Practico_Equipo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = " ";
            string name2 = " ";
            int age1 = 0;
            int age2 = 0;

            Console.WriteLine(" 1.Ingrese su nombre\n 2.Ingrese su edad\n 3.Mostrar informacion\n 0.Terminar bucle");
            string menu = Console.ReadLine();
            while (menu != "0")
            {
                switch (menu)
                {
                    case "1":
                        Console.WriteLine("Introduce el nombre del primer alumno: ");
                        name1 = Console.ReadLine();
                        Console.WriteLine("Introduce el nombre del segundo alumno: ");
                        name2 = Console.ReadLine();
                        Console.WriteLine(" 1.Ingrese su nombre\n 2.Ingrese su edad\n 3.Mostrar informacion\n 0.Terminar bucle");
                        menu = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Introduce la edad del primer alumno: ");
                        age1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la edad del segundo alumno: ");
                        age2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(" 1.Ingrese su nombre\n 2.Ingrese su edad\n 3.Mostrar informacion\n 0.Terminar bucle");
                        menu = Console.ReadLine();
                        break;
                    case "3":
                        Alumno nombre1 = new Alumno(name1, age1);
                        Alumno nombre2 = new Alumno(name2, age2);
                        Console.WriteLine(nombre1.getImprimirDatos());
                        Console.WriteLine(nombre2.getImprimirDatos());
                        menu = Console.ReadLine();
                        break;

                }

            }

        }
    }
    class Alumno
    {

        string nombre;
        int edad;

        public Alumno(string nombre1)
        {
            nombre = nombre1;

        }
        public Alumno(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public string getImprimirDatos()
        {
            return "Datos: \n" + "Nombre: " + nombre + "\n Edad: " + edad;
        }
    }


}
