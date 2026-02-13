using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_guia_1_abnerP.Ejercicios.Bloque3
{
    public class MenuCalcu
    {
        // Aqui guardamos el ultimo resultado para poder seguir operando
        public double ultimoResultado;
        public bool hayResultado;

        public MenuCalcu()
        {
            ultimoResultado = 0;
            hayResultado = false;
        }

        // Muestra el menu de operaciones
        public void MostrarMenu()
        {
            Console.WriteLine("\n      CALCULADORA      ");
            
            // Si ya tenemos un resultado previo, lo mostramos
            if (hayResultado)
            {
                Console.WriteLine("  Resultado actual: " + ultimoResultado);
            }
            
            Console.WriteLine("  1. Sumar");
            Console.WriteLine("  2. Restar");
            Console.WriteLine("  3. Multiplicar");
            Console.WriteLine("  4. Dividir");
            Console.WriteLine("  5. Potencia");
            Console.WriteLine("  6. Raiz Cuadrada");
            Console.WriteLine("  7. Porcentaje");
            Console.WriteLine("  8. Limpiar (nuevo calculo)");
            Console.WriteLine("  0. Salir");
            Console.Write("  Ingrese su opcion: ");
        }

        // Pide un numero al usuario
        public double ObtenerNumero(string mensaje)
        {
            Console.Write(mensaje);
            double numero = double.Parse(Console.ReadLine());
            return numero;
        }

        // SUMA: a + b
        public void Sumar()
        {
            double a, b;

            // Si ya hay resultado, lo usamos como primer numero
            if (hayResultado)
            {
                a = ultimoResultado;
                Console.WriteLine("Primer numero: " + a);
                b = ObtenerNumero("Ingrese el segundo numero: ");
            }
            else
            {
                a = ObtenerNumero("Ingrese el primer numero: ");
                b = ObtenerNumero("Ingrese el segundo numero: ");
            }

            ultimoResultado = a + b;
            hayResultado = true;
            Console.WriteLine("Resultado: " + ultimoResultado);
        }

        // RESTA: a - b
        public void Restar()
        {
            double a, b;

            if (hayResultado)
            {
                a = ultimoResultado;
                Console.WriteLine("Primer numero: " + a);
                b = ObtenerNumero("Ingrese el segundo numero: ");
            }
            else
            {
                a = ObtenerNumero("Ingrese el primer numero: ");
                b = ObtenerNumero("Ingrese el segundo numero: ");
            }

            ultimoResultado = a - b;
            hayResultado = true;
            Console.WriteLine("Resultado: " + ultimoResultado);
        }

        // MULTIPLICACION: a * b
        public void Multiplicar()
        {
            double a, b;

            if (hayResultado)
            {
                a = ultimoResultado;
                Console.WriteLine("Primer numero: " + a);
                b = ObtenerNumero("Ingrese el segundo numero: ");
            }
            else
            {
                a = ObtenerNumero("Ingrese el primer numero: ");
                b = ObtenerNumero("Ingrese el segundo numero: ");
            }

            ultimoResultado = a * b;
            hayResultado = true;
            Console.WriteLine("Resultado: " + ultimoResultado);
        }

        // DIVISION: a / b
        public void Dividir()
        {
            double a, b;

            if (hayResultado)
            {
                a = ultimoResultado;
                Console.WriteLine("Primer numero: " + a);
                b = ObtenerNumero("Ingrese el segundo numero: ");
            }
            else
            {
                a = ObtenerNumero("Ingrese el primer numero: ");
                b = ObtenerNumero("Ingrese el segundo numero: ");
            }

            // Verificamos que no se divida entre 0
            if (b == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre 0.");
                return;
            }

            ultimoResultado = a / b;
            hayResultado = true;
            Console.WriteLine("Resultado: " + ultimoResultado);
        }

        // POTENCIA: base ^ exponente
        public void Potencia()
        {
            double baseNum, exponente;

            if (hayResultado)
            {
                baseNum = ultimoResultado;
                Console.WriteLine("Base: " + baseNum);
                exponente = ObtenerNumero("Ingrese el exponente: ");
            }
            else
            {
                baseNum = ObtenerNumero("Ingrese la base: ");
                exponente = ObtenerNumero("Ingrese el exponente: ");
            }

            // Math.Pow calcula la potencia
            ultimoResultado = Math.Pow(baseNum, exponente);
            hayResultado = true;
            Console.WriteLine("Resultado: " + baseNum + " ^ " + exponente + " = " + ultimoResultado);
        }

        // RAIZ CUADRADA: sqrt(numero)
        public void RaizCuadrada()
        {
            double numero;

            if (hayResultado)
            {
                numero = ultimoResultado;
                Console.WriteLine("Numero: " + numero);
            }
            else
            {
                numero = ObtenerNumero("Ingrese el numero: ");
            }

            // No se puede sacar raiz de numero negativo
            if (numero < 0)
            {
                Console.WriteLine("Error: No se puede calcular raiz de numero negativo.");
                return;
            }

            // Math.Sqrt calcula la raiz cuadrada
            ultimoResultado = Math.Sqrt(numero);
            hayResultado = true;
            Console.WriteLine("Resultado: raiz de " + numero + " = " + ultimoResultado);
        }

        // PORCENTAJE: calcula el porcentaje de un numero
        // Ejemplo: 15% de 200 = 30
        public void Porcentaje()
        {
            double porcentaje, numero;

            if (hayResultado)
            {
                numero = ultimoResultado;
                Console.WriteLine("Numero: " + numero);
                porcentaje = ObtenerNumero("Ingrese el porcentaje a calcular: ");
            }
            else
            {
                numero = ObtenerNumero("Ingrese el numero: ");
                porcentaje = ObtenerNumero("Ingrese el porcentaje a calcular: ");
            }

            // Formula: (porcentaje / 100) * numero
            ultimoResultado = (porcentaje / 100) * numero;
            hayResultado = true;
            Console.WriteLine("Resultado: " + porcentaje + "% de " + numero + " = " + ultimoResultado);
        }

        // Limpia el resultado para empezar de nuevo
        public void Limpiar()
        {
            ultimoResultado = 0;
            hayResultado = false;
            Console.WriteLine("Calculadora limpiada. Listo para nuevo calculo.");
        }

        // Ejecuta la calculadora con el menu principal
        public void Ejecutar()
        {
            int opcion;
            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();

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
                        Console.WriteLine("\n  Saliendo de la calculadora...");
                        continuar = false;
                        break;
                    case 1:
                        Sumar();
                        break;
                    case 2:
                        Restar();
                        break;
                    case 3:
                        Multiplicar();
                        break;
                    case 4:
                        Dividir();
                        break;
                    case 5:
                        Potencia();
                        break;
                    case 6:
                        RaizCuadrada();
                        break;
                    case 7:
                        Porcentaje();
                        break;
                    case 8:
                        Limpiar();
                        break;
                    default:
                        Console.WriteLine("\n  Opcion no valida. Ingrese un numero del 0 al 8.\n");
                        break;
                }

                if (continuar && opcion >= 1 && opcion <= 7)
                {
                    Console.WriteLine("\n  Presione Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }
    }
}
