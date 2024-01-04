using AdaTech.ExerciciosFerias.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.ExerciciosFerias.Exercicios
{
    internal class RaizQuadrada:GeneralUtils
    {
        protected static int CalcularRaizQuadrada(int input)
        {

            double resultado = Math.Exp(Math.Log(input) / 2);

            int calculoFloor = (int)Math.Floor(resultado);

            if (calculoFloor * calculoFloor == input) return calculoFloor;
            else return calculoFloor;
        }
        public new static void DoCalculations()
        {
            int valor = ReceberValor<int>("Integer");
            valor = CalcularRaizQuadrada(valor);
            Console.WriteLine($"O resultado final da operação é {valor}");
        }
    }
}
