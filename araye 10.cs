using System;
namespace Tamrin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            Console.WriteLine("enter:");
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] arr2 = RemoveMinMax(arr1);

            Console.WriteLine("new :");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + "  ");
            }
            Console.ReadKey();
        }
        public static int[] RemoveMinMax(int[] arr)
        {
            int max1 = arr[0];
            int max2 = arr[0];
            int min1 = arr[0];
            int min2 = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                else if (arr[i] > max2)
                {
                    max2 = arr[i];
                }
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min1)
                {
                    min2 = min1;
                    min1 = arr[i];
                }
                else if (arr[i] < min2)
                {
                    min2 = arr[i];
                }
            }
            int[] arr2 = new int[arr.Length - 8];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != min1 && arr[i] != min2 && arr[i] != max1 && arr[i] != max2)
                {
                    arr2[j] = arr[i];
                    j++;
                }
            }
            return arr2;
        }
    }
}