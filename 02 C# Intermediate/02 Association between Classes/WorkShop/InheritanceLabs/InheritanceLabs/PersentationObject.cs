using System;

namespace InheritanceLabs
{
    public class PersentationObject
    {
        protected int Width;
        private int Height;

        protected void Copy()
        {
            Console.WriteLine("Item was copied !");
        }
    }

    public class PersentationObjectV2
    {
        public int Widthv2;
        public int Heightv2;

        public void Copyv2()
        {
            Console.WriteLine("Item was copied !");
        }
    }
}
