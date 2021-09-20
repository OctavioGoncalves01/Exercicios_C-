//1 – Elabore um algoritmo que calcule a idade média de 5 alunos.

using System;

namespace _01_Idade_media_Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] Idade = new float[5];
            float Media = 0;

            Console.WriteLine("Digite a idade do primeiro aluno: ");
            Idade[0] = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade do segundo aluno: ");
            Idade[1] = float.Parse(Console.ReadLine());
    
            Console.WriteLine("Digite a idade do terceiro aluno: ");
            Idade[2] = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade do quarto aluno: ");
            Idade[3] = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a idade do quinto aluno: ");
            Idade[4] = float.Parse(Console.ReadLine());

            Media = (Idade[0] + Idade[1] + Idade[2] + Idade[3] + Idade[4]) / 5;

            Console.WriteLine("A média de idade dos alunos é de: " + Media);
        }
    }
}
