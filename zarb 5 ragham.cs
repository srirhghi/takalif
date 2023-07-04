using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int p = 1;
            while (n > 0)
            {
                int raghan = n % 10;
                if (raghan > 5)
                {
                    p *= raghan;
                }
                n /= 10;
            }
            Console.WriteLine("zarb argham balatar 5 mosavi ast ba " + p);
        }
    }
}