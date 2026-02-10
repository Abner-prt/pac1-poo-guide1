using System;
using poo_guia_1_abnerP.Ejercicios.Bloque1;
using poo_guia_1_abnerP.Ejercicios.Bloque2;

namespace poo_guia_1_abnerP
{
    class Program
    {
        int ObtenerEntero(string mensaje)
        {
            int resultado = 0;
            bool valido = false;

            do
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine() ?? "";
                try
                {
                    resultado = int.Parse(entrada);
                    valido = true;
                }
                catch
                {
                    Console.WriteLine("  Por favor ingrese un número válido.");
                    valido = false;
                }
            } while (!valido);

            return resultado;
        }

        void MostrarMenuPrincipal()
        {
            Console.WriteLine("      MENU PRINCIPAL      ");
            Console.WriteLine("  1. Bloque 1");
            Console.WriteLine("  2. Bloque 2");
            Console.WriteLine("  0. Salir");
            Console.Write("  Ingrese su opción: ");
        }

        void MostrarMenuBloque1()
        {
            Console.WriteLine("\n      BLOQUE 1      ");
            Console.WriteLine("  1. Calculadora IMC");
            Console.WriteLine("  2. Convertidor de Temperatura");
            Console.WriteLine("  3. Desglose de Billetes");
            Console.WriteLine("  4. Calculadora de Prestamo Simple");
            Console.WriteLine("  5. Tiempo Transcurrido");
            Console.WriteLine("  6. Area y Perimetro");
            Console.WriteLine("  7. Conversion de Unidades de Almacenamiento");
            Console.WriteLine("  8. Calculo de Salario Semanal");
            Console.WriteLine("  0. Volver al menu principal");
            Console.Write("  Ingrese su opción: ");
        }

        void MostrarMenuBloque2()
        {
            Console.WriteLine("\n      BLOQUE 2      ");
            Console.WriteLine("  1. Clasificacion de Triangulo");
            Console.WriteLine("  2. Sistema de Calificaciones UNAH");
            Console.WriteLine("  3. Calculadora de Descuentos");
            Console.WriteLine("  0. Volver al menu principal");
            Console.Write("  Ingrese su opción: ");
        }

        void EjecutarBloque1()
        {
            int opcion;
            bool continuar = true;

            while (continuar)
            {
                MostrarMenuBloque1();

                try
                {
                    opcion = int.Parse(Console.ReadLine() ?? "");
                }
                catch
                {
                    opcion = -1;
                }

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("\n  Volviendo al menu principal...");
                        continuar = false;
                        break;
                    case 1:
                        Console.WriteLine("\n  --- CALCULADORA IMC ---");
                        CalculadoraIMC imc = new CalculadoraIMC();
                        imc.Ejecutar();
                        break;
                    case 2:
                        Console.WriteLine("\n  --- CONVERTIDOR DE TEMPERATURA ---");
                        TempConvert tempConvert = new TempConvert();
                        tempConvert.Ejecutar();
                        break;
                    case 3:
                        Console.WriteLine("\n  --- DESGLOSE DE BILLETES ---");
                        int monto = ObtenerEntero("  Ingrese el monto en lempiras: ");
                        BillsDesglose bills = new BillsDesglose();
                        bills.DesglosarBilletes(monto);
                        break;
                    case 4:
                        Console.WriteLine("\n  --- CALCULADORA DE PRESTAMO SIMPLE ---");
                        CalculadoraPSimple prestamo = new CalculadoraPSimple();
                        prestamo.Ejecutar();
                        break;
                    case 5:
                        Console.WriteLine("\n  --- TIEMPO TRANSCURRIDO ---");
                        TiempoTranscurrido tiempo = new TiempoTranscurrido();
                        tiempo.Ejecutar();
                        break;
                    case 6:
                        Console.WriteLine("\n  --- AREA Y PERIMETRO ---");
                        AreaYPerim areaPerim = new AreaYPerim();
                        areaPerim.Ejecutar();
                        break;
                    case 7:
                        Console.WriteLine("\n  --- CONVERSION DE UNIDADES DE ALMACENAMIENTO ---");
                        ConvUnidsAlm convUnids = new ConvUnidsAlm();
                        convUnids.Ejecutar();
                        break;
                    case 8:
                        Console.WriteLine("\n  --- CALCULO DE SALARIO SEMANAL ---");
                        CalcSemSalary salario = new CalcSemSalary();
                        salario.Ejecutar();
                        break;
                    default:
                        Console.WriteLine("\n  Opción no válida. Ingrese un número del 0 al 8.\n");
                        break;
                }

                if (continuar && opcion >= 1 && opcion <= 8)
                {
                    Console.WriteLine("\n  Presione Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }

        void EjecutarBloque2()
        {
            int opcion;
            bool continuar = true;

            while (continuar)
            {
                MostrarMenuBloque2();

                try
                {
                    opcion = int.Parse(Console.ReadLine() ?? "");
                }
                catch
                {
                    opcion = -1;
                }

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("\n  Volviendo al menu principal...");
                        continuar = false;
                        break;
                    case 1:
                        Console.WriteLine("\n  --- CLASIFICACION DE TRIANGULO ---");
                        ClasifTriang triangulo = new ClasifTriang();
                        triangulo.Ejecutar();
                        break;
                    case 2:
                        Console.WriteLine("\n  --- SISTEMA DE CALIFICACIONES UNAH ---");
                        UnahCalifs calif = new UnahCalifs();
                        calif.Ejecutar();
                        break;
                    case 3:
                        Console.WriteLine("\n  --- CALCULADORA DE DESCUENTOS ---");
                        CalcuDesc descuento = new CalcuDesc();
                        descuento.Ejecutar();
                        break;
                    default:
                        Console.WriteLine("\n  Opción no válida. Ingrese un número del 0 al 3.\n");
                        break;
                }

                if (continuar && opcion >= 1 && opcion <= 3)
                {
                    Console.WriteLine("\n  Presione Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }

        static void Main(string[] args)
        {
            Program programa = new Program();
            int opcion;

            do
            {
                programa.MostrarMenuPrincipal();
                opcion = programa.ObtenerEntero("");

                switch (opcion)
                {
                    case 1:
                        programa.EjecutarBloque1();
                        break;
                    case 2:
                        programa.EjecutarBloque2();
                        break;
                    case 0:
                        Console.WriteLine("\n  Programa terminado.");
                        break;
                    default:
                        Console.WriteLine("\n  Opción no válida. Ingrese un número del 0 al 2.\n");
                        break;
                }

            } while (opcion != 0);
        }
    }
}
