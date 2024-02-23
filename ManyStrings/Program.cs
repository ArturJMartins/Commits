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

            Console.WriteLine("Hello, World!");
            Console.WriteLine(frase1);
        }
    }
}
