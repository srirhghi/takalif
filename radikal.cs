using System;
namespace NumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int b = Math.Abs(y);
            int c = Math.Abs(x - y);
            Console.Write(Math.Sqrt(c * b));
        }
    }
}
