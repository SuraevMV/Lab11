using System;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные:");
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            LineSolve lineSolve = new LineSolve(k, b);
            Console.WriteLine(lineSolve.Root());
            Console.ReadKey();
        }
        struct LineSolve
        {
            public double k;
            public double b;
            public LineSolve(double f1, double f2)
            {
                this.k = f1;
                this.b = f2;
            }
            public string Root()
            {
                return $"Решение: {-b / k}";
            }
        }
    }
}
