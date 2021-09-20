//2 – Crie um algoritmo que verifique se um número informado é par ou impar

using System;

namespace _02_Impar_Ou_Par
{
    class Program
    {
        static void Main(string[] args)
        {
            char Continuar;
            int Numero;
            Inicio:

            Console.Clear();
            Console.WriteLine("Verificar se o número é impar ou par");
            Console.WriteLine("Digite um número: ");
            Numero = int.Parse(Console.ReadLine());

            if (Numero / 2 == 0)
            {
                Console.WriteLine("{0} é par", Numero);
            }
            else
            {
                Console.WriteLine("{0} é impar", Numero);
            }      

            Console.WriteLine("Continuar: [S/N]");
            Continuar = Convert.ToChar(Console.ReadLine());
            if (Continuar == 'S' || Continuar == 's'){
                goto Inicio;
            }
            Console.WriteLine("Aperte uma tecla para fechar");
            Console.ReadKey();
        }
    }
}
