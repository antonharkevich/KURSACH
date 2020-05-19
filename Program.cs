using System;

namespace KURSACH
{
    class Program
    {
        
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            while (true)
            {
                Console.WriteLine("Введите 1 для нахождения всех элементов треугольника по его 3-м точкам");
                Console.WriteLine("Введите 2 для входа в режим работы с матрицами");
                Console.WriteLine("Введите 3 для входа в режим работы с алгоритмами");
                Console.WriteLine("Введите 4 для входа в режим работы с векторами");
                Console.WriteLine("Введите 5 для входа в режим работы с комплексными числами");
                Console.WriteLine("Введите 6 для входа в режим работы со множетсвами");
                Console.WriteLine("Введите 0 для выхода из программы");
                int z = Convert.ToInt32(Checks.CheckSingleInput());
                switch (z)
                {
                    case 1:
                        {
    
                            Dot doti1, doti2, doti3;
                            Console.WriteLine("Введите координату x точки A");
                            doti1.x = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                            Console.WriteLine("Введите координату y точки A");
                            doti1.y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                            Console.WriteLine("Введите координату x точки B");
                            doti2.x = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                            Console.WriteLine("Введите координату y точки B");
                            doti2.y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                            Console.WriteLine("Введите координату x точки C");
                            doti3.x = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                            Console.WriteLine("Введите координату y точки C");
                            doti3.y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                            Triangle t = new Triangle(doti1, doti2, doti3);
                            if (t.LengthAB + t.LengthBC <= t.LengthAC || t.LengthAB + t.LengthAC <= t.LengthBC || t.LengthAC + t.LengthBC <= t.LengthAB)
                            {
                                Console.WriteLine("Полученный треугольник не удовлетворяет неравенству Минковского, работать с ним не получится");
                                break;
                            }
                            int k = 42;
                            while (true)
                            {
                                if (k == 0)
                                {
                                    break;
                                }
                                Console.WriteLine("Введите 1 для вывода координат стороны АВ,2 для вывода координат стороны BC");
                                Console.WriteLine("Введите 3 для вывода координат стороны AC,4 для вывода длины АВ");
                                Console.WriteLine("Введите 5 для вывода длины ВС,6 для вывода длины АС");
                                Console.WriteLine("Введите 7 для вывода угла А, 8 для вывода угла В");
                                Console.WriteLine("Введите 9 для вывода угла С, 10 для вывода периметра треугольника");
                                Console.WriteLine("Введите 11 для вывода площади треугольника, 12 для вывода радиуса вписанной в треугольник окружности ");
                                Console.WriteLine("Введите 13 для вывода радиуса описанной около треугольника окружности, 14 для выхода из режима");
                                int a = Convert.ToInt32(Checks.CheckSingleInput());
                                switch (a)
                                {
                                    case 1: Console.WriteLine("Координата x:{0:0.00}", t.CoordinatesAB.x); Console.WriteLine("Координата y:{0:0.00}", t.CoordinatesAB.y); break;
                                    case 2: Console.WriteLine("Координата x:{0:0.00}", t.CoordinatesBC.x); Console.WriteLine("Координата y:{0:0.00}", t.CoordinatesBC.y); break;
                                    case 3: Console.WriteLine("Координата x:{0:0.00}", t.CoordinatesAC.x); Console.WriteLine("Координата y:{0:0.00}", t.CoordinatesAC.y); break;
                                    case 4: Console.WriteLine("Длина АВ:{0:0.00}", t.LengthAB); break;
                                    case 5: Console.WriteLine("Длина ВС:{0:0.00}", t.LengthBC); break;
                                    case 6: Console.WriteLine("Длина АС:{0:0.00}", t.LengthAC); break;
                                    case 7: Console.WriteLine("Угол А:{0:0.00}", t.AngleA); break;
                                    case 8: Console.WriteLine("Угол B:{0:0.00}", t.AngleB); break;
                                    case 9: Console.WriteLine("Угол C:{0:0.00}", t.AngleC); break;
                                    case 10: Console.WriteLine("Периметр:{0:0.00}", t.Perimetr); break;
                                    case 11: Console.WriteLine("Площадь:{0:0.00}", t.Area); break;
                                    case 12: Console.WriteLine("Радиус вписанной окружности:{0:0.00}", t.RadiusOfSmallCircle); break;
                                    case 13: Console.WriteLine("Радиус описанной окружности:{0:0.00}", t.RadiusOfBigCircle); break;
                                    case 14: k = 0; break;
                                    default: Console.WriteLine("Вы ввели что-то не то"); break;
                                }
                            }
                            break;
                        }

                    case 2:
                        {
                            int k = 42;
                            while (true)
                            {
                                if (k == 0)
                                {
                                    break;
                                }
                                Console.WriteLine("Введите 1 для вывода суммы двух матриц");
                                Console.WriteLine("Введите 2 для вывода разности двух матриц");
                                Console.WriteLine("Введите 3 для вывода умножения двух матриц");
                                Console.WriteLine("Введите 4 для вывода умножения матрицы на число");
                                Console.WriteLine("Введите 5 для вывода деления матрицы на число");
                                Console.WriteLine("Введите 6 для вывода следа матрицы");
                                Console.WriteLine("Введите 7 для вывода определителя матрицы");
                                Console.WriteLine("Введите 8 для вывода транспонированной матрицы");
                                Console.WriteLine("Введите 9 для вывода обратной матрицы");
                                Console.WriteLine("Введите 10 для перехода матрицы к новому базису");
                                Console.WriteLine("Введите 11 для решения системы линейных уравнений");
                                Console.WriteLine("Введите 12 для выхода из режима");
                                int a = Convert.ToInt32(Checks.CheckSingleInput());
                                switch (a)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Введите количество строк матрицы");
                                            int n = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (n <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                n = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            Console.WriteLine("Введите количество столбцов матрицы");
                                            int m = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (m <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                m = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            double[,] x = new double[n, m];
                                            Console.WriteLine("Введите матрицу");
                                            for (int i = 0; i < n;)
                                            {
                                                for (int j = 0; j < m;)
                                                {
                                                    if (i >= x.GetLength(0))
                                                    {
                                                        break;
                                                    }
                                                    Checks.CheckMultipleDoubleInput(x, ref i, ref j);
                                                }
                                            }
                                            Console.WriteLine("Введите матрицу для сложения размерности {0}x{1}", x.GetLength(0), x.GetLength(1));
                                            double[,] b = new double[x.GetLength(0), x.GetLength(1)];
                                            for (int i = 0; i < b.GetLength(0);)
                                            {
                                                for (int j = 0; j < b.GetLength(1);)
                                                {
                                                    if (i >= b.GetLength(0))
                                                    {
                                                        break;
                                                    }
                                                    Checks.CheckMultipleDoubleInput(b, ref i, ref j);
                                                }
                                            }
                                            Console.WriteLine("Матрица после сложения:");
                                            WorkWithMatrix.MatrixAddition(x, b);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Введите количество строк матрицы");
                                            int n = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (n <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                n = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            Console.WriteLine("Введите количество столбцов матрицы");
                                            int m = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (m <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                m = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            double[,] x = new double[n, m];
                                            Console.WriteLine("Введите матрицу");
                                            for (int i = 0; i < n;)
                                            {
                                                for (int j = 0; j < m;)
                                                {
                                                    if (i >= x.GetLength(0))
                                                    {
                                                        break;
                                                    }
                                                    Checks.CheckMultipleDoubleInput(x, ref i, ref j);
                                                }
                                            }
                                            Console.WriteLine("Введите матрицу для разности размерности {0}x{1}", x.GetLength(0), x.GetLength(1));
                                            double[,] b = new double[x.GetLength(0), x.GetLength(1)];
                                            for (int i = 0; i < b.GetLength(0);)
                                            {
                                                for (int j = 0; j < b.GetLength(1);)
                                                {
                                                    if (i >= b.GetLength(0))
                                                    {
                                                        break;
                                                    }
                                                    Checks.CheckMultipleDoubleInput(b, ref i, ref j);
                                                }
                                            }
                                            Console.WriteLine("Матрица после разности");
                                            WorkWithMatrix.MatrixSubstraction(x, b);
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("Введите количество строк матрицы");
                                            int n = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (n <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                n = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            Console.WriteLine("Введите количество столбцов матрицы");
                                            int m = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (m <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                m = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            double[,] x = new double[n, m];
                                            Console.WriteLine("Введите матрицу");
                                            for (int i = 0; i < n;)
                                            {
                                                for (int j = 0; j < m;)
                                                {
                                                    if (i >= x.GetLength(0))
                                                    {
                                                        break;
                                                    }
                                                    Checks.CheckMultipleDoubleInput(x, ref i, ref j);
                                                }
                                            }
                                            Console.WriteLine("Введите количество столбцов матрицы для умножения");
                                            int n1 = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (n <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                n1 = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            Console.WriteLine("Введите матрицу для умножения размерности {0}x{1}", x.GetLength(1),n1);
                                            double[,] b = new double[x.GetLength(1),n1];
                                            for (int i = 0; i < b.GetLength(0);)
                                            {
                                                for (int j = 0; j < n1;)
                                                {
                                                    if (i >= b.GetLength(0))
                                                    {
                                                        break;
                                                    }
                                                    Checks.CheckMultipleDoubleInput(b, ref i, ref j);
                                                }
                                            }
                                            Console.WriteLine("Матрица после умножения:");
                                            WorkWithMatrix.MatrixAddition(x, b);
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.WriteLine("Введите количество строк матрицы");
                                            int n = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (n <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                n = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            Console.WriteLine("Введите количество столбцов матрицы");
                                            int m = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (m <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                m = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            double[,] x = new double[n, m];
                                            Console.WriteLine("Введите матрицу");
                                            for (int i = 0; i < n;)
                                            {
                                                for (int j = 0; j < m;)
                                                {
                                                    if (i >= x.GetLength(0))
                                                    {
                                                        break;
                                                    }
                                                    Checks.CheckMultipleDoubleInput(x, ref i, ref j);
                                                }
                                            }
                                            Console.WriteLine("Введите число, на которое нужно умножать");
                                            double b = Convert.ToDouble(Checks.CheckSingleDoubleInput());
             
                                            Console.WriteLine("Матрица после умножения на число");
                                            WorkWithMatrix.MatrixMultiplicationByNumber(x, b);
                                            break;
                                        }
                                    case 5:
                                        {
                                            Console.WriteLine("Введите количество строк матрицы");
                                            int n = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (n <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                n = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            Console.WriteLine("Введите количество столбцов матрицы");
                                            int m = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (m <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                m = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            double[,] x = new double[n, m];
                                            Console.WriteLine("Введите матрицу");
                                            for (int i = 0; i < n;)
                                            {
                                                for (int j = 0; j < m;)
                                                {
                                                    if (i >= x.GetLength(0))
                                                    {
                                                        break;
                                                    }
                                                    Checks.CheckMultipleDoubleInput(x, ref i, ref j);
                                                }
                                            }
                                            Console.WriteLine("Введите число, на которое нужно делить !=0");
                                            double b = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            while (b == 0)
                                            {
                                                Console.WriteLine("Введите не 0");
                                                b = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            }
                                            Console.WriteLine("Матрица после деления на число");
                                            WorkWithMatrix.MatrixDivisionByNumber(x, b);
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.WriteLine("Введите порядок матрицы");
                                            int n = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (n <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                n = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            double[,] x = new double[n, n];
                                            Console.WriteLine("Введите матрицу");
                                            for (int i = 0; i < n;)
                                            {
                                                for (int j = 0; j < n;)
                                                {
                                                    if (i >= x.GetLength(0))
                                                    {
                                                        break;
                                                    }
                                                    Checks.CheckMultipleDoubleInput(x, ref i, ref j);
                                                }
                                            }
                                            WorkWithMatrix.MatrixTr(x);
                                            break;
                                        }
                                    case 7:
                                        {
                                            Console.WriteLine("Введите порядок матрицы");
                                            int n = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (n <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                n = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            double[,] x = new double[n, n];
                                            Console.WriteLine("Введите матрицу");
                                            for (int i = 0; i < n;)
                                            {
                                                for (int j = 0; j < n;)
                                                {
                                                    if (i >= x.GetLength(0))
                                                    {
                                                        break;
                                                    }
                                                    Checks.CheckMultipleDoubleInput(x, ref i, ref j);
                                                }
                                            }
                                            double det=WorkWithMatrix.Determinant(x);
                                            Console.WriteLine("Определитель матрицы:{0}", det);
                                            break;
                                        }
                                    case 8:
                                        {
                                            Console.WriteLine("Введите порядок матрицы");
                                            int n = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (n <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                n = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            double[,] x = new double[n, n];
                                            Console.WriteLine("Введите матрицу");
                                            for (int i = 0; i < n;)
                                            {
                                                for (int j = 0; j < n;)
                                                {
                                                    if (i >= x.GetLength(0))
                                                    {
                                                        break;
                                                    }
                                                    Checks.CheckMultipleDoubleInput(x, ref i, ref j);
                                                }
                                            }
                                            Console.WriteLine("Транспонированная матрица");
                                            WorkWithMatrix.MatrixTranspose(x);
                                            break;
                                        }
                                    case 9:
                                        {
                                            Console.WriteLine("Введите порядок матрицы");
                                            int n = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (n <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                n = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            double[,] x = new double[n, n];
                                            Console.WriteLine("Введите матрицу");
                                            for (int i = 0; i < n;)
                                            {
                                                for (int j = 0; j < n;)
                                                {
                                                    if (i >= x.GetLength(0))
                                                    {
                                                        break;
                                                    }
                                                    Checks.CheckMultipleDoubleInput(x, ref i, ref j);
                                                }
                                            }
                                            double det = WorkWithMatrix.Determinant(x);
                                            if (det == 0)
                                            {
                                                Console.WriteLine("Обратной матрицы нет");
                                                break;
                                            }
                                            Console.WriteLine("Обратная матрица");
                                            WorkWithMatrix.InverseMatrix(x);
                                            break;
                                        }
                                    case 10:
                                        {
                                            Console.WriteLine("Введите порядок матрицы");
                                            int n = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (n <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                n = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            double[,] x = new double[n, n];
                                            Console.WriteLine("Введите матрицу");
                                            for (int i = 0; i < n;)
                                            {
                                                for (int j = 0; j < n;)
                                                {
                                                    if (i >= x.GetLength(0))
                                                    {
                                                        break;
                                                    }
                                                    Checks.CheckMultipleDoubleInput(x, ref i, ref j);
                                                }
                                            }
                                            double[,] y = new double[n, n];
                                            Console.WriteLine("Введите матрицу перехода порядка {0}", n);
                                            for (int i = 0; i < n;)
                                            {
                                                for (int j = 0; j < n;)
                                                {
                                                    if (i >= y.GetLength(0))
                                                    {
                                                        break;
                                                    }
                                                    Checks.CheckMultipleDoubleInput(y, ref i, ref j);
                                                }
                                            }
                                            double det = WorkWithMatrix.Determinant(y);
                                            if (det == 0)
                                            {
                                                Console.WriteLine("Невозможно перейти к новым координатам, т.к. матрица перехода вырожденная");
                                                break;
                                            }
                                            WorkWithMatrix.TransitionToNewCoordinates(y,x);
                                            break;
                                        }
                                    case 11:
                                        {
                                            Console.WriteLine("Введите порядок матрицы коэффициентов уравнений");
                                            int n = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (n <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                n = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            double[,] x = new double[n, n];
                                            Console.WriteLine("Введите матрицу коэффициентов уравнений");
                                            for (int i = 0; i < n;)
                                            {
                                                for (int j = 0; j < n;)
                                                {
                                                    if (i >= x.GetLength(0))
                                                    {
                                                        break;
                                                    }
                                                    Checks.CheckMultipleDoubleInput(x, ref i, ref j);
                                                }
                                            }
                                            double[,] y = new double[n, 1];
                                            Console.WriteLine("Введите вектор значений уравнений", n);
                                            for (int i = 0; i < n;)
                                            {
                                                for (int j = 0; j < 1;)
                                                {
                                                    if (i >= y.GetLength(0))
                                                    {
                                                        break;
                                                    }
                                                    Checks.CheckMultipleDoubleInput(y, ref i, ref j);
                                                }
                                            }
                                            double det = WorkWithMatrix.Determinant(x);
                                            if (det == 0)
                                            {
                                                Console.WriteLine("Невозможно решить систему, т.к. матрица коэффициентов вырожденная");
                                                break;
                                            }
                                            WorkWithMatrix.SolvingSystemsOfLinearEquations(x, y);
                                            break;
                                        }
                                    case 12: k = 0; break;
                                    default: Console.WriteLine("Вы ввели что-то не то");  break;
                                }
                            }
                            break;
                        }
                        case 3:
                        {
                            int k = 42;
                            while (true)
                            {
                                if (k == 0)
                                {
                                    break;
                                }
                                Console.WriteLine("Введите 1 для вывода НОДа двух чисел");
                                Console.WriteLine("Введите 2 для вывода НОКа двух чисел");
                                Console.WriteLine("Введите 3 для реализации алгоритма решета Эратосфена");
                                Console.WriteLine("Введите 4 для выхода из режима");
                                int a = Convert.ToInt32(Checks.CheckSingleInput());
                                switch (a)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Введите первое число");
                                            int b = Convert.ToInt32(Checks.CheckSingleInput());
                                            Console.WriteLine("Введите второе число");
                                            int x = Convert.ToInt32(Checks.CheckSingleInput());
                                            int nod = Algorithms.NOD(x, b);
                                            Console.WriteLine("НОД двух чисел:{0}",nod);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Введите первое число");
                                            int b = Convert.ToInt32(Checks.CheckSingleInput());
                                            Console.WriteLine("Введите второе число");
                                            int x = Convert.ToInt32(Checks.CheckSingleInput());
                                            int nok = Algorithms.NOK(x, b);
                                            Console.WriteLine("НОК двух чисел:{0}", nok);
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("Введите число до которого нужно выводить простые числа");
                                            int b = Convert.ToInt32(Checks.CheckSingleInput());
                                            Algorithms.SieveOfEratosthenes(b);
                                            break;
                                        }
                                    case 4: k = 0; break;
                                    default: Console.WriteLine("Вы ввели что-то не то"); break;
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            int k = 42;
                            while (true)
                            {
                                if (k == 0)
                                {
                                    break;
                                }
                                Console.WriteLine("Введите 1 для нахождения суммы двух векторов");
                                Console.WriteLine("Введите 2 для нахождения длины вектора");
                                Console.WriteLine("Введите 3 для нахождения орта вектора");
                                Console.WriteLine("Введите 4 для нахождения разности двух векторов");
                                Console.WriteLine("Введите 5 для нахождения скалярного произведения двух векторов");
                                Console.WriteLine("Введите 6 для нахождения умножения вектора на число");
                                Console.WriteLine("Введите 7 для нахождения деления вектора на число");
                                Console.WriteLine("Введите 8 для нахождения направляющих косинусов вектора");
                                Console.WriteLine("Введите 9 для нахождения координат вектора по двум точкам");
                                Console.WriteLine("Введите 10 для нахождения длины вектора по двум точкам");
                                Console.WriteLine("Введите 11 для нахождения точки, делящий отрезок в заданном отношении");
                                Console.WriteLine("Введите 12 для нахождения угла между векторами");
                                Console.WriteLine("Введите 13 для нахождения косинуса вгла между векторами");
                                Console.WriteLine("Введите 14 для нахождения проекции вектора на вектор");
                                Console.WriteLine("Введите 15 для нахождения вектора ортогонального двум данным");
                                Console.WriteLine("Введите 16 для составления уравнения прямой по двум точкам");
                                Console.WriteLine("Введите 17 для составления уравнения плоскости по нормальному вектору и точке");
                                Console.WriteLine("Введите 18 для составления уравнения плоскости по двум векторам и точке");
                                Console.WriteLine("Введите 19 для составления уравнения плоскости по трём точкам");
                                Console.WriteLine("Введите 20 для нахождения расстояния от точки до плоскости");
                                Console.WriteLine("Введите 21 для нахождения проекции точки на плоскость");
                                Console.WriteLine("Введите 22 чтобы узнать параллельны ли плоскости");
                                Console.WriteLine("Введите 23 чтобы узнать перпендикулярны ли плоскости");
                                Console.WriteLine("Введите 24 чтобы узнать параллельны ли прямые");
                                Console.WriteLine("Введите 25 чтобы узнать перпендикулярны ли прямые");
                                Console.WriteLine("Введите 26 чтобы узнать перпендикулярны ли прямая и плоскость");
                                Console.WriteLine("Введите 27 чтобы узнать параллельны ли прямая и плоскость");
                                Console.WriteLine("Введите 28 для нахождения угла между плоскостями");
                                Console.WriteLine("Введите 29 для нахождения угла между плоскостью и прямой");
                                Console.WriteLine("Введите 30 для нахождения расстояния между срещивающимися прямыми");
                                Console.WriteLine("Введите 31 для нахождения векторного произведения двух векторов");
                                Console.WriteLine("Введите 32 для нахождения смешанного произведения двух векторов");
                                Console.WriteLine("Введите 33 для реализации процесса ортогонализации Грамма-Шмидта");
                                Console.WriteLine("Введите 34 для выхода из режима");
                                int a = Convert.ToInt32(Checks.CheckSingleInput());
                                switch (a)
                                {
                                    case 1:
                                        {
                                            Vector l; 
                                            Vector r;
                                            Console.WriteLine("Введите координату i левого вектора");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j левого вектора");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k левого вектора");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i правого вектора");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j правого вектора");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k правого вектора");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.VectorAddition(l, r);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Vector l;
                                            Console.WriteLine("Введите координату i  вектора");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j  вектора");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k  вектора");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.VectorLength(l);
                                            break;
                                        }
                                    case 3:
                                        {
                                            Vector l;
                                            Console.WriteLine("Введите координату i  вектора");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j  вектора");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k  вектора");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.VectorOrt(l);
                                            break;
                                        }
                                    case 4:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i левого вектора");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j левого вектора");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k левого вектора");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i правого вектора");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j правого вектора");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k правого вектора");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.VectorSubsraction(l, r);
                                            break;
                                        }
                                    case 5:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i левого вектора");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j левого вектора");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k левого вектора");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i правого вектора");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j правого вектора");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k правого вектора");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.VectorScalarMultiplication(l, r);
                                            break;
                                        }
                                    case 6:
                                        {
                                            Vector l;
                                            Console.WriteLine("Введите координату i  вектора");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j  вектора");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k  вектора");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите число для умножения");
                                            double w = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.VectorMultiplicationNumber(l,w);
                                            break;
                                        }
                                    case 7:
                                        {
                                            Vector l;
                                            Console.WriteLine("Введите координату i  вектора");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j  вектора");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k  вектора");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите число, на которое нужно делить !=0");
                                            double b = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            while (b == 0)
                                            {
                                                Console.WriteLine("Введите не 0");
                                                b = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            }
                                            WorkWithVectors.VectorDivisionNumber(l, b);
                                            break;
                                        }
                                    case 8:
                                        {
                                            Vector l;
                                            Console.WriteLine("Введите координату i  вектора");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j  вектора");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k  вектора");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.VectorGuideCosines(l);
                                            break;
                                        }
                                    case 9:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i первой точки");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j первой точки");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k первой точки");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i второй точки");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j второй точки");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k второй точки");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.VectorCoordinates(l, r);
                                            break;
                                        }
                                    case 10:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i первой точки");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j первой точки");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k первой точки");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i второй точки");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j второй точки");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k второй точки");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.SegmentLength(l, r);
                                            break;
                                        }
                                    case 11:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i первой точки");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j первой точки");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k первой точки");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i второй точки");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j второй точки");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k второй точки");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите отношение деления");
                                            int n = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (n <= 0)
                                            {
                                                Console.WriteLine("Введите правильное отношение деления");
                                                n = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            WorkWithVectors.DivisionOfSegment(l, r,n);
                                            break;
                                        }
                                    case 12:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i левого вектора");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j левого вектора");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k левого вектора");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i правого вектора");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j правого вектора");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k правого вектора");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.AngleBetweenTwoVectors(l, r);
                                            break;
                                        }
                                    case 13:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i левого вектора");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j левого вектора");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k левого вектора");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i правого вектора");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j правого вектора");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k правого вектора");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.CosOfAngleBetweenTwoVectors(l, r);
                                            break;
                                        }
                                    case 14:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i левого вектора");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j левого вектора");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k левого вектора");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i правого вектора");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j правого вектора");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k правого вектора");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.ProectionOfVectorOnOtherVector(l, r);
                                            break;
                                        }
                                    case 15:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i левого вектора");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j левого вектора");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k левого вектора");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i правого вектора");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j правого вектора");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k правого вектора");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.VectorOrthogonalToTwo(l, r);
                                            break;
                                        }
                                    case 16:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i первой точки");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j первой точки");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k первой точки");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i второй точки");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j второй точки");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k второй точки");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.TwoPoinLineEquation(l, r);
                                            break;
                                        }
                                    case 17:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i точки");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j точки");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k точки");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i нормального вектора");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j нормального вектора");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k нормального вектора");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.PointAndVectorPlaneEquation(l, r);
                                            break;
                                        }
                                    case 18:
                                        {
                                            Vector l;
                                            Vector r;
                                            Vector q;
                                            Console.WriteLine("Введите координату i левого вектора");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j левого вектора");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k левого вектора");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i правого вектора");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j правого вектора");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k правого вектора");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i точки");
                                            q.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j точки");
                                            q.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k точки");
                                            q.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.TwoVectorsAndPointPlaneEquation(l, r, q);
                                            break;
                                        }
                                    case 19:
                                        {
                                            Vector l;
                                            Vector r;
                                            Vector q;
                                            Console.WriteLine("Введите координату i первой точки");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j первой точки");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k первой точки");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i второй точки");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j второй точки");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k второй точки");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i третьей точки");
                                            q.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j третьей точки");
                                            q.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k третьей точки");
                                            q.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.ThreePointsPlaneEquation(l, r, q);
                                            break;
                                        }
                                    case 20:
                                        {
                                            Vector l;
                                            Vector r;
                                            Vector q;
                                            Console.WriteLine("Введите координату i вектора плоскости");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j вектора плоскости");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k вектора плоскости");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i точки плоскости");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j точки плоскости");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k точки плоскости");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i данной точки");
                                            q.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j данной точки");
                                            q.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k данной точки");
                                            q.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.DistanseFromPointToPlane(l, r, q);
                                            break;
                                        }
                                    case 21:
                                        {
                                            Vector l;
                                            Vector r;
                                            Vector q;
                                            Console.WriteLine("Введите координату i вектора плоскости");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j вектора плоскости");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k вектора плоскости");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i точки плоскости");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j точки плоскости");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k точки плоскости");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i данной точки");
                                            q.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j данной точки");
                                            q.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k данной точки");
                                            q.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.ProectionOfPointOnPlane(l, r, q);
                                            break;
                                        }
                                    case 22:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i нормального вектора первой плоскости");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j нормального вектора первой плоскости");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k нормального вектора первой плоскости");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i нормального вектора второй плоскости");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j нормального вектора второй плоскости");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k нормального вектора второй плоскости");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            if(WorkWithVectors.IsLineAndPlaneParallel(l, r))
                                            {
                                                Console.WriteLine("Плоскости параллельны");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Плоскости не параллельны");
                                            }
                                            break;
                                        }
                                    case 23:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i нормального вектора первой плоскости");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j нормального вектора первой плоскости");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k нормального вектора первой плоскости");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i нормального вектора второй плоскости");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j нормального вектора второй плоскости");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k нормального вектора второй плоскости");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            if (WorkWithVectors.IsPlanesPerpendicular(l, r))
                                            {
                                                Console.WriteLine("Плоскости перепендикулярны");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Плоскости не перепендикулярны");
                                            }
                                            break;
                                        }
                                    case 24:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i направляющего вектора первой прямой");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j направляющего вектора первой прямой");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k направляющего вектора первой прямой");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i направляющего вектора второй прямой");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j направляющего вектора второй прямой");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k направляющего вектора второй прямой");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            if (WorkWithVectors.IsLinesParallel(l, r))
                                            {
                                                Console.WriteLine("Прямые параллельны");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Прямые не параллельны");
                                            }
                                            break;
                                        }
                                    case 25:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i направляющего вектора первой прямой");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j направляющего вектора первой прямой");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k направляющего вектора первой прямой");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i направляющего вектора второй прямой");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j направляющего вектора второй прямой");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k направляющего вектора второй прямой");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            if (WorkWithVectors.IsLinesPerpendicular(l, r))
                                            {
                                                Console.WriteLine("Прямые перпендикулярны");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Прямые не перпендикулярны");
                                            }
                                            break;
                                        }
                                    case 26:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i направляющего вектора прямой");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j направляющего вектора прямой");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k направляющего вектора прямой");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i нормального вектора плоскости");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j нормального вектора плоскости");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k нормального вектора плоскости");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            if (WorkWithVectors.IsLineAndPlaneParallel(l, r))
                                            {
                                                Console.WriteLine("Прямая и плоскость параллельны");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Прямая и плоскость не параллельны");
                                            }
                                            break;
                                        }
                                    case 27:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i направляющего вектора прямой");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j направляющего вектора прямой");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k направляющего вектора прямой");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i нормального вектора плоскости");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j нормального вектора плоскости");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k нормального вектора плоскости");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            if (WorkWithVectors.IsLineAndPlanePerpendicular(l, r))
                                            {
                                                Console.WriteLine("Прямая и плоскость перпендикулярны");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Прямая и плоскость не перпендикулярны");
                                            }
                                            break;
                                        }
                                    case 28:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i нормального вектора первой плоскости");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j нормального вектора первой плоскости");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k нормального вектора первой плоскости");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i нормального вектора второй плоскости");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j нормального вектора второй плоскости");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k нормального вектора второй плоскости");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.AngleBetweenPlanes(l, r);
                                            break;
                                        }
                                    case 29:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i направляющего вектора прямой");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j направляющего вектора прямой");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k направляющего вектора прямой");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i нормального вектора плоскости");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j нормального вектора плоскости");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k нормального вектора плоскости");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.AngleBetweenLineAndPlane(l, r);
                                            break;
                                        }
                                    case 30:
                                        {
                                            Vector l;
                                            Vector r;
                                            Vector M;
                                            Vector M1;
                                            Console.WriteLine("Введите координату i направляющего вектора первой прямой");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j направляющего вектора первой прямой");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k направляющего вектора первой прямой");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i направляющего вектора второй прямой");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j направляющего вектора второй прямой");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k направляющего вектора второй прямой");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i точки первой прямой");
                                            M.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j точки первой прямой");
                                            M.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k точки первой  прямой");
                                            M.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i точки второй прямой");
                                            M1.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j точки второй прямой");
                                            M1.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k точки второй прямой");
                                            M1.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.DistanceBetweenCrossingLines(l, M, r, M1);
                                            break;
                                        }
                                    case 31:
                                        {
                                            Vector l;
                                            Vector r;
                                            Console.WriteLine("Введите координату i левого вектора");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j левого вектора");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k левого вектора");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i правого вектора");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j правого вектора");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k правого вектора");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.VectorMultiplicationOfTwoVectors(l, r);
                                            break;
                                        }
                                    case 32:
                                        {
                                            Vector l;
                                            Vector r;
                                            Vector q;
                                            Console.WriteLine("Введите координату i первого вектора");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j первого вектора");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k первого вектора");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i второго вектора");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j второго вектора");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k второго вектора");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i третьего вектора");
                                            q.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j третьего вектора");
                                            q.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k третьего вектора");
                                            q.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.MixedMultiplicationOfTwoVectors(l, r,q);
                                            break;
                                        }
                                    case 33:
                                        {
                                            Vector l;
                                            Vector r;
                                            Vector q;
                                            Console.WriteLine("Введите координату i первого вектора");
                                            l.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j первого вектора");
                                            l.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k первого вектора");
                                            l.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i второго вектора");
                                            r.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j второго вектора");
                                            r.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k второго вектора");
                                            r.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату i третьего вектора");
                                            q.i = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату j третьего вектора");
                                            q.j = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите координату k третьего вектора");
                                            q.k = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            WorkWithVectors.GramSchmidtOrthogonalizationProcess(l, r, q);
                                            break;
                                        }
                                    case 34: k = 0; break;
                                    default: Console.WriteLine("Вы ввели что-то не то"); break;
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            int k = 42;
                            while (true)
                            {
                                if (k == 0)
                                {
                                    break;
                                }
                                Console.WriteLine("Введите 1 для сложения двух комплексных чисел");
                                Console.WriteLine("Введите 2 для вычитания двух комплексных чисел");
                                Console.WriteLine("Введите 3 для умножения двух комплексных чисел");
                                Console.WriteLine("Введите 4 для деления двух комплексных чисел");
                                Console.WriteLine("Введите 5 для нахождения длины комплексного числа");
                                Console.WriteLine("Введите 6 для нахождения сопряжённого комплексного числа");
                                Console.WriteLine("Введите 7 для нахождения корня n-ой степени их комплексного числа");
                                Console.WriteLine("Введите 8 для выхода из режима");
                                int a = Convert.ToInt32(Checks.CheckSingleInput());
                                switch (a)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Введите действительную часть левого числа");
                                            double x1 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите мнимую часть лправого числа");
                                            double y1 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите действительную часть левого числа");
                                            double x2 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите мнимую часть правого числа");
                                            double y2 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            ComplexNumber.AdditionNumbers(x1, y1, x2, y2);
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Введите действительную часть левого числа");
                                            double x1 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите мнимую часть лправого числа");
                                            double y1 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите действительную часть левого числа");
                                            double x2 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите мнимую часть правого числа");
                                            double y2 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            ComplexNumber.SubstractionNumbers(x1, y1, x2, y2);
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("Введите действительную часть левого числа");
                                            double x1 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите мнимую часть лправого числа");
                                            double y1 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите действительную часть левого числа");
                                            double x2 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите мнимую часть правого числа");
                                            double y2 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            ComplexNumber.MultiplicationNumbers(x1, y1, x2, y2);
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.WriteLine("Введите действительную часть левого числа");
                                            double x1 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите мнимую часть лправого числа");
                                            double y1 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите действительную часть левого числа");
                                            double x2 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите мнимую часть правого числа");
                                            double y2 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            ComplexNumber.DivisionNumbers(x1, y1, x2, y2);
                                            break;
                                        }
                                    case 5:
                                        {
                                            Console.WriteLine("Введите действительную часть числа");
                                            double x1 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите мнимую часть числа");
                                            double y1 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            ComplexNumber.LengthOfNumber(x1, y1);
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.WriteLine("Введите действительную часть числа");
                                            double x1 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите мнимую часть числа");
                                            double y1 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            ComplexNumber.СonjugateNumber(x1, y1);
                                            break;
                                        }
                                    case 7:
                                        {
                                            Console.WriteLine("Введите действительную часть числа");
                                            double x1 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите мнимую часть числа");
                                            double y1 = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            Console.WriteLine("Введите стпень корня");
                                            int n = Convert.ToInt32(Checks.CheckSingleInput());
                                            ComplexNumber.RootExtracingOfNumber(x1, y1, n);
                                            break;
                                        }
                                    case 8: k = 0; break;
                                    default: Console.WriteLine("Вы ввели что-то не то"); break;
                                }
                            }
                            break;
                        }
                    case 6:
                        {
                            int k = 42;
                            while (true)
                            {
                                if (k == 0)
                                {
                                    break;
                                }
                                Console.WriteLine("Введите 1 для нахождения пересечения двух множеств");
                                Console.WriteLine("Введите 2 для нахождения объединения двух множеств");
                                Console.WriteLine("Введите 3 для нахождения разности двух множеств");
                                Console.WriteLine("Введите 4 для нахождения симметрической разности двух множетсв");
                                Console.WriteLine("Введите 5 для выхода из режима");
                                int a = Convert.ToInt32(Checks.CheckSingleInput());
                                switch (a)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Введите количество элементов первого множества");
                                            int n = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (n <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                n = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            double[] b = new double[n];
                                            for(int i = 0; i < n; i++)
                                            {
                                                b[i] = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            }
                                            Console.WriteLine("Введите количество элементов первого множества");
                                            int m = Convert.ToInt32(Checks.CheckSingleInput());
                                            while (m <= 0)
                                            {
                                                Console.WriteLine("Введите правильную размерность");
                                                m = Convert.ToInt32(Checks.CheckSingleInput());
                                            }
                                            double[] c = new double[m];
                                            for (int i = 0; i < n; i++)
                                            {
                                                c[i] = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                            }
                                            WorkWithSets.IntersectionOfSets(b, c);
                                            break;
                                        }
                                    case 2:
                                        {
                                            {
                                                Console.WriteLine("Введите количество элементов первого множества");
                                                int n = Convert.ToInt32(Checks.CheckSingleInput());
                                                while (n <= 0)
                                                {
                                                    Console.WriteLine("Введите правильную размерность");
                                                    n = Convert.ToInt32(Checks.CheckSingleInput());
                                                }
                                                double[] b = new double[n];
                                                for (int i = 0; i < n; i++)
                                                {
                                                    b[i] = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                                }
                                                Console.WriteLine("Введите количество элементов первого множества");
                                                int m = Convert.ToInt32(Checks.CheckSingleInput());
                                                while (m <= 0)
                                                {
                                                    Console.WriteLine("Введите правильную размерность");
                                                    m = Convert.ToInt32(Checks.CheckSingleInput());
                                                }
                                                double[] c = new double[m];
                                                for (int i = 0; i < n; i++)
                                                {
                                                    c[i] = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                                }
                                                WorkWithSets.UnionOfSets(b, c);
                                                break;
                                            }
                                        }
                                    case 3:
                                        {
                                            {
                                                Console.WriteLine("Введите количество элементов первого множества");
                                                int n = Convert.ToInt32(Checks.CheckSingleInput());
                                                while (n <= 0)
                                                {
                                                    Console.WriteLine("Введите правильную размерность");
                                                    n = Convert.ToInt32(Checks.CheckSingleInput());
                                                }
                                                double[] b = new double[n];
                                                for (int i = 0; i < n; i++)
                                                {
                                                    b[i] = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                                }
                                                Console.WriteLine("Введите количество элементов первого множества");
                                                int m = Convert.ToInt32(Checks.CheckSingleInput());
                                                while (m <= 0)
                                                {
                                                    Console.WriteLine("Введите правильную размерность");
                                                    m = Convert.ToInt32(Checks.CheckSingleInput());
                                                }
                                                double[] c = new double[m];
                                                for (int i = 0; i < n; i++)
                                                {
                                                    c[i] = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                                }
                                                WorkWithSets.DifferenceOfSets(b, c);
                                                break;
                                            }
                                        }
                                    case 4:
                                        {
                                            {
                                                Console.WriteLine("Введите количество элементов первого множества");
                                                int n = Convert.ToInt32(Checks.CheckSingleInput());
                                                while (n <= 0)
                                                {
                                                    Console.WriteLine("Введите правильную размерность");
                                                    n = Convert.ToInt32(Checks.CheckSingleInput());
                                                }
                                                double[] b = new double[n];
                                                for (int i = 0; i < n; i++)
                                                {
                                                    b[i] = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                                }
                                                Console.WriteLine("Введите количество элементов первого множества");
                                                int m = Convert.ToInt32(Checks.CheckSingleInput());
                                                while (m <= 0)
                                                {
                                                    Console.WriteLine("Введите правильную размерность");
                                                    m = Convert.ToInt32(Checks.CheckSingleInput());
                                                }
                                                double[] c = new double[m];
                                                for (int i = 0; i < n; i++)
                                                {
                                                    c[i] = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                                }
                                                WorkWithSets.SymmetricDifferenceOfSets(b, c);
                                                break;
                                            }
                                        }
                                    case 5: k = 0; break;
                                    default: Console.WriteLine("Вы ввели что-то не то"); break;
                                }
                            }
                            break;
                        }
                    case 0: return;
                    default: Console.WriteLine("Вы ввели что-то не то"); break;
                }
            }
    }
        
    }
}
