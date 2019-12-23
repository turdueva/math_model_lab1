using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Sqrsqrt(x));
            Console.WriteLine("***********************");
            Console.WriteLine(Mysqrsqrt(x));
        }
        public static double Rel_error(double x0, double x)
        {
            return Math.Abs(x0 - x) / Math.Abs(x0);
        }
        public static double Divmult(double x, double d = 3.14, int n = 52)
        {
            for (int i = 0; i < n; ++i)
            {
                x /= d;
            }
            for (int i = 0; i < n; ++i)
            {
                x *= d;
            }
            return x;
        }

        public static double Sqrsqrt(double x, int n = 52)
        {
            double[] x1 = new double[52];
            for (int i = 0; i < n; ++i)
            {
                x = Math.Sqrt(x);
                x1[i] = x;
            }
            for (int i = 0; i < n; ++i)
            {
                x *= x1[i];
            }
            return x;
        }
        public static double Mysqrsqrt(double x, int n = 52)
        {
            x = Math.Log(x);
            for (int i = 0; i < n; ++i)
            {
                x *= (1.0 / 2.0);
            }
            for (int i = 0; i < n; ++i)
                x *= 2.0;
            x = Math.Exp(x);
            return x;
        }
        public static void Test(double first, double last, int nsteps)
        {
            double step= (last - first) / nsteps ;
            List<double> x0 = new List<double>() { first };
            double curr=first;
            for (int i = 0; i < nsteps; ++i)
            {
                curr += step;
                x0.Add(curr);
            }
            List<double> x = new List<double>();
            for (int i = 0; i < nsteps; ++i)
            {
                x.Add(Divmult(x0[i]));
            }
            List<double> rel = new List<double>();
            for (int i = 0; i < nsteps; ++i)
            {
                rel.Add(Rel_error(x0[i], x[i]));
            }
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*****************************************");
            foreach (var item in x0)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*******************************************");
            foreach (var item in rel)
            {
                Console.WriteLine(item);
            }
        }
        public static void Tests(double first, double last, int nsteps)
        {
            double step = (last - first) / nsteps;
            List<double> x0 = new List<double>() { first };
            double curr = first;
            for (int i = 0; i < nsteps; ++i)
            {
                curr += step;
                x0.Add(curr);
            }
            List<double> x = new List<double>();
            for (int i = 0; i < nsteps; ++i)
            {
                x.Add(Sqrsqrt(x0[i]));
            }
            List<double> rel = new List<double>();
            for (int i = 0; i < nsteps; ++i)
            {
                rel.Add(Rel_error(x0[i], x[i]));
            }
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*****************************************");
            foreach (var item in x0)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*******************************************");
            foreach (var item in rel)
            {
                Console.WriteLine(item);
            }
        }
        public static void Testmy(double first, double last, int nsteps)
        {
            double step = (last - first) / nsteps;
            List<double> x0 = new List<double>() { first };
            double curr = first;
            for (int i = 0; i < nsteps; ++i)
            {
                curr += step;
                x0.Add(curr);
            }
            List<double> x = new List<double>();
            for (int i = 0; i < nsteps; ++i)
            {
                x.Add(Mysqrsqrt(x0[i]));
            }
            List<double> rel = new List<double>();
            for (int i = 0; i < nsteps; ++i)
            {
                rel.Add(Rel_error(x0[i], x[i]));
            }
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*****************************************");
            foreach (var item in x0)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*******************************************");
            foreach (var item in rel)
            {
                Console.WriteLine(item);
            }
        }
    }
}
