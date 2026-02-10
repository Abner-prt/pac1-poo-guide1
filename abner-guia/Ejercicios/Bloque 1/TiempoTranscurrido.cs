using System;

namespace poo_guia_1_abnerP.Ejercicios.Bloque1
{
    // Clase para calcular el tiempo transcurrido entre dos horas
    public class TiempoTranscurrido
    {
        public int hora1, minuto1, segundo1;
        public int hora2, minuto2, segundo2;
        public int horasTranscurridas, minutosTranscurridos, segundosTranscurridos;

        // Solicita la primera hora al usuario
        public void SolicitarPrimeraHora()
        {
            Console.WriteLine("Ingrese la primera hora (formato 24 horas):");
            Console.Write("  Hora: ");
            hora1 = int.Parse(Console.ReadLine());

            Console.Write("  Minuto: ");
            minuto1 = int.Parse(Console.ReadLine());

            Console.Write("  Segundo: ");
            segundo1 = int.Parse(Console.ReadLine());
        }

        // Solicita la segunda hora al usuario
        public void SolicitarSegundaHora()
        {
            Console.WriteLine("\nIngrese la segunda hora (formato 24 horas):");
            Console.Write("  Hora: ");
            hora2 = int.Parse(Console.ReadLine());

            Console.Write("  Minuto: ");
            minuto2 = int.Parse(Console.ReadLine());

            Console.Write("  Segundo: ");
            segundo2 = int.Parse(Console.ReadLine());
        }

        // Calcula la diferencia de tiempo entre las dos horas
        public void CalcularTiempo()
        {
            // Convierte ambas horas a segundos totales
            int totalSegundos1 = hora1 * 3600 + minuto1 * 60 + segundo1;
            int totalSegundos2 = hora2 * 3600 + minuto2 * 60 + segundo2;

            // Calcula la diferencia
            int diferenciaSegundos = totalSegundos2 - totalSegundos1;

            // Si la diferencia es negativa, suma 24 horas (86400 segundos)
            // Esto maneja casos donde la segunda hora es del dia siguiente
            if (diferenciaSegundos < 0)
            {
                diferenciaSegundos += 24 * 3600;
            }

            // Convierte la diferencia de segundos a horas, minutos y segundos
            horasTranscurridas = diferenciaSegundos / 3600;
            diferenciaSegundos %= 3600;

            minutosTranscurridos = diferenciaSegundos / 60;
            segundosTranscurridos = diferenciaSegundos % 60;
        }

        // Muestra el resultado del tiempo transcurrido
        public void MostrarResultado()
        {
            Console.WriteLine("\n--- TIEMPO TRANSCURRIDO ---");
            Console.WriteLine("Primera hora: " + hora1 + ":" + minuto1 + ":" + segundo1);
            Console.WriteLine("Segunda hora: " + hora2 + ":" + minuto2 + ":" + segundo2);
            Console.WriteLine("Tiempo transcurrido: " + horasTranscurridas + " horas, " + 
                              minutosTranscurridos + " minutos, " + segundosTranscurridos + " segundos");
        }

        // Ejecuta el proceso completo del calculo de tiempo
        public void Ejecutar()
        {
            SolicitarPrimeraHora();
            SolicitarSegundaHora();
            CalcularTiempo();
            MostrarResultado();
        }
    }
}
