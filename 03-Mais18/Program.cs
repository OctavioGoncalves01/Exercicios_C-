//3 – Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.

using System;

namespace _03_Mais18
{
    class Program
    {
        static void Main(string[] args)
        {
            int Mais18 = 0;
            int[] IdadeTodos = new int[10];

            for (int N = 0; N <IdadeTodos.Length; N++)
            {
                Console.Clear();
                Console.WriteLine("Digite a idade da {0} pessoa", N+1);
                int Idade = int.Parse(Console.ReadLine());
                if (Idade > 18)
                {
                    Mais18++;
                }
            }
            
            Console.Clear();
            Console.WriteLine($"\n{Mais18} possuem mais de 18 anos");
        }
    }
}
