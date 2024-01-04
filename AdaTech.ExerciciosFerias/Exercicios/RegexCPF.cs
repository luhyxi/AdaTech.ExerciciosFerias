using AdaTech.ExerciciosFerias.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdaTech.ExerciciosFerias.Exercicios
{
    internal class RegexCPF:GeneralUtils
    {
        private static bool EhValido(string cpf)
        {
            string cpfRegex = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";
            if (!Regex.IsMatch(cpf, cpfRegex))
            {
                return false;
            }


            return true;
        }
        public static new void  DoCalculations()
        {
            do
            {
                Console.WriteLine("Insira um CPF para verificação(Com pontos '.' e traço '-'");
                var input = Console.ReadLine();

                if (EhValido(input))
                {
                    Console.Clear();
                    Console.WriteLine("O CPF está em formato correto!");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("O CPF é inválido, por favor tente novamente.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (true);
        }
    }
}
