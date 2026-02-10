using System;

namespace poo_guia_1_abnerP.Ejercicios.Bloque1
{
    /// Clase para calcular prestamos simples
    public class CalculadoraPSimple
    {
        // Variables para almacenar los datos del prestamo
        public double montoPrestamo;
        public double tasaInteresAnual;
        public int plazoMeses;
        public double interesTotal;
        public double pagoMensual;

        // Solicita los datos del prestamo al usuario
        public void SolicitarDatos()
        {
            Console.Write("Ingrese el monto del prestamo: ");
            montoPrestamo = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la tasa de interes anual (%): ");
            tasaInteresAnual = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el plazo en meses: ");
            plazoMeses = int.Parse(Console.ReadLine());
        }

        //formulas interes total y pago mensual
        // Interes Total = Principal * (Tasa/100) * (Meses/12)
        // pago Mensual = (Principal + Interes Total) / Meses
        public void CalcularPrestamo()
        {
            // Calcula el interes total usando interes simple
            interesTotal = montoPrestamo * (tasaInteresAnual / 100) * (plazoMeses / 12.0);

            // Calcula el pago mensual fijo (capital + intereses dividido entre meses)
            pagoMensual = (montoPrestamo + interesTotal) / plazoMeses;
        }

        // Muestra los resultados del calculo
        public void MostrarResultado()
        {
            Console.WriteLine("\n--- RESULTADO DEL PRESTAMO ---");
            Console.WriteLine("Monto del prestamo: " + montoPrestamo);
            Console.WriteLine("Tasa de interes anual: " + tasaInteresAnual + "%");
            Console.WriteLine("Plazo: " + plazoMeses + " meses");
            Console.WriteLine("Interes total: " + interesTotal);
            Console.WriteLine("Pago mensual fijo: " + pagoMensual);
            Console.WriteLine("Total a pagar: " + (montoPrestamo + interesTotal));
        }

        // Ejecuta el proceso completo de la calculadora de prestamo
        public void Ejecutar()
        {
            SolicitarDatos();
            CalcularPrestamo();
            MostrarResultado();
        }
    }
}
