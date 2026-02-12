using System;

namespace poo_guia_1_abnerP.Ejercicios.Bloque3
{
    public class AdiviGame
    {
        // Variables para estadísticas, despues de recordar que tambien existen las private JAJAJA
        private int numeroSecreto;
        private int intentos;
        private int intentosMax = 7;
        private List<int> intentosRe;
        private Random random;

        public AdiviGame()
        {
            random = new Random();
            intentosRe = new List<int>();
        }
        public void IniciarJuego()
        {
            // se genera un numero aleatorio entre 1 y 100
            numeroSecreto = random.Next(1, 101);
            intentos = 0;
            intentosRe.Clear();

            Console.WriteLine("\n--- JUEGO DE ADIVINANZA ---");
            Console.WriteLine("Adivina el número entre 1 y 100.");
            Console.WriteLine("Tienes " + intentosMax + " intentos.");
            Console.WriteLine("Buena suerte");

            // Bucle generl del juego segun intentos
            while (intentos < intentosMax)
            {
                intentos++;
                int guess = ObtenerIntento();

                // verifica si se acerto
                if (guess == numeroSecreto)
                {
                    Console.WriteLine("\n¡Felicidades. Adivinaste el número");
                    MostrarEstadisticas(true);
                    return;
                }

                // Guarda el intento para estadísticas
                intentosRe.Add(guess);

                // Da pistas
                if (guess < numeroSecreto)
                {
                    Console.WriteLine("  Pista: El numero es MAYOR que " + guess);
                }
                else
                {
                    Console.WriteLine("  Pista: El numero es MENOR que " + guess);
                }

                // muestra intentos restantes
                int restantes = intentosMax - intentos;
                if (restantes > 0)
                {
                    Console.WriteLine("  Intentos restantes: " + restantes);
                }
            }

            // Si se quedó sin intentos
            Console.WriteLine("\nSe acabaron los intentos");
            Console.WriteLine("El numero secreto era: " + numeroSecreto);
            MostrarEstadisticas(false);
        }

        // obtiene un intento válido del usuario
        public int ObtenerIntento()
        {
            int guess;
            bool valido = false;

            do
            {
                Console.Write("\nIntento #" + intentos + " - Ingresa tu número: ");
                string entrada = Console.ReadLine();

                try
                {
                    guess = int.Parse(entrada);

                    // Valida que esté en el rango 1-100
                    if (guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Ingresa un número entre 1 y 100.");
                    }
                    else
                    {
                        valido = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Ingresa un número válido.");
                    guess = 0;
                }
            } while (!valido);

            return guess;
        }

        // Muestra las estadisticas del juego
        public void MostrarEstadisticas(bool gano)
        {
            Console.WriteLine("\n ESTADÍSTICAS DEL JUEGO ");
            Console.WriteLine("Resultado: " + (gano ? "GANO" : "PERDIO"));
            Console.WriteLine("Intentos utilizados: " + intentos);
            Console.WriteLine("Numero secreto: " + numeroSecreto);

            if (intentosRe.Count > 0)
            {
                Console.Write("Tus intentos: ");
                for (int i = 0; i < intentosRe.Count; i++)
                {
                    Console.Write(intentosRe[i]);
                    if (i < intentosRe.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();

                // Muestra el intento más cercano
                int masCercano = ObtenerMasCercano();
                Console.WriteLine("Intento más cercano: " + masCercano + " (diferencia: " + Math.Abs(masCercano - numeroSecreto) + ")");
            }
        }

        // obtiene el intento más cercano al numero secreto
        public int ObtenerMasCercano()
        {
            if (intentosRe.Count == 0)
            {
                return 0;
            }

            int masCercano = intentosRe[0];
            int menorDif = Math.Abs(masCercano - numeroSecreto);

            for (int i = 1; i < intentosRe.Count; i++)
            {
                int diferencia = Math.Abs(intentosRe[i] - numeroSecreto);
                if (diferencia < menorDif)
                {
                    menorDif = diferencia;
                    masCercano = intentosRe[i];
                }
            }

            return masCercano;
        }
        public void Ejecutar()
        {
            IniciarJuego();
        }
    }
}
