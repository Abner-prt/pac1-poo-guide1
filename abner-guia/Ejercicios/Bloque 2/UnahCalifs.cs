using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_guia_1_abnerP.Ejercicios.Bloque2
{

    public class UnahCalifs
    {
        // atrs
        public double calificacion;
        public string letra;
        public string descripcion;
        public string estado;

        public void Ejecutar()
        {
            Console.WriteLine("=== SISTEMA DE CALIFICACIONES UNAH ===");
            Console.Write("Ingrese la calificacion (0-100): ");

            // Validar que sea un número válido usando TryParse
            // TryParse evita excepciones si la entrada no es numérica
            while (double.TryParse(Console.ReadLine(), out calificacion))
            {
                Console.Write("Debe ingresar un número válido. Ingrese la calificacion: ");
            }

            // Validar rango 0-100
            // Si la calificación está fuera del rango, terminates el método
            if (calificacion < 0 || calificacion > 100)
            {
                Console.WriteLine("La calificacion debe estar entre 0 y 100.");
                return;
            }

            // Determina letra y descripción según el rango numérico
            // Se usa estructura if-else-if para clasificar en rangos excluyentes
            DeterminarLetra();

            // Determinar} estado APROBADO/REPROBADO según si pasó el umbral de 60
            DeterminarEstado();

            // Mostrar resultados al usuario
            MostrarResultado();
        }
        // serie de else ifs para determ la letra segun calificacion
        public void DeterminarLetra()
        {
            if (calificacion >= 90 && calificacion <= 100)
            {
                letra = "A";
                descripcion = "Excelente";
            }
                else 
            if (calificacion >= 80 && calificacion <= 89)
            {
                letra = "B";
                descripcion = "Muy Bueno";
            }
                else 
            if (calificacion >= 70 && calificacion <= 79)
            {
                letra = "C";
                descripcion = "Bueno";
            }
                else
            if (calificacion >= 60 && calificacion <= 69)
            {
                letra = "D";
                descripcion = "Suficiente";
            }
                else
            {
                letra = "F";
                descripcion = "Reprobado";
            }
        }

        public void DeterminarEstado()
        {
            estado = (calificacion >= 60) ? "APROBADO" : "REPROBADO";
        }

        public void MostrarResultado()
        {
            Console.WriteLine("\n RESULTADO ");
            Console.WriteLine("Calificacion: " + calificacion);
            Console.WriteLine("Letra: " + letra);
            Console.WriteLine("Descripcion: " + descripcion);
            Console.WriteLine("Estado: " + estado);
        }
    }
}
