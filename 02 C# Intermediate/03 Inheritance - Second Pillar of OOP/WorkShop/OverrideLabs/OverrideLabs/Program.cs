using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = new Shape();
            DoDraw(shape);
            var circle = new Circle();
            //circle.Draw();
            DoDraw(circle);
            var image = new Image();
            //image.Draw();
            DoDraw(image);
        }

        static void DoDraw(Shape shape)
        {
            shape.Draw();
        }
    }
}
