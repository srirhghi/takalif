using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int m = Calc(n);

            if (m == -1)
                Console.WriteLine("nadari");
            else
                Console.WriteLine("maliat to barabar ba : " + m);
            static int Calc(int n)
            {
                if (0 <= n && n <= 483000)
                    return -1;
                if (483001 <= n && n <= 600000)
                    return (10 * n) / 100;
                if (600001 <= n && n <= 1000000)
                    return (15 * n) / 100;
                if (1000001 <= n && n <= 2000000)
                    return (20 * n) / 100;

                return -1;

            }
        }
    }
}