using AdaTech.ExerciciosFerias.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.ExerciciosFerias.Exercicios
{
    internal class AnaliseTexto:GeneralUtils
    {
        public static void AnalisarTexto(string input)
        {
            Dictionary<string, int> PalavrasFrequencia = new Dictionary<string, int>();
            string[] palavras = input.Split(' ');

            foreach (string palavra in palavras)
            {
                string novaPalavra = palavra.Trim().ToLower();
                if (PalavrasFrequencia.ContainsKey(novaPalavra))
                {
                    PalavrasFrequencia[novaPalavra]++;
                }
                else
                {
                    PalavrasFrequencia.Add(novaPalavra, 1);
                }
            }

            foreach (var palavra in PalavrasFrequencia)
            {
                Console.WriteLine($"\n{palavra.Key}: {palavra.Value} vezes");
            }
        }
        public static new void DoCalculations()
        {
            Console.WriteLine("Insira um texto para analise");
            var input = Console.ReadLine();
            AnalisarTexto(input);
        }
    }

}
