using System;

namespace Melyakina.L4.N3
{
    class Program
    {

        static double Method(double a)
        {
            double s = (a + 1) / 15;
            return s;
        }
        static double Rec(double k)
        {


            if (k == -1)
            {
                return 1;
            }
            else
            {
                return Method(k) * Rec(k - 1);
            }


        }
        static void Main(string[] args)
        {


            int n = Convert.ToInt32(Console.ReadLine());
            double s = Rec(n);


            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}

