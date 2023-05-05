using System;
using System.Linq;

namespace Estudando_algoritmos
{
    class Program
    {
        enum hexas
        {
            a= 10, 
            b = 11,
            c = 12,
            d = 13,
            e = 14,
            f=  15
        }
         public static string DecimalToHexa(int valor)
        {
            return Convert.ToString(valor, 16);
        }
        public static string DecimalToOcta(int valor)
        {
            return Convert.ToString(valor, 8);
        }
        static void Main(string[] args)
        {
            int n =Convert.ToInt32(Console.ReadLine());
            int somaImpar,somaTodos;
            int SomaPar = somaImpar = somaTodos= 0;
            for(int cont = 1; cont <= n; cont++)
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                if ( valor%2 == 0)
                {
                    SomaPar += valor;
                }
                else
                {
                    somaImpar += valor;
                }
                somaTodos += valor;
            }
            Console.WriteLine(somaTodos);
            Console.WriteLine(DecimalToHexa(SomaPar));
            Console.WriteLine(DecimalToOcta(somaImpar));
        }
    }
}
