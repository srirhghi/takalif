namespace fardzoj
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
        public void chek()
        {
            int n = input1;
            if (n % 2 == 0)
            {
                Console.WriteLine("zoj");
            }
            if (n % 2 != 0)
            {
                consol.writeline("fard");
            }
        }
    }
    class test2
    {
        static void Main()
        {
            int in1 = Convert.ToInt32(Console.ReadLine());
            Test1 ts = new Test1(in1);
            ts.chek();
        }


    }
}