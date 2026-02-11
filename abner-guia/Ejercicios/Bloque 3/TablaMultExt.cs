using System;

namespace poo_guia_1_abnerP.Ejercicios.Bloque3
{
    // clase para mostrar tablas de multiplicar extendidas
    public class TablaMultExt
    {
        // solicita un numero y muestra su tabla del 1 al 12
        public void MostrarTabla()
        {
            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("\n TABLA DE MULTIPLICAR DEL " + numero );

            // muestra la tabla del 1 al 12 con formato alineado
            for (int i = 1; i <= 12; i++)
            {
                int resultado = numero * i;
                Console.WriteLine("  " + numero + " x " + i + " = " + resultado);
            }
        }

        // metodo de entrada
        public void Ejecutar()
        {
            MostrarTabla();
        }
    }
}