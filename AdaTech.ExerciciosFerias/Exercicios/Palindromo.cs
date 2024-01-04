using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.ExerciciosFerias.Exercicios
{
    internal class Palindromo
    {
        private static bool EhPalindromo(string palavra)
        {
            if (palavra.Length <= 1) { return true; }
            else
            {
                if (palavra[0] != palavra[palavra.Length - 1]) return false;
                else return EhPalindromo(palavra.Substring(1,palavra.Length-2));
            }
        }
        public new static void DoCalculations()
        {
            Console.WriteLine("Por favor, insira uma palavra:");
            var input = Console.ReadLine().Trim();
            string resultado = EhPalindromo(input) ? "é palindromo" : "não é palindromo";
            Console.WriteLine($"A palavra '{input}' {resultado}");
            
        }
    }
}
