using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, divisor, numDivisores = 0;
            numero = 2;
            while (numero <= 100)
            {
                divisor = 1;
                while (divisor <= numero)
                {
                    if (numero % divisor == 0)
                    {
                        numDivisores += 1;
                    }
                    divisor++;
                }
                if (numDivisores <= 2)
                {
                    Console.WriteLine("{0}", numero);
                    numDivisores = 0;
                }
                numero++;
            }
            Console.ReadKey();
        }
    }
}
