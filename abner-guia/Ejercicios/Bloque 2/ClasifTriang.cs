using System;

namespace poo_guia_1_abnerP.Ejercicios.Bloque2
{
    public class ClasifTriang
    {
        // metodo para solicitar los tres lados del triangulo al usuario
        public void SolicitarLados()
        {
            Console.WriteLine("Ingrese los tres lados del triangulo:");

            Console.Write("  Lado 1: ");
            double lado1 = double.Parse(Console.ReadLine());

            Console.Write("  Lado 2: ");
            double lado2 = double.Parse(Console.ReadLine());

            Console.Write("  Lado 3: ");
            double lado3 = double.Parse(Console.ReadLine());

            // Llama al metodo para clasificar el triangulo
            ClasificarTriangulo(lado1, lado2, lado3);
        }

        // metodo principal que coordina la clasificacion
        public void ClasificarTriangulo(double a, double b, double c)
        {
            Console.WriteLine("\n--- CLASIFICACION DEL TRIANGULO ---");
            Console.WriteLine("Lados: " + a + ", " + b + ", " + c);

            // Primero valida si los lados forman un triangulo valido
            if (!EsTrianguloValido(a, b, c))
            {
                Console.WriteLine("  Estos lados no forman un triangulo valido.");
                Console.WriteLine("  La suma de cualquier dos lados debe ser mayor al tercer lado.");
                return;
            }

            // clasifica por lados y muestra el resultado
            string tipoPorLados = ClasificarPorLados(a, b, c);
            Console.WriteLine("  Tipo por lados: " + tipoPorLados);

            // clasifica por angulos y muestra el resultado
            string tipoPorAngulos = ClasificarPorAngulos(a, b, c);
            Console.WriteLine("  Tipo por angulos: " + tipoPorAngulos);
        }

        // valida si los tres lados pueden formar un triangulo
        // Teorema de desigualdad del triangulo: a + b > c, a + c > b, b + c > a
        public bool EsTrianguloValido(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        // clasifica el triangulo segun sus lados
        // equilatero: todos los lados iguales
        // isosceles: exactamente dos lados iguales
        // escaleno: todos los lados diferentes
        public string ClasificarPorLados(double a, double b, double c)
        {
            if (a == b && b == c)
                return "Equilatero";
            else if (a == b || b == c || a == c)
                return "Isosceles";
            else
                return "Escaleno";
        }

        // clasifica el triangulo segun sus angulos usando el teorema del coseno
        // calcula cada angulo usando la ley de cosenos: c^2 = a^2 + b^2 - 2ab*cos(C)
        public string ClasificarPorAngulos(double a, double b, double c)
        {
            // calcula el angulo opuesto al lado a
            double anguloA = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * (180 / Math.PI);
            // calcula el angulo opuesto al lado b
            double anguloB = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * (180 / Math.PI);
            // el tercer angulo es 180 menos la suma de los otros dos
            double anguloC = 180 - anguloA - anguloB;

            // muestra los tres angulos calculados
            Console.WriteLine("  Angulos: " + Math.Round(anguloA, 2) + "°, " +
                            Math.Round(anguloB, 2) + "°, " +
                            Math.Round(anguloC, 2) + "°");

            // Determina el angulo mayor para clasificar el triangulo
            double mayor = Math.Max(Math.Max(anguloA, anguloB), anguloC);

            // segun el angulo mayor
            if (mayor < 90)
                return "Acutangulo";
            else if (mayor == 90)
                return "Rectangulo";
            else
                return "Obtusangulo";
        }

        public void Ejecutar()
        {
            SolicitarLados();
        }
    }
}
