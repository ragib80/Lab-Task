using System;

namespace ProblemSolve4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 8;
            int c = 6;
            int r = -a + b * c;
            Console.WriteLine("result of problem a is: " + r);

            int a2 = 55;
            int b2 = 9;
            int r2 = (a2 + b2) % b2;
            Console.WriteLine("result of problem b is: " + r2);

           double a3 = 20;
            double b3 = -3;
            double c3 = 5;
            double d3 = 8;
            double r3 = a3 + b3 * c3 / d3;
            Console.WriteLine("result of problem c is: " + r3);

            double a4 = 5;
            double b4 = 15;
            double c4 = 3;
            double d4 = 2;
            double e4 = 8;
            double r4 = a4 + b4 / c4 * d4 - e4 % c4;
            Console.WriteLine("result of problem d is: " + r4);

        }
    }
}
