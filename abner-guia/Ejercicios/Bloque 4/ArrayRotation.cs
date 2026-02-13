namespace poo_guia_1_abnerP.Ejercicios.Bloque4
{
    public class ArrayRotation
    {
        // arreglo de elementos
        public int[] arreglo;
        public int cantidad;

        // solicita el tamano del arreglo y lo llena
        public void CrearArreglo()
        {
            Console.Write("Cuantos elementos tendra el arreglo? ");
            cantidad = int.Parse(Console.ReadLine());

            // valida que sea al menos 1
            if (cantidad < 1)
            {
                Console.WriteLine("El arreglo debe tener al menos 1 elemento.");
                return;
            }

            arreglo = new int[cantidad];

            Console.WriteLine("\nIngrese los elementos:");
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Elemento #" + (i + 1) + ": ");
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            MostrarArreglo("Arreglo original");
        }

        // muestra el arreglo actual
        public void MostrarArreglo(string titulo)
        {
            Console.WriteLine("\n" + titulo + ":");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i]);
                if (i < arreglo.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        // rota el arreglo K posiciones a la izquierda
        // ejemplo: [1,2,3,4,5] rotado 2 a la izquierda = [3,4,5,1,2]
        public void RotarIzquierda()
        {
            Console.Write("Cuantas posiciones rotar a la izquierda? ");
            int k = int.Parse(Console.ReadLine());

            // normaliza k para que no sea mayor que el tamaño
            k = k % cantidad;

            if (k == 0)
            {
                Console.WriteLine("No hay cambios.");
                return;
            }

            // se crea un arreglo temporal
            int[] temp = new int[cantidad];

            // se copia los elementos rotados
            for (int i = 0; i < cantidad; i++)
            {
                // la nueva posicion es (i - k)
                // si es negativo, le suma la cantidad
                int nuevaPos = i - k;
                if (nuevaPos < 0)
                {
                    nuevaPos += cantidad;
                }
                temp[nuevaPos] = arreglo[i];
            }

            // copia el temporal al arreglo original
            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = temp[i];
            }

            MostrarArreglo("Arreglo rotado " + k + " posiciones a la izquierda");
        }

        // rota el arreglo K posiciones a la derecha
        // ejemplo: [1,2,3,4,5] rotado 2 a la derecha = [4,5,1,2,3]
        public void RotarDerecha()
        {
            Console.Write("Cuantas posiciones rotar a la derecha? ");
            int k = int.Parse(Console.ReadLine());

            // se repite un poco el procedimiento, normaliza k
            k = k % cantidad;

            if (k == 0)
            {
                Console.WriteLine("No hay cambios.");
                return;
            }

            // se crea un arreglo temporal
            int[] temp = new int[cantidad];

            // copiamos los elementos rotados
            for (int i = 0; i < cantidad; i++)
            {
                // la nueva posicion es i + k ahora
                // si es mayor o igual a cantidad, le resta la cantidad
                int nuevaPos = i + k;
                if (nuevaPos >= cantidad)
                {
                    nuevaPos -= cantidad;
                }
                temp[nuevaPos] = arreglo[i];
            }

            // copia el temporal al arreglo original
            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = temp[i];
            }

            MostrarArreglo("Arreglo rotado " + k + " posiciones a la derecha");
        }

        // invierte el arreglo
        // ejemplo: [1,2,3,4,5] = [5,4,3,2,1]
        public void InvertirArreglo()
        {
            // intercambia el primero con el ultimo, segundo con penultimo, etc.
            int inicio = 0;
            int fin = cantidad - 1;

            while (inicio < fin)
            {
                // intercambia los elementos
                int temp = arreglo[inicio];
                arreglo[inicio] = arreglo[fin];
                arreglo[fin] = temp;

                // mueve los indices
                inicio++;
                fin--;
            }

            MostrarArreglo("Arreglo invertido");
        }

        // muestra el menu de opciones
        public void MostrarMenu()
        {
            Console.WriteLine("\n      ROTACION DE ARREGLO      ");
            Console.WriteLine("  1. Rotar K posiciones a la izquierda");
            Console.WriteLine("  2. Rotar K posiciones a la derecha");
            Console.WriteLine("  3. Invertir arreglo");
            Console.WriteLine("  4. Mostrar arreglo actual");
            Console.WriteLine("  0. Volver al menu principal");
            Console.Write("  Ingrese su opcion: ");
        }

        // ejecutarr
        public void Ejecutar()
        {
            // pero, obvio primero creamos el arreglo
            CrearArreglo();

            if (arreglo == null)
            {
                return;
            }

            int opcion;
            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();

                try
                {
                    opcion = int.Parse(Console.ReadLine());
                }
                catch
                {
                    opcion = -1;
                }

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("\n  Volviendo al menu principal...");
                        continuar = false;
                        break;
                    case 1:
                        RotarIzquierda();
                        break;
                    case 2:
                        RotarDerecha();
                        break;
                    case 3:
                        InvertirArreglo();
                        break;
                    case 4:
                        MostrarArreglo("Arreglo actual");
                        break;
                    default:
                        Console.WriteLine("\n Ingrese un numero del 0 al 4.\n");
                        break;
                }

                if (continuar && opcion >= 1 && opcion <= 4)
                {
                    Console.WriteLine("\n  Presione Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }
    }
}
