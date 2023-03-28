using System;

namespace SomaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100000; // número dado para calcular a soma
            int soma = Soma(num);
            Console.WriteLine($"A soma de 1 até {num} é: {soma}");
        }

        static int Soma(int num)
        {
            if (num < 1) // verifica se o número é maior que zero
            {
                throw new ArgumentException("O número deve ser maior que zero.");
            }

            int soma = 0;
            for (int i = 1; i <= num; i++)
            {
                soma += i;
            }
            return soma;
        }
    }
}
