using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 2, 4 },
                         { 3, 2 } };

            int[,] b = { { 3, 4 },
                         { 3, 3 } };

            int[,] c = new int [a.GetUpperBound(0) + 1, b.GetUpperBound(1) + 1];

            Console.WriteLine();
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    Console.Write("{0,5}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i <= b.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= b.GetUpperBound(1); j++)
                {
                    Console.Write("{0,5}", b[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= b.GetUpperBound(1); j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k <= a.GetUpperBound(0); k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }                   
                }
            }
            Console.WriteLine();
            for (int i = 0; i <= c.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= c.GetUpperBound(1); j++)
                {
                    Console.Write("{0,5}", c[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
