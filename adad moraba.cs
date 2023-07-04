using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (Math.Sqrt(n) % 1 == 0)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}