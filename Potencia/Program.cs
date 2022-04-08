using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, exponente, i;
            double resultado = 1, resultadoNegaivo;

            Console.Write("Ingresa la base: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el exponente: ");
            exponente = Convert.ToInt32(Console.ReadLine());

            if (exponente < 0)
            {
                exponente *= -1;
                
                for(i=1; i<=exponente; i++)
                {
                    resultado *= numero;
                }
                resultadoNegaivo = (1 / resultado);
                Console.WriteLine("{0}^{1} = {2}", numero, exponente, resultadoNegaivo);
                Console.ReadKey();
            }
            else
            {
                for (i=1; i<= exponente; i++)
                {
                    resultado *= numero;
                }
                Console.WriteLine("{0}^{1} = {2}", numero, exponente, resultado);
                Console.ReadKey();
            }


        }
    }
}
