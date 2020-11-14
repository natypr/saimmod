using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public static class Distribution
    {
        // Равномерное распределение
        public static List<double> UniformDistribution(List<double> rand, int N, double a, double b)
        {
            var result = new List<double>(N);

            for (int i = 0; i < N; i++)
                result.Insert(i, a + (b - a) * rand.ElementAt(i));

            return result;
        }

        // Гауссовское распределение
        public static List<double> GaussDistribution(List<double> rand, int N, double m, double sko)
        {
            var result = new List<double>(N);
            double n = 6;
            for (int i = 0; i < N; i++)
            {
                double tmp = 0;
                for (int j = 0; j < n; j++)
                    tmp += rand.ElementAt((i + j) % N);

                result.Insert(i, m + sko * Math.Sqrt(12.0 / n) * (tmp - (double)n / 2));
            }
            return result;
        }

        // Экспоненциальное распределение
        public static List<double> ExponentialDistribution(List<double> rand, int N, double λ)
        {
            var result = new List<double>(N);
            for (int i = 0; i < N; i++)
                result.Insert(i, -Math.Log(rand.ElementAt(i)) / λ);
            return result;
        }

        // Гамма-распределение
        public static List<double> GammaDistribution(List<double> rand, int N, double η, double λ)
        {
            var result = new List<double>(N);
            for (int i = 0; i < N; i++)
            {
                double tmp = 1;
                for (int j = 0; j < η; j++)
                    tmp *= rand.ElementAt((i + j) % N);

                result.Insert(i, -Math.Log(tmp) / λ);
            }
            return result;
        }

        // Треугольное распределение
        public static List<double> TriangleDistribution(List<double> rand, int N, double a, double b)
        {
            var result = new List<double>(N);

            for (int i = 0; i < N; i++)
            {
                double R1 = rand.ElementAt(i);
                double R2 = rand.ElementAt(i + 1);
                result.Insert(i, a + (b - a) * Math.Max(R1, R2));
            }
            return result;
        }

        // Распределение Симпсона
        public static List<double> SimpsonDistribution(List<double> rand, int N, double a, double b)
        {
            var result = new List<double>(N);

            for (int i = 0; i < N; i++)
                result.Insert(i, a / 2 + (b / 2 - a / 2) * rand.ElementAt(i) + a / 2 + (b / 2 - a / 2) * rand.ElementAt((i + 1) % N));

            return result;
        }
    }
}
