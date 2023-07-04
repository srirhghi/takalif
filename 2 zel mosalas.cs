namespace zele
{
    class test1
    {
        private int t1;
        private int t2;
        private int t3;
        public int input1
        {
            get { return t1; }
            set { t1 = value; }
        }
        public int input2
        {
            get { return t2; }
            set { t2 = value; }
        }
        public int input3
        {
            get { return t3; }
            set { t3 = value; }
        }
        public test1() { }
        public test1(int t1, int t2, int t3)
        {
            input1 = t1;
            input2 = t2;
            input3 = t3;
        }// تابع سازنده

        public void calc()
        {
            double b;
            double c;
            double d;
            int t1 = input1;
            int t2 = input2;
            int t3 = input3;
            c = Math.Cos(t3);
            b = (Math.Pow(t1, 2) + Math.Pow(t2, 2)) - (2 * t1 * t2 * c);
            d = Math.Sqrt(b);
            Console.WriteLine(d);
        }
        class test2
        {
            static void Main(string[] args)
            {
                int t1 = Convert.ToInt32(Console.ReadLine());
                int t2 = Convert.ToInt32(Console.ReadLine());
                int t3 = Convert.ToInt32(Console.ReadLine());
                test1 ts = new test1(t1, t2, t3);
                ts.calc();
            }
        }
    }
}