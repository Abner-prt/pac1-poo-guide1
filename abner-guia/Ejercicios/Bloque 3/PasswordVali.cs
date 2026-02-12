using System;
namespace poo_guia_1_abnerP.Ejercicios.Bloque3
{
    public class PasswordVali
    {
        public void SolicitarPassword()         //Varios tutoriales y preguntas despues:
        {
            string password;
            bool valido = false;

            // bucle que se repite hasta que la contrasena sea valida
            do
            {
                // mostra mensaje y lee contrasena
                Console.Write("Ingrese una contrasena: ");
                password = Console.ReadLine();

                // llama al metodo que verifica los requisitos
                List<string> requisitosFalts = VerifPassword(password);

                // verifica si hay requisitos faltantes
                if (requisitosFalts.Count == 0)
                {
                    // Contrasena valida - mostrar exito
                    Console.WriteLine("\n¡Contrasena valida!");
                    Console.WriteLine("Tu contrasena cumple con todos los requisitos de seguridad.");
                    valido = true;  // cambiar a true para salir del bucle
                }
                else
                {
                    // jay requisitos faltantes - mostrarlos
                    Console.WriteLine("\nLa contrasena no cumple con los siguientes requisitos:");
                    
                    // usea foreach para mostrar cada requisito faltante
                    foreach (string requisito in requisitosFalts)
                    {
                        Console.WriteLine("  - " + requisito);
                    }
                    
                    Console.WriteLine("\nIntente de nuevo.");
                    // el bucle continuara porque valido sigue siendo false
                }
            } while (!valido);  // continuar mientras no sea valido
        }

        public List<string> VerifPassword(string password)
        {
            // Crear lista vacia para requisitos faltantes
            List<string> faltantes = new List<string>();

            // Verificar longitud minima (8 caracteres)
            if (password.Length < 8)
            {
                faltantes.Add("Minimo 8 caracteres (actual: " + password.Length + ")");
            }

            // verificar si hay al menos una mayuscula, se
            // usa un bucle for para recorrer cada caracter
            bool tieneMayus = false;
            for (int i = 0; i < password.Length; i++)
            {
                // obtiene el caracter actual
                char c = password[i];
                // verificar si es mayuscula (A-Z)
                if (c >= 'A' && c <= 'Z')
                {
                    tieneMayus = true;
                    break;  // salir del bucle si ya encontramos una mayuscula
                }
            }
            // si no tiene mayuscula, agregarla a la lista de faltantes
            if (!tieneMayus)
            {
                faltantes.Add("Al menos una letra mayuscula (A-Z)");
            }

            //verificar si hay al menos una minuscula
            bool tieneMinusc = false;
            for (int i = 0; i < password.Length; i++)
            {
                char c = password[i];
                // verifica si es minuscula (a-z)
                if (c >= 'a' && c <= 'z')
                {
                    tieneMinusc = true;
                    break;  // salir del bucle si ya encontramos una minuscula
                }
            }
            if (!tieneMinusc)
            {
                faltantes.Add("Al menos una letra minuscula (a-z)");
            }

            //verifica si hay al menos un numero
            bool tieneNumero = false;
            for (int i = 0; i < password.Length; i++)
            {
                char c = password[i];
                // verificar si es un digito (0-9)
                if (c >= '0' && c <= '9')
                {
                    tieneNumero = true;
                    break;  // sale del bucle si ya encontro un numero
                }
            }
            if (!tieneNumero)
            {
                faltantes.Add("Al menos un numero (0-9)");
            }

            // verifica si hay al menos un caracter especial y
            // define la cadena con caracteres especiales permitidos
            string caracteresEspeciales = "!@#$%^&*()_+-=[]{}|;':\",./<>?";
            
            bool tieneEspecial = false;
            for (int i = 0; i < password.Length; i++)
            {
                char c = password[i];
                // Verificar si el caracter actual esta en la lista de especiales
                for (int j = 0; j < caracteresEspeciales.Length; j++)
                {
                    if (c == caracteresEspeciales[j])
                    {
                        tieneEspecial = true;
                        break;  // sale del bucle interno
                    }
                }
                if (tieneEspecial)
                {
                    break;  // se sale del bucle externo
                }
            }
            if (!tieneEspecial)
            {
                faltantes.Add("Al1 menos un caracter especial (!@#$%^&*...)");
            }

            // retorna la lista de requisitos faltantes
            return faltantes;
        }

        public void Ejecutar()
        {
            // mostrar titulo del programa
            Console.WriteLine("\n VALIDACION DE CONTRASENA ");
            
            // mostrar lista de requisitos para el usuario
            Console.WriteLine("Requisitos:");
            Console.WriteLine("  - Minimo 8 caracteres");
            Console.WriteLine("  - Al menos una letra mayuscula");
            Console.WriteLine("  - Al menos una letra minuscula");
            Console.WriteLine("  - Al menos un numero");
            Console.WriteLine("  - Al menos un caracter especial");

            SolicitarPassword();
        }
    }
}
