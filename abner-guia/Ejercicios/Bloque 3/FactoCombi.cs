using System;

namespace poo_guia_1_abnerP.Ejercicios.Bloque3
{
    public class FactoCombi
    {
        // Solicita el numero para calcular el factorial
        public void SolicitarDatos()
        {
            Console.Write("Ingrese el número para calcular Factorial: ");
            int n = int.Parse(Console.ReadLine());

            // Valida que n sea positivo
            if (n <= 0)
            {
                Console.WriteLine("Debe ingresar un número mayor a 0.");
                return;
            }

            // Calcula y muestra el factorial
            long factorial = CalcularFacto(n);
            Console.WriteLine("\nEl factorial de " + n + " es: " + factorial);

            // Solicita datos para combinaciones
            Console.Write("\nIngrese el valor de n para combinaciones: ");
            int nComb = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de r para combinaciones: ");
            int rComb = int.Parse(Console.ReadLine());

            // Valida que r no sea mayor a n
            if (rComb > nComb)
            {
                Console.WriteLine("r no puede ser mayor que n.");
                return;
            }

            // Calcula y muestra la combinación
            long combinacion = CalcularCombi(nComb, rComb);
            Console.WriteLine("\nC(" + nComb + ", " + rComb + ") = " + combinacion);
        }

        // Calcula el factorial de un número
        public long CalcularFacto(int n)
        {
            long factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        // Calcula la combinación C(n,r) = n! / (r! * (n-r)!)
        public long CalcularCombi(int n, int r)
        {
            long factorialN = CalcularFacto(n);
            long factorialR = CalcularFacto(r);
            long factorialNR = CalcularFacto(n - r);

            return factorialN / (factorialR * factorialNR);
        }
        public void Ejecutar()
        {
            SolicitarDatos();
        }
    }
}
