// See https://aka.ms/new-console-template for more information
using AdaTech.ExerciciosFerias.Exercicios;
using AdaTech.ExerciciosFerias.Utils;

Console.WriteLine($@"Por favor, escolha um dos programs a seguir:
1 - Fahrenheit para Celsius
2 - Numero é primo ou não
3 - Calculo fatorial
4 - Ordenar array
5 - Palavra é palindromo
6 - Calculo raiz quadrada
7 - Real para dolar
8 - Validar senha
9 - CPF é válido
10 - Frequencia de palavras");
int opcao = GeneralUtils.ReadOption(1, 10);

switch (opcao)
{
    case 1:
        Console.Clear();
        ConversorFahrenheitCelsius.DoCalculations();
        break;
    case 2:
        Console.Clear();
        EhPrimo.DoCalculations();
        break;
    case 3:
        Console.Clear();
        CalcularFatorial.DoCalculations();
        break;
    case 4:
        Console.Clear();
        ArrayOrdenado.DoCalculations();
        break;
    case 5:
        Console.Clear();
        Palindromo.DoCalculations();
        break;
    case 6:
        Console.Clear();
        RaizQuadrada.DoCalculations();
        break;
    case 7:
        Console.Clear();
        ReaisParaDolares.DoCalculations();
        break;
    case 8:
        Console.Clear();
        VerificarSenha.DoCalculations();
        break;
    case 9:
        Console.Clear();
        RegexCPF.DoCalculations();
        break;
    case 10:
        Console.Clear();
        AnaliseTexto.DoCalculations();
        break;
    default:
        break;
}