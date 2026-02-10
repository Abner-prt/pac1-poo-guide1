using System;

namespace poo_guia_1_abnerP.Ejercicios.Bloque1
{

    public class CalcSemSalary
    {
        public const int HORAS_REGULARES = 44;
        public const double FACTOR_HORA_EXTRA = 1.5;

        // Variables para almacenar los datos
        public double horasTrabajo;
        public double tarifaHora;
        public double horasExtras;
        public double salarioRegular;
        public double salarioHorasExtras;
        public double salarioTotal;

        // Solicita los datos de horas trabajadas y tarifa por hora
        public void SolicitarDatos()
        {
            Console.Write("Ingrese las horas trabajadas en la semana: ");
            horasTrabajo = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la tarifa por hora: ");
            tarifaHora = double.Parse(Console.ReadLine());
        }

        // Calcula el salario semanal incluyendo horas extras,Las primeras 44 horas se pagan normal,
        // las horas adicionales se pagan al 150% (1.5x)
        public void CalcularSalario()
        {
            // aqui deetermina si hay horas extras
            if (horasTrabajo > HORAS_REGULARES)
            {
                horasExtras = horasTrabajo - HORAS_REGULARES;
                horasTrabajo = HORAS_REGULARES; // Las primeras 44 horas son regulares
            }
            else
            {
                horasExtras = 0;
            }

            // se calcula el salario regular
            salarioRegular = horasTrabajo * tarifaHora;

            // secalcula el salario de horas extras 150% = 1.5x
            salarioHorasExtras = horasExtras * tarifaHora * FACTOR_HORA_EXTRA;

            // se calcula el salario total
            salarioTotal = salarioRegular + salarioHorasExtras;
        }

        // muestra el desglose del salario y el total
        public void MostrarResultado()
        {
            Console.WriteLine("\n--- DESGLOSE DE SALARIO SEMANAL ---");

            if (horasExtras > 0)
            {
                Console.WriteLine("Horas regulares: " + HORAS_REGULARES);
                Console.WriteLine("Horas extras: " + horasExtras);
                Console.WriteLine("Tarifa por hora: " + tarifaHora);
                Console.WriteLine("Salario horas regulares: " + salarioRegular);
                Console.WriteLine("Salario horas extras (150%): " + salarioHorasExtras);
            }
            else
            {
                Console.WriteLine("Horas trabajadas: " + horasTrabajo);
                Console.WriteLine("Tarifa por hora: " + tarifaHora);
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("SALARIO TOTAL: " + salarioTotal);
        }

        // Ejecuta el proceso completo del calculo de salario
        public void Ejecutar()
        {
            SolicitarDatos();
            CalcularSalario();
            MostrarResultado();
        }
    }
}
