namespace poo_guia_1_abnerP.Ejercicios.Bloque4
{
    public class BusquedaOrdenam
    {
        // arrglo de 10 ents
        public int[] numeros;

        // el arreglo se llena con los 10 numeros que el usuario debe ingresar
        public void LlenarArreglo()
        {
            numeros = new int[10];
            Console.WriteLine("Ingrese 10 numeros enteros:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Numero #" + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            MostrarArreglo("Arreglo original");
        }

        // muestra el arreglo con un titulo
        public void MostrarArreglo(string titulo)
        {
            Console.WriteLine("\n" + titulo + ":");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i]);
                if (i < numeros.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        //  busca un numero en el arreglo
        // recorre uno por uno hasta encontrarlo
        public void BusquedaLineal()
        {
            Console.Write("\nIngrese el numero a buscar: ");
            int buscado = int.Parse(Console.ReadLine());

            bool encontrado = false;
            int posicion = -1;

            // aqui recorremos el arreglo elemento por elemento
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscado)
                {
                    encontrado = true;
                    posicion = i;
                    break;  // se sale al encontrarlo
                }
            }

            if (encontrado)
            {
                Console.WriteLine("Numero " + buscado + " encontrado en la posicion " + posicion);
            }
            else
            {
                Console.WriteLine("Numero " + buscado + " no encontrado en el arreglo.");
            }
        }

        // aqui se encuentra el segundo numero mas grande
        public void EncontrarSdoMay()
        {
            int mayor = numeros[0];
            int segundoMayor = numeros[0];

            // pero primero se encuentra el mayor
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
            }

            // ahora busca el mayor que no sea igual al primero
            // e inicializamos con el valor mas pequeño posible
            segundoMayor = int.MinValue;
            bool encontrado = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < mayor && numeros[i] > segundoMayor)
                {
                    segundoMayor = numeros[i];
                    encontrado = true;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("\nEl numero mayor es: " + mayor);
                Console.WriteLine("El segundo mayor es: " + segundoMayor);
            }
            else
            {
                Console.WriteLine("\nTodos los numeros son iguales: " + mayor);
            }
        }

        // usamo algo llamado ordenamiento burbuja: compara pares adyacentes y los intercambia
        // repite hasta que el arreglo este ordenado
        public void OrdenarBurbuja()
        {
            // hacemos un arreglon como una copia para no modificar el original
            int[] ordenado = new int[10];
            for (int i = 0; i < 10; i++)
            {
                ordenado[i] = numeros[i];
            }

            // ordenam burbuja otra vez: compara pares y los intercambia si estan desordenados
            for (int i = 0; i < ordenado.Length - 1; i++)
            {
                for (int j = 0; j < ordenado.Length - 1 - i; j++)
                {
                    // si el actual es mayor que el siguiente, los intercambia
                    if (ordenado[j] > ordenado[j + 1])
                    {
                        int temp = ordenado[j];
                        ordenado[j] = ordenado[j + 1];
                        ordenado[j + 1] = temp;
                    }
                }
            }

            // aqui muestra el arreglo ordenado
            Console.WriteLine("\nArreglo ordenado ascendente:");
            for (int i = 0; i < ordenado.Length; i++)
            {
                Console.Write(ordenado[i]);
                if (i < ordenado.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        // muestra los elementos en posiciones pares (0, 2, 4, 6, 8)
        public void MostrarPosiPar()
        {
            Console.WriteLine("\nElementos en posiciones pares (0, 2, 4, 6, 8):");

            for (int i = 0; i < numeros.Length; i += 2)
            {
                Console.WriteLine("Posicion " + i + ": " + numeros[i]);
            }
        }

        // muestra el menu de opciones
        public void MostrarMenu()
        {
            Console.WriteLine("\n      BUSQUEDA Y ORDENAMIENTO      ");
            Console.WriteLine("  1. Buscar un numero (busqueda lineal)");
            Console.WriteLine("  2. Encontrar el segundo mayor");
            Console.WriteLine("  3. Ordenar ascendentemente (bubble sort)");
            Console.WriteLine("  4. Mostrar posiciones pares");
            Console.WriteLine("  5. Mostrar arreglo original");
            Console.WriteLine("  0. Volver al menu principal");
            Console.Write("  Ingrese su opcion: ");
        }

        // ejecuta el programa con el menu
        public void Ejecutar()
        {
            // pero primero llenamos el arreglo
            LlenarArreglo();

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
                        BusquedaLineal();
                        break;
                    case 2:
                        EncontrarSdoMay();
                        break;
                    case 3:
                        OrdenarBurbuja();
                        break;
                    case 4:
                        MostrarPosiPar();
                        break;
                    case 5:
                        MostrarArreglo("Arreglo original");
                        break;
                    default:
                        Console.WriteLine("\n Ingrese un numero del 0 al 5.\n");
                        break;
                }

                if (continuar && opcion >= 1 && opcion <= 5)
                {
                    Console.WriteLine("\n  Presione Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }
    }
}
