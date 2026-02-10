using System;

namespace poo_guia_1_abnerP.Ejercicios.Bloque1
{

    public class ConvUnidsAlm
    {
        // constantes para las conversiones usando 1024 como factor
        public const double KB = 1024;
        public const double MB = 1024 * 1024;
        public const double GB = 1024 * 1024 * 1024;
        public const double TB = 1024L * 1024 * 1024 * 1024;

        // Solicita un valor positivo al usuario
        public double ObtenerPositivo(string mensaje)
        {
            double valor = 0;
            bool valido = false;

            do
            {
                Console.Write(mensaje);
                try
                {
                    valor = double.Parse(Console.ReadLine());
                    if (valor > 0)
                    {
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("  El valor debe ser positivo. Intente de nuevo.");
                    }
                }
                catch
                {
                    Console.WriteLine("  Por favor ingrese un número válido.");
                }
            } while (!valido);

            return valor;
        }

        //  menu 
        public void MostrarMenuUnidades()
        {
            Console.WriteLine("      SELECCIONE LA UNIDAD DE ENTRADA      ");
            Console.WriteLine("  1. Bytes");
            Console.WriteLine("  2. Kilobytes (KB)");
            Console.WriteLine("  3. Megabytes (MB)");
            Console.WriteLine("  4. Gigabytes (GB)");
            Console.WriteLine("  5. Terabytes (TB)");
            Console.WriteLine("  0. Volver al menu principal");
            Console.Write("  Ingrese su opción: ");
        }

        // Convierte bytes a la unidad seleccionada
        public void ConvertirDesdeBytes(double bytes)
        {
            Console.WriteLine("\n--- CONVERTIR DESDE BYTES ---");
            Console.WriteLine("  Bytes: " + bytes);
            Console.WriteLine("  Kilobytes: " + (bytes / KB));
            Console.WriteLine("  Megabytes: " + (bytes / MB));
            Console.WriteLine("  Gigabytes: " + (bytes / GB));
            Console.WriteLine("  Terabytes: " + (bytes / TB));
        }

        // Convierte KB a la unidad seleccionada
        public void ConvertirDesdeKB(double kb)
        {
            double bytes = kb * KB;
            Console.WriteLine("\n--- CONVERTIR DESDE KILOBYTES ---");
            Console.WriteLine("  Kilobytes: " + kb);
            Console.WriteLine("  Bytes: " + bytes);
            Console.WriteLine("  Megabytes: " + (bytes / MB));
            Console.WriteLine("  Gigabytes: " + (bytes / GB));
            Console.WriteLine("  Terabytes: " + (bytes / TB));
        }

        // Convierte MB a la unidad seleccionada
        public void ConvertirDesdeMB(double mb)
        {
            double bytes = mb * MB;
            Console.WriteLine("\n--- CONVERTIR DESDE MEGABYTES ---");
            Console.WriteLine("  Megabytes: " + mb);
            Console.WriteLine("  Bytes: " + bytes);
            Console.WriteLine("  Kilobytes: " + (bytes / KB));
            Console.WriteLine("  Gigabytes: " + (bytes / GB));
            Console.WriteLine("  Terabytes: " + (bytes / TB));
        }

        // Convierte GB a la unidad seleccionada
        public void ConvertirDesdeGB(double gb)
        {
            double bytes = gb * GB;
            Console.WriteLine("\n--- CONVERTIR DESDE GIGABYTES ---");
            Console.WriteLine("  Gigabytes: " + gb);
            Console.WriteLine("  Bytes: " + bytes);
            Console.WriteLine("  Kilobytes: " + (bytes / KB));
            Console.WriteLine("  Megabytes: " + (bytes / MB));
            Console.WriteLine("  Terabytes: " + (bytes / TB));
        }

        // Convierte TB a la unidad seleccionada
        public void ConvertirDesdeTB(double tb)
        {
            double bytes = tb * TB;
            Console.WriteLine("\n--- CONVERTIR DESDE TERABYTES ---");
            Console.WriteLine("  Terabytes: " + tb);
            Console.WriteLine("  Bytes: " + bytes);
            Console.WriteLine("  Kilobytes: " + (bytes / KB));
            Console.WriteLine("  Megabytes: " + (bytes / MB));
            Console.WriteLine("  Gigabytes: " + (bytes / GB));
        }

        // menu de conversion de unids
        public void Ejecutar()
        {
            int opcion;
            bool continuar = true;

            while (continuar)
            {
                MostrarMenuUnidades();

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
                        Console.WriteLine("\n  Ingrese la cantidad en Bytes:");
                        double bytes = ObtenerPositivo("  Bytes: ");
                        ConvertirDesdeBytes(bytes);
                        break;
                    case 2:
                        Console.WriteLine("\n  Ingrese la cantidad en Kilobytes:");
                        double kb = ObtenerPositivo("  KB: ");
                        ConvertirDesdeKB(kb);
                        break;
                    case 3:
                        Console.WriteLine("\n  Ingrese la cantidad en Megabytes:");
                        double mb = ObtenerPositivo("  MB: ");
                        ConvertirDesdeMB(mb);
                        break;
                    case 4:
                        Console.WriteLine("\n  Ingrese la cantidad en Gigabytes:");
                        double gb = ObtenerPositivo("  GB: ");
                        ConvertirDesdeGB(gb);
                        break;
                    case 5:
                        Console.WriteLine("\n  Ingrese la cantidad en Terabytes:");
                        double tb = ObtenerPositivo("  TB: ");
                        ConvertirDesdeTB(tb);
                        break;
                    default:
                        Console.WriteLine("\n  Opción no válida. Ingrese un número del 0 al 5.\n");
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
