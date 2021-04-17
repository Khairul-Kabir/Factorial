using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a number for get factorial: ");
            int getNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nFactorial is:"+ foo(getNumber));
        }

        public static dynamic foo(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n* foo(n - 1);
            }
        }
    }
}
