using System;
using System.Globalization;
using System.Threading;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.
            InvariantCulture;
            

            
                Console.WriteLine("Insira 4 números reais: ");
                string numeros = Console.ReadLine();
                string numeros2 = Console.ReadLine();
                string numeros3 = Console.ReadLine();
                string numeros4 = Console.ReadLine();

                Console.WriteLine(numeros);
                Console.WriteLine(numeros);
                Console.WriteLine(numeros);
                Console.WriteLine(numeros);


            

        }
    }
}
