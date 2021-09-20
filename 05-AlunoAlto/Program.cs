//5 – Faça um algoritmo que leia a altura e a matricula de dez aluno. 
//Mostre a matricula do aluno mais alto e do aluno mais baixo.

using System;

namespace _05_AlunoAlto
{
    class Program
    {
        static void Main(string[] args)
        {
            String MaiorMatricula, MenorMatricula, Matricula;
            Double MaiorAltura, MenorAltura, Altura;

            Console.Write("Informe a matricula do aluno: ");
            Matricula = Console.ReadLine();
            Console.Write("Informe a altura do aluno: ");
            Altura = Convert.ToDouble(Console.ReadLine());

            MaiorAltura = Altura;
            MenorAltura = Altura;
            MaiorMatricula = Matricula;
            MenorMatricula = Matricula;
            
            int i = 1;
            while (i < 5)
            {
                Console.Clear();
                Console.Write("Informe a matricula do aluno: ");
                Matricula = Console.ReadLine();
                Console.Write("Informe a altura do aluno: ");
                Altura = Convert.ToDouble(Console.ReadLine());
                
                if(MaiorAltura < Altura)
                {
                    MaiorMatricula = Matricula;
                    MaiorAltura = Altura;
                }

                if (MenorAltura > Altura)
                {
                    MenorMatricula = Matricula;
                    MenorAltura = Altura;
                }
                i++;

            }
            Console.WriteLine("Maior aluno");
            Console.WriteLine("Matricula: {0}, Altura: {1}", MaiorMatricula, MaiorAltura);
            Console.WriteLine("Menor aluno");
            Console.WriteLine("Matricula: {0}, Altura: {1}", MenorMatricula, MenorAltura);
            Console.ReadKey();                
        }
    }
}
