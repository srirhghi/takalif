using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masahatandmohite
{
    class Test1
    {
        private int input1;
        public int Input1
        {

            get { return input1; }
            set { input1 = value; }


        }

        public Test1() { } // تابع مخرب
        public Test1(int in1)
        {
            Input1 = in1;

        }
        public void fact()
        {
            int n = Input1;
            int fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);

        }


        class Test2
        {
            static void Main(string[] args)
            {
                int in1 = Convert.ToInt32(Console.ReadLine());
                Test1 ts = new Test1(in1);
                ts.fact();
            }
        }
    }
}