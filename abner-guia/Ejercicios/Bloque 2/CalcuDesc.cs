using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_guia_1_abnerP.Ejercicios.Bloque2
{
 
    public class CalcuDesc
    {
        // variables
        public double montoCompra;
        public double descuento;
        public double precioFinal;
        public string rango;

        /**
         * metodo principal que coordina toda la ejecución del programa
         * ss el punto de entrada público para usar esta clase
         */
        public void Ejecutar()
        {
            Console.WriteLine(" CALCULADORA DE DESCUENTOS ");
            
            // solicita monto de compra al usuario
            Console.Write("Ingrese el monto de la compra en L : ");
            
            // TryParse devuelve true si la conversión es exitosa, false si falla, asi valida el numero ingr
            while (!double.TryParse(Console.ReadLine(), out montoCompra))
            {
                Console.Write("Debe ingresar un número válido. Ingrese el monto: ");
            }

            // Valida que el monto sea positivo 
            if (montoCompra <= 0)
            {
                Console.WriteLine("El monto debe ser mayor a 0.");
                return; // Termina el método si hay error de validación
            }

            // Calcular descuento según el rango del monto, e evalúa de mayor a menor para evitar errores de precedencia
            CalcularDescuento();

            // Mostrar resultados al usuario
            MostrarResultado();
        }

        /*
         * Calcula el descuento basado en el monto de compra
         Fórmula: descuento = monto * porcentaje
         */
        public void CalcularDescuento()
        {
            // Rango mayor primero 15% para compras grandes
            if (montoCompra >= 2500)
            {
                descuento = montoCompra * 0.15;  // 15% de descuento
                rango = "L2500+ (15%)";
            }
            // rango medio 10% para compras medianas
                else 
            if (montoCompra >= 1000)
            {
                descuento = montoCompra * 0.10;  // 10% de descuento
                rango = "L1000-2499 (10%)";
            }
            // tango bajo 5% para compras pequeñas
                else 
            if (montoCompra >= 500)
            {
                descuento = montoCompra * 0.05;   // 5% de descuento
                rango = "L500-999 (5%)";
            }
            // Sin descuento para compras muy pequeñas
                else
            {
                descuento = 0;
                rango = "Sin descuento (menos de L500)";
            }

            // precio final: resta el descuento al monto original
            precioFinal = montoCompra - descuento;
        }

        public void MostrarResultado()
        {
            Console.WriteLine("\n RESULTADO ");
            Console.WriteLine("Monto original: L " + montoCompra);
            Console.WriteLine("Descuento: L " + descuento);
            Console.WriteLine("Precio final: L " + precioFinal);
        }
    }
}
