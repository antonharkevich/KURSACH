using System;
using System.Collections.Generic;
using System.Text;

namespace KURSACH
{
    static class WorkWithVectors
    {
        public static double VectorLength(Vector l)
        {
            Console.WriteLine("Длина заданного вектора:{0})",Math.Sqrt(l.i*l.i+l.j*l.j+l.k*l.k));
            return Math.Sqrt(l.i * l.i + l.j * l.j + l.k * l.k);
        }
        public static void VectorOrt(Vector l)
        {
            Console.WriteLine("Орт заданного вектора:({0},{1},{2})", (l.i/Math.Sqrt(l.i * l.i + l.j * l.j + l.k * l.k)), (l.j / Math.Sqrt(l.i * l.i + l.j * l.j + l.k * l.k)), (l.k / Math.Sqrt(l.i * l.i + l.j * l.j + l.k * l.k)));

        }
        public static void VectorMultiplicationNumber(Vector l, double value)
        {
            Console.WriteLine("Вектор после умножения на заданное число:({0},{1},{2})", (l.i*value), (l.j*value), (l.k*value));
        }
        public static void VectorDivisionNumber(Vector l, double value)
        {
            if (value == 0)
            {
                Console.WriteLine("Делить на ноль нельзя!");
            }
            else
            {
                Console.WriteLine("Вектор после деления на заданное число:({0},{1},{2})", (l.i / value), (l.j / value), (l.k / value));
            }
        }
        public static void VectorAddition(Vector l, Vector r)
        {
            Console.WriteLine("Вектор после сложения:({0},{1},{2})", (l.i +r.i), (l.j + r.j), (l.k + r.k));
        }
        public static void VectorSubsraction(Vector l, Vector r)
        {
            Console.WriteLine("Вектор после вычитания:({0},{1},{2})", (l.i - r.i), (l.j - r.j), (l.k - r.k));
        }

        public static double VectorScalarMultiplication(Vector l, Vector r)
        {
            Console.WriteLine("Скалярное проивздение двух векторов: {0}", (l.i * r.i) + (l.j * r.j) + (l.k * r.k));
            return (l.i * r.i) + (l.j * r.j) + (l.k * r.k);
        }

        public static void VectorGuideCosines(Vector l)
        {
            Console.WriteLine("Направляющие косинусы вектора:cosL={0},cosB={1},cosY={2}", (l.i/VectorLength(l)), (l.j / VectorLength(l)), (l.k / VectorLength(l)));
        } 
        public static void VectorCoordinates(Vector A, Vector B)
        {
            Console.WriteLine("Координаты вектора AB:({0},{1},{2})", (B.i - A.i), (B.j - A.j), (B.k - A.k));
        }

        public static void SegmentLength(Vector A, Vector B)
        {
            Console.WriteLine("Длина заданного отрезка:{0}", Math.Sqrt((A.i - B.i) * (A.i - B.i) + (A.j - B.j) * (A.j - B.j) + (A.k - B.k) * (A.k - B.k)));
        }

        public static void DivisionOfSegment(Vector A, Vector B, int L)
        {
            Console.WriteLine("Координаты точки, делящей отрезок в отношении 1:{0}: ({1},{2},{3})",L,(((A.i+B.i*L)/1+L)), (((A.j + B.j * L) / 1 + L)), (((A.k + B.k * L) / 1 + L)));
        }

        public static double AngleBetweenTwoVectors(Vector l, Vector r)
        {
            double angle = Math.Acos(Math.Abs(CosOfAngleBetweenTwoVectors(l,r))) * 180 / Math.PI;
            Console.WriteLine("Угол между векторами:{0}", angle);
            return angle;
        }
        public static double CosOfAngleBetweenTwoVectors(Vector l, Vector r)
        {
            double cos = (VectorScalarMultiplication(l, r) / (VectorLength(l) * VectorLength(r)));
            Console.WriteLine("Косинус угла между векторами:{0}", cos);
            return cos;
        }

        public static void ProectionOfVectorOnOtherVector(Vector l, Vector r)
        {
            Console.WriteLine("Проекция вектора:{0}", VectorScalarMultiplication(l,r)/VectorLength(l));
        }

        public static bool IsLinesParallel(Vector l, Vector r)
        {
            return ((l.i / r.i) == (l.j / r.j))&&((l.j/r.j)==(l.k/r.k))&&((l.i/r.i)==(l.k/r.k));
        }

        public static bool IsPlanesParallel(Vector l, Vector r)
        {
            return ((l.i / r.i) == (l.j / r.j)) && ((l.j / r.j) == (l.k / r.k)) && ((l.i / r.i) == (l.k / r.k));
        }

        public static bool IsLinesPerpendicular(Vector l, Vector r)
        {
            return VectorScalarMultiplication(l,r)==0;
        }

        public static bool IsPlanesPerpendicular(Vector l, Vector r)
        {
            return VectorScalarMultiplication(l, r) == 0;
        }
        public static bool IsLineAndPlanePerpendicular(Vector l, Vector r)
        {
            return ((l.i / r.i) == (l.j / r.j)) && ((l.j / r.j) == (l.k / r.k)) && ((l.i / r.i) == (l.k / r.k));
        }

        public static bool IsLineAndPlaneParallel(Vector l, Vector r)
        {
            return VectorScalarMultiplication(l, r) == 0;
        }

        public static void AngleBetweenPlanes(Vector l, Vector r)
        {
            double angle = Math.Acos(Math.Abs(CosOfAngleBetweenTwoVectors(l, r))) * 180 / Math.PI;
            Console.WriteLine("Угол между плокостями:{0}", angle);
        }

        public static void AngleBetweenLines(Vector l, Vector r)
        {
            double angle = Math.Acos(Math.Abs(CosOfAngleBetweenTwoVectors(l, r))) * 180 / Math.PI;
            Console.WriteLine("Угол между прямыми:{0}", angle);
        }

        public static void AngleBetweenLineAndPlane(Vector l, Vector r)
        {
            double angle = Math.Asin(Math.Abs(CosOfAngleBetweenTwoVectors(l, r))) * 180 / Math.PI;
            Console.WriteLine("Угол между прямой и плокостью:{0}", angle);
        }


        public static void VectorOrthogonalToTwo(Vector l, Vector r)
        {
            Console.WriteLine("Координаты вектора ортогонального двум заданным:({0},{1},{2})", (l.j*r.k - r.j*l.k), (-(l.i*r.k - r.i*l.k)), (l.i*r.j - r.i*l.j));
        }


        public static void TwoPoinLineEquation(Vector l, Vector r)
        {
            Console.WriteLine("Уравнение прямой по двум заданным точкам:(x-{0})/{1}=(y-{2})/{3}=(z-{4})/{5}", (l.i),(r.i-l.i),(l.j),(r.j-l.j),(r.k),(r.k-l.k));
        }

        public static void PointAndVectorPlaneEquation(Vector l, Vector r)
        {
            Console.WriteLine("Уравнение плоскости по заданному вектору и точке:{0}*(x-{1})+{2}*(y-{3})+{4}*(z-{5})=0", (l.i), (r.i), (l.j), (r.j), (l.k), (r.k));
        }

        public static void TwoVectorsAndPointPlaneEquation(Vector l, Vector r, Vector M)
        {
            Console.WriteLine("Уравнение плоскости по двум заданным векторам и точке:{0}*(x-{1})+{2}*(y-{3})+{4}*(z-{5})=0", (l.j * r.k - r.j * l.k), (M.i), (-(l.i * r.k - r.i * l.k)), (M.j), (l.i * r.j - r.i * l.j), (M.k));
        }

        public static void ThreePointsPlaneEquation(Vector M1, Vector M2, Vector M)
        {
            Console.WriteLine("Уравнение плоскости по трём заданным точкам:{0}*(x-{1})+{2}*(y-{3})+{4}*(z-{5})=0", ((M1.j-M.j) * (M2.k-M.k) - (M2.j-M.j) * (M1.k-M.k)), (M.i), (-((M1.i-M.i) * (M2.k-M.k) - (M2.i-M.i) * (M1.k-M.k))), (M.j), ((M1.i-M.i) * (M2.j-M.j) - (M2.i-M.i) * (M1.j-M.j)), (M.k));
        }

        public static void DistanseFromPointToPlane(Vector l, Vector M, Vector M1)
        {
            Console.WriteLine("Расстояние от заданной точки до плокости:{0}", Math.Abs((l.i*(M1.i-M.i)+ l.j * (M1.j - M.j) + l.k * (M1.k - M.k))/Math.Sqrt(l.i*l.i+l.j*l.j+l.k*l.k)));
        }

        public static void ProectionOfPointOnPlane(Vector l, Vector M, Vector M1)
        {
            double t= -((l.i * (M1.i - M.i) + l.j * (M1.j - M.j) + l.k * (M1.k - M.k)) / Math.Sqrt(l.i * l.i + l.j * l.j + l.k * l.k));
            Console.WriteLine("Координаты проекции точки на плокость:({0},{1},{2})",l.i*t+M1.i, l.j * t + M1.j, l.k * t + M1.k);
        }

        public static void DistanceBetweenCrossingLines(Vector l, Vector M,Vector l1, Vector M1)
        {
            Console.WriteLine("Расстояние между скрещивающимися прямыми:{0}", Math.Abs((l.j*l1.k-l.k-l1.j)*(M1.i-M.i)-(l.i*l1.k-l.k*l1.i)*(M1.j-M.j)+(l.i*l1.j-l.j*l1.i)*(M1.k-M.k))/(Math.Sqrt((l.j * l1.k - l.k - l1.j)* (l.j * l1.k - l.k - l1.j)+ (l.i * l1.k - l.k * l1.i)* (l.i * l1.k - l.k * l1.i)+ (l.i * l1.j - l.j * l1.i)* (l.i * l1.j - l.j * l1.i))));
        }

        public static void VectorMultiplicationOfTwoVectors(Vector l, Vector l1)
        {
            Console.WriteLine("Векторное произведение двух векторов:{0}", (Math.Sqrt((l.j * l1.k - l.k - l1.j) * (l.j * l1.k - l.k - l1.j) + (l.i * l1.k - l.k * l1.i) * (l.i * l1.k - l.k * l1.i) + (l.i * l1.j - l.j * l1.i) * (l.i * l1.j - l.j * l1.i))));
        }

        public static void MixedMultiplicationOfTwoVectors(Vector l, Vector r, Vector q )
        {
            Console.WriteLine("Смешанное произведение двух векторов:{0}", (l.i*r.j*q.k+l.k*r.i*q.j+q.i*l.j*r.k-l.k*r.j*q.i-l.i*r.k*q.j-q.k*l.j*r.i));
        }

        public static void GramSchmidtOrthogonalizationProcess(Vector x1, Vector x2, Vector x3)
        {
            
            Vector u1;
            u1.i = x1.i / (x1.i * x1.i + x1.j * x1.j + x1.k * x1.k);
            u1.j = x1.j / (x1.i * x1.i + x1.j * x1.j + x1.k * x1.k);
            u1.k = x1.k / (x1.i * x1.i + x1.j * x1.j + x1.k * x1.k);
            Console.WriteLine("Первый вектор имеет вид: ({0},{1},{2})", u1.i, u1.j, u1.k);
            Vector v2;
            v2.i =x2.i - (x2.i * u1.i + x2.j * u1.j + x2.k * u1.k) * u1.i;
            v2.j =x2.j - (x2.i * u1.i + x2.j * u1.j + x2.k * u1.k) * u1.j;
            v2.k =x2.k - (x2.i * u1.i + x2.j * u1.j + x2.k * u1.k) * u1.k;
            Vector u2;
            u2.i = v2.i / (v2.i * v2.i + v2.j * v2.j + v2.k * v2.k);
            u2.j = v2.j / (v2.i * v2.i + v2.j * v2.j + v2.k * v2.k);
            u2.k = v2.k / (v2.i * v2.i + v2.j * v2.j + v2.k * v2.k);
            Console.WriteLine("Второй вектор имеет вид: ({0},{1},{2})", u2.i, u2.j, u2.k);
            Vector v3;
            v3.i = x3.i - (x3.i * u1.i + x3.j * u1.j + x3.k * u1.k) * u1.i - (x3.i * u2.i + x3.j * u2.j + x3.k * u2.k) * u2.i;
            v3.j = x3.j - (x3.i * u1.i + x3.j * u1.j + x3.k * u1.k) * u1.j - (x3.i * u2.i + x3.j * u2.j + x3.k * u2.k) * u2.j;
            v3.k = x3.k - (x3.i * u1.i + x3.j * u1.j + x3.k * u1.k) * u1.k - (x3.i * u2.i + x3.j * u2.j + x3.k * u2.k) * u2.k;
            Vector u3;
            u3.i = v3.i / (v3.i * v3.i + v3.j * v3.j + v3.k * v3.k);
            u3.j = v3.j / (v3.i * v3.i + v3.j * v3.j + v3.k * v3.k);
            u3.k = v3.k / (v3.i * v3.i + v3.j * v3.j + v3.k * v3.k);
            Console.WriteLine("Третий вектор имеет вид: ({0},{1},{2})", u3.i, u3.j, u3.k);
        }
    }
}
