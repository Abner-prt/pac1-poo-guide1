using System;
namespace poo_guia_1_abnerP.Ejercicios.Bloque5
{
    public class InventSimple
    {
        // se guardan 5 productos, todos tiene codigo, nombre cantidad y precio
        // usamos varios arreglos en paralelo para seguir instrucciones 
        private int[] codigos;
        private string[] nombres;
        private int[] cantidades;
        private double[] precios;
        private int totalProductos;

        public InventSimple()
        {
            // se hace espacio para 5 productos
            codigos = new int[5];
            nombres = new string[5];
            cantidades = new int[5];
            precios = new double[5];
            totalProductos = 0;
        }

        // esto llena el arreglo con algunos productos por defecto para que tengamos con que trabajar
        private void CargarDatosIniciales()
        {
            // 1
            codigos[0] = 101;
            nombres[0] = "Laptop HP";
            cantidades[0] = 15;
            precios[0] = 850.00;

            // 2
            codigos[1] = 102;
            nombres[1] = "Mouse Logitech";
            cantidades[1] = 50;
            precios[1] = 25.50;

            // 3
            codigos[2] = 103;
            nombres[2] = "Teclado Mecanico";
            cantidades[2] = 30;
            precios[2] = 75.00;

            // 4
            codigos[3] = 104;
            nombres[3] = "Monitor 24 pulgadas";
            cantidades[3] = 20;
            precios[3] = 320.00;

            // 5
            codigos[4] = 104;
            nombres[4] = "Audifonos Bluetooth";
            cantidades[4] = 40;
            precios[4] = 65.00;

            totalProductos = 5;
        }

        // se muestran todos los productos
        private void MostrarInventario()
        {
            Console.WriteLine("\n   INVENTARIO COMPLETO ");
            Console.WriteLine("  Codigo    | Nombre                | Cantidad | Precio");
            Console.WriteLine("  ----------|----------------------|----------|----------");

            for (int i = 0; i < totalProductos; i++)
            {
                // se rellena el nombre para que la tabla se vea mas alineada
                string nombreFormateado = nombres[i];
                if (nombreFormateado.Length < 20)
                {
                    nombreFormateado = nombreFormateado + new string(' ', 20 - nombreFormateado.Length);
                }
                else if (nombreFormateado.Length > 20)
                {
                    nombreFormateado = nombreFormateado.Substring(0, 17) + "...";
                }

                Console.WriteLine("  " + codigos[i] + "      | " + nombreFormateado + " | " + cantidades[i] + "       | $" + precios[i]);
            }

            Console.WriteLine("  ==========================================");
        }

        // se le permite al usuario buscar un producto por el codigo
        private void BuscarProducto()
        {
            Console.Write("\n  Ingrese el codigo del producto a buscar: ");
            int codigoBuscar;

            try
            {
                codigoBuscar = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("  Error: El codigo debe ser un numero entero.");
                return;
            }

            // look through all products to find the one with matching code
            bool encontrado = false;
            for (int i = 0; i < totalProductos; i++)
            {
                if (codigos[i] == codigoBuscar)
                {
                    Console.WriteLine("\n  Producto encontrado:");
                    Console.WriteLine("  Codigo: " + codigos[i]);
                    Console.WriteLine("  Nombre: " + nombres[i]);
                    Console.WriteLine("  Cantidad: " + cantidades[i]);
                    Console.WriteLine("  Precio: $" + precios[i]);
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("  No se encontro ningun producto con ese codigo.");
            }
        }

        // permite cambiar la cantidad de un producto para el stock
        private void ActualizarCantidad()
        {
            Console.Write("\n  Ingrese el codigo del producto a actualizar: ");
            int codigoActualizar;

            try
            {
                codigoActualizar = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("  Error: El codigo debe ser un numero entero.");
                return;
            }

            // primero encuentra el producto
            int indice = -1;
            for (int i = 0; i < totalProductos; i++)
            {
                if (codigos[i] == codigoActualizar)
                {
                    indice = i;
                    break;
                }
            }

            if (indice == -1)
            {
                Console.WriteLine("  No se encontro ningun producto con ese codigo.");
                return;
            }

            // muestra la cantidad actual
            Console.WriteLine("  Producto: " + nombres[indice]);
            Console.WriteLine("  Cantidad actual: " + cantidades[indice]);

            Console.Write("  Ingrese la nueva cantidad: ");
            int nuevaCantidad;

            try
            {
                nuevaCantidad = int.Parse(Console.ReadLine());
                if (nuevaCantidad < 0)
                {
                    Console.WriteLine("  Error: La cantidad no puede ser negativa.");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("  Error: Ingrese un numero entero valido.");
                return;
            }

            // actualiza la cantidad
            cantidades[indice] = nuevaCantidad;
            Console.WriteLine("  Cantidad actualizada correctamente.");
        }

        // calcula el valor de todo el inventario
        private void CalcularValorTotal()
        {
            double valorTotal = 0;

            // suma precio * cantidad de cada producto
            for (int i = 0; i < totalProductos; i++)
            {
                valorTotal = valorTotal + (cantidades[i] * precios[i]);
            }

            Console.WriteLine("\n  VALOR DEL INVENTARIO ");
            Console.WriteLine("  Producto              | Cantidad | Precio   | Subtotal");
            Console.WriteLine("  ----------------------|----------|----------|----------");

            for (int i = 0; i < totalProductos; i++)
            {
                double subtotal = cantidades[i] * precios[i];
                string nombreFormateado = nombres[i];
                if (nombreFormateado.Length < 20)
                {
                    nombreFormateado = nombreFormateado + new string(' ', 20 - nombreFormateado.Length);
                }
                else if (nombreFormateado.Length > 20)
                {
                    nombreFormateado = nombreFormateado.Substring(0, 17) + "...";
                }

                Console.WriteLine("  " + nombreFormateado + " | " + cantidades[i] + "       | $" + precios[i] + " | $" + subtotal);
            }

            Console.WriteLine("  ------------------------------------------");
            Console.WriteLine("  VALOR TOTAL DEL INVENTARIO: $" + valorTotal);
            Console.WriteLine("  ==========================================");
        }

        // the main menu where user picks what to do
        public void Ejecutar()
        {
            // first load some sample data so we have something to work with
            CargarDatosIniciales();

            bool continuar = true;
            int opcion;

            Console.WriteLine("\n  ==========================================");
            Console.WriteLine("       SISTEMA DE INVENTARIO SIMPLE");
            Console.WriteLine("  ==========================================");

            while (continuar)
            {
                Console.WriteLine("\n  MENU DE OPCIONES:");
                Console.WriteLine("  1. Mostrar inventario completo");
                Console.WriteLine("  2. Buscar producto por codigo");
                Console.WriteLine("  3. Actualizar cantidad de producto");
                Console.WriteLine("  4. Calcular valor total del inventario");
                Console.WriteLine("  0. Salir");
                Console.Write("  Ingrese su opcion: ");

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
                        Console.WriteLine("\n  Saliendo del sistema de inventario...");
                        continuar = false;
                        break;
                    case 1:
                        MostrarInventario();
                        break;
                    case 2:
                        BuscarProducto();
                        break;
                    case 3:
                        ActualizarCantidad();
                        break;
                    case 4:
                        CalcularValorTotal();
                        break;
                    default:
                        Console.WriteLine("\n  Opcion no valida. Ingrese un numero del 0 al 4.");
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
