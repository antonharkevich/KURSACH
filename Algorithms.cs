using System;
using System.Collections.Generic;
using System.Text;

namespace KURSACH
{
    static class Algorithms
    {
        public static int NOD(int a, int b)
        {
            if (a < 0)
            {
                a *= -1;
            }
            if (b < 0)
            {
                b *= -1;
            }
            while (a > 0 && b > 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }

            }
            return a + b;
        }

        public static int NOK(int a, int b)
        {
            if (a < 0)
            {
                a *= -1;
            }
            if (b < 0)
            {
                b *= -1;
            }
            return a*b / NOD(a, b);
        }

        public static void SieveOfEratosthenes(int n)
        {

            int size = n + 1;
            bool[] erato = new bool[size];

            for (int i = 2; i <= n; i++)
                erato[i] = true;

            for (int i = 2; i <= (int)(Math.Sqrt((float)(n))); i++)
            {
                if (erato[i]) for (int j = i; j <= n; j++)
                    {
                        if (i * j > n) break;
                        erato[i * j] = false;
                    }
            }
            for (int i = 2; i <= n; i++) {
                if (erato[i])
                {
                    Console.WriteLine("{0}", i);
                }
            }

        }
    }
}
