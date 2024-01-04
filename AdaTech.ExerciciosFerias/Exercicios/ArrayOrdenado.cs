using AdaTech.ExerciciosFerias.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.ExerciciosFerias.Exercicios
{
    internal class ArrayOrdenado : GeneralUtils
    {
        private static int[] OrdenarArrayBubble(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
        public new static void DoCalculations()
        {
            int[] intArray = ReceberArray<int>("integer");
            OrdenarArrayBubble(intArray);

            PrintArray(intArray);
        }
    }
}
