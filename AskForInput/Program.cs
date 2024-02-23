using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("Insira um número inteiro: ");
            string usuario = Console.ReadLine();
            int escolha = int.Parse(usuario);

            Console.WriteLine("Insira um número real: ");
            string usuario2 = Console.ReadLine();
            float escolha2 = float.Parse(usuario2);

            Console.WriteLine("A soma dos dois números é " +
             $"{escolha + escolha2}.");


            
        }
    }
}
