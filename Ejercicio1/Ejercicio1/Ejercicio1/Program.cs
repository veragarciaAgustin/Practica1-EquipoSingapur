using System;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;

            Auto autito = new Auto(); //se aprovecha el constructor default.


            Console.WriteLine("Bienvenido al creador de vehiculos.");
            Console.WriteLine("Ingrese 1 para crear un vehiculo, 2 para mostrar el vehiculo");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                autito.modificarAuto();
            }

            if (menu == 2)
            {
                autito.mostrarAuto();
            }

            while (menu != 1 && menu != 2)
            {
                Console.WriteLine("Ingrese 1 para crear un vehiculo o 2 para mostrar los autos");
                menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    autito.modificarAuto();
                }

                if (menu == 2)
                {
                    autito.mostrarAuto();
                }
            }
        }

    }

    class Auto
    {

        string colorCarroceria = "0";
        string colorInterior = "0";
        string climatizador = "0";
        string climatizador2 = "";
        string dimensiones = "0";
        string marca = "0";


        public void modificarAuto()
        {
            int menu = 0;
            int menu2 = 0;


            Console.WriteLine("Ingrese el color de la carroceria \n 1 = Rojo \n 2 = Gris \n 3 = Blanco \n 4 = Azul");
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    colorCarroceria = "Rojo";

                    break;
                case 2:
                    colorCarroceria = "Gris";
                    break;
                case 3:
                    colorCarroceria = "Blanco";
                    break;
                case 4:
                    colorCarroceria = "Azul";
                    break;
            }

            while (menu != 1 && menu != 2 && menu != 3 && menu != 4)
            {
                Console.WriteLine("Ingrese un numero valido.");
                Console.WriteLine("MENU \n 1 = Rojo \n 2 = Gris \n 3 = Blanco \n 4 = Azul");
                menu = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
            Console.Clear();




            Console.WriteLine("Ingrese el color del interior \n 1 = Rojo \n 2 = Violeta \n 3 = Camel \n 4 = Lila");
            menu2 = int.Parse(Console.ReadLine());


            switch (menu2)
            {
                case 1:
                    colorInterior = "Rojo";

                    break;
                case 2:
                    colorInterior = "Violeta";
                    break;
                case 3:
                    colorInterior = "Camel";
                    break;
                case 4:
                    colorInterior = "Lila";
                    break;
            }
            while (menu2 != 1 && menu2 != 2 && menu2 != 3 && menu2 != 4)
            {
                Console.WriteLine("MENU \n 1 = Rojo \n 2 = Violeta \n 3 = Camel \n 4 = Lila");
                menu2 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("El auto cuenta con climatizador \n 1 = Caliente \n 2 = Frio");

            climatizador = Console.ReadLine();

            if (climatizador == "1")
            {
                climatizador2 = "Caliente";
            }
            else if (climatizador == "2")
            {
                climatizador2 = "Frio";
            }


            while (climatizador != "1" && climatizador != "2")
            {
                Console.WriteLine("Ingrese una opcion valida para el c*limatizador. \n 1 = Caliente \n 2 = Frio");
                climatizador = Console.ReadLine();
                if (climatizador == "1")
                {
                    climatizador2 = "Caliente";
                }
                else if (climatizador == "2")
                {
                    climatizador2 = "Frio";
                }
            }


            Console.WriteLine("Ingrese las dimensiones del vehiculo (ancho y largo)");
            dimensiones = Console.ReadLine();
            Console.WriteLine("Ingrese la marca de auto");
            marca = Console.ReadLine();


            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            mostrarMenu();
        }

        public void mostrarMenu()
        {
            int menu = 0;
            Console.WriteLine("Bienvenido al creador de vehiculos.");
            Console.WriteLine("Ingrese 1 para crear un vehiculo, 2 para mostrar el vehiculo");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                modificarAuto();
            }

            if (menu == 2)
            {
                mostrarAuto();
            }

            while (menu != 1 && menu != 2)
            {
                Console.WriteLine("Ingrese 1 para crear un vehiculo o 2 para mostrar los autos");
                menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    modificarAuto();
                }

                if (menu == 2)
                {
                    mostrarAuto();
                }
            }
        }

        public void mostrarAuto()
        {
            Console.WriteLine("Especificaciones del auto\n" + "Dimensiones:   " + dimensiones + "\n" + "Marca:   " + marca + "\n" + "Climatizador:    " + climatizador2 + "\n" + "Color de la carroceria:    " + colorCarroceria + "\n" + "Color del interior:  " + colorInterior);
            Console.WriteLine("Presione cualquier tecla para finalizar el  programa");
            Console.ReadKey();
            Console.Clear();
        }

    }
}