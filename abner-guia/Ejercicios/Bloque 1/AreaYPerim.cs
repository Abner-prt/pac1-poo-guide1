using System;

namespace poo_guia_1_abnerP.Ejercicios.Bloque1
{
    public class AreaYPerim
    {
        // Solicita un valor positivo al usuario
        public double ObtenerPositivo(string mensaje)
        {
            double valor = 0;
            bool valido = false;

            do
            {
                Console.Write(mensaje);
                try
                {
                    valor = double.Parse(Console.ReadLine());
                    if (valor > 0)
                    {
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("  El valor debe ser positivo. Intente de nuevo.");
                    }
                }
                catch
                {
                    Console.WriteLine("  Por favor ingrese un número válido.");
                }
            } while (!valido);

            return valor;
        }

        // Muestra el menu de opciones para figuras
        public void MostrarMenuFiguras()
        {
            Console.WriteLine("      SELECCIONE UNA FIGURA      ");
            Console.WriteLine("  1. Circulo");
            Console.WriteLine("  2. Triangulo");
            Console.WriteLine("  3. Rectangulo");
            Console.WriteLine("  4. Trapecio");
            Console.WriteLine("  0. Volver al menu principal");
            Console.Write("  Ingrese su opción: ");
        }

        // formulas area y perimetro circulo
        // area = pi * r^2
        // perimetro = 2 * pi * r
        public void CalcularCirculo()
        {
            Console.WriteLine("\n CIRCULO ");
            double radio = ObtenerPositivo("  Ingrese el radio: ");

            double area = Math.PI * Math.Pow(radio, 2);
            double perimetro = 2 * Math.PI * radio;

            Console.WriteLine("  Area: " + area);
            Console.WriteLine("  Perimetro: " + perimetro);
        }

        // formulas area y perimetro triangulo
        // area = (base * altura) / 2
        // perimetro = lado1 + lado2 + base
        public void CalcularTriangulo()
        {
            Console.WriteLine("\n TRIANGULO ");
            double baseTriangulo = ObtenerPositivo("  Ingrese la base: ");
            double altura = ObtenerPositivo("  Ingrese la altura: ");
            double lado1 = ObtenerPositivo("  Ingrese el lado 1: ");
            double lado2 = ObtenerPositivo("  Ingrese el lado 2: ");

            double area = (baseTriangulo * altura) / 2;
            double perimetro = baseTriangulo + lado1 + lado2;

            Console.WriteLine("  Area: " + area);
            Console.WriteLine("  Perimetro: " + perimetro);
        }

        // formulas area y perimetro rectang
        // area = base * altura
        // perimetro = 2 * (base + altura)
        public void CalcularRectangulo()
        {
            Console.WriteLine("\n RECTANGULO ");
            double baseRect = ObtenerPositivo("  Ingrese la base: ");
            double altura = ObtenerPositivo("  Ingrese la altura: ");

            double area = baseRect * altura;
            double perimetro = 2 * (baseRect + altura);

            Console.WriteLine("  Area: " + area);
            Console.WriteLine("  Perimetro: " + perimetro);
        }

        // formulas area y perimetro trapc
        // Aaea = ((base1 + base2) / 2) * altura
        // perimetro = base1 + base2 + lado1 + lado2
        public void CalcularTrapecio()
        {
            Console.WriteLine("\n TRAPECIO ");
            double base1 = ObtenerPositivo("  Ingrese la base mayor: ");
            double base2 = ObtenerPositivo("  Ingrese la base menor: ");
            double altura = ObtenerPositivo("  Ingrese la altura: ");
            double lado1 = ObtenerPositivo("  Ingrese el lado 1: ");
            double lado2 = ObtenerPositivo("  Ingrese el lado 2: ");

            double area = ((base1 + base2) / 2) * altura;
            double perimetro = base1 + base2 + lado1 + lado2;

            Console.WriteLine("  Area: " + area);
            Console.WriteLine("  Perimetro: " + perimetro);
        }

        // Ejecuta el menu de calculo de areas y perimetros
        public void Ejecutar()
        {
            int opcion;
            bool continuar = true;

            while (continuar)
            {
                MostrarMenuFiguras();

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
                        CalcularCirculo();
                        break;
                    case 2:
                        CalcularTriangulo();
                        break;
                    case 3:
                        CalcularRectangulo();
                        break;
                    case 4:
                        CalcularTrapecio();
                        break;
                    default:
                        Console.WriteLine("\n  Opción no válida. Ingrese un número del 0 al 4.\n");
                        break;
                }

                if (continuar && opcion >= 1 && opcion <= 4)
                {
                    Console.WriteLine("\n  Presione Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }
    }
}
