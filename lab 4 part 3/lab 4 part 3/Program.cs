using System;

namespace lab_4_part_3
{
    class Program
    {
        static double Method(double x)
        {
            double a = (-1 + x) / 2;
                return a;
        }
        static double Rec(double k)
        {
            if (k == -1)
                return 1;
            else
                return Method(k) * Rec(k - 1);

        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double s = Rec(n);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}