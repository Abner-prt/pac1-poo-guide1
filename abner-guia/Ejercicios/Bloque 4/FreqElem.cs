using System;

namespace poo_guia_1_abnerP.Ejercicios.Bloque4
{
    public class FreqElemen
    {
        // aqui el arreglo para los 20 numeros aleatorios
        public int[] numeros;
        // y aqui el arreglo para contar frecuencias con indices 1-10
        public int[] frecuencias;
        public Random random;

        public FreqElemen()
        {
            numeros = new int[20];
            frecuencias = new int[11];  // indices 0-10, use 1-10
            random = new Random();
        }

        // se genera 20 numeros aleatorios entre 1 y 10
        public void GenerarNumeros()
        {
            Console.WriteLine("Generando 20 numeros aleatorios (1-10)...\n");

            for (int i = 0; i < 20; i++)
            {
                // random.Next1, 11 genera numeros de 1 a 10
                numeros[i] = random.Next(1, 11);
            }

            // muestra los numeros generados
            Console.WriteLine("Numeros generados:");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(numeros[i]);
                if (i < 19)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        // cuenta cuantas veces aparece cada numero
        public void ContarFrecuencias()
        {
            // reinicia el contador
            for (int i = 0; i < 11; i++)
            {
                frecuencias[i] = 0;
            }

            // se cuenta cada numero
            for (int i = 0; i < 20; i++)
            {
                int numero = numeros[i];
                frecuencias[numero]++;
            }
        }

        // muestra la frecuencia de cada numero del 1 al 10
        public void MostrarFrecuencias()
        {
            Console.WriteLine("\n FRECUENCIA DE CADA NUMERO ");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Numero " + i + ": " + frecuencias[i] + " veces");
            }
        }

        // encuentra el numero mas frecuente
        public void EncontrarMasFreq()
        {
            int maxFrecuencia = 0;
            int numeroMasFrecuente = 1;

            for (int i = 1; i <= 10; i++)
            {
                if (frecuencias[i] > maxFrecuencia)
                {
                    maxFrecuencia = frecuencias[i];
                    numeroMasFrecuente = i;
                }
            }

            Console.WriteLine("\nMas frecuente: " + numeroMasFrecuente + " (aparece " + maxFrecuencia + " veces)");
        }

        // encuentra el numero menos frecuente
        public void EncontrarMenFreq()
        {
            int minFrecuencia = 21;  // empezamos con un valor alto
            int numeroMenosFrecuente = 1;

            for (int i = 1; i <= 10; i++)
            {
                if (frecuencias[i] < minFrecuencia)
                {
                    minFrecuencia = frecuencias[i];
                    numeroMenosFrecuente = i;
                }
            }

            Console.WriteLine("Menos frecuente: " + numeroMenosFrecuente + " (aparece " + minFrecuencia + " veces)");
        }

        // muestra una grafica simple de barras
        public void MostrarGrafica()
        {
            Console.WriteLine("\n GRAFICA DE FRECUENCIAS ");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + ": ");
                for (int j = 0; j < frecuencias[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" (" + frecuencias[i] + ")");
            }
        }

        // inicia el programa completo
        public void Ejecutar()
        {
            // para generar los numeros aleatorios
            GenerarNumeros();

            // para contar las frecuencias
            ContarFrecuencias();

            // para mostrar los resultados
            MostrarFrecuencias();
            EncontrarMasFreq();
            EncontrarMenFreq();
            MostrarGrafica();
        }
    }
}
