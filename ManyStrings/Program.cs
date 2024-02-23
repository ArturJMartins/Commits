using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis do tipo string
            string frase1 = "O (\\n) \né um caracter de escape e este " +
            "unicode \\u2605 \u2605 é uma estrela.";

            //variaveis string com concatenação e por interpolação
            int idade = 28;
            int velhice = 40;
            string nome = "Artur " + idade;
            string concatenar ="Ola " + nome + ".";

            string interpolar =$"A idade do {nome} é {idade}." ;
            string interpolar2 =$"O {nome} quando for velho terá"+
            $" {idade + velhice} anos." ;

            Console.WriteLine("Hello, World!");
            Console.WriteLine(frase1);
            Console.WriteLine(concatenar);
            Console.WriteLine(interpolar);
            Console.WriteLine(interpolar2);
        }
    }
}
