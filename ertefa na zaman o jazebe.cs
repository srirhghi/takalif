namespace jazeb
{
    class test1
    {
        private int t1;
        public int input1
        {
            get { return t1; }
            set { t1 = value; }

        }
        public test1() { }
        public test1(int t1)
        {
            input1 = t1;
        }
        public void calc()
        {
            int t = input1;
            double h = 0.5 * t * 9.8;
            Console.WriteLine(h);
        }
        class test2
        {
            static void Main(string[] args)
            {
                int t;
                t = Convert.ToInt32(Console.ReadLine());
                test1 ts = new test1(t);
                ts.calc();
            }
        }
    }
}