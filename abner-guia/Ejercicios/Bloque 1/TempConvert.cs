using System;

namespace poo_guia_1_abnerP.Ejercicios.Bloque1
{
    /// temp unit class
    public class Temperatura
    {
        public double valor;
        public string unidad;

        // metodo constructor para iniciar la temp
        public Temperatura(double valor, string unidad)
        {
            this.valor = valor;
            this.unidad = unidad;
        }

        // encapsulasaoooOoo
        public double GetValor()
        {
            return valor;
        }

        public void SetValor(double valor)
        {
            this.valor = valor;
        }

        public string GetUnidad()
        {
            return unidad;
        }

        public void SetUnidad(string unidad)
        {
            this.unidad = unidad;
        }

        // Method to display temperature information
        public void MostrarInformacion()
        {
            Console.WriteLine("Temperatura: -valor- , -unidad-");
        }
    }

    /// clase para las temps y forms
    public class TempConvert
    {
        // constantes de las formulas
        public const double CELSIUS_A_FAHRENHEIT = 1.8;
        public const double CELSIUS_A_KELVIN = 273.15;
        public const double DIFERENCIA_FAHRENHEIT = 32;

        /// C a f
        public double CelsiusAFahrenheit(double celsius)
        {
            return (celsius * CELSIUS_A_FAHRENHEIT) + DIFERENCIA_FAHRENHEIT;
        }

  // f a C
        public double FahrenheitACelsius(double fahrenheit)
        {
            return (fahrenheit - DIFERENCIA_FAHRENHEIT) / CELSIUS_A_FAHRENHEIT;
        }

        // C a k
        public double CelsiusAKelvin(double celsius)
        {
            return celsius + CELSIUS_A_KELVIN;
        }

        // k a C
        public double KelvinACelsius(double kelvin)
        {
            return kelvin - CELSIUS_A_KELVIN;
        }

        // f a k
        public double FahrenheitAKelvin(double fahrenheit)
        {
            double celsius = FahrenheitACelsius(fahrenheit);
            return CelsiusAKelvin(celsius);
        }

        // k a f
        public double KelvinAFahrenheit(double kelvin)
        {
            double celsius = KelvinACelsius(kelvin);
            return CelsiusAFahrenheit(celsius);
        }

        // mini menu
        public void MostrarMenu()
        {
            Console.WriteLine("      CONVERTIDOR DE TEMPERATURA      ");
            Console.WriteLine("  1. Celsius    -> Fahrenheit");
            Console.WriteLine("  2. Fahrenheit -> Celsius");
            Console.WriteLine("  3. Celsius    -> Kelvin");
            Console.WriteLine("  4. Kelvin     -> Celsius");
            Console.WriteLine("  5. Fahrenheit -> Kelvin");
            Console.WriteLine("  6. Kelvin     -> Fahrenheit");
            Console.WriteLine("  0. Salir");
            Console.Write("  Ingrese su opción: ");
        }

        // valida un valor que no sea nulo para la tem´p
        public double ObtenerTemperatura(string mensaje)
        {
            double temperatura = 0;
            bool entradaValida = false;

            do
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();
                try
                {
                    temperatura = double.Parse(entrada);
                    entradaValida = true;
                }
                catch
                {
                    Console.WriteLine("Por favor ingrese un número válido.");
                    entradaValida = false;
                }
            } while (!entradaValida);

            return temperatura;
        }

        public int ObtenerOpcion()
        {
            int opcion = 0;
            bool opcionValida = false;

            do
            {
                string entrada = Console.ReadLine();
                try
                {
                    opcion = int.Parse(entrada);
                    opcionValida = true;
                }
                catch
                {
                    Console.WriteLine("\n Por favor ingrese un número del 0 al 6.");
                    Console.Write("  Ingrese su opción: ");
                    opcionValida = false;
                }
            } while (!opcionValida);

            return opcion;
        }

        public void Continuar()
        {
            Console.WriteLine("\n  Presione Enter para continuar...");
            Console.ReadLine();
        }

        
        public void Ejecutar()
        {
            int opcion;
            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();
                
                // lee la opcion q eligio el user
                opcion = ObtenerOpcion();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("\n  Prorama terminado");
                        continuar = false;
                        break;

                    case 1:
                        double celsius = ObtenerTemperatura("  Ingrese la temperatura en Celsius: ");
                        double fahrenheit = CelsiusAFahrenheit(celsius);
                        Console.WriteLine("\n  Resultado: " + celsius + " °C = " + fahrenheit + " °F");
                        break;

                    case 2:
                        double fahrInput = ObtenerTemperatura("  Ingrese la temperatura en Fahrenheit: ");
                        double celsiusResult = FahrenheitACelsius(fahrInput);
                        Console.WriteLine("\n  Resultado: " + fahrInput + " °F = " + celsiusResult + " °C");
                        break;

                    case 3:
                        double celsiusKelvin = ObtenerTemperatura("  Ingrese la temperatura en Celsius: ");
                        double kelvin = CelsiusAKelvin(celsiusKelvin);
                        Console.WriteLine("\n  Resultado: " + celsiusKelvin + " °C = " + kelvin + " K");
                        break;

                    case 4:
                        double kelvinInput = ObtenerTemperatura("  Ingrese la temperatura en Kelvin: ");
                        double celsiusFromKelvin = KelvinACelsius(kelvinInput);
                        Console.WriteLine("\n  Resultado: " + kelvinInput + " K = " + celsiusFromKelvin + " °C");
                        break;

                    case 5:
                        double fahrToKelvin = ObtenerTemperatura("  Ingrese la temperatura en Fahrenheit: ");
                        double kelvinFromFahr = FahrenheitAKelvin(fahrToKelvin);
                        Console.WriteLine("\n  Resultado: " + fahrToKelvin + " °F = " + kelvinFromFahr + " K");
                        break;

                    case 6:
                        double kelvinToFahr = ObtenerTemperatura("  Ingrese la temperatura en Kelvin: ");
                        double fahrenheitFromKelvin = KelvinAFahrenheit(kelvinToFahr);
                        Console.WriteLine("\n  Resultado: " + kelvinToFahr + " K = " + fahrenheitFromKelvin + " °F");
                        break;

                    default:
                        Console.WriteLine("\n Opción no válida. Ingrese un número del 0 al 6.");
                        break;
                }

                // pausa antes de volver a mostratr el menu
                if (continuar)
                {
                    Continuar();
                }
            }
        }
    }
}
