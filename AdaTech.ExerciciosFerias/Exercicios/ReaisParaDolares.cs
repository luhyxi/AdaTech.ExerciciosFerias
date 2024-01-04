using AdaTech.ExerciciosFerias.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.ExerciciosFerias.Exercicios
{
    internal class ReaisParaDolares : GeneralUtils
    {
        public static decimal RealizarConversao(decimal reais, decimal cotacaoDolar)
        {
            decimal resultado = decimal.Round(reais * cotacaoDolar, 2);
            return resultado;
        }

        public new static void DoCalculations()
        {
            decimal reais = ReceberValor<decimal>("Decimal (separado por ',')");
            decimal cotacao = ReceberValor<decimal>("Decimal (separado por ',')");

            decimal valor = RealizarConversao(reais, cotacao);

            Console.WriteLine($"O resultado final da operação é {valor}");
        }
    }
}
