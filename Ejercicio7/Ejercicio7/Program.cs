using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NotaDeEntrega nota = new NotaDeEntrega();
            Factura factur = new Factura();
            FacturaLuz factura = new FacturaLuz();
            Municipal municip = new Municipal();
            ReciboSueldo recibo = new ReciboSueldo();

            Console.WriteLine("Ingrese la operación a realizar\n 1 para ingresar datos\n 2 para mostarlos\n 0 para terminar");
            int menu = int.Parse(Console.ReadLine());
            while (menu != 1 || menu != 2)
            {

                switch (menu)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese la nota de entrega:\n ");
                        nota.Ingresar();
                        Console.Clear();

                        Console.WriteLine("Ingrese la nota de la factura:\n ");
                        factur.Ingreso();
                        Console.Clear();

                        Console.WriteLine("Ingrese la nota de la factura de luz:\n ");
                        factura.IngresoDatos();
                        Console.Clear();

                        Console.WriteLine("Ingrese los datos municipales:\n ");
                        municip.ingresoData();
                        Console.Clear();

                        Console.WriteLine("Ingrese los datos correspondientes al recibo:\n ");
                        recibo.ingresoDato();
                        Console.Clear();

                        Console.WriteLine("Introducción de datos terminada");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(nota.mostrarEntrega());
                        Console.WriteLine(factur.mostrarFactura());
                        Console.WriteLine(factura.mostrarFactura());
                        Console.WriteLine(municip.mostrarMunicipal());
                        Console.ReadKey();
                        Console.Clear();

                        break;



                }
                Console.Clear();
                Console.WriteLine("Ingrese la operación a realizar\n 1 para ingresar datos\n 2 para mostarlos\n 0 para terminar");
                menu = int.Parse(Console.ReadLine());
                if (menu == 0)
                {
                    Console.WriteLine("Gracias por su participación");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }

    class NotaDeEntrega
    {
        int CantBultos = 0;
        string fecha;
        int numero = 0;

        public void Ingresar()
        {
            Console.WriteLine("Ingrese la cantidad de bultos");
            CantBultos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha");
            fecha = (Console.ReadLine());
            Console.WriteLine("Ingres el numero de la entrega");
            numero = int.Parse(Console.ReadLine());
        }
        public string mostrarEntrega()
        {
            return "La nota de entrega de entrega está compuesta por:" + " cantidad de bultos " + CantBultos + " en la fecha " + fecha + " y el numero " + numero;
        }
    }
    class Factura
    {
        string fecha;
        int importe = 0;
        public void Ingreso()
        {
            Console.WriteLine("Ingrese la fecha de la factura\n");
            fecha = (Console.ReadLine());
            Console.WriteLine("Ingrese la fecha del importe\n");
            importe = int.Parse(Console.ReadLine());
        }

        public string mostrarFactura()
        {
            return "La factura está compuesta por la fecha " + fecha + " importe " + importe;
        }
    }
    class FacturaLuz
    {
        int CodigoPago = 0;
        int importe = 0;
        public void IngresoDatos()
        {
            Console.WriteLine("Ingrese el codigo del pago\n");
            CodigoPago = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el importe\n");
            importe = int.Parse(Console.ReadLine());
        }
        public string mostrarFactura()
        {
            return "La factura de la luz es la siguiente, codigo de pago: " + CodigoPago + "\nEl importe: " + importe;
        }
    }
    class Municipal
    {
        int importe = 0;
        int partida = 0;
        public void ingresoData()
        {
            Console.WriteLine("Ingrese el importe\n");
            importe = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de la partida\n");
            partida = int.Parse(Console.ReadLine());
        }

        public string mostrarMunicipal()
        {
            return "El importe municipal es: " + importe + "\n" + "La partida: " + partida;
        }
    }
    class ReciboSueldo
    {
        int legajo = 0;
        int total = 0;

        public void ingresoDato()
        {
            Console.WriteLine("Ingrese el total de los legajos\n");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el monto total\n");
            total = int.Parse(Console.ReadLine());
        }

        public string mostrarReciboSueldo()
        {
            return "El recibo de sueldo es: " + total;
        }
    }

}