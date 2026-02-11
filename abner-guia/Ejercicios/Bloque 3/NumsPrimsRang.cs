using System;

namespace poo_guia_1_abnerP.Ejercicios.Bloque3
{
    public class NumsPrimsRang
    {
        // solicita el rango de números al usuario
        public void SolicitarRango()
        {
            Console.Write("Ingrese el número inicial del rango: ");
            int inicio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número final del rango: ");
            int fin = int.Parse(Console.ReadLine());

            // valida que el rango sea válido
            if (inicio > fin)
            {
                Console.WriteLine("El número inicial no puede ser mayor al final.");
                return;
            }

            FindearPrimos(inicio, fin);
        }

        // determina si un número es primo
        public bool EsPrimo(int numero)
        {
            // los números menores a 2 no son primos
            if (numero < 2)
            {
                return false;
            }

            // verifica divisores desde 2 hasta la raíz cuadrada del número
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        // encuentra y muestra todos los primos en el rango
        public void FindearPrimos(int inicio, int fin)
        {
            List<int> primos = new List<int>();

            for (int i = inicio; i <= fin; i++)
            {
                if (EsPrimo(i))
                {
                    primos.Add(i);
                }
            }

            // muestra los resultados, recorre el bloque primos.Count y determina
            // la cantidad de numeros primos que hay
            Console.WriteLine("\n NÚMEROS PRIMOS EN EL RANGO " + inicio + " A " + fin );

            if (primos.Count > 0)
            {
                Console.Write("Números primos: ");
                for (int i = 0; i < primos.Count; i++)
                {
                    Console.Write(primos[i]);
                    if (i < primos.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Cantidad de primos: " + primos.Count);
            }
            else
            {
                Console.WriteLine("No hay números primos en este rango.");
            }
        }

        // ejecutaR
        public void Ejecutar()
        {
            SolicitarRango();
        }
    }
}
