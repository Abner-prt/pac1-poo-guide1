using System;

namespace poo_guia_1_abnerP.Ejercicios.Bloque2
{
    // clase para simular un cajero automatico
    public class CajeroAut
    {
        // saldo inicial del usuario
        public double saldoInicial;

        public CajeroAut()
        {
            // inicializa el saldo en x lempiras
            saldoInicial = 10000;
        }

        // metodo para realizar un retiro
        public void RealizarRetiro()
        {
            Console.WriteLine(" CAJERO AUTOMATICO ");
            Console.WriteLine("Saldo actual: " + saldoInicial + " lempiras");

            Console.Write("\nIngrese el monto a retirar: ");
            double monto = double.Parse(Console.ReadLine());

            // valida que el monto sea positivo
            if (monto <= 0)
            {
                Console.WriteLine("El monto debe ser mayor a 0.");
                return;
            }

            // valida que el monto sea multiplo de 20
            if (monto % 20 != 0)
            {
                Console.WriteLine("El monto debe ser multiplo de 20.");
                return;
            }

            // valida que no exceda el saldo
            if (monto > saldoInicial)
            {
                Console.WriteLine("El monto excede el saldo disponible.");
                return;
            }

            // desglosa los billetes
            DesglosarBilletes(monto);

            // actualiza el saldo
            saldoInicial -= monto;
            Console.WriteLine("\nNuevo saldo: " + saldoInicial + " lempiras");
        }

        // metodo para desglosar los billetes
        public void DesglosarBilletes(double monto)
        {
            int[] billetes = { 500, 100, 50, 20 }; // billetes disponibles
            double montoRestante = monto;

            Console.WriteLine("\n BILLETES DISPENSADOS ");

            for (int i = 0; i < billetes.Length; i++)
            {
                int cantidad = (int)(montoRestante / billetes[i]);
                if (cantidad > 0)
                {
                    Console.WriteLine("Billetes de " + billetes[i] + ": " + cantidad);
                    montoRestante %= billetes[i];
                }
            }

            Console.WriteLine("\nTotal retirado: " + monto + " lempiras");
        }

        // ejecuta
        public void Ejecutar()
        {
            RealizarRetiro();
        }
    }
}
