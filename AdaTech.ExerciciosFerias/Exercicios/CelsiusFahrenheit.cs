using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AdaTech.ExerciciosFerias.Utils;


namespace AdaTech.ExerciciosFerias.Exercicios
{
    public class ConversorFahrenheitCelsius : GeneralUtils
    {
        private static float CelsiusParaFahrenheit(float valor) =>
            (valor * 1.8f + 32);
        private static float FahrenheitParaCelsius(float valor) =>
            ((valor - 32) / 1.8f);

        private static bool EhFahrenheitParaCelsius()
        {
            do
            {
                string escolha = Console.ReadLine().ToLower();
                if (escolha != "a" && escolha != "b")
                {
                    Console.WriteLine("Por favor, escolha uma das opções");
                    continue;
                }
                Console.Clear();
                return escolha == "a" ? true : false;
            }
            while (true);
        }


        public static void DoCalculations()
        {
            Console.WriteLine("Você deseja converter de 'Fahrenheit para Celsius'(Pressione 'a') ou de 'Celsius Para Fahrenheit' ('Pressione 'b')?");
            
            bool escolha = EhFahrenheitParaCelsius();

            float valor = ReceberValor<float>("float");

            if (escolha) 
            {
                Console.WriteLine($"O resultado de Fº {valor} para Cº:{FahrenheitParaCelsius(valor)}");
            }
            else
            {
                Console.WriteLine($"O resultado de Cº {valor} Para Fº: {CelsiusParaFahrenheit(valor)}");
            }
            

        }
    }
}
