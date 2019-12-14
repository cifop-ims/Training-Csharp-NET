using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncastingLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            //

            //var circle = new Circle();
            //circle.Diameter
            //Shape shape = new Circle();
            //shape.Name = nameof(Circle);
            //Circle circle = (Circle)shape;
            //Console.WriteLine(circle.Name);
            //Square squarre = (Square)shape;
            Shape shape = new Circle();
            shape.Name = "Shape";
            //v1
            //Circle circle = shape as Circle;
            //if (circle != null)
            //{
            //    Console.WriteLine(circle.Name);
            //}
            //v2
            //if (shape is Circle)
            //{
            //    Circle circle = (Circle)shape;
            //    Console.WriteLine(circle.Name);
            //}

        }
    }
}
