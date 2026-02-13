namespace poo_guia_1_abnerP.Ejercicios.Bloque4
{
    public class EstadisticaCalif
    {
        // aqui guardamos las calificaciones que ingrese el usuario
        public double[] calificaciones;
        public int cantidad;

        // preguntamos cuantas calificaciones va a ingresar
        public void SolicitarCantidad()
        {
            Console.Write("Cuantas calificaciones va a ingresar? ");
            cantidad = int.Parse(Console.ReadLine());

            // necesitamos al menos 1 calificacion
            if (cantidad < 1)
            {
                Console.WriteLine("Debe ingresar al menos 1 calificacion.");
                return;
            }

            // Creamos el arreglo con el tamano indicado
            calificaciones = new double[cantidad];
            SolicitarCalificaciones();
        }

        // pedimos cada una de las calificaciones
        public void SolicitarCalificaciones()
        {
            Console.WriteLine("\nIngrese las calificaciones (0-100):");
            
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Calificacion #" + (i + 1) + ": ");
                double nota = double.Parse(Console.ReadLine());

                // verificamos que este en el rango valido
                if (nota < 0 || nota > 100)
                {
                    Console.WriteLine("Calificacion invalida. Debe estar entre 0 y 100.");
                    i--;  // repetir esta calificacion
                }
                else
                {
                    calificaciones[i] = nota;
                }
            }

            // mostramos lo que ingresamos
            MostrarCalifs();
            // calculamos todo
            CalcularEstads();
        }

        // mostramos todas las calificaciones ingresadas
        public void MostrarCalifs()
        {
            Console.WriteLine("\n--- CALIFICACIONES INGRESADAS ---");
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write(calificaciones[i]);
                if (i < cantidad - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        // calculamos y mostramos todas las estadisticas
        public void CalcularEstads()
        {
            Console.WriteLine("\n--- ESTADISTICAS ---");

            // promedio: suma de todas dividido entre la cantidad
            double promedio = CalcularPromedio();
            Console.WriteLine("Promedio: " + promedio);

            // maximo: la calificacion mas alta
            double maximo = CalcularMaximo();
            Console.WriteLine("Calificacion mas alta: " + maximo);

            // minimo: la calificacion mas baja
            double minimo = CalcularMinimo();
            Console.WriteLine("Calificacion mas baja: " + minimo);

            // aprobados y reprobados 60 es el minimo para aprobar
            int aprobados = ContarAprobados();
            int reprobados = cantidad - aprobados;
            Console.WriteLine("Aprobados (>=60): " + aprobados);
            Console.WriteLine("Reprobados (<60): " + reprobados);

            // desviacion estandar
            double desviacion = CalcularDesvEst(promedio);
            Console.WriteLine("Desviacion estandar: " + desviacion);
        }

        // calcula el promedio de las calificaciones
        public double CalcularPromedio()
        {
            double suma = 0;

            for (int i = 0; i < cantidad; i++)
            {
                suma += calificaciones[i];
            }

            return suma / cantidad;
        }

        // encuentra la calificacion mas alta
        public double CalcularMaximo()
        {
            double maximo = calificaciones[0];

            for (int i = 1; i < cantidad; i++)
            {
                if (calificaciones[i] > maximo)
                {
                    maximo = calificaciones[i];
                }
            }

            return maximo;
        }

        // encuentra la calificacion mas baja
        public double CalcularMinimo()
        {
            double minimo = calificaciones[0];

            for (int i = 1; i < cantidad; i++)
            {
                if (calificaciones[i] < minimo)
                {
                    minimo = calificaciones[i];
                }
            }

            return minimo;
        }

        // cuenta cuantos alumnos aprobaron (nota >= 60)
        public int ContarAprobados()
        {
            int contador = 0;

            for (int i = 0; i < cantidad; i++)
            {
                if (calificaciones[i] >= 60)
                {
                    contador++;
                }
            }

            return contador;
        }

        // calcula la desviacion estandar
        // formula: raiz cuadrada de la suma de (xi - promedio)^2 dividido entre n
        public double CalcularDesvEst(double promedio)
        {
            double sumaDiferencias = 0;

            for (int i = 0; i < cantidad; i++)
            {
                // diferencia al cuadrado
                double diferencia = calificaciones[i] - promedio;
                sumaDiferencias += diferencia * diferencia;
            }

            // varianza
            double varianza = sumaDiferencias / cantidad;

            // desviacion estandar es la raiz de la varianza
            return Math.Sqrt(varianza);
        }

        // executarr
        public void Ejecutar()
        {
            SolicitarCantidad();
        }
    }
}
