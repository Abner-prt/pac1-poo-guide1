namespace poo_guia_1_abnerP.Ejercicios.Bloque4
{
    public class ArregloTemps
    {
        // arreglo para las temperaturas de 7 dias
        public double[] temperaturas;
        // arreglo con los nombres de los dias de la semana
        public string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

        public ArregloTemps()
        {
            temperaturas = new double[7];
        }

        // se registra las temperaturas de cada dia
        public void RegistrarTemper()
        {
            Console.WriteLine(" REGISTRO DE TEMPERATURAS SEMANALES \n");
            Console.WriteLine("Ingrese las temperaturas en grados Celsius:\n");

            for (int i = 0; i < 7; i++)
            {
                Console.Write(dias[i] + ": ");
                temperaturas[i] = double.Parse(Console.ReadLine());
            }

            // muestra lo que se registrao
            Console.WriteLine("\n TEMPERATURAS REGISTRADAS ");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(dias[i] + ": " + temperaturas[i] + " C");
            }
        }

        // calcula y muestra el promedio semanal
        public double CalcularPromedio()
        {
            double suma = 0;

            for (int i = 0; i < 7; i++)
            {
                suma += temperaturas[i];
            }

            double promedio = suma / 7;
            Console.WriteLine("\nPromedio semanal: " + promedio + " C");
            return promedio;
        }

        // muestra que dias estuvieron por encima del promedio
        public void DiasSobrePromedio(double promedio)
        {
            Console.WriteLine("\n DIAS POR ENCIMA DEL PROMEDIO ");
            int contador = 0;

            for (int i = 0; i < 7; i++)
            {
                if (temperaturas[i] > promedio)
                {
                    Console.WriteLine(dias[i] + ": " + temperaturas[i] + " C");
                    contador++;
                }
            }

            if (contador == 0)
            {
                Console.WriteLine("Ningun dia estuvo por encima del promedio.");
            }
            else
            {
                Console.WriteLine("Total: " + contador + " dias por encima del promedio.");
            }
        }

        // encuentra el dia mas caluroso
        public void DiaMasCaluroso()
        {
            double maxTemp = temperaturas[0];
            int diaCaluroso = 0;

            for (int i = 1; i < 7; i++)
            {
                if (temperaturas[i] > maxTemp)
                {
                    maxTemp = temperaturas[i];
                    diaCaluroso = i;
                }
            }

            Console.WriteLine("\nDia mas caluroso: " + dias[diaCaluroso] + " con " + maxTemp + " C");
        }

        // encuentra el dia mas frio
        public void DiaMasFrio()
        {
            double minTemp = temperaturas[0];
            int diaFrio = 0;

            for (int i = 1; i < 7; i++)
            {
                if (temperaturas[i] < minTemp)
                {
                    minTemp = temperaturas[i];
                    diaFrio = i;
                }
            }

            Console.WriteLine("Dia mas frio: " + dias[diaFrio] + " con " + minTemp + " C");
        }

        // muestra la variacion entre dias consecutivos
        public void VariacionConsecutiva()
        {
            Console.WriteLine("\n VARIACION ENTRE DIAS CONSECUTIVOS ");

            for (int i = 0; i < 6; i++)
            {
                double diferencia = temperaturas[i + 1] - temperaturas[i];
                string direccion;

                if (diferencia > 0)
                {
                    direccion = "subio";
                }
                else if (diferencia < 0)
                {
                    direccion = "bajo";
                    diferencia = diferencia * -1;  // Hacemos positivo para mostrar
                }
                else
                {
                    direccion = "sin cambios";
                }

                Console.WriteLine(dias[i] + " -> " + dias[i + 1] + ": " + direccion + " " + diferencia + " C");
            }
        }

        // muestra un resumen completo
        public void ShowResumen()
        {
            Console.WriteLine("\n RESUMEN SEMANAL ");

            // promedio
            double promedio = CalcularPromedio();

            // dias sobre promedio
            DiasSobrePromedio(promedio);

            // dia mas caluroso y mas frio
            DiaMasCaluroso();
            DiaMasFrio();

            // variacion entre dias
            VariacionConsecutiva();

            Console.WriteLine("\n oa :)");
        }

        // iniciar
        public void Ejecutar()
        {
            RegistrarTemper();
            ShowResumen();
        }
    }
}
