using System;
using poo_guia_1_abnerP.Ejercicios;

namespace poo_guia_1_abnerP
{
    class Program
    {
        static int ObtenerEntero(string mensaje)
        {
            int resultado = 0;
            bool valido = false;

            do
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine() ?? "";
                valido = int.TryParse(entrada, out resultado);
            } while (!valido);

            return resultado;
        }

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("      MENU PRINCIPAL      ");
                Console.WriteLine("  1. Calculadora IMC");
                Console.WriteLine("  2. Convertidor de Temperatura");
                Console.WriteLine("  3. Desglose de Billetes");
                Console.WriteLine("  0. Salir");
                Console.Write("  Ingrese su opción: ");

                opcion = ObtenerEntero("");

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
                    case 3:
                        Console.WriteLine("\n  --- DESGLOSE DE BILLETES ---");
                        int monto = ObtenerEntero("  Ingrese el monto en lempiras: ");
                        BillsDesglose.DesglosarBilletes(monto);
                        break;
                    default:
                        Console.WriteLine("\n  Opción no válida. Ingrese un número del 0 al 3.\n");
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
 //AGREGAR NUEVAS OPCIONES DESPS