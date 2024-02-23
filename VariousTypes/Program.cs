using System;
using System.Text;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // variaveis inteiras
            short a = 1;
            int b = 2;
            long c = 3L;
            ushort d = 4;
            uint e = 5U;
            ulong f = 6UL;

            // variaveis reais
            double g = 7.543;
            float h = 8.432f;
            decimal i = 9.234m;

            //variaveis com valor unicode
            char estrela = '\u2605';
            char vHandPose = '\u270C';
            char copyrightSymbol = '\u00A9';

            //variaveis booleanas
            bool verdadeiro = true;
            bool falso = false;
            
            Console.WriteLine("Hello, World!");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);

            Console.WriteLine(estrela);
            Console.WriteLine(vHandPose);
            Console.WriteLine(copyrightSymbol);

            Console.WriteLine(verdadeiro);
            Console.WriteLine(falso);
        }
    }
}
