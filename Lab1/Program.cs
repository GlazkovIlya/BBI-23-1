public class Program
{
    class Project
    {
        public static void output(double[,] arr, int a, int b)
        {
            Console.WriteLine("Итоговая матрица: ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static int[] MaxMtrx(double[,] mtrx, int a, int b)
        {
            double max = int.MinValue;
            int[] array = new int[2];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (mtrx[i, j] > max)
                    {
                        max = mtrx[i, j];
                        array[1] = j;
                        array[0] = i;
                    }
                }
            }
            return array;
        }
        public static int MaxMtrxLine(double[,] mtrx, int a, int b)
        {
            int I = 0;
            double sum = 0;
            double max = int.MinValue;
            for (int i = 0; i < a; i++)
            {
                sum = 0;
                for (int j = 0; j < b; j++)
                {
                    if (mtrx[i, j] > 0)
                    {
                        sum += 1;
                    }
                }
                if (sum > max)
                {
                    max = sum;
                    I = i;
                }
            }
            return I;
        }
        public static int MaxMtrxC(double[,] mtrx, int a, int b)
        {
            int J = 0;
            double sum = 0;
            double max = int.MinValue;
            for (int i = 0; i < b; i++)
            {
                sum = 0;
                for (int j = 0; j < a; j++)
                {
                    if (mtrx[j, i] > 0)
                    {
                        sum += 1;
                    }
                }
                if (sum > max)
                {
                    max = sum;
                    J = i;
                }
            }
            return J;
        }
        public static double[,] DelLine(double[,] mtrx, int a, int b, int I)
        {
            double[,] mtrx1 = new double[a - 1, b];
            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    mtrx1[i, j] = mtrx[i, j];
                }
            }
            for (int i = I; i < a - 1; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    mtrx1[i, j] = mtrx[i + 1, j];
                }
            }
            return mtrx1;
        }
        public static int CompareMinMax(int Imax, int Imin)
        {
            if (Imax == Imin)
            {
                return 0;
            }
            if (Imax > Imin)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public static int[] MinMtrx(double[,] mtrx, int a, int b)
        {
            double min = int.MaxValue;
            int[] array = new int[2];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (mtrx[i, j] < min)
                    {
                        min = mtrx[i, j];
                        array[1] = j;
                        array[0] = i;
                    }
                }
            }
            return array;
        }
        public static double[,] RemovAColumnWithout0(double[,] mtrx, int a, int b)
        {
            int c = 0;
            int c1 = 0;
            int k = 0;
            for (int j = 0; j < b; j++)
            {
                c = 0;
                for (int i = 0; i < a; i++)
                {
                    if ((mtrx[i, j] == 0))
                    {
                        c += 1;
                    }
                }
                if (c == 0)
                {
                    c1++;
                }
            }
            double[,] mtrx1 = new double[a, b - c1];
            for (int j = 0; j < b - c1; j++)
            {
                c = 0;
                for (int i = 0; i < a; i++)
                {
                    if ((mtrx[i, j] == 0))
                    {
                        c += 1;
                    }
                }
                if (c == 0)
                {
                    k++;
                }
                for (int i = 0; i < a; i++)
                {
                    mtrx1[i, j] = mtrx[i, j + k];
                }
            }
            output(mtrx1, a, b - c1);
            return mtrx1;
        }
        public static int MinMtrxLine(double[,] mtrx, int a, int b)
        {
            int I = 0;
            double s = 0;
            double max = int.MinValue;
            for (int i = 0; i < a; i++)
            {
                s = 0;
                for (int j = 0; j < b; j++)
                {
                    if (mtrx[i, j] < 0)
                    {
                        s += 1;
                    }
                }
                if (s > max)
                {
                    max = s;
                    I = i;
                }
            }
            return I;
        }
        public static int SwapLines(double[,] mtrx, double[,] mtrx1, int a, int b, int I, int I1)
        {
            double[] array = new double[b];
            for (int j = 0; j < b; j++)
            {
                array[j] = mtrx[I, j];
            }
            for (int j = 0; j < b; j++)
            {
                mtrx[I, j] = mtrx1[I1, j];
            }
            for (int j = 0; j < b; j++)
            {
                mtrx1[I1, j] = array[j];
            }
            output(mtrx, a, b);
            output(mtrx1, a, b);
            return I;
        }
        public static void Main(string[] args)
        {
            #region 1
            Console.WriteLine("Задание 1: ");
            int n = 5;
            int m = 6;
            double[,] mtrx = new double[n, m];
            Console.WriteLine($"Введите матрицу - Количество строк: {n}; Количество элементов в строке: {m}");
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            int a = 3;
            int b = 5;
            double[,] mtrx1 = new double[a, b];
            Console.WriteLine($"Введите матрицу - Количество строк: {a}; Количество элементов в строке: {b}");
            for (int i = 0; i < a; i++)
            {
                string str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < b; j++)
                {
                    mtrx1[i, j] = arr[j];
                }
            }
            int[] arr1 = MaxMtrx(mtrx, n, m);
            int[] arr2 = MaxMtrx(mtrx1, a, b);
            double q = mtrx[arr1[0], arr1[1]];
            mtrx[arr1[0], arr1[1]] = mtrx1[arr2[0], arr2[1]];
            mtrx1[arr2[0], arr2[1]] = q;
            Console.WriteLine("Итоговые матрицы");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(mtrx1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion
            Console.WriteLine();

            #region 7
            Console.WriteLine("Задание 7: ");
            n = 4;
            m = 5;
            mtrx = new double[n, m];
            Console.WriteLine($"Введите матрицу - Количество строк: {n}; Количество элементов в строке: {m}");
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            a = 5;
            b = 6;
            mtrx1 = new double[a, b];
            Console.WriteLine($"Введите матрицу - Количество строк: {a}; Количество элементов в строке: {b}");
            for (int i = 0; i < a; i++)
            {
                string str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < b; j++)
                {
                    mtrx1[i, j] = arr[j];
                }
            }
            int I = MaxMtrxLine(mtrx, n, m);
            int J = MaxMtrxC(mtrx1, a, b);
            double[,] mtrx2 = new double[n + 1, m];
            double[] arr3 = new double[a];
            for (int i = 0; i < n + 1; i++)
            {
                arr3[i] = mtrx1[i, J];
            }
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i <= I)
                    {
                        mtrx2[i, j] = mtrx[i, j];
                    }
                    if (i == (I + 1))
                    {
                        mtrx2[i, j] = arr3[j];
                    }
                    if (i > (I + 1))
                    {
                        mtrx2[i, j] = mtrx[i - 1, j];
                    }

                }
            }
            Console.WriteLine(I);
            Console.WriteLine("Итоговая матрица");
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mtrx2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion
            Console.WriteLine();

            #region 13
            Console.WriteLine("Задание 13: ");
            Console.WriteLine("Введите количество строк в матрице: ");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Введите количество элементов в строке матрицы: ");
            int.TryParse(Console.ReadLine(), out m);
            mtrx = new double[n, m];
            if (n - 1 >= 0)
            {
                mtrx1 = new double[n - 1, m];
            }
            if (n - 2 >= 0)
            {
                mtrx2 = new double[n - 2, m];
            }
            Console.WriteLine($"Введите матрицу - Количество строк: {n}; Количество элементов в строке: {m}");
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            arr1 = MaxMtrx(mtrx, n, m);
            arr2 = MinMtrx(mtrx, n, m);
            I = arr1[0];
            int I1 = arr2[0];
            if (n > 0)
            {
                if (I == I1)
                {
                    mtrx1 = DelLine(mtrx, n, m, I);
                    output(mtrx1, n - 1, m);
                }
                if (I < I1)
                {
                    I1 -= 1;
                    mtrx1 = DelLine(mtrx, n, m, I);
                    mtrx2 = DelLine(mtrx1, n - 1, m, I1);
                    output(mtrx2, n - 2, m);
                }
                if (I > I1)
                {
                    mtrx1 = DelLine(mtrx, n, m, I);
                    mtrx2 = DelLine(mtrx1, n - 1, m, I1);
                    output(mtrx2, n - 2, m);
                }
            }
            #endregion
            Console.WriteLine();

            #region 20
            Console.WriteLine("Задание 20: ");
            Console.WriteLine("Введите количество строк в матрице: ");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Введите количество элементов в строке матрицы: ");
            int.TryParse(Console.ReadLine(), out m);
            mtrx = new double[n, m];
            Console.WriteLine($"Введите матрицу - Количество строк: {n}; Количество элементов в строке: {m}");
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            Console.WriteLine("Введите количество строк в матрице: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите количество элементов в строке матрицы: ");
            int.TryParse(Console.ReadLine(), out b);
            mtrx1 = new double[a, b];
            Console.WriteLine($"Введите матрицу - Количество строк: {a}; Количество элементов в строке: {b}");
            for (int i = 0; i < a; i++)
            {
                string str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < b; j++)
                {
                    mtrx1[i, j] = arr[j];
                }
            }
            RemovAColumnWithout0(mtrx, n, m);
            RemovAColumnWithout0(mtrx1, a, b);
            #endregion
            Console.WriteLine();

            #region 26
            Console.WriteLine("Задание 26: ");
            Console.WriteLine("Введите количество строк в матрице: ");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Введите количество элементов в строке матрицы: ");
            int.TryParse(Console.ReadLine(), out m);
            mtrx = new double[n, m];
            Console.WriteLine($"Введите матрицу - Количество строк: {n}; Количество элементов в строке: {m}");
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = arr[j];
                }
            }
            mtrx1 = new double[n, m];
            Console.WriteLine($"Введите матрицу - Количество строк: {n}; Количество элементов в строке: {m}");
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                double[] arr = str.Split(' ').Select(double.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    mtrx1[i, j] = arr[j];

                }
            }
            Console.WriteLine();
            I = MinMtrxLine(mtrx, n, m);
            I1 = MinMtrxLine(mtrx1, n, m);
            Console.WriteLine(I + " " + I1);
            SwapLines(mtrx, mtrx1, n, m, I, I1);
            #endregion
        }
    }
}
