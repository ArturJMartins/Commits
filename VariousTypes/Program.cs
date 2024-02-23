using System;
using System.Text;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            short a = 1;
            int b = 2;
            long c = 3L;
            ushort d = 4;
            uint e = 5U;
            ulong f = 6UL;

            char estrelaNegra = '\u2605';
            char vHandPose = '\u270C';
            char copyrightSymbol = '\u00A9';
            

            Console.WriteLine("Hello, World!");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

            Console.WriteLine(estrelaNegra);
            Console.WriteLine(vHandPose);
            Console.WriteLine(copyrightSymbol);
        }
    }
}
