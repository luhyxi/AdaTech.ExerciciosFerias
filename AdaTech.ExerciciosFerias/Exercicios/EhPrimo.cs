using AdaTech.ExerciciosFerias.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.ExerciciosFerias.Exercicios
{
    internal class EhPrimo : GeneralUtils
    {
        private static bool ChecarPrimo(int num)
        {
            switch (num)
            {
                case <= 1:
                    return false;
                case 2:
                    return true;
                default:
                    for (int i = 2; i * i <= num; i++)
                        if (num % i == 0) return false;
                    return true;
            }
        }
        public new static void DoCalculations()
        {
            int valor = ReceberValor<int>("Integer");
            bool checagem = ChecarPrimo(valor);
            string resultado = checagem ? "é primo" : "não é primo";
            
            Console.WriteLine($"O valor {valor} {resultado}");

        }



    }
}
