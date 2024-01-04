using AdaTech.ExerciciosFerias.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdaTech.ExerciciosFerias.Exercicios
{
    internal class VerificarSenha : GeneralUtils
    {
        public new static void DoCalculations()
        {
            do
            {
                Console.WriteLine("Insira uma senha atende aos seguintes critérios:" +
                    "\nTer no mínimo 8 caracteres, conter pelo menos uma letra maiúscula, uma letra minúscula e um número");
                var input = Console.ReadLine();

                if (Regex.IsMatch(input, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$"))
                {
                    Console.Clear();
                    Console.WriteLine("A Senha está no padrão!");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Senha inválida, por favor tente denovo.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (true);
        }
    }
}
