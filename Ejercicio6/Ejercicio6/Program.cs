using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico6
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;

            ingresoDatos horario = new ingresoDatos();
            Console.WriteLine("MENU \n1 para introducir los datos \n2 para mostrar el horario \n3 Para modificarlos \n4 Para finalizar el programa.");
            menu = int.Parse(Console.ReadLine());
            while (menu != 1 || menu != 2 || menu != 3 || menu != 4)
            {
                switch (menu)
                {
                    case 1:


                        horario.ingreso();
                        Console.ReadKey();

                        break;

                    case 2:

                        Console.WriteLine(horario.mostrarHora());
                        Console.ReadKey();

                        break;

                    case 3:

                        horario.modificar();
                        Console.ReadKey();

                        break;

                }
                Console.Clear();
                Console.WriteLine("MENU \n1 para introducir los datos \n2 para mostrar el horario \n3 Para modificarlos \n4 Para finalizar el programa.");
                menu = int.Parse(Console.ReadLine());
                if (menu == 4)
                {
                    Console.WriteLine("Finalizar programa");
                    Console.ReadKey();
                    break;
                }

            }

        }

        class ingresoDatos
        {
            int horas = 0;
            int horas2 = 0;
            int minutos = 0;
            int minutos2 = 0;
            int segundos = 0;
            int segundos2 = 0;
            int milisegundos = 0;
            int milisegundos2 = 0;
            int menu2 = 0;

            public void ingreso()
            {
                Console.WriteLine("Ingrese la hora");
                horas = int.Parse(Console.ReadLine());
                while (horas < 0 || horas > 24)
                {
                    Console.WriteLine("Ingrese una hora comprendida entre 0 y 24 por favor");
                    horas = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingrese el minuto");
                minutos = int.Parse(Console.ReadLine());
                while (minutos < 0 || minutos > 59)
                {
                    Console.WriteLine("Ingrese un minuto comprendido entre 0 y 59 por favor");
                    minutos = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingrese el segundo");
                segundos = int.Parse(Console.ReadLine());
                while (segundos < 0 || segundos > 59)
                {
                    Console.WriteLine("Ingrese un segundo comprendido entre 0 y 59 por favor");
                    segundos = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingrese el milisegundo");
                milisegundos = int.Parse(Console.ReadLine());
                while (milisegundos < 0 || milisegundos > 999)
                {
                    Console.WriteLine("Ingrese un milisegundo comprendido entre 0 y 59 por favor");
                    milisegundos = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\n Pulse cualquier tecla para volver al menu.");
            }
            public string mostrarHora()
            {
                return "La hora es  " + horas + ":" + minutos + ":" + segundos + ":" + milisegundos + "\nPulse cualquier tecla para volver al menú";
            }

            public void modificar()
            {
                Console.WriteLine("Que tipo de modificacion quiere.\n1. Cambiar horario\n2. Sumar hora. \n3 Sumar minutos. \n4 Sumar segundos. \n5 Sumar milisegundos.");
                menu2 = int.Parse(Console.ReadLine());




                if (menu2 == 1)
                {
                    Console.WriteLine("Ingrese el nuevo horario");
                    Console.WriteLine("Ingrese la nueva hora");
                    horas = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese los nuevos minutos");
                    minutos = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese los nuevos segundos");
                    segundos = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese los nuevos milisegundos");
                    milisegundos = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Presione cualquier tecla para continuar");
                }

                if (menu2 == 2)
                {

                    Console.WriteLine("Ingrese la nueva hora a sumar");
                    horas2 = int.Parse(Console.ReadLine());
                    while (horas2 + horas > 24)
                    {
                        Console.WriteLine("Ingrese un numero menor para sumar a horas");
                        horas2 = int.Parse(Console.ReadLine());
                        horas = horas + horas2;
                        break;
                    }

                    Console.WriteLine("Presione cualquier tecla para continuar");
                }



                if (menu2 == 3)
                {
                    Console.WriteLine("Ingrese los nuevos minutos  a sumar");
                    minutos2 = int.Parse(Console.ReadLine());
                    while (minutos2 + minutos > 60)
                    {
                        Console.WriteLine("Ingrese un numero menor para sumar a minutos");

                        minutos2 = int.Parse(Console.ReadLine());
                        minutos = minutos + minutos2;
                        break;
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar");
                }



                if (menu2 == 4)
                {
                    Console.WriteLine("Ingrese los nuevos segundos a sumar");
                    segundos2 = int.Parse(Console.ReadLine());

                    while (segundos2 + segundos > 60)
                    {

                        Console.WriteLine("Ingrese un numero menor para sumar a segundos");

                        segundos2 = int.Parse(Console.ReadLine());
                        segundos = segundos + segundos2;
                        break;
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar");
                }


                if (menu2 == 5)
                {
                    Console.WriteLine("Ingrese los nuevos milisegundos a sumar");
                    milisegundos2 = int.Parse(Console.ReadLine());

                    while (milisegundos2 + milisegundos > 999)
                    {

                        Console.WriteLine("Ingrese un numero menor para sumar a milisegundos");

                        milisegundos2 = int.Parse(Console.ReadLine());
                        milisegundos = milisegundos2 + milisegundos;
                        break;
                    }

                    Console.WriteLine("Presione cualquier tecla para continuar");

                }






            }
            public void verificacion()
            {
                while (horas < 0 || horas > 24)
                {
                    Console.WriteLine("Ingrese una hora comprendida entre 0 y 24 por favor");
                    horas = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingrese los nuevos minutos");
                minutos = int.Parse(Console.ReadLine());
                while (minutos < 0 || minutos > 59)
                {
                    Console.WriteLine("Ingrese un minuto comprendido entre 0 y 59 por favor");
                    minutos = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingrese los segundos");
                segundos = int.Parse(Console.ReadLine());
                while (segundos < 0 || segundos > 59)
                {
                    Console.WriteLine("Ingrese un segundo comprendido entre 0 y 59 por favor");
                    segundos = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingrese los milisegundos");
                milisegundos = int.Parse(Console.ReadLine());
                while (milisegundos < 0 || milisegundos > 999)
                {
                    Console.WriteLine("Ingrese un milisegundo comprendido entre 0 y 999 por favor");
                    milisegundos = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("La hora es  " + horas + ":" + minutos + ":" + segundos + ":" + milisegundos);
            }


        }
    }

}