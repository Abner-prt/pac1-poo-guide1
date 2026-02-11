using System;

namespace poo_guia_1_abnerP.Ejercicios.Bloque3
{
    public class SerieFibo
    {
        // solicita la cantidad de términos de Fibonacci
        public void SolicitarNumeroTerminos()
        {
            Console.Write("Ingrese la cantidad de términos de Fibonacci: ");
            int n = int.Parse(Console.ReadLine());

            // valida que sea un número positivo
            if (n <= 0)
            {
                Console.WriteLine("Debe ingresar un número mayor a 0.");
                return;
            }

            GenerarFibonacci(n);
        }

        // genera la secuencia de Fibonacci usando List y variables en double
        public void GenerarFibonacci(int n)
        {
            List<double> fibonacci = new List<double>();

            // los dos primeros términos son 0 y 1
            double a = 0;
            double b = 1;

            for (int i = 0; i < n; i++)
            {
                fibonacci.Add(a);

                // calcula el siguiente término
                double siguiente = a + b;
                a = b;
                b = siguiente;
            }

            // calcula la suma y el promedio
            double suma = fibonacci.Sum();
            double promedio = suma / n;

            // muestra los resultados usando el ciclo for para recorrer fibonacci.Count y
            // mostrarlos en pantalla en terminal
            Console.WriteLine("\n SECUENCIA DE FIBONACCI (Primeros " + n + " términos) ");

            Console.Write("Secuencia: ");
            for (int i = 0; i < fibonacci.Count; i++)
            {
                Console.Write(fibonacci[i]);
                if (i < fibonacci.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Suma total: " + suma);
            Console.WriteLine("Promedio: " + promedio);
        }

        // ejeeec
        public void Ejecutar()
        {
            SolicitarNumeroTerminos();
        }
    }
}
