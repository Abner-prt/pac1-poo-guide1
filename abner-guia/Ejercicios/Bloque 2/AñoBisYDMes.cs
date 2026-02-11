using System;

namespace poo_guia_1_abnerP.Ejercicios.Bloque2
{
    public class AñoBisYDMes
    {
        // solicita el año y mes al usuario
        public void SolicitarDatos()
        {
            Console.Write("Ingrese el año: ");
            int año = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el mes (1-12): ");
            int mes = int.Parse(Console.ReadLine());

            // valida que el mes este en rango
            if (mes < 1 || mes > 12)
            {
                Console.WriteLine("El mes debe estar entre 1 y 12.");
                return;
            }

            // determina si el año es bisiesto
            bool esBisiesto = EsAñoBisiesto(año);
            Console.WriteLine("\n RESULTADO ");
            Console.WriteLine("Año: " + año);

            if (esBisiesto)
            {
                Console.WriteLine("El año " + año + " ES bisiesto.");
            }
            else
            {
                Console.WriteLine("El año " + año + " NO es bisiesto.");
            }

            // obtiene y muestra los dias del mes
            int dias = ObtenerDiasDelMes(mes, esBisiesto);
            string nombreMes = ObtenerNombreMes(mes);
            Console.WriteLine("Mes: " + nombreMes);
            Console.WriteLine("Dias del mes: " + dias);
        }

        // determina si un año es bisiesto
        // regla gugleada :D : divisible por 4, pero no por 100, excepto si es divisible por 400
        public bool EsAñoBisiesto(int año)
        {
            return (año % 400 == 0) || (año % 4 == 0 && año % 100 != 0);
        }

        // obtiene el numero de dias de un mes segun la cantidad de dias que tenga el mes
        public int ObtenerDiasDelMes(int mes, bool esBisiesto)
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

        // obtiene el nombre del mes, descinicido por si se ingresa un valor que no concuerde con los dias del mes
        public string ObtenerNombreMes(int mes)
        {
            switch (mes)
            {
                case 1: return "Enero";
                case 2: return "Febrero";
                case 3: return "Marzo";
                case 4: return "Abril";
                case 5: return "Mayo";
                case 6: return "Junio";
                case 7: return "Julio";
                case 8: return "Agosto";
                case 9: return "Septiembre";
                case 10: return "Octubre";
                case 11: return "Noviembre";
                case 12: return "Diciembre";
                default: return "Desconocido";
            }
        }

        public void Ejecutar()
        {
            SolicitarDatos();
        }
    }
}
