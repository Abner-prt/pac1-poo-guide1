using System;

namespace poo_guia_1_abnerP.Ejercicios
{
    public class CalculadoraIMC
    {
        // global vars
        public double peso;
        public double altura;
        public double imc;

        public void SolicitarDatos()
        {
            Console.Write("Ingresa tu peso en kilogramos: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa tu altura en metros: ");
            altura = Convert.ToDouble(Console.ReadLine());
        }

        public void CalcularIMC()
        {
            // Formula: IMC = peso / (altura * altura)
            imc = peso / (altura * altura);
        }

        public void MostrarResultado()
        {
            // muestra el valor imc
            Console.WriteLine("Tu Indice de Masa Corporal es: " + imc);

            // Determinar la categoria
            if (imc < 18.5)
            {
                Console.WriteLine("Categoria: Bajo peso");
            }
            if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Categoria: Peso normal");
            }
            if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Categoria: Sobrepeso");
            }
            if (imc >= 30)
            {
                Console.WriteLine("Categoria: Obesidad");
            }
        }

        // desps en el programcs incorporar el metodo en el menu
        public void Ejecutar()
        {
            SolicitarDatos();
            CalcularIMC();
            MostrarResultado();
        }
    }
}
