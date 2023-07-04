using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintX(n);
        }

        static void PrintX(int num)
        {
            for (int i = 0; 1 < num; i++)
            {
                Console.WriteLine("XXXXXXXXXX");
            }
        }
    }
}