using System;

namespace poo_guia_1_abnerP.Ejercicios.Bloque2
{
    public class ValidFechas
    {
        // volicita dia, mes y año al usuario
        public void SolicitarFecha()
        {
            Console.Write("Ingrese el dia: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el mes (1-12): ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el año: ");
            int año = int.Parse(Console.ReadLine());

            // valida la fecha
            bool fechaValida = ValidarFecha(dia, mes, año);

            Console.WriteLine("\n RESULTADO ");
            Console.WriteLine("Fecha: " + dia + "/" + mes + "/" + año);

            if (fechaValida)
            {
                Console.WriteLine("La fecha ES valida.");
            }
            else
            {
                Console.WriteLine("La fecha NO es valida.");
            }
        }

        // valida si la fecha es real
        public bool ValidarFecha(int dia, int mes, int año)
        {
            // valida el mes
            if (mes < 1 || mes > 12)
            {
                return false;
            }

            // valida el año (positivo)
            if (año < 1)
            {
                return false;
            }

            // determina si es año bisiesto
            bool esBisiesto = EsAñoBisiesto(año);

            // obtiene el numero maximo de dias para ese mes
            int diasEnMes = ObtenerDiasEnMes(mes, esBisiesto);

            // valida que el dia este en el rango correcto
            if (dia < 1 || dia > diasEnMes)
            {
                return false;
            }

            return true;
        }

        // determina si un año es bisiesto
        public bool EsAñoBisiesto(int año)
        {
            return (año % 400 == 0) || (año % 4 == 0 && año % 100 != 0);
        }

        // obtiene el numero de dias de un mes
        public int ObtenerDiasEnMes(int mes, bool esBisiesto)
        {
            switch (mes)
            {
                case 1: return 31;
                case 2: return esBisiesto ? 29 : 28;
                case 3: return 31;
                case 4: return 30;
                case 5: return 31;
                case 6: return 30;
                case 7: return 31;
                case 8: return 31;
                case 9: return 30;
                case 10: return 31;
                case 11: return 30;
                case 12: return 31;
                default: return 0;
            }
        }

        // como siempre, se ejecuta
        public void Ejecutar()
        {
            SolicitarFecha();
        }
    }
}
