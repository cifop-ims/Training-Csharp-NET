namespace ClassLab
{
    partial class Program
    {
        public  class Calc
        {
            public static int Total;
            public int Sum;
            public void Add(int a, int b)
            {
                Sum = a + b;
            }

            public static void DoSomthing()
            {

            }
            public static int Addv2(int a, int b)
            {
                //DoSomthing();
                return a + b;
            }
        }
    }
}
