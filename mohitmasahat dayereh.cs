using System;

namespace ConsoleApp2
{
    class Program
    {
        static int f(int n)
        {
            if (n == 1)
                return 2;
            else
                return 2 * f(n - 1) + 1;
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
                Console.WriteLine("f({0}) = {1}", i, f(i));
        }
    }
}