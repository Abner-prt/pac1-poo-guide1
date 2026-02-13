using System;
using poo_guia_1_abnerP.Ejercicios.Bloque1;
using poo_guia_1_abnerP.Ejercicios.Bloque2;
using poo_guia_1_abnerP.Ejercicios.Bloque3;
using poo_guia_1_abnerP.Ejercicios.Bloque4;
using poo_guia_1_abnerP.Ejercicios.Bloque5;

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
                string entrada = Console.ReadLine();
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
            Console.WriteLine("  3. Bloque 3");
            Console.WriteLine("  4. Bloque 4");
            Console.WriteLine("  5. Bloque 5");
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
            Console.WriteLine("  4. Año Bisiesto y Dias del Mes");
            Console.WriteLine("  5. Validador de Fechas");
            Console.WriteLine("  6. Cajero Automatico");
            Console.WriteLine("  0. Volver al menu principal");
            Console.Write("  Ingrese su opción: ");
        }

        void MostrarMenuBloque3()
        {
            Console.WriteLine("\n      BLOQUE 3      ");
            Console.WriteLine("  1. Tabla de Multiplicar Extendida");
            Console.WriteLine("  2. Numeros Primos en Rango");
            Console.WriteLine("  3. Serie de Fibonacci");
            Console.WriteLine("  4. Factorial y Combinaciones");
            Console.WriteLine("  5. Juego de Adivinanza");
            Console.WriteLine("  6. Validacion de Contrasena");
            Console.WriteLine("  7. Calculadora con Menu");
            Console.WriteLine("  0. Volver al menu principal");
            Console.Write("  Ingrese su opción: ");
        }

        void MostrarMenuBloque4()
        {
            Console.WriteLine("\n      BLOQUE 4      ");
            Console.WriteLine("  1. Estadisticas de Calificaciones");
            Console.WriteLine("  2. Busqueda y Ordenamiento");
            Console.WriteLine("  3. Rotacion de Arreglo");
            Console.WriteLine("  4. Frecuencia de Elementos");
            Console.WriteLine("  5. Arreglo de Temperaturas");
            Console.WriteLine("  0. Volver al menu principal");
            Console.Write("  Ingrese su opción: ");
        }

        void MostrarMenuBloque5()
        {
            Console.WriteLine("\n      BLOQUE 5      ");
            Console.WriteLine("  1. Matriz de Notas por Examen");
            Console.WriteLine("  2. Juego Tic-Tac-Toe");
            Console.WriteLine("  3. Inventario Simple");
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
                    opcion = int.Parse(Console.ReadLine());
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
                    opcion = int.Parse(Console.ReadLine());
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
                    case 4:
                        Console.WriteLine("\n  --- AÑO BISIESTO Y DIAS DEL MES ---");
                        AñoBisYDMes añoBis = new AñoBisYDMes();
                        añoBis.Ejecutar();
                        break;
                    case 5:
                        Console.WriteLine("\n  --- VALIDADOR DE FECHAS ---");
                        ValidFechas fecha = new ValidFechas();
                        fecha.Ejecutar();
                        break;
                    case 6:
                        Console.WriteLine("\n  --- CAJERO AUTOMATICO ---");
                        CajeroAut cajero = new CajeroAut();
                        cajero.Ejecutar();
                        break;
                    default:
                        Console.WriteLine("\n  Opción no válida. Ingrese un número del 0 al 6.\n");
                        break;
                }

                if (continuar && opcion >= 1 && opcion <= 6)
                {
                    Console.WriteLine("\n  Presione Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }

        void EjecutarBloque3()
        {
            int opcion;
            bool continuar = true;

            while (continuar)
            {
                MostrarMenuBloque3();

                try
                {
                    opcion = int.Parse(Console.ReadLine());
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
                        Console.WriteLine("\n  --- TABLA DE MULTIPLICAR EXTENDIDA ---");
                        TablaMultExt tabla = new TablaMultExt();
                        tabla.Ejecutar();
                        break;
                    case 2:
                        Console.WriteLine("\n  --- NUMEROS PRIMOS EN RANGO ---");
                        NumsPrimsRang primos = new NumsPrimsRang();
                        primos.Ejecutar();
                        break;
                    case 3:
                        Console.WriteLine("\n  --- SERIE DE FIBONACCI ---");
                        SerieFibo fibo = new SerieFibo();
                        fibo.Ejecutar();
                        break;
                    case 4:
                        Console.WriteLine("\n  --- FACTORIAL Y COMBINACIONES ---");
                        FactoCombi facto = new FactoCombi();
                        facto.Ejecutar();
                        break;
                    case 5:
                        Console.WriteLine("\n  --- JUEGO DE ADIVINANZA ---");
                        AdiviGame adivina = new AdiviGame();
                        adivina.Ejecutar();
                        break;
                    case 6:
                        Console.WriteLine("\n  --- VALIDACION DE CONTRASENA ---");
                        PasswordVali password = new PasswordVali();
                        password.Ejecutar();
                        break;
                    case 7:
                        Console.WriteLine("\n  --- CALCULADORA CON MENU ---");
                        MenuCalcu calcu = new MenuCalcu();
                        calcu.Ejecutar();
                        break;
                    default:
                        Console.WriteLine("\n  Opción no válida. Ingrese un número del 0 al 7.\n");
                        break;
                }

                if (continuar && opcion >= 1 && opcion <= 7)
                {
                    Console.WriteLine("\n  Presione Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }

        void EjecutarBloque4()
        {
            int opcion;
            bool continuar = true;

            while (continuar)
            {
                MostrarMenuBloque4();

                try
                {
                    opcion = int.Parse(Console.ReadLine());
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
                        Console.WriteLine("\n  --- ESTADISTICAS DE CALIFICACIONES ---");
                        EstadisticaCalif estadisticas = new EstadisticaCalif();
                        estadisticas.Ejecutar();
                        break;
                    case 2:
                        Console.WriteLine("\n  --- BUSQUEDA Y ORDENAMIENTO ---");
                        BusquedaOrdenam busqueda = new BusquedaOrdenam();
                        busqueda.Ejecutar();
                        break;
                    case 3:
                        Console.WriteLine("\n  --- ROTACION DE ARREGLO ---");
                        ArrayRotation rotacion = new ArrayRotation();
                        rotacion.Ejecutar();
                        break;
                    case 4:
                        Console.WriteLine("\n  --- FRECUENCIA DE ELEMENTOS ---");
                        FreqElemen frecuencia = new FreqElemen();
                        frecuencia.Ejecutar();
                        break;
                    case 5:
                        Console.WriteLine("\n  --- ARREGLO DE TEMPERATURAS ---");
                        ArregloTemps temps = new ArregloTemps();
                        temps.Ejecutar();
                        break;
                    default:
                        Console.WriteLine("\n  Opción no válida. Ingrese un número del 0 al 5.\n");
                        break;
                }

                if (continuar && opcion >= 1 && opcion <= 5)
                {
                    Console.WriteLine("\n  Presione Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }

        void EjecutarBloque5()
        {
            int opcion;
            bool continuar = true;

            while (continuar)
            {
                MostrarMenuBloque5();

                try
                {
                    opcion = int.Parse(Console.ReadLine());
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
                        Console.WriteLine("\n  --- MATRIZ DE NOTAS POR EXAMEN ---");
                        MatrizNParcial matriz = new MatrizNParcial();
                        matriz.Ejecutar();
                        break;
                    case 2:
                        Console.WriteLine("\n  --- JUEGO TIC-TAC-TOE ---");
                        TicTacToe juego = new TicTacToe();
                        juego.Ejecutar();
                        break;
                    case 3:
                        Console.WriteLine("\n  --- INVENTARIO SIMPLE ---");
                        InventSimple inventario = new InventSimple();
                        inventario.Ejecutar();
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
                    case 3:
                        programa.EjecutarBloque3();
                        break;
                    case 4:
                        programa.EjecutarBloque4();
                        break;
                    case 5:
                        programa.EjecutarBloque5();
                        break;
                    case 0:
                        Console.WriteLine("\n  Programa terminado.");
                        break;
                    default:
                        Console.WriteLine("\n  Opción no válida. Ingrese un número del 0 al 5.\n");
                        break;
                }

            } while (opcion != 0);
        }
    }
}
