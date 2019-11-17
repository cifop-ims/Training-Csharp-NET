namespace StructLab
{
    public struct Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Display()
        {
            System.Console.WriteLine("X:" + X + ",Y=" + Y);
        }
    }
}
