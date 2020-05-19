using System;
using System.Collections.Generic;
using System.Text;

namespace KURSACH
{
    static class WorkWithMatrix
    {
        public static void MatrixOutput(double[,] c)
        {
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
            
        }

        public static void MatrixAddition(double[,] c, double[,] b)
        {
            
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] += b[i, j];
                }
            }
            MatrixOutput(c);
        }
        public static void MatrixSubstraction(double[,] c, double[,] b)
        {
           
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] -= b[i, j];
                }

            }
            MatrixOutput(c);
        }
        public static void MatrixMultiplication(double[,] c, double[,] b)
        {
           
            double sum;
            double[,] d = new double[c.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    sum = 0;
                    for (int k = 0; k < c.GetLength(1); k++)
                    {
                        sum += c[i, k] * b[k, j];
                    }
                    d[i, j] = sum;
                }
            }
            MatrixOutput(d);
        }
        public static void MatrixMultiplicationByNumber(double[,] c, double a)
        {
            
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] *= a;
                }

            }
            MatrixOutput(c);
        }
        public static void MatrixDivisionByNumber(double[,] c, double a)
        {
              
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] = c[i, j] / a;
                }
            }
            MatrixOutput(c);
        }

        public static void MatrixTr(double[,] c)
        {
            double tr = 0;
            for (int i = 0; i < c.GetLength(0); i++)
            {

                tr += c[i, i];

            }
            Console.WriteLine("След матрицы:{0}", tr);
        }

        public static void MatrixTranspose(double[,] c)
        {
            double[,] a = new double[c.GetLength(0), c.GetLength(0)];
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(0); j++) {
                    a[i, j] = c[j, i];
                }
            }
            MatrixOutput(a);
        }

        public static double Determinant(double[,] c)
        {


            int i, j;
            double det = 0;
            double[,] matr;
            if (c.GetLength(0) == 1)
            {
                det = c[0, 0];
            }
            else if (c.GetLength(0) == 2)
            {
                det = c[0, 0] * c[1, 1] - c[0, 1] * c[1, 0];
            }
            else
            {
                matr = new double[c.GetLength(0) - 1, c.GetLength(0) - 1];
                for (i = 0; i < c.GetLength(0); ++i)
                {
                    for (j = 0; j < c.GetLength(0) - 1; ++j)
                    {
                        if (j < i)
                        {
                            for (int k = 0; k < c.GetLength(0) - 1; k++)
                            {
                                matr[j, k] = c[j, k];
                            }
                        }
                        else
                        {
                            for (int k = 0; k < c.GetLength(0) - 1; k++)
                            {
                                matr[j, k] = c[j + 1, k];
                            }
                        }

                    }
                    det += Math.Pow((double)-1, (i + j)) * Determinant(matr) * c[i, c.GetLength(0) - 1];
                }

            }
            return det;

        }


        public static void InverseMatrix(double[,] c)
        {
            double temp;

            double[,] E = new double[c.GetLength(0), c.GetLength(0)];



            for (int i = 0; i < c.GetLength(0); i++)
                for (int j = 0; j < c.GetLength(0); j++)
                {
                    E[i, j] = 0.0;

                    if (i == j)
                        E[i, j] = 1.0;
                }

            for (int k = 0; k < c.GetLength(0); k++)
            {
                temp = c[k, k];

                for (int j = 0; j < c.GetLength(0); j++)
                {
                    c[k, j] /= temp;
                    E[k, j] /= temp;
                }

                for (int i = k + 1; i < c.GetLength(0); i++)
                {
                    temp = c[i, k];

                    for (int j = 0; j < c.GetLength(0); j++)
                    {
                        c[i, j] -= c[k, j] * temp;
                        E[i, j] -= E[k, j] * temp;
                    }
                }
            }

            for (int k = c.GetLength(0) - 1; k > 0; k--)
            {
                for (int i = k - 1; i >= 0; i--)
                {
                    temp = c[i, k];

                    for (int j = 0; j < c.GetLength(0); j++)
                    {
                        c[i, j] -= c[k, j] * temp;
                        E[i, j] -= E[k, j] * temp;
                    }
                }
            }

            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(0); j++)
                {
                    c[i, j] = E[i, j];
                }
            }

            MatrixOutput(c);
        }

        public static void TransitionToNewCoordinates(double[,] c,double[,] a)
        {
            
            double sum;
            double[,] d = new double[c.GetLength(0), c.GetLength(0)];
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(0); j++)
                {
                    sum = 0;
                    for (int k = 0; k < c.GetLength(1); k++)
                    {
                        sum += a[i, k] * c[k, j];
                    }
                    d[i, j] = sum;
                }
            }
            InverseMatrix(c);
            double[,] e = new double[c.GetLength(0), c.GetLength(0)];
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(0); j++)
                {
                    sum = 0;
                    for (int k = 0; k < c.GetLength(1); k++)
                    {
                        sum += c[i, k] * d[k, j];
                    }
                    e[i, j] = sum;
                }
            }
            Console.WriteLine("Матрица в новых координатах");
            MatrixOutput(e);
        }

        public static void SolvingSystemsOfLinearEquations(double[,] c, double[,] a)
        {
            double det = Determinant(c);
            for(int i = 0; i < c.GetLength(0); i++)
            {
                double[,] b = new double[c.GetLength(0), c.GetLength(0)];
                for(int j = 0; j < c.GetLength(0); j++)
                {
                    for(int k = 0; k < c.GetLength(0); k++)
                    {
                        if (k == i)
                        {
                            b[j, k] = a[j,0];
                        }
                        else
                        {
                            b[j, k] = c[j, k];
                        }
                    }
                }
                double D = Determinant(b);
                Console.WriteLine("x{0}= {1}", i, D / det);
            }
        }
    }

    
}
