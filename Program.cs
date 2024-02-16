using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambioMoneda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Bienvenido al conversor de dólares a euros!");
                Console.WriteLine("Por favor, introduce el tipo de cambio del día (dólares por euro): ");
                double tipoCambio = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("¿Qué deseas hacer?");
                Console.WriteLine("1. Convertir de dólares a euros");
                Console.WriteLine("2. Convertir de euros a dólares");
                Console.Write("Selecciona una opción (1-2): ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ConvertirDolaresAEuros(tipoCambio);
                        break;
                    case 2:
                        ConvertirEurosADolares(tipoCambio);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("¿Deseas realizar otra conversión? (s/n): ");
            } while (Console.ReadLine().ToLower() == "s");
        }

        static void ConvertirDolaresAEuros(double tipoCambio)
        {
            Console.Write("Introduce la cantidad en dólares: ");
            double dolares = Convert.ToDouble(Console.ReadLine());

            double euros = dolares / tipoCambio;
            Console.WriteLine($"La cantidad equivalente en euros es: {euros:N2}");
        }

        static void ConvertirEurosADolares(double tipoCambio)
        {
            Console.Write("Introduce la cantidad en euros: ");
            double euros = Convert.ToDouble(Console.ReadLine());

            double dolares = euros * tipoCambio;
            Console.WriteLine($"La cantidad equivalente en dólares es: {dolares:N2}");

        }
    }
}
