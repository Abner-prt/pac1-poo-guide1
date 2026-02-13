using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_guia_1_abnerP.Ejercicios.Bloque5
{
    public class TicTacToe
    {
        // el tablero de 3x3 donde jugamos
        public char[,] tablero;
        // marca quien esta jugando ahora: X o O
        public char jugadorActual;
        // cuantos movimientos se han hecho
        public int movimientos;
        // si el juego termino
        public bool juegoTerminado;

        public TicTacToe()
        {
            tablero = new char[3, 3];
            InizTablero();
        }

        // preparamos el tablero para empezar
        public void InizTablero()
        {
            // llenamos el tablero con espacios vacios
            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    tablero[fila, col] = ' ';
                }
            }
            jugadorActual = 'X';  // siempre empieza X
            movimientos = 0;
            juegoTerminado = false;
        }

        // mostramos el tablero en pantalla de terminal
        public void MostrarTablero()
        {
            Console.WriteLine("\n     0   1   2");
            Console.WriteLine("   +---+---+---+");
            
            for (int fila = 0; fila < 3; fila++)
            {
                Console.Write(" " + fila + " |");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(" " + tablero[fila, col] + " |");
                }
                Console.WriteLine();
                Console.WriteLine("   +---+---+---+");
            }
        }

        // pedimos al jugador que haga su movimiento
        public void doesMovimiento()
        {
            int fila, columna;
            bool movimientoValido = false;

            Console.WriteLine("\nTurno del jugador " + jugadorActual);

            while (!movimientoValido)
            {
                // pedimos la fila
                Console.Write("Ingrese fila (0-2): ");
                fila = int.Parse(Console.ReadLine());

                // pedimos la columna
                Console.Write("Ingrese columna (0-2): ");
                columna = int.Parse(Console.ReadLine());

                // verificamos que las coordenadas esten en el rango
                if (fila < 0 || fila > 2 || columna < 0 || columna > 2)
                {
                    Console.WriteLine("Posicion invalida. Use numeros del 0 al 2.");
                    continue;
                }

                // verificamos que la casilla este vacia
                if (tablero[fila, columna] != ' ')
                {
                    Console.WriteLine("Esa casilla ya esta ocupada. Elija otra.");
                    continue;
                }

                // si llegamos aqui, el movimiento es valido
                tablero[fila, columna] = jugadorActual;
                movimientos++;
                movimientoValido = true;
            }
        }

        // verificamos si alguien gano
        public bool VerificarGanador()
        {
            // revisamos las filas
            for (int fila = 0; fila < 3; fila++)
            {
                if (tablero[fila, 0] == jugadorActual &&
                    tablero[fila, 1] == jugadorActual &&
                    tablero[fila, 2] == jugadorActual)
                {
                    return true;
                }
            }

            // revisamos las columnas
            for (int col = 0; col < 3; col++)
            {
                if (tablero[0, col] == jugadorActual &&
                    tablero[1, col] == jugadorActual &&
                    tablero[2, col] == jugadorActual)
                {
                    return true;
                }
            }

            // revisamos la diagonal principal esquina sup-izq a inf-der
            if (tablero[0, 0] == jugadorActual &&
                tablero[1, 1] == jugadorActual &&
                tablero[2, 2] == jugadorActual)
            {
                return true;
            }

            // revisamos la diagonal secundaria esquina sup-der a inf-izq
            if (tablero[0, 2] == jugadorActual &&
                tablero[1, 1] == jugadorActual &&
                tablero[2, 0] == jugadorActual)
            {
                return true;
            }

            return false;
        }

        // verificamos si es empate
        public bool VerifEmpate()
        {
            // si ya se hicieron 9 movimientos y nadie gano, es empate
            return movimientos == 9;
        }

        // cambiamos al siguiente jugador
        public void CambiarJugador()
        {
            if (jugadorActual == 'X')
            {
                jugadorActual = 'O';
            }
            else
            {
                jugadorActual = 'X';
            }
        }

        // preguntamos si quieren jugar de nuevo
        public bool JugarDeNuevo()
        {
            Console.Write("\nQuieren jugar de nuevo? (s/n): ");
            string respuesta = Console.ReadLine();

            if (respuesta == "s" || respuesta == "S")
            {
                InizTablero();
                return true;
            }
            return false;
        }

        // ejecutamos el juego completo
        public void Ejecutar()
        {
            Console.WriteLine("\n JUEGO DE TIC TAC TOE ");
            Console.WriteLine("Jugador 1: X");
            Console.WriteLine("Jugador 2: O");
            Console.WriteLine("Para jugar, ingrese fila y columna (0-2)");

            bool seguirJugando = true;

            while (seguirJugando)
            {
                // mostramos el tablero
                MostrarTablero();

                // el jugador actual hace su movimiento
                doesMovimiento();

                // verificamos si gano
                if (VerificarGanador())
                {
                    MostrarTablero();
                    Console.WriteLine("\n¡FELICIDADES! El jugador " + jugadorActual + " ha ganado!");
                    juegoTerminado = true;
                }
                // verificamos si es empate
                else if (VerifEmpate())
                {
                    MostrarTablero();
                    Console.WriteLine("\n¡ES UN EMPATE! Nadie gano.");
                    juegoTerminado = true;
                }

                // si el juego termino, preguntamos si quieren seguir
                if (juegoTerminado)
                {
                    seguirJugando = JugarDeNuevo();
                }
                else
                {
                    // cambiamos al otro jugador
                    CambiarJugador();
                }
            }

            Console.WriteLine("\nGracias por jugar!");
        }
    }
}
