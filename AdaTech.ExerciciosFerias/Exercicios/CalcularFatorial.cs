using AdaTech.ExerciciosFerias.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.ExerciciosFerias.Exercicios
{
    internal class CalcularFatorial:GeneralUtils
    {
        private static int CalculoDoFatorial(int num)
        {
            int resultado = 1; 

            for (int i = 1; i <= num; i++) resultado *= i;

            return resultado;
        }
        public new static void DoCalculations() 
        {
            int valor = ReceberValor<int>("Integer");
            int resultado = CalculoDoFatorial(valor);

            Console.WriteLine($"O fatorial de {valor} é {resultado}");

            // Fazer um loop para repetir esse programa caso optado por 

        }
    }
}
