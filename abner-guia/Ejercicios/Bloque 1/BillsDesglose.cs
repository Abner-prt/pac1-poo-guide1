using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_guia_1_abnerP.Ejercicios.Bloque1
{
    public class BillsDesglose
    {
        public void DesglosarBilletes(int monto)
        {
            // areglo con las denominaciones de billetes disponibles de M a m
            int[] denominationes = { 500, 100, 50, 20, 10, 5, 2, 1 };
            
            Console.WriteLine("Desglose de " + monto + " lempiras:\n");  // Muestra el monto original a desglosar
            
            //decidi el for por mas facilidad, aqui recorre las denominationes para saber cuandos billetes se necesitan
            for (int i = 0; i < denominationes.Length; i++)
            {
                // Calcula la cantidad de billetes de la denomination
                int cantidad = monto / denominationes[i];
                
                // si es 0 se muestra el result
                if (cantidad > 0)
                {
                    Console.WriteLine("Billetes de " + denominationes[i] + ": " + cantidad);
                    // Usa el operador modulo para obtener el sobrante
                    monto %= denominationes[i];
                }
            }
        }
    }       //no hay nanda que 2 tutoriales, 4 cafés y casi 4 horas no consigan, lol
}
