using System;
using poo_guia_1_abnerP.Ejercicios;

namespace poo_guia_1_abnerP
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("      MENU PRINCIPAL      ");
                Console.WriteLine("  1. Calculadora IMC");
                Console.WriteLine("  2. Convertidor de Temperatura");
                Console.WriteLine("  0. Salir");
                Console.Write("  Ingrese su opción: ");

                string entrada = Console.ReadLine();
                bool opcionValida = int.TryParse(entrada, out opcion);

                if (!opcionValida)
                {
                    Console.WriteLine("\n  Por favor ingrese un número válido (0-2).\n");
                    continue;
                }

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("\n  Programa terminado.");
                        break;
                    case 1:
                        Console.WriteLine("\n  --- CALCULADORA IMC ---");
                        CalculadoraIMC imc = new CalculadoraIMC();
                        imc.Ejecutar();
                        break;
                    case 2:
                        Console.WriteLine("\n  --- CONVERTIDOR DE TEMPERATURA ---");
                        TempConvert.Ejecutar();
                        break;
                    default:
                        Console.WriteLine("\n  Opción no válida. Ingrese un número del 0 al 2.\n");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\n  Presione Enter para continuar...");
                    Console.ReadLine();
                }

            } while (opcion != 0);
        }
    }
}
