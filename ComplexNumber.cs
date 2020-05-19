using System;
using System.Collections.Generic;
using System.Text;

namespace KURSACH
{
    static class ComplexNumber
    {
        public static void AdditionNumbers(double lRe, double lIm, double rRe, double rIm)
        {
            Console.WriteLine("Конечное число:{0}+i({1})", (lRe + rRe), (lIm + rIm));
        }

        public static void SubstractionNumbers(double lRe, double lIm, double rRe, double rIm)
        {
            Console.WriteLine("Конечное число:{0}+i({1})", (lRe - rRe), (lIm - rIm));
        }
        public static void DivisionNumbers(double lRe, double lIm, double rRe, double rIm)
        {
            Console.WriteLine("Конечное число:{0}+i({1})", ((lRe * rRe + lIm * rIm)/ (Math.Sqrt((rRe * rRe) + (rIm * rIm)))), ((rRe *lIm-rIm*lRe)/(Math.Sqrt((rRe * rRe) + (rIm * rIm)))));
        }
        public static void MultiplicationNumbers(double lRe, double lIm, double rRe, double rIm)
        {
            Console.WriteLine("Конечное число:{0}+i({1})", (lRe*rRe-lIm*rIm), (lRe*rIm +lIm*rRe));
        }

        public static void СonjugateNumber(double Re, double Im)
        {
            Console.WriteLine("Конечное число:{0}+i({1})", Re, (Im*-1));
        }

        public static void LengthOfNumber(double Re, double Im)
        {
            Console.WriteLine("Длина:{0}", Math.Sqrt((Re*Re)+(Im*Im)));
        }

        public static void RootExtracingOfNumber(double Re, double Im, int n)
        {
            Console.WriteLine("Корень степени n из числа:{0}(cos({1}+2k*pi/{2})+i*sin({1}*2k*pi/{2}))", (Math.Pow(Math.Sqrt((Re * Re) + (Im * Im)),(double)1/n)),(Math.Atan(Im/Re)), n);
        }
    }
}
