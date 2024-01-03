using System;

namespace AdaTech.ExerciciosFerias.Utils
{
    public class GeneralUtils
    {
        public static T ReceberValor<T>(string NomeDoTipo)
        {
            var tipoEsperado = typeof(T);

            do
            {
                Console.WriteLine($"Por favor, insira um valor do tipo {NomeDoTipo}:");
                var input = Console.ReadLine();

                try
                {
                    T valor = (T)Convert.ChangeType(input, tipoEsperado);
                    Console.Clear();
                    return valor;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Erro: Valor inserido não é do tipo {NomeDoTipo}.");
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine($"Erro: Não é possível converter para o tipo {NomeDoTipo}.");
                }

            } while (true);
        }

    }
}
