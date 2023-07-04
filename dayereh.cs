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
            set
            {
                if (value > 0)
                {
                    input1 = value;
                }
            }
        }

        public Test1() { } // تابع مخرب
        public Test1(int in1)
        {
            Input1 = in1;

        }
        public void masahat()
        {
            int r = Input1;
            double s = Math.Pow(r, 2) * 3;
            Console.WriteLine(s);

        }
        public void mohit()
        {
            int r = Input1;
            double m = (2 * r) * 3;
            Console.WriteLine(m);
        }

        class Test2
        {
            static void Main(string[] args)
            {
                int in1 = Convert.ToInt32(Console.ReadLine());
                Test1 ts = new Test1(in1);
                ts.masahat();
                ts.mohit();
            }
        }
    }
}