using System;

namespace ProblemSolve5n6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 500;
            double b = 200;
            double sum = a + b;
            double mul = a * b;
            double sub = a - b;
            double div = a / b;
            double rem = a % b;

            Console.WriteLine("Number 1 is : " + a);
            Console.WriteLine("Number 2 is : " + b);
            Console.WriteLine("Sum is : " + sum);
            Console.WriteLine("multiply is : " + mul);
            Console.WriteLine("substraction is : " + sub);
            Console.WriteLine("division is  : " + div);
            Console.WriteLine("remainder is : " + rem);   //solution of problem 5


            Console.WriteLine(" ");


            double a2 = 25.5;
            double b2 = 3.5;
            double c2 = 40.5;
            double d2 = 4.5;
            double r = (a2 * b2 - b2 * b2) / (c2 - d2);
            Console.WriteLine("solution of problem 6 is  : " + r);   //solution of problem 6


        }

    }
}
