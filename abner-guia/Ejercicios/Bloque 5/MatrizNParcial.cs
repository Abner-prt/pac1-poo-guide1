namespace poo_guia_1_abnerP.Ejercicios.Bloque5
{
    public class MatrizNParcial
    {
        // matriz para guardar las notas: filas = estudiantes, columnas = examenes
        public double[,] notas;
        public int cantidadEst;
        public int cantidadExamenes = 3;  // Siempre son 3 examenes

        // nombres de los examenes para mostrar
        public string[] nombresExamenes = { "Parcial 1", "Parcial 2", "Final" };

        // pedimos cuantos estudiantes vamos a registrar
        public void SolicitarCantEstu()
        {
            Console.Write("Cuantos estudiantes va a registrar? ");
            cantidadEst = int.Parse(Console.ReadLine());

            if (cantidadEst < 1)
            {
                Console.WriteLine("Debe haber al menos 1 estudiante.");
                return;
            }

            // creamos la matriz con el tamano indicado
            notas = new double[cantidadEst, cantidadExamenes];
            SolicitarNotas();
        }

        // pedimos las notas de cada estudiante para cada examen
        public void SolicitarNotas()
        {
            Console.WriteLine("\n REGISTRO DE NOTAS ");
            Console.WriteLine("Ingrese las notas (0-100):\n");

            for (int estudiante = 0; estudiante < cantidadEst; estudiante++)
            {
                Console.WriteLine("--- Estudiante #" + (estudiante + 1) + " ---");
                
                for (int examen = 0; examen < cantidadExamenes; examen++)
                {
                    Console.Write(nombresExamenes[examen] + ": ");
                    double nota = double.Parse(Console.ReadLine());

                    // Verificamos que la nota sea valida
                    if (nota < 0 || nota > 100)
                    {
                        Console.WriteLine("Nota invalida. Debe estar entre 0 y 100.");
                        examen--;  // repetir este examen
                    }
                    else
                    {
                        notas[estudiante, examen] = nota;
                    }
                }
                Console.WriteLine();
            }

            // mostramos la matriz completa
            MostrarMatriz();
            // calculamos y mostramos los resultados
            CalcularResultados();
        }

        // mostramos la matriz de notas completa
        public void MostrarMatriz()
        {
            Console.WriteLine("\n MATRIZ DE NOTAS ");
            Console.Write("Estudiante\t");
            
            for (int e = 0; e < cantidadExamenes; e++)
            {
                Console.Write(nombresExamenes[e] + "\t");
            }
            Console.WriteLine();

            for (int estudiante = 0; estudiante < cantidadEst; estudiante++)
            {
                Console.Write("#" + (estudiante + 1) + "\t\t");
                for (int examen = 0; examen < cantidadExamenes; examen++)
                {
                    Console.Write(notas[estudiante, examen] + "\t");
                }
                Console.WriteLine();
            }
        }

        // calculamos todos los resultados
        public void CalcularResultados()
        {
            Console.WriteLine("\n RESULTADOS ");
            
            // promedio por estudiante
            PromedioPorEstudiante();
            
            // promedio por examen
            PromedioByExam();
            
            // estudiante con mejor promedio
            MejorEstudiante();
            
            // examen mas dificil
            ExamenMasDificil();
        }

        // calculamos el promedio de cada estudiante
        public void PromedioPorEstudiante()
        {
            Console.WriteLine("\n PROMEDIO POR ESTUDIANTE ");
            
            for (int estudiante = 0; estudiante < cantidadEst; estudiante++)
            {
                double suma = 0;
                
                for (int examen = 0; examen < cantidadExamenes; examen++)
                {
                    suma += notas[estudiante, examen];
                }
                
                double promedio = suma / cantidadExamenes;
                Console.WriteLine("Estudiante #" + (estudiante + 1) + ": " + promedio);
            }
        }

        // calculamos el promedio de cada examen
        public void PromedioByExam()
        {
            Console.WriteLine("\n PROMEDIO POR EXAMEN ");
            
            for (int examen = 0; examen < cantidadExamenes; examen++)
            {
                double suma = 0;
                
                for (int estudiante = 0; estudiante < cantidadEst; estudiante++)
                {
                    suma += notas[estudiante, examen];
                }
                
                double promedio = suma / cantidadEst;
                Console.WriteLine(nombresExamenes[examen] + ": " + promedio);
            }
        }

        // encontramos el estudiante con el promedio mas alto
        public void MejorEstudiante()
        {
            double mejorPromedio = 0;
            int numeroMejorEstudiante = 0;

            for (int estudiante = 0; estudiante < cantidadEst; estudiante++)
            {
                double suma = 0;
                
                for (int examen = 0; examen < cantidadExamenes; examen++)
                {
                    suma += notas[estudiante, examen];
                }
                
                double promedio = suma / cantidadExamenes;

                if (promedio > mejorPromedio)
                {
                    mejorPromedio = promedio;
                    numeroMejorEstudiante = estudiante + 1;
                }
            }

            Console.WriteLine("\n MEJOR ESTUDIANTE ");
            Console.WriteLine("Estudiante #" + numeroMejorEstudiante + " con promedio: " + mejorPromedio);
        }

        // encontramos el examen mas dificil (menor promedio)
        public void ExamenMasDificil()
        {
            double menorPromedio = 101;  // Empezamos con un valor alto
            int examenMasDificil = 0;

            for (int examen = 0; examen < cantidadExamenes; examen++)
            {
                double suma = 0;
                
                for (int estudiante = 0; estudiante < cantidadEst; estudiante++)
                {
                    suma += notas[estudiante, examen];
                }
                
                double promedio = suma / cantidadEst;

                if (promedio < menorPromedio)
                {
                    menorPromedio = promedio;
                    examenMasDificil = examen;
                }
            }

            Console.WriteLine("\n EXAMEN MAS DIFICIL ");
            Console.WriteLine(nombresExamenes[examenMasDificil] + " con promedio: " + menorPromedio);
        }

        // se ejecuta
        public void Ejecutar()
        {
            SolicitarCantEstu();
        }
    }
}
