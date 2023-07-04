using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int m = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            if (0 <= n && n <= 600000)
            {
                m = (10 * n) / 100;
                Console.WriteLine("maliat to barabar ba : " + m);
            }
            if (600001 <= n && n <= 1000000)
            {
                m = (15 * n) / 100;
                Console.WriteLine("maliat to barabar ba : " + m);
            }
            if (1000001 <= n && n <= 2000000)
            {
                m = (20 * n) / 100;
                Console.WriteLine("maliat to barabar ba : " + m);
            }
        }
    }
}
