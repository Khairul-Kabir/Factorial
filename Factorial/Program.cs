using System;

namespace Factorial
{
    class Program
    {
        static int[] arr;
        static int j = 0;
        static void Main(string[] args)
        {
            //Program program = new Program();
            Console.Write("Please input a number for get factorial: ");
            int getNumber = Convert.ToInt32(Console.ReadLine());
            arr = new int[getNumber];
            foo(getNumber);
            //Console.WriteLine(res * res);
            int result = getNumber;
            
            for (int i = 0; i < arr.Length-1; i++)
            {
                result *= arr[i];
            }
            Console.WriteLine("\nFactorial is: "+ result);
        }

        public static dynamic foo(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                Console.Write(n - 1 + ",");
                arr[j] = (n - 1);
                j++;
                return foo(n - 1);
            }
        }
    }
}
