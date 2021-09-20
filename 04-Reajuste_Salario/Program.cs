//4 – Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a seguinte regra: 
//Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.

using System;

namespace _04_Reajuste_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            float Salario = 0, NovoSalario = 0;

            for (int I = 1; I < 11; I++)
            {
                Console.Clear();
                Console.Write($"Digite o salário do {I}°: R$");
                Salario = float.Parse(Console.ReadLine());

                if (Salario <= 300)
                {
                    NovoSalario = Salario + (Salario/2);
                }
                else
                {
                    NovoSalario = Salario + ((Salario * 30) / 100);
                }
                Console.WriteLine($"Novo salario no valor de R$:{NovoSalario}");
                Console.WriteLine($"Aperte qualquer tecla para prossiguir\nAinda falta {10-I} funcionario");
                Console.ReadKey();

            }            
        }
    }
}
