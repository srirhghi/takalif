using System;
class Program
{
    static void Main(string[] args)
    {
        int x;
        int y;
        Console.WriteLine("Enter the x: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the y ");
        y = Convert.ToInt32(Console.ReadLine());
        Double a;
        a = Math.Pow(x, 5);
        Double b;
        b = Math.Pow(x, 4);
        Double c;
        c = a + 2 * (b);
        Double d;
        d = Math.Pow(y, 2) - 7;
        Console.WriteLine(c * d);
    }
}