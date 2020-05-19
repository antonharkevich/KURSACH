using System;
using System.Collections.Generic;
using System.Text;

namespace KURSACH
{
    static class WorkWithSets
    {
        public static void IntersectionOfSets(double[] a, double[] b)
        {
            int z = 0;
            int flg = 0;
            double[] intersection = new double[a.Length];
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        flg = 1;
                    }
                }
                if (flg == 1)
                {
                    flg = 0;
                    intersection[z] = a[i];
                    z++;
                }
            }
            Array.Resize(ref intersection, z);
            Console.WriteLine("Пересечение двух множеств");
            for(int i = 0; i < intersection.Length; i++)
            {
                Console.Write("{0} ", intersection[i]);
            }
        }

        public static void UnionOfSets(double[] a, double[] b)
        {
            int z = 0;
            int flg = 1;
            double[] union = new double[a.Length+b.Length];
            for (int i = 0; i < a.Length; i++)
            {
                union[z] = a[i];
                z++;
            }
            for(int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < z; j++)
                {
                    if (b[i] == union[j])
                    {
                        flg = 0;
                    }
                }
                if (flg == 0)
                {
                    flg = 1;
                }

                else
                {
                    union[z] = b[i];
                    z++;
                }
            }
            Array.Resize(ref union, z);
            Console.WriteLine("Объединение двух множеств");
            for (int i = 0; i < union.Length; i++)
            {
                Console.Write("{0} ", union[i]);
            }
        }


        public static void DifferenceOfSets(double[] a, double[] b)
        {
            int z = 0;
            int flg = 1;
            double[] difference = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        flg = 0;
                    }
                }
                if (flg == 0)
                {
                    flg = 1;
                }
                else
                {
                    difference[z] = a[i];
                    z++;
                }
            }
            Array.Resize(ref difference, z);
            Console.WriteLine("Разность двух множеств");
            for (int i = 0; i < difference.Length; i++)
            {
                Console.Write("{0} ", difference[i]);
            }
        }


        public static void SymmetricDifferenceOfSets(double[] a, double[] b)
        {
            int z = 0;
            int flg = 1;
            double[] difference = new double[a.Length+b.Length];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        flg = 0;
                    }
                }
                if (flg == 0)
                {
                    flg = 1;
                }
                else
                {
                    difference[z] = a[i];
                    z++;
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (b[i] == a[j])
                    {
                        flg = 0;
                    }
                }
                if (flg == 0)
                {
                    flg = 1;
                }
                else
                {
                    difference[z] = b[i];
                    z++;
                }
            }
            Array.Resize(ref difference, z);
            Console.WriteLine("Симметрическая разность двух множеств");
            for (int i = 0; i < difference.Length; i++)
            {
                Console.Write("{0} ", difference[i]);
            }
        }
    }
}
